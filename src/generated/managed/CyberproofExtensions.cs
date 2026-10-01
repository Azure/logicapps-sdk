//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cyberproof
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CyberproofActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken> CPCreateExecution([WorkflowExpression] Func<string> actionReqselectAction, [WorkflowExpression] Func<object> actionReqparameters)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/executions/async";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReqpropCount++;
                actionReq["action"] = SourceExpressionConverter.ConvertToken(actionReqselectAction);
                actionReqpropCount++;
                actionReq["parameters"] = SourceExpressionConverter.ConvertToken(actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction CPCreateWebhookExecution([WorkflowExpression] Func<string> actionReqselectAction, [WorkflowExpression] Func<object> actionReqparameters)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/webhooks/user-action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReq["url"] = "#{listCallbackUrl()}";
                actionReqpropCount++;
                actionReqpropCount++;
                actionReq["action"] = SourceExpressionConverter.ConvertToken(actionReqselectAction);
                actionReqpropCount++;
                actionReq["parameters"] = SourceExpressionConverter.ConvertToken(actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction CPSetAlertCustomField([WorkflowExpression] Func<string> actionCustomReqalertId, [WorkflowExpression] Func<string> actionCustomReqselectClassification, [WorkflowExpression] Func<object> actionCustomReqselectField)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["alert_id"] = SourceExpressionConverter.ConvertToken(actionCustomReqalertId);
                actionCustomReqpropCount++;
                actionCustomReq["classifications"] = SourceExpressionConverter.ConvertToken(actionCustomReqselectClassification);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = SourceExpressionConverter.ConvertToken(actionCustomReqselectField);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken> CPGetAlertCustomField([WorkflowExpression] Func<string> actionCustomReqalertId, [WorkflowExpression] Func<string> actionCustomReqselectClassification, [WorkflowExpression] Func<object> actionCustomReqselectField)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["alert_id"] = SourceExpressionConverter.ConvertToken(actionCustomReqalertId);
                actionCustomReqpropCount++;
                actionCustomReq["classifications"] = SourceExpressionConverter.ConvertToken(actionCustomReqselectClassification);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = SourceExpressionConverter.ConvertToken(actionCustomReqselectField);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken> CPGetIncidentSummary([WorkflowExpression] Func<string> actionCustomReqincidentId, [WorkflowExpression] Func<object> actionCustomReqselectIncidentSummary)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["incident_id"] = SourceExpressionConverter.ConvertToken(actionCustomReqincidentId);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = SourceExpressionConverter.ConvertToken(actionCustomReqselectIncidentSummary);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction CPSetIncidentSummary([WorkflowExpression] Func<string> actionCustomReqincidentId, [WorkflowExpression] Func<object> actionCustomReqselectValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["incident_id"] = SourceExpressionConverter.ConvertToken(actionCustomReqincidentId);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = SourceExpressionConverter.ConvertToken(actionCustomReqselectValue);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CyberproofTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CPTrigger([WorkflowExpression] Func<string> actionReqselectTrigger, [WorkflowExpression] Func<object> actionReqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReq["url"] = "#{listCallbackUrl()}";
                actionReqpropCount++;
                actionReqpropCount++;
                actionReq["action"] = SourceExpressionConverter.ConvertToken(actionReqselectTrigger);
                actionReqpropCount++;
                actionReq["parameters"] = SourceExpressionConverter.ConvertToken(actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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