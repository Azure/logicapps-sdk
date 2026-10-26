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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CPCreateExecution(Expression<Func<CPCreateExecutionInput>> actionReq)
        {
            var __workflow_actionReq = WorkflowExpression.Compile(actionReq, nameof(actionReq), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/executions/async";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionReq);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CPCreateWebhookExecution(Expression<Func<CPCreateWebhookExecutionInput>> actionReq)
        {
            var __workflow_actionReq = WorkflowExpression.Compile(actionReq, nameof(actionReq), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/webhooks/user-action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionReq);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CPSetAlertCustomField(Expression<Func<CPSetAlertCustomFieldInput>> actionCustomReq)
        {
            var __workflow_actionCustomReq = WorkflowExpression.Compile(actionCustomReq, nameof(actionCustomReq), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionCustomReq);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CPGetAlertCustomField(Expression<Func<CPGetAlertCustomFieldInput>> actionCustomReq)
        {
            var __workflow_actionCustomReq = WorkflowExpression.Compile(actionCustomReq, nameof(actionCustomReq), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/alert-extended-properties/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionCustomReq);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CPGetIncidentSummary(Expression<Func<CPGetIncidentSummaryInput>> actionCustomReq)
        {
            var __workflow_actionCustomReq = WorkflowExpression.Compile(actionCustomReq, nameof(actionCustomReq), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionCustomReq);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberproof")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CPSetIncidentSummary(Expression<Func<CPSetIncidentSummaryInput>> actionCustomReq)
        {
            var __workflow_actionCustomReq = WorkflowExpression.Compile(actionCustomReq, nameof(actionCustomReq), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/custom-fields/incident-summary/set";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionCustomReq);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CyberproofTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CPTrigger(Expression<Func<CPTriggerInput>> actionReq, FlowRecurrence recurrence = null)
        {
            var __workflow_actionReq = WorkflowExpression.Compile(actionReq, nameof(actionReq), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_actionReq);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CPCreateExecutionInput
    {
        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectAction { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Parameters { get; set; }
    }

    public class CPCreateWebhookExecutionInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectAction { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Parameters { get; set; }
    }

    public class CPSetAlertCustomFieldInput
    {
        [JsonProperty("alert_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AlertId { get; set; }

        [JsonProperty("classifications", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectClassification { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SelectField { get; set; }
    }

    public class CPGetAlertCustomFieldInput
    {
        [JsonProperty("alert_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AlertId { get; set; }

        [JsonProperty("classifications", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectClassification { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SelectField { get; set; }
    }

    public class CPGetIncidentSummaryInput
    {
        [JsonProperty("incident_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IncidentId { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SelectIncidentSummary { get; set; }
    }

    public class CPSetIncidentSummaryInput
    {
        [JsonProperty("incident_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IncidentId { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SelectValue { get; set; }
    }

    public class CPTriggerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectTrigger { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Parameters { get; set; }
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