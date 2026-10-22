//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cyberproof
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CyberproofActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CPCreateExecution(Expression<Func<string>> actionReqselectAction, Expression<Func<object>> actionReqparameters)
        {
            var __workflow_actionReqselectAction = WorkflowExpression.Compile(actionReqselectAction, nameof(actionReqselectAction), required: true);
            var __workflow_actionReqparameters = WorkflowExpression.Compile(actionReqparameters, nameof(actionReqparameters), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/executions/async";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReqpropCount++;
                actionReq["action"] = ExpressionConverter.ConvertO(__workflow_actionReqselectAction);
                actionReqpropCount++;
                actionReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CPCreateWebhookExecution(Expression<Func<string>> actionReqselectAction, Expression<Func<object>> actionReqparameters)
        {
            var __workflow_actionReqselectAction = WorkflowExpression.Compile(actionReqselectAction, nameof(actionReqselectAction), required: true);
            var __workflow_actionReqparameters = WorkflowExpression.Compile(actionReqparameters, nameof(actionReqparameters), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/webhooks/user-action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReq["url"] = "#{listCallbackUrl()}";
                actionReqpropCount++;
                actionReqpropCount++;
                actionReq["action"] = ExpressionConverter.ConvertO(__workflow_actionReqselectAction);
                actionReqpropCount++;
                actionReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CPSetAlertCustomField(Expression<Func<string>> actionCustomReqalertId, Expression<Func<string>> actionCustomReqselectClassification, Expression<Func<object>> actionCustomReqselectField)
        {
            var __workflow_actionCustomReqalertId = WorkflowExpression.Compile(actionCustomReqalertId, nameof(actionCustomReqalertId), required: true);
            var __workflow_actionCustomReqselectClassification = WorkflowExpression.Compile(actionCustomReqselectClassification, nameof(actionCustomReqselectClassification), required: true);
            var __workflow_actionCustomReqselectField = WorkflowExpression.Compile(actionCustomReqselectField, nameof(actionCustomReqselectField), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["alert_id"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqalertId);
                actionCustomReqpropCount++;
                actionCustomReq["classifications"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqselectClassification);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqselectField);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CPGetAlertCustomField(Expression<Func<string>> actionCustomReqalertId, Expression<Func<string>> actionCustomReqselectClassification, Expression<Func<object>> actionCustomReqselectField)
        {
            var __workflow_actionCustomReqalertId = WorkflowExpression.Compile(actionCustomReqalertId, nameof(actionCustomReqalertId), required: true);
            var __workflow_actionCustomReqselectClassification = WorkflowExpression.Compile(actionCustomReqselectClassification, nameof(actionCustomReqselectClassification), required: true);
            var __workflow_actionCustomReqselectField = WorkflowExpression.Compile(actionCustomReqselectField, nameof(actionCustomReqselectField), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["alert_id"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqalertId);
                actionCustomReqpropCount++;
                actionCustomReq["classifications"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqselectClassification);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqselectField);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CPGetIncidentSummary(Expression<Func<string>> actionCustomReqincidentId, Expression<Func<object>> actionCustomReqselectIncidentSummary)
        {
            var __workflow_actionCustomReqincidentId = WorkflowExpression.Compile(actionCustomReqincidentId, nameof(actionCustomReqincidentId), required: true);
            var __workflow_actionCustomReqselectIncidentSummary = WorkflowExpression.Compile(actionCustomReqselectIncidentSummary, nameof(actionCustomReqselectIncidentSummary), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["incident_id"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqincidentId);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqselectIncidentSummary);
                if (actionCustomReqpropCount > 0)
                {
                    callPayload.Body = actionCustomReq;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CPSetIncidentSummary(Expression<Func<string>> actionCustomReqincidentId, Expression<Func<object>> actionCustomReqselectValue)
        {
            var __workflow_actionCustomReqincidentId = WorkflowExpression.Compile(actionCustomReqincidentId, nameof(actionCustomReqincidentId), required: true);
            var __workflow_actionCustomReqselectValue = WorkflowExpression.Compile(actionCustomReqselectValue, nameof(actionCustomReqselectValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionCustomReq = new JObject();
                var actionCustomReqpropCount = 0;
                actionCustomReqpropCount++;
                actionCustomReq["incident_id"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqincidentId);
                actionCustomReqpropCount++;
                actionCustomReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionCustomReqselectValue);
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CPTrigger(Expression<Func<string>> actionReqselectTrigger, Expression<Func<object>> actionReqparameters, FlowRecurrence recurrence = null)
        {
            var __workflow_actionReqselectTrigger = WorkflowExpression.Compile(actionReqselectTrigger, nameof(actionReqselectTrigger), required: true);
            var __workflow_actionReqparameters = WorkflowExpression.Compile(actionReqparameters, nameof(actionReqparameters), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actionReq = new JObject();
                var actionReqpropCount = 0;
                actionReq["url"] = "#{listCallbackUrl()}";
                actionReqpropCount++;
                actionReqpropCount++;
                actionReq["action"] = ExpressionConverter.ConvertO(__workflow_actionReqselectTrigger);
                actionReqpropCount++;
                actionReq["parameters"] = ExpressionConverter.ConvertO(__workflow_actionReqparameters);
                if (actionReqpropCount > 0)
                {
                    callPayload.Body = actionReq;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
