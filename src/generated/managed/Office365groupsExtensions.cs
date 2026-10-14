//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365groups
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Office365groupsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupMembersResponse> ListGroupMembers(Expression<Func<string>> groupId, Expression<Func<int>> top = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListGroupMembersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction AddMemberToGroup(Expression<Func<string>> groupId, Expression<Func<string>> userUpn)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_userUpn = userUpn == null ? null : WorkflowExpression.Compile(userUpn);
            WorkflowExpression.Validate(__workflow_userUpn, nameof(userUpn), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members/$ref", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = ExpressionConverter.Convert(__workflow_userUpn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListOwnedGroupsResponse> ListOwnedGroups()
        {
            var apiCallPath = "/v1.0/me/memberOf/$/microsoft.graph.group";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListOwnedGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListGroups(Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_extractSensitivityLabel = extractSensitivityLabel == null ? null : WorkflowExpression.Compile(extractSensitivityLabel);
            WorkflowExpression.Validate(__workflow_extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = fetchSensitivityLabelMetadata == null ? null : WorkflowExpression.Compile(fetchSensitivityLabelMetadata);
            WorkflowExpression.Validate(__workflow_fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ListGroupsResponse>(() =>
            {
                var apiCallPath = "/v1.0/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse> UpdateCalendarEvent(Expression<Func<string>> groupId, Expression<Func<string>> @event, Expression<Func<string>> bodysubject, Expression<Func<string>> bodystartstartTime = null, Expression<Func<string>> bodyendendTime = null, Expression<Func<string>> bodybodybody = null, Expression<Func<string>> bodylocationlocation = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisReminderOn = null, Expression<Func<int>> bodyreminderStartDuration = null, Expression<Func<bodyshowAsInput>> bodyshowAs = null, Expression<Func<bool>> bodyresponseRequested = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_event = @event == null ? null : WorkflowExpression.Compile(@event);
            WorkflowExpression.Validate(__workflow_event, nameof(@event), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodystartstartTime = bodystartstartTime == null ? null : WorkflowExpression.Compile(bodystartstartTime);
            WorkflowExpression.Validate(__workflow_bodystartstartTime, nameof(bodystartstartTime), required: false);
            var __workflow_bodyendendTime = bodyendendTime == null ? null : WorkflowExpression.Compile(bodyendendTime);
            WorkflowExpression.Validate(__workflow_bodyendendTime, nameof(bodyendendTime), required: false);
            var __workflow_bodybodybody = bodybodybody == null ? null : WorkflowExpression.Compile(bodybodybody);
            WorkflowExpression.Validate(__workflow_bodybodybody, nameof(bodybodybody), required: false);
            var __workflow_bodylocationlocation = bodylocationlocation == null ? null : WorkflowExpression.Compile(bodylocationlocation);
            WorkflowExpression.Validate(__workflow_bodylocationlocation, nameof(bodylocationlocation), required: false);
            var __workflow_bodyimportance = bodyimportance == null ? null : WorkflowExpression.Compile(bodyimportance);
            WorkflowExpression.Validate(__workflow_bodyimportance, nameof(bodyimportance), required: false);
            var __workflow_bodyisAllDay = bodyisAllDay == null ? null : WorkflowExpression.Compile(bodyisAllDay);
            WorkflowExpression.Validate(__workflow_bodyisAllDay, nameof(bodyisAllDay), required: false);
            var __workflow_bodyisReminderOn = bodyisReminderOn == null ? null : WorkflowExpression.Compile(bodyisReminderOn);
            WorkflowExpression.Validate(__workflow_bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            var __workflow_bodyreminderStartDuration = bodyreminderStartDuration == null ? null : WorkflowExpression.Compile(bodyreminderStartDuration);
            WorkflowExpression.Validate(__workflow_bodyreminderStartDuration, nameof(bodyreminderStartDuration), required: false);
            var __workflow_bodyshowAs = bodyshowAs == null ? null : WorkflowExpression.Compile(bodyshowAs);
            WorkflowExpression.Validate(__workflow_bodyshowAs, nameof(bodyshowAs), required: false);
            var __workflow_bodyresponseRequested = bodyresponseRequested == null ? null : WorkflowExpression.Compile(bodyresponseRequested);
            WorkflowExpression.Validate(__workflow_bodyresponseRequested, nameof(bodyresponseRequested), required: false);
            return new DeferredBodyAction<CreateCalendarEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_event, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartstartTime != null)
                {
                    startObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodystartstartTime);
                    startObjectpropCount++;
                }

                startObject["timeZone"] = "UTC";
                startObjectpropCount++;
                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendendTime != null)
                {
                    endObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodyendendTime);
                    endObjectpropCount++;
                }

                endObject["timeZone"] = "UTC";
                endObjectpropCount++;
                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodybodybody != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(__workflow_bodybodybody);
                    bodyObjectpropCount++;
                }

                bodyObject["contentType"] = "Html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodylocationlocation != null)
                {
                    locationObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodylocationlocation);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (__workflow_bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(__workflow_bodyimportance);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllDay != null)
                {
                    body["isAllDay"] = ExpressionConverter.ConvertO(__workflow_bodyisAllDay);
                    bodypropCount++;
                }

                if (__workflow_bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_bodyisReminderOn);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderStartDuration != null)
                {
                    body["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(__workflow_bodyreminderStartDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyshowAs != null)
                {
                    body["showAs"] = ExpressionConverter.ConvertO(__workflow_bodyshowAs);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseRequested != null)
                {
                    body["responseRequested"] = ExpressionConverter.ConvertO(__workflow_bodyresponseRequested);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCalendarEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction RemoveMemberFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> userUpn)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_userUpn = userUpn == null ? null : WorkflowExpression.Compile(userUpn);
            WorkflowExpression.Validate(__workflow_userUpn, nameof(userUpn), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members/memberId/$ref", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = ExpressionConverter.Convert(__workflow_userUpn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListDeletedGroups()
        {
            var apiCallPath = "/v1.0/directory/deletedItems/microsoft.graph.group";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction RestoreDeletedGroup(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/directory/deletedItems/{0}/restore", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListDeletedGroupsByOwner(Expression<Func<string>> userId)
        {
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            return new DeferredBodyAction<ListGroupsResponse>(() =>
            {
                var apiCallPath = "/v1.0/directory/deletedItems/getUserOwnedObjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["userId"] = ExpressionConverter.Convert(__workflow_userId);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction CalendarDeleteItem(Expression<Func<string>> groupId, Expression<Func<string>> @event)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_event = @event == null ? null : WorkflowExpression.Compile(@event);
            WorkflowExpression.Validate(__workflow_event, nameof(@event), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_event, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse> CreateCalendarEvent(Expression<Func<string>> groupId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodystartstartTime = null, Expression<Func<string>> bodyendendTime = null, Expression<Func<string>> bodybodybody = null, Expression<Func<string>> bodylocationlocation = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisReminderOn = null, Expression<Func<int>> bodyreminderStartDuration = null, Expression<Func<bodyshowAsInput>> bodyshowAs = null, Expression<Func<bool>> bodyresponseRequested = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodystartstartTime = bodystartstartTime == null ? null : WorkflowExpression.Compile(bodystartstartTime);
            WorkflowExpression.Validate(__workflow_bodystartstartTime, nameof(bodystartstartTime), required: false);
            var __workflow_bodyendendTime = bodyendendTime == null ? null : WorkflowExpression.Compile(bodyendendTime);
            WorkflowExpression.Validate(__workflow_bodyendendTime, nameof(bodyendendTime), required: false);
            var __workflow_bodybodybody = bodybodybody == null ? null : WorkflowExpression.Compile(bodybodybody);
            WorkflowExpression.Validate(__workflow_bodybodybody, nameof(bodybodybody), required: false);
            var __workflow_bodylocationlocation = bodylocationlocation == null ? null : WorkflowExpression.Compile(bodylocationlocation);
            WorkflowExpression.Validate(__workflow_bodylocationlocation, nameof(bodylocationlocation), required: false);
            var __workflow_bodyimportance = bodyimportance == null ? null : WorkflowExpression.Compile(bodyimportance);
            WorkflowExpression.Validate(__workflow_bodyimportance, nameof(bodyimportance), required: false);
            var __workflow_bodyisAllDay = bodyisAllDay == null ? null : WorkflowExpression.Compile(bodyisAllDay);
            WorkflowExpression.Validate(__workflow_bodyisAllDay, nameof(bodyisAllDay), required: false);
            var __workflow_bodyisReminderOn = bodyisReminderOn == null ? null : WorkflowExpression.Compile(bodyisReminderOn);
            WorkflowExpression.Validate(__workflow_bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            var __workflow_bodyreminderStartDuration = bodyreminderStartDuration == null ? null : WorkflowExpression.Compile(bodyreminderStartDuration);
            WorkflowExpression.Validate(__workflow_bodyreminderStartDuration, nameof(bodyreminderStartDuration), required: false);
            var __workflow_bodyshowAs = bodyshowAs == null ? null : WorkflowExpression.Compile(bodyshowAs);
            WorkflowExpression.Validate(__workflow_bodyshowAs, nameof(bodyshowAs), required: false);
            var __workflow_bodyresponseRequested = bodyresponseRequested == null ? null : WorkflowExpression.Compile(bodyresponseRequested);
            WorkflowExpression.Validate(__workflow_bodyresponseRequested, nameof(bodyresponseRequested), required: false);
            return new DeferredBodyAction<CreateCalendarEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/groups/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartstartTime != null)
                {
                    startObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodystartstartTime);
                    startObjectpropCount++;
                }

                startObject["timeZone"] = "UTC";
                startObjectpropCount++;
                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendendTime != null)
                {
                    endObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodyendendTime);
                    endObjectpropCount++;
                }

                endObject["timeZone"] = "UTC";
                endObjectpropCount++;
                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodybodybody != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(__workflow_bodybodybody);
                    bodyObjectpropCount++;
                }

                bodyObject["contentType"] = "Html";
                bodyObjectpropCount++;
                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodylocationlocation != null)
                {
                    locationObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodylocationlocation);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (__workflow_bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(__workflow_bodyimportance);
                    bodypropCount++;
                }

                if (__workflow_bodyisAllDay != null)
                {
                    body["isAllDay"] = ExpressionConverter.ConvertO(__workflow_bodyisAllDay);
                    bodypropCount++;
                }

                if (__workflow_bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_bodyisReminderOn);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderStartDuration != null)
                {
                    body["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(__workflow_bodyreminderStartDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyshowAs != null)
                {
                    body["showAs"] = ExpressionConverter.ConvertO(__workflow_bodyshowAs);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseRequested != null)
                {
                    body["responseRequested"] = ExpressionConverter.ConvertO(__workflow_bodyresponseRequested);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCalendarEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
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
                var apiCallPath = "/v2/httprequest";
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

    public class Office365groupsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnGroupMemberAddedOrRemovedResponseItem[]> OnGroupMembershipChange(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/delta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnNewEventResponseItem[]> OnNewEvent(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = groupId == null ? null : WorkflowExpression.Compile(groupId);
            WorkflowExpression.Validate(__workflow_groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnNewEventResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v1.0/groups/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnNewEventResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ListGroupMembersResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public ListGroupMembersResponseValueTypeItem[] Value { get; set; }
    }

    public class ListGroupMembersResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class ListOwnedGroupsResponse
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        [JsonProperty("value")]
        public ListOwnedGroupsResponseValueTypeItem[] Value { get; set; }
    }

    public class ListOwnedGroupsResponseValueTypeItem
    {
        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("mailEnabled")]
        public bool MailEnabled { get; set; }

        [JsonProperty("mailNickname")]
        public string Nickname { get; set; }

        [JsonProperty("onPremisesLastSyncDateTime")]
        public string OnPremisesLastSyncDateTime { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("onPremisesSyncEnabled")]
        public string OnPremisesSyncEnabled { get; set; }

        [JsonProperty("renewedDateTime")]
        public string RenewedDateTime { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    public class ListGroupsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public ListGroupsResponseValueTypeItem[] Value { get; set; }
    }

    public class ListGroupsResponseValueTypeItem
    {
        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("mailEnabled")]
        public bool MailEnabled { get; set; }

        [JsonProperty("mailNickname")]
        public string Nickname { get; set; }

        [JsonProperty("onPremisesLastSyncDateTime")]
        public string OnPremisesLastSyncDateTime { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("onPremisesSyncEnabled")]
        public bool OnPremisesSyncEnabled { get; set; }

        [JsonProperty("renewedDateTime")]
        public string RenewedDateTime { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class CreateCalendarEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderStartDuration { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDay { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("showAs")]
        public string ShowAs { get; set; }

        [JsonProperty("body")]
        public CreateCalendarEventResponseBodyType Body { get; set; }

        [JsonProperty("start")]
        public CreateCalendarEventResponseStartType Start { get; set; }

        [JsonProperty("end")]
        public CreateCalendarEventResponseEndType End { get; set; }

        [JsonProperty("location")]
        public CreateCalendarEventResponseLocationType Location { get; set; }
    }

    public class CreateCalendarEventResponseBodyType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class CreateCalendarEventResponseStartType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class CreateCalendarEventResponseEndType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class CreateCalendarEventResponseLocationType
    {
        [JsonProperty("displayName")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyimportanceInput
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyshowAsInput
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
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

    public class OnGroupMemberAddedOrRemovedResponseItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("@removed")]
        public OnGroupMemberAddedOrRemovedResponseItemRemovedType Removed { get; set; }
    }

    public class OnGroupMemberAddedOrRemovedResponseItemRemovedType
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class OnNewEventResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderStartDuration { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDay { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("showAs")]
        public string ShowAs { get; set; }

        [JsonProperty("body")]
        public OnNewEventResponseItemBodyType Body { get; set; }

        [JsonProperty("start")]
        public OnNewEventResponseItemStartType Start { get; set; }

        [JsonProperty("end")]
        public OnNewEventResponseItemEndType End { get; set; }

        [JsonProperty("location")]
        public OnNewEventResponseItemLocationType Location { get; set; }
    }

    public class OnNewEventResponseItemBodyType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class OnNewEventResponseItemStartType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class OnNewEventResponseItemEndType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class OnNewEventResponseItemLocationType
    {
        [JsonProperty("displayName")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365groups;

    public partial class WorkflowManagedActions
    {
        public Office365groupsActions Office365groups(string connectionId) => new Office365groupsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Office365groupsTriggers Office365groups(string connectionId) => new Office365groupsTriggers(connectionId);
    }
}
