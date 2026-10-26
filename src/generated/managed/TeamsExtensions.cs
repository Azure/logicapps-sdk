//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teams
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewMeetingRespone, ApiConnectionActionConfiguration> CreateTeamsMeeting(Expression<Func<calendaridInput>> calendarid, Expression<Func<CreateTeamsMeetingInput>> item)
        {
            var __workflow_calendarid = WorkflowExpression.Compile(calendarid, nameof(calendarid), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<NewMeetingRespone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/calendars/{0}/events", __workflow_calendarid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<NewMeetingRespone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllTeamsResponse, ApiConnectionActionConfiguration> GetAllTeams()
        {
            return new DeferredBodyAction<GetAllTeamsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/me/joinedTeams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllTeamsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllAssociatedTeamsResponse, ApiConnectionActionConfiguration> GetAllAssociatedTeams()
        {
            return new DeferredBodyAction<GetAllAssociatedTeamsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me/teamwork/associatedTeams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllAssociatedTeamsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelsForGroupResponse, ApiConnectionActionConfiguration> GetChannelsForGroup(Expression<Func<string>> groupId, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetChannelsForGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/groups/{0}/channels", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                return new ApiConnectionAction<GetChannelsForGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateChannelResponse, ApiConnectionActionConfiguration> CreateChannel(Expression<Func<string>> groupId, Expression<Func<CreateChannelInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateChannelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/groups/{0}/channels", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelResponse, ApiConnectionActionConfiguration> GetChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetChannelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/{0}/channels/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateChannelProperties(Expression<Func<string>> groupId, Expression<Func<string>> channelId, Expression<Func<UpdateChannelPropertiesInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/{0}/channels/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AsyncOperationResponse, ApiConnectionActionConfiguration> ArchiveChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId, Expression<Func<ArchiveChannelInput>> body = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AsyncOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/channels/{1}/archive", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AsyncOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse, ApiConnectionActionConfiguration> GetAllChannelsForTeam(Expression<Func<string>> groupId, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetAllChannelsForTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/{0}/allChannels", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                return new ApiConnectionAction<GetAllChannelsForTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChatsResponse, ApiConnectionActionConfiguration> GetChats(Expression<Func<chatTypeInput>> chatType, Expression<Func<topicInput>> topic)
        {
            var __workflow_chatType = WorkflowExpression.Compile(chatType, nameof(chatType), required: true);
            var __workflow_topic = WorkflowExpression.Compile(topic, nameof(topic), required: true);
            return new DeferredBodyAction<GetChatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flowbot/actions/listchats/chattypes/{0}/topic/{1}/expandmembers/false", __workflow_chatType.WithUrlEncoding(1), __workflow_topic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostFeedNotification(Expression<Func<posterInput>> poster, Expression<Func<notificationTypeInput>> notificationType, Expression<Func<object>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_notificationType = WorkflowExpression.Compile(notificationType, nameof(notificationType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flowbot/feednotification/poster/{0}/notificationType/{1}", __workflow_poster.WithUrlEncoding(1), __workflow_notificationType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionTagResponse, ApiConnectionActionConfiguration> AtMentionTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<AtMentionTagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/{0}/tags/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AtMentionTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromConversationResponse, ApiConnectionActionConfiguration> GetMessagesFromChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetMessagesFromConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/{0}/channels/{1}/messages", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessagesFromConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetMessageDetails(Expression<Func<string>> messageId, Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> body)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_threadType = WorkflowExpression.Compile(threadType, nameof(threadType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/messages/{0}/messageType/{1}", __workflow_messageId.WithUrlEncoding(1), __workflow_threadType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListRepliesResponseSchema, ApiConnectionActionConfiguration> ListRepliesToMessage(Expression<Func<string>> groupId, Expression<Func<string>> channelId, Expression<Func<string>> messageId, Expression<Func<int>> top = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListRepliesResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/channels/{1}/messages/{2}/replies", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(20);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListRepliesResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListMembersResponseSchema, ApiConnectionActionConfiguration> ListMembers(Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> body, Expression<Func<string>> filter = null)
        {
            var __workflow_threadType = WorkflowExpression.Compile(threadType, nameof(threadType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ListMembersResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/listmembers/threadType/{0}", __workflow_threadType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SubscribeUserMessageWithOptions(Expression<Func<object>> userMessageWithOptionsSubscriptionRequest)
        {
            var __workflow_userMessageWithOptionsSubscriptionRequest = WorkflowExpression.Compile(userMessageWithOptionsSubscriptionRequest, nameof(userMessageWithOptionsSubscriptionRequest), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowbot/actions/messagewithoptions/recipienttypes/user/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_userMessageWithOptionsSubscriptionRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTeamResponse, ApiConnectionActionConfiguration> GetTeam(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<GetTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/{0}", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionUserV1, ApiConnectionActionConfiguration> AtMentionUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<AtMentionUserV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AtMentionUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewChatResponse, ApiConnectionActionConfiguration> CreateChat(Expression<Func<CreateChatInput>> item)
        {
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<NewChatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/chats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<NewChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromConversationResponse, ApiConnectionActionConfiguration> GetMessagesFromChat(Expression<Func<string>> chatId, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> top = null)
        {
            var __workflow_chatId = WorkflowExpression.Compile(chatId, nameof(chatId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetMessagesFromConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/chats/{0}/messages", __workflow_chatId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetMessagesFromConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ChatMessage, ApiConnectionActionConfiguration> PostMessageToSelf(Expression<Func<PostMessageToSelfInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ChatMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/chats/48:notes/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChatMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateATeamResponse, ApiConnectionActionConfiguration> CreateATeam(Expression<Func<CreateATeamInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateATeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/teams";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateATeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListMembersResponseSchema, ApiConnectionActionConfiguration> ListTeamMembers(Expression<Func<string>> teamId, Expression<Func<string>> filter = null, Expression<Func<string>> top = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListMembersResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/members", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddMemberToTeam(Expression<Func<string>> teamId, Expression<Func<AddMemberToTeamInput>> body)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/members", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveMemberFromTeam(Expression<Func<string>> teamId, Expression<Func<string>> membershipId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_membershipId = WorkflowExpression.Compile(membershipId, nameof(membershipId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/members/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_membershipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddMemberToChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId, Expression<Func<AddMemberToChannelInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/channels/{1}/members", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveMemberFromChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId, Expression<Func<string>> membershipId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_membershipId = WorkflowExpression.Compile(membershipId, nameof(membershipId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/channels/{1}/members/{2}", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1), __workflow_membershipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse, ApiConnectionActionConfiguration> PostMessageToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostToConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/teams/conversation/message/poster/{0}/location/{1}", __workflow_poster.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse, ApiConnectionActionConfiguration> ReplyWithMessageToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostToConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/conversation/replyWithMessage/poster/{0}/location/{1}", __workflow_poster.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse, ApiConnectionActionConfiguration> PostCardToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostToConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/conversation/adaptivecard/poster/{0}/location/{1}", __workflow_poster.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PostCardAndWaitForResponse(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<PostCardAndWaitForResponseInput>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/conversation/gatherinput/poster/{0}/location/{1}/$subscriptions", __workflow_poster.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse, ApiConnectionActionConfiguration> ReplyWithCardToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostToConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/conversation/replyWithAdaptivecard/poster/{0}/location/{1}", __workflow_poster.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse, ApiConnectionActionConfiguration> UpdateCardInConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body)
        {
            var __workflow_poster = WorkflowExpression.Compile(poster, nameof(poster), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostToConversationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/conversation/updateAdaptivecard/poster/{0}/location/{1}", __workflow_poster.WithUrlEncoding(1), __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = WorkflowExpression.Compile(customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = WorkflowExpression.Compile(customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = WorkflowExpression.Compile(customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = WorkflowExpression.Compile(customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = WorkflowExpression.Compile(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(__workflow_uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(__workflow_customHeader1);
                if (__workflow_customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(__workflow_customHeader2);
                if (__workflow_customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(__workflow_customHeader3);
                if (__workflow_customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(__workflow_customHeader4);
                if (__workflow_customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(__workflow_customHeader5);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddMemberToChat(Expression<Func<string>> chatId, Expression<Func<AddMemberToChatInput>> body)
        {
            var __workflow_chatId = WorkflowExpression.Compile(chatId, nameof(chatId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/chats/{0}/members", __workflow_chatId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveMemberFromChat(Expression<Func<string>> chatId, Expression<Func<string>> membershipId)
        {
            var __workflow_chatId = WorkflowExpression.Compile(chatId, nameof(chatId), required: true);
            var __workflow_membershipId = WorkflowExpression.Compile(membershipId, nameof(membershipId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/chats/{0}/members/{1}", __workflow_chatId.WithUrlEncoding(1), __workflow_membershipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetOnlineMeetingResponse, ApiConnectionActionConfiguration> GetOnlineMeeting(Expression<Func<lookupTypeInput>> lookupType, Expression<Func<string>> lookupValue)
        {
            var __workflow_lookupType = WorkflowExpression.Compile(lookupType, nameof(lookupType), required: true);
            var __workflow_lookupValue = WorkflowExpression.Compile(lookupValue, nameof(lookupValue), required: true);
            return new DeferredBodyAction<GetOnlineMeetingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me/onlineMeetings/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookupType"] = ExpressionConverter.Convert(__workflow_lookupType);
                callPayload.Queries["lookupValue"] = ExpressionConverter.Convert(__workflow_lookupValue);
                return new ApiConnectionAction<GetOnlineMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptCollectionResponse, ApiConnectionActionConfiguration> ListMeetingTranscripts(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredBodyAction<CallTranscriptCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/onlineMeetings/{0}/transcripts", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallTranscriptCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptResponse, ApiConnectionActionConfiguration> GetMeetingTranscript(Expression<Func<string>> meetingId, Expression<Func<string>> transcriptId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_transcriptId = WorkflowExpression.Compile(transcriptId, nameof(transcriptId), required: true);
            return new DeferredBodyAction<CallTranscriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/onlineMeetings/{0}/transcripts/{1}", __workflow_meetingId.WithUrlEncoding(1), __workflow_transcriptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallTranscriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetMeetingTranscriptContent(Expression<Func<string>> meetingId, Expression<Func<string>> transcriptId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_transcriptId = WorkflowExpression.Compile(transcriptId, nameof(transcriptId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/onlineMeetings/{0}/transcripts/{1}/content", __workflow_meetingId.WithUrlEncoding(1), __workflow_transcriptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingCollectionResponse, ApiConnectionActionConfiguration> ListMeetingRecordings(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredBodyAction<CallRecordingCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/onlineMeetings/{0}/recordings", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallRecordingCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingResponse, ApiConnectionActionConfiguration> GetMeetingRecording(Expression<Func<string>> meetingId, Expression<Func<string>> recordingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_recordingId = WorkflowExpression.Compile(recordingId, nameof(recordingId), required: true);
            return new DeferredBodyAction<CallRecordingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/onlineMeetings/{0}/recordings/{1}", __workflow_meetingId.WithUrlEncoding(1), __workflow_recordingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallRecordingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> GetMeetingRecordingContent(Expression<Func<string>> meetingId, Expression<Func<string>> recordingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_recordingId = WorkflowExpression.Compile(recordingId, nameof(recordingId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/onlineMeetings/{0}/recordings/{1}/content", __workflow_meetingId.WithUrlEncoding(1), __workflow_recordingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListSectionsResponse, ApiConnectionActionConfiguration> ListSections()
        {
            return new DeferredBodyAction<ListSectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/me/teamwork/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListSectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionResponse, ApiConnectionActionConfiguration> CreateSection(Expression<Func<string>> ifMatch, Expression<Func<CreateSectionInput>> body)
        {
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/me/teamwork/sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionResponse, ApiConnectionActionConfiguration> GetSection(Expression<Func<string>> sectionId)
        {
            var __workflow_sectionId = WorkflowExpression.Compile(sectionId, nameof(sectionId), required: true);
            return new DeferredBodyAction<SectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/me/teamwork/sections/{0}", __workflow_sectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionResponse, ApiConnectionActionConfiguration> UpdateSection(Expression<Func<string>> sectionId, Expression<Func<string>> ifMatch, Expression<Func<UpdateSectionInput>> body)
        {
            var __workflow_sectionId = WorkflowExpression.Compile(sectionId, nameof(sectionId), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/me/teamwork/sections/{0}", __workflow_sectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSection(Expression<Func<string>> sectionId, Expression<Func<string>> ifMatch)
        {
            var __workflow_sectionId = WorkflowExpression.Compile(sectionId, nameof(sectionId), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/me/teamwork/sections/{0}", __workflow_sectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListSectionItemsResponse, ApiConnectionActionConfiguration> ListSectionItems(Expression<Func<string>> sectionId)
        {
            var __workflow_sectionId = WorkflowExpression.Compile(sectionId, nameof(sectionId), required: true);
            return new DeferredBodyAction<ListSectionItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/me/teamwork/sections/{0}/items", __workflow_sectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListSectionItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveSectionItem(Expression<Func<string>> sectionId, Expression<Func<string>> sectionItemId, Expression<Func<string>> ifMatch)
        {
            var __workflow_sectionId = WorkflowExpression.Compile(sectionId, nameof(sectionId), required: true);
            var __workflow_sectionItemId = WorkflowExpression.Compile(sectionItemId, nameof(sectionItemId), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/me/teamwork/sections/{0}/items/{1}", __workflow_sectionId.WithUrlEncoding(1), __workflow_sectionItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionItemResponse, ApiConnectionActionConfiguration> MoveSectionItem(Expression<Func<string>> sectionId, Expression<Func<string>> sectionItemId, Expression<Func<string>> ifMatch, Expression<Func<MoveSectionItemInput>> body)
        {
            var __workflow_sectionId = WorkflowExpression.Compile(sectionId, nameof(sectionId), required: true);
            var __workflow_sectionItemId = WorkflowExpression.Compile(sectionItemId, nameof(sectionItemId), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SectionItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/me/teamwork/sections/{0}/items/{1}/move", __workflow_sectionId.WithUrlEncoding(1), __workflow_sectionItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SectionItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagsResponseSchema, ApiConnectionActionConfiguration> GetTags(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetTagsResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagsResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema, ApiConnectionActionConfiguration> CreateTag(Expression<Func<string>> groupId, Expression<Func<CreateTagInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTagResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTagResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema, ApiConnectionActionConfiguration> GetTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<CreateTagResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateTagResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema, ApiConnectionActionConfiguration> UpdateTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId, Expression<Func<UpdateTagInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTagResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTagResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AddMemberToTagResponseSchema, ApiConnectionActionConfiguration> AddMemberToTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId, Expression<Func<AddMemberToTagInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddMemberToTagResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags/{1}/members", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddMemberToTagResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagMembersResponseSchema, ApiConnectionActionConfiguration> GetTagMembers(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<GetTagMembersResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags/{1}/members", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTagMember(Expression<Func<string>> groupId, Expression<Func<string>> tagId, Expression<Func<string>> tagMemberId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_tagMemberId = WorkflowExpression.Compile(tagMemberId, nameof(tagMemberId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/tags/{1}/members/{2}", __workflow_groupId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1), __workflow_tagMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingCollectionResponse, ApiConnectionActionConfiguration> ListCallRecordings(Expression<Func<string>> callId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            return new DeferredBodyAction<CallRecordingCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/adhocCalls/{0}/recordings", __workflow_callId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallRecordingCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingResponse, ApiConnectionActionConfiguration> GetCallRecording(Expression<Func<string>> callId, Expression<Func<string>> recordingId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            var __workflow_recordingId = WorkflowExpression.Compile(recordingId, nameof(recordingId), required: true);
            return new DeferredBodyAction<CallRecordingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/adhocCalls/{0}/recordings/{1}", __workflow_callId.WithUrlEncoding(1), __workflow_recordingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallRecordingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> GetCallRecordingContent(Expression<Func<string>> callId, Expression<Func<string>> recordingId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            var __workflow_recordingId = WorkflowExpression.Compile(recordingId, nameof(recordingId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/adhocCalls/{0}/recordings/{1}/content", __workflow_callId.WithUrlEncoding(1), __workflow_recordingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptCollectionResponse, ApiConnectionActionConfiguration> ListCallTranscripts(Expression<Func<string>> callId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            return new DeferredBodyAction<CallTranscriptCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/adhocCalls/{0}/transcripts", __workflow_callId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallTranscriptCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptResponse, ApiConnectionActionConfiguration> GetCallTranscript(Expression<Func<string>> callId, Expression<Func<string>> transcriptId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            var __workflow_transcriptId = WorkflowExpression.Compile(transcriptId, nameof(transcriptId), required: true);
            return new DeferredBodyAction<CallTranscriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/adhocCalls/{0}/transcripts/{1}", __workflow_callId.WithUrlEncoding(1), __workflow_transcriptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CallTranscriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetCallTranscriptContent(Expression<Func<string>> callId, Expression<Func<string>> transcriptId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            var __workflow_transcriptId = WorkflowExpression.Compile(transcriptId, nameof(transcriptId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/me/adhocCalls/{0}/transcripts/{1}/content", __workflow_callId.WithUrlEncoding(1), __workflow_transcriptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingCollectionResponse, ApiConnectionActionConfiguration> GetAllAdhocCallRecordings(Expression<Func<string>> startDateTime = null, Expression<Func<string>> endDateTime = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> deltatoken = null)
        {
            var __workflow_startDateTime = WorkflowExpression.Compile(startDateTime, nameof(startDateTime), required: false);
            var __workflow_endDateTime = WorkflowExpression.Compile(endDateTime, nameof(endDateTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_deltatoken = WorkflowExpression.Compile(deltatoken, nameof(deltatoken), required: false);
            return new DeferredBodyAction<CallRecordingCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me/adhocCalls/getAllRecordings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDateTime != null)
                    callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(__workflow_startDateTime);
                if (__workflow_endDateTime != null)
                    callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(__workflow_endDateTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_deltatoken != null)
                    callPayload.Queries["$deltatoken"] = ExpressionConverter.Convert(__workflow_deltatoken);
                return new ApiConnectionAction<CallRecordingCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptCollectionResponse, ApiConnectionActionConfiguration> GetAllAdhocCallTranscripts(Expression<Func<string>> startDateTime = null, Expression<Func<string>> endDateTime = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> deltatoken = null)
        {
            var __workflow_startDateTime = WorkflowExpression.Compile(startDateTime, nameof(startDateTime), required: false);
            var __workflow_endDateTime = WorkflowExpression.Compile(endDateTime, nameof(endDateTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_deltatoken = WorkflowExpression.Compile(deltatoken, nameof(deltatoken), required: false);
            return new DeferredBodyAction<CallTranscriptCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me/adhocCalls/getAllTranscripts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startDateTime != null)
                    callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(__workflow_startDateTime);
                if (__workflow_endDateTime != null)
                    callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(__workflow_endDateTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_deltatoken != null)
                    callPayload.Queries["$deltatoken"] = ExpressionConverter.Convert(__workflow_deltatoken);
                return new ApiConnectionAction<CallTranscriptCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AiInsightCollectionResponse, ApiConnectionActionConfiguration> ListAiInsights(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredBodyAction<AiInsightCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/copilot/me/onlineMeetings/{0}/aiInsights", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AiInsightCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AiInsightDetailResponse, ApiConnectionActionConfiguration> GetAiInsight(Expression<Func<string>> meetingId, Expression<Func<string>> aiInsightId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_aiInsightId = WorkflowExpression.Compile(aiInsightId, nameof(aiInsightId), required: true);
            return new DeferredBodyAction<AiInsightDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/copilot/me/onlineMeetings/{0}/aiInsights/{1}", __workflow_meetingId.WithUrlEncoding(1), __workflow_aiInsightId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AiInsightDetailResponse>(callPayload);
            });
        }
    }

    public class TeamsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ChatMessage[], ApiConnectionTriggerConfiguration> OnNewChannelMessage(Expression<Func<string>> groupId, Expression<Func<string>> channelId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<ChatMessage[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return new ApiConnectionTrigger<ChatMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ChatMessage[], ApiConnectionTriggerConfiguration> OnNewChannelMessageMentioningMe(Expression<Func<string>> groupId, Expression<Func<string>> channelId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<ChatMessage[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages_mentioningme", __workflow_groupId.WithUrlEncoding(1), __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return new ApiConnectionTrigger<ChatMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookAtMentionTrigger(Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_threadType = WorkflowExpression.Compile(threadType, nameof(threadType), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/subscriptions/atmentiontrigger/threadType/{0}", __workflow_threadType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookMessageReactionTrigger(Expression<Func<string>> reactionKey, Expression<Func<frequencyInput>> frequency, Expression<Func<runningPolicyInput>> runningPolicy, Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_reactionKey = WorkflowExpression.Compile(reactionKey, nameof(reactionKey), required: true);
            var __workflow_frequency = WorkflowExpression.Compile(frequency, nameof(frequency), required: true);
            var __workflow_runningPolicy = WorkflowExpression.Compile(runningPolicy, nameof(runningPolicy), required: true);
            var __workflow_threadType = WorkflowExpression.Compile(threadType, nameof(threadType), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/subscriptions/messagereactiontrigger/threadType/{0}", __workflow_threadType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reactionKey"] = ExpressionConverter.Convert(__workflow_reactionKey);
                callPayload.Queries["frequency"] = ExpressionConverter.Convert(__workflow_frequency);
                callPayload.Queries["runningPolicy"] = ExpressionConverter.Convert(__workflow_runningPolicy);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TranscriptTrigger(Expression<Func<scopeTypeInput>> scopeType, Expression<Func<TranscriptTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_scopeType = WorkflowExpression.Compile(scopeType, nameof(scopeType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/subscriptions/transcripttrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["scopeType"] = ExpressionConverter.Convert(__workflow_scopeType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> RecordingTrigger(Expression<Func<scopeTypeInput>> scopeType, Expression<Func<RecordingTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_scopeType = WorkflowExpression.Compile(scopeType, nameof(scopeType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/subscriptions/recordingtrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["scopeType"] = ExpressionConverter.Convert(__workflow_scopeType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookChatMessageTrigger(Expression<Func<WebhookChatMessageTriggerInput>> chatMessageSubscriptionRequest, FlowRecurrence recurrence = null)
        {
            var __workflow_chatMessageSubscriptionRequest = WorkflowExpression.Compile(chatMessageSubscriptionRequest, nameof(chatMessageSubscriptionRequest), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/beta/subscriptions/chatmessagetrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_chatMessageSubscriptionRequest);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookKeywordTrigger(Expression<Func<threadTypeInput>> threadType, Expression<Func<string>> search, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_threadType = WorkflowExpression.Compile(threadType, nameof(threadType), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/subscriptions/keywordtrigger/threadType/{0}", __workflow_threadType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookNewMessageTrigger(Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_threadType = WorkflowExpression.Compile(threadType, nameof(threadType), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/subscriptions/newmessagetrigger/threadType/{0}", __workflow_threadType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[], ApiConnectionTriggerConfiguration> OnTeamMemberRemoved(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberChangeResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/removal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[], ApiConnectionTriggerConfiguration> OnTeamMemberAdded(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberChangeResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/delta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class NewMeetingRespone
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTimestamp { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTimestamp { get; set; }

        [JsonProperty("categories")]
        public JToken[] Categories { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int PreEventReminderTime { get; set; }

        [JsonProperty("isReminderOn")]
        public bool RemindersEnabled { get; set; }

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
        public string WebLast { get; set; }

        [JsonProperty("onlineMeetingUrl")]
        public string OnlineMeetingURL { get; set; }

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
        public NewMeetingResponeAttendeeTypeItem[] Attendee { get; set; }

        [JsonProperty("organizer")]
        public NewMeetingResponeOrganizerType Organizer { get; set; }

        [JsonProperty("onlineMeeting")]
        public NewMeetingResponeOnlineMeetingType OnlineMeeting { get; set; }
    }

    public class NewMeetingResponeRecurrenceType
    {
        [JsonProperty("pattern")]
        public JToken RecurrencePattern { get; set; }

        [JsonProperty("range")]
        public JToken RecurrenceRange { get; set; }
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
        public string EventMessageContent { get; set; }
    }

    public class NewMeetingResponeStartType
    {
        [JsonProperty("dateTime")]
        public string DateAndTime { get; set; }
    }

    public class NewMeetingResponeEndType
    {
        [JsonProperty("dateTime")]
        public string DateAndTime { get; set; }
    }

    public class NewMeetingResponeLocationType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NewMeetingResponeAttendeeTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public NewMeetingResponeAttendeeTypeItemStatusType Status { get; set; }

        [JsonProperty("emailAddress")]
        public NewMeetingResponeAttendeeTypeItemEmailAddressType EmailAddress { get; set; }
    }

    public class NewMeetingResponeAttendeeTypeItemStatusType
    {
        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class NewMeetingResponeAttendeeTypeItemEmailAddressType
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

    public class NewMeetingResponeOrganizerTypeEmailAddressType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class NewMeetingResponeOnlineMeetingType
    {
        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum calendaridInput
    {
        Birthdays,
        Calendar,
        [EnumMember(Value = "United States holidays")]
        UnitedStatesHolidays
    }

    public class CreateTeamsMeetingInput
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTeamsMeetingInputBodyType Body { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeZone { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTeamsMeetingInputStartType Start { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTeamsMeetingInputEndType End { get; set; }

        [JsonProperty("requiredAttendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("optionalAttendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("location")]
        public CreateTeamsMeetingInputLocationType Location { get; set; }

        [JsonProperty("importance")]
        public CreateTeamsMeetingInputImportanceType? Importance { get; set; }

        [JsonProperty("recurrence")]
        public CreateTeamsMeetingInputRecurrenceType Recurrence { get; set; }

        [JsonProperty("isAllDay")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int? PreEventReminderTime { get; set; }

        [JsonProperty("isReminderOn")]
        public bool? EnableReminders { get; set; }

        [JsonProperty("showAs")]
        public CreateTeamsMeetingInputStatusShowAsType? StatusShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool? RequestResponse { get; set; }

        [JsonProperty("isOnlineMeeting", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool OnlineMeetingEnabled { get; set; } = true;

        [JsonProperty("onlineMeetingProvider", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string OnlineMeetingProvider { get; set; } = "teamsForBusiness";
    }

    public class CreateTeamsMeetingInputBodyType
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventMessageContent { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "html";
    }

    public class CreateTeamsMeetingInputStartType
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }
    }

    public class CreateTeamsMeetingInputEndType
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }
    }

    public class CreateTeamsMeetingInputLocationType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTeamsMeetingInputImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public class CreateTeamsMeetingInputRecurrenceType
    {
        [JsonProperty("pattern")]
        public CreateTeamsMeetingInputRecurrenceTypePatternType Pattern { get; set; }

        [JsonProperty("range")]
        public CreateTeamsMeetingInputRecurrenceTypeRangeType Range { get; set; }
    }

    public class CreateTeamsMeetingInputRecurrenceTypePatternType
    {
        [JsonProperty("type")]
        public CreateTeamsMeetingInputRecurrenceTypePatternTypeRecurrencePatternType? RecurrencePattern { get; set; }

        [JsonProperty("interval")]
        public int? RecurrenceInterval { get; set; }

        [JsonProperty("daysOfWeek")]
        public string[] DaysOfWeek { get; set; }

        [JsonProperty("index")]
        public CreateTeamsMeetingInputRecurrenceTypePatternTypeWeekIndexType? WeekIndex { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTeamsMeetingInputRecurrenceTypePatternTypeRecurrencePatternType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTeamsMeetingInputRecurrenceTypePatternTypeWeekIndexType
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

    public class CreateTeamsMeetingInputRecurrenceTypeRangeType
    {
        [JsonProperty("startDate")]
        public string RecurrenceStartDate { get; set; }

        [JsonProperty("endDate")]
        public string RecurrenceEndDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTeamsMeetingInputStatusShowAsType
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

    public class GetAllTeamsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetAllTeamsResponseTeamsListTypeItem[] TeamsList { get; set; }
    }

    public class GetAllTeamsResponseTeamsListTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllAssociatedTeamsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public AssociatedTeamInfo[] TeamsList { get; set; }
    }

    public class AssociatedTeamInfo
    {
        [JsonProperty("id")]
        public string TeamId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class GetChannelsForGroupResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetChannelResponse[] ChannelList { get; set; }
    }

    public class GetChannelResponse
    {
        [JsonProperty("id")]
        public string ChannelId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfChannel { get; set; }

        [JsonProperty("email")]
        public string TheEmailAddressForTheChannel { get; set; }

        [JsonProperty("tenantId")]
        public string TeamTenantId { get; set; }

        [JsonProperty("webUrl")]
        public string AHyperlinkForTheChannelInMicrosoftTeams { get; set; }

        [JsonProperty("filesFolderWebUrl")]
        public string SharePointFolderURLForChannel { get; set; }

        [JsonProperty("createdDateTime")]
        public string ChannelCreationTime { get; set; }

        [JsonProperty("membershipType")]
        public GetChannelResponseTheTypeOfTheChannelType TheTypeOfTheChannel { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetChannelResponseTheTypeOfTheChannelType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "shared")]
        Shared
    }

    public class CreateChannelResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }
    }

    public class CreateChannelInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("membershipType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateChannelInputMembershipTypeType? MembershipType { get; set; } = CreateChannelInputMembershipTypeType.Standard;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateChannelInputMembershipTypeType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "shared")]
        Shared
    }

    public class UpdateChannelPropertiesInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class AsyncOperationResponse
    {
        [JsonProperty("status")]
        public AsyncOperationResponseStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AsyncOperationResponseStatusType
    {
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed
    }

    public class ArchiveChannelInput
    {
        [JsonProperty("shouldSetSpoSiteReadOnlyForMembers")]
        public bool? SetSharePointSiteToReadOnlyForMembers { get; set; }
    }

    public class GetAllChannelsForTeamResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public JToken[] ChannelList { get; set; }
    }

    public class GetChatsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetChatsResponseChatsListTypeItem[] ChatsList { get; set; }
    }

    public class GetChatsResponseChatsListTypeItem
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastUpdatedDateTime")]
        public string LastUpdatedDateTime { get; set; }

        [JsonProperty("id")]
        public string ConversationId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum chatTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum topicInput
    {
        [EnumMember(Value = "all")]
        AllChats,
        [EnumMember(Value = "isDefined")]
        IsDefined,
        [EnumMember(Value = "notDefined")]
        IsNotDefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum posterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum notificationTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "team")]
        Team
    }

    public class AtMentionTagResponse
    {
        [JsonProperty("atMention")]
        public string MentionTag { get; set; }
    }

    public class GetMessagesFromConversationResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public ChatMessage[] Value { get; set; }
    }

    public class ChatMessage
    {
        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("body")]
        public ChatMessageBodyType Body { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("from")]
        public ChatMessageFromType From { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTimestamp { get; set; }

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

    public class ChatMessageBodyType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    public class ChatMessageFromType
    {
        [JsonProperty("application")]
        public JToken Application { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("user")]
        public ChatMessageFromTypeUserType User { get; set; }
    }

    public class ChatMessageFromTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identityProvider")]
        public string IdentityProvider { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum threadTypeInput
    {
        [EnumMember(Value = "groupchat")]
        GroupChat,
        [EnumMember(Value = "channel")]
        Channel
    }

    public class ListRepliesResponseSchema
    {
        [JsonProperty("value")]
        public ListRepliesResponseSchemaListOfMessageRepliesTypeItem[] ListOfMessageReplies { get; set; }
    }

    public class ListRepliesResponseSchemaListOfMessageRepliesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("replyToId")]
        public string ReplyToId { get; set; }

        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("lastEditedDateTime")]
        public string LastEditedDateTime { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("chatId")]
        public string ChatId { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("webUrl")]
        public string WebURL { get; set; }

        [JsonProperty("policyViolation")]
        public JToken PolicyViolation { get; set; }

        [JsonProperty("eventDetail")]
        public JToken EventDetail { get; set; }

        [JsonProperty("from")]
        public ListRepliesResponseSchemaListOfMessageRepliesTypeItemFromType From { get; set; }

        [JsonProperty("body")]
        public ListRepliesResponseSchemaListOfMessageRepliesTypeItemBodyType Body { get; set; }

        [JsonProperty("channelIdentity")]
        public ListRepliesResponseSchemaListOfMessageRepliesTypeItemChannelIdentityType ChannelIdentity { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("mentions")]
        public JToken[] Mentions { get; set; }

        [JsonProperty("reactions")]
        public JToken[] Reactions { get; set; }

        [JsonProperty("messageHistory")]
        public JToken[] MessageHistory { get; set; }
    }

    public class ListRepliesResponseSchemaListOfMessageRepliesTypeItemFromType
    {
        [JsonProperty("application")]
        public JToken Application { get; set; }

        [JsonProperty("device")]
        public JToken Device { get; set; }

        [JsonProperty("user")]
        public ListRepliesResponseSchemaListOfMessageRepliesTypeItemFromTypeUserType User { get; set; }
    }

    public class ListRepliesResponseSchemaListOfMessageRepliesTypeItemFromTypeUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userIdentityType")]
        public string UserIdentityType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class ListRepliesResponseSchemaListOfMessageRepliesTypeItemBodyType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ListRepliesResponseSchemaListOfMessageRepliesTypeItemChannelIdentityType
    {
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }
    }

    public class ListMembersResponseSchema
    {
        [JsonProperty("value")]
        public ListMembersResponseSchemaListOfMembersTypeItem[] ListOfMembers { get; set; }
    }

    public class ListMembersResponseSchemaListOfMembersTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("id")]
        public string MembershipId { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("visibleHistoryStartDateTime")]
        public string StartTimeOfConversationSVisibleHistory { get; set; }
    }

    public class GetTeamResponse
    {
        [JsonProperty("id")]
        public string TeamId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfTeam { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("webUrl")]
        public string TeamSWebUrl { get; set; }

        [JsonProperty("isArchived")]
        public bool Archived { get; set; }

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

    public class MemberSettings
    {
        [JsonProperty("allowCreateUpdateChannels")]
        public bool MembersAreAllowedCreateUpdateChannels { get; set; }

        [JsonProperty("allowDeleteChannels")]
        public bool MembersAreAllowedDeleteChannels { get; set; }

        [JsonProperty("allowAddRemoveApps")]
        public bool MembersAreAllowedAddRemoveApps { get; set; }

        [JsonProperty("allowCreateUpdateRemoveTabs")]
        public bool MembersAreAllowedCreateUpdateRemoveTabs { get; set; }

        [JsonProperty("allowCreateUpdateRemoveConnectors")]
        public bool MembersAreAllowedCreateUpdateRemoveConnectors { get; set; }
    }

    public class GuestSettings
    {
        [JsonProperty("allowCreateUpdateChannels")]
        public bool GuestsAreAllowedCreateUpdateChannels { get; set; }

        [JsonProperty("allowDeleteChannels")]
        public bool GuestsAreAllowedDeleteChannels { get; set; }
    }

    public class MessagingSettings
    {
        [JsonProperty("allowUserEditMessages")]
        public bool AllowUserToEditMessages { get; set; }

        [JsonProperty("allowUserDeleteMessages")]
        public bool AllowUserToDeleteMessages { get; set; }

        [JsonProperty("allowOwnerDeleteMessages")]
        public bool AllowOwnerToDeleteMessages { get; set; }

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
        public bool ShowInTeamSSearchAndSuggestions { get; set; }
    }

    public class AtMentionUserV1
    {
        [JsonProperty("atMention")]
        public string Mention { get; set; }
    }

    public class NewChatResponse
    {
        [JsonProperty("id")]
        public string ConversationId { get; set; }
    }

    public class CreateChatInput
    {
        [JsonProperty("topic")]
        public string Title { get; set; }

        [JsonProperty("members", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MembersToAdd { get; set; }
    }

    public class PostMessageToSelfInput
    {
        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostMessageToSelfInputBodyType Body { get; set; }
    }

    public class PostMessageToSelfInputBodyType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostMessageToSelfInputBodyTypeContentTypeType? ContentType { get; set; } = PostMessageToSelfInputBodyTypeContentTypeType.Text;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostMessageToSelfInputBodyTypeContentTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html
    }

    public class CreateATeamResponse
    {
        [JsonProperty("newTeamId")]
        public string NewTeamId { get; set; }
    }

    public class CreateATeamInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TeamName { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("visibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateATeamInputVisibilityType? Visibility { get; set; } = CreateATeamInputVisibilityType.Public;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateATeamInputVisibilityType
    {
        Private,
        Public
    }

    public class AddMemberToTeamInput
    {
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("owner")]
        public bool? SetUserAsTeamOwner { get; set; }
    }

    public class AddMemberToChannelInput
    {
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("owner")]
        public bool? SetUserAsChannelOwner { get; set; }
    }

    public class PostToConversationResponse
    {
        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("messageLink")]
        public string MessageLink { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }
    }

    public class PostCardAndWaitForResponseInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostCardAndWaitForResponseInputBodyType Body { get; set; }
    }

    public class PostCardAndWaitForResponseInputBodyType
    {
        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Recipient { get; set; }

        [JsonProperty("messageBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("updateMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdateMessage { get; set; } = "Thanks for your response!";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class AddMemberToChatInput
    {
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("owner")]
        public bool? SetUserAsChatOwner { get; set; }

        [JsonProperty("visibleHistoryStartDateTime")]
        public string VisibleHistoryStartDateTime { get; set; }
    }

    public class GetOnlineMeetingResponse
    {
        [JsonProperty("id")]
        public string MeetingId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("creationDateTime")]
        public string CreationTime { get; set; }

        [JsonProperty("joinWebUrl")]
        public string JoinWebURL { get; set; }

        [JsonProperty("joinMeetingIdSettings")]
        public GetOnlineMeetingResponseJoinMeetingIdSettingsType JoinMeetingIdSettings { get; set; }

        [JsonProperty("participants")]
        public GetOnlineMeetingResponseParticipantsType Participants { get; set; }

        [JsonProperty("audioConferencing")]
        public GetOnlineMeetingResponseAudioConferencingType AudioConferencing { get; set; }

        [JsonProperty("isEntryExitAnnounced")]
        public bool AnnounceOnEntryExit { get; set; }

        [JsonProperty("allowedPresenters")]
        public string AllowedPresenters { get; set; }

        [JsonProperty("lobbyBypassSettings")]
        public GetOnlineMeetingResponseLobbyBypassSettingsType LobbyBypassSettings { get; set; }

        [JsonProperty("recordAutomatically")]
        public bool RecordAutomatically { get; set; }

        [JsonProperty("allowMeetingChat")]
        public string AllowMeetingChat { get; set; }

        [JsonProperty("meetingOptionsWebUrl")]
        public string MeetingOptionsWebURL { get; set; }
    }

    public class GetOnlineMeetingResponseJoinMeetingIdSettingsType
    {
        [JsonProperty("joinMeetingId")]
        public string JoinMeetingId { get; set; }

        [JsonProperty("isPasscodeRequired")]
        public bool IsPasscodeRequired { get; set; }

        [JsonProperty("passcode")]
        public string Passcode { get; set; }
    }

    public class GetOnlineMeetingResponseParticipantsType
    {
        [JsonProperty("organizer")]
        public GetOnlineMeetingResponseParticipantsTypeOrganizerType Organizer { get; set; }
    }

    public class GetOnlineMeetingResponseParticipantsTypeOrganizerType
    {
        [JsonProperty("upn")]
        public string UPN { get; set; }

        [JsonProperty("identity")]
        public GetOnlineMeetingResponseParticipantsTypeOrganizerTypeIdentityType Identity { get; set; }
    }

    public class GetOnlineMeetingResponseParticipantsTypeOrganizerTypeIdentityType
    {
        [JsonProperty("user")]
        public GetOnlineMeetingResponseParticipantsTypeOrganizerTypeIdentityTypeUserType User { get; set; }
    }

    public class GetOnlineMeetingResponseParticipantsTypeOrganizerTypeIdentityTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class GetOnlineMeetingResponseAudioConferencingType
    {
        [JsonProperty("conferenceId")]
        public string ConferenceId { get; set; }

        [JsonProperty("tollNumber")]
        public string TollNumber { get; set; }

        [JsonProperty("tollFreeNumber")]
        public string TollFreeNumber { get; set; }

        [JsonProperty("dialinUrl")]
        public string DialInURL { get; set; }
    }

    public class GetOnlineMeetingResponseLobbyBypassSettingsType
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("isDialInBypassEnabled")]
        public bool DialInBypass { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum lookupTypeInput
    {
        [EnumMember(Value = "meetingId")]
        MeetingId,
        [EnumMember(Value = "joinWebUrl")]
        JoinWebURL,
        [EnumMember(Value = "joinMeetingId")]
        JoinMeetingIdMeetingCode
    }

    public class CallTranscriptCollectionResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public CallTranscriptResponse[] Transcripts { get; set; }
    }

    public class CallTranscriptResponse
    {
        [JsonProperty("id")]
        public string TranscriptId { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("transcriptContentUrl")]
        public string TranscriptContentURL { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingId { get; set; }

        [JsonProperty("meetingOrganizerId")]
        public string MeetingOrganizerId { get; set; }

        [JsonProperty("callId")]
        public string CallId { get; set; }
    }

    public class CallRecordingCollectionResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public CallRecordingResponse[] Recordings { get; set; }
    }

    public class CallRecordingResponse
    {
        [JsonProperty("id")]
        public string RecordingId { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("recordingContentUrl")]
        public string RecordingContentURL { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingId { get; set; }

        [JsonProperty("meetingOrganizerId")]
        public string MeetingOrganizerId { get; set; }

        [JsonProperty("callId")]
        public string CallId { get; set; }
    }

    public class ListSectionsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@microsoft.graph.sectionsVersion")]
        public string SectionsVersion { get; set; }

        [JsonProperty("value")]
        public SectionResponse[] Sections { get; set; }
    }

    public class SectionResponse
    {
        [JsonProperty("@odata.etag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string SectionId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayIcon")]
        public SectionResponseDisplayIconType DisplayIcon { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("sortType")]
        public SectionResponseSortTypeType SortType { get; set; }

        [JsonProperty("sectionType")]
        public SectionResponseSectionTypeType SectionType { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }
    }

    public class SectionResponseDisplayIconType
    {
        [JsonProperty("iconType")]
        public string IconType { get; set; }

        [JsonProperty("displayName")]
        public string IconDisplayName { get; set; }

        [JsonProperty("skinTone")]
        public SectionResponseDisplayIconTypeSkinToneType SkinTone { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SectionResponseDisplayIconTypeSkinToneType
    {
        [EnumMember(Value = "light")]
        Light,
        [EnumMember(Value = "mediumLight")]
        MediumLight,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "mediumDark")]
        MediumDark,
        [EnumMember(Value = "dark")]
        Dark
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SectionResponseSortTypeType
    {
        [EnumMember(Value = "mostRecent")]
        MostRecent,
        [EnumMember(Value = "unreadThenMostRecent")]
        UnreadThenMostRecent,
        [EnumMember(Value = "nameAlphabetical")]
        NameAlphabetical,
        [EnumMember(Value = "userDefinedCustomOrder")]
        UserDefinedCustomOrder
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SectionResponseSectionTypeType
    {
        [EnumMember(Value = "userDefined")]
        UserDefined,
        [EnumMember(Value = "systemDefined")]
        SystemDefined
    }

    public class CreateSectionInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("displayIcon")]
        public CreateSectionInputDisplayIconType DisplayIcon { get; set; }

        [JsonProperty("isExpanded")]
        public bool? IsExpanded { get; set; }

        [JsonProperty("sortType")]
        public CreateSectionInputSortTypeType? SortType { get; set; }
    }

    public class CreateSectionInputDisplayIconType
    {
        [JsonProperty("iconType")]
        public string IconType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSectionInputSortTypeType
    {
        [EnumMember(Value = "mostRecent")]
        MostRecent,
        [EnumMember(Value = "unreadThenMostRecent")]
        UnreadThenMostRecent,
        [EnumMember(Value = "nameAlphabetical")]
        NameAlphabetical,
        [EnumMember(Value = "userDefinedCustomOrder")]
        UserDefinedCustomOrder
    }

    public class UpdateSectionInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayIcon")]
        public UpdateSectionInputDisplayIconType DisplayIcon { get; set; }

        [JsonProperty("isExpanded")]
        public bool? IsExpanded { get; set; }

        [JsonProperty("sortType")]
        public UpdateSectionInputSortTypeType? SortType { get; set; }
    }

    public class UpdateSectionInputDisplayIconType
    {
        [JsonProperty("iconType")]
        public string IconType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateSectionInputSortTypeType
    {
        [EnumMember(Value = "mostRecent")]
        MostRecent,
        [EnumMember(Value = "unreadThenMostRecent")]
        UnreadThenMostRecent,
        [EnumMember(Value = "nameAlphabetical")]
        NameAlphabetical,
        [EnumMember(Value = "userDefinedCustomOrder")]
        UserDefinedCustomOrder
    }

    public class ListSectionItemsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public SectionItemResponse[] SectionItems { get; set; }
    }

    public class SectionItemResponse
    {
        [JsonProperty("@odata.etag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string ItemId { get; set; }

        [JsonProperty("itemType")]
        public SectionItemResponseItemTypeType ItemType { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SectionItemResponseItemTypeType
    {
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "channel")]
        Channel,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "community")]
        Community
    }

    public class MoveSectionItemInput
    {
        [JsonProperty("targetSectionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetSectionId { get; set; }
    }

    public class GetTagsResponseSchema
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetTagsResponseSchemaValueTypeItem[] Value { get; set; }
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

    public class CreateTagInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("members", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MembersIDs { get; set; }
    }

    public class UpdateTagInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }
    }

    public class AddMemberToTagResponseSchema
    {
        [JsonProperty("userId")]
        public string Id { get; set; }
    }

    public class AddMemberToTagInput
    {
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserSId { get; set; }
    }

    public class GetTagMembersResponseSchema
    {
        [JsonProperty("value")]
        public GetTagMembersResponseSchemaValueTypeItem[] Value { get; set; }
    }

    public class GetTagMembersResponseSchemaValueTypeItem
    {
        [JsonProperty("id")]
        public string TagMemberId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("displayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class AiInsightCollectionResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public AiInsightResponse[] AIInsights { get; set; }
    }

    public class AiInsightResponse
    {
        [JsonProperty("id")]
        public string AIInsightId { get; set; }

        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("contentCorrelationId")]
        public string ContentCorrelationId { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }
    }

    public class AiInsightDetailResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string AIInsightId { get; set; }

        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("contentCorrelationId")]
        public string ContentCorrelationId { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("recapUrl")]
        public string RecapURL { get; set; }

        [JsonProperty("meetingNotes")]
        public AiInsightMeetingNote[] MeetingNotes { get; set; }

        [JsonProperty("actionItems")]
        public AiInsightActionItem[] ActionItems { get; set; }

        [JsonProperty("viewpoint")]
        public AiInsightViewpoint Viewpoint { get; set; }
    }

    public class AiInsightMeetingNote
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("subpoints")]
        public AiInsightMeetingNoteSubpoint[] Subpoints { get; set; }
    }

    public class AiInsightMeetingNoteSubpoint
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AiInsightActionItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ownerDisplayName")]
        public string OwnerDisplayName { get; set; }
    }

    public class AiInsightViewpoint
    {
        [JsonProperty("mentionEvents")]
        public AiInsightMentionEvent[] MentionEvents { get; set; }
    }

    public class AiInsightMentionEvent
    {
        [JsonProperty("eventDateTime")]
        public string EventDateTime { get; set; }

        [JsonProperty("transcriptUtterance")]
        public string TranscriptUtterance { get; set; }

        [JsonProperty("speaker")]
        public AiInsightMentionEventSpeakerType Speaker { get; set; }
    }

    public class AiInsightMentionEventSpeakerType
    {
        [JsonProperty("user")]
        public AiInsightMentionEventSpeakerTypeUserType User { get; set; }
    }

    public class AiInsightMentionEventSpeakerTypeUserType
    {
        [JsonProperty("@odata.type")]
        public string ODataType { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userIdentityType")]
        public string UserIdentityType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum frequencyInput
    {
        [EnumMember(Value = "Multiple")]
        EveryReactionMultiple,
        [EnumMember(Value = "Once")]
        FirstReactionOnlyOnce
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum runningPolicyInput
    {
        Myself,
        Everyone
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum scopeTypeInput
    {
        [EnumMember(Value = "user")]
        MeetingsThatYouOrganized,
        [EnumMember(Value = "meeting")]
        ASpecificMeetingYouOrganized,
        [EnumMember(Value = "adhocCallUser")]
        AdHocCallsYouReIn
    }

    public class TranscriptTriggerInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Scope { get; set; }
    }

    public class RecordingTriggerInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Scope { get; set; }
    }

    public class WebhookChatMessageTriggerInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnGroupMemberChangeResponseItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teams;

    public partial class WorkflowManagedActions
    {
        public TeamsActions Teams(string connectionId) => new TeamsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TeamsTriggers Teams(string connectionId) => new TeamsTriggers(connectionId);
    }
}