//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Typeform
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TypeformActions([ConnectionName] string connectionId)
    {
    }

    public class TypeformTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildNewResponseWebhook))]
        public IBodyWorkflowTrigger<WebhookCreationResponse> NewResponseWebhook([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> tag, [WorkflowExpression] Func<bool> bodyenabled = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookCreationResponse> __BuildNewResponseWebhook(WorkflowExpression<string> formId, WorkflowExpression<string> tag, WorkflowExpression<bool> bodyenabled = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(tag, nameof(tag), required: true);
            WorkflowExpression.Validate(bodyenabled, nameof(bodyenabled), required: false);
            return new DeferredBodyTrigger<WebhookCreationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/forms/{0}/webhooks/{1}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(tag, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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