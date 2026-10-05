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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserList> __BuildListUsers(WorkflowValue<string> roomId)
        {
            WorkflowValue.Validate(roomId, nameof(roomId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponse> __BuildGetUserByID(WorkflowValue<string> userid)
        {
            WorkflowValue.Validate(userid, nameof(userid), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewMessage> __BuildPostMessage(WorkflowValue<string> roomId, WorkflowValue<string> bodymessage)
        {
            WorkflowValue.Validate(roomId, nameof(roomId), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddUserToRoom(WorkflowValue<string> roomId, WorkflowValue<string> memberid)
        {
            WorkflowValue.Validate(roomId, nameof(roomId), required: true);
            WorkflowValue.Validate(memberid, nameof(memberid), required: true);
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
        public IBodyWorkflowTrigger<HistoryResponse> OnNewMessage([WorkflowExpression] Func<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<HistoryResponse> __BuildOnNewMessage(WorkflowValue<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<HistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/message_trigger/room/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<HistoryResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewFile))]
        public IBodyWorkflowTrigger<HistoryResponse> OnNewFile([WorkflowExpression] Func<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<HistoryResponse> __BuildOnNewFile(WorkflowValue<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<HistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/file_trigger/room/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<HistoryResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<RoomList> OnNewRoom(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/room_trigger/room";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RoomList>(callPayload, triggerName, recurrence);
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
