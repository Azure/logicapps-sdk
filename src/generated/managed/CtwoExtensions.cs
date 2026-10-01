//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ctwo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CtwoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> SetSessionFailed([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> bodydetails)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/powerautomate/v1/actions/setsessionfailed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["details"] = SourceExpressionConverter.ConvertToken(bodydetails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> AddLogToSession([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bodylevelInput> bodylevel, [WorkflowExpression] Func<string> bodymessage)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/powerautomate/v1/actions/log";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["level"] = SourceExpressionConverter.Convert(bodylevel);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> AssignForm([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<int> bodyuserId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/assign", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> UnassignForm([WorkflowExpression] Func<string> formId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/unassign", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> CompleteForm([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> bodycompletedAt = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/v2/robotToHumanHelpRequests/{0}/complete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycompletedAt != null)
                {
                    body["completedAt"] = SourceExpressionConverter.ConvertToken(bodycompletedAt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> SetItemData([WorkflowExpression] Func<string> queueItemId, [WorkflowExpression] Func<string> bodycreated = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueItemId, 1));
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

                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> UnlockItem([WorkflowExpression] Func<string> queueItemId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/unlock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueItemId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> SetItemState([WorkflowExpression] Func<string> queueItemId, [WorkflowExpression] Func<string> bodystate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/setstate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueItemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> RetryItem([WorkflowExpression] Func<int> queueItemId, [WorkflowExpression] Func<int> stateId = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<int> workflowTaskId = null, [WorkflowExpression] Func<int> appId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/retry", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(queueItemId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stateId != null)
                    callPayload.Queries["stateId"] = SourceExpressionConverter.ConvertO(stateId);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (workflowTaskId != null)
                    callPayload.Queries["workflowTaskId"] = SourceExpressionConverter.ConvertO(workflowTaskId);
                if (appId != null)
                    callPayload.Queries["appId"] = SourceExpressionConverter.ConvertO(appId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> AddItemLog([WorkflowExpression] Func<string> queueItemId, [WorkflowExpression] Func<bodylevelInput> bodylevel = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/log", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueItemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylevel != null)
                {
                    body["level"] = SourceExpressionConverter.Convert(bodylevel);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> RemoveItemTag([WorkflowExpression] Func<string> queueItemId, [WorkflowExpression] Func<string> tags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/tag", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueItemId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tags != null)
                    callPayload.Queries["tags"] = SourceExpressionConverter.ConvertO(tags);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> AddItemTag([WorkflowExpression] Func<string> queueItemId, [WorkflowExpression] Func<string> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/universalqueues/v2/items/{0}/tag", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueItemId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ctwo")]
        public IBodyWorkflowAction<string> CreateItemState([WorkflowExpression] Func<bodyresponseTimeCalculationBasisInput> bodyresponseTimeCalculationBasis, [WorkflowExpression] Func<bodystateInput> bodystate, [WorkflowExpression] Func<int> bodyqueueId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodytimeSavedPerItem = null, [WorkflowExpression] Func<int> bodyvalueGeneratedPerItem = null, [WorkflowExpression] Func<bool> bodyincludeInReports = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/universalqueues/v2/states";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["responseTimeCalculationBasis"] = SourceExpressionConverter.Convert(bodyresponseTimeCalculationBasis);
                bodypropCount++;
                body["state"] = SourceExpressionConverter.Convert(bodystate);
                bodypropCount++;
                body["queueId"] = SourceExpressionConverter.ConvertToken(bodyqueueId);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodytimeSavedPerItem != null)
                {
                    body["timeSavedPerItem"] = SourceExpressionConverter.ConvertToken(bodytimeSavedPerItem);
                    bodypropCount++;
                }

                if (bodyvalueGeneratedPerItem != null)
                {
                    body["valueGeneratedPerItem"] = SourceExpressionConverter.ConvertToken(bodyvalueGeneratedPerItem);
                    bodypropCount++;
                }

                if (bodyincludeInReports != null)
                {
                    if (bodyincludeInReports != null)
                    {
                        body["includeInReports"] = SourceExpressionConverter.ConvertToken(bodyincludeInReports);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class CtwoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<StartFlowWithoutTimeoutResponse> StartFlowWithoutTimeout([WorkflowExpression] Func<int> taskId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/powerautomate/v1/trigger/ConsumePendingSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["taskId"] = SourceExpressionConverter.ConvertO(taskId);
                return callPayload;
            }

            return new ApiConnectionTrigger<StartFlowWithoutTimeoutResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<StartFlowWithTimeoutResponse> StartFlowWithTimeout([WorkflowExpression] Func<int> taskId, [WorkflowExpression] Func<int> timeout, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/powerautomate/v1/trigger/ConsumePendingSessionsWithRequiredTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["taskId"] = SourceExpressionConverter.ConvertO(taskId);
                callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                return callPayload;
            }

            return new ApiConnectionTrigger<StartFlowWithTimeoutResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public enum bodylevelInput
    {
        Information,
        Warning,
        Exception
    }

    public enum bodyresponseTimeCalculationBasisInput
    {
        ItemStateEnterTime,
        ItemCreationTime,
        ItemDeferTimeWithEnterTimeFallback,
        ItemDeferTimeWithCreationTimeFallback
    }

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