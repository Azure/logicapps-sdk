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
        public IBodyWorkflowAction<ThreadPostResponse> Thread(Expression<Func<string>> bodychannel = null, Expression<Func<string>> bodychannelID = null, Expression<Func<string[]>> bodyblocks = null)
        {
            var __workflow_bodychannel = WorkflowExpression.Compile(bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodychannelID = WorkflowExpression.Compile(bodychannelID, nameof(bodychannelID), required: false);
            var __workflow_bodyblocks = WorkflowExpression.Compile(bodyblocks, nameof(bodyblocks), required: false);
            return new DeferredBodyAction<ThreadPostResponse>(() =>
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

                if (__workflow_bodychannelID != null)
                {
                    body["channelID"] = ExpressionConverter.ConvertO(__workflow_bodychannelID);
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
        public IBodyWorkflowAction<ThreadDeleteResponse> ThreadDelete(Expression<Func<string>> bodythreadID)
        {
            var __workflow_bodythreadID = WorkflowExpression.Compile(bodythreadID, nameof(bodythreadID), required: true);
            return new DeferredBodyAction<ThreadDeleteResponse>(() =>
            {
                var apiCallPath = "/deleteThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["threadID"] = ExpressionConverter.ConvertO(__workflow_bodythreadID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChannelsPostResponse> Channels()
        {
            var apiCallPath = "/channels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ChannelsPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatPostResponse> Chat(Expression<Func<string>> bodychat = null, Expression<Func<string>> bodychatID = null, Expression<Func<string>> bodybody = null)
        {
            var __workflow_bodychat = WorkflowExpression.Compile(bodychat, nameof(bodychat), required: false);
            var __workflow_bodychatID = WorkflowExpression.Compile(bodychatID, nameof(bodychatID), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<ChatPostResponse>(() =>
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

                if (__workflow_bodychatID != null)
                {
                    body["chatID"] = ExpressionConverter.ConvertO(__workflow_bodychatID);
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
        public IBodyWorkflowAction<ChatDeleteResponse> ChatDelete(Expression<Func<string>> bodymessageID = null)
        {
            var __workflow_bodymessageID = WorkflowExpression.Compile(bodymessageID, nameof(bodymessageID), required: false);
            return new DeferredBodyAction<ChatDeleteResponse>(() =>
            {
                var apiCallPath = "/deleteChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessageID != null)
                {
                    body["messageID"] = ExpressionConverter.ConvertO(__workflow_bodymessageID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChatDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<FilePostResponse> File(Expression<Func<object>> data = null)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: false);
            return new DeferredBodyAction<FilePostResponse>(() =>
            {
                var apiCallPath = "/uploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FilePostResponse>(callPayload);
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
        public string ThreadID { get; set; }

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
        public string ChannelID { get; set; }

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
        public string ChatMessageID { get; set; }

        [JsonProperty("chatMessageURL")]
        public string ChatMessageURL { get; set; }
    }

    public class ChatDeleteResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public class FilePostResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public FilePostResponseResultType Result { get; set; }
    }

    public class FilePostResponseResultType
    {
        [JsonProperty("fileID")]
        public string FileID { get; set; }
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
