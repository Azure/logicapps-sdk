//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Slack
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SlackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        [WorkflowExpressionFactory(nameof(__BuildSetDND))]
        public IBodyWorkflowAction<SetDNDResponse> SetDND([WorkflowExpression] Func<string> numMinutes = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetDNDResponse> __BuildSetDND(WorkflowValue<string> numMinutes = null)
        {
            WorkflowValue.Validate(numMinutes, nameof(numMinutes), required: false);
            return new DeferredBodyAction<SetDNDResponse>(() =>
            {
                var apiCallPath = "/dnd.setSnooze";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (numMinutes != null)
                    callPayload.Queries["num_minutes"] = ExpressionConverter.Convert(numMinutes);
                return new ApiConnectionAction<SetDNDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChannel))]
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<bool> isPrivate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateChannelResponse> __BuildCreateChannel(WorkflowValue<string> name = null, WorkflowValue<bool> isPrivate = null)
        {
            WorkflowValue.Validate(name, nameof(name), required: false);
            WorkflowValue.Validate(isPrivate, nameof(isPrivate), required: false);
            return new DeferredBodyAction<CreateChannelResponse>(() =>
            {
                var apiCallPath = "/conversations.create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (isPrivate != null)
                    callPayload.Queries["is_private"] = ExpressionConverter.Convert(isPrivate);
                return new ApiConnectionAction<CreateChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "slack")]
        [WorkflowExpressionFactory(nameof(__BuildJoinChannel))]
        public IBodyWorkflowAction<JoinChannelResponseV2> JoinChannel([WorkflowExpression] Func<string> channel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JoinChannelResponseV2> __BuildJoinChannel(WorkflowValue<string> channel = null)
        {
            WorkflowValue.Validate(channel, nameof(channel), required: false);
            return new DeferredBodyAction<JoinChannelResponseV2>(() =>
            {
                var apiCallPath = "/conversations.join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (channel != null)
                    callPayload.Queries["channel"] = ExpressionConverter.Convert(channel);
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
        [WorkflowExpressionFactory(nameof(__BuildPostMessage))]
        public IBodyWorkflowAction<PostMessageResponse> PostMessage([WorkflowExpression] Func<string> messagechannelName, [WorkflowExpression] Func<string> messagemessageText, [WorkflowExpression] Func<string> messagebotName = null, [WorkflowExpression] Func<bool> messagepostAsUser = null, [WorkflowExpression] Func<messageparseModeInput> messageparseMode = null, [WorkflowExpression] Func<bool> messageslackMarkupParsing = null, [WorkflowExpression] Func<int> messagelinkNames = null, [WorkflowExpression] Func<bool> messageunfurlLinks = null, [WorkflowExpression] Func<bool> messageunfurlMedia = null, [WorkflowExpression] Func<string> messageiconUrl = null, [WorkflowExpression] Func<string> messageiconEmoji = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostMessageResponse> __BuildPostMessage(WorkflowValue<string> messagechannelName, WorkflowValue<string> messagemessageText, WorkflowValue<string> messagebotName = null, WorkflowValue<bool> messagepostAsUser = null, WorkflowValue<messageparseModeInput> messageparseMode = null, WorkflowValue<bool> messageslackMarkupParsing = null, WorkflowValue<int> messagelinkNames = null, WorkflowValue<bool> messageunfurlLinks = null, WorkflowValue<bool> messageunfurlMedia = null, WorkflowValue<string> messageiconUrl = null, WorkflowValue<string> messageiconEmoji = null)
        {
            WorkflowValue.Validate(messagechannelName, nameof(messagechannelName), required: true);
            WorkflowValue.Validate(messagemessageText, nameof(messagemessageText), required: true);
            WorkflowValue.Validate(messagebotName, nameof(messagebotName), required: false);
            WorkflowValue.Validate(messagepostAsUser, nameof(messagepostAsUser), required: false);
            WorkflowValue.Validate(messageparseMode, nameof(messageparseMode), required: false);
            WorkflowValue.Validate(messageslackMarkupParsing, nameof(messageslackMarkupParsing), required: false);
            WorkflowValue.Validate(messagelinkNames, nameof(messagelinkNames), required: false);
            WorkflowValue.Validate(messageunfurlLinks, nameof(messageunfurlLinks), required: false);
            WorkflowValue.Validate(messageunfurlMedia, nameof(messageunfurlMedia), required: false);
            WorkflowValue.Validate(messageiconUrl, nameof(messageiconUrl), required: false);
            WorkflowValue.Validate(messageiconEmoji, nameof(messageiconEmoji), required: false);
            return new DeferredBodyAction<PostMessageResponse>(() =>
            {
                var apiCallPath = "/v2/chat.postMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var message = new JObject();
                var messagepropCount = 0;
                messagepropCount++;
                message["channel"] = ExpressionConverter.ConvertO(messagechannelName);
                messagepropCount++;
                message["text"] = ExpressionConverter.ConvertO(messagemessageText);
                if (messagebotName != null)
                {
                    message["username"] = ExpressionConverter.ConvertO(messagebotName);
                    messagepropCount++;
                }

                if (messagepostAsUser != null)
                {
                    message["as_user"] = ExpressionConverter.ConvertO(messagepostAsUser);
                    messagepropCount++;
                }

                if (messageparseMode != null)
                {
                    message["parse"] = ExpressionConverter.ConvertO(messageparseMode);
                    messagepropCount++;
                }

                if (messageslackMarkupParsing != null)
                {
                    message["mrkdwn"] = ExpressionConverter.ConvertO(messageslackMarkupParsing);
                    messagepropCount++;
                }

                if (messagelinkNames != null)
                {
                    message["link_names"] = ExpressionConverter.ConvertO(messagelinkNames);
                    messagepropCount++;
                }

                if (messageunfurlLinks != null)
                {
                    message["unfurl_links"] = ExpressionConverter.ConvertO(messageunfurlLinks);
                    messagepropCount++;
                }

                if (messageunfurlMedia != null)
                {
                    message["unfurl_media"] = ExpressionConverter.ConvertO(messageunfurlMedia);
                    messagepropCount++;
                }

                if (messageiconUrl != null)
                {
                    message["icon_url"] = ExpressionConverter.ConvertO(messageiconUrl);
                    messagepropCount++;
                }

                if (messageiconEmoji != null)
                {
                    message["icon_emoji"] = ExpressionConverter.ConvertO(messageiconEmoji);
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
        [WorkflowExpressionFactory(nameof(__BuildOnNewFile))]
        public IBodyWorkflowTrigger<OnNewFileResponseItem[]> OnNewFile([WorkflowExpression] Func<string> channel, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewFileResponseItem[]> __BuildOnNewFile(WorkflowValue<string> channel, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(channel, nameof(channel), required: true);
            return new DeferredBodyTrigger<OnNewFileResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/files.list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channel"] = ExpressionConverter.Convert(channel);
                return new ApiConnectionTrigger<OnNewFileResponseItem[]>(callPayload, triggerName, recurrence);
            }, triggerName);
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
