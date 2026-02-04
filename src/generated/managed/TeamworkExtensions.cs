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
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject(Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyprojectdescription = null, Expression<Func<string>> bodyprojectcategoryId = null, Expression<Func<string>> bodyprojectcompanyId = null, Expression<Func<string>> bodyprojectnewCompany = null, Expression<Func<string>> bodyprojectstartDate = null, Expression<Func<string>> bodyprojectendDate = null, Expression<Func<string>> bodyprojecttags = null)
        {
            var apiCallPath = "/projects.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var projectObject = new JObject();
            var projectObjectpropCount = 0;
            if (bodyprojectname != null)
            {
                projectObject["name"] = ExpressionConverter.ConvertO(bodyprojectname);
                projectObjectpropCount++;
            }

            if (bodyprojectdescription != null)
            {
                projectObject["description"] = ExpressionConverter.ConvertO(bodyprojectdescription);
                projectObjectpropCount++;
            }

            if (bodyprojectcategoryId != null)
            {
                projectObject["category-id"] = ExpressionConverter.ConvertO(bodyprojectcategoryId);
                projectObjectpropCount++;
            }

            if (bodyprojectcompanyId != null)
            {
                projectObject["companyId"] = ExpressionConverter.ConvertO(bodyprojectcompanyId);
                projectObjectpropCount++;
            }

            if (bodyprojectnewCompany != null)
            {
                projectObject["newCompany"] = ExpressionConverter.ConvertO(bodyprojectnewCompany);
                projectObjectpropCount++;
            }

            if (bodyprojectstartDate != null)
            {
                projectObject["startDate"] = ExpressionConverter.ConvertO(bodyprojectstartDate);
                projectObjectpropCount++;
            }

            if (bodyprojectendDate != null)
            {
                projectObject["endDate"] = ExpressionConverter.ConvertO(bodyprojectendDate);
                projectObjectpropCount++;
            }

            if (bodyprojecttags != null)
            {
                projectObject["tags"] = ExpressionConverter.ConvertO(bodyprojecttags);
                projectObjectpropCount++;
            }

            if (projectObjectpropCount > 0)
            {
                body["project"] = projectObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateProjectResponse>(callPayload);
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
        public IBodyWorkflowAction<UpsertTaskResponse> CreateTask(Expression<Func<string>> projectId, Expression<Func<string>> taskListId, Expression<Func<string>> bodytodoItemname = null, Expression<Func<string>> bodytodoItemdescription = null, Expression<Func<string>> bodytodoItemprogress = null, Expression<Func<string>> bodytodoItemassignTo = null, Expression<Func<string>> bodytodoItemstartDate = null, Expression<Func<string>> bodytodoItemdueDate = null, Expression<Func<string>> bodytodoItemestimatedMinutes = null, Expression<Func<bodytodoItempriorityInput>> bodytodoItempriority = null, Expression<Func<bool>> bodytodoItemnotifyPeople = null, Expression<Func<bool>> bodytodoItemisPrivate = null, Expression<Func<string>> bodytodoItemtags = null)
        {
            var apiCallPath = String.Format("/tasklists/{0}/tasks.json", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            var body = new JObject();
            var bodypropCount = 0;
            var todoItemObject = new JObject();
            var todoItemObjectpropCount = 0;
            if (bodytodoItemname != null)
            {
                todoItemObject["content"] = ExpressionConverter.ConvertO(bodytodoItemname);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemdescription != null)
            {
                todoItemObject["description"] = ExpressionConverter.ConvertO(bodytodoItemdescription);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemprogress != null)
            {
                todoItemObject["progress"] = ExpressionConverter.ConvertO(bodytodoItemprogress);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemassignTo != null)
            {
                todoItemObject["responsible-party-id"] = ExpressionConverter.ConvertO(bodytodoItemassignTo);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemstartDate != null)
            {
                todoItemObject["start-date"] = ExpressionConverter.ConvertO(bodytodoItemstartDate);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemdueDate != null)
            {
                todoItemObject["due-date"] = ExpressionConverter.ConvertO(bodytodoItemdueDate);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemestimatedMinutes != null)
            {
                todoItemObject["estimated-minutes"] = ExpressionConverter.ConvertO(bodytodoItemestimatedMinutes);
                todoItemObjectpropCount++;
            }

            if (bodytodoItempriority != null)
            {
                todoItemObject["priority"] = ExpressionConverter.ConvertO(bodytodoItempriority);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemnotifyPeople != null)
            {
                todoItemObject["notify"] = ExpressionConverter.ConvertO(bodytodoItemnotifyPeople);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemisPrivate != null)
            {
                todoItemObject["private"] = ExpressionConverter.ConvertO(bodytodoItemisPrivate);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemtags != null)
            {
                todoItemObject["tags"] = ExpressionConverter.ConvertO(bodytodoItemtags);
                todoItemObjectpropCount++;
            }

            if (todoItemObjectpropCount > 0)
            {
                body["todo-item"] = todoItemObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpsertTaskResponse>(callPayload);
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
            var todoItemObject = new JObject();
            var todoItemObjectpropCount = 0;
            if (bodytodoItemname != null)
            {
                todoItemObject["content"] = ExpressionConverter.ConvertO(bodytodoItemname);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemdescription != null)
            {
                todoItemObject["description"] = ExpressionConverter.ConvertO(bodytodoItemdescription);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemprogress != null)
            {
                todoItemObject["progress"] = ExpressionConverter.ConvertO(bodytodoItemprogress);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemassignTo != null)
            {
                todoItemObject["responsible-party-id"] = ExpressionConverter.ConvertO(bodytodoItemassignTo);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemstartDate != null)
            {
                todoItemObject["start-date"] = ExpressionConverter.ConvertO(bodytodoItemstartDate);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemdueDate != null)
            {
                todoItemObject["due-date"] = ExpressionConverter.ConvertO(bodytodoItemdueDate);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemestimatedTime != null)
            {
                todoItemObject["estimated-minutes"] = ExpressionConverter.ConvertO(bodytodoItemestimatedTime);
                todoItemObjectpropCount++;
            }

            if (bodytodoItempriority != null)
            {
                todoItemObject["priority"] = ExpressionConverter.ConvertO(bodytodoItempriority);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemnotifyPeople != null)
            {
                todoItemObject["notify"] = ExpressionConverter.ConvertO(bodytodoItemnotifyPeople);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemisPrivate != null)
            {
                todoItemObject["private"] = ExpressionConverter.ConvertO(bodytodoItemisPrivate);
                todoItemObjectpropCount++;
            }

            if (bodytodoItemtags != null)
            {
                todoItemObject["tags"] = ExpressionConverter.ConvertO(bodytodoItemtags);
                todoItemObjectpropCount++;
            }

            if (todoItemObjectpropCount > 0)
            {
                body["todo-item"] = todoItemObject;
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
        public IBodyWorkflowAction<CreateUserResponse> CreateUser(Expression<Func<string>> bodypersonemailAddress = null, Expression<Func<string>> bodypersonfirstName = null, Expression<Func<string>> bodypersonlastName = null, Expression<Func<string>> bodypersoncompanyId = null, Expression<Func<string>> bodypersonjobTitle = null, Expression<Func<string>> bodypersonhome = null, Expression<Func<string>> bodypersonmobile = null, Expression<Func<string>> bodypersonoffice = null, Expression<Func<string>> bodypersonofficeExtension = null, Expression<Func<string>> bodypersonfax = null, Expression<Func<string>> bodypersonusername = null)
        {
            var apiCallPath = "/people.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var personObject = new JObject();
            var personObjectpropCount = 0;
            if (bodypersonemailAddress != null)
            {
                personObject["email-address"] = ExpressionConverter.ConvertO(bodypersonemailAddress);
                personObjectpropCount++;
            }

            if (bodypersonfirstName != null)
            {
                personObject["first-name"] = ExpressionConverter.ConvertO(bodypersonfirstName);
                personObjectpropCount++;
            }

            if (bodypersonlastName != null)
            {
                personObject["last-name"] = ExpressionConverter.ConvertO(bodypersonlastName);
                personObjectpropCount++;
            }

            if (bodypersoncompanyId != null)
            {
                personObject["company-id"] = ExpressionConverter.ConvertO(bodypersoncompanyId);
                personObjectpropCount++;
            }

            if (bodypersonjobTitle != null)
            {
                personObject["title"] = ExpressionConverter.ConvertO(bodypersonjobTitle);
                personObjectpropCount++;
            }

            if (bodypersonhome != null)
            {
                personObject["phone-number-home"] = ExpressionConverter.ConvertO(bodypersonhome);
                personObjectpropCount++;
            }

            if (bodypersonmobile != null)
            {
                personObject["phone-number-mobile"] = ExpressionConverter.ConvertO(bodypersonmobile);
                personObjectpropCount++;
            }

            if (bodypersonoffice != null)
            {
                personObject["phone-number-office"] = ExpressionConverter.ConvertO(bodypersonoffice);
                personObjectpropCount++;
            }

            if (bodypersonofficeExtension != null)
            {
                personObject["phone-number-office-ext"] = ExpressionConverter.ConvertO(bodypersonofficeExtension);
                personObjectpropCount++;
            }

            if (bodypersonfax != null)
            {
                personObject["phone-number-fax"] = ExpressionConverter.ConvertO(bodypersonfax);
                personObjectpropCount++;
            }

            if (bodypersonusername != null)
            {
                personObject["user-name"] = ExpressionConverter.ConvertO(bodypersonusername);
                personObjectpropCount++;
            }

            if (personObjectpropCount > 0)
            {
                body["person"] = personObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUserResponse>(callPayload);
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
        public IBodyWorkflowTrigger<string> WebhookCreateProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook1/webhooks.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["STATUS"] = "OK";
            bodypropCount++;
            var webhookObject = new JObject();
            var webhookObjectpropCount = 0;
            webhookObject["event"] = "PROJECT.CREATED";
            webhookObjectpropCount++;
            webhookObject["status"] = "ACTIVE";
            webhookObjectpropCount++;
            webhookObject["url"] = "@listCallbackUrl()";
            webhookObjectpropCount++;
            if (webhookObjectpropCount > 0)
            {
                body["webhook"] = webhookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCreateTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook2/webhooks.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["STATUS"] = "OK";
            bodypropCount++;
            var webhookObject = new JObject();
            var webhookObjectpropCount = 0;
            webhookObject["event"] = "TASK.CREATED";
            webhookObjectpropCount++;
            webhookObject["status"] = "ACTIVE";
            webhookObjectpropCount++;
            webhookObject["url"] = "@listCallbackUrl()";
            webhookObjectpropCount++;
            if (webhookObjectpropCount > 0)
            {
                body["webhook"] = webhookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCreateUser(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook3/webhooks.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["STATUS"] = "OK";
            bodypropCount++;
            var webhookObject = new JObject();
            var webhookObjectpropCount = 0;
            webhookObject["event"] = "USER.CREATED";
            webhookObjectpropCount++;
            webhookObject["status"] = "ACTIVE";
            webhookObjectpropCount++;
            webhookObject["url"] = "@listCallbackUrl()";
            webhookObjectpropCount++;
            if (webhookObjectpropCount > 0)
            {
                body["webhook"] = webhookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }
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

    public class CreateProjectResponse
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }
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

    public class GetTaskResponse
    {
        [JsonProperty("todo-item")]
        public TaskResponse TodoItem { get; set; }
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

    public class CreateUserResponse
    {
        [JsonProperty("id")]
        public string UserId { get; set; }
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