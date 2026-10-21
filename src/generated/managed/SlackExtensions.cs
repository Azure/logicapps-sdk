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
        public IBodyWorkflowAction<SetDNDResponse> SetDND(Expression<Func<string>> numMinutes = null)
        {
            var __workflow_numMinutes = WorkflowExpression.Compile(numMinutes, nameof(numMinutes), required: false);
            return new DeferredBodyAction<SetDNDResponse>(() =>
            {
                var apiCallPath = "/dnd.setSnooze";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_numMinutes != null)
                    callPayload.Queries["num_minutes"] = ExpressionConverter.Convert(__workflow_numMinutes);
                return new ApiConnectionAction<SetDNDResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel(Expression<Func<string>> name = null, Expression<Func<bool>> isPrivate = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_isPrivate = WorkflowExpression.Compile(isPrivate, nameof(isPrivate), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        public IBodyWorkflowAction<JoinChannelResponseV2> JoinChannel(Expression<Func<string>> channel = null)
        {
            var __workflow_channel = WorkflowExpression.Compile(channel, nameof(channel), required: false);
            return new DeferredBodyAction<JoinChannelResponseV2>(() =>
            {
                var apiCallPath = "/conversations.join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_channel != null)
                    callPayload.Queries["channel"] = ExpressionConverter.Convert(__workflow_channel);
                return new ApiConnectionAction<JoinChannelResponseV2>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
            var __workflow_messagechannelName = WorkflowExpression.Compile(messagechannelName, nameof(messagechannelName), required: true);
            var __workflow_messagemessageText = WorkflowExpression.Compile(messagemessageText, nameof(messagemessageText), required: true);
            var __workflow_messagebotName = WorkflowExpression.Compile(messagebotName, nameof(messagebotName), required: false);
            var __workflow_messagepostAsUser = WorkflowExpression.Compile(messagepostAsUser, nameof(messagepostAsUser), required: false);
            var __workflow_messageparseMode = WorkflowExpression.Compile(messageparseMode, nameof(messageparseMode), required: false);
            var __workflow_messageslackMarkupParsing = WorkflowExpression.Compile(messageslackMarkupParsing, nameof(messageslackMarkupParsing), required: false);
            var __workflow_messagelinkNames = WorkflowExpression.Compile(messagelinkNames, nameof(messagelinkNames), required: false);
            var __workflow_messageunfurlLinks = WorkflowExpression.Compile(messageunfurlLinks, nameof(messageunfurlLinks), required: false);
            var __workflow_messageunfurlMedia = WorkflowExpression.Compile(messageunfurlMedia, nameof(messageunfurlMedia), required: false);
            var __workflow_messageiconUrl = WorkflowExpression.Compile(messageiconUrl, nameof(messageiconUrl), required: false);
            var __workflow_messageiconEmoji = WorkflowExpression.Compile(messageiconEmoji, nameof(messageiconEmoji), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class SlackTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewFileResponseItem[]> OnNewFile(Expression<Func<string>> channel, FlowRecurrence recurrence = null)
        {
            var __workflow_channel = WorkflowExpression.Compile(channel, nameof(channel), required: true);
            return new DeferredBodyTrigger<OnNewFileResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/files.list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channel"] = ExpressionConverter.Convert(__workflow_channel);
                return new ApiConnectionTrigger<OnNewFileResponseItem[]>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
