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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyprojectdescription = null, [WorkflowExpression] Func<string> bodyprojectcategoryId = null, [WorkflowExpression] Func<string> bodyprojectcompanyId = null, [WorkflowExpression] Func<string> bodyprojectnewCompany = null, [WorkflowExpression] Func<string> bodyprojectstartDate = null, [WorkflowExpression] Func<string> bodyprojectendDate = null, [WorkflowExpression] Func<string> bodyprojecttags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    projectObject["name"] = SourceExpressionConverter.ConvertToken(bodyprojectname);
                    projectObjectpropCount++;
                }

                if (bodyprojectdescription != null)
                {
                    projectObject["description"] = SourceExpressionConverter.ConvertToken(bodyprojectdescription);
                    projectObjectpropCount++;
                }

                if (bodyprojectcategoryId != null)
                {
                    projectObject["category-id"] = SourceExpressionConverter.ConvertToken(bodyprojectcategoryId);
                    projectObjectpropCount++;
                }

                if (bodyprojectcompanyId != null)
                {
                    projectObject["companyId"] = SourceExpressionConverter.ConvertToken(bodyprojectcompanyId);
                    projectObjectpropCount++;
                }

                if (bodyprojectnewCompany != null)
                {
                    projectObject["newCompany"] = SourceExpressionConverter.ConvertToken(bodyprojectnewCompany);
                    projectObjectpropCount++;
                }

                if (bodyprojectstartDate != null)
                {
                    projectObject["startDate"] = SourceExpressionConverter.ConvertToken(bodyprojectstartDate);
                    projectObjectpropCount++;
                }

                if (bodyprojectendDate != null)
                {
                    projectObject["endDate"] = SourceExpressionConverter.ConvertToken(bodyprojectendDate);
                    projectObjectpropCount++;
                }

                if (bodyprojecttags != null)
                {
                    projectObject["tags"] = SourceExpressionConverter.ConvertToken(bodyprojecttags);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> taskListId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasklists/{0}/tasks.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse> CreateTask([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> taskListId, [WorkflowExpression] Func<string> bodytodoItemname = null, [WorkflowExpression] Func<string> bodytodoItemdescription = null, [WorkflowExpression] Func<string> bodytodoItemprogress = null, [WorkflowExpression] Func<string> bodytodoItemassignTo = null, [WorkflowExpression] Func<string> bodytodoItemstartDate = null, [WorkflowExpression] Func<string> bodytodoItemdueDate = null, [WorkflowExpression] Func<string> bodytodoItemestimatedMinutes = null, [WorkflowExpression] Func<bodytodoItempriorityInput> bodytodoItempriority = null, [WorkflowExpression] Func<bool> bodytodoItemnotifyPeople = null, [WorkflowExpression] Func<bool> bodytodoItemisPrivate = null, [WorkflowExpression] Func<string> bodytodoItemtags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasklists/{0}/tasks.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                var body = new JObject();
                var bodypropCount = 0;
                var todoItemObject = new JObject();
                var todoItemObjectpropCount = 0;
                if (bodytodoItemname != null)
                {
                    todoItemObject["content"] = SourceExpressionConverter.ConvertToken(bodytodoItemname);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemdescription != null)
                {
                    todoItemObject["description"] = SourceExpressionConverter.ConvertToken(bodytodoItemdescription);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemprogress != null)
                {
                    todoItemObject["progress"] = SourceExpressionConverter.ConvertToken(bodytodoItemprogress);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemassignTo != null)
                {
                    todoItemObject["responsible-party-id"] = SourceExpressionConverter.ConvertToken(bodytodoItemassignTo);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemstartDate != null)
                {
                    todoItemObject["start-date"] = SourceExpressionConverter.ConvertToken(bodytodoItemstartDate);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemdueDate != null)
                {
                    todoItemObject["due-date"] = SourceExpressionConverter.ConvertToken(bodytodoItemdueDate);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemestimatedMinutes != null)
                {
                    todoItemObject["estimated-minutes"] = SourceExpressionConverter.ConvertToken(bodytodoItemestimatedMinutes);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItempriority != null)
                {
                    todoItemObject["priority"] = SourceExpressionConverter.Convert(bodytodoItempriority);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemnotifyPeople != null)
                {
                    todoItemObject["notify"] = SourceExpressionConverter.ConvertToken(bodytodoItemnotifyPeople);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemisPrivate != null)
                {
                    todoItemObject["private"] = SourceExpressionConverter.ConvertToken(bodytodoItemisPrivate);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemtags != null)
                {
                    todoItemObject["tags"] = SourceExpressionConverter.ConvertToken(bodytodoItemtags);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpsertTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetTaskResponse> GetTask([WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse> UpdateTask([WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodytodoItemname = null, [WorkflowExpression] Func<string> bodytodoItemdescription = null, [WorkflowExpression] Func<string> bodytodoItemprogress = null, [WorkflowExpression] Func<string> bodytodoItemassignTo = null, [WorkflowExpression] Func<string> bodytodoItemstartDate = null, [WorkflowExpression] Func<string> bodytodoItemdueDate = null, [WorkflowExpression] Func<string> bodytodoItemestimatedTime = null, [WorkflowExpression] Func<bodytodoItempriorityInput> bodytodoItempriority = null, [WorkflowExpression] Func<bool> bodytodoItemnotifyPeople = null, [WorkflowExpression] Func<bool> bodytodoItemisPrivate = null, [WorkflowExpression] Func<string> bodytodoItemtags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var todoItemObject = new JObject();
                var todoItemObjectpropCount = 0;
                if (bodytodoItemname != null)
                {
                    todoItemObject["content"] = SourceExpressionConverter.ConvertToken(bodytodoItemname);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemdescription != null)
                {
                    todoItemObject["description"] = SourceExpressionConverter.ConvertToken(bodytodoItemdescription);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemprogress != null)
                {
                    todoItemObject["progress"] = SourceExpressionConverter.ConvertToken(bodytodoItemprogress);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemassignTo != null)
                {
                    todoItemObject["responsible-party-id"] = SourceExpressionConverter.ConvertToken(bodytodoItemassignTo);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemstartDate != null)
                {
                    todoItemObject["start-date"] = SourceExpressionConverter.ConvertToken(bodytodoItemstartDate);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemdueDate != null)
                {
                    todoItemObject["due-date"] = SourceExpressionConverter.ConvertToken(bodytodoItemdueDate);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemestimatedTime != null)
                {
                    todoItemObject["estimated-minutes"] = SourceExpressionConverter.ConvertToken(bodytodoItemestimatedTime);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItempriority != null)
                {
                    todoItemObject["priority"] = SourceExpressionConverter.Convert(bodytodoItempriority);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemnotifyPeople != null)
                {
                    todoItemObject["notify"] = SourceExpressionConverter.ConvertToken(bodytodoItemnotifyPeople);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemisPrivate != null)
                {
                    todoItemObject["private"] = SourceExpressionConverter.ConvertToken(bodytodoItemisPrivate);
                    todoItemObjectpropCount++;
                }

                if (bodytodoItemtags != null)
                {
                    todoItemObject["tags"] = SourceExpressionConverter.ConvertToken(bodytodoItemtags);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpsertTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask([WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/people.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodypersonemailAddress = null, [WorkflowExpression] Func<string> bodypersonfirstName = null, [WorkflowExpression] Func<string> bodypersonlastName = null, [WorkflowExpression] Func<string> bodypersoncompanyId = null, [WorkflowExpression] Func<string> bodypersonjobTitle = null, [WorkflowExpression] Func<string> bodypersonhome = null, [WorkflowExpression] Func<string> bodypersonmobile = null, [WorkflowExpression] Func<string> bodypersonoffice = null, [WorkflowExpression] Func<string> bodypersonofficeExtension = null, [WorkflowExpression] Func<string> bodypersonfax = null, [WorkflowExpression] Func<string> bodypersonusername = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    personObject["email-address"] = SourceExpressionConverter.ConvertToken(bodypersonemailAddress);
                    personObjectpropCount++;
                }

                if (bodypersonfirstName != null)
                {
                    personObject["first-name"] = SourceExpressionConverter.ConvertToken(bodypersonfirstName);
                    personObjectpropCount++;
                }

                if (bodypersonlastName != null)
                {
                    personObject["last-name"] = SourceExpressionConverter.ConvertToken(bodypersonlastName);
                    personObjectpropCount++;
                }

                if (bodypersoncompanyId != null)
                {
                    personObject["company-id"] = SourceExpressionConverter.ConvertToken(bodypersoncompanyId);
                    personObjectpropCount++;
                }

                if (bodypersonjobTitle != null)
                {
                    personObject["title"] = SourceExpressionConverter.ConvertToken(bodypersonjobTitle);
                    personObjectpropCount++;
                }

                if (bodypersonhome != null)
                {
                    personObject["phone-number-home"] = SourceExpressionConverter.ConvertToken(bodypersonhome);
                    personObjectpropCount++;
                }

                if (bodypersonmobile != null)
                {
                    personObject["phone-number-mobile"] = SourceExpressionConverter.ConvertToken(bodypersonmobile);
                    personObjectpropCount++;
                }

                if (bodypersonoffice != null)
                {
                    personObject["phone-number-office"] = SourceExpressionConverter.ConvertToken(bodypersonoffice);
                    personObjectpropCount++;
                }

                if (bodypersonofficeExtension != null)
                {
                    personObject["phone-number-office-ext"] = SourceExpressionConverter.ConvertToken(bodypersonofficeExtension);
                    personObjectpropCount++;
                }

                if (bodypersonfax != null)
                {
                    personObject["phone-number-fax"] = SourceExpressionConverter.ConvertToken(bodypersonfax);
                    personObjectpropCount++;
                }

                if (bodypersonusername != null)
                {
                    personObject["user-name"] = SourceExpressionConverter.ConvertToken(bodypersonusername);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<GetUserResponse> GetUser([WorkflowExpression] Func<string> personId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/people/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserResponse>(BuildSourceInput);
        }
    }

    public class TeamworkTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> WebhookCreateProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                webhookObject["url"] = "#{listCallbackUrl()}";
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
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCreateTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                webhookObject["url"] = "#{listCallbackUrl()}";
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
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCreateUser(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                webhookObject["url"] = "#{listCallbackUrl()}";
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
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
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