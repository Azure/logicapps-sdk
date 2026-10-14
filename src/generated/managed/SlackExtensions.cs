//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Slack
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SlackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<SetDNDResponse> SetDND(Expression<Func<string>> numMinutes = null)
        {
            var __workflow_numMinutes = numMinutes == null ? null : WorkflowExpression.Compile(numMinutes);
            WorkflowExpression.Validate(__workflow_numMinutes, nameof(numMinutes), required: false);
            return new DeferredBodyAction<SetDNDResponse>(() =>
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
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel(Expression<Func<string>> name = null, Expression<Func<bool>> isPrivate = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_isPrivate = isPrivate == null ? null : WorkflowExpression.Compile(isPrivate);
            WorkflowExpression.Validate(__workflow_isPrivate, nameof(isPrivate), required: false);
            return new DeferredBodyAction<CreateChannelResponse>(() =>
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
        public IBodyWorkflowAction<JoinChannelResponseV2> JoinChannel(Expression<Func<string>> channel = null)
        {
            var __workflow_channel = channel == null ? null : WorkflowExpression.Compile(channel);
            WorkflowExpression.Validate(__workflow_channel, nameof(channel), required: false);
            return new DeferredBodyAction<JoinChannelResponseV2>(() =>
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
        public IBodyWorkflowAction<ListChannelsResponseV3> ListChannels()
        {
            var apiCallPath = "/v3/conversations.list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListChannelsResponseV3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<PostMessageResponse> PostMessage(Expression<Func<string>> messagechannelName, Expression<Func<string>> messagemessageText, Expression<Func<string>> messagebotName = null, Expression<Func<bool>> messagepostAsUser = null, Expression<Func<messageparseModeInput>> messageparseMode = null, Expression<Func<bool>> messageslackMarkupParsing = null, Expression<Func<int>> messagelinkNames = null, Expression<Func<bool>> messageunfurlLinks = null, Expression<Func<bool>> messageunfurlMedia = null, Expression<Func<string>> messageiconUrl = null, Expression<Func<string>> messageiconEmoji = null)
        {
            var __workflow_messagechannelName = messagechannelName == null ? null : WorkflowExpression.Compile(messagechannelName);
            WorkflowExpression.Validate(__workflow_messagechannelName, nameof(messagechannelName), required: true);
            var __workflow_messagemessageText = messagemessageText == null ? null : WorkflowExpression.Compile(messagemessageText);
            WorkflowExpression.Validate(__workflow_messagemessageText, nameof(messagemessageText), required: true);
            var __workflow_messagebotName = messagebotName == null ? null : WorkflowExpression.Compile(messagebotName);
            WorkflowExpression.Validate(__workflow_messagebotName, nameof(messagebotName), required: false);
            var __workflow_messagepostAsUser = messagepostAsUser == null ? null : WorkflowExpression.Compile(messagepostAsUser);
            WorkflowExpression.Validate(__workflow_messagepostAsUser, nameof(messagepostAsUser), required: false);
            var __workflow_messageparseMode = messageparseMode == null ? null : WorkflowExpression.Compile(messageparseMode);
            WorkflowExpression.Validate(__workflow_messageparseMode, nameof(messageparseMode), required: false);
            var __workflow_messageslackMarkupParsing = messageslackMarkupParsing == null ? null : WorkflowExpression.Compile(messageslackMarkupParsing);
            WorkflowExpression.Validate(__workflow_messageslackMarkupParsing, nameof(messageslackMarkupParsing), required: false);
            var __workflow_messagelinkNames = messagelinkNames == null ? null : WorkflowExpression.Compile(messagelinkNames);
            WorkflowExpression.Validate(__workflow_messagelinkNames, nameof(messagelinkNames), required: false);
            var __workflow_messageunfurlLinks = messageunfurlLinks == null ? null : WorkflowExpression.Compile(messageunfurlLinks);
            WorkflowExpression.Validate(__workflow_messageunfurlLinks, nameof(messageunfurlLinks), required: false);
            var __workflow_messageunfurlMedia = messageunfurlMedia == null ? null : WorkflowExpression.Compile(messageunfurlMedia);
            WorkflowExpression.Validate(__workflow_messageunfurlMedia, nameof(messageunfurlMedia), required: false);
            var __workflow_messageiconUrl = messageiconUrl == null ? null : WorkflowExpression.Compile(messageiconUrl);
            WorkflowExpression.Validate(__workflow_messageiconUrl, nameof(messageiconUrl), required: false);
            var __workflow_messageiconEmoji = messageiconEmoji == null ? null : WorkflowExpression.Compile(messageiconEmoji);
            WorkflowExpression.Validate(__workflow_messageiconEmoji, nameof(messageiconEmoji), required: false);
            return new DeferredBodyAction<PostMessageResponse>(() =>
            {
                var apiCallPath = "/v2/chat.postMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var message = new JObject();
                var messagepropCount = 0;
                messagepropCount++;
                message["channel"] = ExpressionConverter.ConvertO(__workflow_messagechannelName);
                messagepropCount++;
                message["text"] = ExpressionConverter.ConvertO(__workflow_messagemessageText);
                if (__workflow_messagebotName != null)
                {
                    message["username"] = ExpressionConverter.ConvertO(__workflow_messagebotName);
                    messagepropCount++;
                }

                if (__workflow_messagepostAsUser != null)
                {
                    message["as_user"] = ExpressionConverter.ConvertO(__workflow_messagepostAsUser);
                    messagepropCount++;
                }

                if (__workflow_messageparseMode != null)
                {
                    message["parse"] = ExpressionConverter.ConvertO(__workflow_messageparseMode);
                    messagepropCount++;
                }

                if (__workflow_messageslackMarkupParsing != null)
                {
                    message["mrkdwn"] = ExpressionConverter.ConvertO(__workflow_messageslackMarkupParsing);
                    messagepropCount++;
                }

                if (__workflow_messagelinkNames != null)
                {
                    message["link_names"] = ExpressionConverter.ConvertO(__workflow_messagelinkNames);
                    messagepropCount++;
                }

                if (__workflow_messageunfurlLinks != null)
                {
                    message["unfurl_links"] = ExpressionConverter.ConvertO(__workflow_messageunfurlLinks);
                    messagepropCount++;
                }

                if (__workflow_messageunfurlMedia != null)
                {
                    message["unfurl_media"] = ExpressionConverter.ConvertO(__workflow_messageunfurlMedia);
                    messagepropCount++;
                }

                if (__workflow_messageiconUrl != null)
                {
                    message["icon_url"] = ExpressionConverter.ConvertO(__workflow_messageiconUrl);
                    messagepropCount++;
                }

                if (__workflow_messageiconEmoji != null)
                {
                    message["icon_emoji"] = ExpressionConverter.ConvertO(__workflow_messageiconEmoji);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }

                return new ApiConnectionAction<PostMessageResponse>(callPayload);
            });
        }
    }

    public class SlackTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewFileResponseItem[]> OnNewFile(Expression<Func<string>> channel, FlowRecurrence recurrence = null)
        {
            var __workflow_channel = channel == null ? null : WorkflowExpression.Compile(channel);
            WorkflowExpression.Validate(__workflow_channel, nameof(channel), required: true);
            return new DeferredBodyTrigger<OnNewFileResponseItem[]>(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum messageparseModeInput
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
