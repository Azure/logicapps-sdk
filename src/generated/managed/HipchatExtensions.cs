//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hipchat
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HipchatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<UserList, ApiConnectionActionConfiguration> ListUsers(Expression<Func<string>> roomId)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            return new DeferredBodyAction<UserList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/room/{0}/participant", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetUserById(Expression<Func<string>> userid)
        {
            var __workflow_userid = WorkflowExpression.Compile(userid, nameof(userid), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user/{0}", __workflow_userid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<NewMessage, ApiConnectionActionConfiguration> PostMessage(Expression<Func<string>> roomId, Expression<Func<PostMessageInput>> body)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NewMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/room/{0}/message", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NewMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddUserToRoom(Expression<Func<string>> roomId, Expression<Func<string>> memberid)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            var __workflow_memberid = WorkflowExpression.Compile(memberid, nameof(memberid), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/room/{0}/member/{1}", __workflow_roomId.WithUrlEncoding(1), __workflow_memberid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class HipchatTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<HistoryResponse, ApiConnectionTriggerConfiguration> OnNewMessage(Expression<Func<string>> roomId, FlowRecurrence recurrence = null)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<HistoryResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/message_trigger/room/{0}/history", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<HistoryResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<HistoryResponse, ApiConnectionTriggerConfiguration> OnNewFile(Expression<Func<string>> roomId, FlowRecurrence recurrence = null)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            return new DeferredBodyTrigger<HistoryResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/file_trigger/room/{0}/history", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<HistoryResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RoomList, ApiConnectionTriggerConfiguration> OnNewRoom(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<RoomList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/room_trigger/room";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<RoomList>(callPayload, recurrence: recurrence);
            });
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

    public class PostMessageInput
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
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