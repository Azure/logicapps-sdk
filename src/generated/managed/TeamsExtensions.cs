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
        [WorkflowExpressionFactory(nameof(__BuildCreateTeamsMeeting))]
        public IBodyWorkflowAction<NewMeetingRespone> CreateTeamsMeeting([WorkflowExpression] Func<calendaridInput> calendarid, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemtimeZone, [WorkflowExpression] Func<string> itembodyeventMessageContent = null, [WorkflowExpression] Func<string> itemstartstartTime = null, [WorkflowExpression] Func<string> itemendendTime = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemlocationdisplayName = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<itemrecurrencepatternrecurrencePatternInput> itemrecurrencepatternrecurrencePattern = null, [WorkflowExpression] Func<int> itemrecurrencepatternrecurrenceInterval = null, [WorkflowExpression] Func<string[]> itemrecurrencepatterndaysOfWeek = null, [WorkflowExpression] Func<itemrecurrencepatternweekIndexInput> itemrecurrencepatternweekIndex = null, [WorkflowExpression] Func<string> itemrecurrencerangerecurrenceStartDate = null, [WorkflowExpression] Func<string> itemrecurrencerangerecurrenceEndDate = null, [WorkflowExpression] Func<bool> itemallDayEvent = null, [WorkflowExpression] Func<int> itempreEventReminderTime = null, [WorkflowExpression] Func<bool> itemenableReminders = null, [WorkflowExpression] Func<itemstatusShowAsInput> itemstatusShowAs = null, [WorkflowExpression] Func<bool> itemrequestResponse = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewMeetingRespone> __BuildCreateTeamsMeeting(WorkflowExpression<calendaridInput> calendarid, WorkflowExpression<string> itemsubject, WorkflowExpression<string> itemtimeZone, WorkflowExpression<string> itembodyeventMessageContent = null, WorkflowExpression<string> itemstartstartTime = null, WorkflowExpression<string> itemendendTime = null, WorkflowExpression<string> itemrequiredAttendees = null, WorkflowExpression<string> itemoptionalAttendees = null, WorkflowExpression<string> itemlocationdisplayName = null, WorkflowExpression<itemimportanceInput> itemimportance = null, WorkflowExpression<itemrecurrencepatternrecurrencePatternInput> itemrecurrencepatternrecurrencePattern = null, WorkflowExpression<int> itemrecurrencepatternrecurrenceInterval = null, WorkflowExpression<string[]> itemrecurrencepatterndaysOfWeek = null, WorkflowExpression<itemrecurrencepatternweekIndexInput> itemrecurrencepatternweekIndex = null, WorkflowExpression<string> itemrecurrencerangerecurrenceStartDate = null, WorkflowExpression<string> itemrecurrencerangerecurrenceEndDate = null, WorkflowExpression<bool> itemallDayEvent = null, WorkflowExpression<int> itempreEventReminderTime = null, WorkflowExpression<bool> itemenableReminders = null, WorkflowExpression<itemstatusShowAsInput> itemstatusShowAs = null, WorkflowExpression<bool> itemrequestResponse = null)
        {
            WorkflowExpression.Validate(calendarid, nameof(calendarid), required: true);
            WorkflowExpression.Validate(itemsubject, nameof(itemsubject), required: true);
            WorkflowExpression.Validate(itemtimeZone, nameof(itemtimeZone), required: true);
            WorkflowExpression.Validate(itembodyeventMessageContent, nameof(itembodyeventMessageContent), required: false);
            WorkflowExpression.Validate(itemstartstartTime, nameof(itemstartstartTime), required: false);
            WorkflowExpression.Validate(itemendendTime, nameof(itemendendTime), required: false);
            WorkflowExpression.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            WorkflowExpression.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            WorkflowExpression.Validate(itemlocationdisplayName, nameof(itemlocationdisplayName), required: false);
            WorkflowExpression.Validate(itemimportance, nameof(itemimportance), required: false);
            WorkflowExpression.Validate(itemrecurrencepatternrecurrencePattern, nameof(itemrecurrencepatternrecurrencePattern), required: false);
            WorkflowExpression.Validate(itemrecurrencepatternrecurrenceInterval, nameof(itemrecurrencepatternrecurrenceInterval), required: false);
            WorkflowExpression.Validate(itemrecurrencepatterndaysOfWeek, nameof(itemrecurrencepatterndaysOfWeek), required: false);
            WorkflowExpression.Validate(itemrecurrencepatternweekIndex, nameof(itemrecurrencepatternweekIndex), required: false);
            WorkflowExpression.Validate(itemrecurrencerangerecurrenceStartDate, nameof(itemrecurrencerangerecurrenceStartDate), required: false);
            WorkflowExpression.Validate(itemrecurrencerangerecurrenceEndDate, nameof(itemrecurrencerangerecurrenceEndDate), required: false);
            WorkflowExpression.Validate(itemallDayEvent, nameof(itemallDayEvent), required: false);
            WorkflowExpression.Validate(itempreEventReminderTime, nameof(itempreEventReminderTime), required: false);
            WorkflowExpression.Validate(itemenableReminders, nameof(itemenableReminders), required: false);
            WorkflowExpression.Validate(itemstatusShowAs, nameof(itemstatusShowAs), required: false);
            WorkflowExpression.Validate(itemrequestResponse, nameof(itemrequestResponse), required: false);
            return new DeferredBodyAction<NewMeetingRespone>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/me/calendars/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(calendarid, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildGetChannelsForGroup))]
        public IBodyWorkflowAction<GetChannelsForGroupResponse> GetChannelsForGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChannelsForGroupResponse> __BuildGetChannelsForGroup(WorkflowExpression<string> groupId, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetChannelsForGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                return new ApiConnectionAction<GetChannelsForGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChannel))]
        public IBodyWorkflowAction<CreateChannelResponse> CreateChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateChannelResponse> __BuildCreateChannel(WorkflowExpression<string> groupId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/groups/{0}/channels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetChannel))]
        public IBodyWorkflowAction<GetChannelResponse> GetChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChannelResponse> __BuildGetChannel(WorkflowExpression<string> groupId, WorkflowExpression<string> channelId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllChannelsForTeam))]
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse> GetAllChannelsForTeam([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllChannelsForTeamResponse> __BuildGetAllChannelsForTeam(WorkflowExpression<string> groupId, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<GetAllChannelsForTeamResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/allChannels", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                return new ApiConnectionAction<GetAllChannelsForTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetChats))]
        public IBodyWorkflowAction<GetChatsResponse> GetChats([WorkflowExpression] Func<chatTypeInput> chatType, [WorkflowExpression] Func<topicInput> topic)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChatsResponse> __BuildGetChats(WorkflowExpression<chatTypeInput> chatType, WorkflowExpression<topicInput> topic)
        {
            WorkflowExpression.Validate(chatType, nameof(chatType), required: true);
            WorkflowExpression.Validate(topic, nameof(topic), required: true);
            return new DeferredBodyAction<GetChatsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flowbot/actions/listchats/chattypes/{0}/topic/{1}/expandmembers/false", ExpressionConverter.ConvertWithUrlEncoding(chatType, 1), ExpressionConverter.ConvertWithUrlEncoding(topic, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetTags))]
        public IBodyWorkflowAction<GetTagsResponseSchema> GetTags([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTagsResponseSchema> __BuildGetTags(WorkflowExpression<string> groupId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetTagsResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagsResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTag))]
        public IBodyWorkflowAction<CreateTagResponseSchema> CreateTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodymembersIDs)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTagResponseSchema> __BuildCreateTag(WorkflowExpression<string> groupId, WorkflowExpression<string> bodydisplayName, WorkflowExpression<string> bodymembersIDs)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            WorkflowExpression.Validate(bodymembersIDs, nameof(bodymembersIDs), required: true);
            return new DeferredBodyAction<CreateTagResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildAddMemberToTag))]
        public IBodyWorkflowAction<AddMemberToTagResponseSchema> AddMemberToTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyuserSID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddMemberToTagResponseSchema> __BuildAddMemberToTag(WorkflowExpression<string> groupId, WorkflowExpression<string> tagId, WorkflowExpression<string> bodyuserSID)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            WorkflowExpression.Validate(bodyuserSID, nameof(bodyuserSID), required: true);
            return new DeferredBodyAction<AddMemberToTagResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetTagMembers))]
        public IBodyWorkflowAction<GetTagMembersResponseSchema> GetTagMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTagMembersResponseSchema> __BuildGetTagMembers(WorkflowExpression<string> groupId, WorkflowExpression<string> tagId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<GetTagMembersResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTagMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTagMember))]
        public IWorkflowAction DeleteTagMember([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> tagMemberId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTagMember(WorkflowExpression<string> groupId, WorkflowExpression<string> tagId, WorkflowExpression<string> tagMemberId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            WorkflowExpression.Validate(tagMemberId, nameof(tagMemberId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagMemberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildPostFeedNotification))]
        public IWorkflowAction PostFeedNotification([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<notificationTypeInput> notificationType, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostFeedNotification(WorkflowExpression<posterInput> poster, WorkflowExpression<notificationTypeInput> notificationType, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(notificationType, nameof(notificationType), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flowbot/feednotification/poster/{0}/notificationType/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(notificationType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildAtMentionTag))]
        public IBodyWorkflowAction<AtMentionTagResponse> AtMentionTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AtMentionTagResponse> __BuildAtMentionTag(WorkflowExpression<string> groupId, WorkflowExpression<string> tagId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<AtMentionTagResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AtMentionTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTag))]
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTag(WorkflowExpression<string> groupId, WorkflowExpression<string> tagId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromChannel))]
        public IBodyWorkflowAction<GetMessagesFromChannelResponse> GetMessagesFromChannel([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesFromChannelResponse> __BuildGetMessagesFromChannel(WorkflowExpression<string> groupId, WorkflowExpression<string> channelId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetMessagesFromChannelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessagesFromChannelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessageDetails))]
        public IBodyWorkflowAction<JToken> GetMessageDetails([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetMessageDetails(WorkflowExpression<string> messageId, WorkflowExpression<threadTypeInput> threadType, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(threadType, nameof(threadType), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/messages/{0}/messageType/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildListRepliesToMessage))]
        public IBodyWorkflowAction<ListRepliesResponseSchema> ListRepliesToMessage([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> channelId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRepliesResponseSchema> __BuildListRepliesToMessage(WorkflowExpression<string> groupId, WorkflowExpression<string> channelId, WorkflowExpression<string> messageId, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListRepliesResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/channels/{1}/messages/{2}/replies", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(20);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ListRepliesResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildListMembers))]
        public IBodyWorkflowAction<ListMembersResponseSchema> ListMembers([WorkflowExpression] Func<threadTypeInput> threadType, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListMembersResponseSchema> __BuildListMembers(WorkflowExpression<threadTypeInput> threadType, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(threadType, nameof(threadType), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<ListMembersResponseSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/listmembers/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<ListMembersResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildSubscribeUserMessageWithOptions))]
        public IWorkflowAction SubscribeUserMessageWithOptions([WorkflowExpression] Func<object> userMessageWithOptionsSubscriptionRequest = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubscribeUserMessageWithOptions(WorkflowExpression<object> userMessageWithOptionsSubscriptionRequest = null)
        {
            WorkflowExpression.Validate(userMessageWithOptionsSubscriptionRequest, nameof(userMessageWithOptionsSubscriptionRequest), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowbot/actions/messagewithoptions/recipienttypes/user/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(userMessageWithOptionsSubscriptionRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildGetTeam))]
        public IBodyWorkflowAction<GetTeamResponse> GetTeam([WorkflowExpression] Func<string> teamId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTeamResponse> __BuildGetTeam(WorkflowExpression<string> teamId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<GetTeamResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildAtMentionUser))]
        public IBodyWorkflowAction<AtMentionUserV1> AtMentionUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AtMentionUserV1> __BuildAtMentionUser(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<AtMentionUserV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AtMentionUserV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChat))]
        public IBodyWorkflowAction<NewChatResponse> CreateChat([WorkflowExpression] Func<string> itemmembersToAdd, [WorkflowExpression] Func<string> itemtitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewChatResponse> __BuildCreateChat(WorkflowExpression<string> itemmembersToAdd, WorkflowExpression<string> itemtitle = null)
        {
            WorkflowExpression.Validate(itemmembersToAdd, nameof(itemmembersToAdd), required: true);
            WorkflowExpression.Validate(itemtitle, nameof(itemtitle), required: false);
            return new DeferredBodyAction<NewChatResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildCreateATeam))]
        public IBodyWorkflowAction<CreateATeamResponse> CreateATeam([WorkflowExpression] Func<string> bodyteamName, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateATeamResponse> __BuildCreateATeam(WorkflowExpression<string> bodyteamName, WorkflowExpression<string> bodydescription, WorkflowExpression<bodyvisibilityInput> bodyvisibility = null)
        {
            WorkflowExpression.Validate(bodyteamName, nameof(bodyteamName), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowExpression.Validate(bodyvisibility, nameof(bodyvisibility), required: false);
            return new DeferredBodyAction<CreateATeamResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildAddMemberToTeam))]
        public IWorkflowAction AddMemberToTeam([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodysetUserAsTeamOwner = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddMemberToTeam(WorkflowExpression<string> teamId, WorkflowExpression<string> bodyuser, WorkflowExpression<bool> bodysetUserAsTeamOwner = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(bodyuser, nameof(bodyuser), required: true);
            WorkflowExpression.Validate(bodysetUserAsTeamOwner, nameof(bodysetUserAsTeamOwner), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildPostMessageToConversation))]
        public IBodyWorkflowAction<PostToConversationResponse> PostMessageToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostToConversationResponse> __BuildPostMessageToConversation(WorkflowExpression<posterInput> poster, WorkflowExpression<string> location, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/teams/conversation/message/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildReplyWithMessageToConversation))]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithMessageToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostToConversationResponse> __BuildReplyWithMessageToConversation(WorkflowExpression<posterInput> poster, WorkflowExpression<string> location, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/replyWithMessage/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildPostCardToConversation))]
        public IBodyWorkflowAction<PostToConversationResponse> PostCardToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostToConversationResponse> __BuildPostCardToConversation(WorkflowExpression<posterInput> poster, WorkflowExpression<string> location, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/adaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildPostCardAndWaitForResponse))]
        public IBodyWorkflowAction<JToken> PostCardAndWaitForResponse([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> bodybodyrecipient = null, [WorkflowExpression] Func<string> bodybodymessage = null, [WorkflowExpression] Func<string> bodybodyupdateMessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostCardAndWaitForResponse(WorkflowExpression<posterInput> poster, WorkflowExpression<string> location, WorkflowExpression<object> bodybodyrecipient = null, WorkflowExpression<string> bodybodymessage = null, WorkflowExpression<string> bodybodyupdateMessage = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(bodybodyrecipient, nameof(bodybodyrecipient), required: false);
            WorkflowExpression.Validate(bodybodymessage, nameof(bodybodymessage), required: false);
            WorkflowExpression.Validate(bodybodyupdateMessage, nameof(bodybodyupdateMessage), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/gatherinput/poster/{0}/location/{1}/$subscriptions", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildReplyWithCardToConversation))]
        public IBodyWorkflowAction<PostToConversationResponse> ReplyWithCardToConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostToConversationResponse> __BuildReplyWithCardToConversation(WorkflowExpression<posterInput> poster, WorkflowExpression<string> location, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/replyWithAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCardInConversation))]
        public IBodyWorkflowAction<PostToConversationResponse> UpdateCardInConversation([WorkflowExpression] Func<posterInput> poster, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostToConversationResponse> __BuildUpdateCardInConversation(WorkflowExpression<posterInput> poster, WorkflowExpression<string> location, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(poster, nameof(poster), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PostToConversationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/conversation/updateAdaptivecard/poster/{0}/location/{1}", ExpressionConverter.ConvertWithUrlEncoding(poster, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PostToConversationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teams")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowExpression<string> uri, WorkflowExpression<methodInput> method, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null, WorkflowExpression<string> customHeader1 = null, WorkflowExpression<string> customHeader2 = null, WorkflowExpression<string> customHeader3 = null, WorkflowExpression<string> customHeader4 = null, WorkflowExpression<string> customHeader5 = null)
        {
            WorkflowExpression.Validate(uri, nameof(uri), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            WorkflowExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            WorkflowExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            WorkflowExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            WorkflowExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }
    }

    public class TeamsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewChannelMessage))]
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessage([WorkflowExpression] Func<string> groupId,[WorkflowExpression] Func<string> channelId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> __BuildOnNewChannelMessage(WorkflowExpression<string> groupId,WorkflowExpression<string> channelId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<OnNewChannelMessageResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewChannelMessageMentioningMe))]
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> OnNewChannelMessageMentioningMe([WorkflowExpression] Func<string> groupId,[WorkflowExpression] Func<string> channelId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewChannelMessageResponseItem[]> __BuildOnNewChannelMessageMentioningMe(WorkflowExpression<string> groupId,WorkflowExpression<string> channelId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(channelId, nameof(channelId), required: true);
            return new DeferredBodyTrigger<OnNewChannelMessageResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/beta/teams/{0}/channels/{1}/messages_mentioningme", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(channelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(50);
                return new ApiConnectionTrigger<OnNewChannelMessageResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookAtMentionTrigger))]
        public IWorkflowTrigger WebhookAtMentionTrigger([WorkflowExpression] Func<threadTypeInput> threadType,[WorkflowExpression] Func<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookAtMentionTrigger(WorkflowExpression<threadTypeInput> threadType,WorkflowExpression<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(threadType, nameof(threadType), required: true);
            WorkflowExpression.Validate(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/atmentiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookMessageReactionTrigger))]
        public IWorkflowTrigger WebhookMessageReactionTrigger([WorkflowExpression] Func<string> reactionKey,[WorkflowExpression] Func<frequencyInput> frequency,[WorkflowExpression] Func<runningPolicyInput> runningPolicy,[WorkflowExpression] Func<threadTypeInput> threadType,[WorkflowExpression] Func<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookMessageReactionTrigger(WorkflowExpression<string> reactionKey,WorkflowExpression<frequencyInput> frequency,WorkflowExpression<runningPolicyInput> runningPolicy,WorkflowExpression<threadTypeInput> threadType,WorkflowExpression<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(reactionKey, nameof(reactionKey), required: true);
            WorkflowExpression.Validate(frequency, nameof(frequency), required: true);
            WorkflowExpression.Validate(runningPolicy, nameof(runningPolicy), required: true);
            WorkflowExpression.Validate(threadType, nameof(threadType), required: true);
            WorkflowExpression.Validate(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/messagereactiontrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reactionKey"] = ExpressionConverter.Convert(reactionKey);
                callPayload.Queries["frequency"] = ExpressionConverter.Convert(frequency);
                callPayload.Queries["runningPolicy"] = ExpressionConverter.Convert(runningPolicy);
                callPayload.Body = ExpressionConverter.ConvertO(requestBody);
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

        [WorkflowExpressionFactory(nameof(__BuildWebhookKeywordTrigger))]
        public IWorkflowTrigger WebhookKeywordTrigger([WorkflowExpression] Func<threadTypeInput> threadType,[WorkflowExpression] Func<string> search,[WorkflowExpression] Func<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookKeywordTrigger(WorkflowExpression<threadTypeInput> threadType,WorkflowExpression<string> search,WorkflowExpression<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(threadType, nameof(threadType), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: true);
            WorkflowExpression.Validate(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/keywordtrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
                callPayload.Body = ExpressionConverter.ConvertO(requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookNewMessageTrigger))]
        public IWorkflowTrigger WebhookNewMessageTrigger([WorkflowExpression] Func<threadTypeInput> threadType,[WorkflowExpression] Func<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildWebhookNewMessageTrigger(WorkflowExpression<threadTypeInput> threadType,WorkflowExpression<object> requestBody = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(threadType, nameof(threadType), required: true);
            WorkflowExpression.Validate(requestBody, nameof(requestBody), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/subscriptions/newmessagetrigger/threadType/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(requestBody);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTeamMemberRemoved))]
        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberRemoved([WorkflowExpression] Func<string> groupId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> __BuildOnTeamMemberRemoved(WorkflowExpression<string> groupId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberChangeResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/removal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberChangeResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTeamMemberAdded))]
        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> OnTeamMemberAdded([WorkflowExpression] Func<string> groupId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnGroupMemberChangeResponseItem[]> __BuildOnTeamMemberAdded(WorkflowExpression<string> groupId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberChangeResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/delta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
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