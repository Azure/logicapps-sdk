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
        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration> CreateInviteWebhook(Expression<Func<CreateInviteWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/invite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration> CreateSigninWebhook(Expression<Func<CreateSigninWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/signin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration> CreateSignoutWebhook(Expression<Func<CreateSignoutWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/signout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration> CreateWatchlistWebhook(Expression<Func<CreateWatchlistWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/watchlist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateInviteWebhookInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateInviteWebhookInputEventType Event { get; set; } = CreateInviteWebhookInputEventType.Invite;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateInviteWebhookInputEventType
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

    public class CreateSigninWebhookInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateSigninWebhookInputEventType Event { get; set; } = CreateSigninWebhookInputEventType.Signin;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSigninWebhookInputEventType
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

    public class CreateSignoutWebhookInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateSignoutWebhookInputEventType Event { get; set; } = CreateSignoutWebhookInputEventType.Signout;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSignoutWebhookInputEventType
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

    public class CreateWatchlistWebhookInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWatchlistWebhookInputEventType Event { get; set; } = CreateWatchlistWebhookInputEventType.Watchlist;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWatchlistWebhookInputEventType
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