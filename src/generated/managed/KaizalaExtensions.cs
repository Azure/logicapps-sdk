//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kaizala
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KaizalaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> groupId, Expression<Func<SendMessageRequestInput>> request, Expression<Func<SendToAllInput>> sendToAll = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            var __workflow_sendToAll = WorkflowExpression.Compile(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/messages", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(__workflow_sendToAll);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse, ApiConnectionActionConfiguration> SendActionReminder(Expression<Func<string>> groupId, Expression<Func<ActionTypeInput>> actionType, Expression<Func<SendActionReminderRequestInput>> request = null, Expression<Func<SendToAllInput>> sendToAll = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: false);
            var __workflow_sendToAll = WorkflowExpression.Compile(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/actions/$actionId$/reminder", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(__workflow_actionType);
                if (__workflow_sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(__workflow_sendToAll);
                if (__workflow_request != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SendActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<PostReactionResponse, ApiConnectionActionConfiguration> PostReaction(Expression<Func<string>> groupId, Expression<Func<PostReactionRequestInput>> request = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: false);
            return new DeferredBodyAction<PostReactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/reaction", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_request != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<PostReactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendReply(Expression<Func<string>> groupId, Expression<Func<SendReplyRequestInput>> request)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}/messages", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<CreateGroupRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddGroupToGroup(Expression<Func<string>> groupId, Expression<Func<AddGroupToGroupRequestInput>> request = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subgroups", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_request != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateSubgroup(Expression<Func<string>> groupId, Expression<Func<CreateGroupRequestInput>> request)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subgroups", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveGroupFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> subGroupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_subGroupId = WorkflowExpression.Compile(subGroupId, nameof(subGroupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subgroups/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_subGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddUserToGroup(Expression<Func<string>> groupId, Expression<Func<AddUserToGroupRequestInput>> request)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddSubscriberToGroup(Expression<Func<string>> groupId, Expression<Func<AddSubscriberToGroupRequestInput>> request)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subscribers/add", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveUserFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> memberId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/members/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse, ApiConnectionActionConfiguration> UploadMediaFromURL(Expression<Func<MediaUrlInput>> mediaUrl)
        {
            var __workflow_mediaUrl = WorkflowExpression.Compile(mediaUrl, nameof(mediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/media/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mediaUrl);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse, ApiConnectionActionConfiguration> UploadMediaFromAttachment(Expression<Func<UploadMediaFromAttachmentRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<UploadMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/media/attachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTrigger(Expression<Func<string>> webhookId)
        {
            var __workflow_webhookId = WorkflowExpression.Compile(webhookId, nameof(webhookId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/webhook/{0}", __workflow_webhookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse, ApiConnectionActionConfiguration> SendActions(Expression<Func<string>> groupId, Expression<Func<SendActionsRequestInput>> request, Expression<Func<ActionTypeInput>> actionType = null, Expression<Func<SendToAllInput>> sendToAll = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: false);
            var __workflow_sendToAll = WorkflowExpression.Compile(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}/actions", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = Convert.ToString("Action Package");
                if (__workflow_actionType != null)
                    callPayload.Queries["actionType"] = ExpressionConverter.Convert(__workflow_actionType);
                if (__workflow_sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(__workflow_sendToAll);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SendActionResponse>(callPayload);
            });
        }
    }

    public class KaizalaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ActionCreatedOnGroup(Expression<Func<string>> objectId, Expression<Func<string>> actionPackageId = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_actionPackageId = WorkflowExpression.Compile(actionPackageId, nameof(actionPackageId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/ActionCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                if (__workflow_actionPackageId != null)
                    callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(__workflow_actionPackageId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> AnnouncementOnGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/Announcement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GroupAddedToGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/GroupAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GroupRemovedFromGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/GroupRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> MemberAddedToGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/MemberAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> MemberRemovedFromGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/MemberRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> SurveyCreatedOnGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/SurveyCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TextMessageCreatedOnGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/TextMessageCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> SurveyResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> objectId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Action/SurveyResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> AttachmentOnGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/AttachmentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ActionResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> actionPackageId, Expression<Func<string>> objectId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_actionPackageId = WorkflowExpression.Compile(actionPackageId, nameof(actionPackageId), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(__workflow_actionPackageId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> UserJoinedOnGroup(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/UserJoined";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                callPayload.Body = new ActionCreatedOnGroupRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class SendMessageResponse
    {
        [JsonProperty("referenceId")]
        public string MessageId { get; set; }
    }

    public class SendMessageRequestInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("subscribers")]
        public string Subscribers { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendToAllInput
    {
        Yes,
        No
    }

    public class SendActionResponse
    {
        [JsonProperty("referenceId")]
        public string MessageId { get; set; }

        [JsonProperty("actionId")]
        public string ActionInstanceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActionTypeInput
    {
        [EnumMember(Value = "job")]
        Job,
        [EnumMember(Value = "survey")]
        Survey,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "album")]
        Album,
        [EnumMember(Value = "announcement")]
        Announcement,
        [EnumMember(Value = "Action Package")]
        ActionPackage
    }

    public class SendActionReminderRequestInput
    {
        [JsonProperty("subscribers")]
        public string Subscribers { get; set; }

        [JsonProperty("actionWrapper")]
        public JToken ActionId { get; set; }
    }

    public class PostReactionResponse
    {
        public string ReactionId { get; set; }
    }

    public class PostReactionRequestInput
    {
        public string SourceGroupId { get; set; }

        [JsonProperty("ReferenceId")]
        public string MessageId { get; set; }
        public RequestInputReactionTypeType? ReactionType { get; set; }
        public string Comment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestInputReactionTypeType
    {
        Like,
        Comment
    }

    public class SendReplyRequestInput
    {
        [JsonProperty("replyToReferenceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MessageId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
    }

    public class CreateGroupResponse
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }
    }

    public class CreateGroupRequestInput
    {
        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string WelcomeMessage { get; set; }
        public string Members { get; set; }
        public RequestInputGroupTypeType? GroupType { get; set; }

        [JsonProperty("ShortDescriptionString")]
        public string ShortDescription { get; set; }

        [JsonProperty("LongDescriptionString")]
        public string LongDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestInputGroupTypeType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "connectGroup")]
        ConnectGroup
    }

    public class AddGroupToGroupRequestInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] SubGroups { get; set; }
    }

    public class AddUserToGroupRequestInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Members { get; set; }
    }

    public class AddSubscriberToGroupRequestInput
    {
        [JsonProperty("subscribers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subscribers { get; set; }
    }

    public class UploadMediaResponse
    {
        [JsonProperty("mediaResource")]
        public string MediaResource { get; set; }
    }

    public class MediaUrlInput
    {
        [JsonProperty("mediaUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MediaUrl { get; set; }
    }

    public class UploadMediaFromAttachmentRequestInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken MediaFile { get; set; }
    }

    public class SendActionsRequestInput
    {
        [JsonProperty("actionBody")]
        public JToken ActionBody { get; set; }

        [JsonProperty("subscribers")]
        public string Subscribers { get; set; }
    }

    public class ActionCreatedOnGroupRequestInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kaizala;

    public partial class WorkflowManagedActions
    {
        public KaizalaActions Kaizala(string connectionId) => new KaizalaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KaizalaTriggers Kaizala(string connectionId) => new KaizalaTriggers(connectionId);
    }
}