//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teams
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewMeetingRespone> CreateTeamsMeeting([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<calendaridInput> calendarid, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemtimeZone, [WorkflowExpression] Func<string> itembodyeventMessageContent = null, [WorkflowExpression] Func<string> itemstartstartTime = null, [WorkflowExpression] Func<string> itemendendTime = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemlocationdisplayName = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<itemrecurrencepatternrecurrencePatternInput> itemrecurrencepatternrecurrencePattern = null, [WorkflowExpression] Func<int> itemrecurrencepatternrecurrenceInterval = null, [WorkflowExpression] Func<string[]> itemrecurrencepatterndaysOfWeek = null, [WorkflowExpression] Func<itemrecurrencepatternweekIndexInput> itemrecurrencepatternweekIndex = null, [WorkflowExpression] Func<string> itemrecurrencerangerecurrenceStartDate = null, [WorkflowExpression] Func<string> itemrecurrencerangerecurrenceEndDate = null, [WorkflowExpression] Func<bool> itemallDayEvent = null, [WorkflowExpression] Func<int> itempreEventReminderTime = null, [WorkflowExpression] Func<bool> itemenableReminders = null, [WorkflowExpression] Func<itemstatusShowAsInput> itemstatusShowAs = null, [WorkflowExpression] Func<bool> itemrequestResponse = null)
        {
            var apiCallPath = String.Format("/v1.0/me/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["subject"] = ExpressionConverter.ConvertO(itemsubject);
            var bodyObject = new JObject();
            var bodyObjectpropCount = 0;
            if (itembodyeventMessageContent != null)
            {
                bodyObject["content"] = ExpressionConverter.ConvertO(itembodyeventMessageContent);
                bodyObjectpropCount++;
            }

            bodyObject["contentType"] = "html";
            bodyObjectpropCount++;
            if (bodyObjectpropCount > 0)
            {
                item["body"] = bodyObject;
                itempropCount++;
            }

            itempropCount++;
            item["timeZone"] = ExpressionConverter.ConvertO(itemtimeZone);
            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (itemstartstartTime != null)
            {
                startObject["dateTime"] = ExpressionConverter.ConvertO(itemstartstartTime);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                item["start"] = startObject;
                itempropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (itemendendTime != null)
            {
                endObject["dateTime"] = ExpressionConverter.ConvertO(itemendendTime);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                item["end"] = endObject;
                itempropCount++;
            }

            if (itemrequiredAttendees != null)
            {
                item["requiredAttendees"] = ExpressionConverter.ConvertO(itemrequiredAttendees);
                itempropCount++;
            }

            if (itemoptionalAttendees != null)
            {
                item["optionalAttendees"] = ExpressionConverter.ConvertO(itemoptionalAttendees);
                itempropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (itemlocationdisplayName != null)
            {
                locationObject["displayName"] = ExpressionConverter.ConvertO(itemlocationdisplayName);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                item["location"] = locationObject;
                itempropCount++;
            }

            if (itemimportance != null)
            {
                item["importance"] = ExpressionConverter.ConvertO(itemimportance);
                itempropCount++;
            }

            var recurrenceObject = new JObject();
            var recurrenceObjectpropCount = 0;
            var patternObject = new JObject();
            var patternObjectpropCount = 0;
            if (itemrecurrencepatternrecurrencePattern != null)
            {
                patternObject["type"] = ExpressionConverter.ConvertO(itemrecurrencepatternrecurrencePattern);
                patternObjectpropCount++;
            }

            if (itemrecurrencepatternrecurrenceInterval != null)
            {
                patternObject["interval"] = ExpressionConverter.ConvertO(itemrecurrencepatternrecurrenceInterval);
                patternObjectpropCount++;
            }

            if (itemrecurrencepatterndaysOfWeek != null)
            {
                patternObject["daysOfWeek"] = ExpressionConverter.ConvertO(itemrecurrencepatterndaysOfWeek);
                patternObjectpropCount++;
            }

            if (itemrecurrencepatternweekIndex != null)
            {
                patternObject["index"] = ExpressionConverter.ConvertO(itemrecurrencepatternweekIndex);
                patternObjectpropCount++;
            }

            if (patternObjectpropCount > 0)
            {
                recurrenceObject["pattern"] = patternObject;
                recurrenceObjectpropCount++;
            }

            var rangeObject = new JObject();
            var rangeObjectpropCount = 0;
            if (itemrecurrencerangerecurrenceStartDate != null)
            {
                rangeObject["startDate"] = ExpressionConverter.ConvertO(itemrecurrencerangerecurrenceStartDate);
                rangeObjectpropCount++;
            }

            if (itemrecurrencerangerecurrenceEndDate != null)
            {
                rangeObject["endDate"] = ExpressionConverter.ConvertO(itemrecurrencerangerecurrenceEndDate);
                rangeObjectpropCount++;
            }

            if (rangeObjectpropCount > 0)
            {
                recurrenceObject["range"] = rangeObject;
                recurrenceObjectpropCount++;
            }

            if (recurrenceObjectpropCount > 0)
            {
                item["recurrence"] = recurrenceObject;
                itempropCount++;
            }

            if (itemallDayEvent != null)
            {
                item["isAllDay"] = ExpressionConverter.ConvertO(itemallDayEvent);
                itempropCount++;
            }

            if (itempreEventReminderTime != null)
            {
                item["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(itempreEventReminderTime);
                itempropCount++;
            }

            if (itemenableReminders != null)
            {
                item["isReminderOn"] = ExpressionConverter.ConvertO(itemenableReminders);
                itempropCount++;
            }

            if (itemstatusShowAs != null)
            {
                item["showAs"] = ExpressionConverter.ConvertO(itemstatusShowAs);
                itempropCount++;
            }

            if (itemrequestResponse != null)
            {
                item["responseRequested"] = ExpressionConverter.ConvertO(itemrequestResponse);
                itempropCount++;
            }

            item["isOnlineMeeting"] = true;
            itempropCount++;
            item["onlineMeetingProvider"] = "teamsForBusiness";
            itempropCount++;
            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<NewMeetingRespone>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllTeamsResponse> GetAllTeams()
        {
            var apiCallPath = "/beta/me/joinedTeams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllTeamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllAssociatedTeamsResponse> GetAllAssociatedTeams()
        {
            var apiCallPath = "/v1.0/me/teamwork/associatedTeams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllAssociatedTeamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelsForGroupResponse> GetChannelsForGroup([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            var apiCallPath = String.Format("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            return new ApiConnectionAction<GetChannelsForGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            var apiCallPath = String.Format("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateChannelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelResponse> GetChannel([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> channelId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/channels/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetChannelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse> GetAllChannelsForTeam([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/allChannels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            return new ApiConnectionAction<GetAllChannelsForTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChatsResponse> GetChats([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<chatTypeInput> chatType, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<topicInput> topic)
        {
            var apiCallPath = String.Format("/flowbot/actions/listchats/chattypes/{0}/topic/{1}/expandmembers/false", ExpressionConverter.ConvertWithUrlEncoding(chatType, 1), ExpressionConverter.ConvertWithUrlEncoding(topic, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetChatsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagsResponseSchema> GetTags([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTagsResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema> CreateTag([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodymembersIDs)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            bodypropCount++;
            body["members"] = ExpressionConverter.ConvertO(bodymembersIDs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTagResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId, [WorkflowExpression] Func<string> bodyuserSID)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["userId"] = ExpressionConverter.ConvertO(bodyuserSID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddMemberToTagResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagMembersResponseSchema> GetTagMembers([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTagMembersResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTagMember([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId, [WorkflowExpression] Func<string> tagMemberId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagMemberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction PostFeedNotification([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<notificationTypeInput> notificationType, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/flowbot/feednotification/poster/{0}/notificationType/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(notificationType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionTagResponse> AtMentionTag([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AtMentionTagResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTag([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromChannelResponse> GetMessagesFromChannel([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> channelId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMessagesFromChannelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> GetMessageDetails([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> messageId, [WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/beta/teams/messages/{0}/messageType/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListRepliesResponseSchema> ListRepliesToMessage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> channelId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<int> top = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/channels/{1}/messages/{2}/replies", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$top"] = Convert.ToString(20);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListRepliesResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListMembersResponseSchema> ListMembers([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/listmembers/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<ListMembersResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction SubscribeUserMessageWithOptions([WorkflowExpression] Func<object> userMessageWithOptionsSubscriptionRequest = null)
        {
            var apiCallPath = "/flowbot/actions/messagewithoptions/recipienttypes/user/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(userMessageWithOptionsSubscriptionRequest);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTeamResponse> GetTeam([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> teamId)
        {
            var apiCallPath = String.Format("/beta/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionUserV1> AtMentionUser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userId)
        {
            var apiCallPath = String.Format("/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AtMentionUserV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewChatResponse> CreateChat([WorkflowExpression] Func<string> itemmembersToAdd, [WorkflowExpression] Func<string> itemtitle = null)
        {
            var apiCallPath = "/beta/chats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            if (itemtitle != null)
            {
                item["topic"] = ExpressionConverter.ConvertO(itemtitle);
                itempropCount++;
            }

            itempropCount++;
            item["members"] = ExpressionConverter.ConvertO(itemmembersToAdd);
            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<NewChatResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateATeamResponse> CreateATeam([WorkflowExpression] Func<string> bodyteamName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility = null)
        {
            var apiCallPath = "/beta/teams";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodyteamName);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            if (bodyvisibility != null)
            {
                if (bodyvisibility != null)
                {
                    body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["visibility"] = "Public";
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateATeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction AddMemberToTeam([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> teamId, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodysetUserAsTeamOwner = null)
        {
            var apiCallPath = String.Format("/beta/teams/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["userId"] = ExpressionConverter.ConvertO(bodyuser);
            if (bodysetUserAsTeamOwner != null)
            {
                body["owner"] = ExpressionConverter.ConvertO(bodysetUserAsTeamOwner);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> PostMessageToConversation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/beta/teams/conversation/message/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithMessageToConversation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/replyWithMessage/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> PostCardToConversation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/adaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> PostCardAndWaitForResponse([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> bodybodyrecipient = null, [WorkflowExpression] Func<string> bodybodymessage = null, [WorkflowExpression] Func<string> bodybodyupdateMessage = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/gatherinput/poster/{0}/location/{1}/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["notificationUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            var bodyObject = new JObject();
            var bodyObjectpropCount = 0;
            if (bodybodyrecipient != null)
            {
                bodyObject["recipient"] = ExpressionConverter.ConvertO(bodybodyrecipient);
                bodyObjectpropCount++;
            }

            if (bodybodymessage != null)
            {
                bodyObject["messageBody"] = ExpressionConverter.ConvertO(bodybodymessage);
                bodyObjectpropCount++;
            }

            if (bodybodyupdateMessage != null)
            {
                if (bodybodyupdateMessage != null)
                {
                    bodyObject["updateMessage"] = ExpressionConverter.ConvertO(bodybodyupdateMessage);
                    bodyObjectpropCount++;
                }

                bodyObjectpropCount++;
            }
            else
            {
                bodyObject["updateMessage"] = "Thanks for your response!";
                bodyObjectpropCount++;
            }

            if (bodyObjectpropCount > 0)
            {
                body["body"] = bodyObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithCardToConversation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/replyWithAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> UpdateCardInConversation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/conversation/updateAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<PostToConversationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            var apiCallPath = "/httprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
            callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
            callPayload.Headers["ContentType"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
            if (customHeader1 != null)
                callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
            if (customHeader2 != null)
                callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
            if (customHeader3 != null)
                callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
            if (customHeader4 != null)
                callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
            if (customHeader5 != null)
                callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class TeamsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$top"] = Convert.ToString(50);
            return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessageMentioningMe([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/beta/teams/{0}/channels/{1}/messages_mentioningme", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$top"] = Convert.ToString(50);
            return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookAtMentionTrigger([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/beta/subscriptions/atmentiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(requestBody);
            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookMessageReactionTrigger([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> reactionKey, [WorkflowExpression] Func<frequencyInput> frequency, [WorkflowExpression] Func<runningPolicyInput> runningPolicy, [WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/beta/subscriptions/messagereactiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["reactionKey"] = ExpressionConverter.Convert(reactionKey);
            callPayload.Queries["frequency"] = ExpressionConverter.Convert(frequency);
            callPayload.Queries["runningPolicy"] = ExpressionConverter.Convert(runningPolicy);
            callPayload.Body = ExpressionConverter.ConvertO(requestBody);
            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookChatMessageTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/beta/subscriptions/chatmessagetrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var chatMessageSubscriptionRequest = new JObject();
            var chatMessageSubscriptionRequestpropCount = 0;
            chatMessageSubscriptionRequest["notificationUrl"] = "#{listCallbackUrl()}";
            chatMessageSubscriptionRequestpropCount++;
            if (chatMessageSubscriptionRequestpropCount > 0)
            {
                callPayload.Body = chatMessageSubscriptionRequest;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookKeywordTrigger([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<threadTypeInput> threadType, [WorkflowExpression] Func<string> search, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/beta/subscriptions/keywordtrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
            callPayload.Body = ExpressionConverter.ConvertO(requestBody);
            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookNewMessageTrigger([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/beta/subscriptions/newmessagetrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(requestBody);
            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberRemoved([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1.0/groups/removal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["$select"] = Convert.ToString("members");
            return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberAdded([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1.0/groups/delta";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["$select"] = Convert.ToString("members");
            return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class NewMeetingRespone
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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

    public enum calendaridInput
    {
        Birthdays,
        Calendar,
        [EnumMember(Value = "United States holidays")]
        UnitedStatesHolidays
    }

    public enum itemimportanceInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum itemrecurrencepatternrecurrencePatternInput
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

    public enum itemrecurrencepatternweekIndexInput
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

    public enum itemstatusShowAsInput
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
        public string ID { get; set; }
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
        public string TeamID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("tenantId")]
        public string TenantID { get; set; }
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
        public string ChannelID { get; set; }

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
        public string ID { get; set; }
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
        public string ConversationID { get; set; }
    }

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

    public enum topicInput
    {
        [EnumMember(Value = "all")]
        AllChats,
        [EnumMember(Value = "isDefined")]
        IsDefined,
        [EnumMember(Value = "notDefined")]
        IsNotDefined
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
        public string ID { get; set; }

        [JsonProperty("teamId")]
        public string TeamID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("teamId")]
        public string TeamID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("memberCount")]
        public int MemberCount { get; set; }
    }

    public class AddMemberToTagResponseSchema
    {
        [JsonProperty("userId")]
        public string ID { get; set; }
    }

    public class GetTagMembersResponseSchema
    {
        [JsonProperty("value")]
        public GetTagMembersResponseSchemaValueTypeItem[] Value { get; set; }
    }

    public class GetTagMembersResponseSchemaValueTypeItem
    {
        [JsonProperty("id")]
        public string TagMemberID { get; set; }

        [JsonProperty("tenantId")]
        public string TenantID { get; set; }

        [JsonProperty("displayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userId")]
        public string UserID { get; set; }
    }

    public enum posterInput
    {
        [EnumMember(Value = "Flow bot")]
        FlowBot,
        User
    }

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

    public class OnNewChannelMessageResponseItem
    {
        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("body")]
        public OnNewChannelMessageResponseItemBodyType Body { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreationTimestamp { get; set; }

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

    public class OnNewChannelMessageResponseItemBodyType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
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

    public class OnNewChannelMessageResponseItemFromTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("identityProvider")]
        public string IdentityProvider { get; set; }
    }

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
        public string ID { get; set; }

        [JsonProperty("replyToId")]
        public string ReplyToID { get; set; }

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
        public string ChatID { get; set; }

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
        public string UserID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userIdentityType")]
        public string UserIdentityType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantID { get; set; }
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
        public string TeamID { get; set; }

        [JsonProperty("channelId")]
        public string ChannelID { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("tenantId")]
        public string TenantID { get; set; }

        [JsonProperty("userId")]
        public string UserID { get; set; }

        [JsonProperty("visibleHistoryStartDateTime")]
        public string StartTimeOfConversationSVisibleHistory { get; set; }
    }

    public class GetTeamResponse
    {
        [JsonProperty("id")]
        public string TeamID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfTeam { get; set; }

        [JsonProperty("internalId")]
        public string InternalID { get; set; }

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
        public string ConversationID { get; set; }
    }

    public class CreateATeamResponse
    {
        [JsonProperty("newTeamId")]
        public string NewTeamID { get; set; }
    }

    public enum bodyvisibilityInput
    {
        Private,
        Public
    }

    public class PostToConversationResponse
    {
        [JsonProperty("id")]
        public string MessageID { get; set; }

        [JsonProperty("messageLink")]
        public string MessageLink { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationID { get; set; }
    }

    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public enum frequencyInput
    {
        [EnumMember(Value = "Multiple")]
        EveryReactionMultiple,
        [EnumMember(Value = "Once")]
        FirstReactionOnlyOnce
    }

    public enum runningPolicyInput
    {
        Myself,
        Everyone
    }

    public class OnGroupMemberChangeResponseItem
    {
        [JsonProperty("id")]
        public string UserID { get; set; }
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