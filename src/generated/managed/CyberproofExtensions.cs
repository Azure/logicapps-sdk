//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cyberproof
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CyberproofActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        [WorkflowExpressionFactory(nameof(__BuildCPCreateExecution))]
        public IBodyWorkflowAction<JToken> CPCreateExecution([WorkflowExpression] Func<string> actionReqselectAction, [WorkflowExpression] Func<object> actionReqparameters)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCPCreateExecution(WorkflowValue<string> actionReqselectAction, WorkflowValue<object> actionReqparameters)
        {
            WorkflowValue.Validate(actionReqselectAction, nameof(actionReqselectAction), required: true);
            WorkflowValue.Validate(actionReqparameters, nameof(actionReqparameters), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/v1/executions/async";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReqpropCount++;
                actionReq["action"] = ExpressionConverter.ConvertO(actionReqselectAction);
                actionReqpropCount++;
                actionReq["parameters"] = ExpressionConverter.ConvertO(actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        [WorkflowExpressionFactory(nameof(__BuildCPCreateWebhookExecution))]
        public IWorkflowAction CPCreateWebhookExecution([WorkflowExpression] Func<string> actionReqselectAction, [WorkflowExpression] Func<object> actionReqparameters)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCPCreateWebhookExecution(WorkflowValue<string> actionReqselectAction, WorkflowValue<object> actionReqparameters)
        {
            WorkflowValue.Validate(actionReqselectAction, nameof(actionReqselectAction), required: true);
            WorkflowValue.Validate(actionReqparameters, nameof(actionReqparameters), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/webhooks/user-action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReq["url"] = "#{listCallbackUrl()}";
                actionReqpropCount++;
                actionReqpropCount++;
                actionReq["action"] = ExpressionConverter.ConvertO(actionReqselectAction);
                actionReqpropCount++;
                actionReq["parameters"] = ExpressionConverter.ConvertO(actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        [WorkflowExpressionFactory(nameof(__BuildCPSetAlertCustomField))]
        public IWorkflowAction CPSetAlertCustomField([WorkflowExpression] Func<string> actionCustomReqalertId, [WorkflowExpression] Func<string> actionCustomReqselectClassification, [WorkflowExpression] Func<object> actionCustomReqselectField)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCPSetAlertCustomField(WorkflowValue<string> actionCustomReqalertId, WorkflowValue<string> actionCustomReqselectClassification, WorkflowValue<object> actionCustomReqselectField)
        {
            WorkflowValue.Validate(actionCustomReqalertId, nameof(actionCustomReqalertId), required: true);
            WorkflowValue.Validate(actionCustomReqselectClassification, nameof(actionCustomReqselectClassification), required: true);
            WorkflowValue.Validate(actionCustomReqselectField, nameof(actionCustomReqselectField), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["alert_id"] = ExpressionConverter.ConvertO(actionCustomReqalertId);
                actionCustomReqpropCount++;
                actionCustomReq["classifications"] = ExpressionConverter.ConvertO(actionCustomReqselectClassification);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(actionCustomReqselectField);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        [WorkflowExpressionFactory(nameof(__BuildCPGetAlertCustomField))]
        public IBodyWorkflowAction<JToken> CPGetAlertCustomField([WorkflowExpression] Func<string> actionCustomReqalertId, [WorkflowExpression] Func<string> actionCustomReqselectClassification, [WorkflowExpression] Func<object> actionCustomReqselectField)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCPGetAlertCustomField(WorkflowValue<string> actionCustomReqalertId, WorkflowValue<string> actionCustomReqselectClassification, WorkflowValue<object> actionCustomReqselectField)
        {
            WorkflowValue.Validate(actionCustomReqalertId, nameof(actionCustomReqalertId), required: true);
            WorkflowValue.Validate(actionCustomReqselectClassification, nameof(actionCustomReqselectClassification), required: true);
            WorkflowValue.Validate(actionCustomReqselectField, nameof(actionCustomReqselectField), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["alert_id"] = ExpressionConverter.ConvertO(actionCustomReqalertId);
                actionCustomReqpropCount++;
                actionCustomReq["classifications"] = ExpressionConverter.ConvertO(actionCustomReqselectClassification);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(actionCustomReqselectField);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        [WorkflowExpressionFactory(nameof(__BuildCPGetIncidentSummary))]
        public IBodyWorkflowAction<JToken> CPGetIncidentSummary([WorkflowExpression] Func<string> actionCustomReqincidentId, [WorkflowExpression] Func<object> actionCustomReqselectIncidentSummary)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCPGetIncidentSummary(WorkflowValue<string> actionCustomReqincidentId, WorkflowValue<object> actionCustomReqselectIncidentSummary)
        {
            WorkflowValue.Validate(actionCustomReqincidentId, nameof(actionCustomReqincidentId), required: true);
            WorkflowValue.Validate(actionCustomReqselectIncidentSummary, nameof(actionCustomReqselectIncidentSummary), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["incident_id"] = ExpressionConverter.ConvertO(actionCustomReqincidentId);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(actionCustomReqselectIncidentSummary);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        [WorkflowExpressionFactory(nameof(__BuildCPSetIncidentSummary))]
        public IWorkflowAction CPSetIncidentSummary([WorkflowExpression] Func<string> actionCustomReqincidentId, [WorkflowExpression] Func<object> actionCustomReqselectValue)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCPSetIncidentSummary(WorkflowValue<string> actionCustomReqincidentId, WorkflowValue<object> actionCustomReqselectValue)
        {
            WorkflowValue.Validate(actionCustomReqincidentId, nameof(actionCustomReqincidentId), required: true);
            WorkflowValue.Validate(actionCustomReqselectValue, nameof(actionCustomReqselectValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["incident_id"] = ExpressionConverter.ConvertO(actionCustomReqincidentId);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(actionCustomReqselectValue);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CyberproofTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCPTrigger))]
        public IWorkflowTrigger CPTrigger([WorkflowExpression] Func<string> actionReqselectTrigger, [WorkflowExpression] Func<object> actionReqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCPTrigger(WorkflowValue<string> actionReqselectTrigger, WorkflowValue<object> actionReqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(actionReqselectTrigger, nameof(actionReqselectTrigger), required: true);
            WorkflowValue.Validate(actionReqparameters, nameof(actionReqparameters), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReq["url"] = "#{listCallbackUrl()}";
                actionReqpropCount++;
                actionReqpropCount++;
                actionReq["action"] = ExpressionConverter.ConvertO(actionReqselectTrigger);
                actionReqpropCount++;
                actionReq["parameters"] = ExpressionConverter.ConvertO(actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cyberproof;

    public partial class WorkflowManagedActions
    {
        public CyberproofActions Cyberproof(string connectionId) => new CyberproofActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CyberproofTriggers Cyberproof(string connectionId) => new CyberproofTriggers(connectionId);
    }
}
