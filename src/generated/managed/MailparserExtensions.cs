//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailparser
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailparserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailparser")]
        public IBodyWorkflowAction<InboxListResponse> InboxList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/inboxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InboxListResponse>(BuildSourceInput);
        }
    }

    public class MailparserTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse> WebhookCreate([WorkflowExpression] Func<string> inboxId, [WorkflowExpression] Func<string> requestBodyOfWebhooklabel = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/inboxes/{0}/dispatcher", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inboxId, 1));
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
                    requestBodyOfWebhook["label"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhooklabel);
                    requestBodyOfWebhookpropCount++;
                }

                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookCreationResponse>(BuildSourceInput, triggerName, recurrence);
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