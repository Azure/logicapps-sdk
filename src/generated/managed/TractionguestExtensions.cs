//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TractionguestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tractionguest")]
        public IWorkflowAction DeleteWebhook(Expression<Func<string>> hookId)
        {
            var apiCallPath = String.Format("/webhooks/{0}", ExpressionConverter.ConvertWithUrlEncoding(hookId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class TractionguestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreatedResponse> CreateInviteWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/invite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["event"] = "invite";
            bodypropCount++;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> CreateSigninWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/signin";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["event"] = "signin";
            bodypropCount++;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> CreateSignoutWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/signout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["event"] = "signout";
            bodypropCount++;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> CreateWatchlistWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/watchlist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["event"] = "watchlist";
            bodypropCount++;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest;

    public partial class WorkflowManagedActions
    {
        public TractionguestActions Tractionguest(string connectionId) => new TractionguestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TractionguestTriggers Tractionguest(string connectionId) => new TractionguestTriggers(connectionId);
    }
}