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
        public IBodyWorkflowAction<ThreadResponse, ApiConnectionActionConfiguration> Thread(Expression<Func<ThreadBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/postThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ThreadDeleteResponse, ApiConnectionActionConfiguration> ThreadDelete(Expression<Func<ThreadDeleteBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ThreadDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreadDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChannelsResponse, ApiConnectionActionConfiguration> Channels()
        {
            return new DeferredBodyAction<ChannelsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChannelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatResponse, ApiConnectionActionConfiguration> Chat(Expression<Func<ChatBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ChatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/postChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatDeleteResponse, ApiConnectionActionConfiguration> ChatDelete(Expression<Func<ChatDeleteBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ChatDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatDeleteResponse>(callPayload);
            });
        }
    }

    public class ThreadsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ThreadResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ThreadResponseResultType Result { get; set; }
    }

    public class ThreadResponseResultType
    {
        [JsonProperty("threadID")]
        public string ThreadId { get; set; }

        [JsonProperty("threadURL")]
        public string ThreadUrl { get; set; }
    }

    public class ThreadBodyInput
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("channelID")]
        public string ChannelId { get; set; }

        [JsonProperty("blocks")]
        public string[] Blocks { get; set; }
    }

    public class ThreadDeleteResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class ThreadDeleteBodyInput
    {
        public ThreadDeleteBodyInput(string threadId)
        {
            this.ThreadId = threadId;
        }

        [JsonProperty("threadID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ThreadId { get; set; }
    }

    public class ChannelsResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ChannelsResponseResultTypeItem[] Result { get; set; }
    }

    public class ChannelsResponseResultTypeItem
    {
        [JsonProperty("channelID")]
        public string ChannelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ChatResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ChatResponseResultType Result { get; set; }
    }

    public class ChatResponseResultType
    {
        [JsonProperty("chatMessageID")]
        public string ChatMessageId { get; set; }

        [JsonProperty("chatMessageURL")]
        public string ChatMessageUrl { get; set; }
    }

    public class ChatBodyInput
    {
        [JsonProperty("chat")]
        public string Chat { get; set; }

        [JsonProperty("chatID")]
        public string ChatId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class ChatDeleteResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class ChatDeleteBodyInput
    {
        [JsonProperty("messageID")]
        public string MessageId { get; set; }
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