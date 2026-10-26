//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ctwo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CtwoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetSessionFailed(Expression<Func<string>> sessionId, Expression<Func<SetSessionFailedInput>> body)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerautomate/v1/actions/setsessionfailed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddLogToSession(Expression<Func<string>> sessionId, Expression<Func<AddLogToSessionInput>> body)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerautomate/v1/actions/log";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AssignForm(Expression<Func<string>> formId, Expression<Func<AssignFormInput>> body = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/assign", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UnassignForm(Expression<Func<string>> formId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/unassign", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CompleteForm(Expression<Func<string>> formId, Expression<Func<CompleteFormInput>> body = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/complete", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetItemData(Expression<Func<string>> queueItemId, Expression<Func<SetItemDataInput>> body = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/data", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UnlockItem(Expression<Func<string>> queueItemId)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/unlock", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetItemState(Expression<Func<string>> queueItemId, Expression<Func<SetItemStateInput>> body = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/setstate", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RetryItem(Expression<Func<int>> queueItemId, Expression<Func<int>> stateId = null, Expression<Func<string>> state = null, Expression<Func<int>> workflowTaskId = null, Expression<Func<int>> appId = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_stateId = WorkflowExpression.Compile(stateId, nameof(stateId), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_workflowTaskId = WorkflowExpression.Compile(workflowTaskId, nameof(workflowTaskId), required: false);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/retry", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stateId != null)
                    callPayload.Queries["stateId"] = ExpressionConverter.Convert(__workflow_stateId);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_workflowTaskId != null)
                    callPayload.Queries["workflowTaskId"] = ExpressionConverter.Convert(__workflow_workflowTaskId);
                if (__workflow_appId != null)
                    callPayload.Queries["appId"] = ExpressionConverter.Convert(__workflow_appId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddItemLog(Expression<Func<string>> queueItemId, Expression<Func<AddItemLogInput>> body = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/log", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RemoveItemTag(Expression<Func<string>> queueItemId, Expression<Func<string>> tags = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/tag", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddItemTag(Expression<Func<string>> queueItemId, Expression<Func<AddItemTagInput>> body = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/tag", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateItemState(Expression<Func<CreateItemStateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/universalqueues/v2/states";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class CtwoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<StartFlowWithoutTimeoutResponse, ApiConnectionTriggerConfiguration> StartFlowWithoutTimeout(Expression<Func<int>> taskId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyTrigger<StartFlowWithoutTimeoutResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/powerautomate/v1/trigger/ConsumePendingSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["taskId"] = ExpressionConverter.Convert(__workflow_taskId);
                return new ApiConnectionTrigger<StartFlowWithoutTimeoutResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<StartFlowWithTimeoutResponse, ApiConnectionTriggerConfiguration> StartFlowWithTimeout(Expression<Func<int>> taskId, Expression<Func<int>> timeout, FlowRecurrence recurrence = null)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_timeout = WorkflowExpression.Compile(timeout, nameof(timeout), required: true);
            return new DeferredBodyTrigger<StartFlowWithTimeoutResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/powerautomate/v1/trigger/ConsumePendingSessionsWithRequiredTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["taskId"] = ExpressionConverter.Convert(__workflow_taskId);
                callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                return new ApiConnectionTrigger<StartFlowWithTimeoutResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SetSessionFailedInput
    {
        [JsonProperty("details", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Details { get; set; }
    }

    public class AddLogToSessionInput
    {
        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddLogToSessionInputLevelType Level { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddLogToSessionInputLevelType
    {
        Trace,
        Debug,
        Information,
        Warning,
        Error,
        Critical
    }

    public class AssignFormInput
    {
        [JsonProperty("userId")]
        public int? UserId { get; set; }
    }

    public class CompleteFormInput
    {
        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }
    }

    public class SetItemDataInput
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class SetItemStateInput
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class AddItemLogInput
    {
        [JsonProperty("level")]
        public AddItemLogInputLevelType? Level { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddItemLogInputLevelType
    {
        Information,
        Warning,
        Exception
    }

    public class AddItemTagInput
    {
        [JsonProperty("tags")]
        public string Tags { get; set; }
    }

    public class CreateItemStateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("responseTimeCalculationBasis", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateItemStateInputResponseTimeCalculationBasisType ResponseTimeCalculationBasis { get; set; } = CreateItemStateInputResponseTimeCalculationBasisType.ItemStateEnterTime;

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateItemStateInputStateType State { get; set; }

        [JsonProperty("queueId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int QueueId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timeSavedPerItem")]
        public int? TimeSavedPerItem { get; set; }

        [JsonProperty("valueGeneratedPerItem")]
        public int? ValueGeneratedPerItem { get; set; }

        [JsonProperty("includeInReports", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeInReports { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateItemStateInputResponseTimeCalculationBasisType
    {
        ItemStateEnterTime,
        ItemCreationTime,
        ItemDeferTimeWithEnterTimeFallback,
        ItemDeferTimeWithCreationTimeFallback
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateItemStateInputStateType
    {
        Pending,
        Completed,
        Referred
    }

    public class StartFlowWithoutTimeoutResponse
    {
        [JsonProperty("sessions")]
        public StartFlowWithoutTimeoutResponseSessionsTypeItem[] Sessions { get; set; }
    }

    public class StartFlowWithoutTimeoutResponseSessionsTypeItem
    {
        [JsonProperty("sessionId")]
        public int SessionId { get; set; }

        [JsonProperty("workflowTaskId")]
        public int WorkflowTaskId { get; set; }

        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("processInputValues")]
        public JToken ProcessInputValues { get; set; }
    }

    public class StartFlowWithTimeoutResponse
    {
        [JsonProperty("sessions")]
        public StartFlowWithTimeoutResponseSessionsTypeItem[] Sessions { get; set; }
    }

    public class StartFlowWithTimeoutResponseSessionsTypeItem
    {
        [JsonProperty("sessionId")]
        public int SessionId { get; set; }

        [JsonProperty("workflowTaskId")]
        public int WorkflowTaskId { get; set; }

        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("processInputValues")]
        public JToken ProcessInputValues { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ctwo;

    public partial class WorkflowManagedActions
    {
        public CtwoActions Ctwo(string connectionId) => new CtwoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CtwoTriggers Ctwo(string connectionId) => new CtwoTriggers(connectionId);
    }
}