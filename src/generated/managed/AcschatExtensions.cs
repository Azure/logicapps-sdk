//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acschat
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcschatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<ListMessagesResponse, ApiConnectionActionConfiguration> ListMessages(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId, Expression<Func<string>> startTime = null, Expression<Func<string>> maxPageSize = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_maxPageSize = WorkflowExpression.Compile(maxPageSize, nameof(maxPageSize), required: false);
            return new DeferredBodyAction<ListMessagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}/messages", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = ExpressionConverter.Convert(__workflow_maxPageSize);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<ListMessagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<SendChatResponse, ApiConnectionActionConfiguration> SendChat(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId, Expression<Func<SendChatInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendChatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}/messages", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<AddParticipantsResponse, ApiConnectionActionConfiguration> AddParticipants(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId, Expression<Func<AddParticipantsInput>> body = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddParticipantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}/participants/:add", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveParticipant(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId, Expression<Func<RemoveParticipantInput>> body = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}/participants/:remove", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<ListChatThreadsResponse, ApiConnectionActionConfiguration> ListChatThreads(Expression<Func<string>> accessToken, Expression<Func<string>> startTime = null, Expression<Func<int>> maxPageSize = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_maxPageSize = WorkflowExpression.Compile(maxPageSize, nameof(maxPageSize), required: false);
            return new DeferredBodyAction<ListChatThreadsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chat/threads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = ExpressionConverter.Convert(__workflow_maxPageSize);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<ListChatThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<CreateChatResponse, ApiConnectionActionConfiguration> CreateChat(Expression<Func<string>> accessToken, Expression<Func<CreateChatInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateChatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/chat/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<ListParticipantsResponse, ApiConnectionActionConfiguration> ListParticipants(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId, Expression<Func<string>> skip = null, Expression<Func<string>> maxPageSize = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_maxPageSize = WorkflowExpression.Compile(maxPageSize, nameof(maxPageSize), required: false);
            return new DeferredBodyAction<ListParticipantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}/participants", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_maxPageSize != null)
                    callPayload.Queries["maxPageSize"] = ExpressionConverter.Convert(__workflow_maxPageSize);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<ListParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IBodyWorkflowAction<GetThreadPropertiesResponse, ApiConnectionActionConfiguration> GetThreadProperties(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            return new DeferredBodyAction<GetThreadPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<GetThreadPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateChatThreadProperties(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId, Expression<Func<UpdateChatThreadPropertiesInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["content-type"] = Convert.ToString("application/merge-patch+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acschat")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteChatThread(Expression<Func<string>> accessToken, Expression<Func<string>> chatThreadId)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_chatThreadId = WorkflowExpression.Compile(chatThreadId, nameof(chatThreadId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/chat/threads/{0}", __workflow_chatThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2021-09-07");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
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
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("sequenceId")]
        public string SequenceId { get; set; }

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
        public string UserId { get; set; }
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

    public class SendChatInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("senderDisplayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SenderDisplayName { get; set; }
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

    public class AddParticipantsInput
    {
        [JsonProperty("participants")]
        public AddParticipantsInputParticipantsTypeItem[] Participants { get; set; }
    }

    public class AddParticipantsInputParticipantsTypeItem
    {
        [JsonProperty("communicationIdentifier")]
        public CommunicationIdentifier CommunicationIdentifier { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("shareHistoryTime")]
        public string ShareHistoryTime { get; set; }
    }

    public class RemoveParticipantInput
    {
        [JsonProperty("communicationUser")]
        public RemoveParticipantInputCommunicationUserType CommunicationUser { get; set; }
    }

    public class RemoveParticipantInputCommunicationUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }
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
        public string Id { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdByCommunicationIdentifier")]
        public CommunicationIdentifier CreatedByCommunicationIdentifier { get; set; }
    }

    public class CreateChatInput
    {
        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Topic { get; set; }

        [JsonProperty("participants")]
        public CreateChatInputParticipantsTypeItem[] Participants { get; set; }
    }

    public class CreateChatInputParticipantsTypeItem
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
        public string Id { get; set; }

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
        public string RawId { get; set; }

        [JsonProperty("communicationUser")]
        public GetThreadPropertiesResponseCreatedByCommunicationIdentifierTypeCommunicationUserType CommunicationUser { get; set; }
    }

    public class GetThreadPropertiesResponseCreatedByCommunicationIdentifierTypeCommunicationUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChatThreadPropertiesInput
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }
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