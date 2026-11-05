//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubenterprise
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubenterpriseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InvokeServer(Expression<Func<string>> mcpSessionId = null, Expression<Func<QueryRequestInput>> queryRequest = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<IssueDetailsModel, ApiConnectionActionConfiguration> CreateIssue(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<IssueBasicDetailsInput>> issueBasicDetails)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_issueBasicDetails = WorkflowExpression.Compile(issueBasicDetails, nameof(issueBasicDetails), required: true);
            return new DeferredBodyAction<IssueDetailsModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/issues", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_issueBasicDetails);
                return new ApiConnectionAction<IssueDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetIssues(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> milestone = null, Expression<Func<string>> state = null, Expression<Func<string>> assignee = null, Expression<Func<string>> creator = null, Expression<Func<string>> mentioned = null, Expression<Func<string>> labels = null, Expression<Func<string>> sort = null, Expression<Func<string>> direction = null, Expression<Func<string>> since = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_milestone = WorkflowExpression.Compile(milestone, nameof(milestone), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_assignee = WorkflowExpression.Compile(assignee, nameof(assignee), required: false);
            var __workflow_creator = WorkflowExpression.Compile(creator, nameof(creator), required: false);
            var __workflow_mentioned = WorkflowExpression.Compile(mentioned, nameof(mentioned), required: false);
            var __workflow_labels = WorkflowExpression.Compile(labels, nameof(labels), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/issues", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_milestone != null)
                    callPayload.Queries["milestone"] = ExpressionConverter.Convert(__workflow_milestone);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_assignee != null)
                    callPayload.Queries["assignee"] = ExpressionConverter.Convert(__workflow_assignee);
                if (__workflow_creator != null)
                    callPayload.Queries["creator"] = ExpressionConverter.Convert(__workflow_creator);
                if (__workflow_mentioned != null)
                    callPayload.Queries["mentioned"] = ExpressionConverter.Convert(__workflow_mentioned);
                if (__workflow_labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(__workflow_labels);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<ActionsPublicKey, ApiConnectionActionConfiguration> GetRepositoryPublicKey(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            return new DeferredBodyAction<ActionsPublicKey, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/actions/secrets/public-key", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<ActionsPublicKey>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateUpdateRepositorySecret(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> secretName, Expression<Func<CreateUpdateRepositorySecretBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/actions/secrets/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_secretName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<RepositoryDetails, ApiConnectionActionConfiguration> CreateRepositoryUsingTemplate(Expression<Func<string>> templateOwner, Expression<Func<string>> templateRepository, Expression<Func<CreateRepositoryUsingTemplateBodyInput>> body)
        {
            var __workflow_templateOwner = WorkflowExpression.Compile(templateOwner, nameof(templateOwner), required: true);
            var __workflow_templateRepository = WorkflowExpression.Compile(templateRepository, nameof(templateRepository), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RepositoryDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/generate", __workflow_templateOwner.WithUrlEncoding(1), __workflow_templateRepository.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.baptiste-preview+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RepositoryDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<RepositoryDetails, ApiConnectionActionConfiguration> GetRepositoryById(Expression<Func<int>> repositoryId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            return new DeferredBodyAction<RepositoryDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repositories/{0}", __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<RepositoryDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<GitReference, ApiConnectionActionConfiguration> CreateReference(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<CreateReferenceBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GitReference, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/git/refs", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GitReference>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<GitReference, ApiConnectionActionConfiguration> GetReference(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> reference)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_reference = WorkflowExpression.Compile(reference, nameof(reference), required: true);
            return new DeferredBodyAction<GitReference, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/git/ref/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_reference.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<GitReference>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<PullRequestMergeResult, ApiConnectionActionConfiguration> MergePullRequest(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> pullNumber, Expression<Func<MergePullRequestBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_pullNumber = WorkflowExpression.Compile(pullNumber, nameof(pullNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PullRequestMergeResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls/{2}/merge", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_pullNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PullRequestMergeResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<PullRequest, ApiConnectionActionConfiguration> GetPullRequest(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> pullNumber)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_pullNumber = WorkflowExpression.Compile(pullNumber, nameof(pullNumber), required: true);
            return new DeferredBodyAction<PullRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_pullNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<PullRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<PullRequest, ApiConnectionActionConfiguration> UpdatePullRequest(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> pullNumber, Expression<Func<UpdatePullRequestBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_pullNumber = WorkflowExpression.Compile(pullNumber, nameof(pullNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PullRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_pullNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PullRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<PullRequestFile[], ApiConnectionActionConfiguration> GetPullRequestFiles(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> pullNumber)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_pullNumber = WorkflowExpression.Compile(pullNumber, nameof(pullNumber), required: true);
            return new DeferredBodyAction<PullRequestFile[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls/{2}/files", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_pullNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<PullRequestFile[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RequestReviewersPullRequest(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> pullNumber, Expression<Func<RemoveReviewersPullRequestBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_pullNumber = WorkflowExpression.Compile(pullNumber, nameof(pullNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls/{2}/requested_reviewers", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_pullNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveReviewersPullRequest(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> pullNumber, Expression<Func<RemoveReviewersPullRequestBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_pullNumber = WorkflowExpression.Compile(pullNumber, nameof(pullNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls/{2}/requested_reviewers", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_pullNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<PullRequest, ApiConnectionActionConfiguration> CreatePullRequest(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<CreatePullRequestBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PullRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PullRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetPullRequests(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> state = null, Expression<Func<string>> head = null, Expression<Func<string>> @base = null, Expression<Func<string>> sort = null, Expression<Func<string>> direction = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_head = WorkflowExpression.Compile(head, nameof(head), required: false);
            var __workflow_base = WorkflowExpression.Compile(@base, nameof(@base), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/pulls", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_head != null)
                    callPayload.Queries["head"] = ExpressionConverter.Convert(__workflow_head);
                if (__workflow_base != null)
                    callPayload.Queries["base"] = ExpressionConverter.Convert(__workflow_base);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateRepositoryDispatchEvent(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<CreateRepositoryDispatchEventBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/dispatches", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<CommitComparison, ApiConnectionActionConfiguration> CompareRepositoryCommits(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> @base, Expression<Func<string>> head)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_base = WorkflowExpression.Compile(@base, nameof(@base), required: true);
            var __workflow_head = WorkflowExpression.Compile(head, nameof(head), required: true);
            return new DeferredBodyAction<CommitComparison, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/compare/{2}...{3}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_base.WithUrlEncoding(1), __workflow_head.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<CommitComparison>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddSelectedRepoToOrgSecret(Expression<Func<string>> repositoryOwner, Expression<Func<int>> repositoryId, Expression<Func<string>> secretName)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orgs/{0}/actions/secrets/{1}/repositories/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_secretName.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveSelectedRepoFromOrgSecret(Expression<Func<string>> repositoryOwner, Expression<Func<int>> repositoryId, Expression<Func<string>> secretName)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_secretName = WorkflowExpression.Compile(secretName, nameof(secretName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orgs/{0}/actions/secrets/{1}/repositories/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_secretName.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWebhookTrigger(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> webhookId)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_webhookId = WorkflowExpression.Compile(webhookId, nameof(webhookId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/hooks/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_webhookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<IssueDetailsModel, ApiConnectionActionConfiguration> GetIssueNum(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> issueNumber)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_issueNumber = WorkflowExpression.Compile(issueNumber, nameof(issueNumber), required: true);
            return new DeferredBodyAction<IssueDetailsModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/issues/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_issueNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IssueDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<IssueDetailsModel, ApiConnectionActionConfiguration> UpdateIssueNum(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> issueNumber, Expression<Func<IssueUpdateInput>> issueUpdate)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_issueNumber = WorkflowExpression.Compile(issueNumber, nameof(issueNumber), required: true);
            var __workflow_issueUpdate = WorkflowExpression.Compile(issueUpdate, nameof(issueUpdate), required: true);
            return new DeferredBodyAction<IssueDetailsModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/issues/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_issueNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_issueUpdate);
                return new ApiConnectionAction<IssueDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<Milestone, ApiConnectionActionConfiguration> UpdateMilestone(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> milestoneNumber, Expression<Func<MilestoneUpdateInput>> milestoneUpdate = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_milestoneNumber = WorkflowExpression.Compile(milestoneNumber, nameof(milestoneNumber), required: true);
            var __workflow_milestoneUpdate = WorkflowExpression.Compile(milestoneUpdate, nameof(milestoneUpdate), required: false);
            return new DeferredBodyAction<Milestone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/milestones/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_milestoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_milestoneUpdate != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_milestoneUpdate);
                return new ApiConnectionAction<Milestone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<UserDetailsModel, ApiConnectionActionConfiguration> GetUser()
        {
            return new DeferredBodyAction<UserDetailsModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SearchGithubWithQuery(Expression<Func<QueryInput>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphql";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_query);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetAssignees(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/assignees", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> ListCollaborators(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/collaborators", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CheckCollaborator(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> userName)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/collaborators/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_userName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetMilestones(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> state = null, Expression<Func<string>> sort = null, Expression<Func<string>> direction = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/milestones", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetLabels(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/labels", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetIssueLabels(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<int>> issueNumber, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_issueNumber = WorkflowExpression.Compile(issueNumber, nameof(issueNumber), required: true);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/issues/{2}/labels", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_issueNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetRepos(Expression<Func<string>> repositoryOwner, Expression<Func<string>> type = null, Expression<Func<string>> sort = null, Expression<Func<string>> direction = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/repos", __workflow_repositoryOwner.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetOrgRepos(Expression<Func<string>> repositoryOwner, Expression<Func<string>> type = null, Expression<Func<string>> sort = null, Expression<Func<string>> direction = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orgs/{0}/repos", __workflow_repositoryOwner.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetUserRepos(Expression<Func<string>> visibility = null, Expression<Func<string>> affiliation = null, Expression<Func<string>> since = null, Expression<Func<string>> before = null, Expression<Func<string>> type = null, Expression<Func<string>> sort = null, Expression<Func<string>> direction = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_visibility = WorkflowExpression.Compile(visibility, nameof(visibility), required: false);
            var __workflow_affiliation = WorkflowExpression.Compile(affiliation, nameof(affiliation), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user/repos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_visibility != null)
                    callPayload.Queries["visibility"] = ExpressionConverter.Convert(__workflow_visibility);
                if (__workflow_affiliation != null)
                    callPayload.Queries["affiliation"] = ExpressionConverter.Convert(__workflow_affiliation);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<MultipleSearchFetchModel, ApiConnectionActionConfiguration> SearchIssues(Expression<Func<string>> q, Expression<Func<string>> sort = null, Expression<Func<string>> order = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<MultipleSearchFetchModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search/issues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<MultipleSearchFetchModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> ListRepositoryBranches(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<bool>> @protected = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_protected = WorkflowExpression.Compile(@protected, nameof(@protected), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/branches", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_protected != null)
                    callPayload.Queries["protected"] = ExpressionConverter.Convert(__workflow_protected);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> ListRepositoryCommits(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> sha = null, Expression<Func<string>> author = null, Expression<Func<string>> committer = null, Expression<Func<string>> path = null, Expression<Func<string>> since = null, Expression<Func<string>> until = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_sha = WorkflowExpression.Compile(sha, nameof(sha), required: false);
            var __workflow_author = WorkflowExpression.Compile(author, nameof(author), required: false);
            var __workflow_committer = WorkflowExpression.Compile(committer, nameof(committer), required: false);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_until = WorkflowExpression.Compile(until, nameof(until), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/commits", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sha != null)
                    callPayload.Queries["sha"] = ExpressionConverter.Convert(__workflow_sha);
                if (__workflow_author != null)
                    callPayload.Queries["author"] = ExpressionConverter.Convert(__workflow_author);
                if (__workflow_committer != null)
                    callPayload.Queries["committer"] = ExpressionConverter.Convert(__workflow_committer);
                if (__workflow_path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_until != null)
                    callPayload.Queries["until"] = ExpressionConverter.Convert(__workflow_until);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<RepositoryDetails, ApiConnectionActionConfiguration> GetRepository(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            return new DeferredBodyAction<RepositoryDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction<RepositoryDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetRepositoryContents(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> path, Expression<Func<string>> @ref = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_ref = WorkflowExpression.Compile(@ref, nameof(@ref), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/contents/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_path.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ref != null)
                    callPayload.Queries["ref"] = ExpressionConverter.Convert(__workflow_ref);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateOrUpdateFile(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> path, Expression<Func<CreateOrUpdateFileBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/contents/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_path.WithUrlEncoding(2)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetRepositoryRawFileContent(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<string>> path, Expression<Func<string>> @ref = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_ref = WorkflowExpression.Compile(@ref, nameof(@ref), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/raw-contents/{2}", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1), __workflow_path.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ref != null)
                    callPayload.Queries["ref"] = ExpressionConverter.Convert(__workflow_ref);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> StartTask(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<StartTaskBodyInput>> body)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/agent-tasks", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<TaskListResponse, ApiConnectionActionConfiguration> ListRepositoryTasks(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<StateInput>> state = null, Expression<Func<bool>> isArchived = null, Expression<Func<string>> sort = null, Expression<Func<DirectionInput>> direction = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_isArchived = WorkflowExpression.Compile(isArchived, nameof(isArchived), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<TaskListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/agent-tasks", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_isArchived != null)
                    callPayload.Queries["is_archived"] = ExpressionConverter.Convert(__workflow_isArchived);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<TaskListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubenterprise")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agent-tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }
    }

    public class GithubenterpriseTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> WebhookPullRequestTrigger(Expression<Func<string>> repositoryOwner, Expression<Func<string>> repositoryName, Expression<Func<RequestBodyOfWebhookInput>> requestBodyOfWebhook = null, FlowRecurrence recurrence = null)
        {
            var __workflow_repositoryOwner = WorkflowExpression.Compile(repositoryOwner, nameof(repositoryOwner), required: true);
            var __workflow_repositoryName = WorkflowExpression.Compile(repositoryName, nameof(repositoryName), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: false);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/repos/{0}/{1}/hooks", __workflow_repositoryOwner.WithUrlEncoding(1), __workflow_repositoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.github.v3+json");
                if (__workflow_requestBodyOfWebhook != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssueDetailsModel[], ApiConnectionTriggerConfiguration> IssueOpened(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<IssueDetailsModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/issueOpened";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<IssueDetailsModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssueDetailsModel[], ApiConnectionTriggerConfiguration> IssueClosed(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<IssueDetailsModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/issueClosed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<IssueDetailsModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssueDetailsModel[], ApiConnectionTriggerConfiguration> IssueAssigned(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<IssueDetailsModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/issueAssigned";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<IssueDetailsModel[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class QueryRequestInput
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

    public class IssueDetailsModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("assignee")]
        public UserDetailsModel Assignee { get; set; }

        [JsonProperty("number")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("repository_url")]
        public string RepositoryUrl { get; set; }
    }

    public class UserDetailsModel
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hireable")]
        public bool Hireable { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("public_repos")]
        public int PublicRepos { get; set; }

        [JsonProperty("public_gists")]
        public int PublicGists { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class IssueBasicDetailsInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class ActionsPublicKey
    {
        [JsonProperty("key_id")]
        public string KeyId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class CreateUpdateRepositorySecretBodyInput
    {
        [JsonProperty("encrypted_value")]
        public string EncryptedValue { get; set; }

        [JsonProperty("key_id")]
        public string KeyId { get; set; }
    }

    public class RepositoryDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("license")]
        public LicenseDetails License { get; set; }

        [JsonProperty("forks")]
        public int Forks { get; set; }

        [JsonProperty("permissions")]
        public RepositoryDetailsPermissionsType Permissions { get; set; }

        [JsonProperty("owner")]
        public UserDetailsModel Owner { get; set; }

        [JsonProperty("private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fork")]
        public bool IsAFork { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        [JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        [JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        [JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        [JsonProperty("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("compare_url")]
        public string CompareUrl { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        [JsonProperty("contributors_url")]
        public string ContributorsUrl { get; set; }

        [JsonProperty("deployments_url")]
        public string DeploymentsUrl { get; set; }

        [JsonProperty("downloads_url")]
        public string DownloadsUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        [JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        public string GitReferencesUrl { get; set; }

        [JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_url")]
        public string GitUrl { get; set; }

        [JsonProperty("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        [JsonProperty("keys_url")]
        public string KeysUrl { get; set; }

        [JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        [JsonProperty("languages_url")]
        public string LanguagesUrl { get; set; }

        [JsonProperty("merges_url")]
        public string MergesUrl { get; set; }

        [JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        [JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        [JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("ssh_url")]
        public string SSHUrl { get; set; }

        [JsonProperty("stargazers_url")]
        public string StargazersUrl { get; set; }

        [JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [JsonProperty("subscribers_url")]
        public string SubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        public string SubscriptionUrl { get; set; }

        [JsonProperty("tags_url")]
        public string TagsUrl { get; set; }

        [JsonProperty("teams_url")]
        public string TeamsUrl { get; set; }

        [JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        [JsonProperty("clone_url")]
        public string CloneUrl { get; set; }

        [JsonProperty("mirror_url")]
        public string MirrorUrl { get; set; }

        [JsonProperty("hooks_url")]
        public string HooksUrl { get; set; }

        [JsonProperty("svn_url")]
        public string SVNUrl { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        [JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        public int WatchersCount { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("disabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("pushed_at")]
        public string PushedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("allow_rebase_merge")]
        public bool AllowRebaseMerge { get; set; }

        [JsonProperty("template_repository")]
        public RepositoryDetailsTemplateRepositoryType TemplateRepository { get; set; }

        [JsonProperty("temp_clone_token")]
        public string TempCloneToken { get; set; }

        [JsonProperty("allow_squash_merge")]
        public bool AllowSquashMerge { get; set; }

        [JsonProperty("delete_branch_on_merge")]
        public bool DeleteBranchOnMerge { get; set; }

        [JsonProperty("allow_merge_commit")]
        public bool AllowMergeCommit { get; set; }

        [JsonProperty("subscribers_count")]
        public int SubscribersCount { get; set; }

        [JsonProperty("network_count")]
        public int NetworkCount { get; set; }

        [JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        [JsonProperty("watchers")]
        public int Watchers { get; set; }

        [JsonProperty("master_branch")]
        public string MasterBranch { get; set; }

        [JsonProperty("starred_at")]
        public string StarredAt { get; set; }
    }

    public class LicenseDetails
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("spdx_id")]
        public string SPDXId { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("html_url")]
        public string HTMLUrl { get; set; }
    }

    public class RepositoryDetailsPermissionsType
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("pull")]
        public bool Pull { get; set; }

        [JsonProperty("triage")]
        public bool Triage { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }

        [JsonProperty("maintain")]
        public bool Maintain { get; set; }
    }

    public class RepositoryDetailsTemplateRepositoryType
    {
        [JsonProperty("id")]
        public int TemplateRepositoryId { get; set; }

        [JsonProperty("node_id")]
        public string TemplateRepositoryNodeId { get; set; }

        [JsonProperty("name")]
        public string TemplateRepositoryName { get; set; }

        [JsonProperty("full_name")]
        public string TemplateRepositoryFullName { get; set; }

        [JsonProperty("owner")]
        public UserDetailsModel Owner { get; set; }

        [JsonProperty("private")]
        public bool IsTemplateRepositoryPrivate { get; set; }

        [JsonProperty("html_url")]
        public string TemplateRepositoryHtmlUrl { get; set; }

        [JsonProperty("description")]
        public string TemplateRepositoryDescription { get; set; }

        [JsonProperty("fork")]
        public bool IsTemplateRepositoryAFork { get; set; }

        [JsonProperty("url")]
        public string TemplateRepositoryUrl { get; set; }

        [JsonProperty("archive_url")]
        public string TemplateRepositoryArchiveUrl { get; set; }

        [JsonProperty("assignees_url")]
        public string TemplateRepositoryAssigneesUrl { get; set; }

        [JsonProperty("blobs_url")]
        public string TemplateRepositoryBlobsUrl { get; set; }

        [JsonProperty("branches_url")]
        public string TemplateRepositoryBranchesUrl { get; set; }

        [JsonProperty("collaborators_url")]
        public string TemplateRepositoryCollaboratorsUrl { get; set; }

        [JsonProperty("comments_url")]
        public string TemplateRepositoryCommentsUrl { get; set; }

        [JsonProperty("commits_url")]
        public string TemplateRepositoryCommitsUrl { get; set; }

        [JsonProperty("compare_url")]
        public string TemplateRepositoryCompareUrl { get; set; }

        [JsonProperty("contents_url")]
        public string TemplateRepositoryContentsUrl { get; set; }

        [JsonProperty("contributors_url")]
        public string TemplateRepositoryContributorsUrl { get; set; }

        [JsonProperty("deployments_url")]
        public string TemplateRepositoryDeploymentsUrl { get; set; }

        [JsonProperty("downloads_url")]
        public string TemplateRepositoryDownloadsUrl { get; set; }

        [JsonProperty("events_url")]
        public string TemplateRepositoryEventsUrl { get; set; }

        [JsonProperty("forks_url")]
        public string TemplateRepositoryForksUrl { get; set; }

        [JsonProperty("git_commits_url")]
        public string TemplateRepositoryGitCommitsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        public string TemplateRepositoryGitReferencesUrl { get; set; }

        [JsonProperty("git_tags_url")]
        public string TemplateRepositoryGitTagsUrl { get; set; }

        [JsonProperty("git_url")]
        public string TemplateRepositoryGitUrl { get; set; }

        [JsonProperty("issue_comment_url")]
        public string TemplateRepositoryIssueCommentUrl { get; set; }

        [JsonProperty("issue_events_url")]
        public string TemplateRepositoryIssueEventsUrl { get; set; }

        [JsonProperty("issues_url")]
        public string TemplateRepositoryIssuesUrl { get; set; }

        [JsonProperty("keys_url")]
        public string TemplateRepositoryKeysUrl { get; set; }

        [JsonProperty("labels_url")]
        public string TemplateRepositoryLabelsUrl { get; set; }

        [JsonProperty("languages_url")]
        public string TemplateRepositoryLanguagesUrl { get; set; }

        [JsonProperty("merges_url")]
        public string TemplateRepositoryMergesUrl { get; set; }

        [JsonProperty("milestones_url")]
        public string TemplateRepositoryMilestonesUrl { get; set; }

        [JsonProperty("notifications_url")]
        public string TemplateRepositoryNotificationsUrl { get; set; }

        [JsonProperty("pulls_url")]
        public string TemplateRepositoryPullsUrl { get; set; }

        [JsonProperty("releases_url")]
        public string TemplateRepositoryReleasesUrl { get; set; }

        [JsonProperty("ssh_url")]
        public string TemplateRepositorySSHUrl { get; set; }

        [JsonProperty("stargazers_url")]
        public string TemplateRepositoryStargazersUrl { get; set; }

        [JsonProperty("statuses_url")]
        public string TemplateRepositoryStatusesUrl { get; set; }

        [JsonProperty("subscribers_url")]
        public string TemplateRepositorySubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        public string TemplateRepositorySubscriptionUrl { get; set; }

        [JsonProperty("tags_url")]
        public string TemplateRepositoryTagsUrl { get; set; }

        [JsonProperty("teams_url")]
        public string TemplateRepositoryTeamsUrl { get; set; }

        [JsonProperty("trees_url")]
        public string TemplateRepositoryTreesUrl { get; set; }

        [JsonProperty("clone_url")]
        public string TemplateRepositoryCloneUrl { get; set; }

        [JsonProperty("mirror_url")]
        public string TemplateRepositoryMirrorUrl { get; set; }

        [JsonProperty("hooks_url")]
        public string TemplateRepositoryHooksUrl { get; set; }

        [JsonProperty("svn_url")]
        public string TemplateRepositorySVNUrl { get; set; }

        [JsonProperty("homepage")]
        public string TemplateRepositoryHomepage { get; set; }

        [JsonProperty("language")]
        public string TemplateRepositoryLanguage { get; set; }

        [JsonProperty("forks_count")]
        public int TemplateRepositoryForksCount { get; set; }

        [JsonProperty("stargazers_count")]
        public int TemplateRepositoryStargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        public int TemplateRepositoryWatchersCount { get; set; }

        [JsonProperty("size")]
        public int TemplateRepositorySize { get; set; }

        [JsonProperty("default_branch")]
        public string TemplateRepositoryDefaultBranch { get; set; }

        [JsonProperty("open_issues_count")]
        public int TemplateRepositoryOpenIssuesCount { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplateRepositoryATemplate { get; set; }

        [JsonProperty("topics")]
        public string[] TemplateRepositoryTopics { get; set; }

        [JsonProperty("has_issues")]
        public bool TemplateRepositoryHasIssues { get; set; }

        [JsonProperty("has_projects")]
        public bool TemplateRepositoryHasProjects { get; set; }

        [JsonProperty("has_wiki")]
        public bool TemplateRepositoryHasWiki { get; set; }

        [JsonProperty("has_pages")]
        public bool TemplateRepositoryHasPages { get; set; }

        [JsonProperty("has_downloads")]
        public bool TemplateRepositoryHasDownloads { get; set; }

        [JsonProperty("archived")]
        public bool IsTemplateRepositoryArchived { get; set; }

        [JsonProperty("disabled")]
        public bool IsTemplateRepositoryDisabled { get; set; }

        [JsonProperty("visibility")]
        public string TemplateRepositoryVisibility { get; set; }

        [JsonProperty("pushed_at")]
        public string TemplateRepositoryPushedAt { get; set; }

        [JsonProperty("created_at")]
        public string TemplateRepositoryCreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string TemplateRepositoryUpdatedAt { get; set; }

        [JsonProperty("permissions")]
        public RepositoryDetailsTemplateRepositoryTypeTemplateRepositoryPermissionsType TemplateRepositoryPermissions { get; set; }

        [JsonProperty("allow_rebase_merge")]
        public bool TemplateRepositoryAllowRebaseMerge { get; set; }

        [JsonProperty("template_repository")]
        public string TemplateRepositoryOfTemplateRepository { get; set; }

        [JsonProperty("temp_clone_token")]
        public string TemplateRepositoryTempCloneToken { get; set; }

        [JsonProperty("allow_squash_merge")]
        public bool TemplateRepositoryAllowSquashMerge { get; set; }

        [JsonProperty("delete_branch_on_merge")]
        public bool TemplateRepositoryDeleteBranchOnMerge { get; set; }

        [JsonProperty("allow_merge_commit")]
        public bool TemplateRepositoryAllowMergeCommit { get; set; }

        [JsonProperty("subscribers_count")]
        public int TemplateRepositorySubscribersCount { get; set; }

        [JsonProperty("network_count")]
        public int TemplateRepositoryNetworkCount { get; set; }
    }

    public class RepositoryDetailsTemplateRepositoryTypeTemplateRepositoryPermissionsType
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }

        [JsonProperty("pull")]
        public bool Pull { get; set; }
    }

    public class CreateRepositoryUsingTemplateBodyInput
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("private", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsPrivate { get; set; } = false;
    }

    public class GitReference
    {
        [JsonProperty("ref")]
        public string Reference { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("object")]
        public GitReferenceObjectEntityType ObjectEntity { get; set; }
    }

    public class GitReferenceObjectEntityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateReferenceBodyInput
    {
        [JsonProperty("ref", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Reference { get; set; }

        [JsonProperty("sha", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sha { get; set; }
    }

    public class PullRequestMergeResult
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("merged")]
        public bool IsMerged { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class MergePullRequestBodyInput
    {
        [JsonProperty("commitTitle")]
        public string CommitTitle { get; set; }

        [JsonProperty("commitMessage")]
        public string CommitMessage { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("mergeMethod")]
        public BodyInputMergeMethodType? MergeMethod { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputMergeMethodType
    {
        [EnumMember(Value = "merge")]
        Merge,
        [EnumMember(Value = "squash")]
        Squash,
        [EnumMember(Value = "rebase")]
        Rebase
    }

    public class PullRequest
    {
        [JsonProperty("url")]
        public string PullRequestUrl { get; set; }

        [JsonProperty("id")]
        public int PullRequestId { get; set; }

        [JsonProperty("node_id")]
        public string PullRequestNodeId { get; set; }

        [JsonProperty("html_url")]
        public string PullRequestHtmlUrl { get; set; }

        [JsonProperty("comments_url")]
        public string PullRequestDiffUrl { get; set; }

        [JsonProperty("patch_url")]
        public string PullRequestPatchUrl { get; set; }

        [JsonProperty("issue_url")]
        public string PullRequestIssueUrl { get; set; }

        [JsonProperty("commits_url")]
        public string PullRequestCommitUrl { get; set; }

        [JsonProperty("review_comments_url")]
        public string PullRequestReviewCommentsUrl { get; set; }

        [JsonProperty("review_comment_url")]
        public string PullRequestReviewCommentUrl { get; set; }

        [JsonProperty("statuses_url")]
        public string PullRequestStatusesUrl { get; set; }

        [JsonProperty("number")]
        public int PullRequestNumber { get; set; }

        [JsonProperty("state")]
        public PullRequestPullRequestStateType PullRequestState { get; set; }

        [JsonProperty("locked")]
        public bool IsPullRequestLocked { get; set; }

        [JsonProperty("title")]
        public string PullRequestTitle { get; set; }

        [JsonProperty("user")]
        public UserDetailsModel User { get; set; }

        [JsonProperty("body")]
        public string PullRequestBody { get; set; }

        [JsonProperty("labels")]
        public Label[] PullRequestLabels { get; set; }

        [JsonProperty("milestone")]
        public Milestone Milestone { get; set; }

        [JsonProperty("active_lock_reason")]
        public string PullRequestActiveLockReason { get; set; }

        [JsonProperty("created_at")]
        public string PullRequestCreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string PullRequestUpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public string PullRequestClosedAt { get; set; }

        [JsonProperty("merged_at")]
        public string PullRequestMergedAt { get; set; }

        [JsonProperty("merge_commit_sha")]
        public string PullRequestMergeCommitSha { get; set; }

        [JsonProperty("assignee")]
        public UserDetailsModel Assignee { get; set; }

        [JsonProperty("assignees")]
        public UserDetailsModel[] PullRequestAssignees { get; set; }

        [JsonProperty("requested_reviewers")]
        public UserDetailsModel[] PullRequestRequestedReviewers { get; set; }

        [JsonProperty("requested_teams")]
        public TeamDetails[] PullRequestRequestedTeams { get; set; }

        [JsonProperty("head")]
        public PullRequestHeadType Head { get; set; }

        [JsonProperty("base")]
        public PullRequestBaseType Base { get; set; }

        [JsonProperty("author_association")]
        public string PullRequestAuthorAssociation { get; set; }

        [JsonProperty("draft")]
        public bool IsPullRequestDraft { get; set; }

        [JsonProperty("merged")]
        public bool IsPullRequestMerged { get; set; }

        [JsonProperty("mergeable")]
        public bool IsPullRequestMergeable { get; set; }

        [JsonProperty("rebaseable")]
        public bool IsPullRequestRebaseable { get; set; }

        [JsonProperty("mergeable_state")]
        public string PullRequestMergeableState { get; set; }

        [JsonProperty("merged_by")]
        public UserDetailsModel MergedBy { get; set; }

        [JsonProperty("comments")]
        public int PullRequestCommentsCount { get; set; }

        [JsonProperty("review_comments")]
        public int PullRequestReviewCommentsCount { get; set; }

        [JsonProperty("maintainer_can_modify")]
        public bool CanMaintainerModifyPullRequest { get; set; }

        [JsonProperty("commits")]
        public int PullRequestCommitsCount { get; set; }

        [JsonProperty("additions")]
        public int PullRequestAdditionsCount { get; set; }

        [JsonProperty("deletions")]
        public int PullRequestDeletionsCount { get; set; }

        [JsonProperty("changed_files")]
        public int PullRequestChangedFilesCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PullRequestPullRequestStateType
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class Label
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("default")]
        public bool IsDefault { get; set; }
    }

    public class Milestone
    {
        [JsonProperty("url")]
        public string MilestoneUrl { get; set; }

        [JsonProperty("html_url")]
        public string MilestoneHtmlUrl { get; set; }

        [JsonProperty("labels_url")]
        public string MilestoneLabelsUrl { get; set; }

        [JsonProperty("id")]
        public int MilestoneId { get; set; }

        [JsonProperty("node_id")]
        public string MilestoneNodeId { get; set; }

        [JsonProperty("number")]
        public int MilestoneNumber { get; set; }

        [JsonProperty("state")]
        public MilestoneMilestoneStateType MilestoneState { get; set; }

        [JsonProperty("title")]
        public string MilestoneTitle { get; set; }

        [JsonProperty("description")]
        public string MilestoneDescription { get; set; }

        [JsonProperty("creator")]
        public UserDetailsModel Creator { get; set; }

        [JsonProperty("open_issues")]
        public int MilestoneOpenIssues { get; set; }

        [JsonProperty("closed_issues")]
        public int MilestoneClosedIssues { get; set; }

        [JsonProperty("created_at")]
        public string MilestoneCreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string MilestoneUpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public string MilestoneClosedAt { get; set; }

        [JsonProperty("due_on")]
        public string MilestoneDueOn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MilestoneMilestoneStateType
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class TeamDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("members_url")]
        public string MembersUrl { get; set; }

        [JsonProperty("name")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("html_url")]
        public string HTMLUrl { get; set; }

        [JsonProperty("repositories_url")]
        public string RepositoriesUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("ldap_dn")]
        public string LDAPDN { get; set; }
    }

    public class PullRequestHeadType
    {
        [JsonProperty("label")]
        public string PullRequestHeadLabel { get; set; }

        [JsonProperty("ref")]
        public string PullRequestHeadReference { get; set; }

        [JsonProperty("repo")]
        public RepositoryMiniDetails Repo { get; set; }

        [JsonProperty("sha")]
        public string PullRequestHeadSha { get; set; }

        [JsonProperty("user")]
        public UserDetailsModel User { get; set; }
    }

    public class RepositoryMiniDetails
    {
        [JsonProperty("id")]
        public int RepositoryId { get; set; }

        [JsonProperty("node_id")]
        public string RepositoryNodeId { get; set; }

        [JsonProperty("name")]
        public string RepositoryName { get; set; }

        [JsonProperty("full_name")]
        public string RepositoryFullName { get; set; }

        [JsonProperty("permissions")]
        public RepositoryMiniDetailsRepositoryPermissionsType RepositoryPermissions { get; set; }

        [JsonProperty("owner")]
        public UserDetailsModel Owner { get; set; }

        [JsonProperty("private")]
        public bool IsRepositoryPrivate { get; set; }

        [JsonProperty("description")]
        public string RepositoryDescription { get; set; }

        [JsonProperty("homepage")]
        public string RepositoryHomepage { get; set; }

        [JsonProperty("language")]
        public string RepositoryLanguage { get; set; }

        [JsonProperty("archived")]
        public bool IsRepositoryArchived { get; set; }

        [JsonProperty("disabled")]
        public bool IsRepositoryDisabled { get; set; }

        [JsonProperty("visibility")]
        public string RepositoryVisibility { get; set; }

        [JsonProperty("created_at")]
        public string RepositoryCreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string RepositoryUpdatedAt { get; set; }

        [JsonProperty("allow_rebase_merge")]
        public bool RepositoryAllowRebaseMerge { get; set; }

        [JsonProperty("allow_squash_merge")]
        public bool RepositoryAllowSquashMerge { get; set; }

        [JsonProperty("delete_branch_on_merge")]
        public bool RepositoryDeleteBranchOnMerge { get; set; }

        [JsonProperty("allow_merge_commit")]
        public bool RepositoryAllowMergeCommit { get; set; }

        [JsonProperty("master_branch")]
        public string RepositoryMasterBranch { get; set; }
    }

    public class RepositoryMiniDetailsRepositoryPermissionsType
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("pull")]
        public bool Pull { get; set; }

        [JsonProperty("triage")]
        public bool Triage { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }

        [JsonProperty("maintain")]
        public bool Maintain { get; set; }
    }

    public class PullRequestBaseType
    {
        [JsonProperty("label")]
        public string PullRequestBaseLabel { get; set; }

        [JsonProperty("ref")]
        public string PullRequestBaseReference { get; set; }

        [JsonProperty("repo")]
        public RepositoryMiniDetails Repo { get; set; }

        [JsonProperty("sha")]
        public string PullRequestBaseSha { get; set; }

        [JsonProperty("user")]
        public UserDetailsModel User { get; set; }
    }

    public class UpdatePullRequestBodyInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("state")]
        public BodyInputStateType? State { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("maintainer_can_modify")]
        public bool? CanMaintainerModify { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStateType
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class PullRequestFile
    {
        [JsonProperty("sha")]
        public string ShaForTheFile { get; set; }

        [JsonProperty("filename")]
        public string TheFileName { get; set; }

        [JsonProperty("status")]
        public string ModificationStatusForTheFile { get; set; }

        [JsonProperty("additions")]
        public int NumberOfAdditionsMadeToTheFile { get; set; }

        [JsonProperty("deletions")]
        public int NumberOfDeletionsMadeToTheFile { get; set; }

        [JsonProperty("changes")]
        public int NumberOfChangesMadeToTheFile { get; set; }

        [JsonProperty("blob_url")]
        public string BlobUrlForTheFile { get; set; }

        [JsonProperty("raw_url")]
        public string RawUrlForTheFile { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsUrlForTheFile { get; set; }

        [JsonProperty("patch")]
        public string PatchContentForTheFile { get; set; }
    }

    public class RemoveReviewersPullRequestBodyInput
    {
        [JsonProperty("reviewers")]
        public string[] Reviewers { get; set; }

        [JsonProperty("team_reviewers")]
        public string[] TeamReviewers { get; set; }
    }

    public class CreatePullRequestBodyInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("head", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Head { get; set; }

        [JsonProperty("base", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("maintainer_can_modify")]
        public bool? CanMaintainerModify { get; set; }

        [JsonProperty("draft")]
        public bool? Draft { get; set; }
    }

    public class CreateRepositoryDispatchEventBodyInput
    {
        [JsonProperty("event_type")]
        public string EventName { get; set; }

        [JsonProperty("client_payload")]
        public JToken EventPayload { get; set; }
    }

    public class CommitComparison
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HTMLUrl { get; set; }

        [JsonProperty("permalink_url")]
        public string PermanentUrl { get; set; }

        [JsonProperty("diff_url")]
        public string DiffUrl { get; set; }

        [JsonProperty("patch_url")]
        public string PatchUrl { get; set; }

        [JsonProperty("base_commit")]
        public CommitInfo BaseCommit { get; set; }

        [JsonProperty("merge_base_commit")]
        public CommitInfo MergeBaseCommit { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ahead_by")]
        public int AheadBy { get; set; }

        [JsonProperty("behind_by")]
        public int BehindBy { get; set; }

        [JsonProperty("total_commits")]
        public int TotalCommits { get; set; }

        [JsonProperty("commits")]
        public CommitInfo[] Commits { get; set; }

        [JsonProperty("files")]
        public DiffEntry[] Files { get; set; }
    }

    public class CommitInfo
    {
        [JsonProperty("url")]
        public string CommitUrl { get; set; }

        [JsonProperty("sha")]
        public string CommitSha { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("html_url")]
        public string HTMLUrl { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("commit")]
        public CommitInfoCommitType Commit { get; set; }

        [JsonProperty("author")]
        public UserDetailsModel Author { get; set; }

        [JsonProperty("committer")]
        public UserDetailsModel Committer { get; set; }

        [JsonProperty("parents")]
        public CommitInfoParentsTypeItem[] Parents { get; set; }

        [JsonProperty("stats")]
        public CommitInfoStatsType Stats { get; set; }

        [JsonProperty("files")]
        public DiffEntry[] Files { get; set; }
    }

    public class CommitInfoCommitType
    {
        [JsonProperty("url")]
        public string CommitUrl { get; set; }

        [JsonProperty("author")]
        public GitUser Author { get; set; }

        [JsonProperty("committer")]
        public GitUser Committer { get; set; }

        [JsonProperty("message")]
        public string CommitMessage { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("tree")]
        public CommitInfoCommitTypeTreeType Tree { get; set; }

        [JsonProperty("verification")]
        public Verification Verification { get; set; }
    }

    public class GitUser
    {
        [JsonProperty("name")]
        public string GitUserName { get; set; }

        [JsonProperty("email")]
        public string GitUserEmail { get; set; }

        [JsonProperty("date")]
        public string TimestampOfCommit { get; set; }
    }

    public class CommitInfoCommitTypeTreeType
    {
        [JsonProperty("sha")]
        public string CommitSha { get; set; }

        [JsonProperty("url")]
        public string CommitUrl { get; set; }
    }

    public class Verification
    {
        [JsonProperty("verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("reason")]
        public string VerificationReason { get; set; }

        [JsonProperty("payload")]
        public string SignedValue { get; set; }

        [JsonProperty("signature")]
        public string CommitSignature { get; set; }
    }

    public class CommitInfoParentsTypeItem
    {
        [JsonProperty("sha")]
        public string ParentSha { get; set; }

        [JsonProperty("url")]
        public string ParentBranchUrl { get; set; }

        [JsonProperty("html_url")]
        public string ParentBranchHTMLUrl { get; set; }
    }

    public class CommitInfoStatsType
    {
        [JsonProperty("additions")]
        public int Additions { get; set; }

        [JsonProperty("deletions")]
        public int Deletions { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DiffEntry
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("additions")]
        public int Additions { get; set; }

        [JsonProperty("deletions")]
        public int Deletions { get; set; }

        [JsonProperty("changes")]
        public int Changes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("raw_url")]
        public string RawUrl { get; set; }

        [JsonProperty("blob_url")]
        public string BlobUrl { get; set; }

        [JsonProperty("patch")]
        public string Patch { get; set; }

        [JsonProperty("sha")]
        public string ShaOfTheChange { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        [JsonProperty("previous_filename")]
        public string PreviousFileName { get; set; }
    }

    public class IssueUpdateInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_reason")]
        public string ChangeReason { get; set; }

        [JsonProperty("milestone")]
        public string Milestones { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }
    }

    public class MilestoneUpdateInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("description")]
        public string Milestones { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }
    }

    public class QueryInput
    {
        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class MultipleSearchFetchModel
    {
        [JsonProperty("body")]
        public JToken[] Body { get; set; }
    }

    public class CreateOrUpdateFileBodyInput
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommitMessage { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentBase64 { get; set; }

        [JsonProperty("sha")]
        public string SHA { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("html_url")]
        public string HTMLURL { get; set; }

        [JsonProperty("state")]
        public TaskObjectStateType State { get; set; }

        [JsonProperty("custom_agent")]
        public CustomAgent CustomAgent { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("session_count")]
        public int SessionCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskObjectStateType
    {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "waiting_for_user")]
        WaitingForUser,
        [EnumMember(Value = "timed_out")]
        TimedOut,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class CustomAgent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class StartTaskBodyInput
    {
        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("custom_agent")]
        public string CustomAgent { get; set; }

        [JsonProperty("base_ref")]
        public string BaseRef { get; set; }

        [JsonProperty("create_pull_request")]
        public bool? CreatePullRequest { get; set; }
    }

    public class TaskListResponse
    {
        [JsonProperty("tasks")]
        public TaskObject[] Tasks { get; set; }

        [JsonProperty("total_active_count")]
        public int TotalActiveCount { get; set; }

        [JsonProperty("total_archived_count")]
        public int TotalArchivedCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StateInput
    {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "waiting_for_user")]
        WaitingForUser,
        [EnumMember(Value = "timed_out")]
        TimedOut,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DirectionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("config")]
        public WebhookCreationResponseConfigType Config { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("test_url")]
        public string TestUrl { get; set; }

        [JsonProperty("ping_url")]
        public string PingUrl { get; set; }

        [JsonProperty("last_response")]
        public WebhookCreationResponseLastResponseType LastResponse { get; set; }
    }

    public class WebhookCreationResponseConfigType
    {
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class WebhookCreationResponseLastResponseType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RequestBodyOfWebhookInput
    {
        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool StateOfTheTrigger { get; set; } = true;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NameOfTheTrigger { get; set; } = "web";

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestBodyOfWebhookInputConfigType Config { get; set; } = new RequestBodyOfWebhookInputConfigType();

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] WebhookEventsToListenOn { get; set; } = new string[]
        {
            "pull_request"
        };
    }

    public class RequestBodyOfWebhookInputConfigType
    {
        [JsonProperty("content_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string DescriptionOfRepo { get; set; } = "json";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrlForTrigger { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Githubenterprise;

    public partial class WorkflowManagedActions
    {
        public GithubenterpriseActions Githubenterprise(string connectionId) => new GithubenterpriseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GithubenterpriseTriggers Githubenterprise(string connectionId) => new GithubenterpriseTriggers(connectionId);
    }
}