//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acschat
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcschatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildListMessages))]
        public IBodyWorkflowAction<ListMessagesResponse> ListMessages([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> maxPageSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListMessagesResponse> __BuildListMessages(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId, WorkflowValue<string> startTime = null, WorkflowValue<string> maxPageSize = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(maxPageSize, nameof(maxPageSize), required: false);
            return new DeferredBodyAction<ListMessagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
                if (maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = ExpressionConverter.Convert(maxPageSize);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction<ListMessagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildSendChat))]
        public IBodyWorkflowAction<SendChatResponse> SendChat([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<string> bodysenderDisplayName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendChatResponse> __BuildSendChat(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId, WorkflowValue<string> bodycontent, WorkflowValue<string> bodysenderDisplayName)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            WorkflowValue.Validate(bodycontent, nameof(bodycontent), required: true);
            WorkflowValue.Validate(bodysenderDisplayName, nameof(bodysenderDisplayName), required: true);
            return new DeferredBodyAction<SendChatResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
                body["senderDisplayName"] = ExpressionConverter.ConvertO(bodysenderDisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildAddParticipants))]
        public IBodyWorkflowAction<AddParticipantsResponse> AddParticipants([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<bodyparticipantsInputItem[]> bodyparticipants = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddParticipantsResponse> __BuildAddParticipants(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId, WorkflowValue<bodyparticipantsInputItem[]> bodyparticipants = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            WorkflowValue.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredBodyAction<AddParticipantsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/participants/:add", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveParticipant))]
        public IWorkflowAction RemoveParticipant([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> bodycommunicationUseruserID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveParticipant(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId, WorkflowValue<string> bodycommunicationUseruserID = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            WorkflowValue.Validate(bodycommunicationUseruserID, nameof(bodycommunicationUseruserID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/participants/:remove", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                var communicationUserObject = new JObject();
                var communicationUserObjectpropCount = 0;
                if (bodycommunicationUseruserID != null)
                {
                    communicationUserObject["id"] = ExpressionConverter.ConvertO(bodycommunicationUseruserID);
                    communicationUserObjectpropCount++;
                }

                if (communicationUserObjectpropCount > 0)
                {
                    body["communicationUser"] = communicationUserObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildListChatThreads))]
        public IBodyWorkflowAction<ListChatThreadsResponse> ListChatThreads([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<int> maxPageSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListChatThreadsResponse> __BuildListChatThreads(WorkflowValue<string> accessToken, WorkflowValue<string> startTime = null, WorkflowValue<int> maxPageSize = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(maxPageSize, nameof(maxPageSize), required: false);
            return new DeferredBodyAction<ListChatThreadsResponse>(() =>
            {
                var apiCallPath = "/chat/threads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
                if (maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = ExpressionConverter.Convert(maxPageSize);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction<ListChatThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChat))]
        public IBodyWorkflowAction<CreateChatResponse> CreateChat([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> bodytopic, [WorkflowExpression] Func<bodyparticipantsInputItem2[]> bodyparticipants = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateChatResponse> __BuildCreateChat(WorkflowValue<string> accessToken, WorkflowValue<string> bodytopic, WorkflowValue<bodyparticipantsInputItem2[]> bodyparticipants = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(bodytopic, nameof(bodytopic), required: true);
            WorkflowValue.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredBodyAction<CreateChatResponse>(() =>
            {
                var apiCallPath = "/chat/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = ExpressionConverter.ConvertO(bodytopic);
                if (bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildListParticipants))]
        public IBodyWorkflowAction<ListParticipantsResponse> ListParticipants([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> maxPageSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListParticipantsResponse> __BuildListParticipants(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId, WorkflowValue<string> skip = null, WorkflowValue<string> maxPageSize = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(maxPageSize, nameof(maxPageSize), required: false);
            return new DeferredBodyAction<ListParticipantsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = ExpressionConverter.Convert(maxPageSize);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction<ListParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildGetThreadProperties))]
        public IBodyWorkflowAction<GetThreadPropertiesResponse> GetThreadProperties([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetThreadPropertiesResponse> __BuildGetThreadProperties(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            return new DeferredBodyAction<GetThreadPropertiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction<GetThreadPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateChatThreadProperties))]
        public IWorkflowAction UpdateChatThreadProperties([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> bodytopic = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateChatThreadProperties(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId, WorkflowValue<string> bodytopic = null)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            WorkflowValue.Validate(bodytopic, nameof(bodytopic), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                callPayload.Headers["content-type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopic != null)
                {
                    body["topic"] = ExpressionConverter.ConvertO(bodytopic);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteChatThread))]
        public IWorkflowAction DeleteChatThread([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteChatThread(WorkflowValue<string> accessToken, WorkflowValue<string> chatThreadId)
        {
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: true);
            WorkflowValue.Validate(chatThreadId, nameof(chatThreadId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AcschatTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListMessagesResponse
    {
        [JsonProperty("value")]
        public ListMessagesResponseMessageListTypeItem[] MessageList { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ListMessagesResponseMessageListTypeItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("sequenceId")]
        public string SequenceID { get; set; }

        [JsonProperty("content")]
        public ListMessagesResponseMessageListTypeItemContentType Content { get; set; }

        [JsonProperty("senderDisplayName")]
        public string SenderDisplayName { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("senderCommunicationIdentifier")]
        public CommunicationIdentifier SenderCommunicationIdentifier { get; set; }
    }

    public class ListMessagesResponseMessageListTypeItemContentType
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("initiatorCommunicationIdentifier")]
        public CommunicationIdentifier InitiatorCommunicationIdentifier { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("participants")]
        public ListMessagesResponseMessageListTypeItemContentTypeParticipantsTypeItem[] Participants { get; set; }
    }

    public class CommunicationIdentifier
    {
        [JsonProperty("communicationUser")]
        public CommunicationIdentifierCommunicationUserType CommunicationUser { get; set; }
    }

    public class CommunicationIdentifierCommunicationUserType
    {
        [JsonProperty("id")]
        public string UserID { get; set; }
    }

    public class ListMessagesResponseMessageListTypeItemContentTypeParticipantsTypeItem
    {
        [JsonProperty("communicationIdentifier")]
        public CommunicationIdentifier CommunicationIdentifier { get; set; }
    }

    public class SendChatResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AddParticipantsResponse
    {
        [JsonProperty("invalidParticipants")]
        public AddParticipantsResponseInvalidParticipantsTypeItem[] InvalidParticipants { get; set; }
    }

    public class AddParticipantsResponseInvalidParticipantsTypeItem
    {
        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodyparticipantsInputItem
    {
        [JsonProperty("communicationIdentifier")]
        public CommunicationIdentifier CommunicationIdentifier { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("shareHistoryTime")]
        public string ShareHistoryTime { get; set; }
    }

    public class ListChatThreadsResponse
    {
        [JsonProperty("value")]
        public ListChatThreadsResponseChatThreadsTypeItem[] ChatThreads { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ListChatThreadsResponseChatThreadsTypeItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("lastMessageReceivedOn")]
        public string LastMessageReceivedOn { get; set; }

        [JsonProperty("deletedOn")]
        public string DeletedOn { get; set; }
    }

    public class CreateChatResponse
    {
        [JsonProperty("chatThread")]
        public CreateChatResponseChatThreadType ChatThread { get; set; }
    }

    public class CreateChatResponseChatThreadType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdByCommunicationIdentifier")]
        public CommunicationIdentifier CreatedByCommunicationIdentifier { get; set; }
    }

    public class bodyparticipantsInputItem2
    {
        [JsonProperty("communicationIdentifier")]
        public CommunicationIdentifier CommunicationIdentifier { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ListParticipantsResponse
    {
        [JsonProperty("value")]
        public ListParticipantsResponseValueTypeItem[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ListParticipantsResponseValueTypeItem
    {
        [JsonProperty("communicationIdentifier")]
        public CommunicationIdentifier CommunicationIdentifier { get; set; }

        [JsonProperty("displayName")]
        public string Name { get; set; }

        [JsonProperty("shareHistoryTime")]
        public string Time { get; set; }
    }

    public class GetThreadPropertiesResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("deletedOn")]
        public string DeletedOn { get; set; }

        [JsonProperty("createdByCommunicationIdentifier")]
        public GetThreadPropertiesResponseCreatedByCommunicationIdentifierType CreatedByCommunicationIdentifier { get; set; }
    }

    public class GetThreadPropertiesResponseCreatedByCommunicationIdentifierType
    {
        [JsonProperty("rawId")]
        public string RawID { get; set; }

        [JsonProperty("communicationUser")]
        public GetThreadPropertiesResponseCreatedByCommunicationIdentifierTypeCommunicationUserType CommunicationUser { get; set; }
    }

    public class GetThreadPropertiesResponseCreatedByCommunicationIdentifierTypeCommunicationUserType
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acschat;

    public partial class WorkflowManagedActions
    {
        public AcschatActions Acschat(string connectionId) => new AcschatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcschatTriggers Acschat(string connectionId) => new AcschatTriggers(connectionId);
    }
}
