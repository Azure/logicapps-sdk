//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognizantautomationc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognizantautomationcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<ActivityActionStatusResponse, ApiConnectionActionConfiguration> ActivityActionStatus(Expression<Func<int>> activityId, Expression<Func<int>> activityActionId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_activityActionId = WorkflowExpression.Compile(activityActionId, nameof(activityActionId), required: true);
            return new DeferredBodyAction<ActivityActionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/actions/{1}", __workflow_activityId.WithUrlEncoding(1), __workflow_activityActionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("ExecutedActionView");
                return new ApiConnectionAction<ActivityActionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<TriggerActionResponse, ApiConnectionActionConfiguration> TriggerAction(Expression<Func<string>> activityId, Expression<Func<int>> bodyactionId, Expression<Func<int>> bodyactivityId, Expression<Func<string>> bodycIId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_bodyactionId = WorkflowExpression.Compile(bodyactionId, nameof(bodyactionId), required: true);
            var __workflow_bodyactivityId = WorkflowExpression.Compile(bodyactivityId, nameof(bodyactivityId), required: true);
            var __workflow_bodycIId = WorkflowExpression.Compile(bodycIId, nameof(bodycIId), required: true);
            return new DeferredBodyAction<TriggerActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/actions", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerActionExternal");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ActionId"] = ExpressionConverter.ConvertO(__workflow_bodyactionId);
                bodypropCount++;
                body["ActivityId"] = ExpressionConverter.ConvertO(__workflow_bodyactivityId);
                bodypropCount++;
                body["CIId"] = ExpressionConverter.ConvertO(__workflow_bodycIId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TriggerActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<ReadActivityAttributeResponse, ApiConnectionActionConfiguration> ReadActivityAttribute(Expression<Func<string>> activityId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            return new DeferredBodyAction<ReadActivityAttributeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/attributes", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("ReadAttributes");
                return new ApiConnectionAction<ReadActivityAttributeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<SetActivityAdditionalAttributeResponse, ApiConnectionActionConfiguration> SetActivityAdditionalAttribute(Expression<Func<string>> activityId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            return new DeferredBodyAction<SetActivityAdditionalAttributeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/attributes", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("InsertUpdate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetActivityAdditionalAttributeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<FetchISExecutionStatusResponse, ApiConnectionActionConfiguration> FetchISExecutionStatus(Expression<Func<string>> activityId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            return new DeferredBodyAction<FetchISExecutionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerIsStatusApi");
                return new ApiConnectionAction<FetchISExecutionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<TriggerISResponse, ApiConnectionActionConfiguration> TriggerIS(Expression<Func<string>> activityId, Expression<Func<string>> bodyskillId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_bodyskillId = WorkflowExpression.Compile(bodyskillId, nameof(bodyskillId), required: true);
            return new DeferredBodyAction<TriggerISResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerIS");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["SkillId"] = ExpressionConverter.ConvertO(__workflow_bodyskillId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TriggerISResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<UpdateActionOutputResponse, ApiConnectionActionConfiguration> UpdateActionOutput(Expression<Func<string>> activityActionId, Expression<Func<string>> bodyoutput, Expression<Func<bodyexecutionStatusInput>> bodyexecutionStatus = null)
        {
            var __workflow_activityActionId = WorkflowExpression.Compile(activityActionId, nameof(activityActionId), required: true);
            var __workflow_bodyoutput = WorkflowExpression.Compile(bodyoutput, nameof(bodyoutput), required: true);
            var __workflow_bodyexecutionStatus = WorkflowExpression.Compile(bodyexecutionStatus, nameof(bodyexecutionStatus), required: false);
            return new DeferredBodyAction<UpdateActionOutputResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activityaction/{0}", __workflow_activityActionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["output"] = ExpressionConverter.ConvertO(__workflow_bodyoutput);
                if (__workflow_bodyexecutionStatus != null)
                {
                    body["ActionExecutionStatus"] = ExpressionConverter.ConvertO(__workflow_bodyexecutionStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateActionOutputResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<LinkAsChildActivityResponse, ApiConnectionActionConfiguration> LinkAsChildActivity(Expression<Func<string>> activityId, Expression<Func<int>> bodychildId)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_bodychildId = WorkflowExpression.Compile(bodychildId, nameof(bodychildId), required: true);
            return new DeferredBodyAction<LinkAsChildActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/v1/link", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("AddChild");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ChildId"] = ExpressionConverter.ConvertO(__workflow_bodychildId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkAsChildActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateActivityResponse, ApiConnectionActionConfiguration> CreateActivity(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription, Expression<Func<string>> bodycIId, Expression<Func<string>> bodycustomerId, Expression<Func<string>> bodyrunId = null, Expression<Func<string>> bodyworkflowRunURL = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyassignmentGroup = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodycIId = WorkflowExpression.Compile(bodycIId, nameof(bodycIId), required: true);
            var __workflow_bodycustomerId = WorkflowExpression.Compile(bodycustomerId, nameof(bodycustomerId), required: true);
            var __workflow_bodyrunId = WorkflowExpression.Compile(bodyrunId, nameof(bodyrunId), required: false);
            var __workflow_bodyworkflowRunURL = WorkflowExpression.Compile(bodyworkflowRunURL, nameof(bodyworkflowRunURL), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyassignmentGroup = WorkflowExpression.Compile(bodyassignmentGroup, nameof(bodyassignmentGroup), required: false);
            return new DeferredBodyAction<CreateActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/portal/ino/api/v3/collab/activity";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrunId != null)
                {
                    if (__workflow_bodyrunId != null)
                    {
                        body["pa_run_id"] = ExpressionConverter.ConvertO(__workflow_bodyrunId);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pa_run_id"] = "@{workflow().run.name}";
                    bodypropCount++;
                }

                if (__workflow_bodyworkflowRunURL != null)
                {
                    if (__workflow_bodyworkflowRunURL != null)
                    {
                        body["pa_run_name"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowRunURL);
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
                body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["CIId"] = ExpressionConverter.ConvertO(__workflow_bodycIId);
                if (__workflow_bodyuserId != null)
                {
                    body["OwnerId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentGroup != null)
                {
                    body["AssignmentGroup"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentGroup);
                    bodypropCount++;
                }

                bodypropCount++;
                body["CustomerId"] = ExpressionConverter.ConvertO(__workflow_bodycustomerId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateaActivityLogResponse, ApiConnectionActionConfiguration> CreateaActivityLog(Expression<Func<int>> bodyactivityId, Expression<Func<string>> bodylogMessage, Expression<Func<int>> bodyuserId)
        {
            var __workflow_bodyactivityId = WorkflowExpression.Compile(bodyactivityId, nameof(bodyactivityId), required: true);
            var __workflow_bodylogMessage = WorkflowExpression.Compile(bodylogMessage, nameof(bodylogMessage), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<CreateaActivityLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/portal/ino/api/v3/collab/activity/0/logs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("NewRecord");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ActivityId"] = ExpressionConverter.ConvertO(__workflow_bodyactivityId);
                bodypropCount++;
                body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodylogMessage);
                bodypropCount++;
                body["CreatedById"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateaActivityLogResponse>(callPayload);
            });
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