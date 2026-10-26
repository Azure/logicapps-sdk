//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Slack
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SlackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<SetDNDResponse, ApiConnectionActionConfiguration> SetDND(Expression<Func<string>> numMinutes = null)
        {
            var __workflow_numMinutes = WorkflowExpression.Compile(numMinutes, nameof(numMinutes), required: false);
            return new DeferredBodyAction<SetDNDResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dnd.setSnooze";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_numMinutes != null)
                    callPayload.Queries["num_minutes"] = ExpressionConverter.Convert(__workflow_numMinutes);
                return new ApiConnectionAction<SetDNDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<CreateChannelResponse, ApiConnectionActionConfiguration> CreateChannel(Expression<Func<string>> name = null, Expression<Func<bool>> isPrivate = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_isPrivate = WorkflowExpression.Compile(isPrivate, nameof(isPrivate), required: false);
            return new DeferredBodyAction<CreateChannelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations.create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_isPrivate != null)
                    callPayload.Queries["is_private"] = ExpressionConverter.Convert(__workflow_isPrivate);
                return new ApiConnectionAction<CreateChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<JoinChannelResponseV2, ApiConnectionActionConfiguration> JoinChannel(Expression<Func<string>> channel = null)
        {
            var __workflow_channel = WorkflowExpression.Compile(channel, nameof(channel), required: false);
            return new DeferredBodyAction<JoinChannelResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversations.join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_channel != null)
                    callPayload.Queries["channel"] = ExpressionConverter.Convert(__workflow_channel);
                return new ApiConnectionAction<JoinChannelResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<ListChannelsResponseV3, ApiConnectionActionConfiguration> ListChannels()
        {
            return new DeferredBodyAction<ListChannelsResponseV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/conversations.list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListChannelsResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<PostMessageResponse, ApiConnectionActionConfiguration> PostMessage(Expression<Func<PostMessageV2Input>> message)
        {
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<PostMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/chat.postMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction<PostMessageResponse>(callPayload);
            });
        }
    }

    public class SlackTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewFileResponseItem[], ApiConnectionTriggerConfiguration> OnNewFile(Expression<Func<string>> channel, FlowRecurrence recurrence = null)
        {
            var __workflow_channel = WorkflowExpression.Compile(channel, nameof(channel), required: true);
            return new DeferredBodyTrigger<OnNewFileResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/files.list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channel"] = ExpressionConverter.Convert(__workflow_channel);
                return new ApiConnectionTrigger<OnNewFileResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SetDNDResponse
    {
        [JsonProperty("snooze_enabled")]
        public bool SnoozeEnabled { get; set; }
    }

    public class CreateChannelResponse
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }

    public class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class JoinChannelResponseV2
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("warning")]
        public string Warning { get; set; }
    }

    public class ListChannelsResponseV3
    {
        [JsonProperty("value")]
        public Channel[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class PostMessageResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("ts")]
        public string Ts { get; set; }

        [JsonProperty("message")]
        public PostMessageResponseMessageType Message { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class PostMessageResponseMessageType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ts")]
        public string Ts { get; set; }
    }

    public class PostMessageV2Input
    {
        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessageText { get; set; }

        [JsonProperty("username")]
        public string BotName { get; set; }

        [JsonProperty("as_user")]
        public bool? PostAsUser { get; set; }

        [JsonProperty("parse")]
        public PostMessageV2InputParseModeType? ParseMode { get; set; }

        [JsonProperty("mrkdwn")]
        public bool? SlackMarkupParsing { get; set; }

        [JsonProperty("link_names")]
        public int? LinkNames { get; set; }

        [JsonProperty("unfurl_links")]
        public bool? UnfurlLinks { get; set; }

        [JsonProperty("unfurl_media")]
        public bool? UnfurlMedia { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("icon_emoji")]
        public string IconEmoji { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostMessageV2InputParseModeType
    {
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "none")]
        None
    }

    public class OnNewFileResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Slack;

    public partial class WorkflowManagedActions
    {
        public SlackActions Slack(string connectionId) => new SlackActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SlackTriggers Slack(string connectionId) => new SlackTriggers(connectionId);
    }
}