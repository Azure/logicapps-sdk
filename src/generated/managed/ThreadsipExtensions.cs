//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Threadsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThreadsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ThreadPostResponse, ApiConnectionActionConfiguration> Thread(Expression<Func<string>> bodychannel = null, Expression<Func<string>> bodychannelId = null, Expression<Func<string[]>> bodyblocks = null)
        {
            var __workflow_bodychannel = WorkflowExpression.Compile(bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodychannelId = WorkflowExpression.Compile(bodychannelId, nameof(bodychannelId), required: false);
            var __workflow_bodyblocks = WorkflowExpression.Compile(bodyblocks, nameof(bodyblocks), required: false);
            return new DeferredBodyAction<ThreadPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/postThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                    bodypropCount++;
                }

                if (__workflow_bodychannelId != null)
                {
                    body["channelID"] = ExpressionConverter.ConvertO(__workflow_bodychannelId);
                    bodypropCount++;
                }

                if (__workflow_bodyblocks != null)
                {
                    body["blocks"] = ExpressionConverter.ConvertO(__workflow_bodyblocks);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ThreadDeleteResponse, ApiConnectionActionConfiguration> ThreadDelete(Expression<Func<string>> bodythreadId)
        {
            var __workflow_bodythreadId = WorkflowExpression.Compile(bodythreadId, nameof(bodythreadId), required: true);
            return new DeferredBodyAction<ThreadDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["threadID"] = ExpressionConverter.ConvertO(__workflow_bodythreadId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChannelsPostResponse, ApiConnectionActionConfiguration> Channels()
        {
            return new DeferredBodyAction<ChannelsPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChannelsPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatPostResponse, ApiConnectionActionConfiguration> Chat(Expression<Func<string>> bodychat = null, Expression<Func<string>> bodychatId = null, Expression<Func<string>> bodybody = null)
        {
            var __workflow_bodychat = WorkflowExpression.Compile(bodychat, nameof(bodychat), required: false);
            var __workflow_bodychatId = WorkflowExpression.Compile(bodychatId, nameof(bodychatId), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<ChatPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/postChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodychat != null)
                {
                    body["chat"] = ExpressionConverter.ConvertO(__workflow_bodychat);
                    bodypropCount++;
                }

                if (__workflow_bodychatId != null)
                {
                    body["chatID"] = ExpressionConverter.ConvertO(__workflow_bodychatId);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatDeleteResponse, ApiConnectionActionConfiguration> ChatDelete(Expression<Func<string>> bodymessageId = null)
        {
            var __workflow_bodymessageId = WorkflowExpression.Compile(bodymessageId, nameof(bodymessageId), required: false);
            return new DeferredBodyAction<ChatDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessageId != null)
                {
                    body["messageID"] = ExpressionConverter.ConvertO(__workflow_bodymessageId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatDeleteResponse>(callPayload);
            });
        }
    }

    public class ThreadsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ThreadPostResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ThreadPostResponseResultType Result { get; set; }
    }

    public class ThreadPostResponseResultType
    {
        [JsonProperty("threadID")]
        public string ThreadId { get; set; }

        [JsonProperty("threadURL")]
        public string ThreadURL { get; set; }
    }

    public class ThreadDeleteResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class ChannelsPostResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ChannelsPostResponseResultTypeItem[] Result { get; set; }
    }

    public class ChannelsPostResponseResultTypeItem
    {
        [JsonProperty("channelID")]
        public string ChannelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ChatPostResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ChatPostResponseResultType Result { get; set; }
    }

    public class ChatPostResponseResultType
    {
        [JsonProperty("chatMessageID")]
        public string ChatMessageId { get; set; }

        [JsonProperty("chatMessageURL")]
        public string ChatMessageURL { get; set; }
    }

    public class ChatDeleteResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Threadsip;

    public partial class WorkflowManagedActions
    {
        public ThreadsipActions Threadsip(string connectionId) => new ThreadsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThreadsipTriggers Threadsip(string connectionId) => new ThreadsipTriggers(connectionId);
    }
}