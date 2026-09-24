//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kaizala
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KaizalaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestmessage, [WorkflowExpression] Func<string> requestsubscribers = null, [WorkflowExpression] Func<sendToAllInput> sendToAll = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestmessage, nameof(requestmessage), required: true);
            SourceExpression.Validate(requestsubscribers, nameof(requestsubscribers), required: false);
            SourceExpression.Validate(sendToAll, nameof(sendToAll), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sendToAll != null)
                    callPayload.Queries["sendToAll"] = SourceExpressionConverter.Convert(sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Message"] = SourceExpressionConverter.ConvertToken(requestmessage);
                if (requestsubscribers != null)
                {
                    request["subscribers"] = SourceExpressionConverter.ConvertToken(requestsubscribers);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActions([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<actionTypeInput> actionType = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<object> requestactionBody = null, [WorkflowExpression] Func<string> requestsubscribers = null, [WorkflowExpression] Func<sendToAllInput> sendToAll = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(actionType, nameof(actionType), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(requestactionBody, nameof(requestactionBody), required: false);
            SourceExpression.Validate(requestsubscribers, nameof(requestsubscribers), required: false);
            SourceExpression.Validate(sendToAll, nameof(sendToAll), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (actionType != null)
                    callPayload.Queries["actionType"] = SourceExpressionConverter.Convert(actionType);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (sendToAll != null)
                    callPayload.Queries["sendToAll"] = SourceExpressionConverter.Convert(sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestactionBody != null)
                {
                    request["actionBody"] = SourceExpressionConverter.ConvertToken(requestactionBody);
                    requestpropCount++;
                }

                if (requestsubscribers != null)
                {
                    request["subscribers"] = SourceExpressionConverter.ConvertToken(requestsubscribers);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActionReminder([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<actionTypeInput> actionType, [WorkflowExpression] Func<string> requestsubscribers = null, [WorkflowExpression] Func<object> requestactionId = null, [WorkflowExpression] Func<sendToAllInput> sendToAll = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(actionType, nameof(actionType), required: true);
            SourceExpression.Validate(requestsubscribers, nameof(requestsubscribers), required: false);
            SourceExpression.Validate(requestactionId, nameof(requestactionId), required: false);
            SourceExpression.Validate(sendToAll, nameof(sendToAll), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/actions/$actionId$/reminder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = SourceExpressionConverter.Convert(actionType);
                if (sendToAll != null)
                    callPayload.Queries["sendToAll"] = SourceExpressionConverter.Convert(sendToAll);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestsubscribers != null)
                {
                    request["subscribers"] = SourceExpressionConverter.ConvertToken(requestsubscribers);
                    requestpropCount++;
                }

                if (requestactionId != null)
                {
                    request["actionWrapper"] = SourceExpressionConverter.ConvertToken(requestactionId);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<PostReactionResponse> PostReaction([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestsourceGroupId = null, [WorkflowExpression] Func<string> requestmessageId = null, [WorkflowExpression] Func<requestreactionTypeInput> requestreactionType = null, [WorkflowExpression] Func<string> requestcomment = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestsourceGroupId, nameof(requestsourceGroupId), required: false);
            SourceExpression.Validate(requestmessageId, nameof(requestmessageId), required: false);
            SourceExpression.Validate(requestreactionType, nameof(requestreactionType), required: false);
            SourceExpression.Validate(requestcomment, nameof(requestcomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/reaction", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestsourceGroupId != null)
                {
                    request["SourceGroupId"] = SourceExpressionConverter.ConvertToken(requestsourceGroupId);
                    requestpropCount++;
                }

                if (requestmessageId != null)
                {
                    request["ReferenceId"] = SourceExpressionConverter.ConvertToken(requestmessageId);
                    requestpropCount++;
                }

                if (requestreactionType != null)
                {
                    request["ReactionType"] = SourceExpressionConverter.Convert(requestreactionType);
                    requestpropCount++;
                }

                if (requestcomment != null)
                {
                    request["Comment"] = SourceExpressionConverter.ConvertToken(requestcomment);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostReactionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse> SendReply([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestmessageId, [WorkflowExpression] Func<string> requestmessage)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestmessageId, nameof(requestmessageId), required: true);
            SourceExpression.Validate(requestmessage, nameof(requestmessage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["replyToReferenceId"] = SourceExpressionConverter.ConvertToken(requestmessageId);
                requestpropCount++;
                request["message"] = SourceExpressionConverter.ConvertToken(requestmessage);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestwelcomeMessage, [WorkflowExpression] Func<string> requestmembers = null, [WorkflowExpression] Func<requestgroupTypeInput> requestgroupType = null, [WorkflowExpression] Func<string> requestshortDescription = null, [WorkflowExpression] Func<string> requestlongDescription = null)
        {
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestwelcomeMessage, nameof(requestwelcomeMessage), required: true);
            SourceExpression.Validate(requestmembers, nameof(requestmembers), required: false);
            SourceExpression.Validate(requestgroupType, nameof(requestgroupType), required: false);
            SourceExpression.Validate(requestshortDescription, nameof(requestshortDescription), required: false);
            SourceExpression.Validate(requestlongDescription, nameof(requestlongDescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Name"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                requestpropCount++;
                request["WelcomeMessage"] = SourceExpressionConverter.ConvertToken(requestwelcomeMessage);
                if (requestmembers != null)
                {
                    request["Members"] = SourceExpressionConverter.ConvertToken(requestmembers);
                    requestpropCount++;
                }

                if (requestgroupType != null)
                {
                    request["GroupType"] = SourceExpressionConverter.Convert(requestgroupType);
                    requestpropCount++;
                }

                if (requestshortDescription != null)
                {
                    request["ShortDescriptionString"] = SourceExpressionConverter.ConvertToken(requestshortDescription);
                    requestpropCount++;
                }

                if (requestlongDescription != null)
                {
                    request["LongDescriptionString"] = SourceExpressionConverter.ConvertToken(requestlongDescription);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddGroupToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string[]> requestsubGroups)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestsubGroups, nameof(requestsubGroups), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["SubGroups"] = SourceExpressionConverter.ConvertToken(requestsubGroups);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction CreateSubgroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestwelcomeMessage, [WorkflowExpression] Func<string> requestmembers = null, [WorkflowExpression] Func<requestgroupTypeInput> requestgroupType = null, [WorkflowExpression] Func<string> requestshortDescription = null, [WorkflowExpression] Func<string> requestlongDescription = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestwelcomeMessage, nameof(requestwelcomeMessage), required: true);
            SourceExpression.Validate(requestmembers, nameof(requestmembers), required: false);
            SourceExpression.Validate(requestgroupType, nameof(requestgroupType), required: false);
            SourceExpression.Validate(requestshortDescription, nameof(requestshortDescription), required: false);
            SourceExpression.Validate(requestlongDescription, nameof(requestlongDescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Name"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                requestpropCount++;
                request["WelcomeMessage"] = SourceExpressionConverter.ConvertToken(requestwelcomeMessage);
                if (requestmembers != null)
                {
                    request["Members"] = SourceExpressionConverter.ConvertToken(requestmembers);
                    requestpropCount++;
                }

                if (requestgroupType != null)
                {
                    request["GroupType"] = SourceExpressionConverter.Convert(requestgroupType);
                    requestpropCount++;
                }

                if (requestshortDescription != null)
                {
                    request["ShortDescriptionString"] = SourceExpressionConverter.ConvertToken(requestshortDescription);
                    requestpropCount++;
                }

                if (requestlongDescription != null)
                {
                    request["LongDescriptionString"] = SourceExpressionConverter.ConvertToken(requestlongDescription);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction RemoveGroupFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> subGroupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(subGroupId, nameof(subGroupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subGroupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddUserToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestmembers)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestmembers, nameof(requestmembers), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Members"] = SourceExpressionConverter.ConvertToken(requestmembers);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddSubscriberToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> requestsubscribers)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(requestsubscribers, nameof(requestsubscribers), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subscribers/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["subscribers"] = SourceExpressionConverter.ConvertToken(requestsubscribers);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction RemoveUserFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> memberId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(memberId, nameof(memberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFileContent([WorkflowExpression] Func<object> fileContent)
        {
            SourceExpression.Validate(fileContent, nameof(fileContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UploadMediaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFromURL([WorkflowExpression] Func<string> mediaUrlmediaUrl)
        {
            SourceExpression.Validate(mediaUrlmediaUrl, nameof(mediaUrlmediaUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/media/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mediaUrl = new JObject();
                var mediaUrlpropCount = 0;
                mediaUrlpropCount++;
                mediaUrl["mediaUrl"] = SourceExpressionConverter.ConvertToken(mediaUrlmediaUrl);
                if (mediaUrlpropCount > 0)
                {
                    callPayload.Body = mediaUrl;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadMediaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFromAttachment()
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionAction<UploadMediaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction DeleteTrigger([WorkflowExpression] Func<string> webhookId)
        {
            SourceExpression.Validate(webhookId, nameof(webhookId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/webhook/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webhookId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class KaizalaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ActionCreatedOnGroup([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> actionPackageId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            SourceExpression.Validate(actionPackageId, nameof(actionPackageId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/ActionCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                if (actionPackageId != null)
                    callPayload.Queries["actionPackageId"] = SourceExpressionConverter.ConvertO(actionPackageId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AnnouncementOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/Announcement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupAddedToGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/GroupAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupRemovedFromGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/GroupRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger MemberAddedToGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/MemberAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger MemberRemovedFromGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/MemberRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SurveyCreatedOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/SurveyCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TextMessageCreatedOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/TextMessageCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SurveyResponseOnGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Action/SurveyResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttachmentOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/AttachmentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ActionResponseOnGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> actionPackageId, [WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(actionPackageId, nameof(actionPackageId), required: true);
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["actionPackageId"] = SourceExpressionConverter.ConvertO(actionPackageId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UserJoinedOnGroup([WorkflowExpression] Func<string> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(objectId, nameof(objectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/Group/UserJoined";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["objectId"] = SourceExpressionConverter.ConvertO(objectId);
                var request = new JObject();
                var requestpropCount = 0;
                request["CallbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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