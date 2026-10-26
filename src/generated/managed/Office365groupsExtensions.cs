//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365groups
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365groupsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupMembersResponse, ApiConnectionActionConfiguration> ListGroupMembers(Expression<Func<string>> groupId, Expression<Func<int>> top = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddMemberToGroup(Expression<Func<string>> groupId, Expression<Func<string>> userUpn)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_userUpn = WorkflowExpression.Compile(userUpn, nameof(userUpn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/members/$ref", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = ExpressionConverter.Convert(__workflow_userUpn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse, ApiConnectionActionConfiguration> ListGroups(Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null, Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ListGroupsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateCalendarEventResponse, ApiConnectionActionConfiguration> UpdateCalendarEvent(Expression<Func<string>> groupId, Expression<Func<string>> @event, Expression<Func<UpdateCalendarEventInput>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCalendarEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/events/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_event.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCalendarEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveMemberFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> userUpn)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_userUpn = WorkflowExpression.Compile(userUpn, nameof(userUpn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/members/memberId/$ref", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userUpn"] = ExpressionConverter.Convert(__workflow_userUpn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse, ApiConnectionActionConfiguration> ListDeletedGroups()
        {
            return new DeferredBodyAction<ListGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/directory/deletedItems/microsoft.graph.group";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RestoreDeletedGroup(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/directory/deletedItems/{0}/restore", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListGroupsResponse, ApiConnectionActionConfiguration> ListDeletedGroupsByOwner(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ListGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/directory/deletedItems/getUserOwnedObjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["userId"] = ExpressionConverter.Convert(__workflow_userId);
                return new ApiConnectionAction<ListGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CalendarDeleteItem(Expression<Func<string>> groupId, Expression<Func<string>> @event)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/events/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_event.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<CreateCalendarEventResponse, ApiConnectionActionConfiguration> CreateCalendarEvent(Expression<Func<string>> groupId, Expression<Func<CreateCalendarEventV2Input>> body)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCalendarEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/groups/{0}/events", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCalendarEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
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
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365groups")]
        public IBodyWorkflowAction<ListOwnedGroupsResponse, ApiConnectionActionConfiguration> ListOwnedGroups(Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<ListOwnedGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/v1.0/me/memberOf/$/microsoft.graph.group";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<ListOwnedGroupsResponse>(callPayload);
            });
        }
    }

    public class Office365groupsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnGroupMemberAddedOrRemovedResponseItem[], ApiConnectionTriggerConfiguration> OnGroupMembershipChange(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnGroupMemberAddedOrRemovedResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/v1.0/groups/delta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["$select"] = Convert.ToString("members");
                return new ApiConnectionTrigger<OnGroupMemberAddedOrRemovedResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnNewEventResponseItem[], ApiConnectionTriggerConfiguration> OnNewEvent(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<OnNewEventResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/v1.0/groups/{0}/events", __workflow_groupId.WithUrlEncoding(1)));
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

    public class UpdateCalendarEventInput
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateCalendarEventInputStartType Start { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateCalendarEventInputEndType End { get; set; }

        [JsonProperty("body")]
        public UpdateCalendarEventInputBodyType Body { get; set; }

        [JsonProperty("location")]
        public UpdateCalendarEventInputLocationType Location { get; set; }

        [JsonProperty("importance")]
        public UpdateCalendarEventInputImportanceType? Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool? IsAllDay { get; set; }

        [JsonProperty("isReminderOn")]
        public bool? IsReminderOn { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int? ReminderStartDuration { get; set; }

        [JsonProperty("showAs")]
        public UpdateCalendarEventInputShowAsType? ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool? ResponseRequested { get; set; }
    }

    public class UpdateCalendarEventInputStartType
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TimeZone { get; set; } = "UTC";
    }

    public class UpdateCalendarEventInputEndType
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TimeZone { get; set; } = "UTC";
    }

    public class UpdateCalendarEventInputBodyType
    {
        [JsonProperty("content")]
        public string Body { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BodyContentType { get; set; } = "Html";
    }

    public class UpdateCalendarEventInputLocationType
    {
        [JsonProperty("displayName")]
        public string Location { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateCalendarEventInputImportanceType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateCalendarEventInputShowAsType
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

    public class CreateCalendarEventV2Input
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCalendarEventV2InputStartType Start { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCalendarEventV2InputEndType End { get; set; }

        [JsonProperty("body")]
        public CreateCalendarEventV2InputBodyType Body { get; set; }

        [JsonProperty("location")]
        public CreateCalendarEventV2InputLocationType Location { get; set; }

        [JsonProperty("importance")]
        public CreateCalendarEventV2InputImportanceType? Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool? IsAllDay { get; set; }

        [JsonProperty("isReminderOn")]
        public bool? IsReminderOn { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int? ReminderStartDuration { get; set; }

        [JsonProperty("showAs")]
        public CreateCalendarEventV2InputShowAsType? ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool? ResponseRequested { get; set; }
    }

    public class CreateCalendarEventV2InputStartType
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TimeZone { get; set; } = "UTC";
    }

    public class CreateCalendarEventV2InputEndType
    {
        [JsonProperty("dateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TimeZone { get; set; } = "UTC";
    }

    public class CreateCalendarEventV2InputBodyType
    {
        [JsonProperty("content")]
        public string Body { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BodyContentType { get; set; } = "Html";
    }

    public class CreateCalendarEventV2InputLocationType
    {
        [JsonProperty("displayName")]
        public string Location { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCalendarEventV2InputImportanceType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCalendarEventV2InputShowAsType
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