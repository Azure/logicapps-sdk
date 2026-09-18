//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Threadsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThreadsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ThreadPostResponse> Thread([WorkflowExpression] Func<string> bodychannel = null, [WorkflowExpression] Func<string> bodychannelID = null, [WorkflowExpression] Func<string[]> bodyblocks = null)
        {
            SourceExpression.Validate(bodychannel, nameof(bodychannel), required: false);
            SourceExpression.Validate(bodychannelID, nameof(bodychannelID), required: false);
            SourceExpression.Validate(bodyblocks, nameof(bodyblocks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/postThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodychannel != null)
                {
                    body["channel"] = SourceExpressionConverter.ConvertToken(bodychannel);
                    bodypropCount++;
                }

                if (bodychannelID != null)
                {
                    body["channelID"] = SourceExpressionConverter.ConvertToken(bodychannelID);
                    bodypropCount++;
                }

                if (bodyblocks != null)
                {
                    body["blocks"] = SourceExpressionConverter.ConvertToken(bodyblocks);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ThreadPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ThreadDeleteResponse> ThreadDelete([WorkflowExpression] Func<string> bodythreadID)
        {
            SourceExpression.Validate(bodythreadID, nameof(bodythreadID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["threadID"] = SourceExpressionConverter.ConvertToken(bodythreadID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ThreadDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChannelsPostResponse> Channels()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ChannelsPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatPostResponse> Chat([WorkflowExpression] Func<string> bodychat = null, [WorkflowExpression] Func<string> bodychatID = null, [WorkflowExpression] Func<string> bodybody = null)
        {
            SourceExpression.Validate(bodychat, nameof(bodychat), required: false);
            SourceExpression.Validate(bodychatID, nameof(bodychatID), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/postChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodychat != null)
                {
                    body["chat"] = SourceExpressionConverter.ConvertToken(bodychat);
                    bodypropCount++;
                }

                if (bodychatID != null)
                {
                    body["chatID"] = SourceExpressionConverter.ConvertToken(bodychatID);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChatPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<ChatDeleteResponse> ChatDelete([WorkflowExpression] Func<string> bodymessageID = null)
        {
            SourceExpression.Validate(bodymessageID, nameof(bodymessageID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteChatMessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessageID != null)
                {
                    body["messageID"] = SourceExpressionConverter.ConvertToken(bodymessageID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChatDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "threadsip")]
        public IBodyWorkflowAction<FilePostResponse> File([WorkflowExpression] Func<object> data = null)
        {
            SourceExpression.Validate(data, nameof(data), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/uploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilePostResponse>(BuildSourceInput);
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