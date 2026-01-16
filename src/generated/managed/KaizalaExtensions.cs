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
            var apiCallPath = String.Format("/v1/groups/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActions(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType = null, Expression<Func<string>> id = null, Expression<Func<object>> requestactionBody = null, Expression<Func<string>> requestsubscribers = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActionsV2(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType = null, Expression<Func<object>> requestactionBody = null, Expression<Func<string>> requestsubscribers = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var apiCallPath = String.Format("/groups/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = Convert.ToString("Action Package");
            if (actionType != null)
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendActionResponse> SendActionReminder(Expression<Func<string>> groupId, Expression<Func<actionTypeInput>> actionType, Expression<Func<string>> requestsubscribers = null, Expression<Func<object>> requestactionId = null, Expression<Func<sendToAllInput>> sendToAll = null)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/actions/$actionId$/reminder", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<PostReactionResponse> PostReaction(Expression<Func<string>> groupId, Expression<Func<string>> requestsourceGroupId = null, Expression<Func<string>> requestmessageId = null, Expression<Func<requestreactionTypeInput>> requestreactionType = null, Expression<Func<string>> requestcomment = null)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/reaction", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IBodyWorkflowAction<SendMessageResponse> SendReply(Expression<Func<string>> groupId, Expression<Func<string>> requestmessageId, Expression<Func<string>> requestmessage)
        {
            var apiCallPath = String.Format("/groups/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddGroupToGroup(Expression<Func<string>> groupId, Expression<Func<string[]>> requestSubGroups)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/subgroups", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["SubGroups"] = ExpressionConverter.ConvertO(requestSubGroups);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction CreateSubgroup(Expression<Func<string>> groupId, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestwelcomeMessage, Expression<Func<string>> requestmembers = null, Expression<Func<requestgroupTypeInput>> requestgroupType = null, Expression<Func<string>> requestshortDescription = null, Expression<Func<string>> requestlongDescription = null)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/subgroups", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction RemoveGroupFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> subGroupId)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/subgroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(subGroupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddUserToGroup(Expression<Func<string>> groupId, Expression<Func<string>> requestmembers)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction AddSubscriberToGroup(Expression<Func<string>> groupId, Expression<Func<string>> requestsubscribers)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/subscribers/add", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kaizala")]
        public IWorkflowAction RemoveUserFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> memberId)
        {
            var apiCallPath = String.Format("/v1/groups/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
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
            mediaUrl["mediaUrl"] = ExpressionConverter.ConvertO(mediaUrlmediaUrl);
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
            var apiCallPath = String.Format("/v1/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(webhookId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class KaizalaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ActionCreatedOnGroup(Expression<Func<string>> objectId, Expression<Func<string>> actionPackageId = null, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/ActionCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            if (actionPackageId != null)
                callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(actionPackageId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger AnnouncementOnGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/Announcement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GroupAddedToGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/GroupAdded";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GroupRemovedFromGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/GroupRemoved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger MemberAddedToGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/MemberAdded";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger MemberRemovedFromGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/MemberRemoved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger SurveyCreatedOnGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/SurveyCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TextMessageCreatedOnGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/TextMessageCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger SurveyResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Action/SurveyResponse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger AttachmentOnGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/AttachmentCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ActionResponseOnGroup(Expression<Func<string>> groupId, Expression<Func<string>> actionPackageId, Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["actionPackageId"] = ExpressionConverter.Convert(actionPackageId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UserJoinedOnGroup(Expression<Func<string>> objectId, string triggerName = null)
        {
            var apiCallPath = "/v1/webhook/Group/UserJoined";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["objectId"] = ExpressionConverter.Convert(objectId);
            var request = new JObject();
            var requestpropCount = 0;
            request["CallbackUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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