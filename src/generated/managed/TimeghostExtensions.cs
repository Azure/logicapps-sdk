//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TimeghostActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetCurrentuser()
        {
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/currentuser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<WorkspaceResponse, ApiConnectionActionConfiguration> GetWorkspaceById(Expression<Func<string>> workspaceId2, Expression<Func<string>> workspaceId = null)
        {
            var __workflow_workspaceId2 = WorkflowExpression.Compile(workspaceId2, nameof(workspaceId2), required: true);
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: false);
            return new DeferredBodyAction<WorkspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/get/workspaces/{0}", __workflow_workspaceId2.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspaceId != null)
                    callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<WorkspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse[], ApiConnectionActionConfiguration> GetClientProjects(Expression<Func<string>> workspaceId, Expression<Func<string>> clientid, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_clientid = WorkflowExpression.Compile(clientid, nameof(clientid), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ProjectsResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/get/clients/{0}/projects", __workflow_clientid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<ProjectsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TasksUpdateResponse[], ApiConnectionActionConfiguration> GetProjectTasks(Expression<Func<string>> workspaceId, Expression<Func<string>> projectid, Expression<Func<string>> clientid = null, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectid = WorkflowExpression.Compile(projectid, nameof(projectid), required: true);
            var __workflow_clientid = WorkflowExpression.Compile(clientid, nameof(clientid), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TasksUpdateResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/get/projects/{0}/tasks", __workflow_projectid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                if (__workflow_clientid != null)
                    callPayload.Headers["clientid"] = ExpressionConverter.Convert(__workflow_clientid);
                return new ApiConnectionAction<TasksUpdateResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse[], ApiConnectionActionConfiguration> GetProjects(Expression<Func<string>> workspaceId, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ProjectsResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<ProjectsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse, ApiConnectionActionConfiguration> AddProject(Expression<Func<string>> workspaceId, Expression<Func<AddProjectBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId, Expression<Func<UpdateProjectBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse, ApiConnectionActionConfiguration> UpdateProjectTags(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId, Expression<Func<UpdateProjectTagsBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/projects/{0}/tags", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse, ApiConnectionActionConfiguration> UpdateProjectUsers(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId, Expression<Func<UpdateProjectUsersBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/projects/{0}/users", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ProjectsResponse, ApiConnectionActionConfiguration> UpdateProjectGroups(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId, Expression<Func<UpdateProjectGroupsBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/projects/{0}/groups", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TimesResponse[], ApiConnectionActionConfiguration> GetTimes(Expression<Func<string>> workspaceId, Expression<Func<FilterDateRangeInput>> filterDateRange, Expression<Func<string>> filterUser = null, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_filterDateRange = WorkflowExpression.Compile(filterDateRange, nameof(filterDateRange), required: true);
            var __workflow_filterUser = WorkflowExpression.Compile(filterUser, nameof(filterUser), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TimesResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/times";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter-date-range"] = ExpressionConverter.Convert(__workflow_filterDateRange);
                if (__workflow_filterUser != null)
                    callPayload.Queries["$filter-user"] = ExpressionConverter.Convert(__workflow_filterUser);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<TimesResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TimesResponse[], ApiConnectionActionConfiguration> GetProjectTimes(Expression<Func<string>> workspaceId, Expression<Func<string>> projectid, Expression<Func<FilterDateRangeInput>> filterDateRange, Expression<Func<string>> clientid = null, Expression<Func<string>> filterUser = null, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectid = WorkflowExpression.Compile(projectid, nameof(projectid), required: true);
            var __workflow_filterDateRange = WorkflowExpression.Compile(filterDateRange, nameof(filterDateRange), required: true);
            var __workflow_clientid = WorkflowExpression.Compile(clientid, nameof(clientid), required: false);
            var __workflow_filterUser = WorkflowExpression.Compile(filterUser, nameof(filterUser), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TimesResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/get/projects/{0}/times", __workflow_projectid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter-date-range"] = ExpressionConverter.Convert(__workflow_filterDateRange);
                if (__workflow_filterUser != null)
                    callPayload.Queries["$filter-user"] = ExpressionConverter.Convert(__workflow_filterUser);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                if (__workflow_clientid != null)
                    callPayload.Headers["clientid"] = ExpressionConverter.Convert(__workflow_clientid);
                return new ApiConnectionAction<TimesResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TimesResponse[], ApiConnectionActionConfiguration> GetClientTimes(Expression<Func<string>> workspaceId, Expression<Func<string>> clientid, Expression<Func<FilterDateRangeInput>> filterDateRange, Expression<Func<string>> filterUser = null, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_clientid = WorkflowExpression.Compile(clientid, nameof(clientid), required: true);
            var __workflow_filterDateRange = WorkflowExpression.Compile(filterDateRange, nameof(filterDateRange), required: true);
            var __workflow_filterUser = WorkflowExpression.Compile(filterUser, nameof(filterUser), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TimesResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/get/clients/{0}/times", __workflow_clientid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter-date-range"] = ExpressionConverter.Convert(__workflow_filterDateRange);
                if (__workflow_filterUser != null)
                    callPayload.Queries["$filter-user"] = ExpressionConverter.Convert(__workflow_filterUser);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<TimesResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TimesResponse, ApiConnectionActionConfiguration> AddTime(Expression<Func<string>> workspaceId, Expression<Func<AddTimeBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TimesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/times";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TimesResponse, ApiConnectionActionConfiguration> UpdateTime(Expression<Func<string>> timeId, Expression<Func<string>> workspaceId, Expression<Func<UpdateTimeBodyInput>> body)
        {
            var __workflow_timeId = WorkflowExpression.Compile(timeId, nameof(timeId), required: true);
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TimesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/times/{0}", __workflow_timeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TimesResponse, ApiConnectionActionConfiguration> UpdateTimeTags(Expression<Func<string>> workspaceId, Expression<Func<string>> timeId, Expression<Func<UpdateProjectTagsBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_timeId = WorkflowExpression.Compile(timeId, nameof(timeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TimesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/times/{0}/tags", __workflow_timeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TasksUpdateResponse, ApiConnectionActionConfiguration> AddTask(Expression<Func<string>> workspaceId, Expression<Func<AddTaskBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TasksUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TasksUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TasksUpdateResponse, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> workspaceId, Expression<Func<string>> taskId, Expression<Func<UpdateTaskBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TasksUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TasksUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ClientsResponse[], ApiConnectionActionConfiguration> GetClients(Expression<Func<string>> workspaceId, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ClientsResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<ClientsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ClientsResponse, ApiConnectionActionConfiguration> AddClient(Expression<Func<string>> workspaceId, Expression<Func<AddClientBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ClientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ClientsResponse, ApiConnectionActionConfiguration> UpdateClient(Expression<Func<string>> workspaceId, Expression<Func<string>> clientId, Expression<Func<UpdateClientBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ClientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/clients/{0}", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<GroupsResponse[], ApiConnectionActionConfiguration> GetGroups(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<GroupsResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<GroupsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<GroupsResponse, ApiConnectionActionConfiguration> AddGroup(Expression<Func<string>> workspaceId, Expression<Func<AddGroupBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<GroupsResponse, ApiConnectionActionConfiguration> UpdateGroup(Expression<Func<string>> workspaceId, Expression<Func<string>> groupId, Expression<Func<UpdateGroupBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TagsResponse[], ApiConnectionActionConfiguration> GetTags(Expression<Func<string>> workspaceId, Expression<Func<FilterInput>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TagsResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = Convert.ToString("tagType eq 1");
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<TagsResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TagsResponse, ApiConnectionActionConfiguration> AddTag(Expression<Func<string>> workspaceId, Expression<Func<AddTagBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<TagsResponse, ApiConnectionActionConfiguration> UpdateTag(Expression<Func<string>> workspaceId, Expression<Func<string>> tagId, Expression<Func<UpdateTagBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/tags/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ComeGoResponse, ApiConnectionActionConfiguration> AddComeGo(Expression<Func<string>> workspaceId, Expression<Func<AddComeGoBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ComeGoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/comego";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComeGoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ComeGoResponse[], ApiConnectionActionConfiguration> GetComeGo(Expression<Func<string>> workspaceId, Expression<Func<string>> filterUser = null, Expression<Func<string>> filter = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_filterUser = WorkflowExpression.Compile(filterUser, nameof(filterUser), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ComeGoResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get/comego";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filterUser != null)
                    callPayload.Queries["$filter-user"] = ExpressionConverter.Convert(__workflow_filterUser);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<ComeGoResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<ComeGoResponse, ApiConnectionActionConfiguration> UpdateComeGo(Expression<Func<string>> workspaceId, Expression<Func<BodyInputItem[]>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ComeGoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/update/comego";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComeGoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<CustomFeedEventResponse, ApiConnectionActionConfiguration> AddCustomFeedEvent(Expression<Func<string>> workspaceId, Expression<Func<AddCustomFeedEventBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CustomFeedEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/add/customfeedevent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomFeedEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<CustomFeedEventResponse, ApiConnectionActionConfiguration> UpdateCustomFeedEvent(Expression<Func<string>> workspaceId, Expression<Func<string>> eventId, Expression<Func<UpdateCustomFeedEventBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CustomFeedEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/customfeedevent/{0}", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomFeedEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteItem(Expression<Func<ItemTypeInput>> itemType, Expression<Func<string>> itemId, Expression<Func<string>> workspaceId)
        {
            var __workflow_itemType = WorkflowExpression.Compile(itemType, nameof(itemType), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/delete/{0}/{1}", __workflow_itemType.WithUrlEncoding(1), __workflow_itemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "timeghost")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateExcelReport(Expression<Func<string>> workspaceId, Expression<Func<CreateExcelReportBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Create_Excel_Report";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class TimeghostTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ClientChanges(Expression<Func<string>> workspaceId, Expression<Func<ClientChangesBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register_webhook/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TagChanges(Expression<Func<string>> workspaceId, Expression<Func<TagChangesBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register_webhook/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ProjectChanges(Expression<Func<string>> workspaceId, Expression<Func<ProjectChangesBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register_webhook/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TaskChanges(Expression<Func<string>> workspaceId, Expression<Func<TaskChangesBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register_webhook/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TimeChanges(Expression<Func<string>> workspaceId, Expression<Func<TimeChangesBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register_webhook/times";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["workspace-id"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class UserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("defaultWorkspace")]
        public string DefaultWorkspaceId { get; set; }

        [JsonProperty("workspaces")]
        public UserResponseWorkspacesTypeItem[] Workspaces { get; set; }

        [JsonProperty("settings")]
        public UserResponseSettingsType Settings { get; set; }

        [JsonProperty("organization")]
        public UserResponseOrganizationType Organization { get; set; }

        [JsonProperty("enabledGraphScopes")]
        public string[] EnabledGraphScopes { get; set; }

        [JsonProperty("apiTokens")]
        public UserResponseApiTokensTypeItem[] ApiTokens { get; set; }

        [JsonProperty("pinnedProjects")]
        public string[] PinnedProjects { get; set; }

        [JsonProperty("officeProfile")]
        public UserResponseOfficeProfileType OfficeProfile { get; set; }
    }

    public class UserResponseWorkspacesTypeItem
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string WorkspaceName { get; set; }
    }

    public class UserResponseSettingsType
    {
        [JsonProperty("captureManualMode")]
        public bool CaptureManualMode { get; set; }

        [JsonProperty("feedShowBooked")]
        public bool FeedShowBooked { get; set; }

        [JsonProperty("languageSetting")]
        public string LanguageSetting { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("timeFormat24h")]
        public bool _24hTimeFormat { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("rounding")]
        public UserResponseSettingsTypeRoundingType Rounding { get; set; }
    }

    public class UserResponseSettingsTypeRoundingType
    {
        [JsonProperty("enabled")]
        public bool RoundingEnabled { get; set; }

        [JsonProperty("minutes")]
        public int RoundingMinutes { get; set; }

        [JsonProperty("type")]
        public int RoundingType { get; set; }
    }

    public class UserResponseOrganizationType
    {
        [JsonProperty("displayName")]
        public string OrganizationName { get; set; }
    }

    public class UserResponseApiTokensTypeItem
    {
        [JsonProperty("name")]
        public string TokenName { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class UserResponseOfficeProfileType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class WorkspaceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("settings")]
        public WorkspaceResponseSettingsType Settings { get; set; }

        [JsonProperty("subscription")]
        public WorkspaceResponseSubscriptionType Subscription { get; set; }

        [JsonProperty("users")]
        public WorkspaceResponseUsersTypeItem[] Users { get; set; }

        [JsonProperty("groups")]
        public WorkspaceResponseGroupsTypeItem[] Groups { get; set; }

        [JsonProperty("permissionSettings")]
        public WorkspaceResponsePermissionSettingsType PermissionSettings { get; set; }

        [JsonProperty("projectPermissions")]
        public WorkspaceResponseProjectPermissionsTypeItem[] ProjectPermissions { get; set; }

        [JsonProperty("webhooks")]
        public WorkspaceResponseWebhooksTypeItem[] Webhooks { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class WorkspaceResponseSettingsType
    {
        [JsonProperty("isNewProjectBillable")]
        public bool NewProjectsAreBillableAsDefault { get; set; }

        [JsonProperty("hourly_rate")]
        public double HourlyRate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("allowFutureTimeTracking")]
        public bool FutureTimeTrackingAllowed { get; set; }

        [JsonProperty("allowTimeOverlap")]
        public bool AllowTimeOverlap { get; set; }

        [JsonProperty("comego")]
        public bool ComegoEnabled { get; set; }

        [JsonProperty("comegoOnly")]
        public bool ComegoOnly { get; set; }

        [JsonProperty("timesMode")]
        public string TimesMode { get; set; }
    }

    public class WorkspaceResponseSubscriptionType
    {
        [JsonProperty("status")]
        public string SubscriptionStatus { get; set; }

        [JsonProperty("end")]
        public string SubscriptionEnd { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("recurringInterval")]
        public string RecurringInterval { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class WorkspaceResponseUsersTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("billable_rate")]
        public double BillableRate { get; set; }

        [JsonProperty("labor_cost")]
        public double LaborCost { get; set; }

        [JsonProperty("has_license")]
        public bool HasLicense { get; set; }

        [JsonProperty("removed")]
        public bool Removed { get; set; }
    }

    public class WorkspaceResponseGroupsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("name")]
        public string GroupName { get; set; }

        [JsonProperty("synchronizedGroup")]
        public bool SynchronizedGroup { get; set; }

        [JsonProperty("synchronizedGroupType")]
        public string SynchronizedGroupType { get; set; }

        [JsonProperty("users")]
        public WorkspaceResponseGroupsTypeItemUsersTypeItem[] Users { get; set; }
    }

    public class WorkspaceResponseGroupsTypeItemUsersTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }
    }

    public class WorkspaceResponsePermissionSettingsType
    {
        [JsonProperty("groupsCanManageProjects")]
        public WorkspaceResponsePermissionSettingsTypeGroupsCanManageProjectsTypeItem[] GroupsCanManageProjects { get; set; }

        [JsonProperty("groupsCanSeeTeamActivity")]
        public WorkspaceResponsePermissionSettingsTypeGroupsCanSeeTeamActivityTypeItem[] GroupsCanSeeTeamActivity { get; set; }
    }

    public class WorkspaceResponsePermissionSettingsTypeGroupsCanManageProjectsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }
    }

    public class WorkspaceResponsePermissionSettingsTypeGroupsCanSeeTeamActivityTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }
    }

    public class WorkspaceResponseProjectPermissionsTypeItem
    {
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("users")]
        public WorkspaceResponseProjectPermissionsTypeItemUsersTypeItem[] Users { get; set; }

        [JsonProperty("groups")]
        public WorkspaceResponseProjectPermissionsTypeItemGroupsTypeItem[] Groups { get; set; }
    }

    public class WorkspaceResponseProjectPermissionsTypeItemUsersTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class WorkspaceResponseProjectPermissionsTypeItemGroupsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class WorkspaceResponseWebhooksTypeItem
    {
        [JsonProperty("name")]
        public string WebhookName { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class ProjectsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("taskBasedEstimation")]
        public bool TaskBasedEstimation { get; set; }

        [JsonProperty("estimation")]
        public double Estimation { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("useAsDefault")]
        public bool UseAsDefault { get; set; }

        [JsonProperty("timesRecorded")]
        public ProjectsResponseTimesRecordedType TimesRecorded { get; set; }

        [JsonProperty("earnings")]
        public double Earnings { get; set; }

        [JsonProperty("hourly_rate_enabled")]
        public bool HourlyRateEnabled { get; set; }

        [JsonProperty("hourly_rate")]
        public double HourlyRate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("client")]
        public ProjectsResponseClientType Client { get; set; }

        [JsonProperty("tags")]
        public ProjectsResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("users")]
        public ProjectsResponseUsersTypeItem[] Users { get; set; }

        [JsonProperty("groups")]
        public ProjectsResponseGroupsTypeItem[] Groups { get; set; }

        [JsonProperty("workspace")]
        public ProjectsResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class ProjectsResponseTimesRecordedType
    {
        [JsonProperty("billable")]
        public double BillableTime { get; set; }

        [JsonProperty("notBillable")]
        public double NotBillableTime { get; set; }
    }

    public class ProjectsResponseClientType
    {
        [JsonProperty("id")]
        public string ClientId { get; set; }

        [JsonProperty("name")]
        public string ClientName { get; set; }
    }

    public class ProjectsResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string TagId { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }
    }

    public class ProjectsResponseUsersTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("billable_rate")]
        public double BillableRate { get; set; }

        [JsonProperty("removed")]
        public bool Removed { get; set; }
    }

    public class ProjectsResponseGroupsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("removed")]
        public bool Removed { get; set; }
    }

    public class ProjectsResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    public class TasksUpdateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("timesRecorded")]
        public TasksUpdateResponseTimesRecordedType TimesRecorded { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("client")]
        public TasksUpdateResponseClientType Client { get; set; }

        [JsonProperty("project")]
        public TasksUpdateResponseProjectType Project { get; set; }

        [JsonProperty("estimation")]
        public double Estimation { get; set; }

        [JsonProperty("assignedToUsers")]
        public TasksUpdateResponseAssignedToUsersTypeItem[] AssignedToUsers { get; set; }

        [JsonProperty("assignedToGroups")]
        public TasksUpdateResponseAssignedToGroupsTypeItem[] AssignedToGroups { get; set; }

        [JsonProperty("workspace")]
        public TasksUpdateResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class TasksUpdateResponseTimesRecordedType
    {
        [JsonProperty("billable")]
        public double BillableTime { get; set; }

        [JsonProperty("notBillable")]
        public double NotBillableTime { get; set; }
    }

    public class TasksUpdateResponseClientType
    {
        [JsonProperty("id")]
        public string ClientId { get; set; }

        [JsonProperty("name")]
        public string ClientsName { get; set; }
    }

    public class TasksUpdateResponseProjectType
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectsName { get; set; }

        [JsonProperty("completed")]
        public bool ProjectCompleted { get; set; }
    }

    public class TasksUpdateResponseAssignedToUsersTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }
    }

    public class TasksUpdateResponseAssignedToGroupsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("name")]
        public string GroupName { get; set; }
    }

    public class TasksUpdateResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    public class AddProjectBodyInput
    {
        public AddProjectBodyInput(string name, AddProjectBodyInputClientType client)
        {
            this.Name = name;
            this.Client = client;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("client", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddProjectBodyInputClientType Client { get; set; }

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Color { get; set; } = "#0000FF";

        [JsonProperty("billable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Billable { get; set; } = false;

        [JsonProperty("completed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Completed { get; set; } = false;

        [JsonProperty("taskBasedEstimation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool TaskBasedEstimation { get; set; } = false;

        [JsonProperty("estimation", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Estimation { get; set; } = 0;

        [JsonProperty("private", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Private { get; set; } = false;

        [JsonProperty("projectType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputProjectTypeType? ProjectType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.BodyInputProjectTypeType.Project;

        [JsonProperty("users")]
        public AddProjectBodyInputUsersTypeItem[] Users { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("groups")]
        public string[] Groups { get; set; }

        [JsonProperty("whoCanAddTasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? WhoCanAddTasks { get; set; } = 1;

        [JsonProperty("templateId")]
        public string ProjectTemplateId { get; set; }

        [JsonProperty("templateCopyRate")]
        public bool? TemplateCopyRate { get; set; }

        [JsonProperty("templateCopyTasks")]
        public bool? TemplateCopyTasks { get; set; }

        [JsonProperty("templateCopyTaskAssign")]
        public bool? TemplateCopyTaskAssign { get; set; }
    }

    public class AddProjectBodyInputClientType
    {
        public AddProjectBodyInputClientType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputProjectTypeType
    {
        [EnumMember(Value = "template")]
        Template,
        [EnumMember(Value = "project")]
        Project
    }

    public class AddProjectBodyInputUsersTypeItem
    {
        public AddProjectBodyInputUsersTypeItem(string userId, AddProjectBodyInputUsersTypeItemRoleInProjectType roleInProject)
        {
            this.UserId = userId;
            this.RoleInProject = roleInProject;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddProjectBodyInputUsersTypeItemRoleInProjectType RoleInProject { get; set; }

        [JsonProperty("billable_rate")]
        public double? BillableRate { get; set; }

        [JsonProperty("removed")]
        public bool? Removed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddProjectBodyInputUsersTypeItemRoleInProjectType
    {
        [EnumMember(Value = "member")]
        User,
        [EnumMember(Value = "manager")]
        Manager
    }

    public class UpdateProjectBodyInput
    {
        public UpdateProjectBodyInput(string name, AddProjectBodyInputClientType client, bool billable, bool taskBasedEstimation, bool @private)
        {
            this.Name = name;
            this.Client = client;
            this.Billable = billable;
            this.TaskBasedEstimation = taskBasedEstimation;
            this.Private = @private;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("client", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddProjectBodyInputClientType Client { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("billable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Billable { get; set; }

        [JsonProperty("completed")]
        public bool? Completed { get; set; }

        [JsonProperty("taskBasedEstimation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool TaskBasedEstimation { get; set; }

        [JsonProperty("estimation")]
        public double? Estimation { get; set; }

        [JsonProperty("private", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Private { get; set; }

        [JsonProperty("hourly_rate")]
        public double? HourlyRate { get; set; }

        [JsonProperty("hourly_rate_enabled")]
        public bool? HourlyRateEnabled { get; set; }

        [JsonProperty("users")]
        public UpdateProjectBodyInputUsersTypeItem[] Users { get; set; }

        [JsonProperty("tags")]
        public UpdateProjectBodyInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("groups")]
        public string[] Groups { get; set; }

        [JsonProperty("whoCanAddTasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? WhoCanAddTasks { get; set; } = 1;

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; } = "new";

        [JsonProperty("workspace")]
        public BodyInputWorkspaceType Workspace { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }
    }

    public class UpdateProjectBodyInputUsersTypeItem
    {
        public UpdateProjectBodyInputUsersTypeItem(string userId, AddProjectBodyInputUsersTypeItemRoleInProjectType roleInProject)
        {
            this.UserId = userId;
            this.RoleInProject = roleInProject;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddProjectBodyInputUsersTypeItemRoleInProjectType RoleInProject { get; set; }

        [JsonProperty("billable_rate")]
        public double? BillableRate { get; set; }
    }

    public class UpdateProjectBodyInputTagsTypeItem
    {
        public UpdateProjectBodyInputTagsTypeItem(string tagId, string tagName)
        {
            this.TagId = tagId;
            this.TagName = tagName;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TagId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TagName { get; set; }
    }

    public class BodyInputWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    public class UpdateProjectTagsBodyInput
    {
        [JsonProperty("tags")]
        public UpdateProjectTagsBodyInputTagsTypeItem[] Tags { get; set; }
    }

    public class UpdateProjectTagsBodyInputTagsTypeItem
    {
        public UpdateProjectTagsBodyInputTagsTypeItem(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class UpdateProjectUsersBodyInput
    {
        [JsonProperty("users")]
        public UpdateProjectUsersBodyInputUsersTypeItem[] Users { get; set; }
    }

    public class UpdateProjectUsersBodyInputUsersTypeItem
    {
        public UpdateProjectUsersBodyInputUsersTypeItem(string userId, UpdateProjectUsersBodyInputUsersTypeItemRoleInProjectType roleInProject)
        {
            this.UserId = userId;
            this.RoleInProject = roleInProject;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateProjectUsersBodyInputUsersTypeItemRoleInProjectType RoleInProject { get; set; }

        [JsonProperty("billable_rate")]
        public double? BillableRate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateProjectUsersBodyInputUsersTypeItemRoleInProjectType
    {
        [EnumMember(Value = "member")]
        Member,
        [EnumMember(Value = "manager")]
        Manager
    }

    public class UpdateProjectGroupsBodyInput
    {
        [JsonProperty("groups")]
        public BodyInputGroupsTypeItem[] Groups { get; set; }
    }

    public class BodyInputGroupsTypeItem
    {
        public BodyInputGroupsTypeItem(string groupId, BodyInputGroupsTypeItemRoleInProjectType roleInProject)
        {
            this.GroupId = groupId;
            this.RoleInProject = roleInProject;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGroupsTypeItemRoleInProjectType RoleInProject { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGroupsTypeItemRoleInProjectType
    {
        [EnumMember(Value = "member")]
        Member,
        [EnumMember(Value = "manager")]
        Manager
    }

    public class TimesResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string NameOfTheTime { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("timeDiff")]
        public double Duration { get; set; }

        [JsonProperty("timeZone")]
        public string Timezone { get; set; }

        [JsonProperty("amount")]
        public double Earning { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("project")]
        public TimesResponseProjectType Project { get; set; }

        [JsonProperty("task")]
        public TimesResponseTaskObjectType TaskObject { get; set; }

        [JsonProperty("client")]
        public TimesResponseClientType Client { get; set; }

        [JsonProperty("user")]
        public TimesResponseUserType User { get; set; }

        [JsonProperty("tags")]
        public TimesResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("outlookCalenderReference")]
        public string OutlookCalendarReference { get; set; }

        [JsonProperty("workspace")]
        public TimesResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("hasTimeOverlap")]
        public bool TimeOverlap { get; set; }

        [JsonProperty("inputMode")]
        public string InputMode { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class TimesResponseProjectType
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectsName { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("useAsDefault")]
        public bool UseAsDefault { get; set; }

        [JsonProperty("tags")]
        public TimesResponseProjectTypeTagsTypeItem[] Tags { get; set; }
    }

    public class TimesResponseProjectTypeTagsTypeItem
    {
        [JsonProperty("id")]
        public string TagId { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }
    }

    public class TimesResponseTaskObjectType
    {
        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("name")]
        public string TasksName { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class TimesResponseClientType
    {
        [JsonProperty("id")]
        public string ClientId { get; set; }

        [JsonProperty("name")]
        public string ClientsName { get; set; }
    }

    public class TimesResponseUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string UsersName { get; set; }
    }

    public class TimesResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string TagId { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }
    }

    public class TimesResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilterDateRangeInput
    {
        [EnumMember(Value = "today")]
        Today,
        [EnumMember(Value = "yesterday")]
        Yesterday,
        [EnumMember(Value = "this_week")]
        ThisWeek,
        [EnumMember(Value = "last_week")]
        LastWeek,
        [EnumMember(Value = "this_month")]
        ThisMonth,
        [EnumMember(Value = "last_month")]
        LastMonth,
        [EnumMember(Value = "this_year")]
        ThisYear,
        [EnumMember(Value = "last_year")]
        LastYear,
        [EnumMember(Value = "all_time")]
        AllTime
    }

    public class AddTimeBodyInput
    {
        public AddTimeBodyInput(AddTimeBodyInputClientType client, AddTimeBodyInputProjectType project, string name, string start)
        {
            this.Client = client;
            this.Project = project;
            this.Name = name;
            this.Start = start;
        }

        [JsonProperty("client", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddTimeBodyInputClientType Client { get; set; }

        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddTimeBodyInputProjectType Project { get; set; }

        [JsonProperty("task")]
        public AddTimeBodyInputTaskObjectType TaskObject { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("billable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Billable { get; set; } = false;

        [JsonProperty("tags")]
        public AddTimeBodyInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("inputMode")]
        public string InputMode { get; set; }

        [JsonProperty("outlookCalenderReference")]
        public string OutlookCalendarReference { get; set; }
    }

    public class AddTimeBodyInputClientType
    {
        public AddTimeBodyInputClientType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class AddTimeBodyInputProjectType
    {
        public AddTimeBodyInputProjectType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class AddTimeBodyInputTaskObjectType
    {
        public AddTimeBodyInputTaskObjectType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }
    }

    public class AddTimeBodyInputTagsTypeItem
    {
        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }
    }

    public class UpdateTimeBodyInput
    {
        [JsonProperty("client")]
        public AddProjectBodyInputClientType Client { get; set; }

        [JsonProperty("project")]
        public UpdateTaskBodyInputProjectType Project { get; set; }

        [JsonProperty("task")]
        public UpdateTimeBodyInputTaskObjectType TaskObject { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("billable")]
        public bool? Billable { get; set; }

        [JsonProperty("tags")]
        public UpdateTimeBodyInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("inputMode")]
        public string InputMode { get; set; }

        [JsonProperty("timeDiff")]
        public int? TimeDifference { get; set; }

        [JsonProperty("outlookCalenderReference")]
        public string OutlookCalendarReference { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("user")]
        public UpdateTimeBodyInputUserType User { get; set; }

        [JsonProperty("workspace")]
        public BodyInputWorkspaceType Workspace { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class UpdateTaskBodyInputProjectType
    {
        public UpdateTaskBodyInputProjectType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("completed")]
        public bool? Completed { get; set; }
    }

    public class UpdateTimeBodyInputTaskObjectType
    {
        public UpdateTimeBodyInputTaskObjectType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("completed")]
        public bool? Completed { get; set; }
    }

    public class UpdateTimeBodyInputTagsTypeItem
    {
        public UpdateTimeBodyInputTagsTypeItem(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateTimeBodyInputUserType
    {
        public UpdateTimeBodyInputUserType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddTaskBodyInput
    {
        public AddTaskBodyInput(string name, AddTaskBodyInputProjectType project)
        {
            this.Name = name;
            this.Project = project;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("estimation", DefaultValueHandling = DefaultValueHandling.Include)]
        public double EstimationSeconds { get; set; } = 0;

        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddTaskBodyInputProjectType Project { get; set; }

        [JsonProperty("assignedToGroups")]
        public AddTaskBodyInputAssignedGroupsTypeItem[] AssignedGroups { get; set; }

        [JsonProperty("assignedToUsers")]
        public string[] AssignedUsers { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class AddTaskBodyInputProjectType
    {
        public AddTaskBodyInputProjectType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }
    }

    public class AddTaskBodyInputAssignedGroupsTypeItem
    {
        public AddTaskBodyInputAssignedGroupsTypeItem(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("synchronizedGroup")]
        public bool? SynchronizedGroup { get; set; }
    }

    public class UpdateTaskBodyInput
    {
        public UpdateTaskBodyInput(UpdateTaskBodyInputProjectType project)
        {
            this.Project = project;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("estimation")]
        public double? EstimationSeconds { get; set; }

        [JsonProperty("completed")]
        public bool? Completed { get; set; }

        [JsonProperty("client")]
        public AddProjectBodyInputClientType Client { get; set; }

        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateTaskBodyInputProjectType Project { get; set; }

        [JsonProperty("assignedToGroups")]
        public UpdateTaskBodyInputAssignedGroupsTypeItem[] AssignedGroups { get; set; }

        [JsonProperty("assignedToUsers")]
        public string[] AssignedUsers { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timesRecorded")]
        public BodyInputTimesRecordedType TimesRecorded { get; set; }

        [JsonProperty("workspace")]
        public BodyInputWorkspaceType Workspace { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("canCreateTime")]
        public bool? CanCreateTime { get; set; }

        [JsonProperty("canEdit")]
        public bool? CanEdit { get; set; }
    }

    public class UpdateTaskBodyInputAssignedGroupsTypeItem
    {
        public UpdateTaskBodyInputAssignedGroupsTypeItem(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class BodyInputTimesRecordedType
    {
        [JsonProperty("billable")]
        public double? BillableTime { get; set; }

        [JsonProperty("notBillable")]
        public double? NonBillableTime { get; set; }
    }

    public class ClientsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("useAsDefault")]
        public bool UseAsDefault { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("workspace")]
        public ClientsResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("meta")]
        public ClientsResponseMetaType Meta { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class ClientsResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    public class ClientsResponseMetaType
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("primaryContact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("secondaryContact")]
        public string SecondaryContact { get; set; }

        [JsonProperty("onboardDate")]
        public string OnboardDate { get; set; }

        [JsonProperty("taxRate")]
        public string TaxRate { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class AddClientBodyInput
    {
        public AddClientBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UpdateClientBodyInput
    {
        public UpdateClientBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("workspace")]
        public BodyInputWorkspaceType Workspace { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; } = "active";

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetadataType Metadata { get; set; }
    }

    public class BodyInputMetadataType
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("primaryContact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("secondaryContact")]
        public string SecondaryContact { get; set; }

        [JsonProperty("onboardDate")]
        public string OnboardDate { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }
    }

    public class GroupsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("synchronizedGroup")]
        public bool Synchronized { get; set; }

        [JsonProperty("synchronizedGroupType")]
        public string SynchronizedGroupType { get; set; }

        [JsonProperty("users")]
        public GroupsResponseUsersTypeItem[] Users { get; set; }

        [JsonProperty("workspace")]
        public GroupsResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class GroupsResponseUsersTypeItem
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GroupsResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    public class AddGroupBodyInput
    {
        public AddGroupBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("users")]
        public AddGroupBodyInputUsersTypeItem[] Users { get; set; }

        [JsonProperty("synchronizedGroup", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SynchronizedGroup { get; set; } = false;

        [JsonProperty("synchronizedGroupType")]
        public string SynchronizedGroupType { get; set; }
    }

    public class AddGroupBodyInputUsersTypeItem
    {
        public AddGroupBodyInputUsersTypeItem(string userId)
        {
            this.UserId = userId;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }
    }

    public class UpdateGroupBodyInput
    {
        public UpdateGroupBodyInput(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("synchronizedGroup", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SynchronizedGroup { get; set; } = false;

        [JsonProperty("synchronizedGroupType")]
        public string SynchronizedGroupType { get; set; }

        [JsonProperty("users")]
        public UpdateGroupBodyInputUsersTypeItem[] Users { get; set; }
    }

    public class UpdateGroupBodyInputUsersTypeItem
    {
        public UpdateGroupBodyInputUsersTypeItem(string userId, string email)
        {
            this.UserId = userId;
            this.Email = email;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TagsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("tagType")]
        public int TagType { get; set; }

        [JsonProperty("workspace")]
        public TagsResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CanEdit { get; set; }
    }

    public class TagsResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilterInput
    {
        [EnumMember(Value = "tagType eq 0")]
        TagTypeEq0,
        [EnumMember(Value = "tagType eq 1")]
        TagTypeEq1
    }

    public class AddTagBodyInput
    {
        public AddTagBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("tagType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputNameType Name2 { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.BodyInputNameType._0;
    }

    public enum BodyInputNameType
    {
        _0 = 0,
        _1 = 1
    }

    public class UpdateTagBodyInput
    {
        public UpdateTagBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("tagType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTagTypeType TagType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.BodyInputTagTypeType._1;

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("workspace")]
        public BodyInputWorkspaceType Workspace { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; } = "new";

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public enum BodyInputTagTypeType
    {
        _0 = 0,
        _1 = 1
    }

    public class ComeGoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("cosmosEntityName")]
        public string CosmosEntityName { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public ComeGoResponseUserType User { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("workspace")]
        public ComeGoResponseWorkspaceType Workspace { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool CurrentUserCanEdit { get; set; }
    }

    public class ComeGoResponseUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ComeGoResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AddComeGoBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("type")]
        public BodyInputTypeType? Type { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("user")]
        public AddComeGoBodyInputUserType User { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "pause")]
        Pause,
        [EnumMember(Value = "absence")]
        Absence
    }

    public class AddComeGoBodyInputUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class BodyInputItem
    {
        [JsonProperty("cosmosEntityName")]
        public string EntityName { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("editor")]
        public string EditorId { get; set; }

        [JsonProperty("author")]
        public string AuthorId { get; set; }

        [JsonProperty("created")]
        public string CreatedTimestamp { get; set; }

        [JsonProperty("modified")]
        public string ModifiedTimestamp { get; set; }

        [JsonProperty("id")]
        public string EntryId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public BodyInputItemUserType User { get; set; }

        [JsonProperty("workspace")]
        public BodyInputItemWorkspaceType Workspace { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("currentUserCanEdit")]
        public bool? UserCanEdit { get; set; }
    }

    public class BodyInputItemUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }
    }

    public class BodyInputItemWorkspaceType
    {
        [JsonProperty("id")]
        public string WorkspaceId { get; set; }
    }

    public class CustomFeedEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("imageUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class AddCustomFeedEventBodyInput
    {
        public AddCustomFeedEventBodyInput(string name, AddCustomFeedEventBodyInputUserType user, string start, string end)
        {
            this.Name = name;
            this.User = user;
            this.Start = start;
            this.End = end;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddCustomFeedEventBodyInputUserType User { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public string End { get; set; }

        [JsonProperty("imageUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class AddCustomFeedEventBodyInputUserType
    {
        public AddCustomFeedEventBodyInputUserType(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class UpdateCustomFeedEventBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user")]
        public AddCustomFeedEventBodyInputUserType User { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("imageUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemTypeInput
    {
        [EnumMember(Value = "projects")]
        Project,
        [EnumMember(Value = "tasks")]
        TaskObject,
        [EnumMember(Value = "times")]
        Time,
        [EnumMember(Value = "clients")]
        Client,
        [EnumMember(Value = "tags")]
        Tag,
        [EnumMember(Value = "customfeedevent")]
        CustomFeedEvent,
        [EnumMember(Value = "comego")]
        WorkingHour
    }

    public class CreateExcelReportBodyInput
    {
        public CreateExcelReportBodyInput(string startDate, string endDate, bool groupedByProject)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GroupedByProject = groupedByProject;
        }

        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("billable")]
        public BodyInputBillableType? Billable { get; set; }

        [JsonProperty("columns")]
        public BodyInputColumnsType Columns { get; set; }

        [JsonProperty("groupedByProject", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool GroupedByProject { get; set; }

        [JsonProperty("projectStatus")]
        public BodyInputProjectStatusType? ProjectStatus { get; set; }

        [JsonProperty("rounding")]
        public BodyInputRoundingType Rounding { get; set; }

        [JsonProperty("timeZone")]
        public BodyInputTimeZoneType? TimeZone { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputBillableType
    {
        [EnumMember(Value = "both")]
        Both,
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public class BodyInputColumnsType
    {
        [JsonProperty("client")]
        public bool? Client { get; set; }

        [JsonProperty("project")]
        public bool? Project { get; set; }

        [JsonProperty("projectDescription")]
        public bool? ProjectDescription { get; set; }

        [JsonProperty("task")]
        public bool? TaskObject { get; set; }

        [JsonProperty("description")]
        public bool? Description { get; set; }

        [JsonProperty("author")]
        public bool? Author { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputProjectStatusType
    {
        [EnumMember(Value = "both")]
        Both,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "archived")]
        Archived
    }

    public class BodyInputRoundingType
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("minutes")]
        public int? Minutes { get; set; }

        [JsonProperty("type")]
        public BodyInputRoundingTypeTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRoundingTypeTypeType
    {
        [EnumMember(Value = "upto")]
        Upto,
        [EnumMember(Value = "downto")]
        Downto,
        [EnumMember(Value = "nearest")]
        Nearest
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTimeZoneType
    {
        [EnumMember(Value = "KEEP")]
        Keep,
        [EnumMember(Value = "ADJUST")]
        Adjust
    }

    public class ClientChangesBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; } = "Power Automate Client Trigger";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "clients";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public ClientChangesBodyInputRunOnTypeItem[] RunOn { get; set; } = new ClientChangesBodyInputRunOnTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.ClientChangesBodyInputRunOnTypeItem.NewClientAdded,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.ClientChangesBodyInputRunOnTypeItem.ExistingClientUpdated,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.ClientChangesBodyInputRunOnTypeItem.ClientDeleted
        };

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ClientChangesBodyInputRunOnTypeItem
    {
        [EnumMember(Value = "add")]
        NewClientAdded,
        [EnumMember(Value = "update")]
        ExistingClientUpdated,
        [EnumMember(Value = "delete")]
        ClientDeleted
    }

    public class BodyInputConfigType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class TagChangesBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; } = "Power-Automate Tag Trigger";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public TagChangesBodyInputRunOnTypeItem[] RunOn { get; set; } = new TagChangesBodyInputRunOnTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TagChangesBodyInputRunOnTypeItem.NewTagAdded,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TagChangesBodyInputRunOnTypeItem.ExistingTagUpdated,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TagChangesBodyInputRunOnTypeItem.TagDeleted
        };

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "tags";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagChangesBodyInputRunOnTypeItem
    {
        [EnumMember(Value = "add")]
        NewTagAdded,
        [EnumMember(Value = "update")]
        ExistingTagUpdated,
        [EnumMember(Value = "delete")]
        TagDeleted
    }

    public class ProjectChangesBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; } = "Power-Automate Project Trigger";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public ProjectChangesBodyInputRunOnTypeItem[] RunOn { get; set; } = new ProjectChangesBodyInputRunOnTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.ProjectChangesBodyInputRunOnTypeItem.NewProjectAdded,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.ProjectChangesBodyInputRunOnTypeItem.ExistingProjectUpdated,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.ProjectChangesBodyInputRunOnTypeItem.ProjectDeleted
        };

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "projects";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProjectChangesBodyInputRunOnTypeItem
    {
        [EnumMember(Value = "add")]
        NewProjectAdded,
        [EnumMember(Value = "update")]
        ExistingProjectUpdated,
        [EnumMember(Value = "delete")]
        ProjectDeleted
    }

    public class TaskChangesBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; } = "Power-Automate Task Trigger";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public TaskChangesBodyInputRunOnTypeItem[] RunOn { get; set; } = new TaskChangesBodyInputRunOnTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TaskChangesBodyInputRunOnTypeItem.NewTaskAdded,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TaskChangesBodyInputRunOnTypeItem.ExistingTaskUpdated,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TaskChangesBodyInputRunOnTypeItem.TaskDeleted
        };

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "tasks";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskChangesBodyInputRunOnTypeItem
    {
        [EnumMember(Value = "add")]
        NewTaskAdded,
        [EnumMember(Value = "update")]
        ExistingTaskUpdated,
        [EnumMember(Value = "delete")]
        TaskDeleted
    }

    public class TimeChangesBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; } = "Power-Automate Time Trigger";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public TimeChangesBodyInputRunOnTypeItem[] RunOn { get; set; } = new TimeChangesBodyInputRunOnTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TimeChangesBodyInputRunOnTypeItem.NewTimeAdded,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TimeChangesBodyInputRunOnTypeItem.ExistingTimeUpdated,
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost.TimeChangesBodyInputRunOnTypeItem.TimeDeleted
        };

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "times";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeChangesBodyInputRunOnTypeItem
    {
        [EnumMember(Value = "add")]
        NewTimeAdded,
        [EnumMember(Value = "update")]
        ExistingTimeUpdated,
        [EnumMember(Value = "delete")]
        TimeDeleted
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Timeghost;

    public partial class WorkflowManagedActions
    {
        public TimeghostActions Timeghost(string connectionId) => new TimeghostActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TimeghostTriggers Timeghost(string connectionId) => new TimeghostTriggers(connectionId);
    }
}