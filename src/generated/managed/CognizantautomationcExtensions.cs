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
        public IBodyWorkflowAction<TriggerActionResponse, ApiConnectionActionConfiguration> TriggerAction(Expression<Func<string>> activityId, Expression<Func<TriggerActionInput>> body)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggerActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/actions", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerActionExternal");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<SetActivityAdditionalAttributeResponse, ApiConnectionActionConfiguration> SetActivityAdditionalAttribute(Expression<Func<string>> activityId, Expression<Func<object>> body)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetActivityAdditionalAttributeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/attributes", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("InsertUpdate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<TriggerISResponse, ApiConnectionActionConfiguration> TriggerIS(Expression<Func<string>> activityId, Expression<Func<TriggerISInput>> body)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggerISResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("TriggerIS");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TriggerISResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<UpdateActionOutputResponse, ApiConnectionActionConfiguration> UpdateActionOutput(Expression<Func<string>> activityActionId, Expression<Func<UpdateActionOutputInput>> body)
        {
            var __workflow_activityActionId = WorkflowExpression.Compile(activityActionId, nameof(activityActionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateActionOutputResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activityaction/{0}", __workflow_activityActionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateActionOutputResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<LinkAsChildActivityResponse, ApiConnectionActionConfiguration> LinkAsChildActivity(Expression<Func<string>> activityId, Expression<Func<LinkAsChildActivityInput>> body)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LinkAsChildActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portal/ino/api/v3/collab/activity/{0}/v1/link", __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("AddChild");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LinkAsChildActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateActivityResponse, ApiConnectionActionConfiguration> CreateActivity(Expression<Func<CreateActivityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/portal/ino/api/v3/collab/activity";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateaActivityLogResponse, ApiConnectionActionConfiguration> CreateaActivityLog(Expression<Func<CreateaActivityLogInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateaActivityLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/portal/ino/api/v3/collab/activity/0/logs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ttype"] = Convert.ToString("NewRecord");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class TriggerActionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ActionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ActivityId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CIId { get; set; } = "ActivityCI";
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

    public class TriggerISInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SkillId { get; set; }
    }

    public class UpdateActionOutputResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class UpdateActionOutputInput
    {
        [JsonProperty("output", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Output { get; set; }

        [JsonProperty("ActionExecutionStatus")]
        public UpdateActionOutputInputExecutionStatusType? ExecutionStatus { get; set; }
    }

    public enum UpdateActionOutputInputExecutionStatusType
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

    public class LinkAsChildActivityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ChildId { get; set; }
    }

    public class CreateActivityResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class CreateActivityInput
    {
        [JsonProperty("pa_run_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RunId { get; set; } = "@{workflow().run.name}";

        [JsonProperty("pa_run_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkflowRunURL { get; set; } = "@{concat('https://india.flow.microsoft.com/manage/environments/',workflow().tags.environmentName,'/flows/',workflow().name,'/runs/',workflow().run.name)}";

        [JsonProperty("SourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int SetSourceidAs11ToCreateActivityUnderGeneralCategory { get; set; } = 11;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CIId { get; set; }

        [JsonProperty("OwnerId")]
        public string UserId { get; set; }
        public string AssignmentGroup { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerId { get; set; }
    }

    public class CreateaActivityLogResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class CreateaActivityLogInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ActivityId { get; set; }

        [JsonProperty("Comment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LogMessage { get; set; } = "Triggered by PowerAutomate. Run id: @{workflow().run.name} Workflow: @{concat('https://india.flow.microsoft.com/manage/environments/',workflow().tags.environmentName,'/flows/',workflow().name,'/runs/',workflow().run.name)}";

        [JsonProperty("CreatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UserId { get; set; }
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