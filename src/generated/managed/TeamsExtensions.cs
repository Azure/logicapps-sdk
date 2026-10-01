//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teams
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewMeetingRespone> CreateTeamsMeeting([WorkflowExpression] Func<calendaridInput> calendarid, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemtimeZone, [WorkflowExpression] Func<string> itembodyeventMessageContent = null, [WorkflowExpression] Func<string> itemstartstartTime = null, [WorkflowExpression] Func<string> itemendendTime = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemlocationdisplayName = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<itemrecurrencepatternrecurrencePatternInput> itemrecurrencepatternrecurrencePattern = null, [WorkflowExpression] Func<int> itemrecurrencepatternrecurrenceInterval = null, [WorkflowExpression] Func<string[]> itemrecurrencepatterndaysOfWeek = null, [WorkflowExpression] Func<itemrecurrencepatternweekIndexInput> itemrecurrencepatternweekIndex = null, [WorkflowExpression] Func<string> itemrecurrencerangerecurrenceStartDate = null, [WorkflowExpression] Func<string> itemrecurrencerangerecurrenceEndDate = null, [WorkflowExpression] Func<bool> itemallDayEvent = null, [WorkflowExpression] Func<int> itempreEventReminderTime = null, [WorkflowExpression] Func<bool> itemenableReminders = null, [WorkflowExpression] Func<itemstatusShowAsInput> itemstatusShowAs = null, [WorkflowExpression] Func<bool> itemrequestResponse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/calendars/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = SourceExpressionConverter.ConvertToken(itemsubject);
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (itembodyeventMessageContent != null)
                {
                    bodyObject["content"] = SourceExpressionConverter.ConvertToken(itembodyeventMessageContent);
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
                item["timeZone"] = SourceExpressionConverter.ConvertToken(itemtimeZone);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (itemstartstartTime != null)
                {
                    startObject["dateTime"] = SourceExpressionConverter.ConvertToken(itemstartstartTime);
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
                    endObject["dateTime"] = SourceExpressionConverter.ConvertToken(itemendendTime);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    item["end"] = endObject;
                    itempropCount++;
                }

                if (itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = SourceExpressionConverter.ConvertToken(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = SourceExpressionConverter.ConvertToken(itemoptionalAttendees);
                    itempropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (itemlocationdisplayName != null)
                {
                    locationObject["displayName"] = SourceExpressionConverter.ConvertToken(itemlocationdisplayName);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    item["location"] = locationObject;
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["importance"] = SourceExpressionConverter.Convert(itemimportance);
                    itempropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                var patternObject = new JObject();
                var patternObjectpropCount = 0;
                if (itemrecurrencepatternrecurrencePattern != null)
                {
                    patternObject["type"] = SourceExpressionConverter.Convert(itemrecurrencepatternrecurrencePattern);
                    patternObjectpropCount++;
                }

                if (itemrecurrencepatternrecurrenceInterval != null)
                {
                    patternObject["interval"] = SourceExpressionConverter.ConvertToken(itemrecurrencepatternrecurrenceInterval);
                    patternObjectpropCount++;
                }

                if (itemrecurrencepatterndaysOfWeek != null)
                {
                    patternObject["daysOfWeek"] = SourceExpressionConverter.ConvertToken(itemrecurrencepatterndaysOfWeek);
                    patternObjectpropCount++;
                }

                if (itemrecurrencepatternweekIndex != null)
                {
                    patternObject["index"] = SourceExpressionConverter.Convert(itemrecurrencepatternweekIndex);
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
                    rangeObject["startDate"] = SourceExpressionConverter.ConvertToken(itemrecurrencerangerecurrenceStartDate);
                    rangeObjectpropCount++;
                }

                if (itemrecurrencerangerecurrenceEndDate != null)
                {
                    rangeObject["endDate"] = SourceExpressionConverter.ConvertToken(itemrecurrencerangerecurrenceEndDate);
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
                    item["isAllDay"] = SourceExpressionConverter.ConvertToken(itemallDayEvent);
                    itempropCount++;
                }

                if (itempreEventReminderTime != null)
                {
                    item["reminderMinutesBeforeStart"] = SourceExpressionConverter.ConvertToken(itempreEventReminderTime);
                    itempropCount++;
                }

                if (itemenableReminders != null)
                {
                    item["isReminderOn"] = SourceExpressionConverter.ConvertToken(itemenableReminders);
                    itempropCount++;
                }

                if (itemstatusShowAs != null)
                {
                    item["showAs"] = SourceExpressionConverter.Convert(itemstatusShowAs);
                    itempropCount++;
                }

                if (itemrequestResponse != null)
                {
                    item["responseRequested"] = SourceExpressionConverter.ConvertToken(itemrequestResponse);
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
                return callPayload;
            }

            return new ApiConnectionAction<NewMeetingRespone>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllTeamsResponse> GetAllTeams()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/me/joinedTeams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllTeamsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllAssociatedTeamsResponse> GetAllAssociatedTeams()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me/teamwork/associatedTeams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllAssociatedTeamsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelsForGroupResponse> GetChannelsForGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/channels", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                return callPayload;
            }

            return new ApiConnectionAction<GetChannelsForGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodymembershipTypeInput> bodymembershipType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/channels", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodymembershipType != null)
                {
                    if (bodymembershipType != null)
                    {
                        body["membershipType"] = SourceExpressionConverter.Convert(bodymembershipType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["membershipType"] = "standard";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateChannelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelResponse> GetChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetChannelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction UpdateChannelProperties([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AsyncOperationResponse> ArchiveChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, [WorkflowExpression] Func<bool> bodysetSharePointSiteToReadOnlyForMembers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/channels/{1}/archive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysetSharePointSiteToReadOnlyForMembers != null)
                {
                    body["shouldSetSpoSiteReadOnlyForMembers"] = SourceExpressionConverter.ConvertToken(bodysetSharePointSiteToReadOnlyForMembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AsyncOperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse> GetAllChannelsForTeam([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/allChannels", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllChannelsForTeamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChatsResponse> GetChats([WorkflowExpression] Func<chatTypeInput> chatType, [WorkflowExpression] Func<topicInput> topic)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/flowbot/actions/listchats/chattypes/{0}/topic/{1}/expandmembers/false", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topic, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetChatsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction PostFeedNotification([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<notificationTypeInput> notificationType, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/flowbot/feednotification/poster/{0}/notificationType/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(notificationType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionTagResponse> AtMentionTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AtMentionTagResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromConversationResponse> GetMessagesFromChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesFromConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> GetMessageDetails([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/messages/{0}/messageType/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListRepliesResponseSchema> ListRepliesToMessage([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/channels/{1}/messages/{2}/replies", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(20);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListRepliesResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListMembersResponseSchema> ListMembers([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/listmembers/threadType/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<ListMembersResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction SubscribeUserMessageWithOptions([WorkflowExpression] Func<object> userMessageWithOptionsSubscriptionRequest = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowbot/actions/messagewithoptions/recipienttypes/user/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(userMessageWithOptionsSubscriptionRequest);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTeamResponse> GetTeam([WorkflowExpression] Func<string> teamId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTeamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionUserV1> AtMentionUser([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AtMentionUserV1>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewChatResponse> CreateChat([WorkflowExpression] Func<string> itemmembersToAdd, [WorkflowExpression] Func<string> itemtitle = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/chats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemtitle != null)
                {
                    item["topic"] = SourceExpressionConverter.ConvertToken(itemtitle);
                    itempropCount++;
                }

                itempropCount++;
                item["members"] = SourceExpressionConverter.ConvertToken(itemmembersToAdd);
                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NewChatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromConversationResponse> GetMessagesFromChat([WorkflowExpression] Func<string> chatId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/chats/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesFromConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ChatMessage> PostMessageToSelf([WorkflowExpression] Func<bodybodycontentTypeInput> bodybodycontentType = null, [WorkflowExpression] Func<string> bodybodycontent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/chats/48:notes/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (bodybodycontentType != null)
                {
                    if (bodybodycontentType != null)
                    {
                        bodyObject["contentType"] = SourceExpressionConverter.Convert(bodybodycontentType);
                        bodyObjectpropCount++;
                    }

                    bodyObjectpropCount++;
                }
                else
                {
                    bodyObject["contentType"] = "text";
                    bodyObjectpropCount++;
                }

                if (bodybodycontent != null)
                {
                    bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodybodycontent);
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
                return callPayload;
            }

            return new ApiConnectionAction<ChatMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateATeamResponse> CreateATeam([WorkflowExpression] Func<string> bodyteamName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/teams";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodyteamName);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodyvisibility != null)
                {
                    if (bodyvisibility != null)
                    {
                        body["visibility"] = SourceExpressionConverter.Convert(bodyvisibility);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateATeamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListMembersResponseSchema> ListTeamMembers([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListMembersResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction AddMemberToTeam([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodysetUserAsTeamOwner = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuser);
                if (bodysetUserAsTeamOwner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodysetUserAsTeamOwner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction RemoveMemberFromTeam([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> membershipId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(membershipId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction AddMemberToChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodysetUserAsChannelOwner = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/channels/{1}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuser);
                if (bodysetUserAsChannelOwner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodysetUserAsChannelOwner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction RemoveMemberFromChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, [WorkflowExpression] Func<string> membershipId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/channels/{1}/members/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(membershipId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> PostMessageToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/conversation/message/poster/{0}/location/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PostToConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithMessageToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/replyWithMessage/poster/{0}/location/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PostToConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> PostCardToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/adaptivecard/poster/{0}/location/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PostToConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> PostCardAndWaitForResponse([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> bodybodyrecipient = null, [WorkflowExpression] Func<string> bodybodymessage = null, [WorkflowExpression] Func<string> bodybodyupdateMessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/gatherinput/poster/{0}/location/{1}/$subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
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
                    bodyObject["recipient"] = SourceExpressionConverter.ConvertToken(bodybodyrecipient);
                    bodyObjectpropCount++;
                }

                if (bodybodymessage != null)
                {
                    bodyObject["messageBody"] = SourceExpressionConverter.ConvertToken(bodybodymessage);
                    bodyObjectpropCount++;
                }

                if (bodybodyupdateMessage != null)
                {
                    if (bodybodyupdateMessage != null)
                    {
                        bodyObject["updateMessage"] = SourceExpressionConverter.ConvertToken(bodybodyupdateMessage);
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
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithCardToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/replyWithAdaptivecard/poster/{0}/location/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PostToConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> UpdateCardInConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/updateAdaptivecard/poster/{0}/location/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(poster, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PostToConversationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = SourceExpressionConverter.ConvertO(uri);
                callPayload.Headers["Method"] = SourceExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = SourceExpressionConverter.ConvertO(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = SourceExpressionConverter.ConvertO(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = SourceExpressionConverter.ConvertO(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = SourceExpressionConverter.ConvertO(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = SourceExpressionConverter.ConvertO(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = SourceExpressionConverter.ConvertO(customHeader5);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction AddMemberToChat([WorkflowExpression] Func<string> chatId, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodysetUserAsChatOwner = null, [WorkflowExpression] Func<string> bodyvisibleHistoryStartDateTime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/chats/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuser);
                if (bodysetUserAsChatOwner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodysetUserAsChatOwner);
                    bodypropCount++;
                }

                if (bodyvisibleHistoryStartDateTime != null)
                {
                    body["visibleHistoryStartDateTime"] = SourceExpressionConverter.ConvertToken(bodyvisibleHistoryStartDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction RemoveMemberFromChat([WorkflowExpression] Func<string> chatId, [WorkflowExpression] Func<string> membershipId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/chats/{0}/members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(chatId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(membershipId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetOnlineMeetingResponse> GetOnlineMeeting([WorkflowExpression] Func<lookupTypeInput> lookupType, [WorkflowExpression] Func<string> lookupValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me/onlineMeetings/lookup";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookupType"] = SourceExpressionConverter.Convert(lookupType);
                callPayload.Queries["lookupValue"] = SourceExpressionConverter.ConvertO(lookupValue);
                return callPayload;
            }

            return new ApiConnectionAction<GetOnlineMeetingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptCollectionResponse> ListMeetingTranscripts([WorkflowExpression] Func<string> meetingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/onlineMeetings/{0}/transcripts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallTranscriptCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptResponse> GetMeetingTranscript([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> transcriptId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/onlineMeetings/{0}/transcripts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transcriptId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallTranscriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<string> GetMeetingTranscriptContent([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> transcriptId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/onlineMeetings/{0}/transcripts/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transcriptId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingCollectionResponse> ListMeetingRecordings([WorkflowExpression] Func<string> meetingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/onlineMeetings/{0}/recordings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallRecordingCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingResponse> GetMeetingRecording([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> recordingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/onlineMeetings/{0}/recordings/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallRecordingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<object> GetMeetingRecordingContent([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> recordingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/onlineMeetings/{0}/recordings/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListSectionsResponse> ListSections()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/me/teamwork/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListSectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionResponse> CreateSection([WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodydisplayIconiconType = null, [WorkflowExpression] Func<bool> bodyisExpanded = null, [WorkflowExpression] Func<bodysortTypeInput> bodysortType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/me/teamwork/sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                var displayIconObject = new JObject();
                var displayIconObjectpropCount = 0;
                if (bodydisplayIconiconType != null)
                {
                    displayIconObject["iconType"] = SourceExpressionConverter.ConvertToken(bodydisplayIconiconType);
                    displayIconObjectpropCount++;
                }

                if (displayIconObjectpropCount > 0)
                {
                    body["displayIcon"] = displayIconObject;
                    bodypropCount++;
                }

                if (bodyisExpanded != null)
                {
                    body["isExpanded"] = SourceExpressionConverter.ConvertToken(bodyisExpanded);
                    bodypropCount++;
                }

                if (bodysortType != null)
                {
                    body["sortType"] = SourceExpressionConverter.Convert(bodysortType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionResponse> GetSection([WorkflowExpression] Func<string> sectionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/me/teamwork/sections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionResponse> UpdateSection([WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodydisplayIconiconType = null, [WorkflowExpression] Func<bool> bodyisExpanded = null, [WorkflowExpression] Func<bodysortTypeInput> bodysortType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/me/teamwork/sections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                var displayIconObject = new JObject();
                var displayIconObjectpropCount = 0;
                if (bodydisplayIconiconType != null)
                {
                    displayIconObject["iconType"] = SourceExpressionConverter.ConvertToken(bodydisplayIconiconType);
                    displayIconObjectpropCount++;
                }

                if (displayIconObjectpropCount > 0)
                {
                    body["displayIcon"] = displayIconObject;
                    bodypropCount++;
                }

                if (bodyisExpanded != null)
                {
                    body["isExpanded"] = SourceExpressionConverter.ConvertToken(bodyisExpanded);
                    bodypropCount++;
                }

                if (bodysortType != null)
                {
                    body["sortType"] = SourceExpressionConverter.Convert(bodysortType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteSection([WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> ifMatch)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/me/teamwork/sections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListSectionItemsResponse> ListSectionItems([WorkflowExpression] Func<string> sectionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/me/teamwork/sections/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListSectionItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction RemoveSectionItem([WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> sectionItemId, [WorkflowExpression] Func<string> ifMatch)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/me/teamwork/sections/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionItemId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<SectionItemResponse> MoveSectionItem([WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> sectionItemId, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> bodytargetSectionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/me/teamwork/sections/{0}/items/{1}/move", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sectionItemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["targetSectionId"] = SourceExpressionConverter.ConvertToken(bodytargetSectionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SectionItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagsResponseSchema> GetTags([WorkflowExpression] Func<string> groupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagsResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema> CreateTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodymembersIDs)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
                body["members"] = SourceExpressionConverter.ConvertToken(bodymembersIDs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTagResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema> GetTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CreateTagResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema> UpdateTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodydisplayName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTagResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyuserSId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags/{1}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserSId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddMemberToTagResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagMembersResponseSchema> GetTagMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags/{1}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagMembersResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTagMember([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> tagMemberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/tags/{1}/members/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagMemberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingCollectionResponse> ListCallRecordings([WorkflowExpression] Func<string> callId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/adhocCalls/{0}/recordings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallRecordingCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingResponse> GetCallRecording([WorkflowExpression] Func<string> callId, [WorkflowExpression] Func<string> recordingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/adhocCalls/{0}/recordings/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallRecordingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<object> GetCallRecordingContent([WorkflowExpression] Func<string> callId, [WorkflowExpression] Func<string> recordingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/adhocCalls/{0}/recordings/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptCollectionResponse> ListCallTranscripts([WorkflowExpression] Func<string> callId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/adhocCalls/{0}/transcripts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallTranscriptCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptResponse> GetCallTranscript([WorkflowExpression] Func<string> callId, [WorkflowExpression] Func<string> transcriptId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/adhocCalls/{0}/transcripts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transcriptId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CallTranscriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<string> GetCallTranscriptContent([WorkflowExpression] Func<string> callId, [WorkflowExpression] Func<string> transcriptId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/me/adhocCalls/{0}/transcripts/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transcriptId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallRecordingCollectionResponse> GetAllAdhocCallRecordings([WorkflowExpression] Func<string> startDateTime = null, [WorkflowExpression] Func<string> endDateTime = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> deltatoken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me/adhocCalls/getAllRecordings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDateTime != null)
                    callPayload.Queries["startDateTime"] = SourceExpressionConverter.ConvertO(startDateTime);
                if (endDateTime != null)
                    callPayload.Queries["endDateTime"] = SourceExpressionConverter.ConvertO(endDateTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (deltatoken != null)
                    callPayload.Queries["$deltatoken"] = SourceExpressionConverter.ConvertO(deltatoken);
                return callPayload;
            }

            return new ApiConnectionAction<CallRecordingCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CallTranscriptCollectionResponse> GetAllAdhocCallTranscripts([WorkflowExpression] Func<string> startDateTime = null, [WorkflowExpression] Func<string> endDateTime = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> deltatoken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me/adhocCalls/getAllTranscripts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDateTime != null)
                    callPayload.Queries["startDateTime"] = SourceExpressionConverter.ConvertO(startDateTime);
                if (endDateTime != null)
                    callPayload.Queries["endDateTime"] = SourceExpressionConverter.ConvertO(endDateTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (deltatoken != null)
                    callPayload.Queries["$deltatoken"] = SourceExpressionConverter.ConvertO(deltatoken);
                return callPayload;
            }

            return new ApiConnectionAction<CallTranscriptCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AiInsightCollectionResponse> ListAiInsights([WorkflowExpression] Func<string> meetingId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/copilot/me/onlineMeetings/{0}/aiInsights", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AiInsightCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AiInsightDetailResponse> GetAiInsight([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> aiInsightId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/copilot/me/onlineMeetings/{0}/aiInsights/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aiInsightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AiInsightDetailResponse>(BuildSourceInput);
        }
    }

    public class TeamsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ChatMessage[]> OnNewChannelMessage([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return callPayload;
            }

            return new ApiConnectionTrigger<ChatMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ChatMessage[]> OnNewChannelMessageMentioningMe([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages_mentioningme", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return callPayload;
            }

            return new ApiConnectionTrigger<ChatMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookAtMentionTrigger([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/atmentiontrigger/threadType/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(requestBody);
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookMessageReactionTrigger([WorkflowExpression] Func<string> reactionKey, [WorkflowExpression] Func<frequencyInput> frequency, [WorkflowExpression] Func<runningPolicyInput> runningPolicy, [WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/messagereactiontrigger/threadType/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reactionKey"] = SourceExpressionConverter.ConvertO(reactionKey);
                callPayload.Queries["frequency"] = SourceExpressionConverter.Convert(frequency);
                callPayload.Queries["runningPolicy"] = SourceExpressionConverter.Convert(runningPolicy);
                callPayload.Body = SourceExpressionConverter.ConvertToken(requestBody);
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TranscriptTrigger([WorkflowExpression] Func<scopeTypeInput> scopeType, [WorkflowExpression] Func<object> bodyscope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/subscriptions/transcripttrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["scopeType"] = SourceExpressionConverter.Convert(scopeType);
                var body = new JObject();
                var bodypropCount = 0;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["scope"] = SourceExpressionConverter.ConvertToken(bodyscope);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger RecordingTrigger([WorkflowExpression] Func<scopeTypeInput> scopeType, [WorkflowExpression] Func<object> bodyscope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/subscriptions/recordingtrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["scopeType"] = SourceExpressionConverter.Convert(scopeType);
                var body = new JObject();
                var bodypropCount = 0;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["scope"] = SourceExpressionConverter.ConvertToken(bodyscope);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookChatMessageTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookKeywordTrigger([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<string> search, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/keywordtrigger/threadType/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$search"] = SourceExpressionConverter.ConvertO(search);
                callPayload.Body = SourceExpressionConverter.ConvertToken(requestBody);
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookNewMessageTrigger([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/newmessagetrigger/threadType/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(requestBody);
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberRemoved([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1.0/groups/removal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return callPayload;
            }

            return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberAdded([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1.0/groups/delta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return callPayload;
            }

            return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(BuildSourceInput, triggerName, recurrence);
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

        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }
    }

    public enum bodymembershipTypeInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "shared")]
        Shared
    }

    public class AsyncOperationResponse
    {
        [JsonProperty("status")]
        public AsyncOperationResponseStatusType Status { get; set; }
    }

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
        public string MembershipID { get; set; }

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

    public enum bodybodycontentTypeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html
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

    public class GetOnlineMeetingResponse
    {
        [JsonProperty("id")]
        public string MeetingID { get; set; }

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
        public GetOnlineMeetingResponseJoinMeetingIdSettingsType JoinMeetingIDSettings { get; set; }

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
        public string JoinMeetingID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class GetOnlineMeetingResponseAudioConferencingType
    {
        [JsonProperty("conferenceId")]
        public string ConferenceID { get; set; }

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
        public string TranscriptID { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("transcriptContentUrl")]
        public string TranscriptContentURL { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingID { get; set; }

        [JsonProperty("meetingOrganizerId")]
        public string MeetingOrganizerID { get; set; }

        [JsonProperty("callId")]
        public string CallID { get; set; }
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
        public string RecordingID { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("recordingContentUrl")]
        public string RecordingContentURL { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingID { get; set; }

        [JsonProperty("meetingOrganizerId")]
        public string MeetingOrganizerID { get; set; }

        [JsonProperty("callId")]
        public string CallID { get; set; }
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
        public string SectionID { get; set; }

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

    public enum SectionResponseSectionTypeType
    {
        [EnumMember(Value = "userDefined")]
        UserDefined,
        [EnumMember(Value = "systemDefined")]
        SystemDefined
    }

    public enum bodysortTypeInput
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
        public string ItemID { get; set; }

        [JsonProperty("itemType")]
        public SectionItemResponseItemTypeType ItemType { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }
    }

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
        public string AIInsightID { get; set; }

        [JsonProperty("callId")]
        public string CallID { get; set; }

        [JsonProperty("contentCorrelationId")]
        public string ContentCorrelationID { get; set; }

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
        public string AIInsightID { get; set; }

        [JsonProperty("callId")]
        public string CallID { get; set; }

        [JsonProperty("contentCorrelationId")]
        public string ContentCorrelationID { get; set; }

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
        public string UserID { get; set; }

        [JsonProperty("displayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userIdentityType")]
        public string UserIdentityType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantID { get; set; }
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

    public enum scopeTypeInput
    {
        [EnumMember(Value = "user")]
        MeetingsThatYouOrganized,
        [EnumMember(Value = "meeting")]
        ASpecificMeetingYouOrganized,
        [EnumMember(Value = "adhocCallUser")]
        AdHocCallsYouReIn
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