//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gitlabip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GitlabipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<VersionResponse> GetVersion()
        {
            var apiCallPath = "/version";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<ProjectResponse> CreateProject(Expression<Func<string>> name, Expression<Func<int>> namespaceId = null, Expression<Func<bool>> initializeWithReadme = null)
        {
            var apiCallPath = "/projects";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (namespaceId != null)
                callPayload.Queries["namespace_id"] = ExpressionConverter.Convert(namespaceId);
            callPayload.Queries["initialize_with_readme"] = Convert.ToString(true);
            if (initializeWithReadme != null)
                callPayload.Queries["initialize_with_readme"] = ExpressionConverter.Convert(initializeWithReadme);
            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<ProjectResponse> ForkProject(Expression<Func<int>> id, Expression<Func<string>> path = null, Expression<Func<string>> name = null)
        {
            var apiCallPath = String.Format("/projects/{0}/fork", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (path != null)
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CompareResponse> CompareRepo(Expression<Func<int>> id, Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<int>> fromProjectId = null)
        {
            var apiCallPath = String.Format("/projects/{0}/repository/compare", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            if (fromProjectId != null)
                callPayload.Queries["from_project_id"] = ExpressionConverter.Convert(fromProjectId);
            return new ApiConnectionAction<CompareResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<BranchResponse> CreateBranch(Expression<Func<int>> id, Expression<Func<string>> branch, Expression<Func<string>> @ref)
        {
            var apiCallPath = String.Format("/projects/{0}/repository/branches", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["branch"] = ExpressionConverter.Convert(branch);
            callPayload.Queries["ref"] = ExpressionConverter.Convert(@ref);
            return new ApiConnectionAction<BranchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CommitResponse> CreateCommit(Expression<Func<int>> id, Expression<Func<string>> branch, Expression<Func<string>> commitMessage)
        {
            var apiCallPath = String.Format("/projects/{0}/repository/commits", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["branch"] = ExpressionConverter.Convert(branch);
            callPayload.Queries["commit_message"] = ExpressionConverter.Convert(commitMessage);
            var actions = new JObject();
            var actionspropCount = 0;
            if (actionspropCount > 0)
            {
                callPayload.Body = actions;
            }

            return new ApiConnectionAction<CommitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse> MergeRequest(Expression<Func<int>> id, Expression<Func<string>> sourceBranch, Expression<Func<string>> targetBranch, Expression<Func<string>> title)
        {
            var apiCallPath = String.Format("/projects/{0}/merge_requests", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source_branch"] = ExpressionConverter.Convert(sourceBranch);
            callPayload.Queries["target_branch"] = ExpressionConverter.Convert(targetBranch);
            callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            return new ApiConnectionAction<MergeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse> MergeMergeRequest(Expression<Func<int>> id, Expression<Func<int>> mergeRequestIid, Expression<Func<string>> mergeCommitMessage = null, Expression<Func<bool>> squash = null, Expression<Func<bool>> shouldRemoveSourceBranch = null)
        {
            var apiCallPath = String.Format("/projects/{0}/merge_requests/{1}/merge", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(mergeRequestIid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mergeCommitMessage != null)
                callPayload.Queries["merge_commit_message"] = ExpressionConverter.Convert(mergeCommitMessage);
            callPayload.Queries["squash"] = Convert.ToString(true);
            if (squash != null)
                callPayload.Queries["squash"] = ExpressionConverter.Convert(squash);
            callPayload.Queries["should_remove_source_branch"] = Convert.ToString(true);
            if (shouldRemoveSourceBranch != null)
                callPayload.Queries["should_remove_source_branch"] = ExpressionConverter.Convert(shouldRemoveSourceBranch);
            return new ApiConnectionAction<MergeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse> UpdateMergeRequest(Expression<Func<int>> id, Expression<Func<int>> mergeRequestIid, Expression<Func<string>> stateEvent = null)
        {
            var apiCallPath = String.Format("/projects/{0}/merge_requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(mergeRequestIid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stateEvent != null)
                callPayload.Queries["state_event"] = ExpressionConverter.Convert(stateEvent);
            return new ApiConnectionAction<MergeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<GetFileResponse> GetFile(Expression<Func<int>> id, Expression<Func<string>> filePath, Expression<Func<string>> @ref)
        {
            var apiCallPath = String.Format("/projects/{0}/repository/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(filePath, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ref"] = ExpressionConverter.Convert(@ref);
            return new ApiConnectionAction<GetFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CreateTriggerResponse> CreateTrigger(Expression<Func<int>> id, Expression<Func<string>> description)
        {
            var apiCallPath = String.Format("/projects/{0}/triggers", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["description"] = ExpressionConverter.Convert(description);
            return new ApiConnectionAction<CreateTriggerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<TriggerPipelineResponse> TriggerPipeline(Expression<Func<int>> id, Expression<Func<string>> token, Expression<Func<string>> @ref)
        {
            var apiCallPath = String.Format("/projects/{0}/trigger/pipeline", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = ExpressionConverter.Convert(token);
            callPayload.Queries["ref"] = ExpressionConverter.Convert(@ref);
            return new ApiConnectionAction<TriggerPipelineResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<EnableRunnerResponse> EnableRunner(Expression<Func<int>> id, Expression<Func<int>> runnerId)
        {
            var apiCallPath = String.Format("/projects/{0}/runners", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["runner_id"] = ExpressionConverter.Convert(runnerId);
            return new ApiConnectionAction<EnableRunnerResponse>(callPayload);
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