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
        public IBodyWorkflowAction<UserList> ListUsers([WorkflowExpression] Func<string> roomId)
        {
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/room/{0}/participant", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<UserResponse> GetUserByID([WorkflowExpression] Func<string> userid)
        {
            SourceExpression.Validate(userid, nameof(userid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/user/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<NewMessage> PostMessage([WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> bodymessage)
        {
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/room/{0}/message", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NewMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hipchat")]
        public IBodyWorkflowAction<string> AddUserToRoom([WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> memberid)
        {
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            SourceExpression.Validate(memberid, nameof(memberid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/room/{0}/member/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class HipchatTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<HistoryResponse> OnNewMessage([WorkflowExpression] Func<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/message_trigger/room/{0}/history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<HistoryResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<HistoryResponse> OnNewFile([WorkflowExpression] Func<string> roomId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(roomId, nameof(roomId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/file_trigger/room/{0}/history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<HistoryResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RoomList> OnNewRoom(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/room_trigger/room";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<RoomList>(BuildSourceInput, triggerName, recurrence);
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