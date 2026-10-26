//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jira
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JiraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<SitesItem[], ApiConnectionActionConfiguration> ListResources()
        {
            return new DeferredBodyAction<SitesItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/oauth/token/accessible-resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SitesItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponse, ApiConnectionActionConfiguration> ListIssues(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> jql = null, Expression<Func<string>> fields = null, Expression<Func<string>> nextPageToken = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_nextPageToken = WorkflowExpression.Compile(nextPageToken, nameof(nextPageToken), required: false);
            return new DeferredBodyAction<ListIssuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/2/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_jql != null)
                    callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                callPayload.Queries["expand"] = Convert.ToString("*");
                callPayload.Queries["fields"] = Convert.ToString("*all");
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_nextPageToken != null)
                    callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(__workflow_nextPageToken);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListIssuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponseDatacenter, ApiConnectionActionConfiguration> ListIssuesDatacenter(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<ListIssuesResponseDatacenter, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListIssuesResponseDatacenter>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListTransitionsResponse, ApiConnectionActionConfiguration> ListTransitions(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueIdOrKey = WorkflowExpression.Compile(issueIdOrKey, nameof(issueIdOrKey), required: true);
            return new DeferredBodyAction<ListTransitionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/3/issue/{0}/transitions", __workflow_issueIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListTransitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTransition(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey, Expression<Func<UpdateTransitionInput>> body)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueIdOrKey = WorkflowExpression.Compile(issueIdOrKey, nameof(issueIdOrKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/3/issue/{0}/transitions", __workflow_issueIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCurrentUser(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> expand = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/3/myself";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<MCPQueryResponse, ApiConnectionActionConfiguration> McpJiraIssueManagement(Expression<Func<McpJiraIssueManagementInput>> queryRequest = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/JiraIssueManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<MCPQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CommentResponse, ApiConnectionActionConfiguration> AddComment(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueKey, Expression<Func<AddCommentV2Input>> body)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueKey = WorkflowExpression.Compile(issueKey, nameof(issueKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issue/{0}/comment", __workflow_issueKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateIssueResponse, ApiConnectionActionConfiguration> CreateIssue(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectKey, Expression<Func<string>> issueTypeIds, Expression<Func<object>> item = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_issueTypeIds = WorkflowExpression.Compile(issueTypeIds, nameof(issueTypeIds), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<CreateIssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/issue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                callPayload.Queries["issueTypeIds"] = ExpressionConverter.Convert(__workflow_issueTypeIds);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                if (__workflow_item != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<CreateIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> xRequestJirainstance, Expression<Func<CreateProjectV2Input>> project)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_project);
                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateProjectCategory(Expression<Func<string>> xRequestJirainstance, Expression<Func<CreateProjectCategoryV2Input>> body = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/projectCategory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteProject(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectIdOrKey, Expression<Func<bool>> enableUndo = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectIdOrKey = WorkflowExpression.Compile(projectIdOrKey, nameof(projectIdOrKey), required: true);
            var __workflow_enableUndo = WorkflowExpression.Compile(enableUndo, nameof(enableUndo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/project/{0}", __workflow_projectIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["enableUndo"] = Convert.ToString(false);
                if (__workflow_enableUndo != null)
                    callPayload.Queries["enableUndo"] = ExpressionConverter.Convert(__workflow_enableUndo);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EditIssue(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey, Expression<Func<bool>> notifyUsers = null, Expression<Func<bool>> overrideScreenSecurity = null, Expression<Func<bool>> overrideEditableFlag = null, Expression<Func<EditIssueV2Input>> body = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueIdOrKey = WorkflowExpression.Compile(issueIdOrKey, nameof(issueIdOrKey), required: true);
            var __workflow_notifyUsers = WorkflowExpression.Compile(notifyUsers, nameof(notifyUsers), required: false);
            var __workflow_overrideScreenSecurity = WorkflowExpression.Compile(overrideScreenSecurity, nameof(overrideScreenSecurity), required: false);
            var __workflow_overrideEditableFlag = WorkflowExpression.Compile(overrideEditableFlag, nameof(overrideEditableFlag), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/3/issue/{0}", __workflow_issueIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_notifyUsers != null)
                    callPayload.Queries["notifyUsers"] = ExpressionConverter.Convert(__workflow_notifyUsers);
                if (__workflow_overrideScreenSecurity != null)
                    callPayload.Queries["overrideScreenSecurity"] = ExpressionConverter.Convert(__workflow_overrideScreenSecurity);
                if (__workflow_overrideEditableFlag != null)
                    callPayload.Queries["overrideEditableFlag"] = ExpressionConverter.Convert(__workflow_overrideEditableFlag);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<GetAllProjectCategoriesV2ResponseItem[], ApiConnectionActionConfiguration> GetAllProjectCategories(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<GetAllProjectCategoriesV2ResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/projectCategory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<GetAllProjectCategoriesV2ResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<FullIssue, ApiConnectionActionConfiguration> GetIssue(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueKey)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueKey = WorkflowExpression.Compile(issueKey, nameof(issueKey), required: true);
            return new DeferredBodyAction<FullIssue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issue/{0}", __workflow_issueKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<FullIssue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> taskId)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/task/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> accountId, Expression<Func<string>> expand = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accountId"] = ExpressionConverter.Convert(__workflow_accountId);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListFiltersResponse, ApiConnectionActionConfiguration> ListFilters(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<ListFiltersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/filter/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListFiltersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListProjectsResponseV2, ApiConnectionActionConfiguration> ListProjects(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<ListProjectsResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/project/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListProjectsResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<UserListItem[], ApiConnectionActionConfiguration> ListProjectUsers(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectKey)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            return new DeferredBodyAction<UserListItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/user/permission/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<UserListItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveProjectCategory(Expression<Func<string>> xRequestJirainstance, Expression<Func<int>> id)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/projectCategory/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectIdOrKey, Expression<Func<UpdateProjectV2Input>> body = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectIdOrKey = WorkflowExpression.Compile(projectIdOrKey, nameof(projectIdOrKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/project/{0}", __workflow_projectIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class JiraTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssueDatacenter(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/new_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnCloseIssueDatacenter(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/close_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssueJQLDatacenter(Expression<Func<string>> jql, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/new_issue_jql_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnCloseIssue(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/close_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssue(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/new_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssueJQL(Expression<Func<string>> jql, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/new_issue_jql_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SitesItem
    {
        [JsonProperty("id")]
        public string CloudId { get; set; }

        [JsonProperty("name")]
        public string SiteName { get; set; }

        [JsonProperty("url")]
        public string SiteURL { get; set; }
    }

    public class ListIssuesResponse
    {
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("isLast")]
        public bool IsLastPage { get; set; }

        [JsonProperty("issues")]
        public JToken[] Issues { get; set; }
    }

    public class ListIssuesResponseDatacenter
    {
        [JsonProperty("startAt")]
        public int StartingRecordNumber { get; set; }

        [JsonProperty("maxResults")]
        public int MaximumNumberOfItems { get; set; }

        [JsonProperty("issues")]
        public JToken[] Issues { get; set; }
    }

    public class ListTransitionsResponse
    {
        [JsonProperty("transitions")]
        public Transition[] Transitions { get; set; }
    }

    public class Transition
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("to")]
        public TransitionStatus To { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class TransitionStatus
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateTransitionInput
    {
        [JsonProperty("fields")]
        public UpdateTransitionInputFieldsType Fields { get; set; }

        [JsonProperty("historyMetadata")]
        public UpdateTransitionInputHistoryMetadataType HistoryMetadata { get; set; }

        [JsonProperty("transition")]
        public UpdateTransitionInputTransitionType Transition { get; set; }

        [JsonProperty("update")]
        public UpdateTransitionInputUpdateType Update { get; set; }
    }

    public class UpdateTransitionInputFieldsType
    {
        [JsonProperty("assignee")]
        public UpdateTransitionInputFieldsTypeAssigneeType Assignee { get; set; }

        [JsonProperty("resolution")]
        public UpdateTransitionInputFieldsTypeResolutionType Resolution { get; set; }
    }

    public class UpdateTransitionInputFieldsTypeAssigneeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateTransitionInputFieldsTypeResolutionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateTransitionInputHistoryMetadataType
    {
        [JsonProperty("activityDescription")]
        public string ActivityDescription { get; set; }

        [JsonProperty("actor")]
        public UpdateTransitionInputHistoryMetadataTypeActorType Actor { get; set; }

        [JsonProperty("cause")]
        public UpdateTransitionInputHistoryMetadataTypeCauseType Cause { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("extraData")]
        public UpdateTransitionInputHistoryMetadataTypeExtraDataType ExtraData { get; set; }

        [JsonProperty("generator")]
        public UpdateTransitionInputHistoryMetadataTypeGeneratorType Generator { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateTransitionInputHistoryMetadataTypeActorType
    {
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class UpdateTransitionInputHistoryMetadataTypeCauseType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateTransitionInputHistoryMetadataTypeExtraDataType
    {
        public string Iteration { get; set; }
        public string Step { get; set; }
    }

    public class UpdateTransitionInputHistoryMetadataTypeGeneratorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateTransitionInputTransitionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateTransitionInputUpdateType
    {
        [JsonProperty("comment")]
        public UpdateTransitionInputUpdateTypeCommentTypeItem[] Comment { get; set; }
    }

    public class UpdateTransitionInputUpdateTypeCommentTypeItem
    {
        [JsonProperty("add")]
        public UpdateTransitionInputUpdateTypeCommentTypeItemAddType Add { get; set; }
    }

    public class UpdateTransitionInputUpdateTypeCommentTypeItemAddType
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class MCPQueryResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class McpJiraIssueManagementInput
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class CommentResponse
    {
        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("body")]
        public string CommentBody { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }
    }

    public class AddCommentV2Input
    {
        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }

    public class CreateIssueResponse
    {
        [JsonProperty("id")]
        public string IssueId { get; set; }

        [JsonProperty("key")]
        public string IssueKey { get; set; }
    }

    public class CreateProjectResponse
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("key")]
        public string ProjectKey { get; set; }
    }

    public class CreateProjectV2Input
    {
        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectKey { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("projectTypeKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProjectV2InputTypeType Type { get; set; }

        [JsonProperty("leadAccountId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LeadId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateProjectV2InputTypeType
    {
        [EnumMember(Value = "Software - Scrum software development")]
        SoftwareScrumSoftwareDevelopment,
        [EnumMember(Value = "Software - Kanban software development")]
        SoftwareKanbanSoftwareDevelopment,
        [EnumMember(Value = "Software - Basic software development")]
        SoftwareBasicSoftwareDevelopment,
        [EnumMember(Value = "Business - Project management")]
        BusinessProjectManagement,
        [EnumMember(Value = "Business - Task management")]
        BusinessTaskManagement,
        [EnumMember(Value = "Business - Process management")]
        BusinessProcessManagement
    }

    public class CreateProjectCategoryV2Input
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class EditIssueV2Input
    {
        [JsonProperty("transition")]
        public EditIssueV2InputTransitionType Transition { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("update")]
        public JToken Update { get; set; }

        [JsonProperty("historyMetadata")]
        public EditIssueV2InputHistoryMetadataType HistoryMetadata { get; set; }

        [JsonProperty("properties")]
        public EditIssueV2InputPropertiesTypeItem[] Properties { get; set; }
    }

    public class EditIssueV2InputTransitionType
    {
        [JsonProperty("id")]
        public string TransitionId { get; set; }

        [JsonProperty("looped")]
        public string TransitionLooped { get; set; }
    }

    public class EditIssueV2InputHistoryMetadataType
    {
        [JsonProperty("type")]
        public string MetadataType { get; set; }

        [JsonProperty("description")]
        public string MetadataDescription { get; set; }

        [JsonProperty("descriptionKey")]
        public string MetadataDescriptionKey { get; set; }

        [JsonProperty("activityDescription")]
        public string MetadataActivityDescription { get; set; }

        [JsonProperty("activityDescriptionKey")]
        public string MetadataActivityDescriptionKey { get; set; }

        [JsonProperty("emailDescription")]
        public string MetadataEmailDescription { get; set; }

        [JsonProperty("emailDescriptionKey")]
        public string MetadataEmailDescriptionKey { get; set; }

        [JsonProperty("actor")]
        public EditIssueV2InputHistoryMetadataTypeActorType Actor { get; set; }

        [JsonProperty("generator")]
        public EditIssueV2InputHistoryMetadataTypeGeneratorType Generator { get; set; }

        [JsonProperty("cause")]
        public EditIssueV2InputHistoryMetadataTypeCauseType Cause { get; set; }

        [JsonProperty("extraData")]
        public string ExtraData { get; set; }
    }

    public class EditIssueV2InputHistoryMetadataTypeActorType
    {
        [JsonProperty("id")]
        public string ActorId { get; set; }

        [JsonProperty("displayName")]
        public string ActorDisplayName { get; set; }

        [JsonProperty("displayNameKey")]
        public string ActorDisplayNameKey { get; set; }

        [JsonProperty("type")]
        public string ActorType { get; set; }

        [JsonProperty("avatarUrl")]
        public string ActorAvatarUrl { get; set; }

        [JsonProperty("url")]
        public string ActorUrl { get; set; }
    }

    public class EditIssueV2InputHistoryMetadataTypeGeneratorType
    {
        [JsonProperty("id")]
        public string GeneratorId { get; set; }

        [JsonProperty("displayName")]
        public string GeneratorDisplayName { get; set; }

        [JsonProperty("displayNameKey")]
        public string GeneratorDisplayNameKey { get; set; }

        [JsonProperty("type")]
        public string GeneratorType { get; set; }

        [JsonProperty("avatarUrl")]
        public string GeneratorAvatarUrl { get; set; }

        [JsonProperty("url")]
        public string GeneratorUrl { get; set; }
    }

    public class EditIssueV2InputHistoryMetadataTypeCauseType
    {
        [JsonProperty("id")]
        public string CauseId { get; set; }

        [JsonProperty("displayName")]
        public string CauseDisplayName { get; set; }

        [JsonProperty("displayNameKey")]
        public string CauseDisplayNameKey { get; set; }

        [JsonProperty("type")]
        public string CauseType { get; set; }

        [JsonProperty("avatarUrl")]
        public string CauseAvatarUrl { get; set; }

        [JsonProperty("url")]
        public string CauseUrl { get; set; }
    }

    public class EditIssueV2InputPropertiesTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class GetAllProjectCategoriesV2ResponseItem
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FullIssue
    {
        [JsonProperty("id")]
        public string IssueId { get; set; }

        [JsonProperty("key")]
        public string IssueKey { get; set; }

        [JsonProperty("self")]
        public string IssueURL { get; set; }

        [JsonProperty("fields")]
        public FullIssueFieldsType Fields { get; set; }
    }

    public class FullIssueFieldsType
    {
        [JsonProperty("issuetype")]
        public FullIssueFieldsTypeIssuetypeType Issuetype { get; set; }

        [JsonProperty("timespent")]
        public int TimeSpent { get; set; }

        [JsonProperty("project")]
        public FullIssueFieldsTypeProjectType Project { get; set; }

        [JsonProperty("aggregatetimespent")]
        public int AggregateTimeSpent { get; set; }

        [JsonProperty("resolution")]
        public FullIssueFieldsTypeResolutionType Resolution { get; set; }

        [JsonProperty("resolutiondate")]
        public string ResolutionDate { get; set; }

        [JsonProperty("workratio")]
        public int WorkRatio { get; set; }

        [JsonProperty("created")]
        public string CreatedDate { get; set; }

        [JsonProperty("priority")]
        public FullIssueFieldsTypePriorityType Priority { get; set; }

        [JsonProperty("timeestimate")]
        public int TimeEstimate { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public int AggregateTimeEstimate { get; set; }

        [JsonProperty("assignee")]
        public FullIssueFieldsTypeAssigneeType Assignee { get; set; }

        [JsonProperty("updated")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("status")]
        public FullIssueFieldsTypeStatusType Status { get; set; }

        [JsonProperty("timeoriginalestimate")]
        public int OriginalTimeEstimate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("components")]
        public FullIssueFieldsTypeComponentsTypeItem[] Components { get; set; }

        [JsonProperty("creator")]
        public FullIssueFieldsTypeCreatorType Creator { get; set; }

        [JsonProperty("reporter")]
        public FullIssueFieldsTypeReporterType Reporter { get; set; }

        [JsonProperty("aggregateprogress")]
        public FullIssueFieldsTypeAggregateprogressType Aggregateprogress { get; set; }

        [JsonProperty("duedate")]
        public string DueDateTime { get; set; }

        [JsonProperty("progress")]
        public FullIssueFieldsTypeProgressType Progress { get; set; }

        [JsonProperty("customfield_10119")]
        public JToken EpicNameCustomfield10011 { get; set; }
    }

    public class FullIssueFieldsTypeIssuetypeType
    {
        [JsonProperty("id")]
        public string IssueTypeId { get; set; }

        [JsonProperty("description")]
        public string IssueTypeDescription { get; set; }

        [JsonProperty("iconUrl")]
        public string IssueTypeIconURL { get; set; }

        [JsonProperty("name")]
        public string IssueTypeName { get; set; }
    }

    public class FullIssueFieldsTypeProjectType
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("key")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }
    }

    public class FullIssueFieldsTypeResolutionType
    {
        [JsonProperty("self")]
        public string URLOfTheIssueResolution { get; set; }

        [JsonProperty("id")]
        public string IdOfTheIssueResolution { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfTheIssueResolution { get; set; }

        [JsonProperty("name")]
        public string NameFoTheIssueResolution { get; set; }
    }

    public class FullIssueFieldsTypePriorityType
    {
        [JsonProperty("iconUrl")]
        public string PriorityIconURL { get; set; }

        [JsonProperty("name")]
        public string PriorityName { get; set; }

        [JsonProperty("id")]
        public string PriorityId { get; set; }
    }

    public class FullIssueFieldsTypeAssigneeType
    {
        [JsonProperty("accountId")]
        public string AssigneeId { get; set; }

        [JsonProperty("key")]
        public string AssigneeKey { get; set; }

        [JsonProperty("emailAddress")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("displayName")]
        public string AssigneeDisplayName { get; set; }
    }

    public class FullIssueFieldsTypeStatusType
    {
        [JsonProperty("description")]
        public string StatusDescription { get; set; }

        [JsonProperty("iconUrl")]
        public string StatusIconURL { get; set; }

        [JsonProperty("name")]
        public string StatusName { get; set; }

        [JsonProperty("id")]
        public string StatusId { get; set; }

        [JsonProperty("statusCategory")]
        public FullIssueFieldsTypeStatusTypeStatusCategoryType StatusCategory { get; set; }
    }

    public class FullIssueFieldsTypeStatusTypeStatusCategoryType
    {
        [JsonProperty("id")]
        public int StatusCategoryId { get; set; }

        [JsonProperty("key")]
        public string StatusCategoryKey { get; set; }

        [JsonProperty("colorName")]
        public string StatusCategoryColorName { get; set; }

        [JsonProperty("name")]
        public string StatusCategoryName { get; set; }
    }

    public class FullIssueFieldsTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string ComponentId { get; set; }

        [JsonProperty("name")]
        public string ComponentName { get; set; }
    }

    public class FullIssueFieldsTypeCreatorType
    {
        [JsonProperty("accountId")]
        public string CreatorId { get; set; }

        [JsonProperty("key")]
        public string CreatorKey { get; set; }

        [JsonProperty("emailAddress")]
        public string CreatorEmail { get; set; }

        [JsonProperty("displayName")]
        public string CreatorDisplayName { get; set; }
    }

    public class FullIssueFieldsTypeReporterType
    {
        [JsonProperty("accountId")]
        public string ReporterId { get; set; }

        [JsonProperty("key")]
        public string ReporterKey { get; set; }

        [JsonProperty("emailAddress")]
        public string ReporterEmail { get; set; }

        [JsonProperty("displayName")]
        public string ReporterDisplayName { get; set; }
    }

    public class FullIssueFieldsTypeAggregateprogressType
    {
        [JsonProperty("progress")]
        public int AggregateProgressCompleted { get; set; }

        [JsonProperty("total")]
        public int AggregateEstimatedEffort { get; set; }

        [JsonProperty("percent")]
        public int AggregateProgressPercent { get; set; }
    }

    public class FullIssueFieldsTypeProgressType
    {
        [JsonProperty("progress")]
        public int ProgressCompleted { get; set; }

        [JsonProperty("total")]
        public int EstimatedEffort { get; set; }

        [JsonProperty("percent")]
        public int ProgressPercent { get; set; }
    }

    public class ListFiltersResponse
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("values")]
        public FilterArrayItem[] Values { get; set; }
    }

    public class FilterArrayItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("jql")]
        public string JQL { get; set; }
    }

    public class ListProjectsResponseV2
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("values")]
        public ProjectArrayItem[] Values { get; set; }
    }

    public class ProjectArrayItem
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("key")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }
    }

    public class UserListItem
    {
        [JsonProperty("accountId")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("emailAddress")]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class UpdateProjectV2Input
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }

        [JsonProperty("projectTemplateKey")]
        public string ProjectTemplateKey { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lead")]
        public string Lead { get; set; }

        [JsonProperty("leadAccountId")]
        public string LeadAccountId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("assigneeType")]
        public string AssigneeType { get; set; }

        [JsonProperty("avatarId")]
        public string AvatarId { get; set; }

        [JsonProperty("issueSecurityScheme")]
        public string IssueSecurityScheme { get; set; }

        [JsonProperty("permissionScheme")]
        public string PermissionScheme { get; set; }

        [JsonProperty("notificationScheme")]
        public string NotificationScheme { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jira;

    public partial class WorkflowManagedActions
    {
        public JiraActions Jira(string connectionId) => new JiraActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JiraTriggers Jira(string connectionId) => new JiraTriggers(connectionId);
    }
}