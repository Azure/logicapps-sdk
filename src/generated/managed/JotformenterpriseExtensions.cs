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
        public IBodyWorkflowTrigger<WebhookResponse> WebhookTrigger([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/msflow/v2/forms/{0}/webhooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspaceID"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookResponse>(BuildSourceInput, triggerName, recurrence);
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