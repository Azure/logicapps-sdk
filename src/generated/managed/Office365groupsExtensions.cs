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
        public IBodyWorkflowAction<ListGroupMembersResponse> ListGroupMembers(Expression<Func<string>> groupId, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction AddMemberToGroup(Expression<Func<string>> groupId, Expression<Func<string>> userUpn)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/members/$ref", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userUpn"] = ExpressionConverter.Convert(userUpn);
            return new ApiConnectionAction(callPayload);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse> UpdateCalendarEvent(Expression<Func<string>> groupId, Expression<Func<string>> @event, Expression<Func<string>> bodysubject, Expression<Func<string>> bodystartstartTime = null, Expression<Func<string>> bodyendendTime = null, Expression<Func<string>> bodybodybody = null, Expression<Func<string>> bodylocationlocation = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisReminderOn = null, Expression<Func<int>> bodyreminderStartDuration = null, Expression<Func<bodyshowAsInput>> bodyshowAs = null, Expression<Func<bool>> bodyresponseRequested = null)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction RemoveMemberFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> userUpn)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/members/memberId/$ref", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userUpn"] = ExpressionConverter.Convert(userUpn);
            return new ApiConnectionAction(callPayload);
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
            var apiCallPath = String.Format("/v1.0/directory/deletedItems/{0}/restore", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse> ListDeletedGroupsByOwner(Expression<Func<string>> userId)
        {
            var apiCallPath = "/v1.0/directory/deletedItems/getUserOwnedObjects";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["userId"] = ExpressionConverter.Convert(userId);
            return new ApiConnectionAction<ListGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction CalendarDeleteItem(Expression<Func<string>> groupId, Expression<Func<string>> @event)
        {
            var apiCallPath = String.Format("/v1.0/groups/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse> CreateCalendarEvent(Expression<Func<string>> groupId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodystartstartTime = null, Expression<Func<string>> bodyendendTime = null, Expression<Func<string>> bodybodybody = null, Expression<Func<string>> bodylocationlocation = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bool>> bodyisAllDay = null, Expression<Func<bool>> bodyisReminderOn = null, Expression<Func<int>> bodyreminderStartDuration = null, Expression<Func<bodyshowAsInput>> bodyshowAs = null, Expression<Func<bool>> bodyresponseRequested = null)
        {
            var apiCallPath = String.Format("/v2/v1.0/groups/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
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
        }
    }

    public class Office365groupsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnGroupMemberAddedOrRemovedResponseItem[]> OnGroupMembershipChange(Expression<Func<string>> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1.0/groups/delta";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["$select"] = Convert.ToString("members");
            return new ApiConnectionTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewEventResponseItem[]> OnNewEvent(Expression<Func<string>> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/v1.0/groups/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OnNewEventResponseItem[]>(callPayload, triggerName, recurrence);
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