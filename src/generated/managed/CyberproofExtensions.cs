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
        public IBodyWorkflowAction<JToken> CPCreateExecution(Expression<Func<string>> actionReqselectAction, Expression<Func<object>> actionReqparameters)
        {
            var apiCallPath = "/api/v1/executions/async";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionReq = new JObject();
            var actionReqpropCount = 0;
            actionReqpropCount++;
            actionReq["action"] = CSharpExpressionConverter.ConvertToken(actionReqselectAction);
            actionReqpropCount++;
            actionReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionReqparameters);
            if (actionReqpropCount > 0)
            {
                callPayload.Body = actionReq;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction CPCreateWebhookExecution(Expression<Func<string>> actionReqselectAction, Expression<Func<object>> actionReqparameters)
        {
            var apiCallPath = "/api/v1/webhooks/user-action";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionReq = new JObject();
            var actionReqpropCount = 0;
            actionReq["url"] = "@listCallbackUrl()";
            actionReqpropCount++;
            actionReqpropCount++;
            actionReq["action"] = CSharpExpressionConverter.ConvertToken(actionReqselectAction);
            actionReqpropCount++;
            actionReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionReqparameters);
            if (actionReqpropCount > 0)
            {
                callPayload.Body = actionReq;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction CPSetAlertCustomField(Expression<Func<string>> actionCustomReqalertId, Expression<Func<string>> actionCustomReqselectClassification, Expression<Func<object>> actionCustomReqselectField)
        {
            var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/set";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionCustomReq = new JObject();
            var actionCustomReqpropCount = 0;
            actionCustomReqpropCount++;
            actionCustomReq["alert_id"] = CSharpExpressionConverter.ConvertToken(actionCustomReqalertId);
            actionCustomReqpropCount++;
            actionCustomReq["classifications"] = CSharpExpressionConverter.ConvertToken(actionCustomReqselectClassification);
            actionCustomReqpropCount++;
            actionCustomReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionCustomReqselectField);
            if (actionCustomReqpropCount > 0)
            {
                callPayload.Body = actionCustomReq;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken> CPGetAlertCustomField(Expression<Func<string>> actionCustomReqalertId, Expression<Func<string>> actionCustomReqselectClassification, Expression<Func<object>> actionCustomReqselectField)
        {
            var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/get";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionCustomReq = new JObject();
            var actionCustomReqpropCount = 0;
            actionCustomReqpropCount++;
            actionCustomReq["alert_id"] = CSharpExpressionConverter.ConvertToken(actionCustomReqalertId);
            actionCustomReqpropCount++;
            actionCustomReq["classifications"] = CSharpExpressionConverter.ConvertToken(actionCustomReqselectClassification);
            actionCustomReqpropCount++;
            actionCustomReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionCustomReqselectField);
            if (actionCustomReqpropCount > 0)
            {
                callPayload.Body = actionCustomReq;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken> CPGetIncidentSummary(Expression<Func<string>> actionCustomReqincidentId, Expression<Func<object>> actionCustomReqselectIncidentSummary)
        {
            var apiCallPath = "/api/v1/custom-fields/incident-summary/get";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionCustomReq = new JObject();
            var actionCustomReqpropCount = 0;
            actionCustomReqpropCount++;
            actionCustomReq["incident_id"] = CSharpExpressionConverter.ConvertToken(actionCustomReqincidentId);
            actionCustomReqpropCount++;
            actionCustomReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionCustomReqselectIncidentSummary);
            if (actionCustomReqpropCount > 0)
            {
                callPayload.Body = actionCustomReq;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction CPSetIncidentSummary(Expression<Func<string>> actionCustomReqincidentId, Expression<Func<object>> actionCustomReqselectValue)
        {
            var apiCallPath = "/api/v1/custom-fields/incident-summary/set";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionCustomReq = new JObject();
            var actionCustomReqpropCount = 0;
            actionCustomReqpropCount++;
            actionCustomReq["incident_id"] = CSharpExpressionConverter.ConvertToken(actionCustomReqincidentId);
            actionCustomReqpropCount++;
            actionCustomReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionCustomReqselectValue);
            if (actionCustomReqpropCount > 0)
            {
                callPayload.Body = actionCustomReq;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class CyberproofTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CPTrigger(Expression<Func<string>> actionReqselectTrigger, Expression<Func<object>> actionReqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v1/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actionReq = new JObject();
            var actionReqpropCount = 0;
            actionReq["url"] = "@listCallbackUrl()";
            actionReqpropCount++;
            actionReqpropCount++;
            actionReq["action"] = CSharpExpressionConverter.ConvertToken(actionReqselectTrigger);
            actionReqpropCount++;
            actionReq["parameters"] = CSharpExpressionConverter.ConvertToken(actionReqparameters);
            if (actionReqpropCount > 0)
            {
                callPayload.Body = actionReq;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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