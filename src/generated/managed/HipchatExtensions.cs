//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hipchat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HipchatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<UserList> ListUsers(Expression<Func<string>> roomId)
        {
            var apiCallPath = String.Format("/room/{0}/participant", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<UserResponse> GetUserByID(Expression<Func<string>> userid)
        {
            var apiCallPath = String.Format("/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(userid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<NewMessage> PostMessage(Expression<Func<string>> roomId, Expression<Func<string>> bodymessage)
        {
            var apiCallPath = String.Format("/room/{0}/message", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<string> AddUserToRoom(Expression<Func<string>> roomId, Expression<Func<string>> memberid)
        {
            var apiCallPath = String.Format("/room/{0}/member/{1}", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class HipchatTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<HistoryResponse> OnNewMessage(Expression<Func<string>> roomId)
        {
            var apiCallPath = String.Format("/message_trigger/room/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<HistoryResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<HistoryResponse> OnNewFile(Expression<Func<string>> roomId)
        {
            var apiCallPath = String.Format("/file_trigger/room/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<HistoryResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<RoomList> OnNewRoom()
        {
            var apiCallPath = "/room_trigger/room";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RoomList>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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