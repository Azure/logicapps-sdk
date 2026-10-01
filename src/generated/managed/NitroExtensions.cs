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
        public IBodyWorkflowAction<Error> TemplateSignatureRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> dynamicSchema = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templates/{0}/signature-requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicSchema);
                return callPayload;
            }

            return new ApiConnectionAction<Error>(BuildSourceInput);
        }
    }

    public class NitroTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Error> WebhookDocumentSignedTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<Error>(BuildSourceInput, triggerName, recurrence);
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