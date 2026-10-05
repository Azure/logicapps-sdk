//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365groups
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365groupsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        [WorkflowExpressionFactory(nameof(__BuildListGroupMembers))]
        public IBodyWorkflowAction<ListGroupMembersResponse> ListGroupMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGroupMembersResponse> __BuildListGroupMembers(WorkflowValue<string> groupId, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListGroupMembersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ListGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        [WorkflowExpressionFactory(nameof(__BuildAddMemberToGroup))]
        public IWorkflowAction AddMemberToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> userUpn)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddMemberToGroup(WorkflowValue<string> groupId, WorkflowValue<string> userUpn)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(userUpn, nameof(userUpn), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members/$ref", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = ExpressionConverter.Convert(userUpn);
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
        [WorkflowExpressionFactory(nameof(__BuildListGroups))]
        public IBodyWorkflowAction<ListGroupsResponse> ListGroups([WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGroupsResponse> __BuildListGroups(WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<bool> fetchSensitivityLabelMetadata = null, WorkflowValue<string> filter = null, WorkflowValue<int> top = null, WorkflowValue<string> skiptoken = null)
        {
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ListGroupsResponse>(() =>
            {
                var apiCallPath = "/v1.0/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCalendarEvent))]
        public IBodyWorkflowAction<CreateCalendarEventResponse> UpdateCalendarEvent([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> @event, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodystartstartTime = null, [WorkflowExpression] Func<string> bodyendendTime = null, [WorkflowExpression] Func<string> bodybodybody = null, [WorkflowExpression] Func<string> bodylocationlocation = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<bool> bodyisAllDay = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null, [WorkflowExpression] Func<int> bodyreminderStartDuration = null, [WorkflowExpression] Func<bodyshowAsInput> bodyshowAs = null, [WorkflowExpression] Func<bool> bodyresponseRequested = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCalendarEventResponse> __BuildUpdateCalendarEvent(WorkflowValue<string> groupId, WorkflowValue<string> @event, WorkflowValue<string> bodysubject, WorkflowValue<string> bodystartstartTime = null, WorkflowValue<string> bodyendendTime = null, WorkflowValue<string> bodybodybody = null, WorkflowValue<string> bodylocationlocation = null, WorkflowValue<bodyimportanceInput> bodyimportance = null, WorkflowValue<bool> bodyisAllDay = null, WorkflowValue<bool> bodyisReminderOn = null, WorkflowValue<int> bodyreminderStartDuration = null, WorkflowValue<bodyshowAsInput> bodyshowAs = null, WorkflowValue<bool> bodyresponseRequested = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(@event, nameof(@event), required: true);
            WorkflowValue.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowValue.Validate(bodystartstartTime, nameof(bodystartstartTime), required: false);
            WorkflowValue.Validate(bodyendendTime, nameof(bodyendendTime), required: false);
            WorkflowValue.Validate(bodybodybody, nameof(bodybodybody), required: false);
            WorkflowValue.Validate(bodylocationlocation, nameof(bodylocationlocation), required: false);
            WorkflowValue.Validate(bodyimportance, nameof(bodyimportance), required: false);
            WorkflowValue.Validate(bodyisAllDay, nameof(bodyisAllDay), required: false);
            WorkflowValue.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            WorkflowValue.Validate(bodyreminderStartDuration, nameof(bodyreminderStartDuration), required: false);
            WorkflowValue.Validate(bodyshowAs, nameof(bodyshowAs), required: false);
            WorkflowValue.Validate(bodyresponseRequested, nameof(bodyresponseRequested), required: false);
            return new DeferredBodyAction<CreateCalendarEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartstartTime != null)
                {
                    startObject["dateTime"] = ExpressionConverter.ConvertO(bodystartstartTime);
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
                if (bodyendendTime != null)
                {
                    endObject["dateTime"] = ExpressionConverter.ConvertO(bodyendendTime);
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
                if (bodybodybody != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(bodybodybody);
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
                if (bodylocationlocation != null)
                {
                    locationObject["displayName"] = ExpressionConverter.ConvertO(bodylocationlocation);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(bodyimportance);
                    bodypropCount++;
                }

                if (bodyisAllDay != null)
                {
                    body["isAllDay"] = ExpressionConverter.ConvertO(bodyisAllDay);
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodyreminderStartDuration != null)
                {
                    body["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(bodyreminderStartDuration);
                    bodypropCount++;
                }

                if (bodyshowAs != null)
                {
                    body["showAs"] = ExpressionConverter.ConvertO(bodyshowAs);
                    bodypropCount++;
                }

                if (bodyresponseRequested != null)
                {
                    body["responseRequested"] = ExpressionConverter.ConvertO(bodyresponseRequested);
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
        [WorkflowExpressionFactory(nameof(__BuildRemoveMemberFromGroup))]
        public IWorkflowAction RemoveMemberFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> userUpn)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveMemberFromGroup(WorkflowValue<string> groupId, WorkflowValue<string> userUpn)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(userUpn, nameof(userUpn), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members/memberId/$ref", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = ExpressionConverter.Convert(userUpn);
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
        [WorkflowExpressionFactory(nameof(__BuildRestoreDeletedGroup))]
        public IWorkflowAction RestoreDeletedGroup([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRestoreDeletedGroup(WorkflowValue<string> groupId)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/directory/deletedItems/{0}/restore", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        [WorkflowExpressionFactory(nameof(__BuildListDeletedGroupsByOwner))]
        public IBodyWorkflowAction<ListGroupsResponse> ListDeletedGroupsByOwner([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGroupsResponse> __BuildListDeletedGroupsByOwner(WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ListGroupsResponse>(() =>
            {
                var apiCallPath = "/v1.0/directory/deletedItems/getUserOwnedObjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["userId"] = ExpressionConverter.Convert(userId);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarDeleteItem))]
        public IWorkflowAction CalendarDeleteItem([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> @event)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCalendarDeleteItem(WorkflowValue<string> groupId, WorkflowValue<string> @event)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(@event, nameof(@event), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCalendarEvent))]
        public IBodyWorkflowAction<CreateCalendarEventResponse> CreateCalendarEvent([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodystartstartTime = null, [WorkflowExpression] Func<string> bodyendendTime = null, [WorkflowExpression] Func<string> bodybodybody = null, [WorkflowExpression] Func<string> bodylocationlocation = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<bool> bodyisAllDay = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null, [WorkflowExpression] Func<int> bodyreminderStartDuration = null, [WorkflowExpression] Func<bodyshowAsInput> bodyshowAs = null, [WorkflowExpression] Func<bool> bodyresponseRequested = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCalendarEventResponse> __BuildCreateCalendarEvent(WorkflowValue<string> groupId, WorkflowValue<string> bodysubject, WorkflowValue<string> bodystartstartTime = null, WorkflowValue<string> bodyendendTime = null, WorkflowValue<string> bodybodybody = null, WorkflowValue<string> bodylocationlocation = null, WorkflowValue<bodyimportanceInput> bodyimportance = null, WorkflowValue<bool> bodyisAllDay = null, WorkflowValue<bool> bodyisReminderOn = null, WorkflowValue<int> bodyreminderStartDuration = null, WorkflowValue<bodyshowAsInput> bodyshowAs = null, WorkflowValue<bool> bodyresponseRequested = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowValue.Validate(bodystartstartTime, nameof(bodystartstartTime), required: false);
            WorkflowValue.Validate(bodyendendTime, nameof(bodyendendTime), required: false);
            WorkflowValue.Validate(bodybodybody, nameof(bodybodybody), required: false);
            WorkflowValue.Validate(bodylocationlocation, nameof(bodylocationlocation), required: false);
            WorkflowValue.Validate(bodyimportance, nameof(bodyimportance), required: false);
            WorkflowValue.Validate(bodyisAllDay, nameof(bodyisAllDay), required: false);
            WorkflowValue.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            WorkflowValue.Validate(bodyreminderStartDuration, nameof(bodyreminderStartDuration), required: false);
            WorkflowValue.Validate(bodyshowAs, nameof(bodyshowAs), required: false);
            WorkflowValue.Validate(bodyresponseRequested, nameof(bodyresponseRequested), required: false);
            return new DeferredBodyAction<CreateCalendarEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/groups/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartstartTime != null)
                {
                    startObject["dateTime"] = ExpressionConverter.ConvertO(bodystartstartTime);
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
                if (bodyendendTime != null)
                {
                    endObject["dateTime"] = ExpressionConverter.ConvertO(bodyendendTime);
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
                if (bodybodybody != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(bodybodybody);
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
                if (bodylocationlocation != null)
                {
                    locationObject["displayName"] = ExpressionConverter.ConvertO(bodylocationlocation);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(bodyimportance);
                    bodypropCount++;
                }

                if (bodyisAllDay != null)
                {
                    body["isAllDay"] = ExpressionConverter.ConvertO(bodyisAllDay);
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodyreminderStartDuration != null)
                {
                    body["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(bodyreminderStartDuration);
                    bodypropCount++;
                }

                if (bodyshowAs != null)
                {
                    body["showAs"] = ExpressionConverter.ConvertO(bodyshowAs);
                    bodypropCount++;
                }

                if (bodyresponseRequested != null)
                {
                    body["responseRequested"] = ExpressionConverter.ConvertO(bodyresponseRequested);
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
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowValue<string> uri, WorkflowValue<methodInput> method, WorkflowValue<string> body = null, WorkflowValue<string> contentType = null, WorkflowValue<string> customHeader1 = null, WorkflowValue<string> customHeader2 = null, WorkflowValue<string> customHeader3 = null, WorkflowValue<string> customHeader4 = null, WorkflowValue<string> customHeader5 = null)
        {
            WorkflowValue.Validate(uri, nameof(uri), required: true);
            WorkflowValue.Validate(method, nameof(method), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(customHeader1, nameof(customHeader1), required: false);
            WorkflowValue.Validate(customHeader2, nameof(customHeader2), required: false);
            WorkflowValue.Validate(customHeader3, nameof(customHeader3), required: false);
            WorkflowValue.Validate(customHeader4, nameof(customHeader4), required: false);
            WorkflowValue.Validate(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v2/httprequest";
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

    public class Office365groupsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnGroupMembershipChange))]
        public IBodyWorkflowTrigger<OnGroupMemberAddedOrRemovedResponseItem[]> OnGroupMembershipChange([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnGroupMemberAddedOrRemovedResponseItem[]> __BuildOnGroupMembershipChange(WorkflowValue<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/delta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewEvent))]
        public IBodyWorkflowTrigger<OnNewEventResponseItem[]> OnNewEvent([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewEventResponseItem[]> __BuildOnNewEvent(WorkflowValue<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnNewEventResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/v1.0/groups/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnNewEventResponseItem[]>(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum bodyimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum bodyshowAsInput
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

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
