//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jotformenterprise
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JotformenterpriseActions([ConnectionName] string connectionId)
    {
    }

    public class JotformenterpriseTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionPollingTriggerConfiguration> WebhookTrigger(Expression<Func<string>> workspaceId, Expression<Func<string>> formId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/msflow/v2/forms/{0}/webhooks", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspaceID"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookResponse>(callPayload);
            });
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

    public class BodyInput
    {
        [JsonProperty("callbackURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
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