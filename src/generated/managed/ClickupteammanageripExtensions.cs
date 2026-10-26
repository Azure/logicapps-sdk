//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clickupteammanagerip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClickupteammanageripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<CreateAFolderResponse, ApiConnectionActionConfiguration> CreateAFolder(Expression<Func<string>> spaceId, Expression<Func<CreateAFolderInput>> body = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateAFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/space/{0}/folder", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<GetTeamsResponse, ApiConnectionActionConfiguration> GetTeams()
        {
            return new DeferredBodyAction<GetTeamsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/team";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTeamsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<CreateSpaceResponse, ApiConnectionActionConfiguration> CreateSpace(Expression<Func<string>> teamId, Expression<Func<CreateSpaceInput>> body = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateSpaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/team/{0}/space", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<CreateAListResponse, ApiConnectionActionConfiguration> CreateAList(Expression<Func<string>> folderId, Expression<Func<CreateAListInput>> body = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateAListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/folder/{0}/list", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAListResponse>(callPayload);
            });
        }
    }

    public class ClickupteammanageripTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateAFolderResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderindex")]
        public int Orderindex { get; set; }

        [JsonProperty("override_statuses")]
        public bool OverrideStatuses { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("space")]
        public CreateAFolderResponseSpaceType Space { get; set; }

        [JsonProperty("task_count")]
        public string TaskCount { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("statuses")]
        public JToken[] Statuses { get; set; }

        [JsonProperty("lists")]
        public JToken[] Lists { get; set; }

        [JsonProperty("permission_level")]
        public string PermissionLevel { get; set; }
    }

    public class CreateAFolderResponseSpaceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("access")]
        public bool Access { get; set; }
    }

    public class CreateAFolderInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string FolderName { get; set; }

        [JsonProperty("orderindex")]
        public int? OrderIndex { get; set; }

        [JsonProperty("override_statuses")]
        public bool? OverrideStatuses { get; set; }

        [JsonProperty("hidden")]
        public bool? HiddenFolder { get; set; }

        [JsonProperty("space")]
        public CreateAFolderInputSpaceType Space { get; set; }

        [JsonProperty("task_count")]
        public string TaskCount { get; set; }

        [JsonProperty("archived")]
        public bool? Archived { get; set; }

        [JsonProperty("statuses")]
        public JToken[] Statuses { get; set; }

        [JsonProperty("permission_level")]
        public string PermissionLevel { get; set; }
    }

    public class CreateAFolderInputSpaceType
    {
    }

    public class GetTeamsResponse
    {
        [JsonProperty("teams")]
        public GetTeamsResponseTeamsTypeItem[] Teams { get; set; }
    }

    public class GetTeamsResponseTeamsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("members")]
        public GetTeamsResponseTeamsTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class GetTeamsResponseTeamsTypeItemMembersTypeItem
    {
        [JsonProperty("user")]
        public GetTeamsResponseTeamsTypeItemMembersTypeItemUserType User { get; set; }
    }

    public class GetTeamsResponseTeamsTypeItemMembersTypeItemUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("role")]
        public int Role { get; set; }

        [JsonProperty("custom_role")]
        public string CustomRole { get; set; }

        [JsonProperty("last_active")]
        public string LastActive { get; set; }

        [JsonProperty("date_joined")]
        public string DateJoined { get; set; }

        [JsonProperty("date_invited")]
        public string DateInvited { get; set; }
    }

    public class CreateSpaceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("statuses")]
        public CreateSpaceResponseStatusesTypeItem[] Statuses { get; set; }

        [JsonProperty("multiple_assignees")]
        public bool MultipleAssignees { get; set; }

        [JsonProperty("features")]
        public CreateSpaceResponseFeaturesType Features { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }

    public class CreateSpaceResponseStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("orderindex")]
        public int Orderindex { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class CreateSpaceResponseFeaturesType
    {
        [JsonProperty("due_dates")]
        public CreateSpaceResponseFeaturesTypeDueDatesType DueDates { get; set; }

        [JsonProperty("sprints")]
        public CreateSpaceResponseFeaturesTypeSprintsType Sprints { get; set; }

        [JsonProperty("points")]
        public CreateSpaceResponseFeaturesTypePointsType Points { get; set; }

        [JsonProperty("custom_items")]
        public CreateSpaceResponseFeaturesTypeCustomItemsType CustomItems { get; set; }

        [JsonProperty("tags")]
        public CreateSpaceResponseFeaturesTypeTagsType Tags { get; set; }

        [JsonProperty("time_estimates")]
        public CreateSpaceResponseFeaturesTypeTimeEstimatesType TimeEstimates { get; set; }

        [JsonProperty("checklists")]
        public CreateSpaceResponseFeaturesTypeChecklistsType Checklists { get; set; }

        [JsonProperty("zoom")]
        public CreateSpaceResponseFeaturesTypeZoomType Zoom { get; set; }

        [JsonProperty("milestones")]
        public CreateSpaceResponseFeaturesTypeMilestonesType Milestones { get; set; }

        [JsonProperty("custom_fields")]
        public CreateSpaceResponseFeaturesTypeCustomFieldsType CustomFields { get; set; }

        [JsonProperty("remap_dependencies")]
        public CreateSpaceResponseFeaturesTypeRemapDependenciesType RemapDependencies { get; set; }

        [JsonProperty("dependency_warning")]
        public CreateSpaceResponseFeaturesTypeDependencyWarningType DependencyWarning { get; set; }

        [JsonProperty("multiple_assignees")]
        public CreateSpaceResponseFeaturesTypeMultipleAssigneesType MultipleAssignees { get; set; }

        [JsonProperty("portfolios")]
        public CreateSpaceResponseFeaturesTypePortfoliosType Portfolios { get; set; }

        [JsonProperty("emails")]
        public CreateSpaceResponseFeaturesTypeEmailsType Emails { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeDueDatesType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("start_date")]
        public bool StartDate { get; set; }

        [JsonProperty("remap_due_dates")]
        public bool RemapDueDates { get; set; }

        [JsonProperty("remap_closed_due_date")]
        public bool RemapClosedDueDate { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeSprintsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypePointsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeCustomItemsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeTagsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeTimeEstimatesType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeChecklistsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeZoomType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeMilestonesType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeCustomFieldsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeRemapDependenciesType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeDependencyWarningType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeMultipleAssigneesType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypePortfoliosType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceResponseFeaturesTypeEmailsType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CreateSpaceInput
    {
        [JsonProperty("name")]
        public string SpaceName { get; set; }

        [JsonProperty("multiple_assignees")]
        public bool? MultipleAssignees { get; set; }

        [JsonProperty("features")]
        public CreateSpaceInputFeaturesType Features { get; set; }
    }

    public class CreateSpaceInputFeaturesType
    {
        [JsonProperty("due_dates")]
        public CreateSpaceInputFeaturesTypeDueDatesType DueDates { get; set; }

        [JsonProperty("time_tracking")]
        public CreateSpaceInputFeaturesTypeTimeTrackingType TimeTracking { get; set; }

        [JsonProperty("tags")]
        public CreateSpaceInputFeaturesTypeTagsType Tags { get; set; }

        [JsonProperty("time_estimates")]
        public CreateSpaceInputFeaturesTypeTimeEstimatesType TimeEstimates { get; set; }

        [JsonProperty("checklists")]
        public CreateSpaceInputFeaturesTypeChecklistsType Checklists { get; set; }

        [JsonProperty("custom_fields")]
        public CreateSpaceInputFeaturesTypeCustomFieldsType CustomFields { get; set; }

        [JsonProperty("remap_dependencies")]
        public CreateSpaceInputFeaturesTypeRemapDependenciesType RemapDependencies { get; set; }

        [JsonProperty("dependency_warning")]
        public CreateSpaceInputFeaturesTypeDependencyWarningType DependencyWarning { get; set; }

        [JsonProperty("portfolios")]
        public CreateSpaceInputFeaturesTypePortfoliosType Portfolios { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeDueDatesType
    {
        [JsonProperty("enabled")]
        public bool? DueDates { get; set; }

        [JsonProperty("start_date")]
        public bool? StartDate { get; set; }

        [JsonProperty("remap_due_dates")]
        public bool? RemapDueDate { get; set; }

        [JsonProperty("remap_closed_due_date")]
        public bool? RemapClosedDueDate { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeTimeTrackingType
    {
        [JsonProperty("enabled")]
        public bool? TimeTracking { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeTagsType
    {
        [JsonProperty("enabled")]
        public bool? Tags { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeTimeEstimatesType
    {
        [JsonProperty("enabled")]
        public bool? TimeEstimates { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeChecklistsType
    {
        [JsonProperty("enabled")]
        public bool? Checklist { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeCustomFieldsType
    {
        [JsonProperty("enabled")]
        public bool? CustomFields { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeRemapDependenciesType
    {
        [JsonProperty("enabled")]
        public bool? RemapDependencies { get; set; }
    }

    public class CreateSpaceInputFeaturesTypeDependencyWarningType
    {
        [JsonProperty("enabled")]
        public bool? DependencyWarning { get; set; }
    }

    public class CreateSpaceInputFeaturesTypePortfoliosType
    {
        [JsonProperty("enabled")]
        public bool? Portfolios { get; set; }
    }

    public class CreateAListResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderindex")]
        public int Orderindex { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("status")]
        public CreateAListResponseStatusType Status { get; set; }

        [JsonProperty("priority")]
        public CreateAListResponsePriorityType Priority { get; set; }

        [JsonProperty("assignee")]
        public CreateAListResponseAssigneeType Assignee { get; set; }

        [JsonProperty("task_count")]
        public string TaskCount { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("due_date_time")]
        public bool DueDateTime { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_date_time")]
        public string StartDateTime { get; set; }

        [JsonProperty("folder")]
        public CreateAListResponseFolderType Folder { get; set; }

        [JsonProperty("space")]
        public CreateAListResponseSpaceType Space { get; set; }

        [JsonProperty("statuses")]
        public CreateAListResponseStatusesTypeItem[] Statuses { get; set; }

        [JsonProperty("inbound_address")]
        public string InboundAddress { get; set; }
    }

    public class CreateAListResponseStatusType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("hide_label")]
        public bool HideLabel { get; set; }
    }

    public class CreateAListResponsePriorityType
    {
        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class CreateAListResponseAssigneeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }
    }

    public class CreateAListResponseFolderType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("access")]
        public bool Access { get; set; }
    }

    public class CreateAListResponseSpaceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("access")]
        public bool Access { get; set; }
    }

    public class CreateAListResponseStatusesTypeItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("orderindex")]
        public int Orderindex { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateAListInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderindex")]
        public int? OrderIndex { get; set; }

        [JsonProperty("status")]
        public CreateAListInputStatusType Status { get; set; }

        [JsonProperty("priority")]
        public CreateAListInputPriorityType Priority { get; set; }

        [JsonProperty("assignee")]
        public CreateAListInputAssigneeType Assignee { get; set; }

        [JsonProperty("due_date_time")]
        public bool? DueDate2 { get; set; }

        [JsonProperty("folder")]
        public CreateAListInputFolderType Folder { get; set; }

        [JsonProperty("space")]
        public CreateAListInputSpaceType Space { get; set; }

        [JsonProperty("statuses")]
        public CreateAListInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class CreateAListInputStatusType
    {
    }

    public class CreateAListInputPriorityType
    {
    }

    public class CreateAListInputAssigneeType
    {
    }

    public class CreateAListInputFolderType
    {
    }

    public class CreateAListInputSpaceType
    {
    }

    public class CreateAListInputStatusesTypeItem
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clickupteammanagerip;

    public partial class WorkflowManagedActions
    {
        public ClickupteammanageripActions Clickupteammanagerip(string connectionId) => new ClickupteammanageripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClickupteammanageripTriggers Clickupteammanagerip(string connectionId) => new ClickupteammanageripTriggers(connectionId);
    }
}