//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailparser
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailparserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailparser")]
        public IBodyWorkflowAction<InboxListResponse> InboxList()
        {
            var apiCallPath = "/inboxes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<InboxListResponse>(callPayload);
        }
    }

    public class MailparserTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhookCreate))]
        public IBodyWorkflowTrigger<WebhookCreationResponse> WebhookCreate([WorkflowExpression] Func<string> inboxId,[WorkflowExpression] Func<string> requestBodyOfWebhooklabel = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookCreationResponse> __BuildWebhookCreate(WorkflowExpression<string> inboxId,WorkflowExpression<string> requestBodyOfWebhooklabel = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(inboxId, nameof(inboxId), required: true);
            WorkflowExpression.Validate(requestBodyOfWebhooklabel, nameof(requestBodyOfWebhooklabel), required: false);
            return new DeferredBodyTrigger<WebhookCreationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/inboxes/{0}/dispatcher", ExpressionConverter.ConvertWithUrlEncoding(inboxId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["target_url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["provider"] = "flow";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhooklabel != null)
                {
                    requestBodyOfWebhook["label"] = ExpressionConverter.ConvertO(requestBodyOfWebhooklabel);
                    requestBodyOfWebhookpropCount++;
                }

                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

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