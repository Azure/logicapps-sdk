//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectonline
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<ProjectsWrapper> ListProjects(Expression<Func<string>> siteUrl)
        {
            var apiCallPath = "/_api/ProjectServer/Projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<ProjectsWrapper>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<Project> CreateProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projprojectName, Expression<Func<string>> projprojectDescription = null, Expression<Func<string>> projprojectStartDate = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<Project> ListProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/_api/ProjectServer/Projects('{0}')", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<Project>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<TaskObject> CreateTask(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId, Expression<Func<string>> taskparameterstaskName, Expression<Func<string>> taskparameterstaskNotes = null, Expression<Func<string>> taskparameterstaskStartDate = null, Expression<Func<string>> taskparameterstaskDuration = null)
        {
            var apiCallPath = String.Format("/_api/ProjectServer/Projects('{0}')/Draft/Tasks/Add", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<EnterpriseResource> CreateResource(Expression<Func<string>> siteUrl, Expression<Func<string>> resourceresourceName, Expression<Func<bool>> resourceisResourceInBudget = null, Expression<Func<bool>> resourceisResourceGeneric = null, Expression<Func<bool>> resourceisResourceInactive = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<TasksWrapper> ListTasks(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/_api/ProjectServer/Projects('{0}')/Tasks", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<TasksWrapper>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<TaskObject> GetProjectSummaryTask(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/_api/ProjectServer/Projects('{0}')/ProjectSummaryTask", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<JToken> CheckoutProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/_api/ProjectServer/Projects('{0}')/checkOut", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectonline")]
        public IBodyWorkflowAction<JToken> PublishProject(Expression<Func<string>> siteUrl, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/_api/ProjectServer/Projects('{0}')/Draft/Publish(true)", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ProjectonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerProjectsWrapper> OnNewProject(Expression<Func<string>> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/_api/ProjectData/Projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectsWrapper> OnProjectPublished(Expression<Func<string>> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/_api/ProjectData/PublishedProjects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerResourcesWrapper> OnNewResource(Expression<Func<string>> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/_api/ProjectData/Resources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionTrigger<TriggerResourcesWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerTasksWrapper> OnNewTask(Expression<Func<string>> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/_api/ProjectData/Tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionTrigger<TriggerTasksWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectsWrapper> OnNewProjectV2(Expression<Func<string>> siteUrl, Expression<Func<string>> select, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/trigger/_api/ProjectData/Projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectsWrapper> OnProjectPublishedV2(Expression<Func<string>> siteUrl, Expression<Func<string>> select, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/trigger/_api/ProjectData/PublishedProjects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<TriggerProjectsWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerResourcesWrapper> OnNewResourceV2(Expression<Func<string>> siteUrl, Expression<Func<string>> select, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/trigger/_api/ProjectData/Resources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<TriggerResourcesWrapper>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerTasksWrapper> OnNewTaskV2(Expression<Func<string>> siteUrl, Expression<Func<string>> select, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/trigger/_api/ProjectData/Tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionTrigger<TriggerTasksWrapper>(callPayload, triggerName, recurrence);
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