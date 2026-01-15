//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Typeform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TypeformActions([ConnectionName] string connectionId)
    {
    }

    public class TypeformTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<WebhookCreationResponse> NewResponseWebhook(Expression<Func<string>> formId, Expression<Func<string>> tag, Expression<Func<bool>> bodyenabled = null)
        {
            var apiCallPath = String.Format("/forms/{0}/webhooks/{1}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(tag, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodyenabled != null)
            {
                body["enabled"] = ExpressionConverter.ConvertO(bodyenabled);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<WebhookCreationResponse> NewResponseWebhookV2(Expression<Func<string>> formId, Expression<Func<string>> tag)
        {
            var apiCallPath = String.Format("/v2/forms/{0}/webhooks/{1}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(tag, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            body["enabled"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload);
        }
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Typeform;

    public partial class WorkflowManagedActions
    {
        public TypeformActions Typeform(string connectionId) => new TypeformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TypeformTriggers Typeform(string connectionId) => new TypeformTriggers(connectionId);
    }
}