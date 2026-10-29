//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Campfire
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CampfireActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "campfire")]
        public IBodyWorkflowAction<CreateMessageResponse, ApiConnectionActionConfiguration> CreateMessage(Expression<Func<string>> account, Expression<Func<string>> roomId, Expression<Func<string>> message)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredBodyAction<CreateMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/room/{0}/speak.json", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                return new ApiConnectionAction<CreateMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "campfire")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> account, Expression<Func<int>> userId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}.json", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }
    }

    public class CampfireTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RoomsResponse, ApiConnectionTriggerConfiguration> OnNewRoom(Expression<Func<string>> account, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            return new DeferredBodyTrigger<RoomsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/OnNewRoom_trigger/rooms.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionTrigger<RoomsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<MessagesResponse, ApiConnectionTriggerConfiguration> OnNewMessage(Expression<Func<string>> account, Expression<Func<string>> roomId, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<MessagesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/OnNewMessage_trigger/room/{0}/recent.json", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionTrigger<MessagesResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UploadResponse, ApiConnectionTriggerConfiguration> OnNewUpload(Expression<Func<string>> account, Expression<Func<string>> roomId, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<UploadResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/OnNewUpload_trigger/room/{0}/uploads.json", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionTrigger<UploadResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateMessageResponse
    {
        [JsonProperty("message")]
        public CreateMessageResponseMessageType Message { get; set; }
    }

    public class CreateMessageResponseMessageType
    {
        [JsonProperty("body")]
        public string MessageBody { get; set; }

        [JsonProperty("id")]
        public int MessageId { get; set; }

        [JsonProperty("starred")]
        public bool MessageStarred { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("user")]
        public UserResponseUserType User { get; set; }
    }

    public class UserResponseUserType
    {
        [JsonProperty("email_address")]
        public string UserEmail { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }
    }

    public class RoomsResponse
    {
        [JsonProperty("rooms")]
        public RoomsResponseRoomsTypeItem[] Rooms { get; set; }
    }

    public class RoomsResponseRoomsTypeItem
    {
        [JsonProperty("name")]
        public string RoomName { get; set; }

        [JsonProperty("id")]
        public string RoomId { get; set; }

        [JsonProperty("locked")]
        public bool RoomLocked { get; set; }

        [JsonProperty("topic")]
        public string RoomTopic { get; set; }
    }

    public class MessagesResponse
    {
        [JsonProperty("messages")]
        public MessagesResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class MessagesResponseMessagesTypeItem
    {
        [JsonProperty("body")]
        public string MessageBody { get; set; }

        [JsonProperty("id")]
        public int MessageId { get; set; }

        [JsonProperty("starred")]
        public bool MessageStarred { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }

    public class UploadResponse
    {
        [JsonProperty("uploads")]
        public UploadResponseUploadsTypeItem[] Uploads { get; set; }
    }

    public class UploadResponseUploadsTypeItem
    {
        [JsonProperty("full_url")]
        public string FileUrl { get; set; }

        [JsonProperty("room_id")]
        public int RoomId { get; set; }

        [JsonProperty("id")]
        public int FileId { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Campfire;

    public partial class WorkflowManagedActions
    {
        public CampfireActions Campfire(string connectionId) => new CampfireActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CampfireTriggers Campfire(string connectionId) => new CampfireTriggers(connectionId);
    }
}