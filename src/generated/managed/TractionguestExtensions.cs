//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TractionguestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tractionguest")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWebhook(Expression<Func<string>> hookId)
        {
            var __workflow_hookId = WorkflowExpression.Compile(hookId, nameof(hookId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/{0}", __workflow_hookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TractionguestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> CreateInviteWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/invite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInviteWebhookBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> CreateSigninWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/signin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateSigninWebhookBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> CreateSignoutWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/signout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateSignoutWebhookBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> CreateWatchlistWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/watchlist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateWatchlistWebhookBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateInviteWebhookBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEventType Event { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest.BodyInputEventType.Invite;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventType
    {
        [EnumMember(Value = "signin")]
        Signin,
        [EnumMember(Value = "signout")]
        Signout,
        [EnumMember(Value = "watchlist")]
        Watchlist,
        [EnumMember(Value = "invite")]
        Invite
    }

    public class CreateSigninWebhookBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEventType Event { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest.BodyInputEventType.Signin;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateSignoutWebhookBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEventType Event { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest.BodyInputEventType.Signout;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateWatchlistWebhookBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEventType Event { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tractionguest.BodyInputEventType.Watchlist;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
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