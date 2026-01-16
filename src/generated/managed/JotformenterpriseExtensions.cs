//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jotformenterprise
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JotformenterpriseActions([ConnectionName] string connectionId)
    {
    }

    public class JotformenterpriseTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<WebhookResponse> WebhookTriggerV2(Expression<Func<string>> workspaceID, Expression<Func<string>> formID)
        {
            var apiCallPath = String.Format("/msflow/v2/forms/{0}/webhooks", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["workspaceID"] = ExpressionConverter.Convert(workspaceID);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackURL"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookResponse>(callPayload);
        }
    }

    public class WebhookResponse
    {
        [JsonProperty("content")]
        public WebhookResponseContentType Content { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("responseCode")]
        public int ResponseCode { get; set; }
    }

    public class WebhookResponseContentType
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("webhookDeleteUrl")]
        public string WebhookDeleteUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jotformenterprise;

    public partial class WorkflowManagedActions
    {
        public JotformenterpriseActions Jotformenterprise(string connectionId) => new JotformenterpriseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JotformenterpriseTriggers Jotformenterprise(string connectionId) => new JotformenterpriseTriggers(connectionId);
    }
}