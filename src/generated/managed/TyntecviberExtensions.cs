//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tyntecviber
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecviberActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecviber")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheckV3(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
        }
    }

    public class TyntecviberTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger IncomingV3(Expression<Func<string>> viberServiceId)
        {
            var apiCallPath = String.Format("/conversations/v3/power-automate/webhooks/channels/viber/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(viberServiceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["inboundMessageUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("deliveryChannel")]
        public string DeliveryChannel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Tyntecviber;

    public partial class WorkflowManagedActions
    {
        public TyntecviberActions Tyntecviber(string connectionId) => new TyntecviberActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TyntecviberTriggers Tyntecviber(string connectionId) => new TyntecviberTriggers(connectionId);
    }
}