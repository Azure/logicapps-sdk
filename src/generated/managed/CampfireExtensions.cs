//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Campfire
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CampfireActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "campfire")]
        public IBodyWorkflowAction<CreateMessageResponse> CreateMessage([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> message)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/room/{0}/speak.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                return callPayload;
            }

            return new ApiConnectionAction<CreateMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "campfire")]
        public IBodyWorkflowAction<UserResponse> GetUser([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<int> userId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }
    }

    public class CampfireTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<RoomsResponse> OnNewRoom([WorkflowExpression] Func<string> account, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/OnNewRoom_trigger/rooms.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionTrigger<RoomsResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessagesResponse> OnNewMessage([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/OnNewMessage_trigger/room/{0}/recent.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionTrigger<MessagesResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UploadResponse> OnNewUpload([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/OnNewUpload_trigger/room/{0}/uploads.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionTrigger<UploadResponse>(BuildSourceInput, triggerName, recurrence);
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
        public int UserID { get; set; }
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
        public int UserID { get; set; }
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
        public int UserID { get; set; }
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