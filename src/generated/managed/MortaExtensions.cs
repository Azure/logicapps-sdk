//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Morta
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MortaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetFavouriteProjectsResponse, ApiConnectionActionConfiguration> GetFavouriteProjects()
        {
            return new DeferredBodyAction<GetFavouriteProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/projects/favourites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFavouriteProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetCommentThreadStatsByReferenceResponse, ApiConnectionActionConfiguration> GetCommentThreadStatsByReference(Expression<Func<referenceTypeInput>> referenceType, Expression<Func<string>> mainReferenceId = null)
        {
            var __workflow_referenceType = WorkflowExpression.Compile(referenceType, nameof(referenceType), required: true);
            var __workflow_mainReferenceId = WorkflowExpression.Compile(mainReferenceId, nameof(mainReferenceId), required: false);
            return new DeferredBodyAction<GetCommentThreadStatsByReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/comment_thread/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reference_type"] = ExpressionConverter.Convert(__workflow_referenceType);
                if (__workflow_mainReferenceId != null)
                    callPayload.Queries["main_reference_id"] = ExpressionConverter.Convert(__workflow_mainReferenceId);
                return new ApiConnectionAction<GetCommentThreadStatsByReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetNotificationEventTypesResponse, ApiConnectionActionConfiguration> GetNotificationEventTypes()
        {
            return new DeferredBodyAction<GetNotificationEventTypesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/notifications/event-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetNotificationEventTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> IntegrationsPassthroughDownloadApiCall(Expression<Func<IntegrationsPassthroughDownloadApiCallInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/integrations/passthrough-download";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<IntegrationsPassthroughApiCallResponse, ApiConnectionActionConfiguration> IntegrationsPassthroughApiCall(Expression<Func<IntegrationsPassthroughApiCallInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IntegrationsPassthroughApiCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/integrations/passthrough";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IntegrationsPassthroughApiCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTagByPublicIdResponse, ApiConnectionActionConfiguration> GetTagByPublicId(Expression<Func<string>> tagId)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<GetTagByPublicIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/permissions/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag_id"] = ExpressionConverter.Convert(__workflow_tagId);
                return new ApiConnectionAction<GetTagByPublicIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DuplicateProcessResponse, ApiConnectionActionConfiguration> DuplicateProcess(Expression<Func<DuplicateProcessInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DuplicateProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/process/duplicate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DuplicateProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserPublicProjectsResponse, ApiConnectionActionConfiguration> GetUserPublicProjects()
        {
            return new DeferredBodyAction<GetUserPublicProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/public-projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserPublicProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserOwnerProjectsResponse, ApiConnectionActionConfiguration> GetUserOwnerProjects()
        {
            return new DeferredBodyAction<GetUserOwnerProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/owner-projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserOwnerProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserTemplatesResponse, ApiConnectionActionConfiguration> GetUserTemplates()
        {
            return new DeferredBodyAction<GetUserTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserProjectsResponse, ApiConnectionActionConfiguration> GetUserProjects()
        {
            return new DeferredBodyAction<GetUserProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateUserAccountResponse, ApiConnectionActionConfiguration> UpdateUserAccount(Expression<Func<UpdateUserAccountInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateUserAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/account";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateUserAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateApiKeyResponse, ApiConnectionActionConfiguration> CreateApiKey(Expression<Func<CreateApiKeyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateApiKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/apikey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateApiKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<SearchUsersResponse, ApiConnectionActionConfiguration> SearchUsers(Expression<Func<string>> query, Expression<Func<string>> projectId = null, Expression<Func<string>> processId = null, Expression<Func<string>> tableViewId = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: false);
            var __workflow_tableViewId = WorkflowExpression.Compile(tableViewId, nameof(tableViewId), required: false);
            return new DeferredBodyAction<SearchUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectId != null)
                    callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_processId != null)
                    callPayload.Queries["process_id"] = ExpressionConverter.Convert(__workflow_processId);
                if (__workflow_tableViewId != null)
                    callPayload.Queries["table_view_id"] = ExpressionConverter.Convert(__workflow_tableViewId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<SearchUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetMeResponse, ApiConnectionActionConfiguration> GetMe()
        {
            return new DeferredBodyAction<GetMeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetCommentThreadsByReferenceResponse, ApiConnectionActionConfiguration> GetCommentThreadsByReference(Expression<Func<referenceTypeInput>> referenceType, Expression<Func<string>> referenceId, Expression<Func<string>> mainReference = null)
        {
            var __workflow_referenceType = WorkflowExpression.Compile(referenceType, nameof(referenceType), required: true);
            var __workflow_referenceId = WorkflowExpression.Compile(referenceId, nameof(referenceId), required: true);
            var __workflow_mainReference = WorkflowExpression.Compile(mainReference, nameof(mainReference), required: false);
            return new DeferredBodyAction<GetCommentThreadsByReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/comment_thread";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reference_type"] = ExpressionConverter.Convert(__workflow_referenceType);
                callPayload.Queries["reference_id"] = ExpressionConverter.Convert(__workflow_referenceId);
                if (__workflow_mainReference != null)
                    callPayload.Queries["main_reference"] = ExpressionConverter.Convert(__workflow_mainReference);
                return new ApiConnectionAction<GetCommentThreadsByReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateCommentThreadResponse, ApiConnectionActionConfiguration> CreateCommentThread(Expression<Func<CreateCommentThreadInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCommentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/comment_thread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCommentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateNotificationResponse, ApiConnectionActionConfiguration> CreateNotification(Expression<Func<CreateNotificationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateNotificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetResourcePermissionsResponse, ApiConnectionActionConfiguration> GetResourcePermissions(Expression<Func<resourceInput>> resource, Expression<Func<string>> resourceId)
        {
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            return new DeferredBodyAction<GetResourcePermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/permissions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resource"] = ExpressionConverter.Convert(__workflow_resource);
                callPayload.Queries["resource_id"] = ExpressionConverter.Convert(__workflow_resourceId);
                return new ApiConnectionAction<GetResourcePermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateResourcePermissionsResponse, ApiConnectionActionConfiguration> CreateResourcePermissions(Expression<Func<CreateResourcePermissionsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateResourcePermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/permissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResourcePermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<CreateProjectInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProcessResponse, ApiConnectionActionConfiguration> CreateProcess(Expression<Func<CreateProcessInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateTableResponse, ApiConnectionActionConfiguration> CreateTable(Expression<Func<CreateTableInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateCurrentUserResponse, ApiConnectionActionConfiguration> UpdateCurrentUser(Expression<Func<UpdateCurrentUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateCurrentUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/user";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateCurrentUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RestoreProcessResponseResponse, ApiConnectionActionConfiguration> RestoreProcessResponse(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<string>> processResponseId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_processResponseId = WorkflowExpression.Compile(processResponseId, nameof(processResponseId), required: true);
            return new DeferredBodyAction<RestoreProcessResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response/{2}/restore", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1), __workflow_processResponseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RestoreProcessResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<SubmitProcessResponseResponse, ApiConnectionActionConfiguration> SubmitProcessResponse(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<string>> processResponseId, Expression<Func<SubmitProcessResponseInput>> body = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_processResponseId = WorkflowExpression.Compile(processResponseId, nameof(processResponseId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubmitProcessResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response/{2}/submit", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1), __workflow_processResponseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubmitProcessResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ResetProcessResponseResponse, ApiConnectionActionConfiguration> ResetProcessResponse(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<string>> processResponseId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_processResponseId = WorkflowExpression.Compile(processResponseId, nameof(processResponseId), required: true);
            return new DeferredBodyAction<ResetProcessResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response/{2}/reset", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1), __workflow_processResponseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResetProcessResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<SubmitProcessResponseDraftResponse, ApiConnectionActionConfiguration> SubmitProcessResponseDraft(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<string>> processResponseId, Expression<Func<SubmitProcessResponseDraftInput>> body = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_processResponseId = WorkflowExpression.Compile(processResponseId, nameof(processResponseId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubmitProcessResponseDraftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response/{2}/draft", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1), __workflow_processResponseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubmitProcessResponseDraftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableViewDistinctValuesResponse, ApiConnectionActionConfiguration> GetTableViewDistinctValues(Expression<Func<string>> viewId, Expression<Func<string>> columnId, Expression<Func<string>> filter = null, Expression<Func<string[]>> groupColumns = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_groupColumns = WorkflowExpression.Compile(groupColumns, nameof(groupColumns), required: false);
            return new DeferredBodyAction<GetTableViewDistinctValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/column/{1}/distinct", __workflow_viewId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_groupColumns != null)
                    callPayload.Queries["group_columns"] = ExpressionConverter.Convert(__workflow_groupColumns);
                return new ApiConnectionAction<GetTableViewDistinctValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadTableViewChartImage(Expression<Func<string>> viewId, Expression<Func<string>> chartType = null, Expression<Func<bool>> showLegend = null, Expression<Func<bool>> showValues = null, Expression<Func<string>> columnValueId = null, Expression<Func<string>> columnLabelId = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_chartType = WorkflowExpression.Compile(chartType, nameof(chartType), required: false);
            var __workflow_showLegend = WorkflowExpression.Compile(showLegend, nameof(showLegend), required: false);
            var __workflow_showValues = WorkflowExpression.Compile(showValues, nameof(showValues), required: false);
            var __workflow_columnValueId = WorkflowExpression.Compile(columnValueId, nameof(columnValueId), required: false);
            var __workflow_columnLabelId = WorkflowExpression.Compile(columnLabelId, nameof(columnLabelId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/chart/image", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_chartType != null)
                    callPayload.Queries["chart_type"] = ExpressionConverter.Convert(__workflow_chartType);
                if (__workflow_showLegend != null)
                    callPayload.Queries["show_legend"] = ExpressionConverter.Convert(__workflow_showLegend);
                if (__workflow_showValues != null)
                    callPayload.Queries["show_values"] = ExpressionConverter.Convert(__workflow_showValues);
                if (__workflow_columnValueId != null)
                    callPayload.Queries["column_value_id"] = ExpressionConverter.Convert(__workflow_columnValueId);
                if (__workflow_columnLabelId != null)
                    callPayload.Queries["column_label_id"] = ExpressionConverter.Convert(__workflow_columnLabelId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpsertTableRowsInViewResponse, ApiConnectionActionConfiguration> UpsertTableRowsInView(Expression<Func<string>> viewId, Expression<Func<UpsertTableRowsInViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertTableRowsInViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/rows/upsert", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpsertTableRowsInViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DuplicateProcessSectionAsyncResponse, ApiConnectionActionConfiguration> DuplicateProcessSectionAsync(Expression<Func<string>> processId, Expression<Func<string>> processSectionId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            return new DeferredBodyAction<DuplicateProcessSectionAsyncResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/duplicate-async", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DuplicateProcessSectionAsyncResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DuplicateProcessSectionResponse, ApiConnectionActionConfiguration> DuplicateProcessSection(Expression<Func<string>> processId, Expression<Func<string>> processSectionId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            return new DeferredBodyAction<DuplicateProcessSectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/duplicate", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DuplicateProcessSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteProcessResponseResponse, ApiConnectionActionConfiguration> DeleteProcessResponse(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<string>> processResponseId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_processResponseId = WorkflowExpression.Compile(processResponseId, nameof(processResponseId), required: true);
            return new DeferredBodyAction<DeleteProcessResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response/{2}", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1), __workflow_processResponseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteProcessResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProcessResponseResponse, ApiConnectionActionConfiguration> UpdateProcessResponse(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<string>> processResponseId, Expression<Func<UpdateProcessResponseInput>> body = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_processResponseId = WorkflowExpression.Compile(processResponseId, nameof(processResponseId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateProcessResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response/{2}", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1), __workflow_processResponseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProcessResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProcessResponseResponse, ApiConnectionActionConfiguration> CreateProcessResponse(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<CreateProcessResponseInput>> body = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateProcessResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/response", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProcessResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RestoreProcessSectionResponse, ApiConnectionActionConfiguration> RestoreProcessSection(Expression<Func<string>> processId, Expression<Func<string>> processSectionId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            return new DeferredBodyAction<RestoreProcessSectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}/restore", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RestoreProcessSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<PreviewTableRowInViewResponse, ApiConnectionActionConfiguration> PreviewTableRowInView(Expression<Func<string>> viewId, Expression<Func<PreviewTableRowInViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PreviewTableRowInViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/preview-row", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PreviewTableRowInViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> StreamTableViewRows(Expression<Func<string>> viewId, Expression<Func<string>> filter = null, Expression<Func<string>> sort = null, Expression<Func<string>> processId = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/rows-stream", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_processId != null)
                    callPayload.Queries["process_id"] = ExpressionConverter.Convert(__workflow_processId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(50);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateColumnOnTableViewResponse, ApiConnectionActionConfiguration> UpdateColumnOnTableView(Expression<Func<string>> viewId, Expression<Func<string>> columnId, Expression<Func<UpdateColumnOnTableViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateColumnOnTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/columns/{1}", __workflow_viewId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateColumnOnTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<SetTableViewAsDefaultResponse, ApiConnectionActionConfiguration> SetTableViewAsDefault(Expression<Func<string>> viewId)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            return new DeferredBodyAction<SetTableViewAsDefaultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/default", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SetTableViewAsDefaultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<AddColumnToTableViewResponse, ApiConnectionActionConfiguration> AddColumnToTableView(Expression<Func<string>> viewId, Expression<Func<AddColumnToTableViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddColumnToTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/columns", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddColumnToTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableViewStatsResponse, ApiConnectionActionConfiguration> GetTableViewStats(Expression<Func<string>> viewId, Expression<Func<string>> filter = null, Expression<Func<string[]>> sumAvgMaxMinCount = null, Expression<Func<string>> processId = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_sumAvgMaxMinCount = WorkflowExpression.Compile(sumAvgMaxMinCount, nameof(sumAvgMaxMinCount), required: false);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: false);
            return new DeferredBodyAction<GetTableViewStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/stats", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_sumAvgMaxMinCount != null)
                    callPayload.Queries["sum, avg, max, min, count"] = ExpressionConverter.Convert(__workflow_sumAvgMaxMinCount);
                if (__workflow_processId != null)
                    callPayload.Queries["process_id"] = ExpressionConverter.Convert(__workflow_processId);
                return new ApiConnectionAction<GetTableViewStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateDocumentTableCellsInViewResponse, ApiConnectionActionConfiguration> UpdateDocumentTableCellsInView(Expression<Func<string>> viewId, Expression<Func<UpdateDocumentTableCellsInViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateDocumentTableCellsInViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/cells", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateDocumentTableCellsInViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableViewChartDataResponse, ApiConnectionActionConfiguration> GetTableViewChartData(Expression<Func<string>> viewId, Expression<Func<string>> chartType = null, Expression<Func<bool>> showLegend = null, Expression<Func<bool>> showValues = null, Expression<Func<string>> columnValueId = null, Expression<Func<string>> columnLabelId = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_chartType = WorkflowExpression.Compile(chartType, nameof(chartType), required: false);
            var __workflow_showLegend = WorkflowExpression.Compile(showLegend, nameof(showLegend), required: false);
            var __workflow_showValues = WorkflowExpression.Compile(showValues, nameof(showValues), required: false);
            var __workflow_columnValueId = WorkflowExpression.Compile(columnValueId, nameof(columnValueId), required: false);
            var __workflow_columnLabelId = WorkflowExpression.Compile(columnLabelId, nameof(columnLabelId), required: false);
            return new DeferredBodyAction<GetTableViewChartDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/chart", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_chartType != null)
                    callPayload.Queries["chart_type"] = ExpressionConverter.Convert(__workflow_chartType);
                if (__workflow_showLegend != null)
                    callPayload.Queries["show_legend"] = ExpressionConverter.Convert(__workflow_showLegend);
                if (__workflow_showValues != null)
                    callPayload.Queries["show_values"] = ExpressionConverter.Convert(__workflow_showValues);
                if (__workflow_columnValueId != null)
                    callPayload.Queries["column_value_id"] = ExpressionConverter.Convert(__workflow_columnValueId);
                if (__workflow_columnLabelId != null)
                    callPayload.Queries["column_label_id"] = ExpressionConverter.Convert(__workflow_columnLabelId);
                return new ApiConnectionAction<GetTableViewChartDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableViewRowsResponse, ApiConnectionActionConfiguration> GetTableViewRows(Expression<Func<string>> viewId, Expression<Func<string>> filter = null, Expression<Func<string>> sort = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<GetTableViewRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/rows", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<GetTableViewRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTableRowsInViewResponse, ApiConnectionActionConfiguration> DeleteTableRowsInView(Expression<Func<string>> viewId)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            return new DeferredBodyAction<DeleteTableRowsInViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/rows", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTableRowsInViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<InsertTableRowsInViewResponse, ApiConnectionActionConfiguration> InsertTableRowsInView(Expression<Func<string>> viewId, Expression<Func<InsertTableRowsInViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InsertTableRowsInViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/rows", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InsertTableRowsInViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableRowsInViewResponse, ApiConnectionActionConfiguration> UpdateTableRowsInView(Expression<Func<string>> viewId, Expression<Func<UpdateTableRowsInViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableRowsInViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/rows", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableRowsInViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadTableViewCSV(Expression<Func<string>> viewId, Expression<Func<string>> filter = null, Expression<Func<string>> sort = null, Expression<Func<string>> processId = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}/csv", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_processId != null)
                    callPayload.Queries["process_id"] = ExpressionConverter.Convert(__workflow_processId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetDistinctValuesForColumnResponse, ApiConnectionActionConfiguration> GetDistinctValuesForColumn(Expression<Func<string>> tableId, Expression<Func<string>> columnId, Expression<Func<string>> filter = null, Expression<Func<string[]>> groupColumns = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_groupColumns = WorkflowExpression.Compile(groupColumns, nameof(groupColumns), required: false);
            return new DeferredBodyAction<GetDistinctValuesForColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/column/{1}/distinct", __workflow_tableId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_groupColumns != null)
                    callPayload.Queries["group_columns"] = ExpressionConverter.Convert(__workflow_groupColumns);
                return new ApiConnectionAction<GetDistinctValuesForColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RestoreTableColumnResponse, ApiConnectionActionConfiguration> RestoreTableColumn(Expression<Func<string>> tableId, Expression<Func<string>> columnId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            return new DeferredBodyAction<RestoreTableColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/column/{1}/restore", __workflow_tableId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RestoreTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CheckColumnInViewsResponse, ApiConnectionActionConfiguration> CheckColumnInViews(Expression<Func<string>> tableId, Expression<Func<string>> columnId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            return new DeferredBodyAction<CheckColumnInViewsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/column/{1}/views", __workflow_tableId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CheckColumnInViewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DuplicateDefaultTableViewResponse, ApiConnectionActionConfiguration> DuplicateDefaultTableView(Expression<Func<string>> tableId, Expression<Func<DuplicateDefaultTableViewInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DuplicateDefaultTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/views/duplicate-default", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DuplicateDefaultTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DuplicateTableViewResponse, ApiConnectionActionConfiguration> DuplicateTableView(Expression<Func<string>> tableId, Expression<Func<string>> viewId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            return new DeferredBodyAction<DuplicateTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/views/{1}/duplicate", __workflow_tableId.WithUrlEncoding(1), __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DuplicateTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpsertTableRowsResponse, ApiConnectionActionConfiguration> UpsertTableRows(Expression<Func<string>> tableId, Expression<Func<UpsertTableRowsInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpsertTableRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/row/upsert", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpsertTableRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ChangeUserFavouriteResponse, ApiConnectionActionConfiguration> ChangeUserFavourite(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ChangeUserFavouriteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/projects/{0}/favourite", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChangeUserFavouriteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ChangeUserPinResponse, ApiConnectionActionConfiguration> ChangeUserPin(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ChangeUserPinResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/projects/{0}/pin", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChangeUserPinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteCommentResponse, ApiConnectionActionConfiguration> DeleteComment(Expression<Func<string>> commentThreadId, Expression<Func<string>> commentId)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredBodyAction<DeleteCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}/comment/{1}", __workflow_commentThreadId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateCommentResponse, ApiConnectionActionConfiguration> UpdateComment(Expression<Func<string>> commentThreadId, Expression<Func<string>> commentId, Expression<Func<UpdateCommentInput>> body)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}/comment/{1}", __workflow_commentThreadId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ResolveCommentThreadResponse, ApiConnectionActionConfiguration> ResolveCommentThread(Expression<Func<string>> commentThreadId)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            return new DeferredBodyAction<ResolveCommentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}/resolve", __workflow_commentThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResolveCommentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateCommentResponse, ApiConnectionActionConfiguration> CreateComment(Expression<Func<string>> commentThreadId, Expression<Func<CreateCommentInput>> body)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}/comment", __workflow_commentThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ReopenCommentThreadResponse, ApiConnectionActionConfiguration> ReopenCommentThread(Expression<Func<string>> commentThreadId)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            return new DeferredBodyAction<ReopenCommentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}/reopen", __workflow_commentThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ReopenCommentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetEventsResponse, ApiConnectionActionConfiguration> GetEvents(Expression<Func<string>> resourceId, Expression<Func<typeInput>> type, Expression<Func<int>> page = null, Expression<Func<string>> user = null, Expression<Func<string[]>> verb = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> search = null)
        {
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_verb = WorkflowExpression.Compile(verb, nameof(verb), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<GetEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/notifications/events/{0}", __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_user != null)
                    callPayload.Queries["user"] = ExpressionConverter.Convert(__workflow_user);
                if (__workflow_verb != null)
                    callPayload.Queries["verb"] = ExpressionConverter.Convert(__workflow_verb);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<GetEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RequestResourcePermissions(Expression<Func<string>> projectId, Expression<Func<typeInput>> type, Expression<Func<string>> id)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/permissions/request/{0}/{1}/{2}", __workflow_projectId.WithUrlEncoding(1), __workflow_type.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateMultipleProcessSectionsResponse, ApiConnectionActionConfiguration> UpdateMultipleProcessSections(Expression<Func<string>> processId, Expression<Func<UpdateMultipleProcessSectionsInput>> body = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateMultipleProcessSectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/update-multiple-section", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMultipleProcessSectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProjectHeadingStylingResponse, ApiConnectionActionConfiguration> CreateProjectHeadingStyling(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<CreateProjectHeadingStylingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/add_heading_styling", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateProjectHeadingStylingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectSentNotificationsResponse, ApiConnectionActionConfiguration> GetProjectSentNotifications(Expression<Func<string>> projectId, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> notificationId = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_notificationId = WorkflowExpression.Compile(notificationId, nameof(notificationId), required: false);
            return new DeferredBodyAction<GetProjectSentNotificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/sent-notifications", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(50);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_notificationId != null)
                    callPayload.Queries["notification_id"] = ExpressionConverter.Convert(__workflow_notificationId);
                return new ApiConnectionAction<GetProjectSentNotificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProcessSectionOrderResponse, ApiConnectionActionConfiguration> UpdateProcessSectionOrder(Expression<Func<string>> processId, Expression<Func<UpdateProcessSectionOrderInput>> body = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateProcessSectionOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/changesectionorder", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProcessSectionOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectDeletedProcessesResponse, ApiConnectionActionConfiguration> GetProjectDeletedProcesses(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectDeletedProcessesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/deletedprocesses", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectDeletedProcessesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTopProjectHeadingStylingResponse, ApiConnectionActionConfiguration> DeleteTopProjectHeadingStyling(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<DeleteTopProjectHeadingStylingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/delete_top_style", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTopProjectHeadingStylingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProcessRespondersResponse, ApiConnectionActionConfiguration> UpdateProcessResponders(Expression<Func<string>> processId, Expression<Func<UpdateProcessRespondersInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProcessRespondersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/setallresponders", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProcessRespondersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateMultipleProcessSectionsResponse, ApiConnectionActionConfiguration> CreateMultipleProcessSections(Expression<Func<string>> processId, Expression<Func<CreateMultipleProcessSectionsInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateMultipleProcessSectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/multiple-section", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateMultipleProcessSectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<InviteMultipleUsersToProjectResponse, ApiConnectionActionConfiguration> InviteMultipleUsersToProject(Expression<Func<string>> projectId, Expression<Func<InviteMultipleUsersToProjectInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InviteMultipleUsersToProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/invite-multiple", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InviteMultipleUsersToProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<MortaProcessSection[], ApiConnectionActionConfiguration> GetDeletedProcessSections(Expression<Func<string>> processId, Expression<Func<string>> processSectionId = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: false);
            return new DeferredBodyAction<MortaProcessSection[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/deletedsections", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_processSectionId != null)
                    callPayload.Queries["process_section_id"] = ExpressionConverter.Convert(__workflow_processSectionId);
                return new ApiConnectionAction<MortaProcessSection[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ChangeUserRoleOnProjectResponse, ApiConnectionActionConfiguration> ChangeUserRoleOnProject(Expression<Func<string>> projectId, Expression<Func<string>> firebaseId, Expression<Func<ChangeUserRoleOnProjectInput>> body = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ChangeUserRoleOnProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/changeuserrole/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChangeUserRoleOnProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetInvitedProjectMembersResponse, ApiConnectionActionConfiguration> GetInvitedProjectMembers(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetInvitedProjectMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/invitedmembers", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInvitedProjectMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectDeletedTablesResponse, ApiConnectionActionConfiguration> GetProjectDeletedTables(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectDeletedTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/deletedtables", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectDeletedTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectNotificationsResponse, ApiConnectionActionConfiguration> GetProjectNotifications(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectNotificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/notifications", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectNotificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RemoveUserFromProjectResponse, ApiConnectionActionConfiguration> RemoveUserFromProject(Expression<Func<string>> projectId, Expression<Func<string>> firebaseId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            return new DeferredBodyAction<RemoveUserFromProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/removeuser/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RemoveUserFromProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectResourcesResponse, ApiConnectionActionConfiguration> GetProjectResources(Expression<Func<string>> projectId, Expression<Func<GetProjectResourcesInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetProjectResourcesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/resources", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetProjectResourcesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectProcessesResponse, ApiConnectionActionConfiguration> GetProjectProcesses(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectProcessesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/processes", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectProcessesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectVariablesResponse, ApiConnectionActionConfiguration> GetProjectVariables(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectVariablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/variables", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectVariablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DuplicateProject(Expression<Func<string>> projectId, Expression<Func<DuplicateProjectInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/duplicate", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DuplicateProcessAsync(Expression<Func<string>> processId, Expression<Func<DuplicateProcessAsyncInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/duplicate", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProcessSectionsResponse, ApiConnectionActionConfiguration> CreateProcessSections(Expression<Func<string>> processId, Expression<Func<CreateProcessSectionsInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProcessSectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/sections", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProcessSectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteProjectSecretResponse, ApiConnectionActionConfiguration> DeleteProjectSecret(Expression<Func<string>> projectId, Expression<Func<string>> secretId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_secretId = WorkflowExpression.Compile(secretId, nameof(secretId), required: true);
            return new DeferredBodyAction<DeleteProjectSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/secrets/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_secretId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteProjectSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProjectSecretResponse, ApiConnectionActionConfiguration> UpdateProjectSecret(Expression<Func<string>> projectId, Expression<Func<string>> secretId, Expression<Func<UpdateProjectSecretInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_secretId = WorkflowExpression.Compile(secretId, nameof(secretId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProjectSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/secrets/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_secretId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProjectSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProcessSectionResponse, ApiConnectionActionConfiguration> GetProcessSection(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<bool>> mainParentSection = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_mainParentSection = WorkflowExpression.Compile(mainParentSection, nameof(mainParentSection), required: false);
            return new DeferredBodyAction<GetProcessSectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mainParentSection != null)
                    callPayload.Queries["main_parent_section"] = ExpressionConverter.Convert(__workflow_mainParentSection);
                return new ApiConnectionAction<GetProcessSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteProcessSectionResponse, ApiConnectionActionConfiguration> DeleteProcessSection(Expression<Func<string>> processId, Expression<Func<string>> processSectionId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            return new DeferredBodyAction<DeleteProcessSectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteProcessSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProcessSectionResponse, ApiConnectionActionConfiguration> UpdateProcessSection(Expression<Func<string>> processId, Expression<Func<string>> processSectionId, Expression<Func<UpdateProcessSectionInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_processSectionId = WorkflowExpression.Compile(processSectionId, nameof(processSectionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProcessSectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section/{1}", __workflow_processId.WithUrlEncoding(1), __workflow_processSectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProcessSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RestoreProjectResponse, ApiConnectionActionConfiguration> RestoreProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<RestoreProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/restore", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RestoreProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectSecretsResponse, ApiConnectionActionConfiguration> GetProjectSecrets(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectSecretsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/secrets", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectSecretsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProjectSecretResponse, ApiConnectionActionConfiguration> CreateProjectSecret(Expression<Func<string>> projectId, Expression<Func<CreateProjectSecretInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProjectSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/secrets", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectMembersResponse, ApiConnectionActionConfiguration> GetProjectMembers(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/members", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RestoreProcessResponse, ApiConnectionActionConfiguration> RestoreProcess(Expression<Func<string>> processId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            return new DeferredBodyAction<RestoreProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/restore", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RestoreProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateProcessSectionResponse, ApiConnectionActionConfiguration> CreateProcessSection(Expression<Func<string>> processId, Expression<Func<CreateProcessSectionInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProcessSectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/section", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProcessSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteProjectInviteResponse, ApiConnectionActionConfiguration> DeleteProjectInvite(Expression<Func<string>> projectId, Expression<Func<string>> inviteId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            return new DeferredBodyAction<DeleteProjectInviteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/invite/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteProjectInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<ResendInviteToUserForProjectResponse, ApiConnectionActionConfiguration> ResendInviteToUserForProject(Expression<Func<string>> projectId, Expression<Func<string>> inviteId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            return new DeferredBodyAction<ResendInviteToUserForProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/invite/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResendInviteToUserForProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProjectInviteResponse, ApiConnectionActionConfiguration> UpdateProjectInvite(Expression<Func<string>> projectId, Expression<Func<string>> inviteId, Expression<Func<UpdateProjectInviteInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProjectInviteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/invite/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProjectInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<SearchProjectResponse, ApiConnectionActionConfiguration> SearchProject(Expression<Func<string>> projectId, Expression<Func<string>> search, Expression<Func<string>> processPublicId = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: true);
            var __workflow_processPublicId = WorkflowExpression.Compile(processPublicId, nameof(processPublicId), required: false);
            return new DeferredBodyAction<SearchProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/search", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_processPublicId != null)
                    callPayload.Queries["process_public_id"] = ExpressionConverter.Convert(__workflow_processPublicId);
                return new ApiConnectionAction<SearchProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectTablesResponse, ApiConnectionActionConfiguration> GetProjectTables(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/tables", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<InviteUserToProjectResponse, ApiConnectionActionConfiguration> InviteUserToProject(Expression<Func<string>> projectId, Expression<Func<InviteUserToProjectInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InviteUserToProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/invite", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InviteUserToProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportProcess(Expression<Func<string>> processId, Expression<Func<exportFormatInput>> exportFormat = null, Expression<Func<bool>> tableLinks = null, Expression<Func<bool>> description = null, Expression<Func<pageFormatInput>> pageFormat = null, Expression<Func<pageOrientationInput>> pageOrientation = null, Expression<Func<fontTypeInput>> fontType = null, Expression<Func<int>> fontSize = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_exportFormat = WorkflowExpression.Compile(exportFormat, nameof(exportFormat), required: false);
            var __workflow_tableLinks = WorkflowExpression.Compile(tableLinks, nameof(tableLinks), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_pageFormat = WorkflowExpression.Compile(pageFormat, nameof(pageFormat), required: false);
            var __workflow_pageOrientation = WorkflowExpression.Compile(pageOrientation, nameof(pageOrientation), required: false);
            var __workflow_fontType = WorkflowExpression.Compile(fontType, nameof(fontType), required: false);
            var __workflow_fontSize = WorkflowExpression.Compile(fontSize, nameof(fontSize), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}/export", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_exportFormat != null)
                    callPayload.Queries["export_format"] = ExpressionConverter.Convert(__workflow_exportFormat);
                if (__workflow_tableLinks != null)
                    callPayload.Queries["table_links"] = ExpressionConverter.Convert(__workflow_tableLinks);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_pageFormat != null)
                    callPayload.Queries["page_format"] = ExpressionConverter.Convert(__workflow_pageFormat);
                if (__workflow_pageOrientation != null)
                    callPayload.Queries["page_orientation"] = ExpressionConverter.Convert(__workflow_pageOrientation);
                if (__workflow_fontType != null)
                    callPayload.Queries["font_type"] = ExpressionConverter.Convert(__workflow_fontType);
                if (__workflow_fontSize != null)
                    callPayload.Queries["font_size"] = ExpressionConverter.Convert(__workflow_fontSize);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProjectHeadingStylingResponse, ApiConnectionActionConfiguration> UpdateProjectHeadingStyling(Expression<Func<string>> projectId, Expression<Func<string>> styleId, Expression<Func<UpdateProjectHeadingStylingInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_styleId = WorkflowExpression.Compile(styleId, nameof(styleId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProjectHeadingStylingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/style/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_styleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProjectHeadingStylingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectTagsResponse, ApiConnectionActionConfiguration> GetProjectTags(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}/tags", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableViewResponse, ApiConnectionActionConfiguration> GetTableView(Expression<Func<string>> viewId, Expression<Func<bool>> ignoreCachedOptions = null)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_ignoreCachedOptions = WorkflowExpression.Compile(ignoreCachedOptions, nameof(ignoreCachedOptions), required: false);
            return new DeferredBodyAction<GetTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ignoreCachedOptions != null)
                    callPayload.Queries["ignore_cached_options"] = ExpressionConverter.Convert(__workflow_ignoreCachedOptions);
                return new ApiConnectionAction<GetTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTableViewResponse, ApiConnectionActionConfiguration> DeleteTableView(Expression<Func<string>> viewId)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            return new DeferredBodyAction<DeleteTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableViewResponse, ApiConnectionActionConfiguration> UpdateTableView(Expression<Func<string>> viewId, Expression<Func<UpdateTableViewInput>> body)
        {
            var __workflow_viewId = WorkflowExpression.Compile(viewId, nameof(viewId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/views/{0}", __workflow_viewId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> StreamTableRows(Expression<Func<string>> tableId, Expression<Func<string>> filter = null, Expression<Func<string>> sort = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/rows-stream", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(50);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DuplicateTableResponse, ApiConnectionActionConfiguration> DuplicateTable(Expression<Func<string>> tableId, Expression<Func<DuplicateTableInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DuplicateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/duplicate", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DuplicateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<TruncateTableResponse, ApiConnectionActionConfiguration> TruncateTable(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<TruncateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/truncate", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TruncateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<RestoreTableResponse, ApiConnectionActionConfiguration> RestoreTable(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<RestoreTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/restore", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RestoreTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableColumnsResponse, ApiConnectionActionConfiguration> GetTableColumns(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<GetTableColumnsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/columns", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTableColumnsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateTableIndexesResponse, ApiConnectionActionConfiguration> CreateTableIndexes(Expression<Func<string>> tableId, Expression<Func<CreateTableIndexesInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTableIndexesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/indexes", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTableIndexesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTableColumnResponse, ApiConnectionActionConfiguration> DeleteTableColumn(Expression<Func<string>> tableId, Expression<Func<string>> columnId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            return new DeferredBodyAction<DeleteTableColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/column/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableColumnResponse, ApiConnectionActionConfiguration> UpdateTableColumn(Expression<Func<string>> tableId, Expression<Func<string>> columnId, Expression<Func<UpdateTableColumnInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/column/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateTableColumnResponse, ApiConnectionActionConfiguration> CreateTableColumn(Expression<Func<string>> tableId, Expression<Func<CreateTableColumnInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTableColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/column", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTableColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableColumnStatsResponse, ApiConnectionActionConfiguration> GetTableColumnStats(Expression<Func<string>> tableId, Expression<Func<string>> aggregation = null, Expression<Func<string>> filter = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_aggregation = WorkflowExpression.Compile(aggregation, nameof(aggregation), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetTableColumnStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/stats", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_aggregation != null)
                    callPayload.Queries["aggregation"] = ExpressionConverter.Convert(__workflow_aggregation);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetTableColumnStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableCellsResponse, ApiConnectionActionConfiguration> UpdateTableCells(Expression<Func<string>> tableId, Expression<Func<UpdateTableCellsInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/cells", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableJoinsResponse, ApiConnectionActionConfiguration> GetTableJoins(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<GetTableJoinsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/joins", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTableJoinsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableViewsResponse, ApiConnectionActionConfiguration> GetTableViews(Expression<Func<string>> tableId, Expression<Func<bool>> ignoreColumns = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_ignoreColumns = WorkflowExpression.Compile(ignoreColumns, nameof(ignoreColumns), required: false);
            return new DeferredBodyAction<GetTableViewsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/views", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ignoreColumns != null)
                    callPayload.Queries["ignore_columns"] = ExpressionConverter.Convert(__workflow_ignoreColumns);
                return new ApiConnectionAction<GetTableViewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateTableViewResponse, ApiConnectionActionConfiguration> CreateTableView(Expression<Func<string>> tableId, Expression<Func<CreateTableViewInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTableViewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/views", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTableViewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTableJoinResponse, ApiConnectionActionConfiguration> DeleteTableJoin(Expression<Func<string>> tableId, Expression<Func<string>> joinId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_joinId = WorkflowExpression.Compile(joinId, nameof(joinId), required: true);
            return new DeferredBodyAction<DeleteTableJoinResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/join/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_joinId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTableJoinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableJoinResponse, ApiConnectionActionConfiguration> UpdateTableJoin(Expression<Func<string>> tableId, Expression<Func<string>> joinId, Expression<Func<UpdateTableJoinInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_joinId = WorkflowExpression.Compile(joinId, nameof(joinId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableJoinResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/join/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_joinId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableJoinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteIntegrationFromTableResponse, ApiConnectionActionConfiguration> DeleteIntegrationFromTable(Expression<Func<string>> tableId, Expression<Func<string>> integrationName)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_integrationName = WorkflowExpression.Compile(integrationName, nameof(integrationName), required: true);
            return new DeferredBodyAction<DeleteIntegrationFromTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/sync/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_integrationName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteIntegrationFromTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<SyncTableWithIntegrationResponse, ApiConnectionActionConfiguration> SyncTableWithIntegration(Expression<Func<string>> tableId, Expression<Func<string>> integrationName, Expression<Func<SyncTableWithIntegrationInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_integrationName = WorkflowExpression.Compile(integrationName, nameof(integrationName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SyncTableWithIntegrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/sync/{1}", __workflow_tableId.WithUrlEncoding(1), __workflow_integrationName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SyncTableWithIntegrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetWhereTableUsedResponse, ApiConnectionActionConfiguration> GetWhereTableUsed(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<GetWhereTableUsedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/used", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWhereTableUsedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFileForTableCell(Expression<Func<string>> tableId, Expression<Func<string>> columnId, Expression<Func<string>> filename)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/file", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["column_id"] = ExpressionConverter.Convert(__workflow_columnId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTableRowsResponse, ApiConnectionActionConfiguration> DeleteTableRows(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<DeleteTableRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/rows", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTableRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateTableJoinResponse, ApiConnectionActionConfiguration> CreateTableJoin(Expression<Func<string>> tableId, Expression<Func<CreateTableJoinInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTableJoinResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/join", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTableJoinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableRowsResponse, ApiConnectionActionConfiguration> GetTableRows(Expression<Func<string>> tableId, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<string>> lastUpdatedAt = null, Expression<Func<string>> lastCreatedAt = null, Expression<Func<string>> nextPageToken = null, Expression<Func<string[]>> columns = null, Expression<Func<string[]>> distinctColumns = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_lastUpdatedAt = WorkflowExpression.Compile(lastUpdatedAt, nameof(lastUpdatedAt), required: false);
            var __workflow_lastCreatedAt = WorkflowExpression.Compile(lastCreatedAt, nameof(lastCreatedAt), required: false);
            var __workflow_nextPageToken = WorkflowExpression.Compile(nextPageToken, nameof(nextPageToken), required: false);
            var __workflow_columns = WorkflowExpression.Compile(columns, nameof(columns), required: false);
            var __workflow_distinctColumns = WorkflowExpression.Compile(distinctColumns, nameof(distinctColumns), required: false);
            return new DeferredBodyAction<GetTableRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/row", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(50);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_lastUpdatedAt != null)
                    callPayload.Queries["last_updated_at"] = ExpressionConverter.Convert(__workflow_lastUpdatedAt);
                if (__workflow_lastCreatedAt != null)
                    callPayload.Queries["last_created_at"] = ExpressionConverter.Convert(__workflow_lastCreatedAt);
                if (__workflow_nextPageToken != null)
                    callPayload.Queries["next_page_token"] = ExpressionConverter.Convert(__workflow_nextPageToken);
                if (__workflow_columns != null)
                    callPayload.Queries["columns"] = ExpressionConverter.Convert(__workflow_columns);
                if (__workflow_distinctColumns != null)
                    callPayload.Queries["distinct_columns"] = ExpressionConverter.Convert(__workflow_distinctColumns);
                return new ApiConnectionAction<GetTableRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<CreateTableRowsResponse, ApiConnectionActionConfiguration> CreateTableRows(Expression<Func<string>> tableId, Expression<Func<CreateTableRowsInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTableRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/row", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTableRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableRowsResponse, ApiConnectionActionConfiguration> UpdateTableRows(Expression<Func<string>> tableId, Expression<Func<UpdateTableRowsInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/row", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadTableAsCSV(Expression<Func<string>> tableId, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}/csv", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserByPublicIdResponse, ApiConnectionActionConfiguration> GetUserByPublicId(Expression<Func<string>> publicId)
        {
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            return new DeferredBodyAction<GetUserByPublicIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/public/{0}", __workflow_publicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserByPublicIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteApiKeyResponse, ApiConnectionActionConfiguration> DeleteApiKey(Expression<Func<string>> apiKeyId)
        {
            var __workflow_apiKeyId = WorkflowExpression.Compile(apiKeyId, nameof(apiKeyId), required: true);
            return new DeferredBodyAction<DeleteApiKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/apikey/{0}", __workflow_apiKeyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteApiKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateApiKeyResponse, ApiConnectionActionConfiguration> UpdateApiKey(Expression<Func<string>> apiKeyId, Expression<Func<UpdateApiKeyInput>> body)
        {
            var __workflow_apiKeyId = WorkflowExpression.Compile(apiKeyId, nameof(apiKeyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateApiKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/apikey/{0}", __workflow_apiKeyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateApiKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserPublicContributionsResponse, ApiConnectionActionConfiguration> GetUserPublicContributions(Expression<Func<string>> firebaseId)
        {
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            return new DeferredBodyAction<GetUserPublicContributionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}/public-contributions", __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserPublicContributionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserPinnedProjectsResponse, ApiConnectionActionConfiguration> GetUserPinnedProjects(Expression<Func<string>> firebaseId)
        {
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            return new DeferredBodyAction<GetUserPinnedProjectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}/pinned-projects", __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserPinnedProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserContributionsResponse, ApiConnectionActionConfiguration> GetUserContributions(Expression<Func<string>> firebaseId)
        {
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            return new DeferredBodyAction<GetUserContributionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}/contributions", __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserContributionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserAchievementsResponse, ApiConnectionActionConfiguration> GetUserAchievements(Expression<Func<string>> firebaseId)
        {
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            return new DeferredBodyAction<GetUserAchievementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}/achievements", __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserAchievementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UserDeleteTagResponse, ApiConnectionActionConfiguration> UserDeleteTag(Expression<Func<string>> userId, Expression<Func<string>> tagId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<UserDeleteTagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}/tags/{1}", __workflow_userId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDeleteTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UserAddTagResponse, ApiConnectionActionConfiguration> UserAddTag(Expression<Func<string>> userId, Expression<Func<UserAddTagInput>> body)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserAddTagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}/tags", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserAddTagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetCommentThreadResponse, ApiConnectionActionConfiguration> GetCommentThread(Expression<Func<string>> commentThreadId)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            return new DeferredBodyAction<GetCommentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}", __workflow_commentThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCommentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteCommentThreadResponse, ApiConnectionActionConfiguration> DeleteCommentThread(Expression<Func<string>> commentThreadId)
        {
            var __workflow_commentThreadId = WorkflowExpression.Compile(commentThreadId, nameof(commentThreadId), required: true);
            return new DeferredBodyAction<DeleteCommentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/comment_thread/{0}", __workflow_commentThreadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteCommentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteNotificationResponse, ApiConnectionActionConfiguration> DeleteNotification(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteNotificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/notifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateNotificationResponse, ApiConnectionActionConfiguration> UpdateNotification(Expression<Func<string>> id, Expression<Func<UpdateNotificationInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateNotificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/notifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteResourcePermissions(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/permissions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateResourcePermissionsResponse, ApiConnectionActionConfiguration> UpdateResourcePermissions(Expression<Func<string>> id, Expression<Func<UpdateResourcePermissionsInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateResourcePermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/permissions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateResourcePermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProjectResponse, ApiConnectionActionConfiguration> GetProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteProjectResponse, ApiConnectionActionConfiguration> DeleteProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<DeleteProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProjectResponse, ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> projectId, Expression<Func<UpdateProjectInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/project/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetProcessResponse, ApiConnectionActionConfiguration> GetProcess(Expression<Func<string>> processId, Expression<Func<bool>> excludeChildren = null)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_excludeChildren = WorkflowExpression.Compile(excludeChildren, nameof(excludeChildren), required: false);
            return new DeferredBodyAction<GetProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_excludeChildren != null)
                    callPayload.Queries["exclude_children"] = ExpressionConverter.Convert(__workflow_excludeChildren);
                return new ApiConnectionAction<GetProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteProcessResponse, ApiConnectionActionConfiguration> DeleteProcess(Expression<Func<string>> processId)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            return new DeferredBodyAction<DeleteProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateProcessResponse, ApiConnectionActionConfiguration> UpdateProcess(Expression<Func<string>> processId, Expression<Func<UpdateProcessInput>> body)
        {
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/process/{0}", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetTableResponse, ApiConnectionActionConfiguration> GetTable(Expression<Func<string>> tableId, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<string>> lastUpdatedAt = null, Expression<Func<string>> lastCreatedAt = null, Expression<Func<string>> nextPageToken = null, Expression<Func<string[]>> columns = null, Expression<Func<string[]>> distinctColumns = null)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_lastUpdatedAt = WorkflowExpression.Compile(lastUpdatedAt, nameof(lastUpdatedAt), required: false);
            var __workflow_lastCreatedAt = WorkflowExpression.Compile(lastCreatedAt, nameof(lastCreatedAt), required: false);
            var __workflow_nextPageToken = WorkflowExpression.Compile(nextPageToken, nameof(nextPageToken), required: false);
            var __workflow_columns = WorkflowExpression.Compile(columns, nameof(columns), required: false);
            var __workflow_distinctColumns = WorkflowExpression.Compile(distinctColumns, nameof(distinctColumns), required: false);
            return new DeferredBodyAction<GetTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(50);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_lastUpdatedAt != null)
                    callPayload.Queries["last_updated_at"] = ExpressionConverter.Convert(__workflow_lastUpdatedAt);
                if (__workflow_lastCreatedAt != null)
                    callPayload.Queries["last_created_at"] = ExpressionConverter.Convert(__workflow_lastCreatedAt);
                if (__workflow_nextPageToken != null)
                    callPayload.Queries["next_page_token"] = ExpressionConverter.Convert(__workflow_nextPageToken);
                if (__workflow_columns != null)
                    callPayload.Queries["columns"] = ExpressionConverter.Convert(__workflow_columns);
                if (__workflow_distinctColumns != null)
                    callPayload.Queries["distinct_columns"] = ExpressionConverter.Convert(__workflow_distinctColumns);
                return new ApiConnectionAction<GetTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<DeleteTableResponse, ApiConnectionActionConfiguration> DeleteTable(Expression<Func<string>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<DeleteTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<UpdateTableResponse, ApiConnectionActionConfiguration> UpdateTable(Expression<Func<string>> tableId, Expression<Func<UpdateTableInput>> body)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/table/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "morta")]
        public IBodyWorkflowAction<GetUserResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> firebaseId)
        {
            var __workflow_firebaseId = WorkflowExpression.Compile(firebaseId, nameof(firebaseId), required: true);
            return new DeferredBodyAction<GetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/user/{0}", __workflow_firebaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }
    }

    public class MortaTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetFavouriteProjectsResponse
    {
        [JsonProperty("data")]
        public GetFavouriteProjectsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetFavouriteProjectsResponseDataTypeItem
    {
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class GetCommentThreadStatsByReferenceResponse
    {
        [JsonProperty("data")]
        public CommentThreadStats[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CommentThreadStats
    {
        [JsonProperty("openCommentThreads")]
        public int OpenCommentThreads { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("resolvedCommentThreads")]
        public int ResolvedCommentThreads { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referenceTypeInput
    {
        [EnumMember(Value = "process_section")]
        ProcessSection,
        [EnumMember(Value = "table")]
        Table,
        [EnumMember(Value = "table_view")]
        TableView
    }

    public class GetNotificationEventTypesResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class IntegrationsPassthroughDownloadApiCallInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; } = null;

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public IntegrationsPassthroughDownloadApiCallInputMethodType Method { get; set; }

        [JsonProperty("onBehalfUserId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OnBehalfUserId { get; set; } = null;

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("sourceSystem", DefaultValueHandling = DefaultValueHandling.Include)]
        public IntegrationsPassthroughDownloadApiCallInputSourceSystemType SourceSystem { get; set; }
    }

    public class BaseRequestContext
    {
        [JsonProperty("processPublicId")]
        public string ProcessPublicId { get; set; }

        [JsonProperty("processResponsePublicId")]
        public string ProcessResponsePublicId { get; set; }

        [JsonProperty("processSectionPublicId")]
        public string ProcessSectionPublicId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IntegrationsPassthroughDownloadApiCallInputMethodType
    {
        GET,
        PUT,
        POST,
        DELETE,
        PATCH
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IntegrationsPassthroughDownloadApiCallInputSourceSystemType
    {
        [EnumMember(Value = "viewpoint")]
        Viewpoint,
        [EnumMember(Value = "aconex")]
        Aconex,
        [EnumMember(Value = "autodesk-bim360")]
        AutodeskBim360,
        [EnumMember(Value = "procore")]
        Procore,
        [EnumMember(Value = "revizto")]
        Revizto,
        [EnumMember(Value = "morta")]
        Morta
    }

    public class IntegrationsPassthroughApiCallResponse
    {
        [JsonProperty("data")]
        public IntegrationsPassthroughResponse Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class IntegrationsPassthroughResponse
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IntegrationsPassthroughApiCallInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; } = null;

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public IntegrationsPassthroughApiCallInputMethodType Method { get; set; }

        [JsonProperty("onBehalfUserId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OnBehalfUserId { get; set; } = null;

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("sourceSystem", DefaultValueHandling = DefaultValueHandling.Include)]
        public IntegrationsPassthroughApiCallInputSourceSystemType SourceSystem { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IntegrationsPassthroughApiCallInputMethodType
    {
        GET,
        PUT,
        POST,
        DELETE,
        PATCH
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IntegrationsPassthroughApiCallInputSourceSystemType
    {
        [EnumMember(Value = "viewpoint")]
        Viewpoint,
        [EnumMember(Value = "aconex")]
        Aconex,
        [EnumMember(Value = "autodesk-bim360")]
        AutodeskBim360,
        [EnumMember(Value = "procore")]
        Procore,
        [EnumMember(Value = "revizto")]
        Revizto,
        [EnumMember(Value = "morta")]
        Morta
    }

    public class GetTagByPublicIdResponse
    {
        [JsonProperty("data")]
        public Tag Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class Tag
    {
        [JsonProperty("documentTableId")]
        public string DocumentTableId { get; set; }

        [JsonProperty("projectPublicId")]
        public string ProjectPublicId { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("referencePublicId")]
        public string ReferencePublicId { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class DuplicateProcessResponse
    {
        [JsonProperty("data")]
        public MortaProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MortaProcess
    {
        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("allowDuplication")]
        public bool AllowDuplication { get; set; }

        [JsonProperty("children")]
        public ProcessSection1[] Children { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("expandByDefault")]
        public bool ExpandByDefault { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("templateCategory")]
        public string TemplateCategory { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("variableValues")]
        public string[] VariableValues { get; set; }

        [JsonProperty("variables")]
        public string[] Variables { get; set; }
    }

    public class ProcessSection1
    {
        [JsonProperty("children")]
        public ProcessSection1[] Children { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public Draftjs Description { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("openCommentThreads")]
        public int OpenCommentThreads { get; set; }

        [JsonProperty("pageBreakBefore")]
        public bool PageBreakBefore { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("pdfIncludeDescription")]
        public bool PdfIncludeDescription { get; set; }

        [JsonProperty("pdfIncludeSection")]
        public bool PdfIncludeSection { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("responses")]
        public ProcessResponse[] Responses { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class Draftjs
    {
        [JsonProperty("content")]
        public DraftjsContent Content { get; set; }
    }

    public class DraftjsContent
    {
        [JsonProperty("blocks")]
        public DraftjsBlock[] Blocks { get; set; }

        [JsonProperty("entityMap")]
        public JToken EntityMap { get; set; }
    }

    public class DraftjsBlock
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("entityRanges")]
        public JToken[] EntityRanges { get; set; }

        [JsonProperty("inlineStyleRanges")]
        public JToken[] InlineStyleRanges { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProcessResponse
    {
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("expireResponse")]
        public bool ExpireResponse { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("pdfIncludeResponse")]
        public bool PdfIncludeResponse { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("resetAfterResponse")]
        public bool ResetAfterResponse { get; set; }

        [JsonProperty("responders")]
        public string[] Responders { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }

        [JsonProperty("responseDate")]
        public string ResponseDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeOptions")]
        public JToken TypeOptions { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public SummaryUser User { get; set; }

        [JsonProperty("userResponders")]
        public SummaryUser[] UserResponders { get; set; }
    }

    public class SummaryUser
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firebaseUserId")]
        public string FirebaseUserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class DuplicateProcessInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("processId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; } = null;
    }

    public class GetUserPublicProjectsResponse
    {
        [JsonProperty("data")]
        public HomeProject[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class HomeProject
    {
        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("hideProcessCreated")]
        public bool HideProcessCreated { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("mfaRequired")]
        public bool MfaRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryColour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class GetUserOwnerProjectsResponse
    {
        [JsonProperty("data")]
        public HomeProject[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetUserTemplatesResponse
    {
        [JsonProperty("data")]
        public GetUserTemplatesResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetUserTemplatesResponseDataTypeItem
    {
        [JsonProperty("createdBy")]
        public SummaryUser CreatedBy { get; set; }
    }

    public class GetUserProjectsResponse
    {
        [JsonProperty("data")]
        public HomeProject[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateUserAccountResponse
    {
        [JsonProperty("data")]
        public UserWithToken Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UserWithToken
    {
        [JsonProperty("aconexConnected")]
        public bool AconexConnected { get; set; }

        [JsonProperty("apiKeys")]
        public ApiKey[] ApiKeys { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("autodeskConnected")]
        public bool AutodeskConnected { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("constructionSoftware")]
        public string[] ConstructionSoftware { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firebaseUserId")]
        public string FirebaseUserId { get; set; }

        [JsonProperty("hasPassword")]
        public JToken HasPassword { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is2FaEnabled")]
        public JToken Is2FaEnabled { get; set; }

        [JsonProperty("isSuperAdmin")]
        public bool IsSuperAdmin { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("lastLoginAt")]
        public string LastLoginAt { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("procoreConnected")]
        public bool ProcoreConnected { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("projectsWorkedOn")]
        public string[] ProjectsWorkedOn { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("reviztoConnected")]
        public bool ReviztoConnected { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("specialisms")]
        public string[] Specialisms { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("universityDegree")]
        public string UniversityDegree { get; set; }

        [JsonProperty("viewpointConnected")]
        public bool ViewpointConnected { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class ApiKey
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class UpdateUserAccountInput
    {
        [JsonProperty("oldPassword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OldPassword { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("passwordConfirm", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordConfirm { get; set; }

        [JsonProperty("twoFactorCode")]
        public string TwoFactorCode { get; set; }
    }

    public class CreateApiKeyResponse
    {
        [JsonProperty("data")]
        public ApiKey Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateApiKeyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SearchUsersResponse
    {
        [JsonProperty("data")]
        public SummaryUser[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetMeResponse
    {
        [JsonProperty("data")]
        public User Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class User
    {
        [JsonProperty("aconexConnected")]
        public bool AconexConnected { get; set; }

        [JsonProperty("apiKeys")]
        public ApiKey[] ApiKeys { get; set; }

        [JsonProperty("autodeskConnected")]
        public bool AutodeskConnected { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("constructionSoftware")]
        public string[] ConstructionSoftware { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firebaseUserId")]
        public string FirebaseUserId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("procoreConnected")]
        public bool ProcoreConnected { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("projectsWorkedOn")]
        public string[] ProjectsWorkedOn { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("reviztoConnected")]
        public bool ReviztoConnected { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("specialisms")]
        public string[] Specialisms { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("universityDegree")]
        public string UniversityDegree { get; set; }

        [JsonProperty("viewpointConnected")]
        public bool ViewpointConnected { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class GetCommentThreadsByReferenceResponse
    {
        [JsonProperty("data")]
        public CommentThread[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CommentThread
    {
        [JsonProperty("comments")]
        public Comment[] Comments { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("isCommentInitiator")]
        public JToken IsCommentInitiator { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("resolvedAt")]
        public string ResolvedAt { get; set; }

        [JsonProperty("resolver")]
        public User1 Resolver { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Comment
    {
        [JsonProperty("commentText")]
        public string CommentText { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("isOwner")]
        public JToken IsOwner { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public SummaryUser User { get; set; }
    }

    public class User1
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateCommentThreadResponse
    {
        [JsonProperty("data")]
        public CommentThread Data { get; set; }

        [JsonProperty("metadata")]
        public CreateCommentThreadResponseMetadataType Metadata { get; set; }
    }

    public class CreateCommentThreadResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class CreateCommentThreadInput
    {
        [JsonProperty("commentText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentText { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("mainReferenceId")]
        public string MainReferenceId { get; set; }

        [JsonProperty("referenceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceId { get; set; }

        [JsonProperty("referenceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceType { get; set; }
    }

    public class CreateNotificationResponse
    {
        [JsonProperty("data")]
        public Notification Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class Notification
    {
        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("processes")]
        public Process[] Processes { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("tables")]
        public Table1[] Tables { get; set; }

        [JsonProperty("triggers")]
        public Trigger[] Triggers { get; set; }

        [JsonProperty("user")]
        public SummaryUser User { get; set; }
    }

    public class Action
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookUrl { get; set; }
    }

    public class Process
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class Table1
    {
        [JsonProperty("defaultViewId")]
        public string DefaultViewId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class Trigger
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }
    }

    public class CreateNotificationInput
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("processes")]
        public string[] Processes { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("tables")]
        public string[] Tables { get; set; }

        [JsonProperty("triggers", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTrigger[] Triggers { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebhookUrl { get; set; }
    }

    public class CreateTrigger
    {
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }
    }

    public class GetResourcePermissionsResponse
    {
        [JsonProperty("data")]
        public AccessPolicy[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class AccessPolicy
    {
        [JsonProperty("accessAttribute")]
        public AccessAttribute AccessAttribute { get; set; }

        [JsonProperty("accessResource")]
        public AccessResource AccessResource { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("role")]
        public int Role { get; set; }

        [JsonProperty("roleLabel")]
        public string RoleLabel { get; set; }
    }

    public class AccessAttribute
    {
        [JsonProperty("documentTable")]
        public Table3 DocumentTable { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("tag")]
        public Tag Tag { get; set; }

        [JsonProperty("user")]
        public User3 User { get; set; }
    }

    public class Table3
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class Project
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class User3
    {
        [JsonProperty("firebaseUserId")]
        public string FirebaseUserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class AccessResource
    {
        [JsonProperty("documentTable")]
        public Table3 DocumentTable { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("process")]
        public Process Process { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum resourceInput
    {
        [EnumMember(Value = "process")]
        Process,
        [EnumMember(Value = "table")]
        Table,
        [EnumMember(Value = "table_view")]
        TableView
    }

    public class CreateResourcePermissionsResponse
    {
        [JsonProperty("data")]
        public AccessPolicy Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateResourcePermissionsInput
    {
        [JsonProperty("attributeId")]
        public string AttributeId { get; set; }

        [JsonProperty("attributeKind", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateResourcePermissionsInputAttributeKindType AttributeKind { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("resourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourceId { get; set; }

        [JsonProperty("resourceKind", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateResourcePermissionsInputResourceKindType ResourceKind { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateResourcePermissionsInputRoleType Role { get; set; }

        [JsonProperty("tagReferenceId")]
        public string TagReferenceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateResourcePermissionsInputAttributeKindType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "all_table_tags")]
        AllTableTags
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateResourcePermissionsInputResourceKindType
    {
        [EnumMember(Value = "process")]
        Process,
        [EnumMember(Value = "table")]
        Table,
        [EnumMember(Value = "table_view")]
        TableView
    }

    public enum CreateResourcePermissionsInputRoleType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class CreateProjectResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SimpleProject
    {
        [JsonProperty("adminLimit")]
        public int AdminLimit { get; set; }

        [JsonProperty("automationLimit")]
        public int AutomationLimit { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("defaultProcessId")]
        public string DefaultProcessId { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("headingStyles")]
        public HeadingStyle[] HeadingStyles { get; set; }

        [JsonProperty("hideProcessCreated")]
        public bool HideProcessCreated { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("mfaRequired")]
        public bool MfaRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("noOfAdmins")]
        public int NoOfAdmins { get; set; }

        [JsonProperty("primaryColour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("processTitleBold")]
        public bool ProcessTitleBold { get; set; }

        [JsonProperty("processTitleColour")]
        public string ProcessTitleColour { get; set; }

        [JsonProperty("processTitleFontSize")]
        public double ProcessTitleFontSize { get; set; }

        [JsonProperty("processTitleItalic")]
        public bool ProcessTitleItalic { get; set; }

        [JsonProperty("processTitleUnderline")]
        public bool ProcessTitleUnderline { get; set; }

        [JsonProperty("projectList")]
        public ProjectList[] ProjectList { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class HeadingStyle
    {
        [JsonProperty("bold")]
        public bool Bold { get; set; }

        [JsonProperty("colour")]
        public string Colour { get; set; }

        [JsonProperty("fontSize")]
        public double FontSize { get; set; }

        [JsonProperty("italic")]
        public bool Italic { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("numberingStyle")]
        public int NumberingStyle { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("startAt0")]
        public bool StartAt0 { get; set; }

        [JsonProperty("underline")]
        public bool Underline { get; set; }
    }

    public class ProjectList
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User4 User { get; set; }
    }

    public class User4
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firebaseUserId")]
        public string FirebaseUserId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class CreateProjectInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class CreateProcessResponse
    {
        [JsonProperty("data")]
        public Process Data { get; set; }

        [JsonProperty("metadata")]
        public CreateProcessResponseMetadataType Metadata { get; set; }
    }

    public class CreateProcessResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class CreateProcessInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }
    }

    public class CreateTableResponse
    {
        [JsonProperty("data")]
        public Table Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class Table
    {
        [JsonProperty("allowDuplication")]
        public bool AllowDuplication { get; set; }

        [JsonProperty("columns")]
        public TableColumn[] Columns { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("defaultViewId")]
        public string DefaultViewId { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("isAconexSynced")]
        public bool IsAconexSynced { get; set; }

        [JsonProperty("isAutodeskBim360Synced")]
        public bool IsAutodeskBim360Synced { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isMortaProjectsSynced")]
        public bool IsMortaProjectsSynced { get; set; }

        [JsonProperty("isMortaResourcesSynced")]
        public bool IsMortaResourcesSynced { get; set; }

        [JsonProperty("isMortaSynced")]
        public bool IsMortaSynced { get; set; }

        [JsonProperty("isMortaUsersSynced")]
        public bool IsMortaUsersSynced { get; set; }

        [JsonProperty("isProcoreSynced")]
        public bool IsProcoreSynced { get; set; }

        [JsonProperty("isReviztoIssuesSynced")]
        public bool IsReviztoIssuesSynced { get; set; }

        [JsonProperty("isSynced")]
        public bool IsSynced { get; set; }

        [JsonProperty("isViewpointSynced")]
        public bool IsViewpointSynced { get; set; }

        [JsonProperty("joins")]
        public TableJoin[] Joins { get; set; }

        [JsonProperty("keepColoursInSync")]
        public bool KeepColoursInSync { get; set; }

        [JsonProperty("keepValidationsInSync")]
        public bool KeepValidationsInSync { get; set; }

        [JsonProperty("lastSync")]
        public string LastSync { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projects")]
        public Project[] Projects { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("syncHourlyFrequency")]
        public int SyncHourlyFrequency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("variables")]
        public string[] Variables { get; set; }
    }

    public class TableColumn
    {
        [JsonProperty("aconexSynced")]
        public int AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int Aggregate { get; set; }

        [JsonProperty("alterOptions")]
        public JToken AlterOptions { get; set; }

        [JsonProperty("autodeskBim360Synced")]
        public int AutodeskBim360Synced { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("isIndexed")]
        public bool IsIndexed { get; set; }

        [JsonProperty("isJoined")]
        public bool IsJoined { get; set; }

        [JsonProperty("kind")]
        public TableColumnKindType Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("mortaSynced")]
        public int MortaSynced { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool ScriptEnabled { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool ThousandSeparator { get; set; }

        [JsonProperty("viewpointSynced")]
        public int ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TableColumnKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class SelectOptionsLookup
    {
        [JsonProperty("manualOptions")]
        public string[] ManualOptions { get; set; }

        [JsonProperty("tableOptions")]
        public JToken TableOptions { get; set; }
    }

    public class TableJoin
    {
        [JsonProperty("dataColumns")]
        public TableJoinImportedColumns[] DataColumns { get; set; }

        [JsonProperty("isOneToMany")]
        public bool IsOneToMany { get; set; }

        [JsonProperty("joinColumns")]
        public TableColumnJoin[] JoinColumns { get; set; }

        [JsonProperty("joinTableId")]
        public string JoinTableId { get; set; }

        [JsonProperty("joinViewId")]
        public string JoinViewId { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class TableJoinImportedColumns
    {
        [JsonProperty("sourceColumnId")]
        public string SourceColumnId { get; set; }

        [JsonProperty("targetColumnId")]
        public string TargetColumnId { get; set; }
    }

    public class TableColumnJoin
    {
        [JsonProperty("sourceColumnId")]
        public string SourceColumnId { get; set; }

        [JsonProperty("targetColumnId")]
        public string TargetColumnId { get; set; }
    }

    public class CreateTableInput
    {
        [JsonProperty("columns", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableColumn[] Columns { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("joins")]
        public TableJoin2[] Joins { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; } = "n/a";
    }

    public class TableJoin2
    {
        [JsonProperty("dataColumns")]
        public TableJoinImportedColumns[] DataColumns { get; set; }

        [JsonProperty("isOneToMany")]
        public bool IsOneToMany { get; set; }

        [JsonProperty("joinColumns")]
        public TableColumnJoin[] JoinColumns { get; set; }

        [JsonProperty("joinTableName")]
        public string JoinTableName { get; set; }

        [JsonProperty("joinViewId")]
        public string JoinViewId { get; set; }

        [JsonProperty("joinViewName")]
        public string JoinViewName { get; set; }
    }

    public class CreateUserResponse
    {
        [JsonProperty("data")]
        public User Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateUserInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
    }

    public class UpdateCurrentUserResponse
    {
        [JsonProperty("data")]
        public User Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateCurrentUserInput
    {
        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("universityDegree")]
        public string UniversityDegree { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class RestoreProcessResponseResponse
    {
        [JsonProperty("data")]
        public ProcessResponse Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SubmitProcessResponseResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MortaProcessSection
    {
        [JsonProperty("children")]
        public MortaProcessSection[] Children { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public Draftjs Description { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("openCommentThreads")]
        public int OpenCommentThreads { get; set; }

        [JsonProperty("pageBreakBefore")]
        public bool PageBreakBefore { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("pdfIncludeDescription")]
        public bool PdfIncludeDescription { get; set; }

        [JsonProperty("pdfIncludeSection")]
        public bool PdfIncludeSection { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("responses")]
        public ProcessResponse[] Responses { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class SubmitProcessResponseInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }
    }

    public class ResetProcessResponseResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SubmitProcessResponseDraftResponse
    {
        [JsonProperty("data")]
        public ProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ProcessSection
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class SubmitProcessResponseDraftInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }
    }

    public class GetTableViewDistinctValuesResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpsertTableRowsInViewResponse
    {
        [JsonProperty("data")]
        public UpsertTableRowsInViewResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpsertTableRowsInViewResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class UpsertTableRowsInViewInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableRowAction[] Rows { get; set; }

        [JsonProperty("upsertColumnName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpsertColumnName { get; set; }
    }

    public class TableRowAction
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class DuplicateProcessSectionAsyncResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DuplicateProcessSectionResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DeleteProcessResponseResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessResponseResponse
    {
        [JsonProperty("data")]
        public MortaProcessResponse Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MortaProcessResponse
    {
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("expireResponse")]
        public bool ExpireResponse { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("pdfIncludeResponse")]
        public bool PdfIncludeResponse { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("resetAfterResponse")]
        public bool ResetAfterResponse { get; set; }

        [JsonProperty("responders")]
        public string[] Responders { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }

        [JsonProperty("responseDate")]
        public string ResponseDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeOptions")]
        public JToken TypeOptions { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public SummaryUser User { get; set; }

        [JsonProperty("userResponders")]
        public SummaryUser[] UserResponders { get; set; }
    }

    public class UpdateProcessResponseInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("expireResponse")]
        public bool? ExpireResponse { get; set; }

        [JsonProperty("pdfIncludeResponse")]
        public bool? PdfIncludeResponse { get; set; }

        [JsonProperty("resetAfterResponse")]
        public bool? ResetAfterResponse { get; set; }

        [JsonProperty("responders")]
        public string[] Responders { get; set; }

        [JsonProperty("type")]
        public UpdateProcessResponseInputTypeType? Type { get; set; }

        [JsonProperty("typeOptions")]
        public JToken TypeOptions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateProcessResponseInputTypeType
    {
        Flexible,
        [EnumMember(Value = "File Upload")]
        FileUpload,
        Table,
        Signature,
        Selection
    }

    public class CreateProcessResponseResponse
    {
        [JsonProperty("data")]
        public ProcessResponse Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateProcessResponseInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("type")]
        public CreateProcessResponseInputTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateProcessResponseInputTypeType
    {
        Flexible,
        [EnumMember(Value = "File Upload")]
        FileUpload,
        Table,
        Signature,
        Selection
    }

    public class RestoreProcessSectionResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class PreviewTableRowInViewResponse
    {
        [JsonProperty("data")]
        public PreviewTableRowInViewResponseDataType Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class PreviewTableRowInViewResponseDataType
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class PreviewTableRowInViewInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rowData", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken RowData { get; set; }
    }

    public class UpdateColumnOnTableViewResponse
    {
        [JsonProperty("data")]
        public TableViewColumn Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class TableViewColumn
    {
        [JsonProperty("aconexSynced")]
        public int AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int Aggregate { get; set; }

        [JsonProperty("alterOptions")]
        public JToken AlterOptions { get; set; }

        [JsonProperty("autodeskBim360Synced")]
        public int AutodeskBim360Synced { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("hardValidation")]
        public bool HardValidation { get; set; }

        [JsonProperty("isIndexed")]
        public bool IsIndexed { get; set; }

        [JsonProperty("isJoined")]
        public bool IsJoined { get; set; }

        [JsonProperty("kind")]
        public TableViewColumnKindType Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("mortaSynced")]
        public int MortaSynced { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool ScriptEnabled { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }

        [JsonProperty("stringValidation")]
        public string StringValidation { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool ThousandSeparator { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("validationNoBlanks")]
        public bool ValidationNoBlanks { get; set; }

        [JsonProperty("validationNoDuplicates")]
        public bool ValidationNoDuplicates { get; set; }

        [JsonProperty("viewpointSynced")]
        public int ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TableViewColumnKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class UpdateColumnOnTableViewInput
    {
        [JsonProperty("aconexSynced")]
        public int? AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int? Aggregate { get; set; }

        [JsonProperty("alterOptions", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AlterOptions { get; set; } = null;

        [JsonProperty("autodeskBim360Synced")]
        public int? AutodeskBim360Synced { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int? DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("hardValidation")]
        public bool? HardValidation { get; set; }

        [JsonProperty("isIndexed")]
        public bool? IsIndexed { get; set; }

        [JsonProperty("isJoined")]
        public bool? IsJoined { get; set; }

        [JsonProperty("kind")]
        public UpdateColumnOnTableViewInputKindType? Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("locked")]
        public bool? Locked { get; set; }

        [JsonProperty("mortaSynced")]
        public int? MortaSynced { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int? ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int? ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool? ScriptEnabled { get; set; }

        [JsonProperty("sortOrder")]
        public double? SortOrder { get; set; }

        [JsonProperty("stringValidation")]
        public string StringValidation { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool? ThousandSeparator { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("validationNoBlanks")]
        public bool? ValidationNoBlanks { get; set; }

        [JsonProperty("validationNoDuplicates")]
        public bool? ValidationNoDuplicates { get; set; }

        [JsonProperty("viewpointSynced")]
        public int? ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateColumnOnTableViewInputKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class SetTableViewAsDefaultResponse
    {
        [JsonProperty("data")]
        public TableView Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class TableView
    {
        [JsonProperty("allowContributorDelete")]
        public bool AllowContributorDelete { get; set; }

        [JsonProperty("chartSettings")]
        public Chart ChartSettings { get; set; }

        [JsonProperty("collapsedGroupView")]
        public bool CollapsedGroupView { get; set; }

        [JsonProperty("colourSettings")]
        public Colour[] ColourSettings { get; set; }

        [JsonProperty("columns")]
        public TableViewColumn[] Columns { get; set; }

        [JsonProperty("description")]
        public Draftjs Description { get; set; }

        [JsonProperty("disableNewRow")]
        public bool DisableNewRow { get; set; }

        [JsonProperty("displayCommentRows")]
        public int DisplayCommentRows { get; set; }

        [JsonProperty("displayValidationErrorRows")]
        public int DisplayValidationErrorRows { get; set; }

        [JsonProperty("filterSettings")]
        public Filter[] FilterSettings { get; set; }

        [JsonProperty("frozenIndex")]
        public int FrozenIndex { get; set; }

        [JsonProperty("groupSettings")]
        public Group[] GroupSettings { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowHeight")]
        public int RowHeight { get; set; }

        [JsonProperty("sortSettings")]
        public Sort[] SortSettings { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("unpackMultiselectGroupView")]
        public bool UnpackMultiselectGroupView { get; set; }
    }

    public class Chart
    {
        [JsonProperty("chartType")]
        public string ChartType { get; set; }

        [JsonProperty("columnLabelId")]
        public string ColumnLabelId { get; set; }

        [JsonProperty("columnValueId")]
        public string ColumnValueId { get; set; }

        [JsonProperty("showLegend")]
        public bool ShowLegend { get; set; }

        [JsonProperty("showValues")]
        public bool ShowValues { get; set; }
    }

    public class Colour
    {
        [JsonProperty("backgroundColour")]
        public string BackgroundColour { get; set; }

        [JsonProperty("columnId")]
        public string ColumnId { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("filterType")]
        public ColourFilterTypeType FilterType { get; set; }

        [JsonProperty("fontColour")]
        public string FontColour { get; set; }

        [JsonProperty("multipleValues")]
        public JToken[] MultipleValues { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ColourFilterTypeType
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "lte")]
        Lte,
        [EnumMember(Value = "gte")]
        Gte,
        [EnumMember(Value = "neq")]
        Neq,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "in")]
        In,
        [EnumMember(Value = "row_id")]
        RowId,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "is_not")]
        IsNot,
        [EnumMember(Value = "one_of")]
        OneOf,
        [EnumMember(Value = "not_one_of")]
        NotOneOf,
        [EnumMember(Value = "is_null")]
        IsNull,
        [EnumMember(Value = "is_not_null")]
        IsNotNull,
        [EnumMember(Value = "not_contains")]
        NotContains,
        [EnumMember(Value = "starts_with")]
        StartsWith,
        [EnumMember(Value = "ends_with")]
        EndsWith
    }

    public class Filter
    {
        [JsonProperty("columnId")]
        public string ColumnId { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("filterType")]
        public FilterFilterTypeType FilterType { get; set; }

        [JsonProperty("multipleValues")]
        public JToken[] MultipleValues { get; set; }

        [JsonProperty("orGroup")]
        public string OrGroup { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilterFilterTypeType
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "lte")]
        Lte,
        [EnumMember(Value = "gte")]
        Gte,
        [EnumMember(Value = "neq")]
        Neq,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "in")]
        In,
        [EnumMember(Value = "row_id")]
        RowId,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "is_not")]
        IsNot,
        [EnumMember(Value = "one_of")]
        OneOf,
        [EnumMember(Value = "not_one_of")]
        NotOneOf,
        [EnumMember(Value = "is_null")]
        IsNull,
        [EnumMember(Value = "is_not_null")]
        IsNotNull,
        [EnumMember(Value = "not_contains")]
        NotContains,
        [EnumMember(Value = "starts_with")]
        StartsWith,
        [EnumMember(Value = "ends_with")]
        EndsWith
    }

    public class Group
    {
        [JsonProperty("columnId")]
        public string ColumnId { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class Sort
    {
        [JsonProperty("columnId")]
        public string ColumnId { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class AddColumnToTableViewResponse
    {
        [JsonProperty("data")]
        public TableViewColumn Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class AddColumnToTableViewInput
    {
        [JsonProperty("aconexSynced")]
        public int? AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int? Aggregate { get; set; }

        [JsonProperty("alterOptions", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AlterOptions { get; set; } = null;

        [JsonProperty("autodeskBim360Synced")]
        public int? AutodeskBim360Synced { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int? DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("hardValidation")]
        public bool? HardValidation { get; set; }

        [JsonProperty("isIndexed")]
        public bool? IsIndexed { get; set; }

        [JsonProperty("isJoined")]
        public bool? IsJoined { get; set; }

        [JsonProperty("kind")]
        public AddColumnToTableViewInputKindType? Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("locked", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Locked { get; set; }

        [JsonProperty("mortaSynced")]
        public int? MortaSynced { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int? ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("required", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Required { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int? ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool? ScriptEnabled { get; set; }

        [JsonProperty("sortOrder", DefaultValueHandling = DefaultValueHandling.Include)]
        public double SortOrder { get; set; }

        [JsonProperty("stringValidation")]
        public string StringValidation { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool? ThousandSeparator { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("validationNoBlanks")]
        public bool? ValidationNoBlanks { get; set; }

        [JsonProperty("validationNoDuplicates")]
        public bool? ValidationNoDuplicates { get; set; }

        [JsonProperty("viewpointSynced")]
        public int? ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddColumnToTableViewInputKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class GetTableViewStatsResponse
    {
        [JsonProperty("data")]
        public TableColumnWithAggregation[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class TableColumnWithAggregation
    {
        [JsonProperty("aggregation")]
        public TableColumnAggregationResult Aggregation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class TableColumnAggregationResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class UpdateDocumentTableCellsInViewResponse
    {
        [JsonProperty("data")]
        public UpdateDocumentTableCellsInViewResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateDocumentTableCellsInViewResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class UpdateDocumentTableCellsInViewInput
    {
        [JsonProperty("cells", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateDocumentTableCell[] Cells { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }
    }

    public class UpdateDocumentTableCell
    {
        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rowId")]
        public string RowId { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class GetTableViewChartDataResponse
    {
        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetTableViewRowsResponse
    {
        [JsonProperty("data")]
        public GetTableViewRowsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public GetTableViewRowsResponseMetadataType Metadata { get; set; }
    }

    public class GetTableViewRowsResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class GetTableViewRowsResponseMetadataType
    {
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DeleteTableRowsInViewResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class InsertTableRowsInViewResponse
    {
        [JsonProperty("data")]
        public InsertTableRowsInViewResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class InsertTableRowsInViewResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class InsertTableRowsInViewInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableRowAction[] Rows { get; set; }
    }

    public class UpdateTableRowsInViewResponse
    {
        [JsonProperty("data")]
        public UpdateTableRowsInViewResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableRowsInViewResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class UpdateTableRowsInViewInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableRowAction1[] Rows { get; set; }
    }

    public class TableRowAction1
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class GetDistinctValuesForColumnResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RestoreTableColumnResponse
    {
        [JsonProperty("data")]
        public TableColumn Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CheckColumnInViewsResponse
    {
        [JsonProperty("data")]
        public TableView[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DuplicateDefaultTableViewResponse
    {
        [JsonProperty("data")]
        public TableView Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DuplicateDefaultTableViewInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Type { get; set; } = 0;
    }

    public class DuplicateTableViewResponse
    {
        [JsonProperty("data")]
        public TableView Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpsertTableRowsResponse
    {
        [JsonProperty("data")]
        public UpsertTableRowsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpsertTableRowsResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class UpsertTableRowsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableRowAction[] Rows { get; set; }

        [JsonProperty("upsertColumnName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpsertColumnName { get; set; }
    }

    public class ChangeUserFavouriteResponse
    {
        [JsonProperty("data")]
        public ChangeUserFavouriteResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ChangeUserFavouriteResponseDataTypeItem
    {
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class ChangeUserPinResponse
    {
        [JsonProperty("data")]
        public ChangeUserPinResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ChangeUserPinResponseDataTypeItem
    {
        [JsonProperty("contributors")]
        public int Contributors { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryColour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }
    }

    public class DeleteCommentResponse
    {
        [JsonProperty("data")]
        public Comment Data { get; set; }

        [JsonProperty("metadata")]
        public DeleteCommentResponseMetadataType Metadata { get; set; }
    }

    public class DeleteCommentResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class UpdateCommentResponse
    {
        [JsonProperty("data")]
        public Comment Data { get; set; }

        [JsonProperty("metadata")]
        public UpdateCommentResponseMetadataType Metadata { get; set; }
    }

    public class UpdateCommentResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class UpdateCommentInput
    {
        [JsonProperty("commentText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentText { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }
    }

    public class ResolveCommentThreadResponse
    {
        [JsonProperty("data")]
        public CommentThread Data { get; set; }

        [JsonProperty("metadata")]
        public ResolveCommentThreadResponseMetadataType Metadata { get; set; }
    }

    public class ResolveCommentThreadResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class CreateCommentResponse
    {
        [JsonProperty("data")]
        public Comment Data { get; set; }

        [JsonProperty("metadata")]
        public CreateCommentResponseMetadataType Metadata { get; set; }
    }

    public class CreateCommentResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class CreateCommentInput
    {
        [JsonProperty("commentText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentText { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }
    }

    public class ReopenCommentThreadResponse
    {
        [JsonProperty("data")]
        public CommentThread Data { get; set; }

        [JsonProperty("metadata")]
        public ReopenCommentThreadResponseMetadataType Metadata { get; set; }
    }

    public class ReopenCommentThreadResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class GetEventsResponse
    {
        [JsonProperty("data")]
        public Event[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class Event
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("changeId")]
        public string ChangeId { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("contextProcessId")]
        public int ContextProcessId { get; set; }

        [JsonProperty("contextProcessResponseId")]
        public int ContextProcessResponseId { get; set; }

        [JsonProperty("contextProcessSectionId")]
        public int ContextProcessSectionId { get; set; }

        [JsonProperty("contextTableColumnId")]
        public int ContextTableColumnId { get; set; }

        [JsonProperty("contextTableId")]
        public int ContextTableId { get; set; }

        [JsonProperty("contextTableViewId")]
        public int ContextTableViewId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("resourcePublicId")]
        public string ResourcePublicId { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "process")]
        Process,
        [EnumMember(Value = "table")]
        Table,
        [EnumMember(Value = "view")]
        View
    }

    public class UpdateMultipleProcessSectionsResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateMultipleProcessSectionsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("sections", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtendedUpdateProcessSection[] Sections { get; set; }
    }

    public class ExtendedUpdateProcessSection
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageBreakBefore")]
        public bool PageBreakBefore { get; set; }

        [JsonProperty("pdfIncludeDescription")]
        public bool PdfIncludeDescription { get; set; }

        [JsonProperty("pdfIncludeSection")]
        public bool PdfIncludeSection { get; set; }

        [JsonProperty("plaintextDescription")]
        public string PlaintextDescription { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class CreateProjectHeadingStylingResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectSentNotificationsResponse
    {
        [JsonProperty("data")]
        public NotificationExecution[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class NotificationExecution
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("notification")]
        public Notification1 Notification { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Notification1
    {
        [JsonProperty("actions")]
        public Action[] Actions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("processes")]
        public Process[] Processes { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("tables")]
        public Table1[] Tables { get; set; }

        [JsonProperty("triggers")]
        public Trigger[] Triggers { get; set; }
    }

    public class UpdateProcessSectionOrderResponse
    {
        [JsonProperty("data")]
        public MortaProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessSectionOrderInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("processSections")]
        public SectionOrder[] ProcessSections { get; set; }
    }

    public class SectionOrder
    {
        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("sectionId")]
        public string SectionId { get; set; }
    }

    public class GetProjectDeletedProcessesResponse
    {
        [JsonProperty("data")]
        public SimpleProcess[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SimpleProcess
    {
        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("allowDuplication")]
        public bool AllowDuplication { get; set; }

        [JsonProperty("children")]
        public ProcessSection[] Children { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("expandByDefault")]
        public bool ExpandByDefault { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("templateCategory")]
        public string TemplateCategory { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("variableValues")]
        public string[] VariableValues { get; set; }

        [JsonProperty("variables")]
        public string[] Variables { get; set; }
    }

    public class DeleteTopProjectHeadingStylingResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessRespondersResponse
    {
        [JsonProperty("data")]
        public MortaProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessRespondersInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("responders")]
        public string[] Responders { get; set; }
    }

    public class CreateMultipleProcessSectionsResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public CreateMultipleProcessSectionsResponseMetadataType Metadata { get; set; }
    }

    public class CreateMultipleProcessSectionsResponseMetadataType
    {
        [JsonProperty("resourceIds")]
        public string[] ResourceIds { get; set; }
    }

    public class CreateMultipleProcessSectionsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("sections", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProcessSection[] Sections { get; set; }
    }

    public class CreateProcessSection
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("plaintextDescription")]
        public string PlaintextDescription { get; set; }
    }

    public class InviteMultipleUsersToProjectResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class InviteMultipleUsersToProjectInput
    {
        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class ChangeUserRoleOnProjectResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ChangeUserRoleOnProjectInput
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public ChangeUserRoleOnProjectInputRoleType Role { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ChangeUserRoleOnProjectInputRoleType
    {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "member")]
        Member
    }

    public class GetInvitedProjectMembersResponse
    {
        [JsonProperty("data")]
        public InvitedMember[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class InvitedMember
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invitedBy")]
        public SummaryUser InvitedBy { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }
    }

    public class GetProjectDeletedTablesResponse
    {
        [JsonProperty("data")]
        public Table[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectNotificationsResponse
    {
        [JsonProperty("data")]
        public Notification[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RemoveUserFromProjectResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectResourcesResponse
    {
        [JsonProperty("data")]
        public GetProjectResourcesResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectResourcesResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("process")]
        public PermissionedProcess Process { get; set; }

        [JsonProperty("table")]
        public SimpleDocumentTable Table { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionedProcess
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class SimpleDocumentTable
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("defaultViewId")]
        public string DefaultViewId { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("joins")]
        public TableJoin[] Joins { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class GetProjectResourcesInput
    {
        [JsonProperty("adminView")]
        public bool? AdminView { get; set; }

        [JsonProperty("excludeProcesses")]
        public bool? ExcludeProcesses { get; set; }

        [JsonProperty("excludeTables")]
        public bool? ExcludeTables { get; set; }

        [JsonProperty("onlyDeleted")]
        public bool? OnlyDeleted { get; set; }

        [JsonProperty("projectPermissions")]
        public bool? ProjectPermissions { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }
    }

    public class GetProjectProcessesResponse
    {
        [JsonProperty("data")]
        public SimpleProcess[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectVariablesResponse
    {
        [JsonProperty("data")]
        public GetProjectVariablesResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectVariablesResponseDataTypeItem
    {
        [JsonProperty("cells")]
        public GetProjectVariablesResponseDataTypeItemCellsTypeItem[] Cells { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class GetProjectVariablesResponseDataTypeItemCellsTypeItem
    {
        [JsonProperty("column")]
        public GetProjectVariablesResponseDataTypeItemCellsTypeItemColumnType Column { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetProjectVariablesResponseDataTypeItemCellsTypeItemColumnType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class DuplicateProjectInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("duplicatePermissions")]
        public bool? DuplicatePermissions { get; set; }
    }

    public class DuplicateProcessAsyncInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("duplicateLinkedTables", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DuplicateLinkedTables { get; set; } = false;

        [JsonProperty("duplicatePermissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DuplicatePermissions { get; set; } = false;

        [JsonProperty("targetProjectId")]
        public string TargetProjectId { get; set; }
    }

    public class CreateProcessSectionsResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateProcessSectionsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("details")]
        public CreateProcessSection[] Details { get; set; }
    }

    public class DeleteProjectSecretResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProjectSecretResponse
    {
        [JsonProperty("data")]
        public ProjectSecret Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ProjectSecret
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateProjectSecretInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class GetProcessSectionResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DeleteProcessSectionResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessSectionResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessSectionInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageBreakBefore")]
        public bool? PageBreakBefore { get; set; }

        [JsonProperty("pdfIncludeDescription")]
        public bool? PdfIncludeDescription { get; set; }

        [JsonProperty("pdfIncludeSection")]
        public bool? PdfIncludeSection { get; set; }

        [JsonProperty("plaintextDescription")]
        public string PlaintextDescription { get; set; }
    }

    public class RestoreProjectResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectSecretsResponse
    {
        [JsonProperty("data")]
        public ProjectSecret[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateProjectSecretResponse
    {
        [JsonProperty("data")]
        public ProjectSecret Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateProjectSecretInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class GetProjectMembersResponse
    {
        [JsonProperty("data")]
        public ProjectListWithUserTags[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ProjectListWithUserTags
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("projectRole")]
        public string ProjectRole { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User2 User { get; set; }
    }

    public class User2
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firebaseUserId")]
        public string FirebaseUserId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }
    }

    public class RestoreProcessResponse
    {
        [JsonProperty("data")]
        public MortaProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateProcessSectionResponse
    {
        [JsonProperty("data")]
        public MortaProcessSection Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateProcessSectionInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Description { get; set; } = null;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("plaintextDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaintextDescription { get; set; } = null;
    }

    public class DeleteProjectInviteResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ResendInviteToUserForProjectResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProjectInviteResponse
    {
        [JsonProperty("data")]
        public InvitedMember Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProjectInviteInput
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class SearchProjectResponse
    {
        [JsonProperty("data")]
        public Answer Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class Answer
    {
        [JsonProperty("answers")]
        public SearchProjectAnswerResources[] Answers { get; set; }

        [JsonProperty("resources")]
        public SearchProjectResources[] Resources { get; set; }
    }

    public class SearchProjectAnswerResources
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("originalText")]
        public string OriginalText { get; set; }

        [JsonProperty("similarity")]
        public double Similarity { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SearchProjectResources
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetProjectTablesResponse
    {
        [JsonProperty("data")]
        public Table[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class InviteUserToProjectResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class InviteUserToProjectInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum exportFormatInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "docx")]
        Docx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum pageFormatInput
    {
        A1,
        A2,
        A3,
        A4,
        [EnumMember(Value = "letter")]
        Letter,
        [EnumMember(Value = "legal")]
        Legal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum pageOrientationInput
    {
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "landscape")]
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fontTypeInput
    {
        [EnumMember(Value = "arial")]
        Arial,
        [EnumMember(Value = "verdana")]
        Verdana
    }

    public class UpdateProjectHeadingStylingResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProjectHeadingStylingInput
    {
        [JsonProperty("bold", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Bold { get; set; } = true;

        [JsonProperty("colour", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Colour { get; set; } = "#000";

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("fontSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? FontSize { get; set; } = 1;

        [JsonProperty("italic", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Italic { get; set; } = false;

        [JsonProperty("numberingStyle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberingStyle { get; set; } = 0;

        [JsonProperty("startAt0", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? StartAt0 { get; set; } = false;

        [JsonProperty("underline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Underline { get; set; } = false;
    }

    public class GetProjectTagsResponse
    {
        [JsonProperty("data")]
        public GetProjectTagsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectTagsResponseDataTypeItem
    {
        [JsonProperty("cells")]
        public GetProjectTagsResponseDataTypeItemCellsTypeItem[] Cells { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class GetProjectTagsResponseDataTypeItemCellsTypeItem
    {
        [JsonProperty("column")]
        public GetProjectTagsResponseDataTypeItemCellsTypeItemColumnType Column { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetProjectTagsResponseDataTypeItemCellsTypeItemColumnType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class GetTableViewResponse
    {
        [JsonProperty("data")]
        public TableViewWithTable Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class TableViewWithTable
    {
        [JsonProperty("allowContributorDelete")]
        public bool AllowContributorDelete { get; set; }

        [JsonProperty("chartSettings")]
        public Chart ChartSettings { get; set; }

        [JsonProperty("collapsedGroupView")]
        public bool CollapsedGroupView { get; set; }

        [JsonProperty("colourSettings")]
        public Colour[] ColourSettings { get; set; }

        [JsonProperty("columns")]
        public TableViewColumn[] Columns { get; set; }

        [JsonProperty("description")]
        public Draftjs Description { get; set; }

        [JsonProperty("disableNewRow")]
        public bool DisableNewRow { get; set; }

        [JsonProperty("displayCommentRows")]
        public int DisplayCommentRows { get; set; }

        [JsonProperty("displayValidationErrorRows")]
        public int DisplayValidationErrorRows { get; set; }

        [JsonProperty("documentTable")]
        public Table2 DocumentTable { get; set; }

        [JsonProperty("filterSettings")]
        public Filter[] FilterSettings { get; set; }

        [JsonProperty("frozenIndex")]
        public int FrozenIndex { get; set; }

        [JsonProperty("groupSettings")]
        public Group[] GroupSettings { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowHeight")]
        public int RowHeight { get; set; }

        [JsonProperty("sortSettings")]
        public Sort[] SortSettings { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("unpackMultiselectGroupView")]
        public bool UnpackMultiselectGroupView { get; set; }
    }

    public class Table2
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class DeleteTableViewResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableViewResponse
    {
        [JsonProperty("data")]
        public TableView Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableViewInput
    {
        [JsonProperty("allowContributorDelete")]
        public bool? AllowContributorDelete { get; set; }

        [JsonProperty("chartSettings")]
        public JToken ChartSettings { get; set; }

        [JsonProperty("collapsedGroupView")]
        public bool? CollapsedGroupView { get; set; }

        [JsonProperty("colourSettings")]
        public Colour[] ColourSettings { get; set; }

        [JsonProperty("columns")]
        public UpdateTableViewColumn[] Columns { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("disableNewRow")]
        public bool? DisableNewRow { get; set; }

        [JsonProperty("displayCommentRows")]
        public int? DisplayCommentRows { get; set; }

        [JsonProperty("displayValidationErrorRows")]
        public int? DisplayValidationErrorRows { get; set; }

        [JsonProperty("filterSettings")]
        public Filter[] FilterSettings { get; set; }

        [JsonProperty("frozenIndex")]
        public int? FrozenIndex { get; set; }

        [JsonProperty("groupSettings")]
        public Group[] GroupSettings { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rowHeight")]
        public int? RowHeight { get; set; }

        [JsonProperty("sortSettings")]
        public Sort[] SortSettings { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("unpackMultiselectGroupView")]
        public bool? UnpackMultiselectGroupView { get; set; }
    }

    public class UpdateTableViewColumn
    {
        [JsonProperty("aconexSynced")]
        public int AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int Aggregate { get; set; }

        [JsonProperty("alterOptions")]
        public JToken AlterOptions { get; set; }

        [JsonProperty("autodeskBim360Synced")]
        public int AutodeskBim360Synced { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("hardValidation")]
        public bool HardValidation { get; set; }

        [JsonProperty("isIndexed")]
        public bool IsIndexed { get; set; }

        [JsonProperty("isJoined")]
        public bool IsJoined { get; set; }

        [JsonProperty("kind")]
        public UpdateTableViewColumnKindType Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("mortaSynced")]
        public int MortaSynced { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool ScriptEnabled { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }

        [JsonProperty("stringValidation")]
        public string StringValidation { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool ThousandSeparator { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("validationNoBlanks")]
        public bool ValidationNoBlanks { get; set; }

        [JsonProperty("validationNoDuplicates")]
        public bool ValidationNoDuplicates { get; set; }

        [JsonProperty("viewpointSynced")]
        public int ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTableViewColumnKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class DuplicateTableResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DuplicateTableInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("duplicateLinkedTables", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DuplicateLinkedTables { get; set; } = false;

        [JsonProperty("duplicatePermissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DuplicatePermissions { get; set; } = false;

        [JsonProperty("targetProjectId")]
        public string TargetProjectId { get; set; }
    }

    public class TruncateTableResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RestoreTableResponse
    {
        [JsonProperty("data")]
        public Table Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetTableColumnsResponse
    {
        [JsonProperty("data")]
        public TableColumn[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableIndexesResponse
    {
        [JsonProperty("data")]
        public TableColumn[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableIndexesInput
    {
        [JsonProperty("columns", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableColumnIndex[] Columns { get; set; }
    }

    public class TableColumnIndex
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public class DeleteTableColumnResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableColumnResponse
    {
        [JsonProperty("data")]
        public TableColumn Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableColumnInput
    {
        [JsonProperty("aconexSynced")]
        public int? AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int? Aggregate { get; set; }

        [JsonProperty("alterOptions", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AlterOptions { get; set; } = null;

        [JsonProperty("autodeskBim360Synced")]
        public int? AutodeskBim360Synced { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int? DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("isIndexed")]
        public bool? IsIndexed { get; set; }

        [JsonProperty("kind")]
        public UpdateTableColumnInputKindType? Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("mortaSynced")]
        public int? MortaSynced { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int? ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int? ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool? ScriptEnabled { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool? ThousandSeparator { get; set; }

        [JsonProperty("viewpointSynced")]
        public int? ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTableColumnInputKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class CreateTableColumnResponse
    {
        [JsonProperty("data")]
        public TableColumn Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableColumnInput
    {
        [JsonProperty("aconexSynced")]
        public int? AconexSynced { get; set; }

        [JsonProperty("aggregate")]
        public int? Aggregate { get; set; }

        [JsonProperty("alterOptions", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AlterOptions { get; set; } = null;

        [JsonProperty("autodeskBim360Synced")]
        public int? AutodeskBim360Synced { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("decimalPlaces")]
        public int? DecimalPlaces { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("isIndexed")]
        public bool? IsIndexed { get; set; }

        [JsonProperty("kind")]
        public CreateTableColumnInputKindType? Kind { get; set; }

        [JsonProperty("kindOptions")]
        public SelectOptionsLookup KindOptions { get; set; }

        [JsonProperty("mortaSynced")]
        public int? MortaSynced { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("procoreSynced")]
        public int? ProcoreSynced { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("reviztoIssuesSynced")]
        public int? ReviztoIssuesSynced { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool? ScriptEnabled { get; set; }

        [JsonProperty("thousandSeparator")]
        public bool? ThousandSeparator { get; set; }

        [JsonProperty("viewpointSynced")]
        public int? ViewpointSynced { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTableColumnInputKindType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "datetime")]
        Datetime,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "multilink")]
        Multilink,
        [EnumMember(Value = "select")]
        Select,
        [EnumMember(Value = "multiselect")]
        Multiselect,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "createdby")]
        Createdby,
        [EnumMember(Value = "modifiedby")]
        Modifiedby,
        [EnumMember(Value = "percentage")]
        Percentage,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "variable")]
        Variable,
        [EnumMember(Value = "attachment")]
        Attachment,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "duration")]
        Duration,
        [EnumMember(Value = "autonumber")]
        Autonumber
    }

    public class GetTableColumnStatsResponse
    {
        [JsonProperty("data")]
        public TableColumnWithAggregation[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableCellsResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableCellsInput
    {
        [JsonProperty("cells", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateDocumentTableCell[] Cells { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }
    }

    public class GetTableJoinsResponse
    {
        [JsonProperty("data")]
        public TableJoin[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetTableViewsResponse
    {
        [JsonProperty("data")]
        public TableView[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableViewResponse
    {
        [JsonProperty("data")]
        public TableView Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableViewInput
    {
        [JsonProperty("allowContributorDelete", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowContributorDelete { get; set; } = false;

        [JsonProperty("chartSettings")]
        public JToken ChartSettings { get; set; }

        [JsonProperty("collapsedGroupView", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CollapsedGroupView { get; set; } = false;

        [JsonProperty("colourSettings")]
        public Colour[] ColourSettings { get; set; }

        [JsonProperty("columns")]
        public ViewColumn[] Columns { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("disableNewRow", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableNewRow { get; set; } = false;

        [JsonProperty("displayCommentRows", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DisplayCommentRows { get; set; } = 0;

        [JsonProperty("displayValidationErrorRows", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DisplayValidationErrorRows { get; set; } = 0;

        [JsonProperty("filterSettings")]
        public Filter[] FilterSettings { get; set; }

        [JsonProperty("frozenIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FrozenIndex { get; set; } = 0;

        [JsonProperty("groupSettings")]
        public Group[] GroupSettings { get; set; }

        [JsonProperty("includeAllColumns", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAllColumns { get; set; } = false;

        [JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsDefault { get; set; } = false;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("rowHeight", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RowHeight { get; set; } = 0;

        [JsonProperty("sortSettings")]
        public Sort[] SortSettings { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Type { get; set; } = 0;

        [JsonProperty("unpackMultiselectGroupView", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UnpackMultiselectGroupView { get; set; } = false;
    }

    public class ViewColumn
    {
        [JsonProperty("columnId")]
        public string ColumnId { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }

    public class DeleteTableJoinResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableJoinResponse
    {
        [JsonProperty("data")]
        public Table Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableJoinInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dataColumns")]
        public string[] DataColumns { get; set; }

        [JsonProperty("isOneToMany")]
        public bool? IsOneToMany { get; set; }

        [JsonProperty("joinColumns")]
        public TableColumnJoin[] JoinColumns { get; set; }

        [JsonProperty("joinViewId")]
        public string JoinViewId { get; set; }
    }

    public class DeleteIntegrationFromTableResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SyncTableWithIntegrationResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class SyncTableWithIntegrationInput
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("enterpriseId")]
        public string EnterpriseId { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("hubId")]
        public string HubId { get; set; }

        [JsonProperty("licenseId")]
        public string LicenseId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectIds")]
        public string[] ProjectIds { get; set; }

        [JsonProperty("topFolderId")]
        public string TopFolderId { get; set; }

        [JsonProperty("type")]
        public SyncTableWithIntegrationInputTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SyncTableWithIntegrationInputTypeType
    {
        Projects,
        Resources,
        Users
    }

    public class GetWhereTableUsedResponse
    {
        [JsonProperty("data")]
        public GetWhereTableUsedResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetWhereTableUsedResponseDataTypeItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DeleteTableRowsResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableJoinResponse
    {
        [JsonProperty("data")]
        public Table Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableJoinInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("dataColumns")]
        public string[] DataColumns { get; set; }

        [JsonProperty("isOneToMany", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsOneToMany { get; set; } = false;

        [JsonProperty("joinColumns")]
        public TableColumnJoin[] JoinColumns { get; set; }

        [JsonProperty("joinViewId")]
        public string JoinViewId { get; set; }
    }

    public class GetTableRowsResponse
    {
        [JsonProperty("data")]
        public GetTableRowsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public GetTableRowsResponseMetadataType Metadata { get; set; }
    }

    public class GetTableRowsResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class GetTableRowsResponseMetadataType
    {
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class CreateTableRowsResponse
    {
        [JsonProperty("data")]
        public CreateTableRowsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateTableRowsResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class CreateTableRowsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableRowAction[] Rows { get; set; }
    }

    public class UpdateTableRowsResponse
    {
        [JsonProperty("data")]
        public UpdateTableRowsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableRowsResponseDataTypeItem
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("rowData")]
        public JToken RowData { get; set; }

        [JsonProperty("sortOrder")]
        public double SortOrder { get; set; }
    }

    public class UpdateTableRowsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public TableRowAction1[] Rows { get; set; }
    }

    public class GetUserByPublicIdResponse
    {
        [JsonProperty("data")]
        public User Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DeleteApiKeyResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateApiKeyResponse
    {
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }
    }

    public class UpdateApiKeyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetUserPublicContributionsResponse
    {
        [JsonProperty("data")]
        public Event[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetUserPinnedProjectsResponse
    {
        [JsonProperty("data")]
        public GetUserPinnedProjectsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetUserPinnedProjectsResponseDataTypeItem
    {
        [JsonProperty("contributors")]
        public int Contributors { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryColour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }
    }

    public class GetUserContributionsResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetUserAchievementsResponse
    {
        [JsonProperty("data")]
        public GetUserAchievementsResponseDataType Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetUserAchievementsResponseDataType
    {
        [JsonProperty("createdProcesses")]
        public int CreatedProcesses { get; set; }

        [JsonProperty("createdTables")]
        public int CreatedTables { get; set; }
    }

    public class UserDeleteTagResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UserAddTagResponse
    {
        [JsonProperty("data")]
        public Tag Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UserAddTagInput
    {
        [JsonProperty("tagReferenceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TagReferenceId { get; set; }
    }

    public class GetCommentThreadResponse
    {
        [JsonProperty("data")]
        public CommentThread Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DeleteCommentThreadResponse
    {
        [JsonProperty("data")]
        public CommentThread Data { get; set; }

        [JsonProperty("metadata")]
        public DeleteCommentThreadResponseMetadataType Metadata { get; set; }
    }

    public class DeleteCommentThreadResponseMetadataType
    {
        [JsonProperty("change")]
        public JToken Change { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }

    public class DeleteNotificationResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateNotificationResponse
    {
        [JsonProperty("data")]
        public Notification Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateNotificationInput
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; } = null;

        [JsonProperty("processes")]
        public string[] Processes { get; set; }

        [JsonProperty("tables")]
        public string[] Tables { get; set; }

        [JsonProperty("triggers")]
        public UpdateTrigger[] Triggers { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebhookUrl { get; set; }
    }

    public class UpdateTrigger
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }
    }

    public class UpdateResourcePermissionsResponse
    {
        [JsonProperty("data")]
        public AccessPolicy Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateResourcePermissionsInput
    {
        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateResourcePermissionsInputRoleType Role { get; set; }
    }

    public enum UpdateResourcePermissionsInputRoleType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class GetProjectResponse
    {
        [JsonProperty("data")]
        public GetProjectResponseDataType Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetProjectResponseDataType
    {
        [JsonProperty("folders")]
        public GetProjectResponseDataTypeFoldersTypeItem[] Folders { get; set; }

        [JsonProperty("projectDetails")]
        public SimpleProject ProjectDetails { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class GetProjectResponseDataTypeFoldersTypeItem
    {
        [JsonProperty("childFolders")]
        public GetProjectResponseDataTypeFoldersTypeItemChildFoldersTypeItem[] ChildFolders { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetProjectResponseDataTypeFoldersTypeItemChildFoldersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeleteProjectResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProjectResponse
    {
        [JsonProperty("data")]
        public SimpleProject Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProjectInput
    {
        [JsonProperty("defaultProcessId")]
        public string DefaultProcessId { get; set; }

        [JsonProperty("hideProcessCreated")]
        public bool? HideProcessCreated { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("mfaRequired")]
        public bool? MfaRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryColour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("processTitleBold")]
        public bool? ProcessTitleBold { get; set; }

        [JsonProperty("processTitleColour")]
        public string ProcessTitleColour { get; set; }

        [JsonProperty("processTitleFontSize")]
        public double? ProcessTitleFontSize { get; set; }

        [JsonProperty("processTitleItalic")]
        public bool? ProcessTitleItalic { get; set; }

        [JsonProperty("processTitleUnderline")]
        public bool? ProcessTitleUnderline { get; set; }

        [JsonProperty("public")]
        public bool? Public { get; set; }
    }

    public class GetProcessResponse
    {
        [JsonProperty("data")]
        public MortaProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class DeleteProcessResponse
    {
        [JsonProperty("data")]
        public MortaProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessResponse
    {
        [JsonProperty("data")]
        public SimpleProcess Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateProcessInput
    {
        [JsonProperty("allowComments")]
        public bool? AllowComments { get; set; }

        [JsonProperty("allowDuplication")]
        public bool? AllowDuplication { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("expandByDefault")]
        public bool? ExpandByDefault { get; set; }

        [JsonProperty("isTemplate")]
        public bool? IsTemplate { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plaintextDescription")]
        public string PlaintextDescription { get; set; }

        [JsonProperty("templateCategory")]
        public string TemplateCategory { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("variables")]
        public string[] Variables { get; set; }
    }

    public class GetTableResponse
    {
        [JsonProperty("data")]
        public Table Data { get; set; }

        [JsonProperty("metadata")]
        public GetTableResponseMetadataType Metadata { get; set; }
    }

    public class GetTableResponseMetadataType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DeleteTableResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableResponse
    {
        [JsonProperty("data")]
        public Table Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class UpdateTableInput
    {
        [JsonProperty("allowDuplication")]
        public bool? AllowDuplication { get; set; }

        [JsonProperty("context")]
        public BaseRequestContext Context { get; set; }

        [JsonProperty("joins")]
        public TableJoin1[] Joins { get; set; }

        [JsonProperty("keepColoursInSync")]
        public bool? KeepColoursInSync { get; set; }

        [JsonProperty("keepValidationsInSync")]
        public bool? KeepValidationsInSync { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("syncHourlyFrequency")]
        public UpdateTableInputSyncHourlyFrequencyType? SyncHourlyFrequency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("variables")]
        public string[] Variables { get; set; }
    }

    public class TableJoin1
    {
        [JsonProperty("dataColumns")]
        public TableJoinImportedColumns[] DataColumns { get; set; }

        [JsonProperty("isOneToMany")]
        public bool IsOneToMany { get; set; }

        [JsonProperty("joinColumns")]
        public TableColumnJoin[] JoinColumns { get; set; }

        [JsonProperty("joinTableName")]
        public string JoinTableName { get; set; }

        [JsonProperty("joinViewId")]
        public string JoinViewId { get; set; }

        [JsonProperty("joinViewName")]
        public string JoinViewName { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }
    }

    public enum UpdateTableInputSyncHourlyFrequencyType
    {
        _1 = 1,
        _3 = 3,
        _6 = 6,
        _12 = 12,
        _24 = 24
    }

    public class GetUserResponse
    {
        [JsonProperty("data")]
        public User Data { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Morta;

    public partial class WorkflowManagedActions
    {
        public MortaActions Morta(string connectionId) => new MortaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MortaTriggers Morta(string connectionId) => new MortaTriggers(connectionId);
    }
}