//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Honeywellforge
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HoneywellforgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IBodyWorkflowAction<CloseCaseResponse, ApiConnectionActionConfiguration> CloseServiceCaseAtForge(Expression<Func<string>> projectId, Expression<Func<string>> serviceCaseNumber, Expression<Func<CloseServiceCaseAtForgeInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_serviceCaseNumber = WorkflowExpression.Compile(serviceCaseNumber, nameof(serviceCaseNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CloseCaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/service-cases/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_serviceCaseNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CloseCaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEventToForge(Expression<Func<string>> projectId, Expression<Func<SendEventToForgeInput>> body = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/transactionEvent", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HoneywellforgeTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ServiceCaseCreated(Expression<Func<string>> projectId, Expression<Func<string>> connectorId, Expression<Func<ServiceCaseCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_connectorId = WorkflowExpression.Compile(connectorId, nameof(connectorId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/webhooks/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_connectorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CloseCaseResponse
    {
        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }
    }

    public class CloseServiceCaseAtForgeInput
    {
        [JsonProperty("siteId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteId { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "Closed";

        [JsonProperty("workOrderIDs")]
        public string WorkOrderIDs { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Priority { get; set; } = "Medium";

        [JsonProperty("resolutionText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResolutionText { get; set; }

        [JsonProperty("resolutionCode")]
        public string ResolutionCode { get; set; }

        [JsonProperty("rootCauseCode")]
        public string RootCauseCode { get; set; }

        [JsonProperty("serviceCaseClosedOn")]
        public int? ServiceCaseClosedOn { get; set; }
    }

    public class SendEventToForgeInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventName { get; set; } = "defaultEvent";

        [JsonProperty("eventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventType { get; set; } = "defaultEventType";

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; } = "defaultMessage";

        [JsonProperty("corelationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; } = "defaultCorrelationID";

        [JsonProperty("connectorId")]
        public string ConnectorId { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Source { get; set; } = "defaultSource";
    }

    public class ServiceCaseCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Honeywellforge;

    public partial class WorkflowManagedActions
    {
        public HoneywellforgeActions Honeywellforge(string connectionId) => new HoneywellforgeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HoneywellforgeTriggers Honeywellforge(string connectionId) => new HoneywellforgeTriggers(connectionId);
    }
}