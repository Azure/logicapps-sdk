//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teams
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TeamsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewMeetingRespone> CreateTeamsMeeting(Expression<Func<calendaridInput>> calendarid, Expression<Func<string>> itemsubject, Expression<Func<string>> itemtimeZone, Expression<Func<string>> itembodyeventMessageContent = null, Expression<Func<string>> itemstartstartTime = null, Expression<Func<string>> itemendendTime = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemlocationdisplayName = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<itemrecurrencepatternrecurrencePatternInput>> itemrecurrencepatternrecurrencePattern = null, Expression<Func<int>> itemrecurrencepatternrecurrenceInterval = null, Expression<Func<string[]>> itemrecurrencepatterndaysOfWeek = null, Expression<Func<itemrecurrencepatternweekIndexInput>> itemrecurrencepatternweekIndex = null, Expression<Func<string>> itemrecurrencerangerecurrenceStartDate = null, Expression<Func<string>> itemrecurrencerangerecurrenceEndDate = null, Expression<Func<bool>> itemallDayEvent = null, Expression<Func<int>> itempreEventReminderTime = null, Expression<Func<bool>> itemenableReminders = null, Expression<Func<itemstatusShowAsInput>> itemstatusShowAs = null, Expression<Func<bool>> itemrequestResponse = null)
        {
            var __workflow_calendarid = calendarid == null ? null : WorkflowExpression.Compile(calendarid);
            WorkflowExpression.Validate(__workflow_calendarid, nameof(calendarid), required: true);
            var __workflow_itemsubject = itemsubject == null ? null : WorkflowExpression.Compile(itemsubject);
            WorkflowExpression.Validate(__workflow_itemsubject, nameof(itemsubject), required: true);
            var __workflow_itemtimeZone = itemtimeZone == null ? null : WorkflowExpression.Compile(itemtimeZone);
            WorkflowExpression.Validate(__workflow_itemtimeZone, nameof(itemtimeZone), required: true);
            var __workflow_itembodyeventMessageContent = itembodyeventMessageContent == null ? null : WorkflowExpression.Compile(itembodyeventMessageContent);
            WorkflowExpression.Validate(__workflow_itembodyeventMessageContent, nameof(itembodyeventMessageContent), required: false);
            var __workflow_itemstartstartTime = itemstartstartTime == null ? null : WorkflowExpression.Compile(itemstartstartTime);
            WorkflowExpression.Validate(__workflow_itemstartstartTime, nameof(itemstartstartTime), required: false);
            var __workflow_itemendendTime = itemendendTime == null ? null : WorkflowExpression.Compile(itemendendTime);
            WorkflowExpression.Validate(__workflow_itemendendTime, nameof(itemendendTime), required: false);
            var __workflow_itemrequiredAttendees = itemrequiredAttendees == null ? null : WorkflowExpression.Compile(itemrequiredAttendees);
            WorkflowExpression.Validate(__workflow_itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            var __workflow_itemoptionalAttendees = itemoptionalAttendees == null ? null : WorkflowExpression.Compile(itemoptionalAttendees);
            WorkflowExpression.Validate(__workflow_itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            var __workflow_itemlocationdisplayName = itemlocationdisplayName == null ? null : WorkflowExpression.Compile(itemlocationdisplayName);
            WorkflowExpression.Validate(__workflow_itemlocationdisplayName, nameof(itemlocationdisplayName), required: false);
            var __workflow_itemimportance = itemimportance == null ? null : WorkflowExpression.Compile(itemimportance);
            WorkflowExpression.Validate(__workflow_itemimportance, nameof(itemimportance), required: false);
            var __workflow_itemrecurrencepatternrecurrencePattern = itemrecurrencepatternrecurrencePattern == null ? null : WorkflowExpression.Compile(itemrecurrencepatternrecurrencePattern);
            WorkflowExpression.Validate(__workflow_itemrecurrencepatternrecurrencePattern, nameof(itemrecurrencepatternrecurrencePattern), required: false);
            var __workflow_itemrecurrencepatternrecurrenceInterval = itemrecurrencepatternrecurrenceInterval == null ? null : WorkflowExpression.Compile(itemrecurrencepatternrecurrenceInterval);
            WorkflowExpression.Validate(__workflow_itemrecurrencepatternrecurrenceInterval, nameof(itemrecurrencepatternrecurrenceInterval), required: false);
            var __workflow_itemrecurrencepatterndaysOfWeek = itemrecurrencepatterndaysOfWeek == null ? null : WorkflowExpression.Compile(itemrecurrencepatterndaysOfWeek);
            WorkflowExpression.Validate(__workflow_itemrecurrencepatterndaysOfWeek, nameof(itemrecurrencepatterndaysOfWeek), required: false);
            var __workflow_itemrecurrencepatternweekIndex = itemrecurrencepatternweekIndex == null ? null : WorkflowExpression.Compile(itemrecurrencepatternweekIndex);
            WorkflowExpression.Validate(__workflow_itemrecurrencepatternweekIndex, nameof(itemrecurrencepatternweekIndex), required: false);
            var __workflow_itemrecurrencerangerecurrenceStartDate = itemrecurrencerangerecurrenceStartDate == null ? null : WorkflowExpression.Compile(itemrecurrencerangerecurrenceStartDate);
            WorkflowExpression.Validate(__workflow_itemrecurrencerangerecurrenceStartDate, nameof(itemrecurrencerangerecurrenceStartDate), required: false);
            var __workflow_itemrecurrencerangerecurrenceEndDate = itemrecurrencerangerecurrenceEndDate == null ? null : WorkflowExpression.Compile(itemrecurrencerangerecurrenceEndDate);
            WorkflowExpression.Validate(__workflow_itemrecurrencerangerecurrenceEndDate, nameof(itemrecurrencerangerecurrenceEndDate), required: false);
            var __workflow_itemallDayEvent = itemallDayEvent == null ? null : WorkflowExpression.Compile(itemallDayEvent);
            WorkflowExpression.Validate(__workflow_itemallDayEvent, nameof(itemallDayEvent), required: false);
            var __workflow_itempreEventReminderTime = itempreEventReminderTime == null ? null : WorkflowExpression.Compile(itempreEventReminderTime);
            WorkflowExpression.Validate(__workflow_itempreEventReminderTime, nameof(itempreEventReminderTime), required: false);
            var __workflow_itemenableReminders = itemenableReminders == null ? null : WorkflowExpression.Compile(itemenableReminders);
            WorkflowExpression.Validate(__workflow_itemenableReminders, nameof(itemenableReminders), required: false);
            var __workflow_itemstatusShowAs = itemstatusShowAs == null ? null : WorkflowExpression.Compile(itemstatusShowAs);
            WorkflowExpression.Validate(__workflow_itemstatusShowAs, nameof(itemstatusShowAs), required: false);
            var __workflow_itemrequestResponse = itemrequestResponse == null ? null : WorkflowExpression.Compile(itemrequestResponse);
            WorkflowExpression.Validate(__workflow_itemrequestResponse, nameof(itemrequestResponse), required: false);
            return new DeferredBodyAction<NewMeetingRespone>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/me/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_calendarid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = ExpressionConverter.ConvertO(__workflow_itemsubject);
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_itembodyeventMessageContent != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(__workflow_itembodyeventMessageContent);
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
                item["timeZone"] = ExpressionConverter.ConvertO(__workflow_itemtimeZone);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_itemstartstartTime != null)
                {
                    startObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_itemstartstartTime);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    item["start"] = startObject;
                    itempropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_itemendendTime != null)
                {
                    endObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_itemendendTime);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    item["end"] = endObject;
                    itempropCount++;
                }

                if (__workflow_itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = ExpressionConverter.ConvertO(__workflow_itemrequiredAttendees);
                    itempropCount++;
                }

                if (__workflow_itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = ExpressionConverter.ConvertO(__workflow_itemoptionalAttendees);
                    itempropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_itemlocationdisplayName != null)
                {
                    locationObject["displayName"] = ExpressionConverter.ConvertO(__workflow_itemlocationdisplayName);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    item["location"] = locationObject;
                    itempropCount++;
                }

                if (__workflow_itemimportance != null)
                {
                    item["importance"] = ExpressionConverter.ConvertO(__workflow_itemimportance);
                    itempropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                var patternObject = new JObject();
                var patternObjectpropCount = 0;
                if (__workflow_itemrecurrencepatternrecurrencePattern != null)
                {
                    patternObject["type"] = ExpressionConverter.ConvertO(__workflow_itemrecurrencepatternrecurrencePattern);
                    patternObjectpropCount++;
                }

                if (__workflow_itemrecurrencepatternrecurrenceInterval != null)
                {
                    patternObject["interval"] = ExpressionConverter.ConvertO(__workflow_itemrecurrencepatternrecurrenceInterval);
                    patternObjectpropCount++;
                }

                if (__workflow_itemrecurrencepatterndaysOfWeek != null)
                {
                    patternObject["daysOfWeek"] = ExpressionConverter.ConvertO(__workflow_itemrecurrencepatterndaysOfWeek);
                    patternObjectpropCount++;
                }

                if (__workflow_itemrecurrencepatternweekIndex != null)
                {
                    patternObject["index"] = ExpressionConverter.ConvertO(__workflow_itemrecurrencepatternweekIndex);
                    patternObjectpropCount++;
                }

                if (patternObjectpropCount > 0)
                {
                    recurrenceObject["pattern"] = patternObject;
                    recurrenceObjectpropCount++;
                }

                var rangeObject = new JObject();
                var rangeObjectpropCount = 0;
                if (__workflow_itemrecurrencerangerecurrenceStartDate != null)
                {
                    rangeObject["startDate"] = ExpressionConverter.ConvertO(__workflow_itemrecurrencerangerecurrenceStartDate);
                    rangeObjectpropCount++;
                }

                if (__workflow_itemrecurrencerangerecurrenceEndDate != null)
                {
                    rangeObject["endDate"] = ExpressionConverter.ConvertO(__workflow_itemrecurrencerangerecurrenceEndDate);
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

                if (__workflow_itemallDayEvent != null)
                {
                    item["isAllDay"] = ExpressionConverter.ConvertO(__workflow_itemallDayEvent);
                    itempropCount++;
                }

                if (__workflow_itempreEventReminderTime != null)
                {
                    item["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(__workflow_itempreEventReminderTime);
                    itempropCount++;
                }

                if (__workflow_itemenableReminders != null)
                {
                    item["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_itemenableReminders);
                    itempropCount++;
                }

                if (__workflow_itemstatusShowAs != null)
                {
                    item["showAs"] = ExpressionConverter.ConvertO(__workflow_itemstatusShowAs);
                    itempropCount++;
                }

                if (__workflow_itemrequestResponse != null)
                {
                    item["responseRequested"] = ExpressionConverter.ConvertO(__workflow_itemrequestResponse);
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
            });
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
        public IBodyWorkflowAction<GetChannelsForGroupResponse> GetChannelsForGroup(Expression<Func<string>> groupId, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetChannelsForGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
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
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel(Expression<Func<string>> groupId, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetChannelResponse> GetChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_channelId = channelId == null ? null : WorkflowExpression.Compile(channelId);
            WorkflowExpression.Validate(__workflow_channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse> GetAllChannelsForTeam(Expression<Func<string>> groupId, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetAllChannelsForTeamResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/allChannels", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
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
        public IBodyWorkflowAction<GetChatsResponse> GetChats(Expression<Func<chatTypeInput>> chatType, Expression<Func<topicInput>> topic)
        {
            var __workflow_chatType = chatType == null ? null : WorkflowExpression.Compile(chatType);
            WorkflowExpression.Validate(__workflow_chatType, nameof(chatType), required: true);
            var __workflow_topic = topic == null ? null : WorkflowExpression.Compile(topic);
            WorkflowExpression.Validate(__workflow_topic, nameof(topic), required: true);
            return new DeferredBodyAction<GetChatsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flowbot/actions/listchats/chattypes/{0}/topic/{1}/expandmembers/false", ExpressionConverter.ConvertWithUrlEncoding(__workflow_chatType, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topic, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagsResponseSchema> GetTags(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetTagsResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagsResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateTagResponseSchema> CreateTag(Expression<Func<string>> groupId, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodymembersIDs)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodymembersIDs = bodymembersIDs == null ? null : WorkflowExpression.Compile(bodymembersIDs);
            WorkflowExpression.Validate(__workflow_bodymembersIDs, nameof(bodymembersIDs), required: true);
            return new DeferredBodyAction<CreateTagResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembersIDs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTagResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId, Expression<Func<string>> bodyuserSID)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_tagId = tagId == null ? null : WorkflowExpression.Compile(tagId);
            WorkflowExpression.Validate(__workflow_tagId, nameof(tagId), required: true);
            var __workflow_bodyuserSID = bodyuserSID == null ? null : WorkflowExpression.Compile(bodyuserSID);
            WorkflowExpression.Validate(__workflow_bodyuserSID, nameof(bodyuserSID), required: true);
            return new DeferredBodyAction<AddMemberToTagResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserSID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddMemberToTagResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTagMembersResponseSchema> GetTagMembers(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_tagId = tagId == null ? null : WorkflowExpression.Compile(tagId);
            WorkflowExpression.Validate(__workflow_tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<GetTagMembersResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTagMember(Expression<Func<string>> groupId, Expression<Func<string>> tagId, Expression<Func<string>> tagMemberId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_tagId = tagId == null ? null : WorkflowExpression.Compile(tagId);
            WorkflowExpression.Validate(__workflow_tagId, nameof(tagId), required: true);
            var __workflow_tagMemberId = tagMemberId == null ? null : WorkflowExpression.Compile(tagMemberId);
            WorkflowExpression.Validate(__workflow_tagMemberId, nameof(tagMemberId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagMemberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction PostFeedNotification(Expression<Func<posterInput>> poster, Expression<Func<notificationTypeInput>> notificationType, Expression<Func<object>> body = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_notificationType = notificationType == null ? null : WorkflowExpression.Compile(notificationType);
            WorkflowExpression.Validate(__workflow_notificationType, nameof(notificationType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flowbot/feednotification/poster/{0}/notificationType/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_notificationType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionTagResponse> AtMentionTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_tagId = tagId == null ? null : WorkflowExpression.Compile(tagId);
            WorkflowExpression.Validate(__workflow_tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<AtMentionTagResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AtMentionTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction DeleteTag(Expression<Func<string>> groupId, Expression<Func<string>> tagId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_tagId = tagId == null ? null : WorkflowExpression.Compile(tagId);
            WorkflowExpression.Validate(__workflow_tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetMessagesFromChannelResponse> GetMessagesFromChannel(Expression<Func<string>> groupId, Expression<Func<string>> channelId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_channelId = channelId == null ? null : WorkflowExpression.Compile(channelId);
            WorkflowExpression.Validate(__workflow_channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetMessagesFromChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessagesFromChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> GetMessageDetails(Expression<Func<string>> messageId, Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> body = null)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            var __workflow_threadType = threadType == null ? null : WorkflowExpression.Compile(threadType);
            WorkflowExpression.Validate(__workflow_threadType, nameof(threadType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/messages/{0}/messageType/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListRepliesResponseSchema> ListRepliesToMessage(Expression<Func<string>> groupId, Expression<Func<string>> channelId, Expression<Func<string>> messageId, Expression<Func<int>> top = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_channelId = channelId == null ? null : WorkflowExpression.Compile(channelId);
            WorkflowExpression.Validate(__workflow_channelId, nameof(channelId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListRepliesResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/channels/{1}/messages/{2}/replies", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_channelId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(20);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListRepliesResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<ListMembersResponseSchema> ListMembers(Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> body = null)
        {
            var __workflow_threadType = threadType == null ? null : WorkflowExpression.Compile(threadType);
            WorkflowExpression.Validate(__workflow_threadType, nameof(threadType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<ListMembersResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/listmembers/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ListMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction SubscribeUserMessageWithOptions(Expression<Func<object>> userMessageWithOptionsSubscriptionRequest = null)
        {
            var __workflow_userMessageWithOptionsSubscriptionRequest = userMessageWithOptionsSubscriptionRequest == null ? null : WorkflowExpression.Compile(userMessageWithOptionsSubscriptionRequest);
            WorkflowExpression.Validate(__workflow_userMessageWithOptionsSubscriptionRequest, nameof(userMessageWithOptionsSubscriptionRequest), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowbot/actions/messagewithoptions/recipienttypes/user/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_userMessageWithOptionsSubscriptionRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<GetTeamResponse> GetTeam(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<GetTeamResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<AtMentionUserV1> AtMentionUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            return new DeferredBodyAction<AtMentionUserV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AtMentionUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<NewChatResponse> CreateChat(Expression<Func<string>> itemmembersToAdd, Expression<Func<string>> itemtitle = null)
        {
            var __workflow_itemmembersToAdd = itemmembersToAdd == null ? null : WorkflowExpression.Compile(itemmembersToAdd);
            WorkflowExpression.Validate(__workflow_itemmembersToAdd, nameof(itemmembersToAdd), required: true);
            var __workflow_itemtitle = itemtitle == null ? null : WorkflowExpression.Compile(itemtitle);
            WorkflowExpression.Validate(__workflow_itemtitle, nameof(itemtitle), required: false);
            return new DeferredBodyAction<NewChatResponse>(() =>
            {
                var apiCallPath = "/beta/chats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (__workflow_itemtitle != null)
                {
                    item["topic"] = ExpressionConverter.ConvertO(__workflow_itemtitle);
                    itempropCount++;
                }

                itempropCount++;
                item["members"] = ExpressionConverter.ConvertO(__workflow_itemmembersToAdd);
                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<NewChatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<CreateATeamResponse> CreateATeam(Expression<Func<string>> bodyteamName, Expression<Func<string>> bodydescription, Expression<Func<bodyvisibilityInput>> bodyvisibility = null)
        {
            var __workflow_bodyteamName = bodyteamName == null ? null : WorkflowExpression.Compile(bodyteamName);
            WorkflowExpression.Validate(__workflow_bodyteamName, nameof(bodyteamName), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyvisibility = bodyvisibility == null ? null : WorkflowExpression.Compile(bodyvisibility);
            WorkflowExpression.Validate(__workflow_bodyvisibility, nameof(bodyvisibility), required: false);
            return new DeferredBodyAction<CreateATeamResponse>(() =>
            {
                var apiCallPath = "/beta/teams";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyteamName);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (__workflow_bodyvisibility != null)
                {
                    if (__workflow_bodyvisibility != null)
                    {
                        body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IWorkflowAction AddMemberToTeam(Expression<Func<string>> teamId, Expression<Func<string>> bodyuser, Expression<Func<bool>> bodysetUserAsTeamOwner = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_bodyuser = bodyuser == null ? null : WorkflowExpression.Compile(bodyuser);
            WorkflowExpression.Validate(__workflow_bodyuser, nameof(bodyuser), required: true);
            var __workflow_bodysetUserAsTeamOwner = bodysetUserAsTeamOwner == null ? null : WorkflowExpression.Compile(bodysetUserAsTeamOwner);
            WorkflowExpression.Validate(__workflow_bodysetUserAsTeamOwner, nameof(bodysetUserAsTeamOwner), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                if (__workflow_bodysetUserAsTeamOwner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodysetUserAsTeamOwner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> PostMessageToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/conversation/message/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithMessageToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/replyWithMessage/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> PostCardToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/adaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> PostCardAndWaitForResponse(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> bodybodyrecipient = null, Expression<Func<string>> bodybodymessage = null, Expression<Func<string>> bodybodyupdateMessage = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            var __workflow_bodybodyrecipient = bodybodyrecipient == null ? null : WorkflowExpression.Compile(bodybodyrecipient);
            WorkflowExpression.Validate(__workflow_bodybodyrecipient, nameof(bodybodyrecipient), required: false);
            var __workflow_bodybodymessage = bodybodymessage == null ? null : WorkflowExpression.Compile(bodybodymessage);
            WorkflowExpression.Validate(__workflow_bodybodymessage, nameof(bodybodymessage), required: false);
            var __workflow_bodybodyupdateMessage = bodybodyupdateMessage == null ? null : WorkflowExpression.Compile(bodybodyupdateMessage);
            WorkflowExpression.Validate(__workflow_bodybodyupdateMessage, nameof(bodybodyupdateMessage), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/gatherinput/poster/{0}/location/{1}/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodybodyrecipient != null)
                {
                    bodyObject["recipient"] = ExpressionConverter.ConvertO(__workflow_bodybodyrecipient);
                    bodyObjectpropCount++;
                }

                if (__workflow_bodybodymessage != null)
                {
                    bodyObject["messageBody"] = ExpressionConverter.ConvertO(__workflow_bodybodymessage);
                    bodyObjectpropCount++;
                }

                if (__workflow_bodybodyupdateMessage != null)
                {
                    if (__workflow_bodybodyupdateMessage != null)
                    {
                        bodyObject["updateMessage"] = ExpressionConverter.ConvertO(__workflow_bodybodyupdateMessage);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithCardToConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/replyWithAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<PostToConversationResponse> UpdateCardInConversation(Expression<Func<posterInput>> poster, Expression<Func<string>> location, Expression<Func<object>> body = null)
        {
            var __workflow_poster = poster == null ? null : WorkflowExpression.Compile(poster);
            WorkflowExpression.Validate(__workflow_poster, nameof(poster), required: true);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/updateAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_poster, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = uri == null ? null : WorkflowExpression.Compile(uri);
            WorkflowExpression.Validate(__workflow_uri, nameof(uri), required: true);
            var __workflow_method = method == null ? null : WorkflowExpression.Compile(method);
            WorkflowExpression.Validate(__workflow_method, nameof(method), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = customHeader1 == null ? null : WorkflowExpression.Compile(customHeader1);
            WorkflowExpression.Validate(__workflow_customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = customHeader2 == null ? null : WorkflowExpression.Compile(customHeader2);
            WorkflowExpression.Validate(__workflow_customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = customHeader3 == null ? null : WorkflowExpression.Compile(customHeader3);
            WorkflowExpression.Validate(__workflow_customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = customHeader4 == null ? null : WorkflowExpression.Compile(customHeader4);
            WorkflowExpression.Validate(__workflow_customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = customHeader5 == null ? null : WorkflowExpression.Compile(customHeader5);
            WorkflowExpression.Validate(__workflow_customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class TeamsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessage(Expression<Func<string>> groupId, Expression<Func<string>> channelId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_channelId = channelId == null ? null : WorkflowExpression.Compile(channelId);
            WorkflowExpression.Validate(__workflow_channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<OnNewChannelMessageResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessageMentioningMe(Expression<Func<string>> groupId, Expression<Func<string>> channelId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_channelId = channelId == null ? null : WorkflowExpression.Compile(channelId);
            WorkflowExpression.Validate(__workflow_channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<OnNewChannelMessageResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages_mentioningme", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WebhookAtMentionTrigger(Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_threadType = threadType == null ? null : WorkflowExpression.Compile(threadType);
            WorkflowExpression.Validate(__workflow_threadType, nameof(threadType), required: true);
            var __workflow_requestBody = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            WorkflowExpression.Validate(__workflow_requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/atmentiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WebhookMessageReactionTrigger(Expression<Func<string>> reactionKey, Expression<Func<frequencyInput>> frequency, Expression<Func<runningPolicyInput>> runningPolicy, Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_reactionKey = reactionKey == null ? null : WorkflowExpression.Compile(reactionKey);
            WorkflowExpression.Validate(__workflow_reactionKey, nameof(reactionKey), required: true);
            var __workflow_frequency = frequency == null ? null : WorkflowExpression.Compile(frequency);
            WorkflowExpression.Validate(__workflow_frequency, nameof(frequency), required: true);
            var __workflow_runningPolicy = runningPolicy == null ? null : WorkflowExpression.Compile(runningPolicy);
            WorkflowExpression.Validate(__workflow_runningPolicy, nameof(runningPolicy), required: true);
            var __workflow_threadType = threadType == null ? null : WorkflowExpression.Compile(threadType);
            WorkflowExpression.Validate(__workflow_threadType, nameof(threadType), required: true);
            var __workflow_requestBody = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            WorkflowExpression.Validate(__workflow_requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/messagereactiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reactionKey"] = ExpressionConverter.Convert(__workflow_reactionKey);
                callPayload.Queries["frequency"] = ExpressionConverter.Convert(__workflow_frequency);
                callPayload.Queries["runningPolicy"] = ExpressionConverter.Convert(__workflow_runningPolicy);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WebhookChatMessageTrigger(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger WebhookKeywordTrigger(Expression<Func<threadTypeInput>> threadType, Expression<Func<string>> search, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_threadType = threadType == null ? null : WorkflowExpression.Compile(threadType);
            WorkflowExpression.Validate(__workflow_threadType, nameof(threadType), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: true);
            var __workflow_requestBody = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            WorkflowExpression.Validate(__workflow_requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/keywordtrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WebhookNewMessageTrigger(Expression<Func<threadTypeInput>> threadType, Expression<Func<object>> requestBody = null, FlowRecurrence recurrence = null)
        {
            var __workflow_threadType = threadType == null ? null : WorkflowExpression.Compile(threadType);
            WorkflowExpression.Validate(__workflow_threadType, nameof(threadType), required: true);
            var __workflow_requestBody = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            WorkflowExpression.Validate(__workflow_requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/newmessagetrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberRemoved(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberChangeResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/removal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberAdded(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberChangeResponseItem[]>(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum calendaridInput
    {
        Birthdays,
        Calendar,
        [EnumMember(Value = "United States holidays")]
        UnitedStatesHolidays
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum itemimportanceInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
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
