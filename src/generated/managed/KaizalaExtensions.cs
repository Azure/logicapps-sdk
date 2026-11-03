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
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> groupId, Expression<Func<string>> requestmessage, Expression<Func<string>> requestsubscribers = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestmessage = WorkflowExpression.Compile(requestmessage, nameof(requestmessage), required: true);
            var __workflow_requestsubscribers = WorkflowExpression.Compile(requestsubscribers, nameof(requestsubscribers), required: false);
            var __workflow_sendToAll = WorkflowExpression.Compile(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/messages", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(__workflow_sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Message"] = ExpressionConverter.ConvertO(__workflow_requestmessage);
                if (__workflow_requestsubscribers != null)
                {
                    request["subscribers"] = ExpressionConverter.ConvertO(__workflow_requestsubscribers);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse, ApiConnectionActionConfiguration> SendActionReminder(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType, Expression<Func<string>> requestsubscribers = null, Expression<Func<object>> requestactionId = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: true);
            var __workflow_requestsubscribers = WorkflowExpression.Compile(requestsubscribers, nameof(requestsubscribers), required: false);
            var __workflow_requestactionId = WorkflowExpression.Compile(requestactionId, nameof(requestactionId), required: false);
            var __workflow_sendToAll = WorkflowExpression.Compile(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/actions/$actionId$/reminder", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(__workflow_actionType);
                if (__workflow_sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(__workflow_sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestsubscribers != null)
                {
                    request["subscribers"] = ExpressionConverter.ConvertO(__workflow_requestsubscribers);
                    requestpropCount++;
                }

                if (__workflow_requestactionId != null)
                {
                    request["actionWrapper"] = ExpressionConverter.ConvertO(__workflow_requestactionId);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SendActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<PostReactionResponse, ApiConnectionActionConfiguration> PostReaction(Expression<Func<string>> groupId, Expression<Func<string>> requestsourceGroupId = null, Expression<Func<string>> requestmessageId = null, Expression<Func<requestreactionTypeInput>> requestreactionType = null, Expression<Func<string>> requestcomment = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestsourceGroupId = WorkflowExpression.Compile(requestsourceGroupId, nameof(requestsourceGroupId), required: false);
            var __workflow_requestmessageId = WorkflowExpression.Compile(requestmessageId, nameof(requestmessageId), required: false);
            var __workflow_requestreactionType = WorkflowExpression.Compile(requestreactionType, nameof(requestreactionType), required: false);
            var __workflow_requestcomment = WorkflowExpression.Compile(requestcomment, nameof(requestcomment), required: false);
            return new DeferredBodyAction<PostReactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/reaction", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestsourceGroupId != null)
                {
                    request["SourceGroupId"] = ExpressionConverter.ConvertO(__workflow_requestsourceGroupId);
                    requestpropCount++;
                }

                if (__workflow_requestmessageId != null)
                {
                    request["ReferenceId"] = ExpressionConverter.ConvertO(__workflow_requestmessageId);
                    requestpropCount++;
                }

                if (__workflow_requestreactionType != null)
                {
                    request["ReactionType"] = ExpressionConverter.ConvertO(__workflow_requestreactionType);
                    requestpropCount++;
                }

                if (__workflow_requestcomment != null)
                {
                    request["Comment"] = ExpressionConverter.ConvertO(__workflow_requestcomment);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PostReactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendReply(Expression<Func<string>> groupId, Expression<Func<string>> requestmessageId, Expression<Func<string>> requestmessage)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestmessageId = WorkflowExpression.Compile(requestmessageId, nameof(requestmessageId), required: true);
            var __workflow_requestmessage = WorkflowExpression.Compile(requestmessage, nameof(requestmessage), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}/messages", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["replyToReferenceId"] = ExpressionConverter.ConvertO(__workflow_requestmessageId);
                requestpropCount++;
                request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessage);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<string>> requestgroupName, Expression<Func<string>> requestwelcomeMessage, Expression<Func<string>> requestmembers = null, Expression<Func<requestgroupTypeInput>> requestgroupType = null, Expression<Func<string>> requestshortDescription = null, Expression<Func<string>> requestlongDescription = null)
        {
            var __workflow_requestgroupName = WorkflowExpression.Compile(requestgroupName, nameof(requestgroupName), required: true);
            var __workflow_requestwelcomeMessage = WorkflowExpression.Compile(requestwelcomeMessage, nameof(requestwelcomeMessage), required: true);
            var __workflow_requestmembers = WorkflowExpression.Compile(requestmembers, nameof(requestmembers), required: false);
            var __workflow_requestgroupType = WorkflowExpression.Compile(requestgroupType, nameof(requestgroupType), required: false);
            var __workflow_requestshortDescription = WorkflowExpression.Compile(requestshortDescription, nameof(requestshortDescription), required: false);
            var __workflow_requestlongDescription = WorkflowExpression.Compile(requestlongDescription, nameof(requestlongDescription), required: false);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Name"] = ExpressionConverter.ConvertO(__workflow_requestgroupName);
                requestpropCount++;
                request["WelcomeMessage"] = ExpressionConverter.ConvertO(__workflow_requestwelcomeMessage);
                if (__workflow_requestmembers != null)
                {
                    request["Members"] = ExpressionConverter.ConvertO(__workflow_requestmembers);
                    requestpropCount++;
                }

                if (__workflow_requestgroupType != null)
                {
                    request["GroupType"] = ExpressionConverter.ConvertO(__workflow_requestgroupType);
                    requestpropCount++;
                }

                if (__workflow_requestshortDescription != null)
                {
                    request["ShortDescriptionString"] = ExpressionConverter.ConvertO(__workflow_requestshortDescription);
                    requestpropCount++;
                }

                if (__workflow_requestlongDescription != null)
                {
                    request["LongDescriptionString"] = ExpressionConverter.ConvertO(__workflow_requestlongDescription);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddGroupToGroup(Expression<Func<string>> groupId, Expression<Func<string[]>> requestsubGroups)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestsubGroups = WorkflowExpression.Compile(requestsubGroups, nameof(requestsubGroups), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subgroups", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["SubGroups"] = ExpressionConverter.ConvertO(__workflow_requestsubGroups);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateSubgroup(Expression<Func<string>> groupId, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestwelcomeMessage, Expression<Func<string>> requestmembers = null, Expression<Func<requestgroupTypeInput>> requestgroupType = null, Expression<Func<string>> requestshortDescription = null, Expression<Func<string>> requestlongDescription = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestgroupName = WorkflowExpression.Compile(requestgroupName, nameof(requestgroupName), required: true);
            var __workflow_requestwelcomeMessage = WorkflowExpression.Compile(requestwelcomeMessage, nameof(requestwelcomeMessage), required: true);
            var __workflow_requestmembers = WorkflowExpression.Compile(requestmembers, nameof(requestmembers), required: false);
            var __workflow_requestgroupType = WorkflowExpression.Compile(requestgroupType, nameof(requestgroupType), required: false);
            var __workflow_requestshortDescription = WorkflowExpression.Compile(requestshortDescription, nameof(requestshortDescription), required: false);
            var __workflow_requestlongDescription = WorkflowExpression.Compile(requestlongDescription, nameof(requestlongDescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subgroups", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Name"] = ExpressionConverter.ConvertO(__workflow_requestgroupName);
                requestpropCount++;
                request["WelcomeMessage"] = ExpressionConverter.ConvertO(__workflow_requestwelcomeMessage);
                if (__workflow_requestmembers != null)
                {
                    request["Members"] = ExpressionConverter.ConvertO(__workflow_requestmembers);
                    requestpropCount++;
                }

                if (__workflow_requestgroupType != null)
                {
                    request["GroupType"] = ExpressionConverter.ConvertO(__workflow_requestgroupType);
                    requestpropCount++;
                }

                if (__workflow_requestshortDescription != null)
                {
                    request["ShortDescriptionString"] = ExpressionConverter.ConvertO(__workflow_requestshortDescription);
                    requestpropCount++;
                }

                if (__workflow_requestlongDescription != null)
                {
                    request["LongDescriptionString"] = ExpressionConverter.ConvertO(__workflow_requestlongDescription);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> AddUserToGroup(Expression<Func<string>> groupId, Expression<Func<string>> requestmembers)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestmembers = WorkflowExpression.Compile(requestmembers, nameof(requestmembers), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Members"] = ExpressionConverter.ConvertO(__workflow_requestmembers);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddSubscriberToGroup(Expression<Func<string>> groupId, Expression<Func<string>> requestsubscribers)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_requestsubscribers = WorkflowExpression.Compile(requestsubscribers, nameof(requestsubscribers), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/groups/{0}/subscribers/add", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["subscribers"] = ExpressionConverter.ConvertO(__workflow_requestsubscribers);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

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
        public IBodyWorkflowAction<UploadMediaResponse, ApiConnectionActionConfiguration> UploadMediaFromURL(Expression<Func<string>> mediaUrlmediaUrl)
        {
            var __workflow_mediaUrlmediaUrl = WorkflowExpression.Compile(mediaUrlmediaUrl, nameof(mediaUrlmediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/media/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mediaUrl = new JObject();
                var mediaUrlpropCount = 0;
                mediaUrlpropCount++;
                mediaUrl["mediaUrl"] = ExpressionConverter.ConvertO(__workflow_mediaUrlmediaUrl);
                if (mediaUrlpropCount > 0)
                {
                    callPayload.Body = mediaUrl;
                }

                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse, ApiConnectionActionConfiguration> UploadMediaFromAttachment()
        {
            return new DeferredBodyAction<UploadMediaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/media/attachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var fileContentObject = new JObject();
                var fileContentObjectpropCount = 0;
                if (fileContentObjectpropCount > 0)
                {
                    request["fileContent"] = fileContentObject;
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

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
        public IBodyWorkflowAction<SendActionResponse, ApiConnectionActionConfiguration> SendActions(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType = null, Expression<Func<object>> requestactionBody = null, Expression<Func<string>> requestsubscribers = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: false);
            var __workflow_requestactionBody = WorkflowExpression.Compile(requestactionBody, nameof(requestactionBody), required: false);
            var __workflow_requestsubscribers = WorkflowExpression.Compile(requestsubscribers, nameof(requestsubscribers), required: false);
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
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestactionBody != null)
                {
                    request["actionBody"] = ExpressionConverter.ConvertO(__workflow_requestactionBody);
                    requestpropCount++;
                }

                if (__workflow_requestsubscribers != null)
                {
                    request["subscribers"] = ExpressionConverter.ConvertO(__workflow_requestsubscribers);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SendActionResponse>(callPayload);
            });
        }
    }

    public class KaizalaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ActionCreatedOnGroup(Expression<Func<string>> objectId, Expression<Func<string>> actionPackageId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_actionPackageId = WorkflowExpression.Compile(actionPackageId, nameof(actionPackageId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/ActionCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                if (__workflow_actionPackageId != null)
                    callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(__workflow_actionPackageId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AnnouncementOnGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/Announcement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupAddedToGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/GroupAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupRemovedFromGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/GroupRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> MemberAddedToGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/MemberAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> MemberRemovedFromGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/MemberRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SurveyCreatedOnGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/SurveyCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TextMessageCreatedOnGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/TextMessageCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SurveyResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Action/SurveyResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AttachmentOnGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/AttachmentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ActionResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> actionPackageId, Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_actionPackageId = WorkflowExpression.Compile(actionPackageId, nameof(actionPackageId), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(__workflow_actionPackageId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UserJoinedOnGroup(Expression<Func<string>> objectId, FlowRecurrence recurrence = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/Group/UserJoined";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(__workflow_objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendMessageResponse
    {
        [JsonProperty("referenceId")]
        public string MessageId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sendToAllInput
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
    public enum actionTypeInput
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

    public class PostReactionResponse
    {
        public string ReactionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestreactionTypeInput
    {
        Like,
        Comment
    }

    public class CreateGroupResponse
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestgroupTypeInput
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "connectGroup")]
        ConnectGroup
    }

    public class UploadMediaResponse
    {
        [JsonProperty("mediaResource")]
        public string MediaResource { get; set; }
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