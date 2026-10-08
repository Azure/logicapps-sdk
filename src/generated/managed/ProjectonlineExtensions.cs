//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectonline
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectonlineActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildListProjects))]
        public IBodyWorkflowAction<ProjectsWrapper> ListProjects([WorkflowExpression] Func<string> siteUrl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectsWrapper> __BuildListProjects(WorkflowExpression<string> siteUrl)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<ProjectsWrapper>(() =>
            {
                var apiCallPath = "/_api/ProjectServer/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<ProjectsWrapper>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<Project> CreateProject([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projprojectName, [WorkflowExpression] Func<string> projprojectDescription = null, [WorkflowExpression] Func<string> projprojectStartDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Project> __BuildCreateProject(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projprojectName, WorkflowExpression<string> projprojectDescription = null, WorkflowExpression<string> projprojectStartDate = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projprojectName, nameof(projprojectName), required: true);
            WorkflowExpression.Validate(projprojectDescription, nameof(projprojectDescription), required: false);
            WorkflowExpression.Validate(projprojectStartDate, nameof(projprojectStartDate), required: false);
            return new DeferredBodyAction<Project>(() =>
            {
                var apiCallPath = "/_api/ProjectServer/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                var proj = new JObject();
                var projpropCount = 0;
                projpropCount++;
                proj["Name"] = ExpressionConverter.ConvertO(projprojectName);
                if (projprojectDescription != null)
                {
                    proj["Description"] = ExpressionConverter.ConvertO(projprojectDescription);
                    projpropCount++;
                }

                if (projprojectStartDate != null)
                {
                    proj["Start"] = ExpressionConverter.ConvertO(projprojectStartDate);
                    projpropCount++;
                }

                if (projpropCount > 0)
                {
                    callPayload.Body = proj;
                }

                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildListProject))]
        public IBodyWorkflowAction<Project> ListProject([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Project> __BuildListProject(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projectId, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<Project>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/ProjectServer/Projects('{0}')", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<TaskObject> CreateTask([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> taskparameterstaskName, [WorkflowExpression] Func<string> taskparameterstaskNotes = null, [WorkflowExpression] Func<string> taskparameterstaskStartDate = null, [WorkflowExpression] Func<string> taskparameterstaskDuration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildCreateTask(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projectId, WorkflowExpression<string> taskparameterstaskName, WorkflowExpression<string> taskparameterstaskNotes = null, WorkflowExpression<string> taskparameterstaskStartDate = null, WorkflowExpression<string> taskparameterstaskDuration = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(taskparameterstaskName, nameof(taskparameterstaskName), required: true);
            WorkflowExpression.Validate(taskparameterstaskNotes, nameof(taskparameterstaskNotes), required: false);
            WorkflowExpression.Validate(taskparameterstaskStartDate, nameof(taskparameterstaskStartDate), required: false);
            WorkflowExpression.Validate(taskparameterstaskDuration, nameof(taskparameterstaskDuration), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/ProjectServer/Projects('{0}')/Draft/Tasks/Add", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                var task = new JObject();
                var taskpropCount = 0;
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                parametersObjectpropCount++;
                parametersObject["Name"] = ExpressionConverter.ConvertO(taskparameterstaskName);
                if (taskparameterstaskNotes != null)
                {
                    parametersObject["Notes"] = ExpressionConverter.ConvertO(taskparameterstaskNotes);
                    parametersObjectpropCount++;
                }

                if (taskparameterstaskStartDate != null)
                {
                    parametersObject["Start"] = ExpressionConverter.ConvertO(taskparameterstaskStartDate);
                    parametersObjectpropCount++;
                }

                if (taskparameterstaskDuration != null)
                {
                    parametersObject["Duration"] = ExpressionConverter.ConvertO(taskparameterstaskDuration);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    task["parameters"] = parametersObject;
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildCreateResource))]
        public IBodyWorkflowAction<EnterpriseResource> CreateResource([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> resourceresourceName, [WorkflowExpression] Func<bool> resourceisResourceInBudget = null, [WorkflowExpression] Func<bool> resourceisResourceGeneric = null, [WorkflowExpression] Func<bool> resourceisResourceInactive = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnterpriseResource> __BuildCreateResource(WorkflowExpression<string> siteUrl, WorkflowExpression<string> resourceresourceName, WorkflowExpression<bool> resourceisResourceInBudget = null, WorkflowExpression<bool> resourceisResourceGeneric = null, WorkflowExpression<bool> resourceisResourceInactive = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(resourceresourceName, nameof(resourceresourceName), required: true);
            WorkflowExpression.Validate(resourceisResourceInBudget, nameof(resourceisResourceInBudget), required: false);
            WorkflowExpression.Validate(resourceisResourceGeneric, nameof(resourceisResourceGeneric), required: false);
            WorkflowExpression.Validate(resourceisResourceInactive, nameof(resourceisResourceInactive), required: false);
            return new DeferredBodyAction<EnterpriseResource>(() =>
            {
                var apiCallPath = "/_api/ProjectServer/EnterpriseResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                var resource = new JObject();
                var resourcepropCount = 0;
                resourcepropCount++;
                resource["Name"] = ExpressionConverter.ConvertO(resourceresourceName);
                if (resourceisResourceInBudget != null)
                {
                    resource["IsBudget"] = ExpressionConverter.ConvertO(resourceisResourceInBudget);
                    resourcepropCount++;
                }

                if (resourceisResourceGeneric != null)
                {
                    resource["IsGeneric"] = ExpressionConverter.ConvertO(resourceisResourceGeneric);
                    resourcepropCount++;
                }

                if (resourceisResourceInactive != null)
                {
                    resource["IsInactive"] = ExpressionConverter.ConvertO(resourceisResourceInactive);
                    resourcepropCount++;
                }

                if (resourcepropCount > 0)
                {
                    callPayload.Body = resource;
                }

                return new ApiConnectionAction<EnterpriseResource>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildListTasks))]
        public IBodyWorkflowAction<TasksWrapper> ListTasks([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TasksWrapper> __BuildListTasks(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projectId, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<TasksWrapper>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/ProjectServer/Projects('{0}')/Tasks", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<TasksWrapper>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectSummaryTask))]
        public IBodyWorkflowAction<TaskObject> GetProjectSummaryTask([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildGetProjectSummaryTask(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/ProjectServer/Projects('{0}')/ProjectSummaryTask", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildCheckoutProject))]
        public IBodyWorkflowAction<JToken> CheckoutProject([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCheckoutProject(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/ProjectServer/Projects('{0}')/checkOut", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        [WorkflowExpressionFactory(nameof(__BuildPublishProject))]
        public IBodyWorkflowAction<JToken> PublishProject([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPublishProject(WorkflowExpression<string> siteUrl, WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/ProjectServer/Projects('{0}')/Draft/Publish(true)", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ProjectonlineTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewProject))]
        public IBodyWorkflowTrigger<TriggerProjectsWrapper> OnNewProject([WorkflowExpression] Func<string> siteUrl,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerProjectsWrapper> __BuildOnNewProject(WorkflowExpression<string> siteUrl,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyTrigger<TriggerProjectsWrapper>(() =>
            {
                var apiCallPath = "/trigger/_api/ProjectData/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnProjectPublished))]
        public IBodyWorkflowTrigger<TriggerProjectsWrapper> OnProjectPublished([WorkflowExpression] Func<string> siteUrl,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerProjectsWrapper> __BuildOnProjectPublished(WorkflowExpression<string> siteUrl,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyTrigger<TriggerProjectsWrapper>(() =>
            {
                var apiCallPath = "/trigger/_api/ProjectData/PublishedProjects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewResource))]
        public IBodyWorkflowTrigger<TriggerResourcesWrapper> OnNewResource([WorkflowExpression] Func<string> siteUrl,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerResourcesWrapper> __BuildOnNewResource(WorkflowExpression<string> siteUrl,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyTrigger<TriggerResourcesWrapper>(() =>
            {
                var apiCallPath = "/trigger/_api/ProjectData/Resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionTrigger<TriggerResourcesWrapper>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewTask))]
        public IBodyWorkflowTrigger<TriggerTasksWrapper> OnNewTask([WorkflowExpression] Func<string> siteUrl,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerTasksWrapper> __BuildOnNewTask(WorkflowExpression<string> siteUrl,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyTrigger<TriggerTasksWrapper>(() =>
            {
                var apiCallPath = "/trigger/_api/ProjectData/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionTrigger<TriggerTasksWrapper>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ProjectsWrapper
    {
        [JsonProperty("value")]
        public Project[] ReturnedProjects { get; set; }
    }

    public class Project
    {
        [JsonProperty("ApprovedStart")]
        public string ApprovedStartDate { get; set; }

        [JsonProperty("ApprovedEnd")]
        public string ApprovedEndDate { get; set; }
        public string CheckedOutDate { get; set; }

        [JsonProperty("CheckOutDescription")]
        public string CheckoutDescription { get; set; }

        [JsonProperty("CheckOutId")]
        public string CheckoutId { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("Id")]
        public string ProjectId { get; set; }
        public bool IsCheckedOut { get; set; }
        public string LastPublishedDate { get; set; }
        public string LastSavedDate { get; set; }
        public int OptimizerDecision { get; set; }
        public int PlannerDecision { get; set; }
        public int ProjectType { get; set; }

        [JsonProperty("Name")]
        public string ProjectName { get; set; }
        public string ProjectIdentifier { get; set; }

        [JsonProperty("WinprojVersion")]
        public string WinProjVersion { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("Created")]
        public string TaskCreatedDate { get; set; }

        [JsonProperty("Modified")]
        public string TaskLastModifiedDate { get; set; }

        [JsonProperty("Start")]
        public string TaskStartDate { get; set; }

        [JsonProperty("Finish")]
        public string TaskFinishDate { get; set; }

        [JsonProperty("ScheduledStart")]
        public string TaskScheduledStartDate { get; set; }

        [JsonProperty("ScheduledFinish")]
        public string TaskScheduledFinishDate { get; set; }

        [JsonProperty("Name")]
        public string TaskName { get; set; }

        [JsonProperty("Id")]
        public string TaskId { get; set; }

        [JsonProperty("Priority")]
        public int TaskPriority { get; set; }

        [JsonProperty("PercentComplete")]
        public int TaskPercentComplete { get; set; }

        [JsonProperty("Notes")]
        public string TaskNotes { get; set; }

        [JsonProperty("Contact")]
        public string TaskContact { get; set; }

        [JsonProperty("IsMilestone")]
        public bool IsMilestoneTask { get; set; }
    }

    public class EnterpriseResource
    {
        [JsonProperty("CanLevel")]
        public bool CanResourceLevel { get; set; }

        [JsonProperty("Code")]
        public string ResourceCode { get; set; }

        [JsonProperty("CostAccrual")]
        public int ResourceCostAccrual { get; set; }

        [JsonProperty("CostCenter")]
        public string ResourceCostCenter { get; set; }

        [JsonProperty("Created")]
        public string ResourceCreatedTime { get; set; }
        public int DefaultBookingType { get; set; }
        public string Email { get; set; }
        public string ExternalId { get; set; }

        [JsonProperty("Group")]
        public string ResourceGroup { get; set; }
        public string HireDate { get; set; }

        [JsonProperty("Id")]
        public string ResourceId { get; set; }

        [JsonProperty("Initials")]
        public string ResouceInitials { get; set; }

        [JsonProperty("IsActive")]
        public bool IsResourceActive { get; set; }
        public bool IsBudget { get; set; }
        public bool IsCheckedOut { get; set; }
        public bool IsGeneric { get; set; }
        public bool IsTeam { get; set; }
        public string MaterialLabel { get; set; }

        [JsonProperty("Modified")]
        public string LastModified { get; set; }

        [JsonProperty("Name")]
        public string ResourceName { get; set; }

        [JsonProperty("Phonetics")]
        public string ResourcePhonetics { get; set; }
        public int ResourceType { get; set; }
        public string TerminationDate { get; set; }
    }

    public class TasksWrapper
    {
        [JsonProperty("value")]
        public TaskObject[] ReturnedTasks { get; set; }
    }

    public class TriggerProjectsWrapper
    {
        [JsonProperty("value")]
        public TriggerProject[] ReturnedProjects { get; set; }
    }

    public class TriggerProject
    {
        public string ProjectStartDate { get; set; }

        [JsonProperty("ProjectFinishDate")]
        public string ProjectEndDate { get; set; }

        [JsonProperty("ProjectCreatedDate")]
        public string CreatedDate { get; set; }
        public string ProjectId { get; set; }

        [JsonProperty("ProjectModifiedDate")]
        public string LastModifiedDate { get; set; }
        public int ProjectType { get; set; }
        public string ProjectName { get; set; }

        [JsonProperty("ProjectLastPublishedDate")]
        public string LastPublishedDate { get; set; }

        [JsonProperty("ProjectOwnerName")]
        public string ProjectOwner { get; set; }
        public int ProjectPercentCompleted { get; set; }
        public int ProjectPercentWorkCompleted { get; set; }
        public string ProjectOvertimeCost { get; set; }
        public string ProjectOvertimeWork { get; set; }
    }

    public class TriggerResourcesWrapper
    {
        [JsonProperty("value")]
        public TriggerResource[] ReturnedResources { get; set; }
    }

    public class TriggerResource
    {
        public string ResourceId { get; set; }

        [JsonProperty("ResourceBaseCalendar")]
        public string BaseCalendar { get; set; }
        public int ResourceBookingType { get; set; }

        [JsonProperty("ResourceCanLevel")]
        public bool CanResourceLevel { get; set; }
        public string ResourceCostPerUse { get; set; }

        [JsonProperty("ResourceCreatedDate")]
        public string ResourceCreateDate { get; set; }
        public string ResourceEarliestAvailableFrom { get; set; }

        [JsonProperty("ResourceEmailAddress")]
        public string ResourceEmail { get; set; }
        public string ResourceInitials { get; set; }

        [JsonProperty("ResourceIsActive")]
        public bool IsResourceActivew { get; set; }

        [JsonProperty("ResourceIsGeneric")]
        public bool IsResourceGeneric { get; set; }
        public string ResourceLatestAvailableTo { get; set; }

        [JsonProperty("ResourceModifiedDate")]
        public string ResourceLastModifiedDate { get; set; }
        public string ResourceName { get; set; }

        [JsonProperty("ResourceStatsuName")]
        public string ResourceStatusName { get; set; }
        public int ResourceType { get; set; }

        [JsonProperty("TypeDescription")]
        public string ResourceTypeDescription { get; set; }

        [JsonProperty("TypeName")]
        public string ResourceTypeName { get; set; }
    }

    public class TriggerTasksWrapper
    {
        [JsonProperty("value")]
        public TriggerTask[] ReturnedTasks { get; set; }
    }

    public class TriggerTask
    {
        public string ProjectId { get; set; }
        public string TaskId { get; set; }
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public string TaskCreatedDate { get; set; }

        [JsonProperty("TaskModifieddate")]
        public string TaskLastModifiedDate { get; set; }
        public string TaskStartDate { get; set; }
        public string TaskFinishDate { get; set; }

        [JsonProperty("TaskPriority")]
        public int TaskSummary { get; set; }
        public bool TaskIsActive { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Projectonline;

    public partial class WorkflowManagedActions
    {
        public ProjectonlineActions Projectonline(string connectionId) => new ProjectonlineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProjectonlineTriggers Projectonline(string connectionId) => new ProjectonlineTriggers(connectionId);
    }
}