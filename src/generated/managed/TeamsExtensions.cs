//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teams
{
    using System.Net;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class TeamsExtensions
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<NewMeetingRespone> CreateTeamsMeeting([ConnectionName] string connectionId, Expression<Func<CreateTeamsMeetingcalendaridInput>> calendarid, Expression<Func<NewMeeting>> item)
        {
            var apiCallPath = String.Format("/v1.0/me/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<NewMeetingRespone>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetAllTeamsResponse> GetAllTeams([ConnectionName] string connectionId)
        {
            var apiCallPath = "/beta/me/joinedTeams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllTeamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetChannelsForGroupResponse> GetChannelsForGroup([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId)
        {
            var apiCallPath = String.Format("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetChannelsForGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<CreateChannelResponse> CreateChannel([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, Expression<Func<CreateChannelbodyInput>> body)
        {
            var apiCallPath = String.Format("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<CreateChannelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetChatsResponse> GetChats([ConnectionName] string connectionId, Expression<Func<GetChatschatTypeInput>> chatType, Expression<Func<GetChatstopicInput>> topic)
        {
            var apiCallPath = String.Format("/flowbot/actions/listchats/chattypes/{0}/topic/{1}/expandmembers/false", ExpressionConverter.ConvertWithUrlEncoding(chatType, 1), ExpressionConverter.ConvertWithUrlEncoding(topic, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetChatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetTagsResponseSchema> GetTags([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTagsResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<CreateTagResponseSchema> CreateTag([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, Expression<Func<CreateTagbodyInput>> body)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<CreateTagResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId, Expression<Func<AddMemberToTagbodyInput>> body)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<AddMemberToTagResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetTagMembersResponseSchema> GetTagMembers([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTagMembersResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IWorkflowAction DeleteTagMember([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId, Expression<Func<string>> tagMemberId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagMemberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IWorkflowAction PostFeedNotification([ConnectionName] string connectionId, Expression<Func<PostFeedNotificationposterInput>> poster, Expression<Func<PostFeedNotificationnotificationTypeInput>> notificationType, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/flowbot/feednotification/poster/{0}/notificationType/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(notificationType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<AtMentionTagResponse> AtMentionTag([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AtMentionTagResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IWorkflowAction DeleteTag([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetMessagesFromChannelResponse> GetMessagesFromChannel([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetChannelsForGroup")] Expression<Func<string>> channelId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMessagesFromChannelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<JToken> GetMessageDetails([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<GetMessageDetailsthreadTypeInput>> threadType, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/beta/teams/messages/{0}/messageType/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<ListMembersResponseSchema> ListMembers([ConnectionName] string connectionId, Expression<Func<ListMembersthreadTypeInput>> threadType, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/v1.0/teams/listmembers/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<ListMembersResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowTrigger<JToken> WhenWebhookAtMentionTrigger([ConnectionName] string connectionId, Expression<Func<WebhookAtMentionTriggerthreadTypeInput>> threadType, Expression<Func<JToken>> requestBody)
        {
            var apiCallPath = String.Format("/beta/subscriptions/atmentiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(requestBody);
            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowTrigger<JToken> WhenWebhookChatMessageTrigger([ConnectionName] string connectionId, Expression<Func<WebhookChatMessageTriggerChatMessageSubscriptionRequestInput>> chatMessageSubscriptionRequest)
        {
            var apiCallPath = "/beta/subscriptions/chatmessagetrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(chatMessageSubscriptionRequest);
            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowTrigger<JToken> WhenWebhookKeywordTrigger([ConnectionName] string connectionId, Expression<Func<WebhookKeywordTriggerthreadTypeInput>> threadType, Expression<Func<string>> search, Expression<Func<JToken>> requestBody)
        {
            var apiCallPath = String.Format("/beta/subscriptions/keywordtrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
            callPayload.Body = ExpressionConverter.ConvertObject(requestBody);
            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowTrigger<JToken> WhenWebhookNewMessageTrigger([ConnectionName] string connectionId, Expression<Func<WebhookNewMessageTriggerthreadTypeInput>> threadType, Expression<Func<JToken>> requestBody)
        {
            var apiCallPath = String.Format("/beta/subscriptions/newmessagetrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(requestBody);
            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<JToken> SubscribeUserMessageWithOptions([ConnectionName] string connectionId, Expression<Func<JToken>> userMessageWithOptionsSubscriptionRequest)
        {
            var apiCallPath = "/flowbot/actions/messagewithoptions/recipienttypes/user/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(userMessageWithOptionsSubscriptionRequest);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<GetTeamResponse> GetTeam([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> teamId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<AtMentionUserV1> AtMentionUser([ConnectionName] string connectionId, Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AtMentionUserV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowTrigger<OnGroupMemberChangeResponseItem[]> WhenOnGroupMembershipRemoval([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId)
        {
            var apiCallPath = "/trigger/v1.0/groups/removal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["$select"] = "members";
            return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowTrigger<OnGroupMemberChangeResponseItem[]> WhenOnGroupMembershipAdd([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> groupId)
        {
            var apiCallPath = "/trigger/v1.0/groups/delta";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["$select"] = "members";
            return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<NewChatResponse> CreateChat([ConnectionName] string connectionId, Expression<Func<NewChat>> item)
        {
            var apiCallPath = "/beta/chats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<NewChatResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<CreateATeamResponse> CreateATeam([ConnectionName] string connectionId, Expression<Func<CreateATeambodyInput>> body)
        {
            var apiCallPath = "/beta/teams";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<CreateATeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IWorkflowAction AddMemberToTeam([ConnectionName] string connectionId, [DynamicValues("GetAllTeams")] Expression<Func<string>> teamId, Expression<Func<AddMemberToTeambodyInput>> body)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<PostToConversationResponse> PostMessageToConversation([ConnectionName] string connectionId, Expression<Func<PostMessageToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<object>> body)
        {
            var apiCallPath = String.Format("/beta/teams/conversation/message/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<PostToConversationResponse> ReplyWithMessageToConversation([ConnectionName] string connectionId, Expression<Func<ReplyWithMessageToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/replyWithMessage/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<PostToConversationResponse> PostCardToConversation([ConnectionName] string connectionId, Expression<Func<PostCardToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/adaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<JToken> PostCardAndWaitForResponse([ConnectionName] string connectionId, Expression<Func<PostCardAndWaitForResponseposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<PostCardAndWaitForResponsebodyInput>> body)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/gatherinput/poster/{0}/location/{1}/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<PostToConversationResponse> ReplyWithCardToConversation([ConnectionName] string connectionId, Expression<Func<ReplyWithCardToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/replyWithAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<PostToConversationResponse> UpdateCardInConversation([ConnectionName] string connectionId, Expression<Func<UpdateCardInConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/updateAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public static IOutputWorkflowAction<JToken> HttpRequest([ConnectionName] string connectionId, Expression<Func<string>> uri, Expression<Func<HttpRequestMethodInput>> method, Expression<Func<string>> body, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var apiCallPath = "/httprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
            callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
            if (contentType != null)
            {
                callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
            }

            if (customHeader1 != null)
            {
                callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
            }

            if (customHeader2 != null)
            {
                callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
            }

            if (customHeader3 != null)
            {
                callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
            }

            if (customHeader4 != null)
            {
                callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
            }

            if (customHeader5 != null)
            {
                callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
            }

            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class TeamsInstance(string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<NewMeetingRespone> CreateTeamsMeeting(Expression<Func<CreateTeamsMeetingcalendaridInput>> calendarid, Expression<Func<NewMeeting>> item) => TeamsExtensions.CreateTeamsMeeting(connectionId, calendarid, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetAllTeamsResponse> GetAllTeams() => TeamsExtensions.GetAllTeams(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetChannelsForGroupResponse> GetChannelsForGroup([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId) => TeamsExtensions.GetChannelsForGroup(connectionId, groupId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<CreateChannelResponse> CreateChannel([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, Expression<Func<CreateChannelbodyInput>> body) => TeamsExtensions.CreateChannel(connectionId, groupId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetChatsResponse> GetChats(Expression<Func<GetChatschatTypeInput>> chatType, Expression<Func<GetChatstopicInput>> topic) => TeamsExtensions.GetChats(connectionId, chatType, topic);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetTagsResponseSchema> GetTags([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId) => TeamsExtensions.GetTags(connectionId, groupId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<CreateTagResponseSchema> CreateTag([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, Expression<Func<CreateTagbodyInput>> body) => TeamsExtensions.CreateTag(connectionId, groupId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId, Expression<Func<AddMemberToTagbodyInput>> body) => TeamsExtensions.AddMemberToTag(connectionId, groupId, tagId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetTagMembersResponseSchema> GetTagMembers([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId) => TeamsExtensions.GetTagMembers(connectionId, groupId, tagId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTagMember([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId, Expression<Func<string>> tagMemberId) => TeamsExtensions.DeleteTagMember(connectionId, groupId, tagId, tagMemberId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction PostFeedNotification(Expression<Func<PostFeedNotificationposterInput>> poster, Expression<Func<PostFeedNotificationnotificationTypeInput>> notificationType, Expression<Func<JToken>> body) => TeamsExtensions.PostFeedNotification(connectionId, poster, notificationType, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<AtMentionTagResponse> AtMentionTag([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId) => TeamsExtensions.AtMentionTag(connectionId, groupId, tagId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTag([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetTags")] Expression<Func<string>> tagId) => TeamsExtensions.DeleteTag(connectionId, groupId, tagId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetMessagesFromChannelResponse> GetMessagesFromChannel([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId, [DynamicValues("GetChannelsForGroup")] Expression<Func<string>> channelId) => TeamsExtensions.GetMessagesFromChannel(connectionId, groupId, channelId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<JToken> GetMessageDetails(Expression<Func<string>> messageId, Expression<Func<GetMessageDetailsthreadTypeInput>> threadType, Expression<Func<JToken>> body) => TeamsExtensions.GetMessageDetails(connectionId, messageId, threadType, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<ListMembersResponseSchema> ListMembers(Expression<Func<ListMembersthreadTypeInput>> threadType, Expression<Func<JToken>> body) => TeamsExtensions.ListMembers(connectionId, threadType, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<JToken> SubscribeUserMessageWithOptions(Expression<Func<JToken>> userMessageWithOptionsSubscriptionRequest) => TeamsExtensions.SubscribeUserMessageWithOptions(connectionId, userMessageWithOptionsSubscriptionRequest);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<GetTeamResponse> GetTeam([DynamicValues("GetAllTeams")] Expression<Func<string>> teamId) => TeamsExtensions.GetTeam(connectionId, teamId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<AtMentionUserV1> AtMentionUser(Expression<Func<string>> userId) => TeamsExtensions.AtMentionUser(connectionId, userId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<NewChatResponse> CreateChat(Expression<Func<NewChat>> item) => TeamsExtensions.CreateChat(connectionId, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<CreateATeamResponse> CreateATeam(Expression<Func<CreateATeambodyInput>> body) => TeamsExtensions.CreateATeam(connectionId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction AddMemberToTeam([DynamicValues("GetAllTeams")] Expression<Func<string>> teamId, Expression<Func<AddMemberToTeambodyInput>> body) => TeamsExtensions.AddMemberToTeam(connectionId, teamId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<PostToConversationResponse> PostMessageToConversation(Expression<Func<PostMessageToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<object>> body) => TeamsExtensions.PostMessageToConversation(connectionId, poster, location, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<PostToConversationResponse> ReplyWithMessageToConversation(Expression<Func<ReplyWithMessageToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body) => TeamsExtensions.ReplyWithMessageToConversation(connectionId, poster, location, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<PostToConversationResponse> PostCardToConversation(Expression<Func<PostCardToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body) => TeamsExtensions.PostCardToConversation(connectionId, poster, location, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<JToken> PostCardAndWaitForResponse(Expression<Func<PostCardAndWaitForResponseposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<PostCardAndWaitForResponsebodyInput>> body) => TeamsExtensions.PostCardAndWaitForResponse(connectionId, poster, location, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<PostToConversationResponse> ReplyWithCardToConversation(Expression<Func<ReplyWithCardToConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body) => TeamsExtensions.ReplyWithCardToConversation(connectionId, poster, location, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<PostToConversationResponse> UpdateCardInConversation(Expression<Func<UpdateCardInConversationposterInput>> poster, [DynamicValues("GetMessageLocations")] Expression<Func<string>> location, Expression<Func<JToken>> body) => TeamsExtensions.UpdateCardInConversation(connectionId, poster, location, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IOutputWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<HttpRequestMethodInput>> method, Expression<Func<string>> body, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null) => TeamsExtensions.HttpRequest(connectionId, uri, method, body, contentType, customHeader1, customHeader2, customHeader3, customHeader4, customHeader5);
    }

    public class TeamsInstanceTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<JToken> WhenWebhookAtMentionTrigger(Expression<Func<WebhookAtMentionTriggerthreadTypeInput>> threadType, Expression<Func<JToken>> requestBody) => TeamsExtensions.WhenWebhookAtMentionTrigger(connectionId, threadType, requestBody);
        public IOutputWorkflowTrigger<JToken> WhenWebhookChatMessageTrigger(Expression<Func<WebhookChatMessageTriggerChatMessageSubscriptionRequestInput>> chatMessageSubscriptionRequest) => TeamsExtensions.WhenWebhookChatMessageTrigger(connectionId, chatMessageSubscriptionRequest);
        public IOutputWorkflowTrigger<JToken> WhenWebhookKeywordTrigger(Expression<Func<WebhookKeywordTriggerthreadTypeInput>> threadType, Expression<Func<string>> search, Expression<Func<JToken>> requestBody) => TeamsExtensions.WhenWebhookKeywordTrigger(connectionId, threadType, search, requestBody);
        public IOutputWorkflowTrigger<JToken> WhenWebhookNewMessageTrigger(Expression<Func<WebhookNewMessageTriggerthreadTypeInput>> threadType, Expression<Func<JToken>> requestBody) => TeamsExtensions.WhenWebhookNewMessageTrigger(connectionId, threadType, requestBody);
        public IOutputWorkflowTrigger<OnGroupMemberChangeResponseItem[]> WhenOnGroupMembershipRemoval([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId) => TeamsExtensions.WhenOnGroupMembershipRemoval(connectionId, groupId);
        public IOutputWorkflowTrigger<OnGroupMemberChangeResponseItem[]> WhenOnGroupMembershipAdd([DynamicValues("GetAllTeams")] Expression<Func<string>> groupId) => TeamsExtensions.WhenOnGroupMembershipAdd(connectionId, groupId);
    }

    public class NewMeetingBodyType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    public class NewMeetingStartType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class NewMeetingEndType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class NewMeetingLocationType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NewMeetingRecurrenceTypePatternType
    {
        [JsonProperty("type")]
        public NewMeetingRecurrenceTypePatternTypeTypeType Type { get; set; }

        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("daysOfWeek")]
        public string[] DaysOfWeek { get; set; }

        [JsonProperty("index")]
        public NewMeetingRecurrenceTypePatternTypeIndexType Index { get; set; }
    }

    public class NewMeetingRecurrenceTypeRangeType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class NewMeetingRecurrenceType
    {
        [JsonProperty("pattern")]
        public NewMeetingRecurrenceTypePatternType Pattern { get; set; }

        [JsonProperty("range")]
        public NewMeetingRecurrenceTypeRangeType Range { get; set; }
    }

    public class NewMeeting
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public NewMeetingBodyType Body { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("start")]
        public NewMeetingStartType Start { get; set; }

        [JsonProperty("end")]
        public NewMeetingEndType End { get; set; }

        [JsonProperty("requiredAttendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("optionalAttendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("location")]
        public NewMeetingLocationType Location { get; set; }

        [JsonProperty("importance")]
        public NewMeetingImportanceType Importance { get; set; }

        [JsonProperty("recurrence")]
        public NewMeetingRecurrenceType Recurrence { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDay { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderMinutesBeforeStart { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public NewMeetingShowAsType ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("isOnlineMeeting")]
        public bool IsOnlineMeeting { get; set; }

        [JsonProperty("onlineMeetingProvider")]
        public string OnlineMeetingProvider { get; set; }
    }

    public class NewMeetingResponeRecurrenceType
    {
        [JsonProperty("pattern")]
        public JToken Pattern { get; set; }

        [JsonProperty("range")]
        public JToken Range { get; set; }
    }

    public class NewMeetingResponeResponseStatusType
    {
        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class NewMeetingResponeBodyType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class NewMeetingResponeStartType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class NewMeetingResponeEndType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class NewMeetingResponeLocationType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NewMeetingResponeAttendeesTypeItemStatusType
    {
        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class NewMeetingResponeAttendeesTypeItemEmailAddressType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class NewMeetingResponeAttendeesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public NewMeetingResponeAttendeesTypeItemStatusType Status { get; set; }

        [JsonProperty("emailAddress")]
        public NewMeetingResponeAttendeesTypeItemEmailAddressType EmailAddress { get; set; }
    }

    public class NewMeetingResponeOrganizerTypeEmailAddressType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class NewMeetingResponeOrganizerType
    {
        [JsonProperty("emailAddress")]
        public NewMeetingResponeOrganizerTypeEmailAddressType EmailAddress { get; set; }
    }

    public class NewMeetingResponeOnlineMeetingType
    {
        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }
    }

    public class NewMeetingRespone
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("categories")]
        public JToken[] Categories { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderMinutesBeforeStart { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("hasAttachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("bodyPreview")]
        public string BodyPreview { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("sensitivity")]
        public string Sensitivity { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDay { get; set; }

        [JsonProperty("isCancelled")]
        public bool IsCancelled { get; set; }

        [JsonProperty("isOrganizer")]
        public bool IsOrganizer { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("showAs")]
        public string ShowAs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("onlineMeetingUrl")]
        public string OnlineMeetingUrl { get; set; }

        [JsonProperty("allowNewTimeProposals")]
        public bool AllowNewTimeProposals { get; set; }

        [JsonProperty("recurrence")]
        public NewMeetingResponeRecurrenceType Recurrence { get; set; }

        [JsonProperty("responseStatus")]
        public NewMeetingResponeResponseStatusType ResponseStatus { get; set; }

        [JsonProperty("body")]
        public NewMeetingResponeBodyType Body { get; set; }

        [JsonProperty("start")]
        public NewMeetingResponeStartType Start { get; set; }

        [JsonProperty("end")]
        public NewMeetingResponeEndType End { get; set; }

        [JsonProperty("location")]
        public NewMeetingResponeLocationType Location { get; set; }

        [JsonProperty("attendees")]
        public NewMeetingResponeAttendeesTypeItem[] Attendees { get; set; }

        [JsonProperty("organizer")]
        public NewMeetingResponeOrganizerType Organizer { get; set; }

        [JsonProperty("onlineMeeting")]
        public NewMeetingResponeOnlineMeetingType OnlineMeeting { get; set; }
    }

    public class GetSupportedTimeZonesResponseValueTypeItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class GetSupportedTimeZonesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetSupportedTimeZonesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetAllTeamsResponseValueTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllTeamsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetAllTeamsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetChannelsForGroupResponseValueTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetChannelsForGroupResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetChannelsForGroupResponseValueTypeItem[] Value { get; set; }
    }

    public class CreateChannelbodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class CreateChannelResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetChatsResponseValueTypeItem
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastUpdatedDateTime")]
        public string LastUpdatedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetChatsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetChatsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetTagsResponseSchemaValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("memberCount")]
        public int MemberCount { get; set; }
    }

    public class GetTagsResponseSchema
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetTagsResponseSchemaValueTypeItem[] Value { get; set; }
    }

    public class CreateTagbodyInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public string Members { get; set; }
    }

    public class CreateTagResponseSchema
    {
        [JsonProperty("@odata.type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("memberCount")]
        public int MemberCount { get; set; }
    }

    public class AddMemberToTagbodyInput
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class AddMemberToTagResponseSchema
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class GetTagMembersResponseSchemaValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class GetTagMembersResponseSchema
    {
        [JsonProperty("value")]
        public GetTagMembersResponseSchemaValueTypeItem[] Value { get; set; }
    }

    public class AtMentionTagResponse
    {
        [JsonProperty("atMention")]
        public string AtMention { get; set; }
    }

    public class OnNewChannelMessageResponseItemBodyType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    public class OnNewChannelMessageResponseItemFromTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identityProvider")]
        public string IdentityProvider { get; set; }
    }

    public class OnNewChannelMessageResponseItemFromType
    {
        [JsonProperty("application")]
        public JToken Application { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("user")]
        public OnNewChannelMessageResponseItemFromTypeUserType User { get; set; }
    }

    public class OnNewChannelMessageResponseItem
    {
        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("body")]
        public OnNewChannelMessageResponseItemBodyType Body { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("from")]
        public OnNewChannelMessageResponseItemFromType From { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("mentions")]
        public JToken[] Mentions { get; set; }

        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        [JsonProperty("reactions")]
        public JToken[] Reactions { get; set; }

        [JsonProperty("replyToId")]
        public string ReplyToId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class GetMessagesFromChannelResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public OnNewChannelMessageResponseItem[] Value { get; set; }
    }

    public class ListMembersResponseSchemaValueTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("visibleHistoryStartDateTime")]
        public string VisibleHistoryStartDateTime { get; set; }
    }

    public class ListMembersResponseSchema
    {
        [JsonProperty("value")]
        public ListMembersResponseSchemaValueTypeItem[] Value { get; set; }
    }

    public class WebhookChatMessageTriggerChatMessageSubscriptionRequestInput
    {
        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }
    }

    public class RenewWebHookSubscriptionbodyInput
    {
        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }
    }

    public class UnifiedActionSchema
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class DynamicResponseSchema
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class ConnectorMetadata
    {
        [JsonProperty("metadatatype")]
        public string Metadatatype { get; set; }

        [JsonProperty("activitytype")]
        public string Activitytype { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class SelectedMessageTriggerMetadata
    {
        public JToken TeamsFlowRunContext { get; set; }
        public JToken CardOutputs { get; set; }
    }

    public class ComposeMessageTriggerMetadata
    {
        public JToken TeamsFlowRunContext { get; set; }
        public JToken CardOutputs { get; set; }
    }

    public class CardResponseTriggerMetadata
    {
        public JToken TeamsFlowRunContext { get; set; }
        public JToken CardOutputs { get; set; }
    }

    public class MemberSettings
    {
        [JsonProperty("allowCreateUpdateChannels")]
        public bool AllowCreateUpdateChannels { get; set; }

        [JsonProperty("allowDeleteChannels")]
        public bool AllowDeleteChannels { get; set; }

        [JsonProperty("allowAddRemoveApps")]
        public bool AllowAddRemoveApps { get; set; }

        [JsonProperty("allowCreateUpdateRemoveTabs")]
        public bool AllowCreateUpdateRemoveTabs { get; set; }

        [JsonProperty("allowCreateUpdateRemoveConnectors")]
        public bool AllowCreateUpdateRemoveConnectors { get; set; }
    }

    public class GuestSettings
    {
        [JsonProperty("allowCreateUpdateChannels")]
        public bool AllowCreateUpdateChannels { get; set; }

        [JsonProperty("allowDeleteChannels")]
        public bool AllowDeleteChannels { get; set; }
    }

    public class MessagingSettings
    {
        [JsonProperty("allowUserEditMessages")]
        public bool AllowUserEditMessages { get; set; }

        [JsonProperty("allowUserDeleteMessages")]
        public bool AllowUserDeleteMessages { get; set; }

        [JsonProperty("allowOwnerDeleteMessages")]
        public bool AllowOwnerDeleteMessages { get; set; }

        [JsonProperty("allowTeamMentions")]
        public bool AllowTeamMentions { get; set; }

        [JsonProperty("allowChannelMentions")]
        public bool AllowChannelMentions { get; set; }
    }

    public class FunSettings
    {
        [JsonProperty("allowGiphy")]
        public bool AllowGiphy { get; set; }

        [JsonProperty("giphyContentRating")]
        public string GiphyContentRating { get; set; }

        [JsonProperty("allowStickersAndMemes")]
        public bool AllowStickersAndMemes { get; set; }

        [JsonProperty("allowCustomMemes")]
        public bool AllowCustomMemes { get; set; }
    }

    public class DiscoverySettings
    {
        [JsonProperty("showInTeamsSearchAndSuggestions")]
        public bool ShowInTeamsSearchAndSuggestions { get; set; }
    }

    public class GetTeamResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("isArchived")]
        public bool IsArchived { get; set; }

        [JsonProperty("memberSettings")]
        public MemberSettings MemberSettings { get; set; }

        [JsonProperty("guestSettings")]
        public GuestSettings GuestSettings { get; set; }

        [JsonProperty("messagingSettings")]
        public MessagingSettings MessagingSettings { get; set; }

        [JsonProperty("funSettings")]
        public FunSettings FunSettings { get; set; }

        [JsonProperty("discoverySettings")]
        public DiscoverySettings DiscoverySettings { get; set; }
    }

    public class AtMentionUserV1
    {
        [JsonProperty("atMention")]
        public string AtMention { get; set; }
    }

    public class OnGroupMemberChangeResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class NewChat
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("members")]
        public string Members { get; set; }
    }

    public class NewChatResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateATeambodyInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("visibility")]
        public CreateATeambodyInputVisibilityType Visibility { get; set; }
    }

    public class CreateATeamResponse
    {
        [JsonProperty("newTeamId")]
        public string NewTeamId { get; set; }
    }

    public class AddMemberToTeambodyInput
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }
    }

    public class PostToConversationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("messageLink")]
        public string MessageLink { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }
    }

    public class PostCardAndWaitForResponsebodyInputBodyType
    {
        [JsonProperty("recipient")]
        public JToken Recipient { get; set; }

        [JsonProperty("messageBody")]
        public string MessageBody { get; set; }

        [JsonProperty("updateMessage")]
        public string UpdateMessage { get; set; }
    }

    public class PostCardAndWaitForResponsebodyInput
    {
        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }

        [JsonProperty("body")]
        public PostCardAndWaitForResponsebodyInputBodyType Body { get; set; }
    }

    public class GetMessageDetailsSchema
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class ListMembersSchema
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class WebhookTriggerSchema
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class GetMessageLocationsResponse
    {
        [JsonProperty("locations")]
        public JToken[] Locations { get; set; }
    }

    public class PostFeedSchema
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class VirtualAgentBotsValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("botid")]
        public string Botid { get; set; }
    }

    public class VirtualAgentBots
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public VirtualAgentBotsValueTypeItem[] Value { get; set; }
    }

    public enum CreateTeamsMeetingcalendaridInput
    {
        Birthdays,
        Calendar,
        [EnumMember(Value = "United States holidays")]
        UnitedStatesHolidays
    }

    public enum NewMeetingImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum NewMeetingRecurrenceTypePatternTypeTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "relativeMonthly")]
        Monthly,
        [EnumMember(Value = "relativeYearly")]
        RelativeYearly
    }

    public enum NewMeetingRecurrenceTypePatternTypeIndexType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "first")]
        First,
        [EnumMember(Value = "second")]
        Second,
        [EnumMember(Value = "third")]
        Third,
        [EnumMember(Value = "fourth")]
        Fourth,
        [EnumMember(Value = "last")]
        Last
    }

    public enum NewMeetingShowAsType
    {
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "oof")]
        Oof,
        [EnumMember(Value = "workingElsewhere")]
        WorkingElsewhere,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public enum GetChatschatTypeInput
    {
        [EnumMember(Value = "all")]
        AllChatTypes,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "oneOnOne")]
        OneOnOne
    }

    public enum GetChatstopicInput
    {
        [EnumMember(Value = "all")]
        AllChats,
        [EnumMember(Value = "isDefined")]
        IsDefined,
        [EnumMember(Value = "notDefined")]
        IsNotDefined
    }

    public enum PostFeedNotificationposterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot
    }

    public enum PostFeedNotificationnotificationTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "team")]
        Team
    }

    public enum GetMessageDetailsthreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum ListMembersthreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat
    }

    public enum WebhookAtMentionTriggerthreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum WebhookKeywordTriggerthreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum WebhookNewMessageTriggerthreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum GetUnifiedActionSchemaposterInput
    {
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum GetPostToConversationResponseSchemaposterInput
    {
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum GetFlowContinuationSubscriptionWithPosterOutputMetadataposterInput
    {
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot
    }

    public enum CreateATeambodyInputVisibilityType
    {
        Private,
        Public
    }

    public enum PostMessageToConversationposterInput
    {
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum ReplyWithMessageToConversationposterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum PostCardToConversationposterInput
    {
        [EnumMember(Value = "Power Apps")]
        PowerApps,
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum PostCardAndWaitForResponseposterInput
    {
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot
    }

    public enum ReplyWithCardToConversationposterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum UpdateCardInConversationposterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum GetMessageDetailsInputSchemathreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum GetMessageDetailsResponseSchemathreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum ListMembersInputSchemathreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum GetWebhookTriggerRequestSchemathreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum GetWebhookTriggerResponseSchemathreadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public enum GetMessageLocationsposterInput
    {
        [EnumMember(Value = "Power Virtual Agents")]
        PowerVirtualAgentsPreview,
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    public enum GetFeedNotificationInputSchemaposterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot
    }

    public enum GetFeedNotificationInputSchemanotificationTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "team")]
        Team
    }

    public enum HttpRequestMethodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teams;

    public static class TeamsTriggerInstanceExtensions
    {
        public static TeamsInstanceTriggers Teams(this WorkflowManagedTriggers t, string connectionId) => new TeamsInstanceTriggers(connectionId);
        public static TeamsInstance Teams(this WorkflowManagedActions t, string connectionId) => new TeamsInstance(connectionId);
    }
}