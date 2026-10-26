//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamwork
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamworkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListProjectsResponse, ApiConnectionActionConfiguration> ListProjects()
        {
            return new DeferredBodyAction<ListProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}.json", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListTasksResponse, ApiConnectionActionConfiguration> ListTasks(Expression<Func<string>> projectId, Expression<Func<string>> taskListId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyAction<ListTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasklists/{0}/tasks.json", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<ListTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> projectId, Expression<Func<string>> taskListId, Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasklists/{0}/tasks.json", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpsertTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetTaskResponse, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}.json", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> taskId, Expression<Func<UpdateTaskInput>> body)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}.json", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpsertTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<DeleteTaskResponse, ApiConnectionActionConfiguration> DeleteTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<DeleteTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}.json", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListUsersResponse, ApiConnectionActionConfiguration> ListUsers(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/people.json", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/people.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetUserResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> personId)
        {
            var __workflow_personId = WorkflowExpression.Compile(personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/people/{0}.json", __workflow_personId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }
    }

    public class TeamworkTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> WebhookCreateProject(Expression<Func<WebhookCreateProjectInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook1/webhooks.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> WebhookCreateTask(Expression<Func<WebhookCreateTaskInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook2/webhooks.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> WebhookCreateUser(Expression<Func<WebhookCreateUserInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook3/webhooks.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
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

    public class CreateProjectInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProjectInputProjectType Project { get; set; }
    }

    public class CreateProjectInputProjectType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category-id")]
        public string CategoryId { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("newCompany")]
        public string NewCompany { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
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

    public class CreateTaskInput
    {
        [JsonProperty("todo-item", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskInputTodoItemType TodoItem { get; set; }
    }

    public class CreateTaskInputTodoItemType
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("responsible-party-id")]
        public string AssignTo { get; set; }

        [JsonProperty("start-date")]
        public string StartDate { get; set; }

        [JsonProperty("due-date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated-minutes")]
        public string EstimatedMinutes { get; set; }

        [JsonProperty("priority")]
        public CreateTaskInputTodoItemTypePriorityType? Priority { get; set; }

        [JsonProperty("notify")]
        public bool? NotifyPeople { get; set; }

        [JsonProperty("private")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskInputTodoItemTypePriorityType
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

    public class UpdateTaskInput
    {
        [JsonProperty("todo-item")]
        public UpdateTaskInputTodoItemType TodoItem { get; set; }
    }

    public class UpdateTaskInputTodoItemType
    {
        [JsonProperty("content")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("responsible-party-id")]
        public string AssignTo { get; set; }

        [JsonProperty("start-date")]
        public string StartDate { get; set; }

        [JsonProperty("due-date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated-minutes")]
        public string EstimatedTime { get; set; }

        [JsonProperty("priority")]
        public UpdateTaskInputTodoItemTypePriorityType? Priority { get; set; }

        [JsonProperty("notify")]
        public bool? NotifyPeople { get; set; }

        [JsonProperty("private")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputTodoItemTypePriorityType
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

    public class CreateUserResponse
    {
        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class CreateUserInput
    {
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserInputPersonType Person { get; set; }
    }

    public class CreateUserInputPersonType
    {
        [JsonProperty("email-address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }

        [JsonProperty("first-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("company-id")]
        public string CompanyId { get; set; }

        [JsonProperty("title")]
        public string JobTitle { get; set; }

        [JsonProperty("phone-number-home")]
        public string Home { get; set; }

        [JsonProperty("phone-number-mobile")]
        public string Mobile { get; set; }

        [JsonProperty("phone-number-office")]
        public string Office { get; set; }

        [JsonProperty("phone-number-office-ext")]
        public string OfficeExtension { get; set; }

        [JsonProperty("phone-number-fax")]
        public string Fax { get; set; }

        [JsonProperty("user-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("person")]
        public UserResponse Person { get; set; }
    }

    public class WebhookCreateProjectInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string STATUS { get; set; } = "OK";

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookCreateProjectInputWebhookType Webhook { get; set; }
    }

    public class WebhookCreateProjectInputWebhookType
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "PROJECT.CREATED";

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "ACTIVE";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookCreateTaskInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string STATUS { get; set; } = "OK";

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookCreateTaskInputWebhookType Webhook { get; set; }
    }

    public class WebhookCreateTaskInputWebhookType
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "TASK.CREATED";

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "ACTIVE";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookCreateUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string STATUS { get; set; } = "OK";

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookCreateUserInputWebhookType Webhook { get; set; }
    }

    public class WebhookCreateUserInputWebhookType
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "USER.CREATED";

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "ACTIVE";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
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