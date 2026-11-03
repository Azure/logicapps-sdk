//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voxaide
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoxaideActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<Ping, ApiConnectionActionConfiguration> TestConnection()
        {
            return new DeferredBodyAction<Ping, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Ping>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<ListReasonsResponse, ApiConnectionActionConfiguration> ListReasons()
        {
            return new DeferredBodyAction<ListReasonsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reasons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListReasonsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<CreateReasonResponse, ApiConnectionActionConfiguration> CreateReason(Expression<Func<string>> bodyname, Expression<Func<string[]>> bodyquestions, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodydayOfWeek = null, Expression<Func<bool>> bodysmsOnNoAnswer = null, Expression<Func<string>> bodysmsMessage = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyquestions = WorkflowExpression.Compile(bodyquestions, nameof(bodyquestions), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydayOfWeek = WorkflowExpression.Compile(bodydayOfWeek, nameof(bodydayOfWeek), required: false);
            var __workflow_bodysmsOnNoAnswer = WorkflowExpression.Compile(bodysmsOnNoAnswer, nameof(bodysmsOnNoAnswer), required: false);
            var __workflow_bodysmsMessage = WorkflowExpression.Compile(bodysmsMessage, nameof(bodysmsMessage), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<CreateReasonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reasons";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydayOfWeek != null)
                {
                    if (__workflow_bodydayOfWeek != null)
                    {
                        body["dayOfWeek"] = ExpressionConverter.ConvertO(__workflow_bodydayOfWeek);
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
                body["questions"] = ExpressionConverter.ConvertO(__workflow_bodyquestions);
                if (__workflow_bodysmsOnNoAnswer != null)
                {
                    if (__workflow_bodysmsOnNoAnswer != null)
                    {
                        body["smsOnNoAnswer"] = ExpressionConverter.ConvertO(__workflow_bodysmsOnNoAnswer);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["smsOnNoAnswer"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodysmsMessage != null)
                {
                    body["smsMessage"] = ExpressionConverter.ConvertO(__workflow_bodysmsMessage);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateReasonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<GetReasonResponse, ApiConnectionActionConfiguration> GetReason(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetReasonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reasons/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetReasonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateReason(Expression<Func<string>> id, Expression<Func<string>> bodyname, Expression<Func<string[]>> bodyquestions, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodydayOfWeek = null, Expression<Func<bool>> bodysmsOnNoAnswer = null, Expression<Func<string>> bodysmsMessage = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyquestions = WorkflowExpression.Compile(bodyquestions, nameof(bodyquestions), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydayOfWeek = WorkflowExpression.Compile(bodydayOfWeek, nameof(bodydayOfWeek), required: false);
            var __workflow_bodysmsOnNoAnswer = WorkflowExpression.Compile(bodysmsOnNoAnswer, nameof(bodysmsOnNoAnswer), required: false);
            var __workflow_bodysmsMessage = WorkflowExpression.Compile(bodysmsMessage, nameof(bodysmsMessage), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reasons/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydayOfWeek != null)
                {
                    if (__workflow_bodydayOfWeek != null)
                    {
                        body["dayOfWeek"] = ExpressionConverter.ConvertO(__workflow_bodydayOfWeek);
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
                body["questions"] = ExpressionConverter.ConvertO(__workflow_bodyquestions);
                if (__workflow_bodysmsOnNoAnswer != null)
                {
                    if (__workflow_bodysmsOnNoAnswer != null)
                    {
                        body["smsOnNoAnswer"] = ExpressionConverter.ConvertO(__workflow_bodysmsOnNoAnswer);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["smsOnNoAnswer"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodysmsMessage != null)
                {
                    body["smsMessage"] = ExpressionConverter.ConvertO(__workflow_bodysmsMessage);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<ListCallsResponse, ApiConnectionActionConfiguration> ListCalls(Expression<Func<string>> since = null, Expression<Func<string>> status = null, Expression<Func<string>> reasonId = null, Expression<Func<int>> limit = null)
        {
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_reasonId = WorkflowExpression.Compile(reasonId, nameof(reasonId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListCallsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/calls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_reasonId != null)
                    callPayload.Queries["reasonId"] = ExpressionConverter.Convert(__workflow_reasonId);
                callPayload.Queries["limit"] = Convert.ToString(50);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ListCallsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<PlaceCallResponse, ApiConnectionActionConfiguration> PlaceCall(Expression<Func<string>> bodyreasonId, Expression<Func<string>> bodycontactphone, Expression<Func<string>> bodycontactname = null, Expression<Func<string>> bodycontactemail = null, Expression<Func<string>> bodycontactexternalId = null, Expression<Func<string>> bodyactivityId = null, Expression<Func<string>> bodycontentpurpose = null, Expression<Func<string>> bodycontentgreeting = null, Expression<Func<string>> bodycontentgoodbye = null, Expression<Func<string[]>> bodycontentquestions = null)
        {
            var __workflow_bodyreasonId = WorkflowExpression.Compile(bodyreasonId, nameof(bodyreasonId), required: true);
            var __workflow_bodycontactphone = WorkflowExpression.Compile(bodycontactphone, nameof(bodycontactphone), required: true);
            var __workflow_bodycontactname = WorkflowExpression.Compile(bodycontactname, nameof(bodycontactname), required: false);
            var __workflow_bodycontactemail = WorkflowExpression.Compile(bodycontactemail, nameof(bodycontactemail), required: false);
            var __workflow_bodycontactexternalId = WorkflowExpression.Compile(bodycontactexternalId, nameof(bodycontactexternalId), required: false);
            var __workflow_bodyactivityId = WorkflowExpression.Compile(bodyactivityId, nameof(bodyactivityId), required: false);
            var __workflow_bodycontentpurpose = WorkflowExpression.Compile(bodycontentpurpose, nameof(bodycontentpurpose), required: false);
            var __workflow_bodycontentgreeting = WorkflowExpression.Compile(bodycontentgreeting, nameof(bodycontentgreeting), required: false);
            var __workflow_bodycontentgoodbye = WorkflowExpression.Compile(bodycontentgoodbye, nameof(bodycontentgoodbye), required: false);
            var __workflow_bodycontentquestions = WorkflowExpression.Compile(bodycontentquestions, nameof(bodycontentquestions), required: false);
            return new DeferredBodyAction<PlaceCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["reasonId"] = ExpressionConverter.ConvertO(__workflow_bodyreasonId);
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (__workflow_bodycontactname != null)
                {
                    contactObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycontactname);
                    contactObjectpropCount++;
                }

                contactObjectpropCount++;
                contactObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodycontactphone);
                if (__workflow_bodycontactemail != null)
                {
                    contactObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontactemail);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactexternalId != null)
                {
                    contactObject["externalId"] = ExpressionConverter.ConvertO(__workflow_bodycontactexternalId);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["contact"] = contactObject;
                    bodypropCount++;
                }

                if (__workflow_bodyactivityId != null)
                {
                    body["activityId"] = ExpressionConverter.ConvertO(__workflow_bodyactivityId);
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (__workflow_bodycontentpurpose != null)
                {
                    contentObject["purpose"] = ExpressionConverter.ConvertO(__workflow_bodycontentpurpose);
                    contentObjectpropCount++;
                }

                if (__workflow_bodycontentgreeting != null)
                {
                    contentObject["greeting"] = ExpressionConverter.ConvertO(__workflow_bodycontentgreeting);
                    contentObjectpropCount++;
                }

                if (__workflow_bodycontentgoodbye != null)
                {
                    contentObject["goodbye"] = ExpressionConverter.ConvertO(__workflow_bodycontentgoodbye);
                    contentObjectpropCount++;
                }

                if (__workflow_bodycontentquestions != null)
                {
                    contentObject["questions"] = ExpressionConverter.ConvertO(__workflow_bodycontentquestions);
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

                return new ApiConnectionAction<PlaceCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<GetCallResponse, ApiConnectionActionConfiguration> GetCall(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calls/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCallResponse>(callPayload);
            });
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