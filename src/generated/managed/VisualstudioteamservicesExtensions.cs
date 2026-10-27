//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Visualstudioteamservices
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VisualstudioteamservicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemSearchResponse, ApiConnectionActionConfiguration> SearchWorkItemsAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<SearchWorkItemsAsyncInput>> searchRequest)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_searchRequest = WorkflowExpression.Compile(searchRequest, nameof(searchRequest), required: true);
            return new DeferredBodyAction<WorkItemSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_apis/search/workitemsearchresults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchRequest);
                return new ApiConnectionAction<WorkItemSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<BuildResult, ApiConnectionActionConfiguration> GetBuildAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> buildId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_buildId = WorkflowExpression.Compile(buildId, nameof(buildId), required: true);
            return new DeferredBodyAction<BuildResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/builds/{1}", __workflow_project.WithUrlEncoding(1), __workflow_buildId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<BuildResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Timeline, ApiConnectionActionConfiguration> GetBuildTimelineAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> buildId, Expression<Func<string>> timelineId = null, Expression<Func<int>> changeId = null, Expression<Func<string>> planId = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_buildId = WorkflowExpression.Compile(buildId, nameof(buildId), required: true);
            var __workflow_timelineId = WorkflowExpression.Compile(timelineId, nameof(timelineId), required: false);
            var __workflow_changeId = WorkflowExpression.Compile(changeId, nameof(changeId), required: false);
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: false);
            return new DeferredBodyAction<Timeline, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/builds/{1}/timeline", __workflow_project.WithUrlEncoding(1), __workflow_buildId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_timelineId != null)
                    callPayload.Queries["timelineId"] = ExpressionConverter.Convert(__workflow_timelineId);
                if (__workflow_changeId != null)
                    callPayload.Queries["changeId"] = ExpressionConverter.Convert(__workflow_changeId);
                if (__workflow_planId != null)
                    callPayload.Queries["planId"] = ExpressionConverter.Convert(__workflow_planId);
                return new ApiConnectionAction<Timeline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListAccount, ApiConnectionActionConfiguration> ListAccounts()
        {
            return new DeferredBodyAction<VstsListAccount, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_apis/Accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VstsListAccount>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Profile, ApiConnectionActionConfiguration> GetProfile(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Profile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/profile/profiles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Profile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListTeamSettingsIteration, ApiConnectionActionConfiguration> ListIterations(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: true);
            return new DeferredBodyAction<VstsListTeamSettingsIteration, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/iterations", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                return new ApiConnectionAction<VstsListTeamSettingsIteration>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListGitRef, ApiConnectionActionConfiguration> ListBuildBranchesAsync(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListGitRef, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/branches", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListGitRef>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListBuildResult, ApiConnectionActionConfiguration> ListBuilds(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> definitions = null, Expression<Func<string>> buildNumber = null, Expression<Func<string>> branchName = null, Expression<Func<resultFilterInput>> resultFilter = null, Expression<Func<statusFilterInput>> statusFilter = null, Expression<Func<reasonFilterInput>> reasonFilter = null, Expression<Func<string>> requestedFor = null, Expression<Func<string>> minTime = null, Expression<Func<string>> maxTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_definitions = WorkflowExpression.Compile(definitions, nameof(definitions), required: false);
            var __workflow_buildNumber = WorkflowExpression.Compile(buildNumber, nameof(buildNumber), required: false);
            var __workflow_branchName = WorkflowExpression.Compile(branchName, nameof(branchName), required: false);
            var __workflow_resultFilter = WorkflowExpression.Compile(resultFilter, nameof(resultFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_reasonFilter = WorkflowExpression.Compile(reasonFilter, nameof(reasonFilter), required: false);
            var __workflow_requestedFor = WorkflowExpression.Compile(requestedFor, nameof(requestedFor), required: false);
            var __workflow_minTime = WorkflowExpression.Compile(minTime, nameof(minTime), required: false);
            var __workflow_maxTime = WorkflowExpression.Compile(maxTime, nameof(maxTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<VstsListBuildResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/builds", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_definitions != null)
                    callPayload.Queries["definitions"] = ExpressionConverter.Convert(__workflow_definitions);
                if (__workflow_buildNumber != null)
                    callPayload.Queries["buildNumber"] = ExpressionConverter.Convert(__workflow_buildNumber);
                if (__workflow_branchName != null)
                    callPayload.Queries["branchName"] = ExpressionConverter.Convert(__workflow_branchName);
                if (__workflow_resultFilter != null)
                    callPayload.Queries["resultFilter"] = ExpressionConverter.Convert(__workflow_resultFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_reasonFilter != null)
                    callPayload.Queries["reasonFilter"] = ExpressionConverter.Convert(__workflow_reasonFilter);
                if (__workflow_requestedFor != null)
                    callPayload.Queries["requestedFor"] = ExpressionConverter.Convert(__workflow_requestedFor);
                if (__workflow_minTime != null)
                    callPayload.Queries["minTime"] = ExpressionConverter.Convert(__workflow_minTime);
                if (__workflow_maxTime != null)
                    callPayload.Queries["maxTime"] = ExpressionConverter.Convert(__workflow_maxTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<VstsListBuildResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<BuildResult, ApiConnectionActionConfiguration> QueueNewBuild(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> buildDefId, Expression<Func<QueueNewBuildInput>> buildDetails = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_buildDefId = WorkflowExpression.Compile(buildDefId, nameof(buildDefId), required: true);
            var __workflow_buildDetails = WorkflowExpression.Compile(buildDetails, nameof(buildDetails), required: false);
            return new DeferredBodyAction<BuildResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/builds", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["buildDefId"] = ExpressionConverter.Convert(__workflow_buildDefId);
                if (__workflow_buildDetails != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_buildDetails);
                return new ApiConnectionAction<BuildResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListTeamMember, ApiConnectionActionConfiguration> ListBuildRequestersAsync(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListTeamMember, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/requesters", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListTeamMember>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListGitRepository, ApiConnectionActionConfiguration> ListGitRepositories(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListGitRepository, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/git/repositories", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListGitRepository>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListProject, ApiConnectionActionConfiguration> ListProjects(Expression<Func<string>> account)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            return new DeferredBodyAction<VstsListProject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_apis/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListReleaseDefinition, ApiConnectionActionConfiguration> ListReleaseDefinitions(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListReleaseDefinition, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/definitions", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListReleaseDefinition>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Release, ApiConnectionActionConfiguration> CreateRelease(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> releaseDefId, Expression<Func<CreateReleaseInput>> releaseStartMetadata)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_releaseDefId = WorkflowExpression.Compile(releaseDefId, nameof(releaseDefId), required: true);
            var __workflow_releaseStartMetadata = WorkflowExpression.Compile(releaseStartMetadata, nameof(releaseStartMetadata), required: true);
            return new DeferredBodyAction<Release, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/releases", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["releaseDefId"] = ExpressionConverter.Convert(__workflow_releaseDefId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_releaseStartMetadata);
                return new ApiConnectionAction<Release>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> account, Expression<Func<HttpRequestInput>> parameters)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListWorkItemField, ApiConnectionActionConfiguration> ListWorkItemFieldsAsync(Expression<Func<string>> account, Expression<Func<string>> project = null, Expression<Func<expandInput>> expand = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<VstsListWorkItemField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_apis/wit/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_project != null)
                    callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<VstsListWorkItemField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListWorkItemType, ApiConnectionActionConfiguration> ListWorkItemTypes(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListWorkItemType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_apis/wit/workitemtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<VstsListWorkItemType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<DynamicWorkItemResponse, ApiConnectionActionConfiguration> GetWorkItemDetails(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> typeName, Expression<Func<string>> id)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_typeName = WorkflowExpression.Compile(typeName, nameof(typeName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DynamicWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["typeName"] = ExpressionConverter.Convert(__workflow_typeName);
                return new ApiConnectionAction<DynamicWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse, ApiConnectionActionConfiguration> UpdateWorkItem(Expression<Func<string>> account, Expression<Func<string>> id, Expression<Func<UpdateWorkItemInput>> workItem, Expression<Func<string>> project = null, Expression<Func<string>> type = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_workItem = WorkflowExpression.Compile(workItem, nameof(workItem), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_project != null)
                    callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_workItem);
                return new ApiConnectionAction<PatchWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemDetailsV2Response, ApiConnectionActionConfiguration> GetWorkItemDetailsV2Async(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> typeName, Expression<Func<string>> id, Expression<Func<string>> asOf = null, Expression<Func<expandInput>> expand = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_typeName = WorkflowExpression.Compile(typeName, nameof(typeName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_asOf = WorkflowExpression.Compile(asOf, nameof(asOf), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<WorkItemDetailsV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/v2/workitems/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["typeName"] = ExpressionConverter.Convert(__workflow_typeName);
                if (__workflow_asOf != null)
                    callPayload.Queries["asOf"] = ExpressionConverter.Convert(__workflow_asOf);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<WorkItemDetailsV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse, ApiConnectionActionConfiguration> GetWorkItemChildren(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> id, Expression<Func<string>> workItemType = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_workItemType = WorkflowExpression.Compile(workItemType, nameof(workItemType), required: false);
            return new DeferredBodyAction<VstsListListWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/children", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["workItemType"] = Convert.ToString("");
                if (__workflow_workItemType != null)
                    callPayload.Queries["workItemType"] = ExpressionConverter.Convert(__workflow_workItemType);
                return new ApiConnectionAction<VstsListListWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemAttachmentResponse, ApiConnectionActionConfiguration> GetWorkItemAttachmentAsync(Expression<Func<string>> account, Expression<Func<string>> attachmentId, Expression<Func<string>> project = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<WorkItemAttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_project != null)
                    callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_fileName != null)
                    callPayload.Queries["fileName"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<WorkItemAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemCommentsResponse, ApiConnectionActionConfiguration> GetWorkItemCommentsAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> workItemId, Expression<Func<int>> top = null, Expression<Func<orderInput>> order = null, Expression<Func<bool>> includeDeleted = null, Expression<Func<expandInput>> expand = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_includeDeleted = WorkflowExpression.Compile(includeDeleted, nameof(includeDeleted), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<WorkItemCommentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/comments", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                callPayload.Queries["includeDeleted"] = Convert.ToString(false);
                if (__workflow_includeDeleted != null)
                    callPayload.Queries["includeDeleted"] = ExpressionConverter.Convert(__workflow_includeDeleted);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<WorkItemCommentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemComment, ApiConnectionActionConfiguration> CreateWorkItemCommentAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> workItemId, Expression<Func<CreateWorkItemCommentAsyncInput>> comment, Expression<Func<string>> type = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredBodyAction<WorkItemComment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/comments", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["format"] = Convert.ToString("markdown");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_comment);
                return new ApiConnectionAction<WorkItemComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse, ApiConnectionActionConfiguration> AddWorkItemLinkAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> type, Expression<Func<int>> workItemId, Expression<Func<AddWorkItemLinkAsyncInput>> linkRequest)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_linkRequest = WorkflowExpression.Compile(linkRequest, nameof(linkRequest), required: true);
            return new DeferredBodyAction<PatchWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/links", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_linkRequest);
                return new ApiConnectionAction<PatchWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse, ApiConnectionActionConfiguration> DeleteWorkItemLinkAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> type, Expression<Func<int>> workItemId, Expression<Func<DeleteWorkItemLinkAsyncInput>> linkRequest)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_linkRequest = WorkflowExpression.Compile(linkRequest, nameof(linkRequest), required: true);
            return new DeferredBodyAction<PatchWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/links/delete", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_linkRequest);
                return new ApiConnectionAction<PatchWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemComment, ApiConnectionActionConfiguration> UpdateWorkItemCommentAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> workItemId, Expression<Func<int>> commentId, Expression<Func<UpdateWorkItemCommentAsyncInput>> comment, Expression<Func<formatInput>> format = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredBodyAction<WorkItemComment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/comments/{1}", __workflow_workItemId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["format"] = Convert.ToString("markdown");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_comment);
                return new ApiConnectionAction<WorkItemComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkItemCommentAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> workItemId, Expression<Func<int>> commentId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/comments/{1}", __workflow_workItemId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem, ApiConnectionActionConfiguration> ListRootQueryFolders(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/queries", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem, ApiConnectionActionConfiguration> ListQueriesInFolder(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> folderPath)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/queriesInFolder", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse, ApiConnectionActionConfiguration> ListWorkItems(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> workItemIds, Expression<Func<string>> workItemType = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemIds = WorkflowExpression.Compile(workItemIds, nameof(workItemIds), required: true);
            var __workflow_workItemType = WorkflowExpression.Compile(workItemType, nameof(workItemType), required: false);
            return new DeferredBodyAction<VstsListListWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/wit/workitems", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["workItemIds"] = ExpressionConverter.Convert(__workflow_workItemIds);
                callPayload.Queries["workItemType"] = Convert.ToString("");
                if (__workflow_workItemType != null)
                    callPayload.Queries["workItemType"] = ExpressionConverter.Convert(__workflow_workItemType);
                return new ApiConnectionAction<VstsListListWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Pipeline, ApiConnectionActionConfiguration> ListPipelines(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<Pipeline, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/pipelines", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<Pipeline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Run, ApiConnectionActionConfiguration> ListPipelineRuns(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> pipelineId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_pipelineId = WorkflowExpression.Compile(pipelineId, nameof(pipelineId), required: true);
            return new DeferredBodyAction<Run, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/pipelines/{1}/runs", __workflow_project.WithUrlEncoding(1), __workflow_pipelineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<Run>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryResultWorkItemResponse, ApiConnectionActionConfiguration> GetQueryResults(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> queryId, Expression<Func<int>> workItemsCount = null, Expression<Func<bool>> throwIfQueryChanged = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_queryId = WorkflowExpression.Compile(queryId, nameof(queryId), required: true);
            var __workflow_workItemsCount = WorkflowExpression.Compile(workItemsCount, nameof(workItemsCount), required: false);
            var __workflow_throwIfQueryChanged = WorkflowExpression.Compile(throwIfQueryChanged, nameof(throwIfQueryChanged), required: false);
            return new DeferredBodyAction<VstsListQueryResultWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}/queryResults/{1}", __workflow_project.WithUrlEncoding(1), __workflow_queryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["workItemsCount"] = Convert.ToString(200);
                if (__workflow_workItemsCount != null)
                    callPayload.Queries["workItemsCount"] = ExpressionConverter.Convert(__workflow_workItemsCount);
                if (__workflow_throwIfQueryChanged != null)
                    callPayload.Queries["throwIfQueryChanged"] = ExpressionConverter.Convert(__workflow_throwIfQueryChanged);
                return new ApiConnectionAction<VstsListQueryResultWorkItemResponse>(callPayload);
            });
        }
    }

    public class VisualstudioteamservicesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<VstsListBuildResult, ApiConnectionTriggerConfiguration> OnBuildCompleted(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<resultFilterInput>> resultFilter = null, Expression<Func<string>> definitions = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_resultFilter = WorkflowExpression.Compile(resultFilter, nameof(resultFilter), required: false);
            var __workflow_definitions = WorkflowExpression.Compile(definitions, nameof(definitions), required: false);
            return new DeferredBodyTrigger<VstsListBuildResult, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/buildcompleted_trigger/{0}/_apis/build/builds", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_resultFilter != null)
                    callPayload.Queries["resultFilter"] = ExpressionConverter.Convert(__workflow_resultFilter);
                if (__workflow_definitions != null)
                    callPayload.Queries["definitions"] = ExpressionConverter.Convert(__workflow_definitions);
                return new ApiConnectionTrigger<VstsListBuildResult>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListGitPush, ApiConnectionTriggerConfiguration> OnGitPush(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repository, Expression<Func<string>> refName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repository = WorkflowExpression.Compile(repository, nameof(repository), required: true);
            var __workflow_refName = WorkflowExpression.Compile(refName, nameof(refName), required: false);
            return new DeferredBodyTrigger<VstsListGitPush, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gitpushed_trigger/{0}/_apis/git/repositories/{1}/pushes", __workflow_project.WithUrlEncoding(1), __workflow_repository.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_refName != null)
                    callPayload.Queries["refName"] = ExpressionConverter.Convert(__workflow_refName);
                return new ApiConnectionTrigger<VstsListGitPush>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListGitPullRequest, ApiConnectionTriggerConfiguration> OnGitPullCreated(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repository, Expression<Func<string>> sourceRefName = null, Expression<Func<string>> targetRefName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repository = WorkflowExpression.Compile(repository, nameof(repository), required: true);
            var __workflow_sourceRefName = WorkflowExpression.Compile(sourceRefName, nameof(sourceRefName), required: false);
            var __workflow_targetRefName = WorkflowExpression.Compile(targetRefName, nameof(targetRefName), required: false);
            return new DeferredBodyTrigger<VstsListGitPullRequest, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gitpullcreated_trigger/{0}/_apis/git/repositories/{1}/pullrequests", __workflow_project.WithUrlEncoding(1), __workflow_repository.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_sourceRefName != null)
                    callPayload.Queries["sourceRefName"] = ExpressionConverter.Convert(__workflow_sourceRefName);
                if (__workflow_targetRefName != null)
                    callPayload.Queries["targetRefName"] = ExpressionConverter.Convert(__workflow_targetRefName);
                return new ApiConnectionTrigger<VstsListGitPullRequest>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListGitPullRequest, ApiConnectionTriggerConfiguration> OnGitPullClosed(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repository, Expression<Func<string>> sourceRefName = null, Expression<Func<string>> targetRefName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repository = WorkflowExpression.Compile(repository, nameof(repository), required: true);
            var __workflow_sourceRefName = WorkflowExpression.Compile(sourceRefName, nameof(sourceRefName), required: false);
            var __workflow_targetRefName = WorkflowExpression.Compile(targetRefName, nameof(targetRefName), required: false);
            return new DeferredBodyTrigger<VstsListGitPullRequest, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gitpullclosed_trigger/{0}/_apis/git/repositories/{1}/pullrequests", __workflow_project.WithUrlEncoding(1), __workflow_repository.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_sourceRefName != null)
                    callPayload.Queries["sourceRefName"] = ExpressionConverter.Convert(__workflow_sourceRefName);
                if (__workflow_targetRefName != null)
                    callPayload.Queries["targetRefName"] = ExpressionConverter.Convert(__workflow_targetRefName);
                return new ApiConnectionTrigger<VstsListGitPullRequest>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListTfvcChangeset, ApiConnectionTriggerConfiguration> OnTfvcCheckIn(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> author = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_author = WorkflowExpression.Compile(author, nameof(author), required: false);
            return new DeferredBodyTrigger<VstsListTfvcChangeset, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/tfvccheckin_trigger/_apis/tfvc/changesets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                if (__workflow_author != null)
                    callPayload.Queries["author"] = ExpressionConverter.Convert(__workflow_author);
                return new ApiConnectionTrigger<VstsListTfvcChangeset>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration> OnWorkItemAssigned(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team, Expression<Func<string>> wiqlSystemAssignedTo, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: true);
            var __workflow_wiqlSystemAssignedTo = WorkflowExpression.Compile(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: true);
            var __workflow_wiqlSystemWorkItemType = WorkflowExpression.Compile(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_wiqlSystemAreaPath = WorkflowExpression.Compile(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = WorkflowExpression.Compile(areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = WorkflowExpression.Compile(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = WorkflowExpression.Compile(iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = WorkflowExpression.Compile(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/workitemassigned_trigger/{0}/_apis/wit/wiql", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(__workflow_wiqlSystemAssignedTo);
                if (__workflow_wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(__workflow_wiqlSystemWorkItemType);
                if (__workflow_wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (__workflow_areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(__workflow_areaPathComparison);
                if (__workflow_wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (__workflow_iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(__workflow_iterationPathComparison);
                if (__workflow_wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(__workflow_wiqlMicrosoftVSTSCommonPriority);
                if (__workflow_wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(__workflow_wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration> OnWorkItemClosed(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> wiqlSystemAssignedTo = null, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> closedState = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_wiqlSystemAssignedTo = WorkflowExpression.Compile(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            var __workflow_wiqlSystemWorkItemType = WorkflowExpression.Compile(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_closedState = WorkflowExpression.Compile(closedState, nameof(closedState), required: false);
            var __workflow_wiqlSystemAreaPath = WorkflowExpression.Compile(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = WorkflowExpression.Compile(areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = WorkflowExpression.Compile(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = WorkflowExpression.Compile(iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = WorkflowExpression.Compile(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/workitemclosed_trigger/{0}/_apis/wit/wiql", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                if (__workflow_wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(__workflow_wiqlSystemAssignedTo);
                callPayload.Queries["wiql__System_WorkItemType"] = Convert.ToString("Bug");
                if (__workflow_wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(__workflow_wiqlSystemWorkItemType);
                callPayload.Queries["closedState"] = Convert.ToString("Done, Closed, Completed, Inactive");
                if (__workflow_closedState != null)
                    callPayload.Queries["closedState"] = ExpressionConverter.Convert(__workflow_closedState);
                if (__workflow_wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (__workflow_areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(__workflow_areaPathComparison);
                if (__workflow_wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (__workflow_iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(__workflow_iterationPathComparison);
                if (__workflow_wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(__workflow_wiqlMicrosoftVSTSCommonPriority);
                if (__workflow_wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(__workflow_wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration> OnWorkItemCreated(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> wiqlSystemAssignedTo = null, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_wiqlSystemAssignedTo = WorkflowExpression.Compile(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            var __workflow_wiqlSystemWorkItemType = WorkflowExpression.Compile(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_wiqlSystemAreaPath = WorkflowExpression.Compile(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = WorkflowExpression.Compile(areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = WorkflowExpression.Compile(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = WorkflowExpression.Compile(iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = WorkflowExpression.Compile(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/workitemcreated_trigger/{0}/_apis/wit/wiql", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                if (__workflow_wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(__workflow_wiqlSystemAssignedTo);
                callPayload.Queries["wiql__System_WorkItemType"] = Convert.ToString("Bug");
                if (__workflow_wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(__workflow_wiqlSystemWorkItemType);
                if (__workflow_wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (__workflow_areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(__workflow_areaPathComparison);
                if (__workflow_wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (__workflow_iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(__workflow_iterationPathComparison);
                if (__workflow_wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(__workflow_wiqlMicrosoftVSTSCommonPriority);
                if (__workflow_wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(__workflow_wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration> OnWorkItemUpdated(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> wiqlSystemAssignedTo = null, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_team = WorkflowExpression.Compile(team, nameof(team), required: false);
            var __workflow_wiqlSystemAssignedTo = WorkflowExpression.Compile(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            var __workflow_wiqlSystemWorkItemType = WorkflowExpression.Compile(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_wiqlSystemAreaPath = WorkflowExpression.Compile(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = WorkflowExpression.Compile(areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = WorkflowExpression.Compile(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = WorkflowExpression.Compile(iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = WorkflowExpression.Compile(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/workitemupdated_trigger/{0}/_apis/wit/wiql", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                if (__workflow_wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(__workflow_wiqlSystemAssignedTo);
                if (__workflow_wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(__workflow_wiqlSystemWorkItemType);
                if (__workflow_wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (__workflow_areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(__workflow_areaPathComparison);
                if (__workflow_wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(__workflow_wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (__workflow_iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(__workflow_iterationPathComparison);
                if (__workflow_wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(__workflow_wiqlMicrosoftVSTSCommonPriority);
                if (__workflow_wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(__workflow_wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WorkItemSearchResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public WorkItemResult[] Results { get; set; }

        [JsonProperty("infoCode")]
        public int InfoCode { get; set; }

        [JsonProperty("facets")]
        public JToken Facets { get; set; }
    }

    public class WorkItemResult
    {
        [JsonProperty("project")]
        public SearchProject Project { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("hits")]
        public WorkItemHit[] Hits { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class SearchProject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class WorkItemHit
    {
        [JsonProperty("fieldReferenceName")]
        public string FieldReferenceName { get; set; }

        [JsonProperty("highlights")]
        public string[] Highlights { get; set; }
    }

    public class SearchWorkItemsAsyncInput
    {
        [JsonProperty("searchText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchText { get; set; }

        [JsonProperty("$skip")]
        public int? Skip { get; set; }

        [JsonProperty("$top")]
        public int? Top { get; set; }

        [JsonProperty("filters")]
        public JToken Filters { get; set; }

        [JsonProperty("includeFacets")]
        public bool? IncludeFacets { get; set; }

        [JsonProperty("$orderBy")]
        public SortOption[] OrderBy { get; set; }
    }

    public class SortOption
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }
    }

    public class BuildResult
    {
        [JsonProperty("id")]
        public int BuildId { get; set; }

        [JsonProperty("buildNumber")]
        public string BuildNumber { get; set; }

        [JsonProperty("sourceBranch")]
        public string SourceBranch { get; set; }

        [JsonProperty("sourceVersion")]
        public string SourceVersion { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("queueTime")]
        public string QueueTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("finishTime")]
        public string FinishTime { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("requestedFor")]
        public BuildRequestUser RequestedFor { get; set; }

        [JsonProperty("parameters")]
        public string Parameters { get; set; }

        [JsonProperty("definition")]
        public BuildResultDefinition Definition { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class BuildRequestUser
    {
        [JsonProperty("uniqueName")]
        public string RequestedFor { get; set; }
    }

    public class BuildResultDefinition
    {
        [JsonProperty("id")]
        public int BuildDefinitionId { get; set; }

        [JsonProperty("name")]
        public string BuildDefinitionName { get; set; }
    }

    public class Links
    {
        [JsonProperty("web")]
        public WebLinks Web { get; set; }
    }

    public class WebLinks
    {
        [JsonProperty("href")]
        public string HTMLLink { get; set; }
    }

    public class Timeline
    {
        [JsonProperty("id")]
        public string TimelineId { get; set; }

        [JsonProperty("changeId")]
        public int ChangeId { get; set; }

        [JsonProperty("lastChangedBy")]
        public string LastChangedBy { get; set; }

        [JsonProperty("lastChangedOn")]
        public string LastChangedOn { get; set; }

        [JsonProperty("records")]
        public TimelineRecord[] TimelineRecords { get; set; }
    }

    public class TimelineRecord
    {
        [JsonProperty("id")]
        public string RecordId { get; set; }

        [JsonProperty("changeId")]
        public int ChangeId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("finishTime")]
        public string FinishTime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("workerName")]
        public string WorkerName { get; set; }

        [JsonProperty("attempt")]
        public int Attempt { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("issues")]
        public TimelineIssue[] Issues { get; set; }

        [JsonProperty("log")]
        public TimelineLogReference Log { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("details")]
        public TimelineReference Details { get; set; }

        [JsonProperty("task")]
        public TimelineTask TaskObject { get; set; }

        [JsonProperty("previousAttempts")]
        public TimelineReference[] PreviousAttempts { get; set; }

        [JsonProperty("percentComplete")]
        public int PercentComplete { get; set; }

        [JsonProperty("currentOperation")]
        public string CurrentOperation { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class TimelineIssue
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("warningCode")]
        public string WarningCode { get; set; }
    }

    public class TimelineLogReference
    {
        [JsonProperty("id")]
        public int LogId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("lineCount")]
        public int LineCount { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class TimelineReference
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changeId")]
        public int ChangeId { get; set; }
    }

    public class TimelineTask
    {
        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class VstsListAccount
    {
        [JsonProperty("value")]
        public Account[] Value { get; set; }
    }

    public class Account
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountUri")]
        public string AccountURI { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("accountOwner")]
        public string AccountOwner { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }
    }

    public class Profile
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicAlias")]
        public string PublicAlias { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("coreRevision")]
        public int CoreRevision { get; set; }
    }

    public class VstsListTeamSettingsIteration
    {
        [JsonProperty("value")]
        public TeamSettingsIteration[] Value { get; set; }
    }

    public class TeamSettingsIteration
    {
        public TeamIterationAttributes Attributes { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        [JsonProperty("_links")]
        public JToken Links { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    public class TeamIterationAttributes
    {
        public string FinishDate { get; set; }
        public string StartDate { get; set; }
    }

    public class VstsListGitRef
    {
        [JsonProperty("value")]
        public GitRef[] Value { get; set; }
    }

    public class GitRef
    {
        [JsonProperty("objectId")]
        public string RefId { get; set; }

        [JsonProperty("name")]
        public string RefName { get; set; }
    }

    public class VstsListBuildResult
    {
        [JsonProperty("value")]
        public BuildResult[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum resultFilterInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "partiallySucceeded")]
        PartiallySucceeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "canceled")]
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusFilterInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "cancelling")]
        Cancelling,
        [EnumMember(Value = "postponed")]
        Postponed,
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "all")]
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum reasonFilterInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "individualCI")]
        IndividualCI,
        [EnumMember(Value = "batchedCI")]
        BatchedCI,
        [EnumMember(Value = "schedule")]
        Schedule,
        [EnumMember(Value = "scheduleForced")]
        ScheduleForced,
        [EnumMember(Value = "userCreated")]
        UserCreated,
        [EnumMember(Value = "validateShelveset")]
        ValidateShelveset,
        [EnumMember(Value = "checkInShelveset")]
        CheckInShelveset,
        [EnumMember(Value = "pullRequest")]
        PullRequest,
        [EnumMember(Value = "buildCompletion")]
        BuildCompletion,
        [EnumMember(Value = "triggered")]
        Triggered,
        [EnumMember(Value = "all")]
        All
    }

    public class QueueNewBuildInput
    {
        [JsonProperty("sourceBranch")]
        public string SourceBranch { get; set; }

        [JsonProperty("parameters")]
        public string Parameters { get; set; }
    }

    public class VstsListTeamMember
    {
        [JsonProperty("value")]
        public TeamMember[] Value { get; set; }
    }

    public class TeamMember
    {
        [JsonProperty("id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("url")]
        public string MemberURI { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageURI { get; set; }
    }

    public class VstsListGitRepository
    {
        [JsonProperty("value")]
        public GitRepository[] Value { get; set; }
    }

    public class GitRepository
    {
        [JsonProperty("id")]
        public string RepositoryId { get; set; }

        [JsonProperty("name")]
        public string RepositoryName { get; set; }

        [JsonProperty("url")]
        public string RepositoryBrowserURL { get; set; }

        [JsonProperty("remoteUrl")]
        public string RepositoryRemoteURL { get; set; }
    }

    public class VstsListProject
    {
        [JsonProperty("value")]
        public Project[] Value { get; set; }
    }

    public class Project
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("url")]
        public string ProjectURL { get; set; }
    }

    public class VstsListReleaseDefinition
    {
        [JsonProperty("value")]
        public ReleaseDefinition[] Value { get; set; }
    }

    public class ReleaseDefinition
    {
        public string Comment { get; set; }
        public string CreatedOn { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public IdentityRef ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string ReleaseNameFormat { get; set; }
        public int Revision { get; set; }
        public ReleaseDefinitionSourceType Source { get; set; }
        public string[] Tags { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    public class IdentityRef
    {
        public string DirectoryAlias { get; set; }
        public string DisplayName { get; set; }
        public string UniqueName { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseDefinitionSourceType
    {
        Undefined,
        RestApi,
        UserInterface,
        Ibiza,
        PortalExtensionApi
    }

    public class Release
    {
        public string Comment { get; set; }
        public IdentityRef CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool KeepForever { get; set; }

        [JsonProperty("LogsContainerUrl")]
        public string LogsContainerURL { get; set; }
        public IdentityRef ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string Name { get; set; }
        public ReleaseReasonType Reason { get; set; }
        public ReleaseDefinitionShallowReference ReleaseDefinition { get; set; }
        public ReleaseStatusType Status { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseReasonType
    {
        None,
        Manual,
        ContinuousIntegration,
        Schedule,
        IndividualCI,
        BatchedCI
    }

    public class ReleaseDefinitionShallowReference
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseStatusType
    {
        Undefined,
        Draft,
        Active,
        Abandoned
    }

    public class CreateReleaseInput
    {
        public string Description { get; set; }
        public bool? IsDraft { get; set; }
        public CreateReleaseInputReasonType? Reason { get; set; }

        [JsonProperty("Variables")]
        public ConfigurationVariable[] ReleaseVariables { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateReleaseInputReasonType
    {
        None,
        Manual,
        ContinuousIntegration,
        Schedule,
        IndividualCI,
        BatchedCI
    }

    public class ConfigurationVariable
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class HttpRequestInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public HttpRequestInputMethodType Method { get; set; } = HttpRequestInputMethodType.GET;

        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RelativeURI { get; set; }
        public JToken Headers { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsBase64")]
        public bool? BodyIsBase64 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HttpRequestInputMethodType
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE,
        OPTIONS
    }

    public class VstsListWorkItemField
    {
        [JsonProperty("value")]
        public WorkItemField[] Value { get; set; }
    }

    public class WorkItemField
    {
        public string Name { get; set; }
        public bool ReadOnly { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsPicklist { get; set; }
        public string ReferenceName { get; set; }
        public string Description { get; set; }
        public WorkItemFieldOperation[] SupportedOperations { get; set; }
        public WorkItemFieldTypeType Type { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    public class WorkItemFieldOperation
    {
        public string Name { get; set; }
        public string ReferenceName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkItemFieldTypeType
    {
        Boolean,
        DateTime,
        Double,
        [EnumMember(Value = "Guid")]
        Id,
        History,
        Html,
        Integer,
        PlainText,
        String,
        TreePath
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum expandInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "reactions")]
        Reactions,
        [EnumMember(Value = "renderedText")]
        RenderedText,
        [EnumMember(Value = "renderedTextOnly")]
        RenderedTextOnly,
        [EnumMember(Value = "all")]
        All
    }

    public class VstsListWorkItemType
    {
        [JsonProperty("value")]
        public WorkItemType[] Value { get; set; }
    }

    public class WorkItemType
    {
        public string Description { get; set; }
        public string Name { get; set; }

        [JsonProperty("XmlForm")]
        public string XMLForm { get; set; }

        [JsonProperty("FieldInstances")]
        public WorkItemTypeFieldInstance[] Fields { get; set; }

        [JsonProperty("icon")]
        public WorkItemTypeIconType Icon { get; set; }

        [JsonProperty("states")]
        public WorkItemStateColor[] States { get; set; }
    }

    public class WorkItemTypeFieldInstance
    {
        public bool AlwaysRequired { get; set; }
        public string ReferenceName { get; set; }
        public string Name { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    public class WorkItemTypeIconType
    {
        [JsonProperty("id")]
        public string IconId { get; set; }

        [JsonProperty("url")]
        public string IconUrl { get; set; }
    }

    public class WorkItemStateColor
    {
        [JsonProperty("category")]
        public string CategoryOfState { get; set; }

        [JsonProperty("color")]
        public string ColorValue { get; set; }

        [JsonProperty("name")]
        public string StateName { get; set; }
    }

    public class DynamicWorkItemResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rev")]
        public int RevisionCount { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("fields")]
        public DynamicWorkItemResponseFieldsType Fields { get; set; }
    }

    public class DynamicWorkItemResponseFieldsType
    {
        [JsonProperty("System_Id")]
        public int Id { get; set; }

        [JsonProperty("System_AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty("System_TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty("System_IterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty("System_WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("System_State")]
        public string State { get; set; }

        [JsonProperty("System_Reason")]
        public string Reason { get; set; }

        [JsonProperty("System_CreatedDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("System_CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("System_ChangedDate")]
        public string ChangedDate { get; set; }

        [JsonProperty("System_ChangedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("System_Title")]
        public string Title { get; set; }

        [JsonProperty("System_Description")]
        public string Description { get; set; }

        [JsonProperty("System_Tags")]
        public string Tags { get; set; }

        [JsonProperty("System_AssignedTo")]
        public string AssignedTo { get; set; }
    }

    public class PatchWorkItemResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rev")]
        public int RevisionCount { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("fields")]
        public PatchWorkItemResponseFieldsType Fields { get; set; }
    }

    public class PatchWorkItemResponseFieldsType
    {
        [JsonProperty("System_Id")]
        public int Id { get; set; }

        [JsonProperty("System_AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty("System_TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty("System_IterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty("System_WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("System_State")]
        public string State { get; set; }

        [JsonProperty("System_Reason")]
        public string Reason { get; set; }

        [JsonProperty("System_CreatedDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("System_CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("System_ChangedDate")]
        public string ChangedDate { get; set; }

        [JsonProperty("System_ChangedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("System_Title")]
        public string Title { get; set; }

        [JsonProperty("System_Description")]
        public string Description { get; set; }

        [JsonProperty("System_Tags")]
        public string Tags { get; set; }

        [JsonProperty("System_AssignedTo")]
        public string AssignedTo { get; set; }
    }

    public class UpdateWorkItemInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("iteration")]
        public string IterationPath { get; set; }

        [JsonProperty("area")]
        public string AreaPath { get; set; }

        [JsonProperty("linkUrl")]
        public string LinkURL { get; set; }

        [JsonProperty("linkType")]
        public UpdateWorkItemInputLinkTypeType? LinkType { get; set; }

        [JsonProperty("linkComment")]
        public string LinkComment { get; set; }

        [JsonProperty("dynamicFields")]
        public JToken DynamicFields { get; set; }

        [JsonProperty("userEnteredFields")]
        public JToken OtherFields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateWorkItemInputLinkTypeType
    {
        [EnumMember(Value = "Dependency-forward")]
        DependencyForward,
        [EnumMember(Value = "Dependency-reverse")]
        DependencyReverse,
        [EnumMember(Value = "Hierarchy-forward")]
        HierarchyForward,
        [EnumMember(Value = "Hierarchy-reverse")]
        HierarchyReverse,
        Related
    }

    public class WorkItemDetailsV2Response
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rev")]
        public int RevisionCount { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("fields")]
        public WorkItemDetailsV2ResponseFieldsType Fields { get; set; }

        [JsonProperty("relations")]
        public JToken[] Relations { get; set; }

        [JsonProperty("multilineFieldsFormat")]
        public JToken MultilineFieldFormats { get; set; }

        [JsonProperty("_links")]
        public JToken Links { get; set; }
    }

    public class WorkItemDetailsV2ResponseFieldsType
    {
        [JsonProperty("System.Id")]
        public int Id { get; set; }

        [JsonProperty("System.AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty("System.TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty("System.IterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty("System.WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("System.State")]
        public string State { get; set; }

        [JsonProperty("System.Reason")]
        public string Reason { get; set; }

        [JsonProperty("System.CreatedDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("System.CreatedBy")]
        public JToken CreatedBy { get; set; }

        [JsonProperty("System.ChangedDate")]
        public string ChangedDate { get; set; }

        [JsonProperty("System.ChangedBy")]
        public JToken ChangedBy { get; set; }

        [JsonProperty("System.Title")]
        public string Title { get; set; }

        [JsonProperty("System.Description")]
        public string Description { get; set; }

        [JsonProperty("System.Tags")]
        public string Tags { get; set; }

        [JsonProperty("System.AssignedTo")]
        public JToken AssignedTo { get; set; }

        [JsonProperty("Microsoft.VSTS.Common.StateChangeDate")]
        public string StateChangeDate { get; set; }
    }

    public class VstsListListWorkItemResponse
    {
        [JsonProperty("value")]
        public ListWorkItemResponse[] Value { get; set; }
    }

    public class ListWorkItemResponse
    {
        [JsonProperty("System.Id")]
        public int Id { get; set; }

        [JsonProperty("System.AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty("System.TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty("System.IterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty("System.WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("System.State")]
        public string State { get; set; }

        [JsonProperty("System.Reason")]
        public string Reason { get; set; }

        [JsonProperty("System.CreatedDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("System.CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("System.ChangedDate")]
        public string ChangedDate { get; set; }

        [JsonProperty("System.ChangedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("System.Title")]
        public string Title { get; set; }

        [JsonProperty("System.Description")]
        public string Description { get; set; }

        [JsonProperty("System.Tags")]
        public string Tags { get; set; }

        [JsonProperty("System.AssignedTo")]
        public string AssignedTo { get; set; }
    }

    public class WorkItemAttachmentResponse
    {
        [JsonProperty("attachmentId")]
        public string AttachmentId { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentLength")]
        public int ContentLength { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class WorkItemCommentsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("comments")]
        public WorkItemComment[] Comments { get; set; }
    }

    public class WorkItemComment
    {
        [JsonProperty("_links")]
        public JToken Links { get; set; }

        [JsonProperty("id")]
        public int CommentId { get; set; }

        [JsonProperty("workItemId")]
        public int WorkItemId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("format")]
        public CommentFormat Format { get; set; }

        [JsonProperty("text")]
        public string CommentText { get; set; }

        [JsonProperty("renderedText")]
        public string RenderedText { get; set; }

        [JsonProperty("createdBy")]
        public IdentityRef CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("createdOnBehalfOf")]
        public IdentityRef CreatedOnBehalfOf { get; set; }

        [JsonProperty("createdOnBehalfDate")]
        public string CreatedOnBehalfDate { get; set; }

        [JsonProperty("modifiedBy")]
        public IdentityRef ModifiedBy { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("mentions")]
        public CommentMention[] Mentions { get; set; }

        [JsonProperty("reactions")]
        public CommentReaction[] Reactions { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommentFormat
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "html")]
        Html
    }

    public class CommentMention
    {
        [JsonProperty("_links")]
        public JToken Links { get; set; }

        [JsonProperty("artifactId")]
        public string ArtifactId { get; set; }

        [JsonProperty("artifactType")]
        public string ArtifactType { get; set; }

        [JsonProperty("commentId")]
        public int CommentId { get; set; }

        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class CommentReaction
    {
        [JsonProperty("_links")]
        public JToken Links { get; set; }

        [JsonProperty("commentId")]
        public int CommentId { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("isCurrentUserEngaged")]
        public bool IsCurrentUserEngaged { get; set; }

        [JsonProperty("type")]
        public CommentReactionType ReactionType { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommentReactionType
    {
        [EnumMember(Value = "like")]
        Like,
        [EnumMember(Value = "dislike")]
        Dislike,
        [EnumMember(Value = "heart")]
        Heart,
        [EnumMember(Value = "hooray")]
        Hooray,
        [EnumMember(Value = "smile")]
        Smile,
        [EnumMember(Value = "confused")]
        Confused
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CreateWorkItemCommentAsyncInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentText { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "html")]
        Html
    }

    public class AddWorkItemLinkAsyncInput
    {
        [JsonProperty("linkType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddWorkItemLinkAsyncInputLinkTypeType LinkType { get; set; } = AddWorkItemLinkAsyncInputLinkTypeType.SystemLinkTypesRelated;

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetURL { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddWorkItemLinkAsyncInputLinkTypeType
    {
        [EnumMember(Value = "System.LinkTypes.Related")]
        SystemLinkTypesRelated,
        [EnumMember(Value = "System.LinkTypes.Hierarchy-Forward")]
        SystemLinkTypesHierarchyForward,
        [EnumMember(Value = "System.LinkTypes.Hierarchy-Reverse")]
        SystemLinkTypesHierarchyReverse,
        [EnumMember(Value = "System.LinkTypes.Dependency-Forward")]
        SystemLinkTypesDependencyForward,
        [EnumMember(Value = "System.LinkTypes.Dependency-Reverse")]
        SystemLinkTypesDependencyReverse,
        [EnumMember(Value = "System.LinkTypes.Duplicate-Forward")]
        SystemLinkTypesDuplicateForward,
        [EnumMember(Value = "System.LinkTypes.Duplicate-Reverse")]
        SystemLinkTypesDuplicateReverse,
        [EnumMember(Value = "Microsoft.VSTS.Common.TestedBy-Forward")]
        MicrosoftVSTSCommonTestedByForward,
        [EnumMember(Value = "Microsoft.VSTS.Common.TestedBy-Reverse")]
        MicrosoftVSTSCommonTestedByReverse,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedStepReferencedBy-Forward")]
        MicrosoftVSTSTestCaseSharedStepReferencedByForward,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedStepReferencedBy-Reverse")]
        MicrosoftVSTSTestCaseSharedStepReferencedByReverse,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Forward")]
        MicrosoftVSTSTestCaseSharedParameterReferencedByForward,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Reverse")]
        MicrosoftVSTSTestCaseSharedParameterReferencedByReverse,
        [EnumMember(Value = "Microsoft.VSTS.Common.Affects-Forward")]
        MicrosoftVSTSCommonAffectsForward,
        [EnumMember(Value = "Microsoft.VSTS.Common.Affects-Reverse")]
        MicrosoftVSTSCommonAffectsReverse,
        Hyperlink
    }

    public class DeleteWorkItemLinkAsyncInput
    {
        [JsonProperty("linkId")]
        public int? RelationId { get; set; }

        [JsonProperty("workItemLinkToRemove")]
        public string WorkItemLinkToRemove { get; set; }

        [JsonProperty("linkType")]
        public DeleteWorkItemLinkAsyncInputLinkRelationTypeType? LinkRelationType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteWorkItemLinkAsyncInputLinkRelationTypeType
    {
        [EnumMember(Value = "System.LinkTypes.Related")]
        SystemLinkTypesRelated,
        [EnumMember(Value = "System.LinkTypes.Hierarchy-Forward")]
        SystemLinkTypesHierarchyForward,
        [EnumMember(Value = "System.LinkTypes.Hierarchy-Reverse")]
        SystemLinkTypesHierarchyReverse,
        [EnumMember(Value = "System.LinkTypes.Dependency-Forward")]
        SystemLinkTypesDependencyForward,
        [EnumMember(Value = "System.LinkTypes.Dependency-Reverse")]
        SystemLinkTypesDependencyReverse,
        [EnumMember(Value = "System.LinkTypes.Duplicate-Forward")]
        SystemLinkTypesDuplicateForward,
        [EnumMember(Value = "System.LinkTypes.Duplicate-Reverse")]
        SystemLinkTypesDuplicateReverse,
        [EnumMember(Value = "Microsoft.VSTS.Common.TestedBy-Forward")]
        MicrosoftVSTSCommonTestedByForward,
        [EnumMember(Value = "Microsoft.VSTS.Common.TestedBy-Reverse")]
        MicrosoftVSTSCommonTestedByReverse,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedStepReferencedBy-Forward")]
        MicrosoftVSTSTestCaseSharedStepReferencedByForward,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedStepReferencedBy-Reverse")]
        MicrosoftVSTSTestCaseSharedStepReferencedByReverse,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Forward")]
        MicrosoftVSTSTestCaseSharedParameterReferencedByForward,
        [EnumMember(Value = "Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Reverse")]
        MicrosoftVSTSTestCaseSharedParameterReferencedByReverse,
        [EnumMember(Value = "Microsoft.VSTS.Common.Affects-Forward")]
        MicrosoftVSTSCommonAffectsForward,
        [EnumMember(Value = "Microsoft.VSTS.Common.Affects-Reverse")]
        MicrosoftVSTSCommonAffectsReverse,
        Hyperlink
    }

    public class UpdateWorkItemCommentAsyncInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentText { get; set; }
    }

    public class VstsListQueryHierarchyItem
    {
        [JsonProperty("value")]
        public QueryHierarchyItem[] Value { get; set; }
    }

    public class QueryHierarchyItem
    {
        public QueryHierarchyItem[] Children { get; set; }
        public WorkItemQueryClause Clauses { get; set; }
        public WorkItemFieldReference[] Columns { get; set; }
        public QueryHierarchyItemFilterOptionsType FilterOptions { get; set; }
        public bool HasChildren { get; set; }
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFolder { get; set; }
        public bool IsInvalidSyntax { get; set; }
        public bool IsPublic { get; set; }
        public WorkItemQueryClause LinkClauses { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public QueryHierarchyItemQueryTypeType QueryType { get; set; }
        public WorkItemQuerySortColumn[] SortColumns { get; set; }
        public WorkItemQueryClause SourceClauses { get; set; }
        public WorkItemQueryClause TargetClauses { get; set; }
        public string Wiql { get; set; }

        [JsonProperty("_links")]
        public JToken Links { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    public class WorkItemQueryClause
    {
        public WorkItemQueryClause Clauses { get; set; }
        public WorkItemFieldReference Field { get; set; }
        public WorkItemFieldReference FieldValue { get; set; }
        public bool IsFieldValue { get; set; }
        public WorkItemQueryClauseLogicalOperatorType LogicalOperator { get; set; }
        public WorkItemFieldOperation Operator { get; set; }
        public string Value { get; set; }
    }

    public class WorkItemFieldReference
    {
        public string Name { get; set; }
        public string ReferenceName { get; set; }

        [JsonProperty("Url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkItemQueryClauseLogicalOperatorType
    {
        NONE,
        AND,
        OR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryHierarchyItemFilterOptionsType
    {
        WorkItems,
        LinksOneHopMustContain,
        LinksOneHopMayContain,
        LinksOneHopDoesNotContain,
        LinksRecursiveMustContain,
        LinksRecursiveMayContain,
        LinksRecursiveDoesNotContain
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryHierarchyItemQueryTypeType
    {
        Flat,
        Tree,
        OneHop
    }

    public class WorkItemQuerySortColumn
    {
        public bool Descending { get; set; }
        public WorkItemFieldReference Field { get; set; }
    }

    public class Pipeline
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PipelineValueTypeItem[] Value { get; set; }
    }

    public class PipelineValueTypeItem
    {
        [JsonProperty("_links")]
        public PipelineValueTypeItemLinksType Links { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PipelineValueTypeItemLinksType
    {
        [JsonProperty("self")]
        public PipelineValueTypeItemLinksTypeSelfType Self { get; set; }

        [JsonProperty("web")]
        public PipelineValueTypeItemLinksTypeWebType Web { get; set; }
    }

    public class PipelineValueTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class PipelineValueTypeItemLinksTypeWebType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Run
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public RunValueTypeItem[] Value { get; set; }
    }

    public class RunValueTypeItem
    {
        [JsonProperty("_links")]
        public RunValueTypeItemLinksType Links { get; set; }

        [JsonProperty("pipeline")]
        public RunValueTypeItemPipelineType Pipeline { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("finishedDate")]
        public string FinishedDate { get; set; }
    }

    public class RunValueTypeItemLinksType
    {
        [JsonProperty("self")]
        public RunValueTypeItemLinksTypeSelfType Self { get; set; }

        [JsonProperty("web")]
        public RunValueTypeItemLinksTypeWebType Web { get; set; }

        [JsonProperty("pipeline.web")]
        public RunValueTypeItemLinksTypePipelineWebType PipelineWeb { get; set; }

        [JsonProperty("pipeline")]
        public RunValueTypeItemLinksTypePipelineType Pipeline { get; set; }
    }

    public class RunValueTypeItemLinksTypeSelfType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class RunValueTypeItemLinksTypeWebType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class RunValueTypeItemLinksTypePipelineWebType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class RunValueTypeItemLinksTypePipelineType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class RunValueTypeItemPipelineType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }
    }

    public class VstsListQueryResultWorkItemResponse
    {
        [JsonProperty("value")]
        public QueryResultWorkItemResponse[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class QueryResultWorkItemResponse
    {
        [JsonProperty("System.Id")]
        public int Id { get; set; }

        [JsonProperty("System.AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty("System.TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty("System.IterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty("System.WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("System.State")]
        public string State { get; set; }

        [JsonProperty("System.Reason")]
        public string Reason { get; set; }

        [JsonProperty("System.CreatedDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("System.CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("System.ChangedDate")]
        public string ChangedDate { get; set; }

        [JsonProperty("System.ChangedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("System.Title")]
        public string Title { get; set; }

        [JsonProperty("System.Description")]
        public string Description { get; set; }

        [JsonProperty("System.Tags")]
        public string Tags { get; set; }

        [JsonProperty("System.AssignedTo")]
        public string AssignedTo { get; set; }
    }

    public class VstsListGitPush
    {
        [JsonProperty("value")]
        public GitPush[] Value { get; set; }
    }

    public class GitPush
    {
        [JsonProperty("repository")]
        public GitRepository Repository { get; set; }

        [JsonProperty("pushedBy")]
        public GitPushUser PushedBy { get; set; }

        [JsonProperty("refUpdates")]
        public GitRefUpdate[] RefUpdates { get; set; }

        [JsonProperty("pushId")]
        public int PushId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class GitPushUser
    {
        [JsonProperty("id")]
        public string PusherId { get; set; }

        [JsonProperty("displayName")]
        public string PusherName { get; set; }

        [JsonProperty("uniqueName")]
        public string PusherUniqueName { get; set; }

        [JsonProperty("imageUrl")]
        public string PusherImageUrl { get; set; }
    }

    public class GitRefUpdate
    {
        [JsonProperty("name")]
        public string RefName { get; set; }

        [JsonProperty("repositoryId")]
        public string RepositoryId { get; set; }

        [JsonProperty("oldObjectId")]
        public string OldCommitId { get; set; }

        [JsonProperty("newObjectId")]
        public string NewCommitId { get; set; }
    }

    public class VstsListGitPullRequest
    {
        [JsonProperty("value")]
        public GitPullRequest[] Value { get; set; }
    }

    public class GitPullRequest
    {
        [JsonProperty("repository")]
        public GitRepository Repository { get; set; }

        [JsonProperty("pullRequestId")]
        public int PullRequestId { get; set; }

        [JsonProperty("createdBy")]
        public PullRequestCreatedBy CreatedBy { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("closedDate")]
        public string ClosedDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceRefName")]
        public string SourceRefName { get; set; }

        [JsonProperty("targetRefName")]
        public string TargetRefName { get; set; }

        [JsonProperty("isDraft")]
        public bool IsDraft { get; set; }

        [JsonProperty("reviewers")]
        public PullRequestReviewer[] Reviewers { get; set; }

        [JsonProperty("reviewerList")]
        public string ReviewerList { get; set; }

        [JsonProperty("requiredReviewerList")]
        public string RequiredReviewerList { get; set; }

        [JsonProperty("commits")]
        public GitCommitRef[] Commits { get; set; }

        [JsonProperty("completionOptions")]
        public PullRequestCompletionOptions CompletionOptions { get; set; }

        [JsonProperty("mergeOptions")]
        public PullRequestMergeOptions MergeOptions { get; set; }

        [JsonProperty("mergeFailureMessage")]
        public string MergeFailureMessage { get; set; }

        [JsonProperty("closedBy")]
        public PullRequestClosedBy ClosedBy { get; set; }

        [JsonProperty("autoCompleteSetBy")]
        public PullRequestAutoCompleteSetBy AutoCompleteSetBy { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("remoteUrl")]
        public string RemoteUrl { get; set; }

        [JsonProperty("artifactId")]
        public string ArtifactId { get; set; }

        [JsonProperty("mergeId")]
        public string MergeId { get; set; }

        [JsonProperty("codeReviewId")]
        public int CodeReviewId { get; set; }

        [JsonProperty("completionQueueTime")]
        public string CompletionQueueTime { get; set; }

        [JsonProperty("supportsIterations")]
        public bool SupportsIterations { get; set; }
    }

    public class PullRequestCreatedBy
    {
        [JsonProperty("displayName")]
        public string CreatedByDisplayName { get; set; }

        [JsonProperty("uniqueName")]
        public string CreatedByUniqueName { get; set; }

        [JsonProperty("id")]
        public string CreatedById { get; set; }

        [JsonProperty("imageUrl")]
        public string CreatedByImageUrl { get; set; }

        [JsonProperty("url")]
        public string CreatedByUrl { get; set; }
    }

    public class PullRequestReviewer
    {
        [JsonProperty("displayName")]
        public string ReviewerDisplayName { get; set; }

        [JsonProperty("uniqueName")]
        public string ReviewerUniqueName { get; set; }

        [JsonProperty("id")]
        public string ReviewerId { get; set; }

        [JsonProperty("url")]
        public string ReviewerUrl { get; set; }

        [JsonProperty("hasDeclined")]
        public bool HasDeclined { get; set; }

        [JsonProperty("isFlagged")]
        public bool IsFlagged { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("vote")]
        public int Vote { get; set; }

        [JsonProperty("votedFor")]
        public PullRequestReviewer[] VotedFor { get; set; }
    }

    public class GitCommitRef
    {
        [JsonProperty("author")]
        public CommitGitUserDate Author { get; set; }

        [JsonProperty("comment")]
        public string CommitComment { get; set; }

        [JsonProperty("commentTruncated")]
        public string CommitCommentTruncated { get; set; }

        [JsonProperty("commitId")]
        public string CommitId { get; set; }

        [JsonProperty("committer")]
        public CommitGitUserDate Committer { get; set; }

        [JsonProperty("parents")]
        public string[] Parents { get; set; }

        [JsonProperty("remoteUrl")]
        public string CommitRemoteUrl { get; set; }

        [JsonProperty("url")]
        public string CommitUrl { get; set; }
    }

    public class CommitGitUserDate
    {
        [JsonProperty("date")]
        public string CommitUserDate { get; set; }

        [JsonProperty("email")]
        public string CommitUserEmail { get; set; }

        [JsonProperty("imageUrl")]
        public string CommitImageUrl { get; set; }

        [JsonProperty("name")]
        public string CommitUserName { get; set; }
    }

    public class PullRequestCompletionOptions
    {
        [JsonProperty("autoCompleteIgnoreConfigIds")]
        public int[] AutoCompleteIgnoreConfigIds { get; set; }

        [JsonProperty("bypassPolicy")]
        public bool BypassPolicy { get; set; }

        [JsonProperty("bypassReason")]
        public string BypassReason { get; set; }

        [JsonProperty("deleteSourceBranch")]
        public bool DeleteSourceBranch { get; set; }

        [JsonProperty("mergeCommitMessage")]
        public string MergeCommitMessage { get; set; }

        [JsonProperty("mergeStrategy")]
        public PullRequestMergeStrategy MergeStrategy { get; set; }

        [JsonProperty("squashMerge")]
        public bool SquashMerge { get; set; }

        [JsonProperty("transitionWorkItems")]
        public bool TransitionWorkItems { get; set; }
    }

    public class PullRequestMergeStrategy
    {
        [JsonProperty("conflictAuthorshipCommits")]
        public bool ConflictAuthorshipCommits { get; set; }

        [JsonProperty("detectRenameFalsePositives")]
        public bool DetectRenameFalsePositives { get; set; }

        [JsonProperty("disableRenames")]
        public bool DisableRenames { get; set; }
    }

    public class PullRequestMergeOptions
    {
        [JsonProperty("noFastForward")]
        public string NoFastForward { get; set; }

        [JsonProperty("rebase")]
        public string Rebase { get; set; }

        [JsonProperty("rebaseMerge")]
        public string RebaseMerge { get; set; }

        [JsonProperty("squash")]
        public string Squash { get; set; }
    }

    public class PullRequestClosedBy
    {
        [JsonProperty("displayName")]
        public string ClosedByDisplayName { get; set; }

        [JsonProperty("uniqueName")]
        public string ClosedByUniqueName { get; set; }

        [JsonProperty("id")]
        public string ClosedById { get; set; }

        [JsonProperty("imageUrl")]
        public string ClosedByImageUrl { get; set; }

        [JsonProperty("url")]
        public string ClosedByUrl { get; set; }
    }

    public class PullRequestAutoCompleteSetBy
    {
        [JsonProperty("displayName")]
        public string AutoCompleteSetByDisplayName { get; set; }

        [JsonProperty("uniqueName")]
        public string AutoCompleteSetByUniqueName { get; set; }

        [JsonProperty("id")]
        public string AutoCompleteSetById { get; set; }

        [JsonProperty("imageUrl")]
        public string AutoCompleteSetByImageUrl { get; set; }

        [JsonProperty("url")]
        public string AutoCompleteSetByUrl { get; set; }
    }

    public class VstsListTfvcChangeset
    {
        [JsonProperty("value")]
        public TfvcChangeset[] Value { get; set; }
    }

    public class TfvcChangeset
    {
        [JsonProperty("changesetId")]
        public int ChangesetId { get; set; }

        [JsonProperty("author")]
        public ChangesetAuthor Author { get; set; }

        [JsonProperty("checkedInBy")]
        public ChangesetCheckedInBy CheckedInBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class ChangesetAuthor
    {
        [JsonProperty("displayName")]
        public string AuthorName { get; set; }

        [JsonProperty("uniqueName")]
        public string AuthorUniqueName { get; set; }
    }

    public class ChangesetCheckedInBy
    {
        [JsonProperty("displayName")]
        public string CheckedInByName { get; set; }

        [JsonProperty("uniqueName")]
        public string CheckedInByUniqueName { get; set; }
    }

    public class VstsListTriggerWorkItemResponse
    {
        [JsonProperty("value")]
        public TriggerWorkItemResponse[] Value { get; set; }
    }

    public class TriggerWorkItemResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rev")]
        public int RevisionCount { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum areaPathComparisonInput
    {
        Equals,
        Under
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum iterationPathComparisonInput
    {
        Equals,
        Under
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Visualstudioteamservices;

    public partial class WorkflowManagedActions
    {
        public VisualstudioteamservicesActions Visualstudioteamservices(string connectionId) => new VisualstudioteamservicesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VisualstudioteamservicesTriggers Visualstudioteamservices(string connectionId) => new VisualstudioteamservicesTriggers(connectionId);
    }
}