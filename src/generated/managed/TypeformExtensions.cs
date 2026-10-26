//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Typeform
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TypeformActions([ConnectionName] string connectionId)
    {
    }

    public class TypeformTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> NewResponseWebhook(Expression<Func<string>> formId, Expression<Func<string>> tag, Expression<Func<NewResponseWebhookV2Input>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/forms/{0}/webhooks/{1}", __workflow_formId.WithUrlEncoding(1), __workflow_tag.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
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

    public class NewResponseWebhookV2Input
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Enabled { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Typeform;

    public partial class WorkflowManagedActions
    {
        public TypeformActions Typeform(string connectionId) => new TypeformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TypeformTriggers Typeform(string connectionId) => new TypeformTriggers(connectionId);
    }
}