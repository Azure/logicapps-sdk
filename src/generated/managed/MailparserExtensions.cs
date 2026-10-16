//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailparser
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowTrigger<WebhookCreationResponse> WebhookCreate(Expression<Func<string>> inboxId, Expression<Func<string>> requestBodyOfWebhooklabel = null, FlowRecurrence recurrence = null)
        {
            var __workflow_inboxId = WorkflowExpression.Compile(inboxId, nameof(inboxId), required: true);
            var __workflow_requestBodyOfWebhooklabel = WorkflowExpression.Compile(requestBodyOfWebhooklabel, nameof(requestBodyOfWebhooklabel), required: false);
            return new DeferredBodyTrigger<WebhookCreationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/inboxes/{0}/dispatcher", ExpressionConverter.ConvertWithUrlEncoding(__workflow_inboxId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["target_url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["provider"] = "flow";
                requestBodyOfWebhookpropCount++;
                if (__workflow_requestBodyOfWebhooklabel != null)
                {
                    requestBodyOfWebhook["label"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhooklabel);
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
