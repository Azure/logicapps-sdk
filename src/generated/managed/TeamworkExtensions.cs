//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamwork
{
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
        [WorkflowExpressionFactory(nameof(__BuildCreateProject))]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyprojectdescription = null, [WorkflowExpression] Func<string> bodyprojectcategoryId = null, [WorkflowExpression] Func<string> bodyprojectcompanyId = null, [WorkflowExpression] Func<string> bodyprojectnewCompany = null, [WorkflowExpression] Func<string> bodyprojectstartDate = null, [WorkflowExpression] Func<string> bodyprojectendDate = null, [WorkflowExpression] Func<string> bodyprojecttags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateProjectResponse> __BuildCreateProject(WorkflowExpression<string> bodyprojectname = null, WorkflowExpression<string> bodyprojectdescription = null, WorkflowExpression<string> bodyprojectcategoryId = null, WorkflowExpression<string> bodyprojectcompanyId = null, WorkflowExpression<string> bodyprojectnewCompany = null, WorkflowExpression<string> bodyprojectstartDate = null, WorkflowExpression<string> bodyprojectendDate = null, WorkflowExpression<string> bodyprojecttags = null)
        {
            WorkflowExpression.Validate(bodyprojectname, nameof(bodyprojectname), required: false);
            WorkflowExpression.Validate(bodyprojectdescription, nameof(bodyprojectdescription), required: false);
            WorkflowExpression.Validate(bodyprojectcategoryId, nameof(bodyprojectcategoryId), required: false);
            WorkflowExpression.Validate(bodyprojectcompanyId, nameof(bodyprojectcompanyId), required: false);
            WorkflowExpression.Validate(bodyprojectnewCompany, nameof(bodyprojectnewCompany), required: false);
            WorkflowExpression.Validate(bodyprojectstartDate, nameof(bodyprojectstartDate), required: false);
            WorkflowExpression.Validate(bodyprojectendDate, nameof(bodyprojectendDate), required: false);
            WorkflowExpression.Validate(bodyprojecttags, nameof(bodyprojecttags), required: false);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildGetProject))]
        public IBodyWorkflowAction<GetProjectResponse> GetProject([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectResponse> __BuildGetProject(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildListTasks))]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> taskListId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTasksResponse> __BuildListTasks(WorkflowExpression<string> projectId, WorkflowExpression<string> taskListId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyAction<ListTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasklists/{0}/tasks.json", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                return new ApiConnectionAction<ListTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<UpsertTaskResponse> CreateTask([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> taskListId, [WorkflowExpression] Func<string> bodytodoItemname = null, [WorkflowExpression] Func<string> bodytodoItemdescription = null, [WorkflowExpression] Func<string> bodytodoItemprogress = null, [WorkflowExpression] Func<string> bodytodoItemassignTo = null, [WorkflowExpression] Func<string> bodytodoItemstartDate = null, [WorkflowExpression] Func<string> bodytodoItemdueDate = null, [WorkflowExpression] Func<string> bodytodoItemestimatedMinutes = null, [WorkflowExpression] Func<bodytodoItempriorityInput> bodytodoItempriority = null, [WorkflowExpression] Func<bool> bodytodoItemnotifyPeople = null, [WorkflowExpression] Func<bool> bodytodoItemisPrivate = null, [WorkflowExpression] Func<string> bodytodoItemtags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpsertTaskResponse> __BuildCreateTask(WorkflowExpression<string> projectId, WorkflowExpression<string> taskListId, WorkflowExpression<string> bodytodoItemname = null, WorkflowExpression<string> bodytodoItemdescription = null, WorkflowExpression<string> bodytodoItemprogress = null, WorkflowExpression<string> bodytodoItemassignTo = null, WorkflowExpression<string> bodytodoItemstartDate = null, WorkflowExpression<string> bodytodoItemdueDate = null, WorkflowExpression<string> bodytodoItemestimatedMinutes = null, WorkflowExpression<bodytodoItempriorityInput> bodytodoItempriority = null, WorkflowExpression<bool> bodytodoItemnotifyPeople = null, WorkflowExpression<bool> bodytodoItemisPrivate = null, WorkflowExpression<string> bodytodoItemtags = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            WorkflowExpression.Validate(bodytodoItemname, nameof(bodytodoItemname), required: false);
            WorkflowExpression.Validate(bodytodoItemdescription, nameof(bodytodoItemdescription), required: false);
            WorkflowExpression.Validate(bodytodoItemprogress, nameof(bodytodoItemprogress), required: false);
            WorkflowExpression.Validate(bodytodoItemassignTo, nameof(bodytodoItemassignTo), required: false);
            WorkflowExpression.Validate(bodytodoItemstartDate, nameof(bodytodoItemstartDate), required: false);
            WorkflowExpression.Validate(bodytodoItemdueDate, nameof(bodytodoItemdueDate), required: false);
            WorkflowExpression.Validate(bodytodoItemestimatedMinutes, nameof(bodytodoItemestimatedMinutes), required: false);
            WorkflowExpression.Validate(bodytodoItempriority, nameof(bodytodoItempriority), required: false);
            WorkflowExpression.Validate(bodytodoItemnotifyPeople, nameof(bodytodoItemnotifyPeople), required: false);
            WorkflowExpression.Validate(bodytodoItemisPrivate, nameof(bodytodoItemisPrivate), required: false);
            WorkflowExpression.Validate(bodytodoItemtags, nameof(bodytodoItemtags), required: false);
            return new DeferredBodyAction<UpsertTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasklists/{0}/tasks.json", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildGetTask))]
        public IBodyWorkflowAction<GetTaskResponse> GetTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponse> __BuildGetTask(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTask))]
        public IBodyWorkflowAction<UpsertTaskResponse> UpdateTask([WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<string> bodytodoItemname = null, [WorkflowExpression] Func<string> bodytodoItemdescription = null, [WorkflowExpression] Func<string> bodytodoItemprogress = null, [WorkflowExpression] Func<string> bodytodoItemassignTo = null, [WorkflowExpression] Func<string> bodytodoItemstartDate = null, [WorkflowExpression] Func<string> bodytodoItemdueDate = null, [WorkflowExpression] Func<string> bodytodoItemestimatedTime = null, [WorkflowExpression] Func<bodytodoItempriorityInput> bodytodoItempriority = null, [WorkflowExpression] Func<bool> bodytodoItemnotifyPeople = null, [WorkflowExpression] Func<bool> bodytodoItemisPrivate = null, [WorkflowExpression] Func<string> bodytodoItemtags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpsertTaskResponse> __BuildUpdateTask(WorkflowExpression<string> taskId, WorkflowExpression<string> bodytodoItemname = null, WorkflowExpression<string> bodytodoItemdescription = null, WorkflowExpression<string> bodytodoItemprogress = null, WorkflowExpression<string> bodytodoItemassignTo = null, WorkflowExpression<string> bodytodoItemstartDate = null, WorkflowExpression<string> bodytodoItemdueDate = null, WorkflowExpression<string> bodytodoItemestimatedTime = null, WorkflowExpression<bodytodoItempriorityInput> bodytodoItempriority = null, WorkflowExpression<bool> bodytodoItemnotifyPeople = null, WorkflowExpression<bool> bodytodoItemisPrivate = null, WorkflowExpression<string> bodytodoItemtags = null)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            WorkflowExpression.Validate(bodytodoItemname, nameof(bodytodoItemname), required: false);
            WorkflowExpression.Validate(bodytodoItemdescription, nameof(bodytodoItemdescription), required: false);
            WorkflowExpression.Validate(bodytodoItemprogress, nameof(bodytodoItemprogress), required: false);
            WorkflowExpression.Validate(bodytodoItemassignTo, nameof(bodytodoItemassignTo), required: false);
            WorkflowExpression.Validate(bodytodoItemstartDate, nameof(bodytodoItemstartDate), required: false);
            WorkflowExpression.Validate(bodytodoItemdueDate, nameof(bodytodoItemdueDate), required: false);
            WorkflowExpression.Validate(bodytodoItemestimatedTime, nameof(bodytodoItemestimatedTime), required: false);
            WorkflowExpression.Validate(bodytodoItempriority, nameof(bodytodoItempriority), required: false);
            WorkflowExpression.Validate(bodytodoItemnotifyPeople, nameof(bodytodoItemnotifyPeople), required: false);
            WorkflowExpression.Validate(bodytodoItemisPrivate, nameof(bodytodoItemisPrivate), required: false);
            WorkflowExpression.Validate(bodytodoItemtags, nameof(bodytodoItemtags), required: false);
            return new DeferredBodyAction<UpsertTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTask))]
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteTaskResponse> __BuildDeleteTask(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<DeleteTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildListUsers))]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListUsersResponse> __BuildListUsers(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListUsersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/people.json", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodypersonemailAddress = null, [WorkflowExpression] Func<string> bodypersonfirstName = null, [WorkflowExpression] Func<string> bodypersonlastName = null, [WorkflowExpression] Func<string> bodypersoncompanyId = null, [WorkflowExpression] Func<string> bodypersonjobTitle = null, [WorkflowExpression] Func<string> bodypersonhome = null, [WorkflowExpression] Func<string> bodypersonmobile = null, [WorkflowExpression] Func<string> bodypersonoffice = null, [WorkflowExpression] Func<string> bodypersonofficeExtension = null, [WorkflowExpression] Func<string> bodypersonfax = null, [WorkflowExpression] Func<string> bodypersonusername = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUserResponse> __BuildCreateUser(WorkflowExpression<string> bodypersonemailAddress = null, WorkflowExpression<string> bodypersonfirstName = null, WorkflowExpression<string> bodypersonlastName = null, WorkflowExpression<string> bodypersoncompanyId = null, WorkflowExpression<string> bodypersonjobTitle = null, WorkflowExpression<string> bodypersonhome = null, WorkflowExpression<string> bodypersonmobile = null, WorkflowExpression<string> bodypersonoffice = null, WorkflowExpression<string> bodypersonofficeExtension = null, WorkflowExpression<string> bodypersonfax = null, WorkflowExpression<string> bodypersonusername = null)
        {
            WorkflowExpression.Validate(bodypersonemailAddress, nameof(bodypersonemailAddress), required: false);
            WorkflowExpression.Validate(bodypersonfirstName, nameof(bodypersonfirstName), required: false);
            WorkflowExpression.Validate(bodypersonlastName, nameof(bodypersonlastName), required: false);
            WorkflowExpression.Validate(bodypersoncompanyId, nameof(bodypersoncompanyId), required: false);
            WorkflowExpression.Validate(bodypersonjobTitle, nameof(bodypersonjobTitle), required: false);
            WorkflowExpression.Validate(bodypersonhome, nameof(bodypersonhome), required: false);
            WorkflowExpression.Validate(bodypersonmobile, nameof(bodypersonmobile), required: false);
            WorkflowExpression.Validate(bodypersonoffice, nameof(bodypersonoffice), required: false);
            WorkflowExpression.Validate(bodypersonofficeExtension, nameof(bodypersonofficeExtension), required: false);
            WorkflowExpression.Validate(bodypersonfax, nameof(bodypersonfax), required: false);
            WorkflowExpression.Validate(bodypersonusername, nameof(bodypersonusername), required: false);
            return new DeferredBodyAction<CreateUserResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<GetUserResponse> GetUser([WorkflowExpression] Func<string> personId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserResponse> __BuildGetUser(WorkflowExpression<string> personId)
        {
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/people/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }
    }

    public class TeamworkTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> WebhookCreateProject(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCreateTask(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookCreateUser(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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