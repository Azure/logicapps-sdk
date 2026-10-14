//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamwork
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_bodyprojectname = bodyprojectname == null ? null : WorkflowExpression.Compile(bodyprojectname);
            WorkflowExpression.Validate(__workflow_bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyprojectdescription = bodyprojectdescription == null ? null : WorkflowExpression.Compile(bodyprojectdescription);
            WorkflowExpression.Validate(__workflow_bodyprojectdescription, nameof(bodyprojectdescription), required: false);
            var __workflow_bodyprojectcategoryId = bodyprojectcategoryId == null ? null : WorkflowExpression.Compile(bodyprojectcategoryId);
            WorkflowExpression.Validate(__workflow_bodyprojectcategoryId, nameof(bodyprojectcategoryId), required: false);
            var __workflow_bodyprojectcompanyId = bodyprojectcompanyId == null ? null : WorkflowExpression.Compile(bodyprojectcompanyId);
            WorkflowExpression.Validate(__workflow_bodyprojectcompanyId, nameof(bodyprojectcompanyId), required: false);
            var __workflow_bodyprojectnewCompany = bodyprojectnewCompany == null ? null : WorkflowExpression.Compile(bodyprojectnewCompany);
            WorkflowExpression.Validate(__workflow_bodyprojectnewCompany, nameof(bodyprojectnewCompany), required: false);
            var __workflow_bodyprojectstartDate = bodyprojectstartDate == null ? null : WorkflowExpression.Compile(bodyprojectstartDate);
            WorkflowExpression.Validate(__workflow_bodyprojectstartDate, nameof(bodyprojectstartDate), required: false);
            var __workflow_bodyprojectendDate = bodyprojectendDate == null ? null : WorkflowExpression.Compile(bodyprojectendDate);
            WorkflowExpression.Validate(__workflow_bodyprojectendDate, nameof(bodyprojectendDate), required: false);
            var __workflow_bodyprojecttags = bodyprojecttags == null ? null : WorkflowExpression.Compile(bodyprojecttags);
            WorkflowExpression.Validate(__workflow_bodyprojecttags, nameof(bodyprojecttags), required: false);
            return new DeferredBodyAction<CreateProjectResponse>(() =>
            {
                var apiCallPath = "/projects.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (__workflow_bodyprojectname != null)
                {
                    projectObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectdescription != null)
                {
                    projectObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyprojectdescription);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectcategoryId != null)
                {
                    projectObject["category-id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectcategoryId);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectcompanyId != null)
                {
                    projectObject["companyId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectcompanyId);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectnewCompany != null)
                {
                    projectObject["newCompany"] = ExpressionConverter.ConvertO(__workflow_bodyprojectnewCompany);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectstartDate != null)
                {
                    projectObject["startDate"] = ExpressionConverter.ConvertO(__workflow_bodyprojectstartDate);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectendDate != null)
                {
                    projectObject["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyprojectendDate);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojecttags != null)
                {
                    projectObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodyprojecttags);
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
        public IBodyWorkflowAction<GetProjectResponse> GetProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks(Expression<Func<string>> projectId, Expression<Func<string>> taskListId)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_taskListId = taskListId == null ? null : WorkflowExpression.Compile(taskListId);
            WorkflowExpression.Validate(__workflow_taskListId, nameof(taskListId), required: true);
            return new DeferredBodyAction<ListTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasklists/{0}/tasks.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<ListTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse> CreateTask(Expression<Func<string>> projectId, Expression<Func<string>> taskListId, Expression<Func<string>> bodytodoItemname = null, Expression<Func<string>> bodytodoItemdescription = null, Expression<Func<string>> bodytodoItemprogress = null, Expression<Func<string>> bodytodoItemassignTo = null, Expression<Func<string>> bodytodoItemstartDate = null, Expression<Func<string>> bodytodoItemdueDate = null, Expression<Func<string>> bodytodoItemestimatedMinutes = null, Expression<Func<bodytodoItempriorityInput>> bodytodoItempriority = null, Expression<Func<bool>> bodytodoItemnotifyPeople = null, Expression<Func<bool>> bodytodoItemisPrivate = null, Expression<Func<string>> bodytodoItemtags = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_taskListId = taskListId == null ? null : WorkflowExpression.Compile(taskListId);
            WorkflowExpression.Validate(__workflow_taskListId, nameof(taskListId), required: true);
            var __workflow_bodytodoItemname = bodytodoItemname == null ? null : WorkflowExpression.Compile(bodytodoItemname);
            WorkflowExpression.Validate(__workflow_bodytodoItemname, nameof(bodytodoItemname), required: false);
            var __workflow_bodytodoItemdescription = bodytodoItemdescription == null ? null : WorkflowExpression.Compile(bodytodoItemdescription);
            WorkflowExpression.Validate(__workflow_bodytodoItemdescription, nameof(bodytodoItemdescription), required: false);
            var __workflow_bodytodoItemprogress = bodytodoItemprogress == null ? null : WorkflowExpression.Compile(bodytodoItemprogress);
            WorkflowExpression.Validate(__workflow_bodytodoItemprogress, nameof(bodytodoItemprogress), required: false);
            var __workflow_bodytodoItemassignTo = bodytodoItemassignTo == null ? null : WorkflowExpression.Compile(bodytodoItemassignTo);
            WorkflowExpression.Validate(__workflow_bodytodoItemassignTo, nameof(bodytodoItemassignTo), required: false);
            var __workflow_bodytodoItemstartDate = bodytodoItemstartDate == null ? null : WorkflowExpression.Compile(bodytodoItemstartDate);
            WorkflowExpression.Validate(__workflow_bodytodoItemstartDate, nameof(bodytodoItemstartDate), required: false);
            var __workflow_bodytodoItemdueDate = bodytodoItemdueDate == null ? null : WorkflowExpression.Compile(bodytodoItemdueDate);
            WorkflowExpression.Validate(__workflow_bodytodoItemdueDate, nameof(bodytodoItemdueDate), required: false);
            var __workflow_bodytodoItemestimatedMinutes = bodytodoItemestimatedMinutes == null ? null : WorkflowExpression.Compile(bodytodoItemestimatedMinutes);
            WorkflowExpression.Validate(__workflow_bodytodoItemestimatedMinutes, nameof(bodytodoItemestimatedMinutes), required: false);
            var __workflow_bodytodoItempriority = bodytodoItempriority == null ? null : WorkflowExpression.Compile(bodytodoItempriority);
            WorkflowExpression.Validate(__workflow_bodytodoItempriority, nameof(bodytodoItempriority), required: false);
            var __workflow_bodytodoItemnotifyPeople = bodytodoItemnotifyPeople == null ? null : WorkflowExpression.Compile(bodytodoItemnotifyPeople);
            WorkflowExpression.Validate(__workflow_bodytodoItemnotifyPeople, nameof(bodytodoItemnotifyPeople), required: false);
            var __workflow_bodytodoItemisPrivate = bodytodoItemisPrivate == null ? null : WorkflowExpression.Compile(bodytodoItemisPrivate);
            WorkflowExpression.Validate(__workflow_bodytodoItemisPrivate, nameof(bodytodoItemisPrivate), required: false);
            var __workflow_bodytodoItemtags = bodytodoItemtags == null ? null : WorkflowExpression.Compile(bodytodoItemtags);
            WorkflowExpression.Validate(__workflow_bodytodoItemtags, nameof(bodytodoItemtags), required: false);
            return new DeferredBodyAction<UpsertTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasklists/{0}/tasks.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                var body = new JObject();
                var bodypropCount = 0;
                var todoItemObject = new JObject();
                var todoItemObjectpropCount = 0;
                if (__workflow_bodytodoItemname != null)
                {
                    todoItemObject["content"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemname);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemdescription != null)
                {
                    todoItemObject["description"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemdescription);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemprogress != null)
                {
                    todoItemObject["progress"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemprogress);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemassignTo != null)
                {
                    todoItemObject["responsible-party-id"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemassignTo);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemstartDate != null)
                {
                    todoItemObject["start-date"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemstartDate);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemdueDate != null)
                {
                    todoItemObject["due-date"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemdueDate);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemestimatedMinutes != null)
                {
                    todoItemObject["estimated-minutes"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemestimatedMinutes);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItempriority != null)
                {
                    todoItemObject["priority"] = ExpressionConverter.ConvertO(__workflow_bodytodoItempriority);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemnotifyPeople != null)
                {
                    todoItemObject["notify"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemnotifyPeople);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemisPrivate != null)
                {
                    todoItemObject["private"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemisPrivate);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemtags != null)
                {
                    todoItemObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemtags);
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
        public IBodyWorkflowAction<GetTaskResponse> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<UpsertTaskResponse> UpdateTask(Expression<Func<string>> taskId, Expression<Func<string>> bodytodoItemname = null, Expression<Func<string>> bodytodoItemdescription = null, Expression<Func<string>> bodytodoItemprogress = null, Expression<Func<string>> bodytodoItemassignTo = null, Expression<Func<string>> bodytodoItemstartDate = null, Expression<Func<string>> bodytodoItemdueDate = null, Expression<Func<string>> bodytodoItemestimatedTime = null, Expression<Func<bodytodoItempriorityInput>> bodytodoItempriority = null, Expression<Func<bool>> bodytodoItemnotifyPeople = null, Expression<Func<bool>> bodytodoItemisPrivate = null, Expression<Func<string>> bodytodoItemtags = null)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            var __workflow_bodytodoItemname = bodytodoItemname == null ? null : WorkflowExpression.Compile(bodytodoItemname);
            WorkflowExpression.Validate(__workflow_bodytodoItemname, nameof(bodytodoItemname), required: false);
            var __workflow_bodytodoItemdescription = bodytodoItemdescription == null ? null : WorkflowExpression.Compile(bodytodoItemdescription);
            WorkflowExpression.Validate(__workflow_bodytodoItemdescription, nameof(bodytodoItemdescription), required: false);
            var __workflow_bodytodoItemprogress = bodytodoItemprogress == null ? null : WorkflowExpression.Compile(bodytodoItemprogress);
            WorkflowExpression.Validate(__workflow_bodytodoItemprogress, nameof(bodytodoItemprogress), required: false);
            var __workflow_bodytodoItemassignTo = bodytodoItemassignTo == null ? null : WorkflowExpression.Compile(bodytodoItemassignTo);
            WorkflowExpression.Validate(__workflow_bodytodoItemassignTo, nameof(bodytodoItemassignTo), required: false);
            var __workflow_bodytodoItemstartDate = bodytodoItemstartDate == null ? null : WorkflowExpression.Compile(bodytodoItemstartDate);
            WorkflowExpression.Validate(__workflow_bodytodoItemstartDate, nameof(bodytodoItemstartDate), required: false);
            var __workflow_bodytodoItemdueDate = bodytodoItemdueDate == null ? null : WorkflowExpression.Compile(bodytodoItemdueDate);
            WorkflowExpression.Validate(__workflow_bodytodoItemdueDate, nameof(bodytodoItemdueDate), required: false);
            var __workflow_bodytodoItemestimatedTime = bodytodoItemestimatedTime == null ? null : WorkflowExpression.Compile(bodytodoItemestimatedTime);
            WorkflowExpression.Validate(__workflow_bodytodoItemestimatedTime, nameof(bodytodoItemestimatedTime), required: false);
            var __workflow_bodytodoItempriority = bodytodoItempriority == null ? null : WorkflowExpression.Compile(bodytodoItempriority);
            WorkflowExpression.Validate(__workflow_bodytodoItempriority, nameof(bodytodoItempriority), required: false);
            var __workflow_bodytodoItemnotifyPeople = bodytodoItemnotifyPeople == null ? null : WorkflowExpression.Compile(bodytodoItemnotifyPeople);
            WorkflowExpression.Validate(__workflow_bodytodoItemnotifyPeople, nameof(bodytodoItemnotifyPeople), required: false);
            var __workflow_bodytodoItemisPrivate = bodytodoItemisPrivate == null ? null : WorkflowExpression.Compile(bodytodoItemisPrivate);
            WorkflowExpression.Validate(__workflow_bodytodoItemisPrivate, nameof(bodytodoItemisPrivate), required: false);
            var __workflow_bodytodoItemtags = bodytodoItemtags == null ? null : WorkflowExpression.Compile(bodytodoItemtags);
            WorkflowExpression.Validate(__workflow_bodytodoItemtags, nameof(bodytodoItemtags), required: false);
            return new DeferredBodyAction<UpsertTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var todoItemObject = new JObject();
                var todoItemObjectpropCount = 0;
                if (__workflow_bodytodoItemname != null)
                {
                    todoItemObject["content"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemname);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemdescription != null)
                {
                    todoItemObject["description"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemdescription);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemprogress != null)
                {
                    todoItemObject["progress"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemprogress);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemassignTo != null)
                {
                    todoItemObject["responsible-party-id"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemassignTo);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemstartDate != null)
                {
                    todoItemObject["start-date"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemstartDate);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemdueDate != null)
                {
                    todoItemObject["due-date"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemdueDate);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemestimatedTime != null)
                {
                    todoItemObject["estimated-minutes"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemestimatedTime);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItempriority != null)
                {
                    todoItemObject["priority"] = ExpressionConverter.ConvertO(__workflow_bodytodoItempriority);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemnotifyPeople != null)
                {
                    todoItemObject["notify"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemnotifyPeople);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemisPrivate != null)
                {
                    todoItemObject["private"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemisPrivate);
                    todoItemObjectpropCount++;
                }

                if (__workflow_bodytodoItemtags != null)
                {
                    todoItemObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodytodoItemtags);
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
        public IBodyWorkflowAction<DeleteTaskResponse> DeleteTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<DeleteTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ListUsersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/people.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamwork")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser(Expression<Func<string>> bodypersonemailAddress = null, Expression<Func<string>> bodypersonfirstName = null, Expression<Func<string>> bodypersonlastName = null, Expression<Func<string>> bodypersoncompanyId = null, Expression<Func<string>> bodypersonjobTitle = null, Expression<Func<string>> bodypersonhome = null, Expression<Func<string>> bodypersonmobile = null, Expression<Func<string>> bodypersonoffice = null, Expression<Func<string>> bodypersonofficeExtension = null, Expression<Func<string>> bodypersonfax = null, Expression<Func<string>> bodypersonusername = null)
        {
            var __workflow_bodypersonemailAddress = bodypersonemailAddress == null ? null : WorkflowExpression.Compile(bodypersonemailAddress);
            WorkflowExpression.Validate(__workflow_bodypersonemailAddress, nameof(bodypersonemailAddress), required: false);
            var __workflow_bodypersonfirstName = bodypersonfirstName == null ? null : WorkflowExpression.Compile(bodypersonfirstName);
            WorkflowExpression.Validate(__workflow_bodypersonfirstName, nameof(bodypersonfirstName), required: false);
            var __workflow_bodypersonlastName = bodypersonlastName == null ? null : WorkflowExpression.Compile(bodypersonlastName);
            WorkflowExpression.Validate(__workflow_bodypersonlastName, nameof(bodypersonlastName), required: false);
            var __workflow_bodypersoncompanyId = bodypersoncompanyId == null ? null : WorkflowExpression.Compile(bodypersoncompanyId);
            WorkflowExpression.Validate(__workflow_bodypersoncompanyId, nameof(bodypersoncompanyId), required: false);
            var __workflow_bodypersonjobTitle = bodypersonjobTitle == null ? null : WorkflowExpression.Compile(bodypersonjobTitle);
            WorkflowExpression.Validate(__workflow_bodypersonjobTitle, nameof(bodypersonjobTitle), required: false);
            var __workflow_bodypersonhome = bodypersonhome == null ? null : WorkflowExpression.Compile(bodypersonhome);
            WorkflowExpression.Validate(__workflow_bodypersonhome, nameof(bodypersonhome), required: false);
            var __workflow_bodypersonmobile = bodypersonmobile == null ? null : WorkflowExpression.Compile(bodypersonmobile);
            WorkflowExpression.Validate(__workflow_bodypersonmobile, nameof(bodypersonmobile), required: false);
            var __workflow_bodypersonoffice = bodypersonoffice == null ? null : WorkflowExpression.Compile(bodypersonoffice);
            WorkflowExpression.Validate(__workflow_bodypersonoffice, nameof(bodypersonoffice), required: false);
            var __workflow_bodypersonofficeExtension = bodypersonofficeExtension == null ? null : WorkflowExpression.Compile(bodypersonofficeExtension);
            WorkflowExpression.Validate(__workflow_bodypersonofficeExtension, nameof(bodypersonofficeExtension), required: false);
            var __workflow_bodypersonfax = bodypersonfax == null ? null : WorkflowExpression.Compile(bodypersonfax);
            WorkflowExpression.Validate(__workflow_bodypersonfax, nameof(bodypersonfax), required: false);
            var __workflow_bodypersonusername = bodypersonusername == null ? null : WorkflowExpression.Compile(bodypersonusername);
            WorkflowExpression.Validate(__workflow_bodypersonusername, nameof(bodypersonusername), required: false);
            return new DeferredBodyAction<CreateUserResponse>(() =>
            {
                var apiCallPath = "/people.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var personObject = new JObject();
                var personObjectpropCount = 0;
                if (__workflow_bodypersonemailAddress != null)
                {
                    personObject["email-address"] = ExpressionConverter.ConvertO(__workflow_bodypersonemailAddress);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonfirstName != null)
                {
                    personObject["first-name"] = ExpressionConverter.ConvertO(__workflow_bodypersonfirstName);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonlastName != null)
                {
                    personObject["last-name"] = ExpressionConverter.ConvertO(__workflow_bodypersonlastName);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersoncompanyId != null)
                {
                    personObject["company-id"] = ExpressionConverter.ConvertO(__workflow_bodypersoncompanyId);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonjobTitle != null)
                {
                    personObject["title"] = ExpressionConverter.ConvertO(__workflow_bodypersonjobTitle);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonhome != null)
                {
                    personObject["phone-number-home"] = ExpressionConverter.ConvertO(__workflow_bodypersonhome);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonmobile != null)
                {
                    personObject["phone-number-mobile"] = ExpressionConverter.ConvertO(__workflow_bodypersonmobile);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonoffice != null)
                {
                    personObject["phone-number-office"] = ExpressionConverter.ConvertO(__workflow_bodypersonoffice);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonofficeExtension != null)
                {
                    personObject["phone-number-office-ext"] = ExpressionConverter.ConvertO(__workflow_bodypersonofficeExtension);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonfax != null)
                {
                    personObject["phone-number-fax"] = ExpressionConverter.ConvertO(__workflow_bodypersonfax);
                    personObjectpropCount++;
                }

                if (__workflow_bodypersonusername != null)
                {
                    personObject["user-name"] = ExpressionConverter.ConvertO(__workflow_bodypersonusername);
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
        public IBodyWorkflowAction<GetUserResponse> GetUser(Expression<Func<string>> personId)
        {
            var __workflow_personId = personId == null ? null : WorkflowExpression.Compile(personId);
            WorkflowExpression.Validate(__workflow_personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/people/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_personId, 1));
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
