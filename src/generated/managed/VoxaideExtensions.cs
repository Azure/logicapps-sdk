//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voxaide
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoxaideActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<Ping> TestConnection()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Ping>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<ListReasonsResponse> ListReasons()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reasons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListReasonsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<CreateReasonResponse> CreateReason([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string[]> bodyquestions, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodydayOfWeek = null, [WorkflowExpression] Func<bool> bodysmsOnNoAnswer = null, [WorkflowExpression] Func<string> bodysmsMessage = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reasons";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydayOfWeek != null)
                {
                    if (bodydayOfWeek != null)
                    {
                        body["dayOfWeek"] = SourceExpressionConverter.ConvertToken(bodydayOfWeek);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["dayOfWeek"] = 1;
                    bodypropCount++;
                }

                bodypropCount++;
                body["questions"] = SourceExpressionConverter.ConvertToken(bodyquestions);
                if (bodysmsOnNoAnswer != null)
                {
                    if (bodysmsOnNoAnswer != null)
                    {
                        body["smsOnNoAnswer"] = SourceExpressionConverter.ConvertToken(bodysmsOnNoAnswer);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["smsOnNoAnswer"] = true;
                    bodypropCount++;
                }

                if (bodysmsMessage != null)
                {
                    body["smsMessage"] = SourceExpressionConverter.ConvertToken(bodysmsMessage);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateReasonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<GetReasonResponse> GetReason([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reasons/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetReasonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IWorkflowAction UpdateReason([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string[]> bodyquestions, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodydayOfWeek = null, [WorkflowExpression] Func<bool> bodysmsOnNoAnswer = null, [WorkflowExpression] Func<string> bodysmsMessage = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reasons/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydayOfWeek != null)
                {
                    if (bodydayOfWeek != null)
                    {
                        body["dayOfWeek"] = SourceExpressionConverter.ConvertToken(bodydayOfWeek);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["dayOfWeek"] = 1;
                    bodypropCount++;
                }

                bodypropCount++;
                body["questions"] = SourceExpressionConverter.ConvertToken(bodyquestions);
                if (bodysmsOnNoAnswer != null)
                {
                    if (bodysmsOnNoAnswer != null)
                    {
                        body["smsOnNoAnswer"] = SourceExpressionConverter.ConvertToken(bodysmsOnNoAnswer);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["smsOnNoAnswer"] = true;
                    bodypropCount++;
                }

                if (bodysmsMessage != null)
                {
                    body["smsMessage"] = SourceExpressionConverter.ConvertToken(bodysmsMessage);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<ListCallsResponse> ListCalls([WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> reasonId = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/calls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (reasonId != null)
                    callPayload.Queries["reasonId"] = SourceExpressionConverter.ConvertO(reasonId);
                callPayload.Queries["limit"] = Convert.ToString(50);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<ListCallsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<PlaceCallResponse> PlaceCall([WorkflowExpression] Func<string> bodyreasonId, [WorkflowExpression] Func<string> bodycontactphone, [WorkflowExpression] Func<string> bodycontactname = null, [WorkflowExpression] Func<string> bodycontactemail = null, [WorkflowExpression] Func<string> bodycontactexternalId = null, [WorkflowExpression] Func<string> bodyactivityId = null, [WorkflowExpression] Func<string> bodycontentpurpose = null, [WorkflowExpression] Func<string> bodycontentgreeting = null, [WorkflowExpression] Func<string> bodycontentgoodbye = null, [WorkflowExpression] Func<string[]> bodycontentquestions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["reasonId"] = SourceExpressionConverter.ConvertToken(bodyreasonId);
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (bodycontactname != null)
                {
                    contactObject["name"] = SourceExpressionConverter.ConvertToken(bodycontactname);
                    contactObjectpropCount++;
                }

                contactObjectpropCount++;
                contactObject["phone"] = SourceExpressionConverter.ConvertToken(bodycontactphone);
                if (bodycontactemail != null)
                {
                    contactObject["email"] = SourceExpressionConverter.ConvertToken(bodycontactemail);
                    contactObjectpropCount++;
                }

                if (bodycontactexternalId != null)
                {
                    contactObject["externalId"] = SourceExpressionConverter.ConvertToken(bodycontactexternalId);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["contact"] = contactObject;
                    bodypropCount++;
                }

                if (bodyactivityId != null)
                {
                    body["activityId"] = SourceExpressionConverter.ConvertToken(bodyactivityId);
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentpurpose != null)
                {
                    contentObject["purpose"] = SourceExpressionConverter.ConvertToken(bodycontentpurpose);
                    contentObjectpropCount++;
                }

                if (bodycontentgreeting != null)
                {
                    contentObject["greeting"] = SourceExpressionConverter.ConvertToken(bodycontentgreeting);
                    contentObjectpropCount++;
                }

                if (bodycontentgoodbye != null)
                {
                    contentObject["goodbye"] = SourceExpressionConverter.ConvertToken(bodycontentgoodbye);
                    contentObjectpropCount++;
                }

                if (bodycontentquestions != null)
                {
                    contentObject["questions"] = SourceExpressionConverter.ConvertToken(bodycontentquestions);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlaceCallResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<GetCallResponse> GetCall([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/calls/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCallResponse>(BuildSourceInput);
        }
    }

    public class VoxaideTriggers([ConnectionName] string connectionId)
    {
    }

    public class Ping
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("org")]
        public string Org { get; set; }
    }

    public class ListReasonsResponse
    {
        [JsonProperty("reasons")]
        public Reason[] Reasons { get; set; }
    }

    public class Reason
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dayOfWeek")]
        public int DayOfWeek { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }

        [JsonProperty("smsOnNoAnswer")]
        public bool SmsOnNoAnswer { get; set; }

        [JsonProperty("smsMessage")]
        public string SmsMessage { get; set; }

        [JsonProperty("contactCount")]
        public int ContactCount { get; set; }
    }

    public class CreateReasonResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetReasonResponse
    {
        [JsonProperty("reason")]
        public Reason Reason { get; set; }
    }

    public class ListCallsResponse
    {
        [JsonProperty("calls")]
        public Call[] Calls { get; set; }
    }

    public class Call
    {
        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("reasonId")]
        public string ReasonId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("outcome")]
        public string Outcome { get; set; }

        [JsonProperty("contact")]
        public CallContactType Contact { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("issueRaised")]
        public bool IssueRaised { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("durationSec")]
        public int DurationSec { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class CallContactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class PlaceCallResponse
    {
        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetCallResponse
    {
        [JsonProperty("call")]
        public Call Call { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Voxaide;

    public partial class WorkflowManagedActions
    {
        public VoxaideActions Voxaide(string connectionId) => new VoxaideActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VoxaideTriggers Voxaide(string connectionId) => new VoxaideTriggers(connectionId);
    }
}