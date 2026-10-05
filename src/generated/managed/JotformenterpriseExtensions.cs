//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jotformenterprise
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JotformenterpriseActions([ConnectionName] string connectionId)
    {
    }

    public class JotformenterpriseTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildWebhookTrigger))]
        public IBodyWorkflowTrigger<WebhookResponse> WebhookTrigger([WorkflowExpression] Func<string> workspaceID, [WorkflowExpression] Func<string> formID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookResponse> __BuildWebhookTrigger(WorkflowValue<string> workspaceID, WorkflowValue<string> formID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(workspaceID, nameof(workspaceID), required: true);
            WorkflowValue.Validate(formID, nameof(formID), required: true);
            return new DeferredBodyTrigger<WebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/msflow/v2/forms/{0}/webhooks", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspaceID"] = ExpressionConverter.Convert(workspaceID);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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

namespace Microsoft.Azure.Workflows.Sdk
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
