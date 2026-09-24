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
            SourceExpression.Validate(calendarid, nameof(calendarid), required: true);
            SourceExpression.Validate(itemsubject, nameof(itemsubject), required: true);
            SourceExpression.Validate(itemtimeZone, nameof(itemtimeZone), required: true);
            SourceExpression.Validate(itembodyeventMessageContent, nameof(itembodyeventMessageContent), required: false);
            SourceExpression.Validate(itemstartstartTime, nameof(itemstartstartTime), required: false);
            SourceExpression.Validate(itemendendTime, nameof(itemendendTime), required: false);
            SourceExpression.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            SourceExpression.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            SourceExpression.Validate(itemlocationdisplayName, nameof(itemlocationdisplayName), required: false);
            SourceExpression.Validate(itemimportance, nameof(itemimportance), required: false);
            SourceExpression.Validate(itemrecurrencepatternrecurrencePattern, nameof(itemrecurrencepatternrecurrencePattern), required: false);
            SourceExpression.Validate(itemrecurrencepatternrecurrenceInterval, nameof(itemrecurrencepatternrecurrenceInterval), required: false);
            SourceExpression.Validate(itemrecurrencepatterndaysOfWeek, nameof(itemrecurrencepatterndaysOfWeek), required: false);
            SourceExpression.Validate(itemrecurrencepatternweekIndex, nameof(itemrecurrencepatternweekIndex), required: false);
            SourceExpression.Validate(itemrecurrencerangerecurrenceStartDate, nameof(itemrecurrencerangerecurrenceStartDate), required: false);
            SourceExpression.Validate(itemrecurrencerangerecurrenceEndDate, nameof(itemrecurrencerangerecurrenceEndDate), required: false);
            SourceExpression.Validate(itemallDayEvent, nameof(itemallDayEvent), required: false);
            SourceExpression.Validate(itempreEventReminderTime, nameof(itempreEventReminderTime), required: false);
            SourceExpression.Validate(itemenableReminders, nameof(itemenableReminders), required: false);
            SourceExpression.Validate(itemstatusShowAs, nameof(itemstatusShowAs), required: false);
            SourceExpression.Validate(itemrequestResponse, nameof(itemrequestResponse), required: false);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
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
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(channelId, nameof(channelId), required: true);
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
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse> GetAllChannelsForTeam([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
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
            SourceExpression.Validate(chatType, nameof(chatType), required: true);
            SourceExpression.Validate(topic, nameof(topic), required: true);
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
        public IBodyWorkflowAction<GetTagsResponseSchema> GetTags([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagsResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema> CreateTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodymembersIDs)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            SourceExpression.Validate(bodymembersIDs, nameof(bodymembersIDs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
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
        public IBodyWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyuserSID)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            SourceExpression.Validate(bodyuserSID, nameof(bodyuserSID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserSID);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagMembersResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTagMember([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> tagMemberId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            SourceExpression.Validate(tagMemberId, nameof(tagMemberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagMemberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction PostFeedNotification([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<notificationTypeInput> notificationType, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(notificationType, nameof(notificationType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
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
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromChannelResponse> GetMessagesFromChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(channelId, nameof(channelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesFromChannelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> GetMessageDetails([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(threadType, nameof(threadType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(channelId, nameof(channelId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
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
        public IBodyWorkflowAction<ListMembersResponseSchema> ListMembers([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(threadType, nameof(threadType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/listmembers/threadType/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<ListMembersResponseSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction SubscribeUserMessageWithOptions([WorkflowExpression] Func<object> userMessageWithOptionsSubscriptionRequest = null)
        {
            SourceExpression.Validate(userMessageWithOptionsSubscriptionRequest, nameof(userMessageWithOptionsSubscriptionRequest), required: false);
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
            SourceExpression.Validate(teamId, nameof(teamId), required: true);
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
            SourceExpression.Validate(userId, nameof(userId), required: true);
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
            SourceExpression.Validate(itemmembersToAdd, nameof(itemmembersToAdd), required: true);
            SourceExpression.Validate(itemtitle, nameof(itemtitle), required: false);
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
        public IBodyWorkflowAction<CreateATeamResponse> CreateATeam([WorkflowExpression] Func<string> bodyteamName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility = null)
        {
            SourceExpression.Validate(bodyteamName, nameof(bodyteamName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
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
        public IWorkflowAction AddMemberToTeam([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodysetUserAsTeamOwner = null)
        {
            SourceExpression.Validate(teamId, nameof(teamId), required: true);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: true);
            SourceExpression.Validate(bodysetUserAsTeamOwner, nameof(bodysetUserAsTeamOwner), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
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
        public IBodyWorkflowAction<PostToConversationResponse> PostMessageToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(bodybodyrecipient, nameof(bodybodyrecipient), required: false);
            SourceExpression.Validate(bodybodymessage, nameof(bodybodymessage), required: false);
            SourceExpression.Validate(bodybodyupdateMessage, nameof(bodybodyupdateMessage), required: false);
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
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(poster, nameof(poster), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
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
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            SourceExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            SourceExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            SourceExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            SourceExpression.Validate(customHeader5, nameof(customHeader5), required: false);
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
    }

    public class TeamsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessage([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(channelId, nameof(channelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessageMentioningMe([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(channelId, nameof(channelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages_mentioningme", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WebhookAtMentionTrigger([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> requestBody = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(threadType, nameof(threadType), required: true);
            SourceExpression.Validate(requestBody, nameof(requestBody), required: false);
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
            SourceExpression.Validate(reactionKey, nameof(reactionKey), required: true);
            SourceExpression.Validate(frequency, nameof(frequency), required: true);
            SourceExpression.Validate(runningPolicy, nameof(runningPolicy), required: true);
            SourceExpression.Validate(threadType, nameof(threadType), required: true);
            SourceExpression.Validate(requestBody, nameof(requestBody), required: false);
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
            SourceExpression.Validate(threadType, nameof(threadType), required: true);
            SourceExpression.Validate(search, nameof(search), required: true);
            SourceExpression.Validate(requestBody, nameof(requestBody), required: false);
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
            SourceExpression.Validate(threadType, nameof(threadType), required: true);
            SourceExpression.Validate(requestBody, nameof(requestBody), required: false);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
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
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
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