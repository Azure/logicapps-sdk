//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nitro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NitroActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nitro")]
        public IBodyWorkflowAction<Error, ApiConnectionActionConfiguration> TemplateSignatureRequest(Expression<Func<string>> id, Expression<Func<object>> dynamicSchema = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_dynamicSchema = WorkflowExpression.Compile(dynamicSchema, nameof(dynamicSchema), required: false);
            return new DeferredBodyAction<Error, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}/signature-requests", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicSchema);
                return new ApiConnectionAction<Error>(callPayload);
            });
        }
    }

    public class NitroTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Error, ApiConnectionTriggerConfiguration> WebhookDocumentSignedTrigger(Expression<Func<WebhookDocumentSignedTriggerV2Input>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyTrigger<Error, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger<Error>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Error
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class WebhookDocumentSignedTriggerV2Input
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "esign.request.completed";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nitro;

    public partial class WorkflowManagedActions
    {
        public NitroActions Nitro(string connectionId) => new NitroActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NitroTriggers Nitro(string connectionId) => new NitroTriggers(connectionId);
    }
}