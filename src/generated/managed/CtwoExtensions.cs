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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetSessionFailed(Expression<Func<string>> sessionId, Expression<Func<string>> bodydetails)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_bodydetails = WorkflowExpression.Compile(bodydetails, nameof(bodydetails), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerautomate/v1/actions/setsessionfailed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["details"] = ExpressionConverter.ConvertO(__workflow_bodydetails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddLogToSession(Expression<Func<string>> sessionId, Expression<Func<bodylevelInput>> bodylevel, Expression<Func<string>> bodymessage)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerautomate/v1/actions/log";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AssignForm(Expression<Func<string>> formId, Expression<Func<int>> bodyuserId = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/assign", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CompleteForm(Expression<Func<string>> formId, Expression<Func<string>> bodycompletedAt = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_bodycompletedAt = WorkflowExpression.Compile(bodycompletedAt, nameof(bodycompletedAt), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/complete", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycompletedAt != null)
                {
                    body["completedAt"] = ExpressionConverter.ConvertO(__workflow_bodycompletedAt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetItemData(Expression<Func<string>> queueItemId, Expression<Func<string>> bodycreated = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/data", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (__workflow_bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetItemState(Expression<Func<string>> queueItemId, Expression<Func<string>> bodystate = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/setstate", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddItemLog(Expression<Func<string>> queueItemId, Expression<Func<bodylevelInput>> bodylevel = null, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/log", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylevel != null)
                {
                    body["level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddItemTag(Expression<Func<string>> queueItemId, Expression<Func<string>> bodytags = null)
        {
            var __workflow_queueItemId = WorkflowExpression.Compile(queueItemId, nameof(queueItemId), required: true);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/universalqueues/v2/items/{0}/tag", __workflow_queueItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateItemState(Expression<Func<bodyresponseTimeCalculationBasisInput>> bodyresponseTimeCalculationBasis, Expression<Func<bodystateInput>> bodystate, Expression<Func<int>> bodyqueueId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodytimeSavedPerItem = null, Expression<Func<int>> bodyvalueGeneratedPerItem = null, Expression<Func<bool>> bodyincludeInReports = null)
        {
            var __workflow_bodyresponseTimeCalculationBasis = WorkflowExpression.Compile(bodyresponseTimeCalculationBasis, nameof(bodyresponseTimeCalculationBasis), required: true);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: true);
            var __workflow_bodyqueueId = WorkflowExpression.Compile(bodyqueueId, nameof(bodyqueueId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytimeSavedPerItem = WorkflowExpression.Compile(bodytimeSavedPerItem, nameof(bodytimeSavedPerItem), required: false);
            var __workflow_bodyvalueGeneratedPerItem = WorkflowExpression.Compile(bodyvalueGeneratedPerItem, nameof(bodyvalueGeneratedPerItem), required: false);
            var __workflow_bodyincludeInReports = WorkflowExpression.Compile(bodyincludeInReports, nameof(bodyincludeInReports), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/universalqueues/v2/states";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["responseTimeCalculationBasis"] = ExpressionConverter.ConvertO(__workflow_bodyresponseTimeCalculationBasis);
                bodypropCount++;
                body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                bodypropCount++;
                body["queueId"] = ExpressionConverter.ConvertO(__workflow_bodyqueueId);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytimeSavedPerItem != null)
                {
                    body["timeSavedPerItem"] = ExpressionConverter.ConvertO(__workflow_bodytimeSavedPerItem);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueGeneratedPerItem != null)
                {
                    body["valueGeneratedPerItem"] = ExpressionConverter.ConvertO(__workflow_bodyvalueGeneratedPerItem);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeInReports != null)
                {
                    if (__workflow_bodyincludeInReports != null)
                    {
                        body["includeInReports"] = ExpressionConverter.ConvertO(__workflow_bodyincludeInReports);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeInReports"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylevelInput
    {
        Information,
        Warning,
        Exception
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyresponseTimeCalculationBasisInput
    {
        ItemStateEnterTime,
        ItemCreationTime,
        ItemDeferTimeWithEnterTimeFallback,
        ItemDeferTimeWithCreationTimeFallback
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystateInput
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