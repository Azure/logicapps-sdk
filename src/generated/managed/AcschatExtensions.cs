//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acschat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcschatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<ListMessagesResponse> ListMessages([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> maxPageSize = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(maxPageSize, nameof(maxPageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = SourceExpressionConverter.ConvertO(maxPageSize);
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction<ListMessagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<SendChatResponse> SendChat([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<string> bodysenderDisplayName)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            SourceExpression.Validate(bodysenderDisplayName, nameof(bodysenderDisplayName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
                body["senderDisplayName"] = SourceExpressionConverter.ConvertToken(bodysenderDisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendChatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<AddParticipantsResponse> AddParticipants([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<bodyparticipantsInputItem[]> bodyparticipants = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            SourceExpression.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/participants/:add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddParticipantsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IWorkflowAction RemoveParticipant([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> bodycommunicationUseruserId = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            SourceExpression.Validate(bodycommunicationUseruserId, nameof(bodycommunicationUseruserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/participants/:remove", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                var communicationUserObject = new JObject();
                var communicationUserObjectpropCount = 0;
                if (bodycommunicationUseruserId != null)
                {
                    communicationUserObject["id"] = SourceExpressionConverter.ConvertToken(bodycommunicationUseruserId);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<ListChatThreadsResponse> ListChatThreads([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<int> maxPageSize = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(startTime, nameof(startTime), required: false);
            SourceExpression.Validate(maxPageSize, nameof(maxPageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chat/threads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = SourceExpressionConverter.ConvertO(maxPageSize);
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction<ListChatThreadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<CreateChatResponse> CreateChat([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> bodytopic, [WorkflowExpression] Func<bodyparticipantsInputItem2[]> bodyparticipants = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(bodytopic, nameof(bodytopic), required: true);
            SourceExpression.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chat/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["topic"] = SourceExpressionConverter.ConvertToken(bodytopic);
                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateChatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<ListParticipantsResponse> ListParticipants([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> maxPageSize = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(maxPageSize, nameof(maxPageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}/participants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = SourceExpressionConverter.ConvertO(maxPageSize);
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction<ListParticipantsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<GetThreadPropertiesResponse> GetThreadProperties([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction<GetThreadPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IWorkflowAction UpdateChatThreadProperties([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId, [WorkflowExpression] Func<string> bodytopic = null)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            SourceExpression.Validate(bodytopic, nameof(bodytopic), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                callPayload.Headers["content-type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopic != null)
                {
                    body["topic"] = SourceExpressionConverter.ConvertToken(bodytopic);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IWorkflowAction DeleteChatThread([WorkflowExpression] Func<string> accessToken, [WorkflowExpression] Func<string> chatThreadId)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            SourceExpression.Validate(chatThreadId, nameof(chatThreadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chat/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatThreadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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