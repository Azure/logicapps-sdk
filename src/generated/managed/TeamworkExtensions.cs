//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamwork
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamworkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListProjectsResponse> ListProjects()
        {
            var apiCallPath = "/projects.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks(Expression<Func<string>> projectId, Expression<Func<string>> taskListId)
        {
            var apiCallPath = String.Format("/tasklists/{0}/tasks.json", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<ListTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetTaskResponse> GetTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse> UpdateTask(Expression<Func<string>> taskId, Expression<Func<string>> bodytodoItemname = null, Expression<Func<string>> bodytodoItemdescription = null, Expression<Func<string>> bodytodoItemprogress = null, Expression<Func<string>> bodytodoItemassignTo = null, Expression<Func<string>> bodytodoItemstartDate = null, Expression<Func<string>> bodytodoItemdueDate = null, Expression<Func<string>> bodytodoItemestimatedTime = null, Expression<Func<bodytodoItempriorityInput>> bodytodoItempriority = null, Expression<Func<bool>> bodytodoItemnotifyPeople = null, Expression<Func<bool>> bodytodoItemisPrivate = null, Expression<Func<string>> bodytodoItemtags = null)
        {
            var apiCallPath = String.Format("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var todo - itemObject  =  new  JObject ( );
            var todo - itemObjectpropCount  =  0;
            if (bodytodoItemname != null)
            {
                todo - itemObject["content"] = ExpressionConverter.ConvertO(bodytodoItemname);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemdescription != null)
            {
                todo - itemObject["description"] = ExpressionConverter.ConvertO(bodytodoItemdescription);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemprogress != null)
            {
                todo - itemObject["progress"] = ExpressionConverter.ConvertO(bodytodoItemprogress);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemassignTo != null)
            {
                todo - itemObject["responsible-party-id"] = ExpressionConverter.ConvertO(bodytodoItemassignTo);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemstartDate != null)
            {
                todo - itemObject["start-date"] = ExpressionConverter.ConvertO(bodytodoItemstartDate);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemdueDate != null)
            {
                todo - itemObject["due-date"] = ExpressionConverter.ConvertO(bodytodoItemdueDate);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemestimatedTime != null)
            {
                todo - itemObject["estimated-minutes"] = ExpressionConverter.ConvertO(bodytodoItemestimatedTime);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItempriority != null)
            {
                todo - itemObject["priority"] = ExpressionConverter.ConvertO(bodytodoItempriority);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemnotifyPeople != null)
            {
                todo - itemObject["notify"] = ExpressionConverter.ConvertO(bodytodoItemnotifyPeople);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemisPrivate != null)
            {
                todo - itemObject["private"] = ExpressionConverter.ConvertO(bodytodoItemisPrivate);
                todo - itemObjectpropCount++;
            }

            if (bodytodoItemtags != null)
            {
                todo - itemObject["tags"] = ExpressionConverter.ConvertO(bodytodoItemtags);
                todo - itemObjectpropCount++;
            }

            if (todo - itemObjectpropCount > 0)
            {
                body["todo-item"] = todo-itemObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpsertTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/projects/{0}/people.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetUserResponse> GetUser(Expression<Func<string>> personId)
        {
            var apiCallPath = String.Format("/people/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserResponse>(callPayload);
        }
    }

    public class TeamworkTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListProjectsResponse
    {
        [JsonProperty("projects")]
        public ProjectResponse[] ProjectsList { get; set; }
    }

    public class ProjectResponse
    {
        [JsonProperty("category")]
        public ProjectResponseCategoryType Category { get; set; }

        [JsonProperty("company")]
        public ProjectResponseCompanyType Company { get; set; }

        [JsonProperty("created-on")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endDate")]
        public string EndDateTime { get; set; }

        [JsonProperty("harvest-timers-enabled")]
        public bool TimerEnabled { get; set; }

        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("last-changed-on")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview-start-page")]
        public string OverviewPage { get; set; }

        [JsonProperty("privacyEnabled")]
        public bool PrivacyEnabled { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("startDate")]
        public string StartDateTime { get; set; }

        [JsonProperty("start-page")]
        public string StartPage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subStatus")]
        public string Substatus { get; set; }

        [JsonProperty("tasks-start-page")]
        public string TasksStartPage { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectResponseCategoryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectResponseCompanyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProjectResponse
    {
        [JsonProperty("project")]
        public ProjectResponse Project { get; set; }
    }

    public class ListTasksResponse
    {
        [JsonProperty("todo-items")]
        public TaskResponse[] TodoItems { get; set; }
    }

    public class TaskResponse
    {
        [JsonProperty("canComplete")]
        public bool CanComplete { get; set; }

        [JsonProperty("canEdit")]
        public bool CanEdit { get; set; }

        [JsonProperty("canLogTime")]
        public bool CanLogTime { get; set; }

        [JsonProperty("company-id")]
        public int CompanyId { get; set; }

        [JsonProperty("company-name")]
        public string CompanyName { get; set; }

        [JsonProperty("completed")]
        public bool IsCompleted { get; set; }

        [JsonProperty("content")]
        public string Name { get; set; }

        [JsonProperty("created-on")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("creator-avatar-url")]
        public string CreatorAvatarURL { get; set; }

        [JsonProperty("creator-firstname")]
        public string CreatorFirstName { get; set; }

        [JsonProperty("creator-id")]
        public int CreatorId { get; set; }

        [JsonProperty("creator-lastname")]
        public string CreatorLastName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due-date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated-minutes")]
        public int EstimatedMinutes { get; set; }

        [JsonProperty("harvest-enabled")]
        public bool HarvestEnabled { get; set; }

        [JsonProperty("has-dependencies")]
        public int DependencyCount { get; set; }

        [JsonProperty("has-predecessors")]
        public int HasPredecessors { get; set; }

        [JsonProperty("has-reminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasTickets")]
        public bool HasTickets { get; set; }

        [JsonProperty("has-unread-comments")]
        public bool HasUnreadComments { get; set; }

        [JsonProperty("id")]
        public int TaskId { get; set; }

        [JsonProperty("last-changed-on")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("lockdownId")]
        public string LockDownId { get; set; }

        [JsonProperty("parentTaskId")]
        public string ParentTaskId { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("private")]
        public int Private { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("project-id")]
        public int ProjectId { get; set; }

        [JsonProperty("project-name")]
        public string ProjectName { get; set; }

        [JsonProperty("start-date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("todo-list-id")]
        public int TodoListId { get; set; }

        [JsonProperty("todo-list-name")]
        public string TodoListName { get; set; }

        [JsonProperty("userFollowingChanges")]
        public bool FollowingChanges { get; set; }

        [JsonProperty("userFollowingComments")]
        public bool FollowingComments { get; set; }
    }

    public class GetTaskResponse
    {
        [JsonProperty("todo-item")]
        public TaskResponse TodoItem { get; set; }
    }

    public class UpsertTaskResponse
    {
        [JsonProperty("id")]
        public string TaskId { get; set; }
    }

    public enum bodytodoItempriorityInput
    {
        [EnumMember(Value = "not set")]
        NotSet,
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High
    }

    public class DeleteTaskResponse
    {
        [JsonProperty("affectedTaskIds")]
        public string TaskId { get; set; }
    }

    public class ListUsersResponse
    {
        [JsonProperty("people")]
        public UserResponse[] Users { get; set; }
    }

    public class UserResponse
    {
        [JsonProperty("avatar-url")]
        public string AvatarURL { get; set; }

        [JsonProperty("company-id")]
        public string CompanyId { get; set; }

        [JsonProperty("company-name")]
        public string CompanyName { get; set; }

        [JsonProperty("email-address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email-alt-1")]
        public string EmailAlternate1 { get; set; }

        [JsonProperty("first-name")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("last-name")]
        public string LastName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("openId")]
        public string OpenId { get; set; }

        [JsonProperty("phone-number-fax")]
        public string FaxNumber { get; set; }

        [JsonProperty("phone-number-home")]
        public string Home { get; set; }

        [JsonProperty("phone-number-mobile-parts")]
        public UserResponseMobileType Mobile { get; set; }

        [JsonProperty("phone-number-office")]
        public string Office { get; set; }

        [JsonProperty("phone-number-office-ext")]
        public string OfficeExtension { get; set; }

        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("user-name")]
        public string Username { get; set; }

        [JsonProperty("user-type")]
        public string Type { get; set; }

        [JsonProperty("userUUID")]
        public string UUID { get; set; }
    }

    public class UserResponseMobileType
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("person")]
        public UserResponse Person { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teamwork;

    public partial class WorkflowManagedActions
    {
        public TeamworkActions Teamwork(string connectionId) => new TeamworkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TeamworkTriggers Teamwork(string connectionId) => new TeamworkTriggers(connectionId);
    }
}