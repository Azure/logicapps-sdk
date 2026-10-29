//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gitlabip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GitlabipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<VersionResponse, ApiConnectionActionConfiguration> GetVersion()
        {
            return new DeferredBodyAction<VersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<ProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> name, Expression<Func<int>> namespaceId = null, Expression<Func<bool>> initializeWithReadme = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_namespaceId = WorkflowExpression.Compile(namespaceId, nameof(namespaceId), required: false);
            var __workflow_initializeWithReadme = WorkflowExpression.Compile(initializeWithReadme, nameof(initializeWithReadme), required: false);
            return new DeferredBodyAction<ProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_namespaceId != null)
                    callPayload.Queries["namespace_id"] = ExpressionConverter.Convert(__workflow_namespaceId);
                callPayload.Queries["initialize_with_readme"] = Convert.ToString(true);
                if (__workflow_initializeWithReadme != null)
                    callPayload.Queries["initialize_with_readme"] = ExpressionConverter.Convert(__workflow_initializeWithReadme);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<ProjectResponse, ApiConnectionActionConfiguration> ForkProject(Expression<Func<int>> id, Expression<Func<string>> path = null, Expression<Func<string>> name = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredBodyAction<ProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/fork", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<ProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CompareResponse, ApiConnectionActionConfiguration> CompareRepo(Expression<Func<int>> id, Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<int>> fromProjectId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: true);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_fromProjectId = WorkflowExpression.Compile(fromProjectId, nameof(fromProjectId), required: false);
            return new DeferredBodyAction<CompareResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/repository/compare", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_fromProjectId != null)
                    callPayload.Queries["from_project_id"] = ExpressionConverter.Convert(__workflow_fromProjectId);
                return new ApiConnectionAction<CompareResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<BranchResponse, ApiConnectionActionConfiguration> CreateBranch(Expression<Func<int>> id, Expression<Func<string>> branch, Expression<Func<string>> @ref)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_branch = WorkflowExpression.Compile(branch, nameof(branch), required: true);
            var __workflow_ref = WorkflowExpression.Compile(@ref, nameof(@ref), required: true);
            return new DeferredBodyAction<BranchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/repository/branches", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["branch"] = ExpressionConverter.Convert(__workflow_branch);
                callPayload.Queries["ref"] = ExpressionConverter.Convert(__workflow_ref);
                return new ApiConnectionAction<BranchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CommitResponse, ApiConnectionActionConfiguration> CreateCommit(Expression<Func<int>> id, Expression<Func<string>> branch, Expression<Func<string>> commitMessage)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_branch = WorkflowExpression.Compile(branch, nameof(branch), required: true);
            var __workflow_commitMessage = WorkflowExpression.Compile(commitMessage, nameof(commitMessage), required: true);
            return new DeferredBodyAction<CommitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/repository/commits", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["branch"] = ExpressionConverter.Convert(__workflow_branch);
                callPayload.Queries["commit_message"] = ExpressionConverter.Convert(__workflow_commitMessage);
                var actions = new JObject();
                var actionspropCount = 0;
                if (actionspropCount > 0)
                {
                    callPayload.Body = actions;
                }

                return new ApiConnectionAction<CommitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse, ApiConnectionActionConfiguration> MergeRequest(Expression<Func<int>> id, Expression<Func<string>> sourceBranch, Expression<Func<string>> targetBranch, Expression<Func<string>> title)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_sourceBranch = WorkflowExpression.Compile(sourceBranch, nameof(sourceBranch), required: true);
            var __workflow_targetBranch = WorkflowExpression.Compile(targetBranch, nameof(targetBranch), required: true);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: true);
            return new DeferredBodyAction<MergeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/merge_requests", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_branch"] = ExpressionConverter.Convert(__workflow_sourceBranch);
                callPayload.Queries["target_branch"] = ExpressionConverter.Convert(__workflow_targetBranch);
                callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                return new ApiConnectionAction<MergeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse, ApiConnectionActionConfiguration> MergeMergeRequest(Expression<Func<int>> id, Expression<Func<int>> mergeRequestIid, Expression<Func<string>> mergeCommitMessage = null, Expression<Func<bool>> squash = null, Expression<Func<bool>> shouldRemoveSourceBranch = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mergeRequestIid = WorkflowExpression.Compile(mergeRequestIid, nameof(mergeRequestIid), required: true);
            var __workflow_mergeCommitMessage = WorkflowExpression.Compile(mergeCommitMessage, nameof(mergeCommitMessage), required: false);
            var __workflow_squash = WorkflowExpression.Compile(squash, nameof(squash), required: false);
            var __workflow_shouldRemoveSourceBranch = WorkflowExpression.Compile(shouldRemoveSourceBranch, nameof(shouldRemoveSourceBranch), required: false);
            return new DeferredBodyAction<MergeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/merge_requests/{1}/merge", __workflow_id.WithUrlEncoding(1), __workflow_mergeRequestIid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mergeCommitMessage != null)
                    callPayload.Queries["merge_commit_message"] = ExpressionConverter.Convert(__workflow_mergeCommitMessage);
                callPayload.Queries["squash"] = Convert.ToString(true);
                if (__workflow_squash != null)
                    callPayload.Queries["squash"] = ExpressionConverter.Convert(__workflow_squash);
                callPayload.Queries["should_remove_source_branch"] = Convert.ToString(true);
                if (__workflow_shouldRemoveSourceBranch != null)
                    callPayload.Queries["should_remove_source_branch"] = ExpressionConverter.Convert(__workflow_shouldRemoveSourceBranch);
                return new ApiConnectionAction<MergeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse, ApiConnectionActionConfiguration> UpdateMergeRequest(Expression<Func<int>> id, Expression<Func<int>> mergeRequestIid, Expression<Func<string>> stateEvent = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mergeRequestIid = WorkflowExpression.Compile(mergeRequestIid, nameof(mergeRequestIid), required: true);
            var __workflow_stateEvent = WorkflowExpression.Compile(stateEvent, nameof(stateEvent), required: false);
            return new DeferredBodyAction<MergeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/merge_requests/{1}", __workflow_id.WithUrlEncoding(1), __workflow_mergeRequestIid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stateEvent != null)
                    callPayload.Queries["state_event"] = ExpressionConverter.Convert(__workflow_stateEvent);
                return new ApiConnectionAction<MergeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<GetFileResponse, ApiConnectionActionConfiguration> GetFile(Expression<Func<int>> id, Expression<Func<string>> filePath, Expression<Func<string>> @ref)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_filePath = WorkflowExpression.Compile(filePath, nameof(filePath), required: true);
            var __workflow_ref = WorkflowExpression.Compile(@ref, nameof(@ref), required: true);
            return new DeferredBodyAction<GetFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/repository/files/{1}", __workflow_id.WithUrlEncoding(1), __workflow_filePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ref"] = ExpressionConverter.Convert(__workflow_ref);
                return new ApiConnectionAction<GetFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CreateTriggerResponse, ApiConnectionActionConfiguration> CreateTrigger(Expression<Func<int>> id, Expression<Func<string>> description)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: true);
            return new DeferredBodyAction<CreateTriggerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/triggers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                return new ApiConnectionAction<CreateTriggerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<TriggerPipelineResponse, ApiConnectionActionConfiguration> TriggerPipeline(Expression<Func<int>> id, Expression<Func<string>> token, Expression<Func<string>> @ref)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_ref = WorkflowExpression.Compile(@ref, nameof(@ref), required: true);
            return new DeferredBodyAction<TriggerPipelineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/trigger/pipeline", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Queries["ref"] = ExpressionConverter.Convert(__workflow_ref);
                return new ApiConnectionAction<TriggerPipelineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<EnableRunnerResponse, ApiConnectionActionConfiguration> EnableRunner(Expression<Func<int>> id, Expression<Func<int>> runnerId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_runnerId = WorkflowExpression.Compile(runnerId, nameof(runnerId), required: true);
            return new DeferredBodyAction<EnableRunnerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/runners", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["runner_id"] = ExpressionConverter.Convert(__workflow_runnerId);
                return new ApiConnectionAction<EnableRunnerResponse>(callPayload);
            });
        }
    }

    public class GitlabipTriggers([ConnectionName] string connectionId)
    {
    }

    public class VersionResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class StatusDetails
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }
    }

    public class Messages
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ProjectResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class CompareResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class BranchResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class CommitResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class MergeResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetFileResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class CreateTriggerResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class TriggerPipelineResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class EnableRunnerResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gitlabip;

    public partial class WorkflowManagedActions
    {
        public GitlabipActions Gitlabip(string connectionId) => new GitlabipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GitlabipTriggers Gitlabip(string connectionId) => new GitlabipTriggers(connectionId);
    }
}