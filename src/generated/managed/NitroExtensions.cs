//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nitro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NitroActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nitro")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateSignatureRequest))]
        public IBodyWorkflowAction<Error> TemplateSignatureRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> dynamicSchema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nitro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Error> __BuildTemplateSignatureRequest(WorkflowExpression<string> id, WorkflowExpression<object> dynamicSchema = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(dynamicSchema, nameof(dynamicSchema), required: false);
            return new DeferredBodyAction<Error>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}/signature-requests", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicSchema);
                return new ApiConnectionAction<Error>(callPayload);
            });
        }
    }

    public class NitroTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Error> WebhookDocumentSignedTrigger(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["endpoint"] = "#{listCallbackUrl()}";
            requestpropCount++;
            request["event"] = "esign.request.completed";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger<Error>(callPayload, recurrence: recurrence);
        }
    }

    public class Error
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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