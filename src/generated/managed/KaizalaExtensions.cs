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
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> groupId, Expression<Func<string>> requestmessage, Expression<Func<string>> requestsubscribers = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sendToAll != null)
                callPayload.Queries["sendToAll"] = CSharpExpressionConverter.Convert(sendToAll);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["Message"] = CSharpExpressionConverter.ConvertToken(requestmessage);
            if (requestsubscribers != null)
            {
                request["subscribers"] = CSharpExpressionConverter.ConvertToken(requestsubscribers);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActions(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType = null, Expression<Func<string>> id = null, Expression<Func<object>> requestactionBody = null, Expression<Func<string>> requestsubscribers = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/actions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (actionType != null)
                callPayload.Queries["actionType"] = CSharpExpressionConverter.Convert(actionType);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            if (sendToAll != null)
                callPayload.Queries["sendToAll"] = CSharpExpressionConverter.Convert(sendToAll);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestactionBody != null)
            {
                request["actionBody"] = CSharpExpressionConverter.ConvertToken(requestactionBody);
                requestpropCount++;
            }

            if (requestsubscribers != null)
            {
                request["subscribers"] = CSharpExpressionConverter.ConvertToken(requestsubscribers);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SendActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActionReminder(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType, Expression<Func<string>> requestsubscribers = null, Expression<Func<object>> requestactionId = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/actions/$actionId$/reminder", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = CSharpExpressionConverter.Convert(actionType);
            if (sendToAll != null)
                callPayload.Queries["sendToAll"] = CSharpExpressionConverter.Convert(sendToAll);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestsubscribers != null)
            {
                request["subscribers"] = CSharpExpressionConverter.ConvertToken(requestsubscribers);
                requestpropCount++;
            }

            if (requestactionId != null)
            {
                request["actionWrapper"] = CSharpExpressionConverter.ConvertToken(requestactionId);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SendActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<PostReactionResponse> PostReaction(Expression<Func<string>> groupId, Expression<Func<string>> requestsourceGroupId = null, Expression<Func<string>> requestmessageId = null, Expression<Func<requestreactionTypeInput>> requestreactionType = null, Expression<Func<string>> requestcomment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/reaction", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestsourceGroupId != null)
            {
                request["SourceGroupId"] = CSharpExpressionConverter.ConvertToken(requestsourceGroupId);
                requestpropCount++;
            }

            if (requestmessageId != null)
            {
                request["ReferenceId"] = CSharpExpressionConverter.ConvertToken(requestmessageId);
                requestpropCount++;
            }

            if (requestreactionType != null)
            {
                request["ReactionType"] = CSharpExpressionConverter.Convert(requestreactionType);
                requestpropCount++;
            }

            if (requestcomment != null)
            {
                request["Comment"] = CSharpExpressionConverter.ConvertToken(requestcomment);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<PostReactionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse> SendReply(Expression<Func<string>> groupId, Expression<Func<string>> requestmessageId, Expression<Func<string>> requestmessage)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/groups/{0}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["replyToReferenceId"] = CSharpExpressionConverter.ConvertToken(requestmessageId);
            requestpropCount++;
            request["message"] = CSharpExpressionConverter.ConvertToken(requestmessage);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup(Expression<Func<string>> requestgroupName, Expression<Func<string>> requestwelcomeMessage, Expression<Func<string>> requestmembers = null, Expression<Func<requestgroupTypeInput>> requestgroupType = null, Expression<Func<string>> requestshortDescription = null, Expression<Func<string>> requestlongDescription = null)
        {
            var apiCallPath = "/v1/groups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["Name"] = CSharpExpressionConverter.ConvertToken(requestgroupName);
            requestpropCount++;
            request["WelcomeMessage"] = CSharpExpressionConverter.ConvertToken(requestwelcomeMessage);
            if (requestmembers != null)
            {
                request["Members"] = CSharpExpressionConverter.ConvertToken(requestmembers);
                requestpropCount++;
            }

            if (requestgroupType != null)
            {
                request["GroupType"] = CSharpExpressionConverter.Convert(requestgroupType);
                requestpropCount++;
            }

            if (requestshortDescription != null)
            {
                request["ShortDescriptionString"] = CSharpExpressionConverter.ConvertToken(requestshortDescription);
                requestpropCount++;
            }

            if (requestlongDescription != null)
            {
                request["LongDescriptionString"] = CSharpExpressionConverter.ConvertToken(requestlongDescription);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<CreateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddGroupToGroup(Expression<Func<string>> groupId, Expression<Func<string[]>> requestsubGroups)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["SubGroups"] = CSharpExpressionConverter.ConvertToken(requestsubGroups);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction CreateSubgroup(Expression<Func<string>> groupId, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestwelcomeMessage, Expression<Func<string>> requestmembers = null, Expression<Func<requestgroupTypeInput>> requestgroupType = null, Expression<Func<string>> requestshortDescription = null, Expression<Func<string>> requestlongDescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["Name"] = CSharpExpressionConverter.ConvertToken(requestgroupName);
            requestpropCount++;
            request["WelcomeMessage"] = CSharpExpressionConverter.ConvertToken(requestwelcomeMessage);
            if (requestmembers != null)
            {
                request["Members"] = CSharpExpressionConverter.ConvertToken(requestmembers);
                requestpropCount++;
            }

            if (requestgroupType != null)
            {
                request["GroupType"] = CSharpExpressionConverter.Convert(requestgroupType);
                requestpropCount++;
            }

            if (requestshortDescription != null)
            {
                request["ShortDescriptionString"] = CSharpExpressionConverter.ConvertToken(requestshortDescription);
                requestpropCount++;
            }

            if (requestlongDescription != null)
            {
                request["LongDescriptionString"] = CSharpExpressionConverter.ConvertToken(requestlongDescription);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction RemoveGroupFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> subGroupId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subgroups/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subGroupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddUserToGroup(Expression<Func<string>> groupId, Expression<Func<string>> requestmembers)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["Members"] = CSharpExpressionConverter.ConvertToken(requestmembers);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddSubscriberToGroup(Expression<Func<string>> groupId, Expression<Func<string>> requestsubscribers)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/subscribers/add", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["subscribers"] = CSharpExpressionConverter.ConvertToken(requestsubscribers);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction RemoveUserFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> memberId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/groups/{0}/members/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFileContent(Expression<Func<object>> fileContent)
        {
            var apiCallPath = "/v1/media";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadMediaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<UploadMediaResponse> UploadMediaFromURL(Expression<Func<string>> mediaUrlmediaUrl)
        {
            var apiCallPath = "/v1/media/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mediaUrl = new JObject();
            var mediaUrlpropCount = 0;
            mediaUrlpropCount++;
            mediaUrl["mediaUrl"] = CSharpExpressionConverter.ConvertToken(mediaUrlmediaUrl);
            if (mediaUrlpropCount > 0)
            {
                callPayload.Body = mediaUrl;
            }

            return new ApiConnectionAction<UploadMediaResponse>(callPayload);
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
        public IWorkflowAction DeleteTrigger(Expression<Func<string>> webhookId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/webhook/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(webhookId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class KaizalaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ActionCreatedOnGroup(Expression<Func<string>> objectId, Expression<Func<string>> actionPackageId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/ActionCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            if (actionPackageId != null)
                callPayload.Queries["actionPackageId"] = CSharpExpressionConverter.ConvertO(actionPackageId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AnnouncementOnGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/Announcement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupAddedToGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/GroupAdded";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupRemovedFromGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/GroupRemoved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger MemberAddedToGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/MemberAdded";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger MemberRemovedFromGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/MemberRemoved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SurveyCreatedOnGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/SurveyCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TextMessageCreatedOnGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/TextMessageCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SurveyResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Action/SurveyResponse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = CSharpExpressionConverter.ConvertO(groupId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AttachmentOnGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/AttachmentCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ActionResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> actionPackageId, Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = CSharpExpressionConverter.ConvertO(groupId);
            callPayload.Queries["actionPackageId"] = CSharpExpressionConverter.ConvertO(actionPackageId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UserJoinedOnGroup(Expression<Func<string>> objectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/Group/UserJoined";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = CSharpExpressionConverter.ConvertO(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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