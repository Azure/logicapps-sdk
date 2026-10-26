//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailparser
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailparserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailparser")]
        public IBodyWorkflowAction<InboxListResponse, ApiConnectionActionConfiguration> InboxList()
        {
            return new DeferredBodyAction<InboxListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inboxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InboxListResponse>(callPayload);
            });
        }
    }

    public class MailparserTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> WebhookCreate(Expression<Func<string>> inboxId, Expression<Func<WebhookCreateInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_inboxId = WorkflowExpression.Compile(inboxId, nameof(inboxId), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inboxes/{0}/dispatcher", __workflow_inboxId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class InboxListResponse
    {
        [JsonProperty("data")]
        public Inbox[] Data { get; set; }
    }

    public class Inbox
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("data")]
        public WebhookCreationResponseDataType Data { get; set; }
    }

    public class WebhookCreationResponseDataType
    {
        [JsonProperty("dispatcher_id")]
        public string DispatcherId { get; set; }
    }

    public class WebhookCreateInput
    {
        [JsonProperty("target_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("provider", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Provider { get; set; } = "flow";

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailparser;

    public partial class WorkflowManagedActions
    {
        public MailparserActions Mailparser(string connectionId) => new MailparserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailparserTriggers Mailparser(string connectionId) => new MailparserTriggers(connectionId);
    }
}