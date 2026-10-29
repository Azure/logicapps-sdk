//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vineforce
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VineforceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<AlertResponse, ApiConnectionActionConfiguration> Alert(Expression<Func<AlertInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AlertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/PushNotificationFromExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AlertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateExternalProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateTaskResponse, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<UpdateTaskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateExternalTask";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContactNote(Expression<Func<CreateContactNoteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactNotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateCompany(Expression<Func<CreateCompanyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalCompany/CreateCompanyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<CreateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContactPhone(Expression<Func<CreateContactPhoneInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactPhoneExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContactAddress(Expression<Func<CreateContactAddressInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactAddressExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContactFamily(Expression<Func<CreateContactFamilyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/CreateContactFamilyExternal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetContactFolderDetailsResponse, ApiConnectionActionConfiguration> GetContactFolderDetails(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<string>> contactEmail)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            var __workflow_contactEmail = WorkflowExpression.Compile(contactEmail, nameof(contactEmail), required: true);
            return new DeferredBodyAction<GetContactFolderDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalContact/GetContactFolderDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                callPayload.Queries["ContactEmail"] = ExpressionConverter.Convert(__workflow_contactEmail);
                return new ApiConnectionAction<GetContactFolderDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetCompanyDetailExternalResponse, ApiConnectionActionConfiguration> GetCompanyDetailExternal(Expression<Func<string>> apiKey, Expression<Func<matchByInput>> matchBy, Expression<Func<string>> matchValue)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_matchBy = WorkflowExpression.Compile(matchBy, nameof(matchBy), required: true);
            var __workflow_matchValue = WorkflowExpression.Compile(matchValue, nameof(matchValue), required: true);
            return new DeferredBodyAction<GetCompanyDetailExternalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalCompany/GetCompanyDetailExternal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["MatchBy"] = ExpressionConverter.Convert(__workflow_matchBy);
                callPayload.Queries["MatchValue"] = ExpressionConverter.Convert(__workflow_matchValue);
                return new ApiConnectionAction<GetCompanyDetailExternalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskByResourceExtResponse, ApiConnectionActionConfiguration> GetTaskByResourceExt(Expression<Func<string>> apiKey, Expression<Func<string>> resourceAppId)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_resourceAppId = WorkflowExpression.Compile(resourceAppId, nameof(resourceAppId), required: true);
            return new DeferredBodyAction<GetTaskByResourceExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskByResourceExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["ResourceAppID"] = ExpressionConverter.Convert(__workflow_resourceAppId);
                return new ApiConnectionAction<GetTaskByResourceExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateTaskCommentExtResponse, ApiConnectionActionConfiguration> CreateTaskCommentExt(Expression<Func<CreateTaskCommentExtInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTaskCommentExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateTaskCommentExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskCommentExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<UpdateProjectResponse, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<UpdateProjectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/UpdateProjectExt";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetTaskExtResponse, ApiConnectionActionConfiguration> GetTaskExt(Expression<Func<string>> apiKey, Expression<Func<getByInput>> getBy, Expression<Func<string>> id, Expression<Func<string>> source = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_getBy = WorkflowExpression.Compile(getBy, nameof(getBy), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            return new DeferredBodyAction<GetTaskExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetTaskExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["GetBy"] = ExpressionConverter.Convert(__workflow_getBy);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(__workflow_source);
                return new ApiConnectionAction<GetTaskExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectExtResponse, ApiConnectionActionConfiguration> GetProjectExt(Expression<Func<string>> apiKey, Expression<Func<getByInput>> getBy, Expression<Func<string>> id, Expression<Func<string>> source = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_getBy = WorkflowExpression.Compile(getBy, nameof(getBy), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            return new DeferredBodyAction<GetProjectExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["GetBy"] = ExpressionConverter.Convert(__workflow_getBy);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(__workflow_source);
                return new ApiConnectionAction<GetProjectExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectTemplatesExtResponse, ApiConnectionActionConfiguration> GetProjectTemplatesExt(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            return new DeferredBodyAction<GetProjectTemplatesExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectTemplatesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                return new ApiConnectionAction<GetProjectTemplatesExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<GetProjectRolesExtResponse, ApiConnectionActionConfiguration> GetProjectRolesExt(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<roleTypeInput>> roleType = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            var __workflow_roleType = WorkflowExpression.Compile(roleType, nameof(roleType), required: false);
            return new DeferredBodyAction<GetProjectRolesExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/GetProjectRolesExt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                if (__workflow_roleType != null)
                    callPayload.Queries["RoleType"] = ExpressionConverter.Convert(__workflow_roleType);
                return new ApiConnectionAction<GetProjectRolesExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<CreateProjectFromTemplateExtResponse, ApiConnectionActionConfiguration> CreateProjectFromTemplateExt(Expression<Func<CreateProjectFromTemplateExtInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProjectFromTemplateExtResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/CreateProjectFromTemplateExt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectFromTemplateExtResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vineforce")]
        public IBodyWorkflowAction<DeletetaskResponse, ApiConnectionActionConfiguration> Deletetask(Expression<Func<string>> apiKey, Expression<Func<string>> taskId)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<DeletetaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/services/app/ExternalTask/DeleteExternalTask";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["TaskID"] = ExpressionConverter.Convert(__workflow_taskId);
                return new ApiConnectionAction<DeletetaskResponse>(callPayload);
            });
        }
    }

    public class VineforceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenTaskIsCompletedResponse, ApiConnectionTriggerConfiguration> WhenTaskIsCompleted(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> creatorEmail = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_assigneeEmail = WorkflowExpression.Compile(assigneeEmail, nameof(assigneeEmail), required: false);
            var __workflow_creatorEmail = WorkflowExpression.Compile(creatorEmail, nameof(creatorEmail), required: false);
            return new DeferredBodyTrigger<WhenTaskIsCompletedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentCompletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                if (__workflow_projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(__workflow_assigneeEmail);
                if (__workflow_creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = ExpressionConverter.Convert(__workflow_creatorEmail);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsCompletedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WhenTaskSectionIsChangedResponse, ApiConnectionTriggerConfiguration> WhenTaskSectionIsChanged(Expression<Func<string>> apiKey, Expression<Func<string>> userEmail, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> taskId = null, Expression<Func<string>> oldSectionId = null, Expression<Func<string>> oldSectoinName = null, Expression<Func<string>> newSectionId = null, Expression<Func<string>> newSectoinName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_userEmail = WorkflowExpression.Compile(userEmail, nameof(userEmail), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_assigneeEmail = WorkflowExpression.Compile(assigneeEmail, nameof(assigneeEmail), required: false);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            var __workflow_oldSectionId = WorkflowExpression.Compile(oldSectionId, nameof(oldSectionId), required: false);
            var __workflow_oldSectoinName = WorkflowExpression.Compile(oldSectoinName, nameof(oldSectoinName), required: false);
            var __workflow_newSectionId = WorkflowExpression.Compile(newSectionId, nameof(newSectionId), required: false);
            var __workflow_newSectoinName = WorkflowExpression.Compile(newSectoinName, nameof(newSectoinName), required: false);
            return new DeferredBodyTrigger<WhenTaskSectionIsChangedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentModifiedSectionTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["UserEmail"] = ExpressionConverter.Convert(__workflow_userEmail);
                if (__workflow_projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(__workflow_assigneeEmail);
                if (__workflow_taskId != null)
                    callPayload.Queries["TaskId"] = ExpressionConverter.Convert(__workflow_taskId);
                if (__workflow_oldSectionId != null)
                    callPayload.Queries["OldSectionId"] = ExpressionConverter.Convert(__workflow_oldSectionId);
                if (__workflow_oldSectoinName != null)
                    callPayload.Queries["OldSectoinName"] = ExpressionConverter.Convert(__workflow_oldSectoinName);
                if (__workflow_newSectionId != null)
                    callPayload.Queries["NewSectionId"] = ExpressionConverter.Convert(__workflow_newSectionId);
                if (__workflow_newSectoinName != null)
                    callPayload.Queries["NewSectoinName"] = ExpressionConverter.Convert(__workflow_newSectoinName);
                return new ApiConnectionTrigger<WhenTaskSectionIsChangedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WhenTaskIsCreatedResponse, ApiConnectionTriggerConfiguration> WhenTaskIsCreated(Expression<Func<string>> apiKey, Expression<Func<int>> duration, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            return new DeferredBodyTrigger<WhenTaskIsCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyCreatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WhenTaskIsUpdatedResponse, ApiConnectionTriggerConfiguration> WhenTaskIsUpdated(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> updateFilter = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            var __workflow_updateFilter = WorkflowExpression.Compile(updateFilter, nameof(updateFilter), required: false);
            return new DeferredBodyTrigger<WhenTaskIsUpdatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyUpdatedTask";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                if (__workflow_updateFilter != null)
                    callPayload.Queries["UpdateFilter"] = ExpressionConverter.Convert(__workflow_updateFilter);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsUpdatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WhenTaskIsDeletedResponse, ApiConnectionTriggerConfiguration> WhenTaskIsDeleted(Expression<Func<string>> apiKey, Expression<Func<int>> duration, Expression<Func<string>> projectName = null, Expression<Func<string>> projectId = null, Expression<Func<string>> assigneeEmail = null, Expression<Func<string>> creatorEmail = null, FlowRecurrence recurrence = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: true);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_assigneeEmail = WorkflowExpression.Compile(assigneeEmail, nameof(assigneeEmail), required: false);
            var __workflow_creatorEmail = WorkflowExpression.Compile(creatorEmail, nameof(creatorEmail), required: false);
            return new DeferredBodyTrigger<WhenTaskIsDeletedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/api/GetRecentlyDeletedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApiKey"] = ExpressionConverter.Convert(__workflow_apiKey);
                if (__workflow_projectName != null)
                    callPayload.Queries["ProjectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectId != null)
                    callPayload.Queries["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_assigneeEmail != null)
                    callPayload.Queries["AssigneeEmail"] = ExpressionConverter.Convert(__workflow_assigneeEmail);
                if (__workflow_creatorEmail != null)
                    callPayload.Queries["CreatorEmail"] = ExpressionConverter.Convert(__workflow_creatorEmail);
                callPayload.Queries["Duration"] = ExpressionConverter.Convert(__workflow_duration);
                return new ApiConnectionTrigger<WhenTaskIsDeletedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("result")]
        public CreateTaskResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateTaskResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("taskID")]
        public string TaskId { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("responseData")]
        public int ResponseData { get; set; }

        [JsonProperty("listOfEntities")]
        public string ListOfEntities { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    public class CreateTaskInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("fromEmail")]
        public string FromEmail { get; set; }

        [JsonProperty("toEmail")]
        public string ToEmail { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("priorityText")]
        public CreateTaskInputPriorityTextType? PriorityText { get; set; }

        [JsonProperty("associatedContactEmail")]
        public string AssociatedContactEmail { get; set; }

        [JsonProperty("resourceAppName")]
        public CreateTaskInputResourceAppNameType? ResourceAppName { get; set; }

        [JsonProperty("resourceAppUrl")]
        public string ResourceAppUrl { get; set; }

        [JsonProperty("resourceAppID")]
        public string ResourceAppId { get; set; }

        [JsonProperty("resourceAppData")]
        public string ResourceAppData { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("projectSectionName")]
        public string ProjectSectionName { get; set; }

        [JsonProperty("projectTags")]
        public string ProjectTags { get; set; }

        [JsonProperty("checklists")]
        public CreateTaskInputChecklistsTypeItem[] Checklists { get; set; }

        [JsonProperty("files")]
        public CreateTaskInputFilesTypeItem[] Files { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskInputPriorityTextType
    {
        Normal,
        Important,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskInputResourceAppNameType
    {
        [EnumMember(Value = "Adobe Cloud")]
        AdobeCloud,
        [EnumMember(Value = "Adobe Sign")]
        AdobeSign,
        Asana,
        [EnumMember(Value = "Azure DevOps")]
        AzureDevOps,
        Bitbucket,
        [EnumMember(Value = "Contact Manager")]
        ContactManager,
        Docusign,
        Excel,
        HelloSign,
        Hubspot,
        Jira,
        Dataverse,
        [EnumMember(Value = "Dynamics 365")]
        Dynamics365,
        Forms,
        LinkedIn,
        List,
        [EnumMember(Value = "To Do")]
        ToDo,
        OneDrive,
        OneNote,
        Outlook,
        Pdf,
        Photo,
        Planner,
        [EnumMember(Value = "Power Apps")]
        PowerApps,
        [EnumMember(Value = "Power Automate")]
        PowerAutomate,
        PowerPoint,
        Teams,
        Twitter,
        Typeform,
        Visio,
        Word,
        Zendesk
    }

    public class CreateTaskInputChecklistsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CreateTaskInputFilesTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public CreateTaskInputFilesTypeItemFileTypeType? FileType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskInputFilesTypeItemFileTypeType
    {
        Word,
        Excel,
        PowerPoint,
        PDF,
        Photo,
        OneNote,
        Visio,
        Folder,
        Link,
        Other
    }

    public class AlertResponse
    {
        [JsonProperty("result")]
        public AlertResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class AlertResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    public class AlertInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("alertToEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AlertToEmail { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("resourceName")]
        public AlertInputResourceNameType? ResourceName { get; set; }
        public string ResourceUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertInputResourceNameType
    {
        [EnumMember(Value = "Adobe Cloud")]
        AdobeCloud,
        [EnumMember(Value = "Adobe Sign")]
        AdobeSign,
        Asana,
        [EnumMember(Value = "Azure DevOps")]
        AzureDevOps,
        Bitbucket,
        [EnumMember(Value = "Contact Manager")]
        ContactManager,
        Docusign,
        Excel,
        HelloSign,
        Hubspot,
        Jira,
        Dataverse,
        [EnumMember(Value = "Dynamics 365")]
        Dynamics365,
        Forms,
        LinkedIn,
        List,
        [EnumMember(Value = "To Do")]
        ToDo,
        OneDrive,
        OneNote,
        Outlook,
        Pdf,
        Photo,
        Planner,
        [EnumMember(Value = "Power Apps")]
        PowerApps,
        [EnumMember(Value = "Power Automate")]
        PowerAutomate,
        PowerPoint,
        Teams,
        Twitter,
        Typeform,
        Visio,
        Word,
        Zendesk
    }

    public class CreateProjectResponse
    {
        [JsonProperty("result")]
        public CreateProjectResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateProjectResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("projectID")]
        public string ProjectId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateProjectInput
    {
        [JsonProperty("projectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }

        [JsonProperty("creatorEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatorEmail { get; set; }

        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("isPrivate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsPrivate { get; set; } = false;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("members")]
        public string Members { get; set; }

        [JsonProperty("sections")]
        public string Sections { get; set; }

        [JsonProperty("files", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProjectInputFilesTypeItem[] Files { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }
    }

    public class CreateProjectInputFilesTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public CreateProjectInputFilesTypeItemFileTypeType? FileType { get; set; }

        [JsonProperty("fileItemId")]
        public string FileItemId { get; set; }

        [JsonProperty("fileDriveId")]
        public string FileDriveId { get; set; }

        [JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsDefault { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateProjectInputFilesTypeItemFileTypeType
    {
        Word,
        Excel,
        PowerPoint,
        PDF,
        Photo,
        OneNote,
        Visio,
        Folder,
        Link,
        Other
    }

    public class UpdateTaskResponse
    {
        [JsonProperty("result")]
        public UpdateTaskResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class UpdateTaskResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("taskID")]
        public string TaskId { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("responseData")]
        public int ResponseData { get; set; }

        [JsonProperty("listOfEntities")]
        public string ListOfEntities { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    public class UpdateTaskInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("taskID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("fromEmail")]
        public string FromEmail { get; set; }

        [JsonProperty("toEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToEmail { get; set; }
        public UpdateTaskInputTaskStatusType? TaskStatus { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("priorityText")]
        public UpdateTaskInputPriorityTextType? PriorityText { get; set; }

        [JsonProperty("associatedContactEmail")]
        public string AssociatedContactEmail { get; set; }

        [JsonProperty("resourceAppName")]
        public UpdateTaskInputResourceAppNameType? ResourceAppName { get; set; }

        [JsonProperty("resourceAppUrl")]
        public string ResourceAppUrl { get; set; }

        [JsonProperty("resourceAppID")]
        public string ResourceAppId { get; set; }

        [JsonProperty("resourceAppData")]
        public string ResourceAppData { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("projectSectionName")]
        public string ProjectSectionName { get; set; }

        [JsonProperty("projectTags")]
        public string ProjectTags { get; set; }

        [JsonProperty("checklists")]
        public UpdateTaskInputChecklistsTypeItem[] Checklists { get; set; }

        [JsonProperty("files")]
        public UpdateTaskInputFilesTypeItem[] Files { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputTaskStatusType
    {
        Completed,
        Unfinished
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputPriorityTextType
    {
        Normal,
        Important,
        Urgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputResourceAppNameType
    {
        [EnumMember(Value = "Adobe Cloud")]
        AdobeCloud,
        [EnumMember(Value = "Adobe Sign")]
        AdobeSign,
        Asana,
        [EnumMember(Value = "Azure DevOps")]
        AzureDevOps,
        Bitbucket,
        [EnumMember(Value = "Contact Manager")]
        ContactManager,
        Docusign,
        Excel,
        HelloSign,
        Hubspot,
        Jira,
        Dataverse,
        [EnumMember(Value = "Dynamics 365")]
        Dynamics365,
        Forms,
        LinkedIn,
        List,
        [EnumMember(Value = "To Do")]
        ToDo,
        OneDrive,
        OneNote,
        Outlook,
        Pdf,
        Photo,
        Planner,
        [EnumMember(Value = "Power Apps")]
        PowerApps,
        [EnumMember(Value = "Power Automate")]
        PowerAutomate,
        PowerPoint,
        Teams,
        Twitter,
        Typeform,
        Visio,
        Word,
        Zendesk
    }

    public class UpdateTaskInputChecklistsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UpdateTaskInputFilesTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public UpdateTaskInputFilesTypeItemFileTypeType? FileType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputFilesTypeItemFileTypeType
    {
        Word,
        Excel,
        PowerPoint,
        PDF,
        Photo,
        OneNote,
        Visio,
        Folder,
        Link,
        Other
    }

    public class CreateContactNoteInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("ownerEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerEmail { get; set; }

        [JsonProperty("contactEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("notes", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Notes { get; set; }
    }

    public class CreateCompanyInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("companyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CompanyName { get; set; }

        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suite_UnitNumber")]
        public string SuiteUnitNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("taxId")]
        public string TaxId { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }
    }

    public class CreateContactResponse
    {
        [JsonProperty("result")]
        public CreateContactResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateContactResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }
    }

    public class CreateContactInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("ownerEmailAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerEmailAddress { get; set; }

        [JsonProperty("contactEmailAddress1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmailAddress1 { get; set; }

        [JsonProperty("contactEmailAddress2")]
        public string ContactEmailAddress2 { get; set; }

        [JsonProperty("contactEmailAddress3")]
        public string ContactEmailAddress3 { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("birthDay")]
        public string BirthDay { get; set; }

        [JsonProperty("birthMonth")]
        public int? BirthMonth { get; set; }

        [JsonProperty("birthYear")]
        public int? BirthYear { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("companyID1")]
        public string CompanyID1 { get; set; }

        [JsonProperty("companyID2")]
        public string CompanyID2 { get; set; }

        [JsonProperty("companyID3")]
        public string CompanyID3 { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("socialSecurityNumber")]
        public string SocialSecurityNumber { get; set; }
    }

    public class CreateContactPhoneInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("contactEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }

        [JsonProperty("phoneType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactPhoneInputPhoneTypeType PhoneType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactPhoneInputPhoneTypeType
    {
        Mobile,
        Work,
        Home,
        Fax,
        Other
    }

    public class CreateContactAddressInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("contactEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("addressType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactAddressInputAddressTypeType AddressType { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suiteUnitNumber")]
        public string SuiteUnitNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactAddressInputAddressTypeType
    {
        Home,
        Physical,
        Mailing,
        Work,
        Other
    }

    public class CreateContactFamilyInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("contactEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactFamilyInputRelationshipType Relationship { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("birthMonth")]
        public int? BirthMonth { get; set; }

        [JsonProperty("birthYear")]
        public int? BirthYear { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactFamilyInputRelationshipType
    {
        Spouse,
        Son,
        Daughter,
        Mother,
        Father,
        Brother,
        Sister,
        GrandMother,
        GrandFather,
        GrandSon,
        GrandDaughter
    }

    public class GetContactFolderDetailsResponse
    {
        [JsonProperty("result")]
        public GetContactFolderDetailsResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetContactFolderDetailsResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("folderPath")]
        public string FolderPath { get; set; }

        [JsonProperty("isSharePointDrive")]
        public bool IsSharePointDrive { get; set; }
    }

    public class GetCompanyDetailExternalResponse
    {
        [JsonProperty("result")]
        public GetCompanyDetailExternalResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetCompanyDetailExternalResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suiteUnitNumber")]
        public string SuiteUnitNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("taxID")]
        public string TaxId { get; set; }

        [JsonProperty("folderPath")]
        public string FolderPath { get; set; }

        [JsonProperty("isSharePointDrive")]
        public bool IsSharePointDrive { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum matchByInput
    {
        [EnumMember(Value = "Account No.")]
        AccountNo,
        [EnumMember(Value = "Tax ID")]
        TaxId,
        [EnumMember(Value = "Company ID")]
        CompanyId,
        [EnumMember(Value = "Company Name")]
        CompanyName,
        URL
    }

    public class GetTaskByResourceExtResponse
    {
        [JsonProperty("result")]
        public GetTaskByResourceExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetTaskByResourceExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("taskID")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }
    }

    public class CreateTaskCommentExtResponse
    {
        [JsonProperty("result")]
        public CreateTaskCommentExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateTaskCommentExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("taskID")]
        public string TaskId { get; set; }
    }

    public class CreateTaskCommentExtInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserEmail { get; set; }

        [JsonProperty("taskId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskId { get; set; }

        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }

    public class UpdateProjectResponse
    {
        [JsonProperty("result")]
        public UpdateProjectResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class UpdateProjectResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("projectID")]
        public string ProjectId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class UpdateProjectInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("projectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }

        [JsonProperty("currentUserEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentUserEmail { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateProjectInputStatusType? Status { get; set; } = UpdateProjectInputStatusType.Active;

        [JsonProperty("isPrivate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsPrivate { get; set; } = false;

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateProjectInputStatusType
    {
        Active,
        Inactive
    }

    public class GetTaskExtResponse
    {
        [JsonProperty("result")]
        public GetTaskExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetTaskExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("taskID")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum getByInput
    {
        [EnumMember(Value = "Trovve Id")]
        TrovveId,
        [EnumMember(Value = "Reference Id")]
        ReferenceId
    }

    public class GetProjectExtResponse
    {
        [JsonProperty("result")]
        public GetProjectExtResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class GetProjectExtResponseResultType
    {
        [JsonProperty("statuscode")]
        public int Statuscode { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("managerEmails")]
        public string ManagerEmails { get; set; }

        [JsonProperty("folderLocPath")]
        public string FolderLocPath { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceData")]
        public string ReferenceData { get; set; }

        [JsonProperty("referenceSource")]
        public string ReferenceSource { get; set; }
    }

    public class GetProjectTemplatesExtResponse
    {
        [JsonProperty("result")]
        public GetProjectTemplatesExtResponseResultType Result { get; set; }
    }

    public class GetProjectTemplatesExtResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public GetProjectTemplatesExtResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class GetProjectTemplatesExtResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }
    }

    public class GetProjectRolesExtResponse
    {
        [JsonProperty("result")]
        public GetProjectRolesExtResponseResultType Result { get; set; }
    }

    public class GetProjectRolesExtResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public GetProjectRolesExtResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class GetProjectRolesExtResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("roleId")]
        public string RoleId { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("roleType")]
        public string RoleType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum roleTypeInput
    {
        Member,
        Manager
    }

    public class CreateProjectFromTemplateExtResponse
    {
        [JsonProperty("result")]
        public CreateProjectFromTemplateExtResponseResultType Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class CreateProjectFromTemplateExtResponseResultType
    {
        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public CreateProjectFromTemplateExtResponseResultTypeResponseDataType ResponseData { get; set; }
    }

    public class CreateProjectFromTemplateExtResponseResultTypeResponseDataType
    {
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }
    }

    public class CreateProjectFromTemplateExtInput
    {
        [JsonProperty("apiKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("creatorEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatorEmail { get; set; }

        [JsonProperty("projectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("isPrivate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPrivate { get; set; } = false;

        [JsonProperty("members")]
        public CreateProjectFromTemplateExtInputMembersTypeItem[] Members { get; set; }

        [JsonProperty("filesLinks")]
        public CreateProjectFromTemplateExtInputFilesLinksTypeItem[] FilesLinks { get; set; }
    }

    public class CreateProjectFromTemplateExtInputMembersTypeItem
    {
        [JsonProperty("roleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleId { get; set; }

        [JsonProperty("memberEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MemberEmail { get; set; }
    }

    public class CreateProjectFromTemplateExtInputFilesLinksTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public CreateProjectFromTemplateExtInputFilesLinksTypeItemFileTypeType? FileType { get; set; }

        [JsonProperty("fileItemId")]
        public string FileItemId { get; set; }

        [JsonProperty("fileDriveId")]
        public string FileDriveId { get; set; }

        [JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsDefault { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateProjectFromTemplateExtInputFilesLinksTypeItemFileTypeType
    {
        Word,
        Excel,
        PowerPoint,
        PDF,
        Photo,
        OneNote,
        Visio,
        Folder,
        Link,
        Other
    }

    public class DeletetaskResponse
    {
        [JsonProperty("result")]
        public DeletetaskResponseResultType Result { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonProperty("__abp")]
        public bool Abp { get; set; }
    }

    public class DeletetaskResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("message_Info")]
        public string MessageInfo { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("longTypeEntityId")]
        public string LongTypeEntityId { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
    }

    public class WhenTaskIsCompletedResponse
    {
        [JsonProperty("result")]
        public WhenTaskIsCompletedResponseResultType Result { get; set; }
    }

    public class WhenTaskIsCompletedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsCompletedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskIsCompletedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("lastModificationTime")]
        public string LastModificationTime { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("externalReferenceSource")]
        public string ExternalReferenceSource { get; set; }

        [JsonProperty("externalReferenceData")]
        public string ExternalReferenceData { get; set; }
    }

    public class WhenTaskSectionIsChangedResponse
    {
        [JsonProperty("result")]
        public WhenTaskSectionIsChangedResponseResultType Result { get; set; }
    }

    public class WhenTaskSectionIsChangedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskSectionIsChangedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskSectionIsChangedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("lastModificationTime")]
        public string LastModificationTime { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("externalReferenceSource")]
        public string ExternalReferenceSource { get; set; }

        [JsonProperty("externalReferenceData")]
        public string ExternalReferenceData { get; set; }
    }

    public class WhenTaskIsCreatedResponse
    {
        [JsonProperty("result")]
        public WhenTaskIsCreatedResponseResultType Result { get; set; }
    }

    public class WhenTaskIsCreatedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsCreatedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskIsCreatedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }
    }

    public class WhenTaskIsUpdatedResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("errorType")]
        public int ErrorType { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsUpdatedResponseResponseDataTypeItem[] ResponseData { get; set; }

        [JsonProperty("listOfEntities")]
        public WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItem[][] ListOfEntities { get; set; }
    }

    public class WhenTaskIsUpdatedResponseResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("changes")]
        public string Changes { get; set; }

        [JsonProperty("taskChanges")]
        public WhenTaskIsUpdatedResponseResponseDataTypeItemTaskChangesTypeItem[] TaskChanges { get; set; }
    }

    public class WhenTaskIsUpdatedResponseResponseDataTypeItemTaskChangesTypeItem
    {
        [JsonProperty("changeType")]
        public string ChangeType { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("taskChanges")]
        public WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItemTaskChangesTypeItem[] TaskChanges { get; set; }
    }

    public class WhenTaskIsUpdatedResponseListOfEntitiesTypeItemItemTaskChangesTypeItem
    {
        [JsonProperty("changeType")]
        public string ChangeType { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class WhenTaskIsDeletedResponse
    {
        [JsonProperty("result")]
        public WhenTaskIsDeletedResponseResultType Result { get; set; }
    }

    public class WhenTaskIsDeletedResponseResultType
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("responseData")]
        public WhenTaskIsDeletedResponseResultTypeResponseDataTypeItem[] ResponseData { get; set; }
    }

    public class WhenTaskIsDeletedResponseResultTypeResponseDataTypeItem
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assigneeEmail")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("assigneeName")]
        public string AssigneeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taskStatus")]
        public string TaskStatus { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("projectSection")]
        public string ProjectSection { get; set; }

        [JsonProperty("assoContactEmail")]
        public string AssoContactEmail { get; set; }

        [JsonProperty("assoContactName")]
        public string AssoContactName { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("lastModificationTime")]
        public string LastModificationTime { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("externalReferenceSource")]
        public string ExternalReferenceSource { get; set; }

        [JsonProperty("externalReferenceData")]
        public string ExternalReferenceData { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vineforce;

    public partial class WorkflowManagedActions
    {
        public VineforceActions Vineforce(string connectionId) => new VineforceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VineforceTriggers Vineforce(string connectionId) => new VineforceTriggers(connectionId);
    }
}