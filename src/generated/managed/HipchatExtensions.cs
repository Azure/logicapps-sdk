//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hipchat
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HipchatActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        [WorkflowExpressionFactory(nameof(__BuildListUsers))]
        public IBodyWorkflowAction<UserList> ListUsers([WorkflowExpression] Func<string> roomId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserList> __BuildListUsers(WorkflowExpression<string> roomId)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            return new DeferredBodyAction<UserList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/room/{0}/participant", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserByID))]
        public IBodyWorkflowAction<UserResponse> GetUserByID([WorkflowExpression] Func<string> userid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponse> __BuildGetUserByID(WorkflowExpression<string> userid)
        {
            WorkflowExpression.Validate(userid, nameof(userid), required: true);
            return new DeferredBodyAction<UserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(userid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        [WorkflowExpressionFactory(nameof(__BuildPostMessage))]
        public IBodyWorkflowAction<NewMessage> PostMessage([WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> bodymessage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewMessage> __BuildPostMessage(WorkflowExpression<string> roomId, WorkflowExpression<string> bodymessage)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            return new DeferredBodyAction<NewMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/room/{0}/message", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        [WorkflowExpressionFactory(nameof(__BuildAddUserToRoom))]
        public IBodyWorkflowAction<string> AddUserToRoom([WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> memberid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddUserToRoom(WorkflowExpression<string> roomId, WorkflowExpression<string> memberid)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            WorkflowExpression.Validate(memberid, nameof(memberid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/room/{0}/member/{1}", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class HipchatTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewMessage))]
        public IBodyWorkflowTrigger<HistoryResponse> OnNewMessage([WorkflowExpression] Func<string> roomId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<HistoryResponse> __BuildOnNewMessage(WorkflowExpression<string> roomId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<HistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/message_trigger/room/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<HistoryResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFile))]
        public IBodyWorkflowTrigger<HistoryResponse> OnNewFile([WorkflowExpression] Func<string> roomId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<HistoryResponse> __BuildOnNewFile(WorkflowExpression<string> roomId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<HistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/file_trigger/room/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<HistoryResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RoomList> OnNewRoom(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/room_trigger/room";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RoomList>(callPayload, recurrence: recurrence);
        }
    }

    public class UserList
    {
        [JsonProperty("items")]
        public UserListItemsTypeItem[] Items { get; set; }
    }

    public class UserListItemsTypeItem
    {
        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("is_present_in_room")]
        public bool UserIsPresent { get; set; }

        [JsonProperty("mention_name")]
        public string MentionName { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("mention_name")]
        public string MentionName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class NewMessage
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string DatePosted { get; set; }
    }

    public class HistoryResponse
    {
        [JsonProperty("items")]
        public HistoryResponseItemsTypeItem[] Items { get; set; }
    }

    public class HistoryResponseItemsTypeItem
    {
        [JsonProperty("date")]
        public string DatePosted { get; set; }

        [JsonProperty("file")]
        public HistoryResponseItemsTypeItemFileType File { get; set; }

        [JsonProperty("from")]
        public JToken AuthorSInfo { get; set; }

        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class HistoryResponseItemsTypeItemFileType
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("url")]
        public string FileURL { get; set; }
    }

    public class RoomList
    {
        [JsonProperty("items")]
        public RoomListItemsTypeItem[] Items { get; set; }
    }

    public class RoomListItemsTypeItem
    {
        [JsonProperty("id")]
        public int RoomId { get; set; }

        [JsonProperty("is_archived")]
        public bool Archived { get; set; }

        [JsonProperty("name")]
        public string RoomName { get; set; }

        [JsonProperty("privacy")]
        public string Private { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hipchat;

    public partial class WorkflowManagedActions
    {
        public HipchatActions Hipchat(string connectionId) => new HipchatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HipchatTriggers Hipchat(string connectionId) => new HipchatTriggers(connectionId);
    }
}