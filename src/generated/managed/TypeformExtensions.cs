//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Typeform
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
        public IBodyWorkflowTrigger<WebhookCreationResponse> NewResponseWebhook([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> tag, [WorkflowExpression] Func<bool> bodyenabled = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(tag, nameof(tag), required: true);
            SourceExpression.Validate(bodyenabled, nameof(bodyenabled), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/forms/{0}/webhooks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tag, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodyenabled != null)
                {
                    body["enabled"] = SourceExpressionConverter.ConvertToken(bodyenabled);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookCreationResponse>(BuildSourceInput, triggerName, recurrence);
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