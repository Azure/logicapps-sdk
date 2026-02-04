//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nitro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NitroActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nitro")]
        public IBodyWorkflowAction<Error> TemplateSignatureRequest(Expression<Func<string>> id, Expression<Func<object>> dynamicSchema = null)
        {
            var apiCallPath = String.Format("/templates/{0}/signature-requests", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicSchema);
            return new ApiConnectionAction<Error>(callPayload);
        }
    }

    public class NitroTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Error> WebhookDocumentSignedTriggerV2(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["endpoint"] = "@listCallbackUrl()";
            requestpropCount++;
            request["event"] = "esign.request.completed";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger<Error>(callPayload, triggerName, recurrence);
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