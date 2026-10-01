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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<ProjectResponse> CreateProject([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<int> namespaceId = null, [WorkflowExpression] Func<bool> initializeWithReadme = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (namespaceId != null)
                    callPayload.Queries["namespace_id"] = SourceExpressionConverter.ConvertO(namespaceId);
                callPayload.Queries["initialize_with_readme"] = Convert.ToString(true);
                if (initializeWithReadme != null)
                    callPayload.Queries["initialize_with_readme"] = SourceExpressionConverter.ConvertO(initializeWithReadme);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<ProjectResponse> ForkProject([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> path = null, [WorkflowExpression] Func<string> name = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/fork", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (path != null)
                    callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CompareResponse> CompareRepo([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> from, [WorkflowExpression] Func<string> to, [WorkflowExpression] Func<int> fromProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/repository/compare", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (fromProjectId != null)
                    callPayload.Queries["from_project_id"] = SourceExpressionConverter.ConvertO(fromProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<CompareResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<BranchResponse> CreateBranch([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> branch, [WorkflowExpression] Func<string> @ref)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/repository/branches", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["branch"] = SourceExpressionConverter.ConvertO(branch);
                callPayload.Queries["ref"] = SourceExpressionConverter.ConvertO(@ref);
                return callPayload;
            }

            return new ApiConnectionAction<BranchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CommitResponse> CreateCommit([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> branch, [WorkflowExpression] Func<string> commitMessage)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/repository/commits", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["branch"] = SourceExpressionConverter.ConvertO(branch);
                callPayload.Queries["commit_message"] = SourceExpressionConverter.ConvertO(commitMessage);
                var actions = new JObject();
                var actionspropCount = 0;
                if (actionspropCount > 0)
                {
                    callPayload.Body = actions;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse> MergeRequest([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> sourceBranch, [WorkflowExpression] Func<string> targetBranch, [WorkflowExpression] Func<string> title)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/merge_requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_branch"] = SourceExpressionConverter.ConvertO(sourceBranch);
                callPayload.Queries["target_branch"] = SourceExpressionConverter.ConvertO(targetBranch);
                callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                return callPayload;
            }

            return new ApiConnectionAction<MergeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse> MergeMergeRequest([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> mergeRequestIid, [WorkflowExpression] Func<string> mergeCommitMessage = null, [WorkflowExpression] Func<bool> squash = null, [WorkflowExpression] Func<bool> shouldRemoveSourceBranch = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/merge_requests/{1}/merge", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(mergeRequestIid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mergeCommitMessage != null)
                    callPayload.Queries["merge_commit_message"] = SourceExpressionConverter.ConvertO(mergeCommitMessage);
                callPayload.Queries["squash"] = Convert.ToString(true);
                if (squash != null)
                    callPayload.Queries["squash"] = SourceExpressionConverter.ConvertO(squash);
                callPayload.Queries["should_remove_source_branch"] = Convert.ToString(true);
                if (shouldRemoveSourceBranch != null)
                    callPayload.Queries["should_remove_source_branch"] = SourceExpressionConverter.ConvertO(shouldRemoveSourceBranch);
                return callPayload;
            }

            return new ApiConnectionAction<MergeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<MergeResponse> UpdateMergeRequest([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> mergeRequestIid, [WorkflowExpression] Func<string> stateEvent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/merge_requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(mergeRequestIid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stateEvent != null)
                    callPayload.Queries["state_event"] = SourceExpressionConverter.ConvertO(stateEvent);
                return callPayload;
            }

            return new ApiConnectionAction<MergeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<GetFileResponse> GetFile([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> filePath, [WorkflowExpression] Func<string> @ref)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/repository/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filePath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ref"] = SourceExpressionConverter.ConvertO(@ref);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<CreateTriggerResponse> CreateTrigger([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> description)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/triggers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                return callPayload;
            }

            return new ApiConnectionAction<CreateTriggerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<TriggerPipelineResponse> TriggerPipeline([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> @ref)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/trigger/pipeline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Queries["ref"] = SourceExpressionConverter.ConvertO(@ref);
                return callPayload;
            }

            return new ApiConnectionAction<TriggerPipelineResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gitlabip")]
        public IBodyWorkflowAction<EnableRunnerResponse> EnableRunner([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> runnerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/runners", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["runner_id"] = SourceExpressionConverter.ConvertO(runnerId);
                return callPayload;
            }

            return new ApiConnectionAction<EnableRunnerResponse>(BuildSourceInput);
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