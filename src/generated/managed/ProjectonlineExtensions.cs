//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectonline
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<ProjectsWrapper, ApiConnectionActionConfiguration> ListProjects(Expression<Func<string>> siteUrl)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<ProjectsWrapper, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_api/ProjectServer/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<ProjectsWrapper>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> siteUrl, Expression<Func<CreateProjectInput>> proj)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_proj = WorkflowExpression.Compile(proj, nameof(proj), required: true);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_api/ProjectServer/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_proj);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> ListProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId, Expression<Func<string>> select = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_api/ProjectServer/Projects('{0}')", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId, Expression<Func<CreateTaskInput>> task)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_api/ProjectServer/Projects('{0}')/Draft/Tasks/Add", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_task);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<EnterpriseResource, ApiConnectionActionConfiguration> CreateResource(Expression<Func<string>> siteUrl, Expression<Func<CreateResourceInput>> resource)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            return new DeferredBodyAction<EnterpriseResource, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_api/ProjectServer/EnterpriseResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_resource);
                return new ApiConnectionAction<EnterpriseResource>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<TasksWrapper, ApiConnectionActionConfiguration> ListTasks(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<TasksWrapper, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_api/ProjectServer/Projects('{0}')/Tasks", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<TasksWrapper>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> GetProjectSummaryTask(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_api/ProjectServer/Projects('{0}')/ProjectSummaryTask", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CheckoutProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_api/ProjectServer/Projects('{0}')/checkOut", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PublishProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_api/ProjectServer/Projects('{0}')/Draft/Publish(true)", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ProjectonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerProjectsWrapper, ApiConnectionTriggerConfiguration> OnNewProject(Expression<Func<string>> siteUrl, Expression<Func<string>> select, FlowRecurrence recurrence = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            return new DeferredBodyTrigger<TriggerProjectsWrapper, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/trigger/_api/ProjectData/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TriggerResourcesWrapper, ApiConnectionTriggerConfiguration> OnNewResource(Expression<Func<string>> siteUrl, Expression<Func<string>> select, FlowRecurrence recurrence = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            return new DeferredBodyTrigger<TriggerResourcesWrapper, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/trigger/_api/ProjectData/Resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<TriggerResourcesWrapper>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TriggerTasksWrapper, ApiConnectionTriggerConfiguration> OnNewTask(Expression<Func<string>> siteUrl, Expression<Func<string>> select, FlowRecurrence recurrence = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            return new DeferredBodyTrigger<TriggerTasksWrapper, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/trigger/_api/ProjectData/Tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<TriggerTasksWrapper>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TriggerProjectsWrapper, ApiConnectionTriggerConfiguration> OnProjectPublished(Expression<Func<string>> siteUrl, Expression<Func<string>> select, FlowRecurrence recurrence = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            return new DeferredBodyTrigger<TriggerProjectsWrapper, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/trigger/_api/ProjectData/PublishedProjects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, recurrence: recurrence);
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

    public class CreateProjectInput
    {
        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }

        [JsonProperty("Description")]
        public string ProjectDescription { get; set; }

        [JsonProperty("Start")]
        public string ProjectStartDate { get; set; }
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

    public class CreateTaskInput
    {
        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public TaskParameters Parameters { get; set; }
    }

    public class TaskParameters
    {
        [JsonProperty("Name")]
        public string TaskName { get; set; }

        [JsonProperty("Notes")]
        public string TaskNotes { get; set; }

        [JsonProperty("Start")]
        public string TaskStartDate { get; set; }

        [JsonProperty("Duration")]
        public string TaskDuration { get; set; }
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

    public class CreateResourceInput
    {
        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourceName { get; set; }

        [JsonProperty("IsBudget")]
        public bool? IsResourceInBudget { get; set; }

        [JsonProperty("IsGeneric")]
        public bool? IsResourceGeneric { get; set; }

        [JsonProperty("IsInactive")]
        public bool? IsResourceInactive { get; set; }
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