//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clickupteammanagerip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClickupteammanageripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clickupteammanagerip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAFolder))]
        public IBodyWorkflowAction<CreateAFolderResponse> CreateAFolder([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyfolderName = null, [WorkflowExpression] Func<int> bodyorderIndex = null, [WorkflowExpression] Func<bool> bodyoverrideStatuses = null, [WorkflowExpression] Func<bool> bodyhiddenFolder = null, [WorkflowExpression] Func<string> bodytaskCount = null, [WorkflowExpression] Func<bool> bodyarchived = null, [WorkflowExpression] Func<JToken[]> bodystatuses = null, [WorkflowExpression] Func<string> bodypermissionLevel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAFolderResponse> __BuildCreateAFolder(WorkflowValue<string> spaceId, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodyfolderName = null, WorkflowValue<int> bodyorderIndex = null, WorkflowValue<bool> bodyoverrideStatuses = null, WorkflowValue<bool> bodyhiddenFolder = null, WorkflowValue<string> bodytaskCount = null, WorkflowValue<bool> bodyarchived = null, WorkflowValue<JToken[]> bodystatuses = null, WorkflowValue<string> bodypermissionLevel = null)
        {
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyfolderName, nameof(bodyfolderName), required: false);
            WorkflowValue.Validate(bodyorderIndex, nameof(bodyorderIndex), required: false);
            WorkflowValue.Validate(bodyoverrideStatuses, nameof(bodyoverrideStatuses), required: false);
            WorkflowValue.Validate(bodyhiddenFolder, nameof(bodyhiddenFolder), required: false);
            WorkflowValue.Validate(bodytaskCount, nameof(bodytaskCount), required: false);
            WorkflowValue.Validate(bodyarchived, nameof(bodyarchived), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            WorkflowValue.Validate(bodypermissionLevel, nameof(bodypermissionLevel), required: false);
            return new DeferredBodyAction<CreateAFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/space/{0}/folder", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyfolderName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyfolderName);
                    bodypropCount++;
                }

                if (bodyorderIndex != null)
                {
                    body["orderindex"] = ExpressionConverter.ConvertO(bodyorderIndex);
                    bodypropCount++;
                }

                if (bodyoverrideStatuses != null)
                {
                    body["override_statuses"] = ExpressionConverter.ConvertO(bodyoverrideStatuses);
                    bodypropCount++;
                }

                if (bodyhiddenFolder != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(bodyhiddenFolder);
                    bodypropCount++;
                }

                var spaceObject = new JObject();
                var spaceObjectpropCount = 0;
                if (spaceObjectpropCount > 0)
                {
                    body["space"] = spaceObject;
                    bodypropCount++;
                }

                if (bodytaskCount != null)
                {
                    body["task_count"] = ExpressionConverter.ConvertO(bodytaskCount);
                    bodypropCount++;
                }

                if (bodyarchived != null)
                {
                    body["archived"] = ExpressionConverter.ConvertO(bodyarchived);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                    bodypropCount++;
                }

                if (bodypermissionLevel != null)
                {
                    body["permission_level"] = ExpressionConverter.ConvertO(bodypermissionLevel);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateSpace))]
        public IBodyWorkflowAction<CreateSpaceResponse> CreateSpace([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> bodyspaceName = null, [WorkflowExpression] Func<bool> bodymultipleAssignees = null, [WorkflowExpression] Func<bool> bodyfeaturesdueDatesdueDates = null, [WorkflowExpression] Func<bool> bodyfeaturesdueDatesstartDate = null, [WorkflowExpression] Func<bool> bodyfeaturesdueDatesremapDueDate = null, [WorkflowExpression] Func<bool> bodyfeaturesdueDatesremapClosedDueDate = null, [WorkflowExpression] Func<bool> bodyfeaturestimeTrackingtimeTracking = null, [WorkflowExpression] Func<bool> bodyfeaturestagstags = null, [WorkflowExpression] Func<bool> bodyfeaturestimeEstimatestimeEstimates = null, [WorkflowExpression] Func<bool> bodyfeatureschecklistschecklist = null, [WorkflowExpression] Func<bool> bodyfeaturescustomFieldscustomFields = null, [WorkflowExpression] Func<bool> bodyfeaturesremapDependenciesremapDependencies = null, [WorkflowExpression] Func<bool> bodyfeaturesdependencyWarningdependencyWarning = null, [WorkflowExpression] Func<bool> bodyfeaturesportfoliosportfolios = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSpaceResponse> __BuildCreateSpace(WorkflowValue<string> teamId, WorkflowValue<string> bodyspaceName = null, WorkflowValue<bool> bodymultipleAssignees = null, WorkflowValue<bool> bodyfeaturesdueDatesdueDates = null, WorkflowValue<bool> bodyfeaturesdueDatesstartDate = null, WorkflowValue<bool> bodyfeaturesdueDatesremapDueDate = null, WorkflowValue<bool> bodyfeaturesdueDatesremapClosedDueDate = null, WorkflowValue<bool> bodyfeaturestimeTrackingtimeTracking = null, WorkflowValue<bool> bodyfeaturestagstags = null, WorkflowValue<bool> bodyfeaturestimeEstimatestimeEstimates = null, WorkflowValue<bool> bodyfeatureschecklistschecklist = null, WorkflowValue<bool> bodyfeaturescustomFieldscustomFields = null, WorkflowValue<bool> bodyfeaturesremapDependenciesremapDependencies = null, WorkflowValue<bool> bodyfeaturesdependencyWarningdependencyWarning = null, WorkflowValue<bool> bodyfeaturesportfoliosportfolios = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(bodyspaceName, nameof(bodyspaceName), required: false);
            WorkflowValue.Validate(bodymultipleAssignees, nameof(bodymultipleAssignees), required: false);
            WorkflowValue.Validate(bodyfeaturesdueDatesdueDates, nameof(bodyfeaturesdueDatesdueDates), required: false);
            WorkflowValue.Validate(bodyfeaturesdueDatesstartDate, nameof(bodyfeaturesdueDatesstartDate), required: false);
            WorkflowValue.Validate(bodyfeaturesdueDatesremapDueDate, nameof(bodyfeaturesdueDatesremapDueDate), required: false);
            WorkflowValue.Validate(bodyfeaturesdueDatesremapClosedDueDate, nameof(bodyfeaturesdueDatesremapClosedDueDate), required: false);
            WorkflowValue.Validate(bodyfeaturestimeTrackingtimeTracking, nameof(bodyfeaturestimeTrackingtimeTracking), required: false);
            WorkflowValue.Validate(bodyfeaturestagstags, nameof(bodyfeaturestagstags), required: false);
            WorkflowValue.Validate(bodyfeaturestimeEstimatestimeEstimates, nameof(bodyfeaturestimeEstimatestimeEstimates), required: false);
            WorkflowValue.Validate(bodyfeatureschecklistschecklist, nameof(bodyfeatureschecklistschecklist), required: false);
            WorkflowValue.Validate(bodyfeaturescustomFieldscustomFields, nameof(bodyfeaturescustomFieldscustomFields), required: false);
            WorkflowValue.Validate(bodyfeaturesremapDependenciesremapDependencies, nameof(bodyfeaturesremapDependenciesremapDependencies), required: false);
            WorkflowValue.Validate(bodyfeaturesdependencyWarningdependencyWarning, nameof(bodyfeaturesdependencyWarningdependencyWarning), required: false);
            WorkflowValue.Validate(bodyfeaturesportfoliosportfolios, nameof(bodyfeaturesportfoliosportfolios), required: false);
            return new DeferredBodyAction<CreateSpaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/team/{0}/space", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyspaceName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyspaceName);
                    bodypropCount++;
                }

                if (bodymultipleAssignees != null)
                {
                    body["multiple_assignees"] = ExpressionConverter.ConvertO(bodymultipleAssignees);
                    bodypropCount++;
                }

                var featuresObject = new JObject();
                var featuresObjectpropCount = 0;
                var dueDatesObject = new JObject();
                var dueDatesObjectpropCount = 0;
                if (bodyfeaturesdueDatesdueDates != null)
                {
                    dueDatesObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturesdueDatesdueDates);
                    dueDatesObjectpropCount++;
                }

                if (bodyfeaturesdueDatesstartDate != null)
                {
                    dueDatesObject["start_date"] = ExpressionConverter.ConvertO(bodyfeaturesdueDatesstartDate);
                    dueDatesObjectpropCount++;
                }

                if (bodyfeaturesdueDatesremapDueDate != null)
                {
                    dueDatesObject["remap_due_dates"] = ExpressionConverter.ConvertO(bodyfeaturesdueDatesremapDueDate);
                    dueDatesObjectpropCount++;
                }

                if (bodyfeaturesdueDatesremapClosedDueDate != null)
                {
                    dueDatesObject["remap_closed_due_date"] = ExpressionConverter.ConvertO(bodyfeaturesdueDatesremapClosedDueDate);
                    dueDatesObjectpropCount++;
                }

                if (dueDatesObjectpropCount > 0)
                {
                    featuresObject["due_dates"] = dueDatesObject;
                    featuresObjectpropCount++;
                }

                var timeTrackingObject = new JObject();
                var timeTrackingObjectpropCount = 0;
                if (bodyfeaturestimeTrackingtimeTracking != null)
                {
                    timeTrackingObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturestimeTrackingtimeTracking);
                    timeTrackingObjectpropCount++;
                }

                if (timeTrackingObjectpropCount > 0)
                {
                    featuresObject["time_tracking"] = timeTrackingObject;
                    featuresObjectpropCount++;
                }

                var tagsObject = new JObject();
                var tagsObjectpropCount = 0;
                if (bodyfeaturestagstags != null)
                {
                    tagsObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturestagstags);
                    tagsObjectpropCount++;
                }

                if (tagsObjectpropCount > 0)
                {
                    featuresObject["tags"] = tagsObject;
                    featuresObjectpropCount++;
                }

                var timeEstimatesObject = new JObject();
                var timeEstimatesObjectpropCount = 0;
                if (bodyfeaturestimeEstimatestimeEstimates != null)
                {
                    timeEstimatesObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturestimeEstimatestimeEstimates);
                    timeEstimatesObjectpropCount++;
                }

                if (timeEstimatesObjectpropCount > 0)
                {
                    featuresObject["time_estimates"] = timeEstimatesObject;
                    featuresObjectpropCount++;
                }

                var checklistsObject = new JObject();
                var checklistsObjectpropCount = 0;
                if (bodyfeatureschecklistschecklist != null)
                {
                    checklistsObject["enabled"] = ExpressionConverter.ConvertO(bodyfeatureschecklistschecklist);
                    checklistsObjectpropCount++;
                }

                if (checklistsObjectpropCount > 0)
                {
                    featuresObject["checklists"] = checklistsObject;
                    featuresObjectpropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (bodyfeaturescustomFieldscustomFields != null)
                {
                    customFieldsObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturescustomFieldscustomFields);
                    customFieldsObjectpropCount++;
                }

                if (customFieldsObjectpropCount > 0)
                {
                    featuresObject["custom_fields"] = customFieldsObject;
                    featuresObjectpropCount++;
                }

                var remapDependenciesObject = new JObject();
                var remapDependenciesObjectpropCount = 0;
                if (bodyfeaturesremapDependenciesremapDependencies != null)
                {
                    remapDependenciesObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturesremapDependenciesremapDependencies);
                    remapDependenciesObjectpropCount++;
                }

                if (remapDependenciesObjectpropCount > 0)
                {
                    featuresObject["remap_dependencies"] = remapDependenciesObject;
                    featuresObjectpropCount++;
                }

                var dependencyWarningObject = new JObject();
                var dependencyWarningObjectpropCount = 0;
                if (bodyfeaturesdependencyWarningdependencyWarning != null)
                {
                    dependencyWarningObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturesdependencyWarningdependencyWarning);
                    dependencyWarningObjectpropCount++;
                }

                if (dependencyWarningObjectpropCount > 0)
                {
                    featuresObject["dependency_warning"] = dependencyWarningObject;
                    featuresObjectpropCount++;
                }

                var portfoliosObject = new JObject();
                var portfoliosObjectpropCount = 0;
                if (bodyfeaturesportfoliosportfolios != null)
                {
                    portfoliosObject["enabled"] = ExpressionConverter.ConvertO(bodyfeaturesportfoliosportfolios);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateAList))]
        public IBodyWorkflowAction<CreateAListResponse> CreateAList([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyorderIndex = null, [WorkflowExpression] Func<bool> bodydueDate2 = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAListResponse> __BuildCreateAList(WorkflowValue<string> folderId, WorkflowValue<string> bodyname = null, WorkflowValue<int> bodyorderIndex = null, WorkflowValue<bool> bodydueDate2 = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyorderIndex, nameof(bodyorderIndex), required: false);
            WorkflowValue.Validate(bodydueDate2, nameof(bodydueDate2), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<CreateAListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/folder/{0}/list", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyorderIndex != null)
                {
                    body["orderindex"] = ExpressionConverter.ConvertO(bodyorderIndex);
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

                if (bodydueDate2 != null)
                {
                    body["due_date_time"] = ExpressionConverter.ConvertO(bodydueDate2);
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

                if (bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
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
