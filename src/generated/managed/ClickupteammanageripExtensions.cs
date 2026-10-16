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
        public IBodyWorkflowAction<CreateAFolderResponse> CreateAFolder(Expression<Func<string>> spaceId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyfolderName = null, Expression<Func<int>> bodyorderIndex = null, Expression<Func<bool>> bodyoverrideStatuses = null, Expression<Func<bool>> bodyhiddenFolder = null, Expression<Func<string>> bodytaskCount = null, Expression<Func<bool>> bodyarchived = null, Expression<Func<JToken[]>> bodystatuses = null, Expression<Func<string>> bodypermissionLevel = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyfolderName = WorkflowExpression.Compile(bodyfolderName, nameof(bodyfolderName), required: false);
            var __workflow_bodyorderIndex = WorkflowExpression.Compile(bodyorderIndex, nameof(bodyorderIndex), required: false);
            var __workflow_bodyoverrideStatuses = WorkflowExpression.Compile(bodyoverrideStatuses, nameof(bodyoverrideStatuses), required: false);
            var __workflow_bodyhiddenFolder = WorkflowExpression.Compile(bodyhiddenFolder, nameof(bodyhiddenFolder), required: false);
            var __workflow_bodytaskCount = WorkflowExpression.Compile(bodytaskCount, nameof(bodytaskCount), required: false);
            var __workflow_bodyarchived = WorkflowExpression.Compile(bodyarchived, nameof(bodyarchived), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            var __workflow_bodypermissionLevel = WorkflowExpression.Compile(bodypermissionLevel, nameof(bodypermissionLevel), required: false);
            return new DeferredBodyAction<CreateAFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/space/{0}/folder", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyfolderName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyfolderName);
                    bodypropCount++;
                }

                if (__workflow_bodyorderIndex != null)
                {
                    body["orderindex"] = ExpressionConverter.ConvertO(__workflow_bodyorderIndex);
                    bodypropCount++;
                }

                if (__workflow_bodyoverrideStatuses != null)
                {
                    body["override_statuses"] = ExpressionConverter.ConvertO(__workflow_bodyoverrideStatuses);
                    bodypropCount++;
                }

                if (__workflow_bodyhiddenFolder != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(__workflow_bodyhiddenFolder);
                    bodypropCount++;
                }

                var spaceObject = new JObject();
                var spaceObjectpropCount = 0;
                if (spaceObjectpropCount > 0)
                {
                    body["space"] = spaceObject;
                    bodypropCount++;
                }

                if (__workflow_bodytaskCount != null)
                {
                    body["task_count"] = ExpressionConverter.ConvertO(__workflow_bodytaskCount);
                    bodypropCount++;
                }

                if (__workflow_bodyarchived != null)
                {
                    body["archived"] = ExpressionConverter.ConvertO(__workflow_bodyarchived);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (__workflow_bodypermissionLevel != null)
                {
                    body["permission_level"] = ExpressionConverter.ConvertO(__workflow_bodypermissionLevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<GetTeamsResponse> GetTeams()
        {
            var apiCallPath = "/api/v2/team";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTeamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<CreateSpaceResponse> CreateSpace(Expression<Func<string>> teamId, Expression<Func<string>> bodyspaceName = null, Expression<Func<bool>> bodymultipleAssignees = null, Expression<Func<bool>> bodyfeaturesdueDatesdueDates = null, Expression<Func<bool>> bodyfeaturesdueDatesstartDate = null, Expression<Func<bool>> bodyfeaturesdueDatesremapDueDate = null, Expression<Func<bool>> bodyfeaturesdueDatesremapClosedDueDate = null, Expression<Func<bool>> bodyfeaturestimeTrackingtimeTracking = null, Expression<Func<bool>> bodyfeaturestagstags = null, Expression<Func<bool>> bodyfeaturestimeEstimatestimeEstimates = null, Expression<Func<bool>> bodyfeatureschecklistschecklist = null, Expression<Func<bool>> bodyfeaturescustomFieldscustomFields = null, Expression<Func<bool>> bodyfeaturesremapDependenciesremapDependencies = null, Expression<Func<bool>> bodyfeaturesdependencyWarningdependencyWarning = null, Expression<Func<bool>> bodyfeaturesportfoliosportfolios = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_bodyspaceName = WorkflowExpression.Compile(bodyspaceName, nameof(bodyspaceName), required: false);
            var __workflow_bodymultipleAssignees = WorkflowExpression.Compile(bodymultipleAssignees, nameof(bodymultipleAssignees), required: false);
            var __workflow_bodyfeaturesdueDatesdueDates = WorkflowExpression.Compile(bodyfeaturesdueDatesdueDates, nameof(bodyfeaturesdueDatesdueDates), required: false);
            var __workflow_bodyfeaturesdueDatesstartDate = WorkflowExpression.Compile(bodyfeaturesdueDatesstartDate, nameof(bodyfeaturesdueDatesstartDate), required: false);
            var __workflow_bodyfeaturesdueDatesremapDueDate = WorkflowExpression.Compile(bodyfeaturesdueDatesremapDueDate, nameof(bodyfeaturesdueDatesremapDueDate), required: false);
            var __workflow_bodyfeaturesdueDatesremapClosedDueDate = WorkflowExpression.Compile(bodyfeaturesdueDatesremapClosedDueDate, nameof(bodyfeaturesdueDatesremapClosedDueDate), required: false);
            var __workflow_bodyfeaturestimeTrackingtimeTracking = WorkflowExpression.Compile(bodyfeaturestimeTrackingtimeTracking, nameof(bodyfeaturestimeTrackingtimeTracking), required: false);
            var __workflow_bodyfeaturestagstags = WorkflowExpression.Compile(bodyfeaturestagstags, nameof(bodyfeaturestagstags), required: false);
            var __workflow_bodyfeaturestimeEstimatestimeEstimates = WorkflowExpression.Compile(bodyfeaturestimeEstimatestimeEstimates, nameof(bodyfeaturestimeEstimatestimeEstimates), required: false);
            var __workflow_bodyfeatureschecklistschecklist = WorkflowExpression.Compile(bodyfeatureschecklistschecklist, nameof(bodyfeatureschecklistschecklist), required: false);
            var __workflow_bodyfeaturescustomFieldscustomFields = WorkflowExpression.Compile(bodyfeaturescustomFieldscustomFields, nameof(bodyfeaturescustomFieldscustomFields), required: false);
            var __workflow_bodyfeaturesremapDependenciesremapDependencies = WorkflowExpression.Compile(bodyfeaturesremapDependenciesremapDependencies, nameof(bodyfeaturesremapDependenciesremapDependencies), required: false);
            var __workflow_bodyfeaturesdependencyWarningdependencyWarning = WorkflowExpression.Compile(bodyfeaturesdependencyWarningdependencyWarning, nameof(bodyfeaturesdependencyWarningdependencyWarning), required: false);
            var __workflow_bodyfeaturesportfoliosportfolios = WorkflowExpression.Compile(bodyfeaturesportfoliosportfolios, nameof(bodyfeaturesportfoliosportfolios), required: false);
            return new DeferredBodyAction<CreateSpaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/team/{0}/space", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyspaceName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyspaceName);
                    bodypropCount++;
                }

                if (__workflow_bodymultipleAssignees != null)
                {
                    body["multiple_assignees"] = ExpressionConverter.ConvertO(__workflow_bodymultipleAssignees);
                    bodypropCount++;
                }

                var featuresObject = new JObject();
                var featuresObjectpropCount = 0;
                var dueDatesObject = new JObject();
                var dueDatesObjectpropCount = 0;
                if (__workflow_bodyfeaturesdueDatesdueDates != null)
                {
                    dueDatesObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesdueDatesdueDates);
                    dueDatesObjectpropCount++;
                }

                if (__workflow_bodyfeaturesdueDatesstartDate != null)
                {
                    dueDatesObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesdueDatesstartDate);
                    dueDatesObjectpropCount++;
                }

                if (__workflow_bodyfeaturesdueDatesremapDueDate != null)
                {
                    dueDatesObject["remap_due_dates"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesdueDatesremapDueDate);
                    dueDatesObjectpropCount++;
                }

                if (__workflow_bodyfeaturesdueDatesremapClosedDueDate != null)
                {
                    dueDatesObject["remap_closed_due_date"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesdueDatesremapClosedDueDate);
                    dueDatesObjectpropCount++;
                }

                if (dueDatesObjectpropCount > 0)
                {
                    featuresObject["due_dates"] = dueDatesObject;
                    featuresObjectpropCount++;
                }

                var timeTrackingObject = new JObject();
                var timeTrackingObjectpropCount = 0;
                if (__workflow_bodyfeaturestimeTrackingtimeTracking != null)
                {
                    timeTrackingObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturestimeTrackingtimeTracking);
                    timeTrackingObjectpropCount++;
                }

                if (timeTrackingObjectpropCount > 0)
                {
                    featuresObject["time_tracking"] = timeTrackingObject;
                    featuresObjectpropCount++;
                }

                var tagsObject = new JObject();
                var tagsObjectpropCount = 0;
                if (__workflow_bodyfeaturestagstags != null)
                {
                    tagsObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturestagstags);
                    tagsObjectpropCount++;
                }

                if (tagsObjectpropCount > 0)
                {
                    featuresObject["tags"] = tagsObject;
                    featuresObjectpropCount++;
                }

                var timeEstimatesObject = new JObject();
                var timeEstimatesObjectpropCount = 0;
                if (__workflow_bodyfeaturestimeEstimatestimeEstimates != null)
                {
                    timeEstimatesObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturestimeEstimatestimeEstimates);
                    timeEstimatesObjectpropCount++;
                }

                if (timeEstimatesObjectpropCount > 0)
                {
                    featuresObject["time_estimates"] = timeEstimatesObject;
                    featuresObjectpropCount++;
                }

                var checklistsObject = new JObject();
                var checklistsObjectpropCount = 0;
                if (__workflow_bodyfeatureschecklistschecklist != null)
                {
                    checklistsObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeatureschecklistschecklist);
                    checklistsObjectpropCount++;
                }

                if (checklistsObjectpropCount > 0)
                {
                    featuresObject["checklists"] = checklistsObject;
                    featuresObjectpropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (__workflow_bodyfeaturescustomFieldscustomFields != null)
                {
                    customFieldsObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturescustomFieldscustomFields);
                    customFieldsObjectpropCount++;
                }

                if (customFieldsObjectpropCount > 0)
                {
                    featuresObject["custom_fields"] = customFieldsObject;
                    featuresObjectpropCount++;
                }

                var remapDependenciesObject = new JObject();
                var remapDependenciesObjectpropCount = 0;
                if (__workflow_bodyfeaturesremapDependenciesremapDependencies != null)
                {
                    remapDependenciesObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesremapDependenciesremapDependencies);
                    remapDependenciesObjectpropCount++;
                }

                if (remapDependenciesObjectpropCount > 0)
                {
                    featuresObject["remap_dependencies"] = remapDependenciesObject;
                    featuresObjectpropCount++;
                }

                var dependencyWarningObject = new JObject();
                var dependencyWarningObjectpropCount = 0;
                if (__workflow_bodyfeaturesdependencyWarningdependencyWarning != null)
                {
                    dependencyWarningObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesdependencyWarningdependencyWarning);
                    dependencyWarningObjectpropCount++;
                }

                if (dependencyWarningObjectpropCount > 0)
                {
                    featuresObject["dependency_warning"] = dependencyWarningObject;
                    featuresObjectpropCount++;
                }

                var portfoliosObject = new JObject();
                var portfoliosObjectpropCount = 0;
                if (__workflow_bodyfeaturesportfoliosportfolios != null)
                {
                    portfoliosObject["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyfeaturesportfoliosportfolios);
                    portfoliosObjectpropCount++;
                }

                if (portfoliosObjectpropCount > 0)
                {
                    featuresObject["portfolios"] = portfoliosObject;
                    featuresObjectpropCount++;
                }

                if (featuresObjectpropCount > 0)
                {
                    body["features"] = featuresObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        public IBodyWorkflowAction<CreateAListResponse> CreateAList(Expression<Func<string>> folderId, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyorderIndex = null, Expression<Func<bool>> bodydueDate2 = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyorderIndex = WorkflowExpression.Compile(bodyorderIndex, nameof(bodyorderIndex), required: false);
            var __workflow_bodydueDate2 = WorkflowExpression.Compile(bodydueDate2, nameof(bodydueDate2), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<CreateAListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/folder/{0}/list", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyorderIndex != null)
                {
                    body["orderindex"] = ExpressionConverter.ConvertO(__workflow_bodyorderIndex);
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (statusObjectpropCount > 0)
                {
                    body["status"] = statusObject;
                    bodypropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (priorityObjectpropCount > 0)
                {
                    body["priority"] = priorityObject;
                    bodypropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                if (assigneeObjectpropCount > 0)
                {
                    body["assignee"] = assigneeObject;
                    bodypropCount++;
                }

                if (__workflow_bodydueDate2 != null)
                {
                    body["due_date_time"] = ExpressionConverter.ConvertO(__workflow_bodydueDate2);
                    bodypropCount++;
                }

                var folderObject = new JObject();
                var folderObjectpropCount = 0;
                if (folderObjectpropCount > 0)
                {
                    body["folder"] = folderObject;
                    bodypropCount++;
                }

                var spaceObject = new JObject();
                var spaceObjectpropCount = 0;
                if (spaceObjectpropCount > 0)
                {
                    body["space"] = spaceObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class bodystatusesInputItem
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
