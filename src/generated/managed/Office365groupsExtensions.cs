//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365groups
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365groupsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupMembersResponse> ListGroupMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction AddMemberToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> userUpn)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(userUpn, nameof(userUpn), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = SourceExpressionConverter.ConvertO(userUpn);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListGroups([WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                return callPayload;
            }

            return new ApiConnectionAction<ListGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse> UpdateCalendarEvent([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> @event, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodystartstartTime = null, [WorkflowExpression] Func<string> bodyendendTime = null, [WorkflowExpression] Func<string> bodybodybody = null, [WorkflowExpression] Func<string> bodylocationlocation = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<bool> bodyisAllDay = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null, [WorkflowExpression] Func<int> bodyreminderStartDuration = null, [WorkflowExpression] Func<bodyshowAsInput> bodyshowAs = null, [WorkflowExpression] Func<bool> bodyresponseRequested = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(@event, nameof(@event), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodystartstartTime, nameof(bodystartstartTime), required: false);
            SourceExpression.Validate(bodyendendTime, nameof(bodyendendTime), required: false);
            SourceExpression.Validate(bodybodybody, nameof(bodybodybody), required: false);
            SourceExpression.Validate(bodylocationlocation, nameof(bodylocationlocation), required: false);
            SourceExpression.Validate(bodyimportance, nameof(bodyimportance), required: false);
            SourceExpression.Validate(bodyisAllDay, nameof(bodyisAllDay), required: false);
            SourceExpression.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            SourceExpression.Validate(bodyreminderStartDuration, nameof(bodyreminderStartDuration), required: false);
            SourceExpression.Validate(bodyshowAs, nameof(bodyshowAs), required: false);
            SourceExpression.Validate(bodyresponseRequested, nameof(bodyresponseRequested), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@event, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartstartTime != null)
                {
                    startObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodystartstartTime);
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
                    endObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodyendendTime);
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
                    bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodybodybody);
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
                    locationObject["displayName"] = SourceExpressionConverter.ConvertToken(bodylocationlocation);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodyimportance != null)
                {
                    body["importance"] = SourceExpressionConverter.Convert(bodyimportance);
                    bodypropCount++;
                }

                if (bodyisAllDay != null)
                {
                    body["isAllDay"] = SourceExpressionConverter.ConvertToken(bodyisAllDay);
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = SourceExpressionConverter.ConvertToken(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodyreminderStartDuration != null)
                {
                    body["reminderMinutesBeforeStart"] = SourceExpressionConverter.ConvertToken(bodyreminderStartDuration);
                    bodypropCount++;
                }

                if (bodyshowAs != null)
                {
                    body["showAs"] = SourceExpressionConverter.Convert(bodyshowAs);
                    bodypropCount++;
                }

                if (bodyresponseRequested != null)
                {
                    body["responseRequested"] = SourceExpressionConverter.ConvertToken(bodyresponseRequested);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCalendarEventResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction RemoveMemberFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> userUpn)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(userUpn, nameof(userUpn), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members/memberId/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = SourceExpressionConverter.ConvertO(userUpn);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListDeletedGroups()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/directory/deletedItems/microsoft.graph.group";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction RestoreDeletedGroup([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/directory/deletedItems/{0}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListDeletedGroupsByOwner([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/directory/deletedItems/getUserOwnedObjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["userId"] = SourceExpressionConverter.ConvertO(userId);
                return callPayload;
            }

            return new ApiConnectionAction<ListGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction CalendarDeleteItem([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> @event)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(@event, nameof(@event), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@event, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse> CreateCalendarEvent([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodystartstartTime = null, [WorkflowExpression] Func<string> bodyendendTime = null, [WorkflowExpression] Func<string> bodybodybody = null, [WorkflowExpression] Func<string> bodylocationlocation = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<bool> bodyisAllDay = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null, [WorkflowExpression] Func<int> bodyreminderStartDuration = null, [WorkflowExpression] Func<bodyshowAsInput> bodyshowAs = null, [WorkflowExpression] Func<bool> bodyresponseRequested = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodystartstartTime, nameof(bodystartstartTime), required: false);
            SourceExpression.Validate(bodyendendTime, nameof(bodyendendTime), required: false);
            SourceExpression.Validate(bodybodybody, nameof(bodybodybody), required: false);
            SourceExpression.Validate(bodylocationlocation, nameof(bodylocationlocation), required: false);
            SourceExpression.Validate(bodyimportance, nameof(bodyimportance), required: false);
            SourceExpression.Validate(bodyisAllDay, nameof(bodyisAllDay), required: false);
            SourceExpression.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            SourceExpression.Validate(bodyreminderStartDuration, nameof(bodyreminderStartDuration), required: false);
            SourceExpression.Validate(bodyshowAs, nameof(bodyshowAs), required: false);
            SourceExpression.Validate(bodyresponseRequested, nameof(bodyresponseRequested), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/v1.0/groups/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartstartTime != null)
                {
                    startObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodystartstartTime);
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
                    endObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodyendendTime);
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
                    bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodybodybody);
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
                    locationObject["displayName"] = SourceExpressionConverter.ConvertToken(bodylocationlocation);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodyimportance != null)
                {
                    body["importance"] = SourceExpressionConverter.Convert(bodyimportance);
                    bodypropCount++;
                }

                if (bodyisAllDay != null)
                {
                    body["isAllDay"] = SourceExpressionConverter.ConvertToken(bodyisAllDay);
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = SourceExpressionConverter.ConvertToken(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodyreminderStartDuration != null)
                {
                    body["reminderMinutesBeforeStart"] = SourceExpressionConverter.ConvertToken(bodyreminderStartDuration);
                    bodypropCount++;
                }

                if (bodyshowAs != null)
                {
                    body["showAs"] = SourceExpressionConverter.Convert(bodyshowAs);
                    bodypropCount++;
                }

                if (bodyresponseRequested != null)
                {
                    body["responseRequested"] = SourceExpressionConverter.ConvertToken(bodyresponseRequested);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCalendarEventResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
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
                var apiCallPath = "/v2/httprequest";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListOwnedGroupsResponse> ListOwnedGroups([WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/v1.0/me/memberOf/$/microsoft.graph.group";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<ListOwnedGroupsResponse>(BuildSourceInput);
        }
    }

    public class Office365groupsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnGroupMemberAddedOrRemovedResponseItem[]> OnGroupMembershipChange([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewEventResponseItem[]> OnNewEvent([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/v1.0/groups/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewEventResponseItem[]>(BuildSourceInput, triggerName, recurrence);
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