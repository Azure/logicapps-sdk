//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognizantautomationc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognizantautomationcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<ActivityActionStatusResponse> ActivityActionStatus([WorkflowExpression] Func<int> activityId, [WorkflowExpression] Func<int> activityActionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}/actions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(activityId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(activityActionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("ExecutedActionView");
                return callPayload;
            }

            return new ApiConnectionAction<ActivityActionStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<TriggerActionResponse> TriggerAction([WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<int> bodyactionId, [WorkflowExpression] Func<int> bodyactivityId, [WorkflowExpression] Func<string> bodycIId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerActionExternal");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ActionId"] = SourceExpressionConverter.ConvertToken(bodyactionId);
                bodypropCount++;
                body["ActivityId"] = SourceExpressionConverter.ConvertToken(bodyactivityId);
                bodypropCount++;
                body["CIId"] = SourceExpressionConverter.ConvertToken(bodycIId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TriggerActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<ReadActivityAttributeResponse> ReadActivityAttribute([WorkflowExpression] Func<string> activityId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}/attributes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("ReadAttributes");
                return callPayload;
            }

            return new ApiConnectionAction<ReadActivityAttributeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<SetActivityAdditionalAttributeResponse> SetActivityAdditionalAttribute([WorkflowExpression] Func<string> activityId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}/attributes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("InsertUpdate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetActivityAdditionalAttributeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<FetchISExecutionStatusResponse> FetchISExecutionStatus([WorkflowExpression] Func<string> activityId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerIsStatusApi");
                return callPayload;
            }

            return new ApiConnectionAction<FetchISExecutionStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<TriggerISResponse> TriggerIS([WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<string> bodyskillId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerIS");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["SkillId"] = SourceExpressionConverter.ConvertToken(bodyskillId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TriggerISResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<UpdateActionOutputResponse> UpdateActionOutput([WorkflowExpression] Func<string> activityActionId, [WorkflowExpression] Func<string> bodyoutput, [WorkflowExpression] Func<bodyexecutionStatusInput> bodyexecutionStatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activityaction/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityActionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["output"] = SourceExpressionConverter.ConvertToken(bodyoutput);
                if (bodyexecutionStatus != null)
                {
                    body["ActionExecutionStatus"] = SourceExpressionConverter.Convert(bodyexecutionStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateActionOutputResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<LinkAsChildActivityResponse> LinkAsChildActivity([WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<int> bodychildId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/portal/ino/api/v3/collab/activity/{0}/v1/link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("AddChild");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ChildId"] = SourceExpressionConverter.ConvertToken(bodychildId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkAsChildActivityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateActivityResponse> CreateActivity([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodycIId, [WorkflowExpression] Func<string> bodycustomerId, [WorkflowExpression] Func<string> bodyrunId = null, [WorkflowExpression] Func<string> bodyworkflowRunURL = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyassignmentGroup = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/portal/ino/api/v3/collab/activity";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrunId != null)
                {
                    if (bodyrunId != null)
                    {
                        body["pa_run_id"] = SourceExpressionConverter.ConvertToken(bodyrunId);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pa_run_id"] = "@{workflow().run.name}";
                    bodypropCount++;
                }

                if (bodyworkflowRunURL != null)
                {
                    if (bodyworkflowRunURL != null)
                    {
                        body["pa_run_name"] = SourceExpressionConverter.ConvertToken(bodyworkflowRunURL);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pa_run_name"] = "@{concat('https://india.flow.microsoft.com/manage/environments/',workflow().tags.environmentName,'/flows/',workflow().name,'/runs/',workflow().run.name)}";
                    bodypropCount++;
                }

                body["SourceId"] = 11;
                bodypropCount++;
                bodypropCount++;
                body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["CIId"] = SourceExpressionConverter.ConvertToken(bodycIId);
                if (bodyuserId != null)
                {
                    body["OwnerId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyassignmentGroup != null)
                {
                    body["AssignmentGroup"] = SourceExpressionConverter.ConvertToken(bodyassignmentGroup);
                    bodypropCount++;
                }

                bodypropCount++;
                body["CustomerId"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateActivityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateaActivityLogResponse> CreateaActivityLog([WorkflowExpression] Func<int> bodyactivityId, [WorkflowExpression] Func<string> bodylogMessage, [WorkflowExpression] Func<int> bodyuserId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/portal/ino/api/v3/collab/activity/0/logs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("NewRecord");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ActivityId"] = SourceExpressionConverter.ConvertToken(bodyactivityId);
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodylogMessage);
                bodypropCount++;
                body["CreatedById"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateaActivityLogResponse>(BuildSourceInput);
        }
    }

    public class CognizantautomationcTriggers([ConnectionName] string connectionId)
    {
    }

    public class ActivityActionStatusResponse
    {
        public bool Success { get; set; }
        public JToken[] DateTZConversionColumn { get; set; }
        public ActivityActionStatusResponseDataTypeItem[] Data { get; set; }
        public int TotalCount { get; set; }
        public JToken[] ColumnMapping { get; set; }
        public JToken[] DateColumn { get; set; }
        public JToken[] ComboBox { get; set; }
        public JToken[] ComboSelect { get; set; }
        public string TransactionKey { get; set; }
    }

    public class ActivityActionStatusResponseDataTypeItem
    {
        public string Status { get; set; }

        [JsonProperty("Automation Status")]
        public string AutomationStatus { get; set; }

        [JsonProperty("Status Id")]
        public int StatusId { get; set; }

        [JsonProperty("Automation Status Id")]
        public int AutomationStatusId { get; set; }

        [JsonProperty("Output Status Id")]
        public int OutputStatusId { get; set; }
    }

    public class TriggerActionResponse
    {
        public int ActivityActionId { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class ReadActivityAttributeResponse
    {
        public bool Success { get; set; }
        public JToken[] DateTZConversionColumn { get; set; }
        public ReadActivityAttributeResponseDataTypeItem[] Data { get; set; }
    }

    public class ReadActivityAttributeResponseDataTypeItem
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
    }

    public class SetActivityAdditionalAttributeResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class FetchISExecutionStatusResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public JToken[] DateTZConversionColumn { get; set; }
        public FetchISExecutionStatusResponseDataTypeItem[] Data { get; set; }
        public int TotalCount { get; set; }
        public JToken[] ColumnMapping { get; set; }
        public JToken[] ComboBox { get; set; }
        public JToken[] ComboSelect { get; set; }
        public JToken[] DateColumn { get; set; }
        public string TransactionKey { get; set; }
    }

    public class FetchISExecutionStatusResponseDataTypeItem
    {
        public int Id { get; set; }
        public string IntelligentSequenceStatusId { get; set; }
    }

    public class TriggerISResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class UpdateActionOutputResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public enum bodyexecutionStatusInput
    {
        _1 = 1,
        _2 = 2
    }

    public class LinkAsChildActivityResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class CreateActivityResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class CreateaActivityLogResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognizantautomationc;

    public partial class WorkflowManagedActions
    {
        public CognizantautomationcActions Cognizantautomationc(string connectionId) => new CognizantautomationcActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognizantautomationcTriggers Cognizantautomationc(string connectionId) => new CognizantautomationcTriggers(connectionId);
    }
}