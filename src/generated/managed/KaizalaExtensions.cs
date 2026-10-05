//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kaizala
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KaizalaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestmessage, [WorkflowExpression] Func<string> requestsubscribers = null, [WorkflowExpression] Func<sendToAllInput> sendToAll = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowValue<string> groupId, WorkflowValue<string> requestmessage, WorkflowValue<string> requestsubscribers = null, WorkflowValue<sendToAllInput> sendToAll = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestmessage, nameof(requestmessage), required: true);
            WorkflowValue.Validate(requestsubscribers, nameof(requestsubscribers), required: false);
            WorkflowValue.Validate(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Message"] = ExpressionConverter.ConvertO(requestmessage);
                if (requestsubscribers != null)
                {
                    request["subscribers"] = ExpressionConverter.ConvertO(requestsubscribers);
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
        [WorkflowExpressionFactory(nameof(__BuildSendActions))]
        public IBodyWorkflowAction<SendActionResponse> SendActions([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<actionTypeInput> actionType = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<object> requestactionBody = null, [WorkflowExpression] Func<string> requestsubscribers = null, [WorkflowExpression] Func<sendToAllInput> sendToAll = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendActionResponse> __BuildSendActions(WorkflowValue<string> groupId, WorkflowValue<actionTypeInput> actionType = null, WorkflowValue<string> id = null, WorkflowValue<object> requestactionBody = null, WorkflowValue<string> requestsubscribers = null, WorkflowValue<sendToAllInput> sendToAll = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(actionType, nameof(actionType), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(requestactionBody, nameof(requestactionBody), required: false);
            WorkflowValue.Validate(requestsubscribers, nameof(requestsubscribers), required: false);
            WorkflowValue.Validate(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (actionType != null)
                    callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestactionBody != null)
                {
                    request["actionBody"] = ExpressionConverter.ConvertO(requestactionBody);
                    requestpropCount++;
                }

                if (requestsubscribers != null)
                {
                    request["subscribers"] = ExpressionConverter.ConvertO(requestsubscribers);
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
        [WorkflowExpressionFactory(nameof(__BuildSendActionReminder))]
        public IBodyWorkflowAction<SendActionResponse> SendActionReminder([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<actionTypeInput> actionType, [WorkflowExpression] Func<string> requestsubscribers = null, [WorkflowExpression] Func<object> requestactionId = null, [WorkflowExpression] Func<sendToAllInput> sendToAll = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendActionResponse> __BuildSendActionReminder(WorkflowValue<string> groupId, WorkflowValue<actionTypeInput> actionType, WorkflowValue<string> requestsubscribers = null, WorkflowValue<object> requestactionId = null, WorkflowValue<sendToAllInput> sendToAll = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(actionType, nameof(actionType), required: true);
            WorkflowValue.Validate(requestsubscribers, nameof(requestsubscribers), required: false);
            WorkflowValue.Validate(requestactionId, nameof(requestactionId), required: false);
            WorkflowValue.Validate(sendToAll, nameof(sendToAll), required: false);
            return new DeferredBodyAction<SendActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/actions/$actionId$/reminder", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
                if (sendToAll != null)
                    callPayload.Queries["sendToAll"] = ExpressionConverter.Convert(sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestsubscribers != null)
                {
                    request["subscribers"] = ExpressionConverter.ConvertO(requestsubscribers);
                    requestpropCount++;
                }

                if (requestactionId != null)
                {
                    request["actionWrapper"] = ExpressionConverter.ConvertO(requestactionId);
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
        [WorkflowExpressionFactory(nameof(__BuildPostReaction))]
        public IBodyWorkflowAction<PostReactionResponse> PostReaction([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestsourceGroupId = null, [WorkflowExpression] Func<string> requestmessageId = null, [WorkflowExpression] Func<requestreactionTypeInput> requestreactionType = null, [WorkflowExpression] Func<string> requestcomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostReactionResponse> __BuildPostReaction(WorkflowValue<string> groupId, WorkflowValue<string> requestsourceGroupId = null, WorkflowValue<string> requestmessageId = null, WorkflowValue<requestreactionTypeInput> requestreactionType = null, WorkflowValue<string> requestcomment = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestsourceGroupId, nameof(requestsourceGroupId), required: false);
            WorkflowValue.Validate(requestmessageId, nameof(requestmessageId), required: false);
            WorkflowValue.Validate(requestreactionType, nameof(requestreactionType), required: false);
            WorkflowValue.Validate(requestcomment, nameof(requestcomment), required: false);
            return new DeferredBodyAction<PostReactionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/reaction", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestsourceGroupId != null)
                {
                    request["SourceGroupId"] = ExpressionConverter.ConvertO(requestsourceGroupId);
                    requestpropCount++;
                }

                if (requestmessageId != null)
                {
                    request["ReferenceId"] = ExpressionConverter.ConvertO(requestmessageId);
                    requestpropCount++;
                }

                if (requestreactionType != null)
                {
                    request["ReactionType"] = ExpressionConverter.ConvertO(requestreactionType);
                    requestpropCount++;
                }

                if (requestcomment != null)
                {
                    request["Comment"] = ExpressionConverter.ConvertO(requestcomment);
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
        [WorkflowExpressionFactory(nameof(__BuildSendReply))]
        public IBodyWorkflowAction<SendMessageResponse> SendReply([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestmessageId, [WorkflowExpression] Func<string> requestmessage)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendReply(WorkflowValue<string> groupId, WorkflowValue<string> requestmessageId, WorkflowValue<string> requestmessage)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestmessageId, nameof(requestmessageId), required: true);
            WorkflowValue.Validate(requestmessage, nameof(requestmessage), required: true);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["replyToReferenceId"] = ExpressionConverter.ConvertO(requestmessageId);
                requestpropCount++;
                request["message"] = ExpressionConverter.ConvertO(requestmessage);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGroup))]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestwelcomeMessage, [WorkflowExpression] Func<string> requestmembers = null, [WorkflowExpression] Func<requestgroupTypeInput> requestgroupType = null, [WorkflowExpression] Func<string> requestshortDescription = null, [WorkflowExpression] Func<string> requestlongDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateGroupResponse> __BuildCreateGroup(WorkflowValue<string> requestgroupName, WorkflowValue<string> requestwelcomeMessage, WorkflowValue<string> requestmembers = null, WorkflowValue<requestgroupTypeInput> requestgroupType = null, WorkflowValue<string> requestshortDescription = null, WorkflowValue<string> requestlongDescription = null)
        {
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestwelcomeMessage, nameof(requestwelcomeMessage), required: true);
            WorkflowValue.Validate(requestmembers, nameof(requestmembers), required: false);
            WorkflowValue.Validate(requestgroupType, nameof(requestgroupType), required: false);
            WorkflowValue.Validate(requestshortDescription, nameof(requestshortDescription), required: false);
            WorkflowValue.Validate(requestlongDescription, nameof(requestlongDescription), required: false);
            return new DeferredBodyAction<CreateGroupResponse>(() =>
            {
                var apiCallPath = "/v1/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Name"] = ExpressionConverter.ConvertO(requestgroupName);
                requestpropCount++;
                request["WelcomeMessage"] = ExpressionConverter.ConvertO(requestwelcomeMessage);
                if (requestmembers != null)
                {
                    request["Members"] = ExpressionConverter.ConvertO(requestmembers);
                    requestpropCount++;
                }

                if (requestgroupType != null)
                {
                    request["GroupType"] = ExpressionConverter.ConvertO(requestgroupType);
                    requestpropCount++;
                }

                if (requestshortDescription != null)
                {
                    request["ShortDescriptionString"] = ExpressionConverter.ConvertO(requestshortDescription);
                    requestpropCount++;
                }

                if (requestlongDescription != null)
                {
                    request["LongDescriptionString"] = ExpressionConverter.ConvertO(requestlongDescription);
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
        [WorkflowExpressionFactory(nameof(__BuildAddGroupToGroup))]
        public IWorkflowAction AddGroupToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string[]> requestsubGroups)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddGroupToGroup(WorkflowValue<string> groupId, WorkflowValue<string[]> requestsubGroups)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestsubGroups, nameof(requestsubGroups), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["SubGroups"] = ExpressionConverter.ConvertO(requestsubGroups);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSubgroup))]
        public IWorkflowAction CreateSubgroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestwelcomeMessage, [WorkflowExpression] Func<string> requestmembers = null, [WorkflowExpression] Func<requestgroupTypeInput> requestgroupType = null, [WorkflowExpression] Func<string> requestshortDescription = null, [WorkflowExpression] Func<string> requestlongDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateSubgroup(WorkflowValue<string> groupId, WorkflowValue<string> requestgroupName, WorkflowValue<string> requestwelcomeMessage, WorkflowValue<string> requestmembers = null, WorkflowValue<requestgroupTypeInput> requestgroupType = null, WorkflowValue<string> requestshortDescription = null, WorkflowValue<string> requestlongDescription = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestwelcomeMessage, nameof(requestwelcomeMessage), required: true);
            WorkflowValue.Validate(requestmembers, nameof(requestmembers), required: false);
            WorkflowValue.Validate(requestgroupType, nameof(requestgroupType), required: false);
            WorkflowValue.Validate(requestshortDescription, nameof(requestshortDescription), required: false);
            WorkflowValue.Validate(requestlongDescription, nameof(requestlongDescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Name"] = ExpressionConverter.ConvertO(requestgroupName);
                requestpropCount++;
                request["WelcomeMessage"] = ExpressionConverter.ConvertO(requestwelcomeMessage);
                if (requestmembers != null)
                {
                    request["Members"] = ExpressionConverter.ConvertO(requestmembers);
                    requestpropCount++;
                }

                if (requestgroupType != null)
                {
                    request["GroupType"] = ExpressionConverter.ConvertO(requestgroupType);
                    requestpropCount++;
                }

                if (requestshortDescription != null)
                {
                    request["ShortDescriptionString"] = ExpressionConverter.ConvertO(requestshortDescription);
                    requestpropCount++;
                }

                if (requestlongDescription != null)
                {
                    request["LongDescriptionString"] = ExpressionConverter.ConvertO(requestlongDescription);
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
        [WorkflowExpressionFactory(nameof(__BuildRemoveGroupFromGroup))]
        public IWorkflowAction RemoveGroupFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> subGroupId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveGroupFromGroup(WorkflowValue<string> groupId, WorkflowValue<string> subGroupId)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(subGroupId, nameof(subGroupId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(subGroupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildAddUserToGroup))]
        public IWorkflowAction AddUserToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestmembers)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddUserToGroup(WorkflowValue<string> groupId, WorkflowValue<string> requestmembers)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestmembers, nameof(requestmembers), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Members"] = ExpressionConverter.ConvertO(requestmembers);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildAddSubscriberToGroup))]
        public IWorkflowAction AddSubscriberToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestsubscribers)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddSubscriberToGroup(WorkflowValue<string> groupId, WorkflowValue<string> requestsubscribers)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(requestsubscribers, nameof(requestsubscribers), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subscribers/add", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["subscribers"] = ExpressionConverter.ConvertO(requestsubscribers);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveUserFromGroup))]
        public IWorkflowAction RemoveUserFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> memberId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveUserFromGroup(WorkflowValue<string> groupId, WorkflowValue<string> memberId)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(memberId, nameof(memberId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMediaFileContent))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFileContent([WorkflowExpression] Func<object> fileContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMediaFileContent(WorkflowValue<object> fileContent)
        {
            WorkflowValue.Validate(fileContent, nameof(fileContent), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/v1/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMediaFromURL))]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFromURL([WorkflowExpression] Func<string> mediaUrlmediaUrl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadMediaResponse> __BuildUploadMediaFromURL(WorkflowValue<string> mediaUrlmediaUrl)
        {
            WorkflowValue.Validate(mediaUrlmediaUrl, nameof(mediaUrlmediaUrl), required: true);
            return new DeferredBodyAction<UploadMediaResponse>(() =>
            {
                var apiCallPath = "/v1/media/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mediaUrl = new JObject();
                var mediaUrlpropCount = 0;
                mediaUrlpropCount++;
                mediaUrl["mediaUrl"] = ExpressionConverter.ConvertO(mediaUrlmediaUrl);
                if (mediaUrlpropCount > 0)
                {
                    callPayload.Body = mediaUrl;
                }

                return new ApiConnectionAction<UploadMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFromAttachment()
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTrigger))]
        public IWorkflowAction DeleteTrigger([WorkflowExpression] Func<string> webhookId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTrigger(WorkflowValue<string> webhookId)
        {
            WorkflowValue.Validate(webhookId, nameof(webhookId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(webhookId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class KaizalaTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildActionCreatedOnGroup))]
        public IWorkflowTrigger ActionCreatedOnGroup([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> actionPackageId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildActionCreatedOnGroup(WorkflowValue<string> objectId, WorkflowValue<string> actionPackageId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            WorkflowValue.Validate(actionPackageId, nameof(actionPackageId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/ActionCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                if (actionPackageId != null)
                    callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(actionPackageId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildAnnouncementOnGroup))]
        public IWorkflowTrigger AnnouncementOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAnnouncementOnGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/Announcement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGroupAddedToGroup))]
        public IWorkflowTrigger GroupAddedToGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildGroupAddedToGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/GroupAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGroupRemovedFromGroup))]
        public IWorkflowTrigger GroupRemovedFromGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildGroupRemovedFromGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/GroupRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildMemberAddedToGroup))]
        public IWorkflowTrigger MemberAddedToGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildMemberAddedToGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/MemberAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildMemberRemovedFromGroup))]
        public IWorkflowTrigger MemberRemovedFromGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildMemberRemovedFromGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/MemberRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildSurveyCreatedOnGroup))]
        public IWorkflowTrigger SurveyCreatedOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSurveyCreatedOnGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/SurveyCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTextMessageCreatedOnGroup))]
        public IWorkflowTrigger TextMessageCreatedOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTextMessageCreatedOnGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/TextMessageCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildSurveyResponseOnGroup))]
        public IWorkflowTrigger SurveyResponseOnGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSurveyResponseOnGroup(WorkflowValue<string> groupId, WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Action/SurveyResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildAttachmentOnGroup))]
        public IWorkflowTrigger AttachmentOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttachmentOnGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/AttachmentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildActionResponseOnGroup))]
        public IWorkflowTrigger ActionResponseOnGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> actionPackageId, [WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildActionResponseOnGroup(WorkflowValue<string> groupId, WorkflowValue<string> actionPackageId, WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(actionPackageId, nameof(actionPackageId), required: true);
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(actionPackageId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildUserJoinedOnGroup))]
        public IWorkflowTrigger UserJoinedOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUserJoinedOnGroup(WorkflowValue<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/Group/UserJoined";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class SendMessageResponse
    {
        [JsonProperty("referenceId")]
        public string MessageId { get; set; }
    }

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
