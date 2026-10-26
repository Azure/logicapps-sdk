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
        public IBodyWorkflowAction<WorkItemSearchResponse, ApiConnectionActionConfiguration> SearchWorkItemsAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> searchRequestsearchText, Expression<Func<int>> searchRequestskip = null, Expression<Func<int>> searchRequesttop = null, Expression<Func<bool>> searchRequestincludeFacets = null, Expression<Func<SortOption[]>> searchRequestorderBy = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_searchRequestsearchText = WorkflowExpression.Compile(searchRequestsearchText, nameof(searchRequestsearchText), required: true);
            var __workflow_searchRequestskip = WorkflowExpression.Compile(searchRequestskip, nameof(searchRequestskip), required: false);
            var __workflow_searchRequesttop = WorkflowExpression.Compile(searchRequesttop, nameof(searchRequesttop), required: false);
            var __workflow_searchRequestincludeFacets = WorkflowExpression.Compile(searchRequestincludeFacets, nameof(searchRequestincludeFacets), required: false);
            var __workflow_searchRequestorderBy = WorkflowExpression.Compile(searchRequestorderBy, nameof(searchRequestorderBy), required: false);
            return new DeferredBodyAction<WorkItemSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_apis/search/workitemsearchresults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                var searchRequest = new JObject();
                var searchRequestpropCount = 0;
                searchRequestpropCount++;
                searchRequest["searchText"] = ExpressionConverter.ConvertO(__workflow_searchRequestsearchText);
                if (__workflow_searchRequestskip != null)
                {
                    searchRequest["$skip"] = ExpressionConverter.ConvertO(__workflow_searchRequestskip);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequesttop != null)
                {
                    searchRequest["$top"] = ExpressionConverter.ConvertO(__workflow_searchRequesttop);
                    searchRequestpropCount++;
                }

                var filtersObject = new JObject();
                var filtersObjectpropCount = 0;
                if (filtersObjectpropCount > 0)
                {
                    searchRequest["filters"] = filtersObject;
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestincludeFacets != null)
                {
                    searchRequest["includeFacets"] = ExpressionConverter.ConvertO(__workflow_searchRequestincludeFacets);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestorderBy != null)
                {
                    searchRequest["$orderBy"] = ExpressionConverter.ConvertO(__workflow_searchRequestorderBy);
                    searchRequestpropCount++;
                }

                if (searchRequestpropCount > 0)
                {
                    callPayload.Body = searchRequest;
                }

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
        public IBodyWorkflowAction<VstsListBuildResult, ApiConnectionActionConfiguration> ListBuilds(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> definitions = null, Expression<Func<string>> buildNumber = null, Expression<Func<string>> branchName = null, Expression<Func<resultFilterInput>> resultFilter = null, Expression<Func<statusFilterInput>> statusFilter = null, Expression<Func<reasonFilterInput>> reasonFilter = null, Expression<Func<string>> requestedFor = null, Expression<Func<string>> minTime = null, Expression<Func<string>> maxTime = null, Expression<Func<int>> top = null, Expression<Func<queryOrderInput>> queryOrder = null, Expression<Func<string>> tagFilters = null)
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
            var __workflow_queryOrder = WorkflowExpression.Compile(queryOrder, nameof(queryOrder), required: false);
            var __workflow_tagFilters = WorkflowExpression.Compile(tagFilters, nameof(tagFilters), required: false);
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
                if (__workflow_queryOrder != null)
                    callPayload.Queries["queryOrder"] = ExpressionConverter.Convert(__workflow_queryOrder);
                if (__workflow_tagFilters != null)
                    callPayload.Queries["tagFilters"] = ExpressionConverter.Convert(__workflow_tagFilters);
                return new ApiConnectionAction<VstsListBuildResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<BuildResult, ApiConnectionActionConfiguration> QueueNewBuild(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> buildDefId, Expression<Func<string>> buildDetailssourceBranch = null, Expression<Func<string>> buildDetailsparameters = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_buildDefId = WorkflowExpression.Compile(buildDefId, nameof(buildDefId), required: true);
            var __workflow_buildDetailssourceBranch = WorkflowExpression.Compile(buildDetailssourceBranch, nameof(buildDetailssourceBranch), required: false);
            var __workflow_buildDetailsparameters = WorkflowExpression.Compile(buildDetailsparameters, nameof(buildDetailsparameters), required: false);
            return new DeferredBodyAction<BuildResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/build/builds", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["buildDefId"] = ExpressionConverter.Convert(__workflow_buildDefId);
                var buildDetails = new JObject();
                var buildDetailspropCount = 0;
                if (__workflow_buildDetailssourceBranch != null)
                {
                    buildDetails["sourceBranch"] = ExpressionConverter.ConvertO(__workflow_buildDetailssourceBranch);
                    buildDetailspropCount++;
                }

                if (__workflow_buildDetailsparameters != null)
                {
                    buildDetails["parameters"] = ExpressionConverter.ConvertO(__workflow_buildDetailsparameters);
                    buildDetailspropCount++;
                }

                if (buildDetailspropCount > 0)
                {
                    callPayload.Body = buildDetails;
                }

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
        public IBodyWorkflowAction<Release, ApiConnectionActionConfiguration> CreateRelease(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> releaseDefId, Expression<Func<string>> releaseStartMetadatadescription = null, Expression<Func<bool>> releaseStartMetadataisDraft = null, Expression<Func<releaseStartMetadatareasonInput>> releaseStartMetadatareason = null, Expression<Func<ConfigurationVariable[]>> releaseStartMetadatareleaseVariables = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_releaseDefId = WorkflowExpression.Compile(releaseDefId, nameof(releaseDefId), required: true);
            var __workflow_releaseStartMetadatadescription = WorkflowExpression.Compile(releaseStartMetadatadescription, nameof(releaseStartMetadatadescription), required: false);
            var __workflow_releaseStartMetadataisDraft = WorkflowExpression.Compile(releaseStartMetadataisDraft, nameof(releaseStartMetadataisDraft), required: false);
            var __workflow_releaseStartMetadatareason = WorkflowExpression.Compile(releaseStartMetadatareason, nameof(releaseStartMetadatareason), required: false);
            var __workflow_releaseStartMetadatareleaseVariables = WorkflowExpression.Compile(releaseStartMetadatareleaseVariables, nameof(releaseStartMetadatareleaseVariables), required: false);
            return new DeferredBodyAction<Release, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/releases", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["releaseDefId"] = ExpressionConverter.Convert(__workflow_releaseDefId);
                var releaseStartMetadata = new JObject();
                var releaseStartMetadatapropCount = 0;
                if (__workflow_releaseStartMetadatadescription != null)
                {
                    releaseStartMetadata["Description"] = ExpressionConverter.ConvertO(__workflow_releaseStartMetadatadescription);
                    releaseStartMetadatapropCount++;
                }

                if (__workflow_releaseStartMetadataisDraft != null)
                {
                    releaseStartMetadata["IsDraft"] = ExpressionConverter.ConvertO(__workflow_releaseStartMetadataisDraft);
                    releaseStartMetadatapropCount++;
                }

                if (__workflow_releaseStartMetadatareason != null)
                {
                    releaseStartMetadata["Reason"] = ExpressionConverter.ConvertO(__workflow_releaseStartMetadatareason);
                    releaseStartMetadatapropCount++;
                }

                if (__workflow_releaseStartMetadatareleaseVariables != null)
                {
                    releaseStartMetadata["Variables"] = ExpressionConverter.ConvertO(__workflow_releaseStartMetadatareleaseVariables);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadatapropCount > 0)
                {
                    callPayload.Body = releaseStartMetadata;
                }

                return new ApiConnectionAction<Release>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> account, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parametersrelativeURI, Expression<Func<string>> parametersbody = null, Expression<Func<bool>> parametersbodyIsBase64 = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parametersmethod = WorkflowExpression.Compile(parametersmethod, nameof(parametersmethod), required: true);
            var __workflow_parametersrelativeURI = WorkflowExpression.Compile(parametersrelativeURI, nameof(parametersrelativeURI), required: true);
            var __workflow_parametersbody = WorkflowExpression.Compile(parametersbody, nameof(parametersbody), required: false);
            var __workflow_parametersbodyIsBase64 = WorkflowExpression.Compile(parametersbodyIsBase64, nameof(parametersbodyIsBase64), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["Method"] = ExpressionConverter.ConvertO(__workflow_parametersmethod);
                parameterspropCount++;
                parameters["Uri"] = ExpressionConverter.ConvertO(__workflow_parametersrelativeURI);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["Headers"] = headersObject;
                    parameterspropCount++;
                }

                if (__workflow_parametersbody != null)
                {
                    parameters["Body"] = ExpressionConverter.ConvertO(__workflow_parametersbody);
                    parameterspropCount++;
                }

                if (__workflow_parametersbodyIsBase64 != null)
                {
                    parameters["IsBase64"] = ExpressionConverter.ConvertO(__workflow_parametersbodyIsBase64);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

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
        public IBodyWorkflowAction<PatchWorkItemResponse, ApiConnectionActionConfiguration> UpdateWorkItem(Expression<Func<string>> account, Expression<Func<string>> id, Expression<Func<string>> project = null, Expression<Func<string>> type = null, Expression<Func<string>> workItemtitle = null, Expression<Func<string>> workItemdescription = null, Expression<Func<int>> workItempriority = null, Expression<Func<string>> workItemiterationPath = null, Expression<Func<string>> workItemareaPath = null, Expression<Func<string>> workItemlinkURL = null, Expression<Func<workItemlinkTypeInput>> workItemlinkType = null, Expression<Func<string>> workItemlinkComment = null, Expression<Func<object>> workItemdynamicFields = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_workItemtitle = WorkflowExpression.Compile(workItemtitle, nameof(workItemtitle), required: false);
            var __workflow_workItemdescription = WorkflowExpression.Compile(workItemdescription, nameof(workItemdescription), required: false);
            var __workflow_workItempriority = WorkflowExpression.Compile(workItempriority, nameof(workItempriority), required: false);
            var __workflow_workItemiterationPath = WorkflowExpression.Compile(workItemiterationPath, nameof(workItemiterationPath), required: false);
            var __workflow_workItemareaPath = WorkflowExpression.Compile(workItemareaPath, nameof(workItemareaPath), required: false);
            var __workflow_workItemlinkURL = WorkflowExpression.Compile(workItemlinkURL, nameof(workItemlinkURL), required: false);
            var __workflow_workItemlinkType = WorkflowExpression.Compile(workItemlinkType, nameof(workItemlinkType), required: false);
            var __workflow_workItemlinkComment = WorkflowExpression.Compile(workItemlinkComment, nameof(workItemlinkComment), required: false);
            var __workflow_workItemdynamicFields = WorkflowExpression.Compile(workItemdynamicFields, nameof(workItemdynamicFields), required: false);
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
                var workItem = new JObject();
                var workItempropCount = 0;
                if (__workflow_workItemtitle != null)
                {
                    workItem["title"] = ExpressionConverter.ConvertO(__workflow_workItemtitle);
                    workItempropCount++;
                }

                if (__workflow_workItemdescription != null)
                {
                    workItem["description"] = ExpressionConverter.ConvertO(__workflow_workItemdescription);
                    workItempropCount++;
                }

                if (__workflow_workItempriority != null)
                {
                    workItem["priority"] = ExpressionConverter.ConvertO(__workflow_workItempriority);
                    workItempropCount++;
                }

                if (__workflow_workItemiterationPath != null)
                {
                    workItem["iteration"] = ExpressionConverter.ConvertO(__workflow_workItemiterationPath);
                    workItempropCount++;
                }

                if (__workflow_workItemareaPath != null)
                {
                    workItem["area"] = ExpressionConverter.ConvertO(__workflow_workItemareaPath);
                    workItempropCount++;
                }

                if (__workflow_workItemlinkURL != null)
                {
                    workItem["linkUrl"] = ExpressionConverter.ConvertO(__workflow_workItemlinkURL);
                    workItempropCount++;
                }

                if (__workflow_workItemlinkType != null)
                {
                    workItem["linkType"] = ExpressionConverter.ConvertO(__workflow_workItemlinkType);
                    workItempropCount++;
                }

                if (__workflow_workItemlinkComment != null)
                {
                    workItem["linkComment"] = ExpressionConverter.ConvertO(__workflow_workItemlinkComment);
                    workItempropCount++;
                }

                if (__workflow_workItemdynamicFields != null)
                {
                    workItem["dynamicFields"] = ExpressionConverter.ConvertO(__workflow_workItemdynamicFields);
                    workItempropCount++;
                }

                var userEnteredFieldsObject = new JObject();
                var userEnteredFieldsObjectpropCount = 0;
                if (userEnteredFieldsObjectpropCount > 0)
                {
                    workItem["userEnteredFields"] = userEnteredFieldsObject;
                    workItempropCount++;
                }

                if (workItempropCount > 0)
                {
                    callPayload.Body = workItem;
                }

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
        public IBodyWorkflowAction<WorkItemComment, ApiConnectionActionConfiguration> CreateWorkItemCommentAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> workItemId, Expression<Func<string>> commentcommentText, Expression<Func<string>> type = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_commentcommentText = WorkflowExpression.Compile(commentcommentText, nameof(commentcommentText), required: true);
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
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["text"] = ExpressionConverter.ConvertO(__workflow_commentcommentText);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

                return new ApiConnectionAction<WorkItemComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse, ApiConnectionActionConfiguration> AddWorkItemLinkAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> type, Expression<Func<int>> workItemId, Expression<Func<linkRequestlinkTypeInput>> linkRequestlinkType, Expression<Func<string>> linkRequesttargetURL, Expression<Func<string>> linkRequestcomment = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_linkRequestlinkType = WorkflowExpression.Compile(linkRequestlinkType, nameof(linkRequestlinkType), required: true);
            var __workflow_linkRequesttargetURL = WorkflowExpression.Compile(linkRequesttargetURL, nameof(linkRequesttargetURL), required: true);
            var __workflow_linkRequestcomment = WorkflowExpression.Compile(linkRequestcomment, nameof(linkRequestcomment), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/links", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                var linkRequest = new JObject();
                var linkRequestpropCount = 0;
                linkRequestpropCount++;
                linkRequest["linkType"] = ExpressionConverter.ConvertO(__workflow_linkRequestlinkType);
                linkRequestpropCount++;
                linkRequest["targetUrl"] = ExpressionConverter.ConvertO(__workflow_linkRequesttargetURL);
                if (__workflow_linkRequestcomment != null)
                {
                    linkRequest["comment"] = ExpressionConverter.ConvertO(__workflow_linkRequestcomment);
                    linkRequestpropCount++;
                }

                if (linkRequestpropCount > 0)
                {
                    callPayload.Body = linkRequest;
                }

                return new ApiConnectionAction<PatchWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse, ApiConnectionActionConfiguration> DeleteWorkItemLinkAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> type, Expression<Func<int>> workItemId, Expression<Func<int>> linkRequestrelationId = null, Expression<Func<string>> linkRequestworkItemLinkToRemove = null, Expression<Func<linkRequestlinkRelationTypeInput>> linkRequestlinkRelationType = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_linkRequestrelationId = WorkflowExpression.Compile(linkRequestrelationId, nameof(linkRequestrelationId), required: false);
            var __workflow_linkRequestworkItemLinkToRemove = WorkflowExpression.Compile(linkRequestworkItemLinkToRemove, nameof(linkRequestworkItemLinkToRemove), required: false);
            var __workflow_linkRequestlinkRelationType = WorkflowExpression.Compile(linkRequestlinkRelationType, nameof(linkRequestlinkRelationType), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/wit/workitems/{0}/links/delete", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                var linkRequest = new JObject();
                var linkRequestpropCount = 0;
                if (__workflow_linkRequestrelationId != null)
                {
                    linkRequest["linkId"] = ExpressionConverter.ConvertO(__workflow_linkRequestrelationId);
                    linkRequestpropCount++;
                }

                if (__workflow_linkRequestworkItemLinkToRemove != null)
                {
                    linkRequest["workItemLinkToRemove"] = ExpressionConverter.ConvertO(__workflow_linkRequestworkItemLinkToRemove);
                    linkRequestpropCount++;
                }

                if (__workflow_linkRequestlinkRelationType != null)
                {
                    linkRequest["linkType"] = ExpressionConverter.ConvertO(__workflow_linkRequestlinkRelationType);
                    linkRequestpropCount++;
                }

                if (linkRequestpropCount > 0)
                {
                    callPayload.Body = linkRequest;
                }

                return new ApiConnectionAction<PatchWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemComment, ApiConnectionActionConfiguration> UpdateWorkItemCommentAsync(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> workItemId, Expression<Func<int>> commentId, Expression<Func<string>> commentcommentText, Expression<Func<formatInput>> format = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            var __workflow_commentcommentText = WorkflowExpression.Compile(commentcommentText, nameof(commentcommentText), required: true);
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
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["text"] = ExpressionConverter.ConvertO(__workflow_commentcommentText);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

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
        public IBodyWorkflowAction<PipelineRun, ApiConnectionActionConfiguration> RunPipeline(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> pipelineId, Expression<Func<int>> pipelineVersion = null, Expression<Func<string[]>> runParametersstagesToSkip = null, Expression<Func<bool>> runParameterspreviewRun = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_pipelineId = WorkflowExpression.Compile(pipelineId, nameof(pipelineId), required: true);
            var __workflow_pipelineVersion = WorkflowExpression.Compile(pipelineVersion, nameof(pipelineVersion), required: false);
            var __workflow_runParametersstagesToSkip = WorkflowExpression.Compile(runParametersstagesToSkip, nameof(runParametersstagesToSkip), required: false);
            var __workflow_runParameterspreviewRun = WorkflowExpression.Compile(runParameterspreviewRun, nameof(runParameterspreviewRun), required: false);
            return new DeferredBodyAction<PipelineRun, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/pipelines/{1}/runs", __workflow_project.WithUrlEncoding(1), __workflow_pipelineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_pipelineVersion != null)
                    callPayload.Queries["pipelineVersion"] = ExpressionConverter.Convert(__workflow_pipelineVersion);
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                var runParameters = new JObject();
                var runParameterspropCount = 0;
                var resourcesObject = new JObject();
                var resourcesObjectpropCount = 0;
                var repositoriesObject = new JObject();
                var repositoriesObjectpropCount = 0;
                if (repositoriesObjectpropCount > 0)
                {
                    resourcesObject["repositories"] = repositoriesObject;
                    resourcesObjectpropCount++;
                }

                if (resourcesObjectpropCount > 0)
                {
                    runParameters["resources"] = resourcesObject;
                    runParameterspropCount++;
                }

                var templateParametersObject = new JObject();
                var templateParametersObjectpropCount = 0;
                if (templateParametersObjectpropCount > 0)
                {
                    runParameters["templateParameters"] = templateParametersObject;
                    runParameterspropCount++;
                }

                var variablesObject = new JObject();
                var variablesObjectpropCount = 0;
                if (variablesObjectpropCount > 0)
                {
                    runParameters["variables"] = variablesObject;
                    runParameterspropCount++;
                }

                if (__workflow_runParametersstagesToSkip != null)
                {
                    runParameters["stagesToSkip"] = ExpressionConverter.ConvertO(__workflow_runParametersstagesToSkip);
                    runParameterspropCount++;
                }

                if (__workflow_runParameterspreviewRun != null)
                {
                    runParameters["previewRun"] = ExpressionConverter.ConvertO(__workflow_runParameterspreviewRun);
                    runParameterspropCount++;
                }

                if (runParameterspropCount > 0)
                {
                    callPayload.Body = runParameters;
                }

                return new ApiConnectionAction<PipelineRun>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PipelineRun, ApiConnectionActionConfiguration> GetPipelineRun(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> pipelineId, Expression<Func<int>> runId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_pipelineId = WorkflowExpression.Compile(pipelineId, nameof(pipelineId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<PipelineRun, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/pipelines/{1}/runs/{2}", __workflow_project.WithUrlEncoding(1), __workflow_pipelineId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                return new ApiConnectionAction<PipelineRun>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<GitItem, ApiConnectionActionConfiguration> GetGitItem(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repositoryId, Expression<Func<string>> path, Expression<Func<bool>> includeContent = null, Expression<Func<string>> versionDescriptorVersion = null, Expression<Func<versionDescriptorVersionTypeInput>> versionDescriptorVersionType = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_includeContent = WorkflowExpression.Compile(includeContent, nameof(includeContent), required: false);
            var __workflow_versionDescriptorVersion = WorkflowExpression.Compile(versionDescriptorVersion, nameof(versionDescriptorVersion), required: false);
            var __workflow_versionDescriptorVersionType = WorkflowExpression.Compile(versionDescriptorVersionType, nameof(versionDescriptorVersionType), required: false);
            return new DeferredBodyAction<GitItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/git/repositories/{1}/items", __workflow_project.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["includeContent"] = Convert.ToString(true);
                if (__workflow_includeContent != null)
                    callPayload.Queries["includeContent"] = ExpressionConverter.Convert(__workflow_includeContent);
                if (__workflow_versionDescriptorVersion != null)
                    callPayload.Queries["versionDescriptor.version"] = ExpressionConverter.Convert(__workflow_versionDescriptorVersion);
                if (__workflow_versionDescriptorVersionType != null)
                    callPayload.Queries["versionDescriptor.versionType"] = ExpressionConverter.Convert(__workflow_versionDescriptorVersionType);
                callPayload.Queries["$format"] = Convert.ToString("json");
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                return new ApiConnectionAction<GitItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<GitRefList, ApiConnectionActionConfiguration> ListGitRefsWithFilter(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repositoryId, Expression<Func<string>> filter = null, Expression<Func<bool>> peelTags = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_peelTags = WorkflowExpression.Compile(peelTags, nameof(peelTags), required: false);
            return new DeferredBodyAction<GitRefList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/git/repositories/{1}/refs", __workflow_project.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_peelTags != null)
                    callPayload.Queries["peelTags"] = ExpressionConverter.Convert(__workflow_peelTags);
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                return new ApiConnectionAction<GitRefList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<GitPushResponse, ApiConnectionActionConfiguration> CreateGitPush(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repositoryId, Expression<Func<GitRefUpdateRequest[]>> pushrefUpdates, Expression<Func<GitCommitRequest[]>> pushcommits)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_pushrefUpdates = WorkflowExpression.Compile(pushrefUpdates, nameof(pushrefUpdates), required: true);
            var __workflow_pushcommits = WorkflowExpression.Compile(pushcommits, nameof(pushcommits), required: true);
            return new DeferredBodyAction<GitPushResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/git/repositories/{1}/pushes", __workflow_project.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                var push = new JObject();
                var pushpropCount = 0;
                pushpropCount++;
                push["refUpdates"] = ExpressionConverter.ConvertO(__workflow_pushrefUpdates);
                pushpropCount++;
                push["commits"] = ExpressionConverter.ConvertO(__workflow_pushcommits);
                if (pushpropCount > 0)
                {
                    callPayload.Body = push;
                }

                return new ApiConnectionAction<GitPushResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<GitPullRequestResponse, ApiConnectionActionConfiguration> CreateGitPullRequest(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repositoryId, Expression<Func<string>> pullRequestsourceBranch, Expression<Func<string>> pullRequesttargetBranch, Expression<Func<string>> pullRequesttitle, Expression<Func<string>> pullRequestdescription = null, Expression<Func<bool>> pullRequestisDraft = null, Expression<Func<GitPullRequestWorkItemRef[]>> pullRequestworkItemRefs = null, Expression<Func<GitPullRequestReviewerRef[]>> pullRequestreviewers = null, Expression<Func<pullRequestlabelsInputItem[]>> pullRequestlabels = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_pullRequestsourceBranch = WorkflowExpression.Compile(pullRequestsourceBranch, nameof(pullRequestsourceBranch), required: true);
            var __workflow_pullRequesttargetBranch = WorkflowExpression.Compile(pullRequesttargetBranch, nameof(pullRequesttargetBranch), required: true);
            var __workflow_pullRequesttitle = WorkflowExpression.Compile(pullRequesttitle, nameof(pullRequesttitle), required: true);
            var __workflow_pullRequestdescription = WorkflowExpression.Compile(pullRequestdescription, nameof(pullRequestdescription), required: false);
            var __workflow_pullRequestisDraft = WorkflowExpression.Compile(pullRequestisDraft, nameof(pullRequestisDraft), required: false);
            var __workflow_pullRequestworkItemRefs = WorkflowExpression.Compile(pullRequestworkItemRefs, nameof(pullRequestworkItemRefs), required: false);
            var __workflow_pullRequestreviewers = WorkflowExpression.Compile(pullRequestreviewers, nameof(pullRequestreviewers), required: false);
            var __workflow_pullRequestlabels = WorkflowExpression.Compile(pullRequestlabels, nameof(pullRequestlabels), required: false);
            return new DeferredBodyAction<GitPullRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/git/repositories/{1}/pullrequests", __workflow_project.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                var pullRequest = new JObject();
                var pullRequestpropCount = 0;
                pullRequestpropCount++;
                pullRequest["sourceRefName"] = ExpressionConverter.ConvertO(__workflow_pullRequestsourceBranch);
                pullRequestpropCount++;
                pullRequest["targetRefName"] = ExpressionConverter.ConvertO(__workflow_pullRequesttargetBranch);
                pullRequestpropCount++;
                pullRequest["title"] = ExpressionConverter.ConvertO(__workflow_pullRequesttitle);
                if (__workflow_pullRequestdescription != null)
                {
                    pullRequest["description"] = ExpressionConverter.ConvertO(__workflow_pullRequestdescription);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequestisDraft != null)
                {
                    pullRequest["isDraft"] = ExpressionConverter.ConvertO(__workflow_pullRequestisDraft);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequestworkItemRefs != null)
                {
                    pullRequest["workItemRefs"] = ExpressionConverter.ConvertO(__workflow_pullRequestworkItemRefs);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequestreviewers != null)
                {
                    pullRequest["reviewers"] = ExpressionConverter.ConvertO(__workflow_pullRequestreviewers);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequestlabels != null)
                {
                    pullRequest["labels"] = ExpressionConverter.ConvertO(__workflow_pullRequestlabels);
                    pullRequestpropCount++;
                }

                if (pullRequestpropCount > 0)
                {
                    callPayload.Body = pullRequest;
                }

                return new ApiConnectionAction<GitPullRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<GitPullRequestResponse, ApiConnectionActionConfiguration> UpdateGitPullRequest(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repositoryId, Expression<Func<int>> pullRequestId, Expression<Func<pullRequeststatusInput>> pullRequeststatus = null, Expression<Func<string>> pullRequesttitle = null, Expression<Func<string>> pullRequestdescription = null, Expression<Func<string>> pullRequesttargetBranch = null, Expression<Func<bool>> pullRequestisDraft = null, Expression<Func<string>> pullRequestautoCompleteSetByidentityId = null, Expression<Func<string>> pullRequestlastMergeSourceCommitcommitId = null, Expression<Func<bool>> pullRequestcompletionOptionsdeleteSourceBranch = null, Expression<Func<bool>> pullRequestcompletionOptionssquashMerge = null, Expression<Func<bool>> pullRequestcompletionOptionsbypassPolicy = null, Expression<Func<string>> pullRequestcompletionOptionsbypassReason = null, Expression<Func<string>> pullRequestcompletionOptionsmergeCommitMessage = null, Expression<Func<bool>> pullRequestcompletionOptionstransitionWorkItems = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_pullRequestId = WorkflowExpression.Compile(pullRequestId, nameof(pullRequestId), required: true);
            var __workflow_pullRequeststatus = WorkflowExpression.Compile(pullRequeststatus, nameof(pullRequeststatus), required: false);
            var __workflow_pullRequesttitle = WorkflowExpression.Compile(pullRequesttitle, nameof(pullRequesttitle), required: false);
            var __workflow_pullRequestdescription = WorkflowExpression.Compile(pullRequestdescription, nameof(pullRequestdescription), required: false);
            var __workflow_pullRequesttargetBranch = WorkflowExpression.Compile(pullRequesttargetBranch, nameof(pullRequesttargetBranch), required: false);
            var __workflow_pullRequestisDraft = WorkflowExpression.Compile(pullRequestisDraft, nameof(pullRequestisDraft), required: false);
            var __workflow_pullRequestautoCompleteSetByidentityId = WorkflowExpression.Compile(pullRequestautoCompleteSetByidentityId, nameof(pullRequestautoCompleteSetByidentityId), required: false);
            var __workflow_pullRequestlastMergeSourceCommitcommitId = WorkflowExpression.Compile(pullRequestlastMergeSourceCommitcommitId, nameof(pullRequestlastMergeSourceCommitcommitId), required: false);
            var __workflow_pullRequestcompletionOptionsdeleteSourceBranch = WorkflowExpression.Compile(pullRequestcompletionOptionsdeleteSourceBranch, nameof(pullRequestcompletionOptionsdeleteSourceBranch), required: false);
            var __workflow_pullRequestcompletionOptionssquashMerge = WorkflowExpression.Compile(pullRequestcompletionOptionssquashMerge, nameof(pullRequestcompletionOptionssquashMerge), required: false);
            var __workflow_pullRequestcompletionOptionsbypassPolicy = WorkflowExpression.Compile(pullRequestcompletionOptionsbypassPolicy, nameof(pullRequestcompletionOptionsbypassPolicy), required: false);
            var __workflow_pullRequestcompletionOptionsbypassReason = WorkflowExpression.Compile(pullRequestcompletionOptionsbypassReason, nameof(pullRequestcompletionOptionsbypassReason), required: false);
            var __workflow_pullRequestcompletionOptionsmergeCommitMessage = WorkflowExpression.Compile(pullRequestcompletionOptionsmergeCommitMessage, nameof(pullRequestcompletionOptionsmergeCommitMessage), required: false);
            var __workflow_pullRequestcompletionOptionstransitionWorkItems = WorkflowExpression.Compile(pullRequestcompletionOptionstransitionWorkItems, nameof(pullRequestcompletionOptionstransitionWorkItems), required: false);
            return new DeferredBodyAction<GitPullRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/{0}/_apis/git/repositories/{1}/pullrequests/{2}", __workflow_project.WithUrlEncoding(1), __workflow_repositoryId.WithUrlEncoding(1), __workflow_pullRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["api-version"] = Convert.ToString("7.1");
                var pullRequest = new JObject();
                var pullRequestpropCount = 0;
                if (__workflow_pullRequeststatus != null)
                {
                    pullRequest["status"] = ExpressionConverter.ConvertO(__workflow_pullRequeststatus);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequesttitle != null)
                {
                    pullRequest["title"] = ExpressionConverter.ConvertO(__workflow_pullRequesttitle);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequestdescription != null)
                {
                    pullRequest["description"] = ExpressionConverter.ConvertO(__workflow_pullRequestdescription);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequesttargetBranch != null)
                {
                    pullRequest["targetRefName"] = ExpressionConverter.ConvertO(__workflow_pullRequesttargetBranch);
                    pullRequestpropCount++;
                }

                if (__workflow_pullRequestisDraft != null)
                {
                    pullRequest["isDraft"] = ExpressionConverter.ConvertO(__workflow_pullRequestisDraft);
                    pullRequestpropCount++;
                }

                var autoCompleteSetByObject = new JObject();
                var autoCompleteSetByObjectpropCount = 0;
                if (__workflow_pullRequestautoCompleteSetByidentityId != null)
                {
                    autoCompleteSetByObject["id"] = ExpressionConverter.ConvertO(__workflow_pullRequestautoCompleteSetByidentityId);
                    autoCompleteSetByObjectpropCount++;
                }

                if (autoCompleteSetByObjectpropCount > 0)
                {
                    pullRequest["autoCompleteSetBy"] = autoCompleteSetByObject;
                    pullRequestpropCount++;
                }

                var lastMergeSourceCommitObject = new JObject();
                var lastMergeSourceCommitObjectpropCount = 0;
                if (__workflow_pullRequestlastMergeSourceCommitcommitId != null)
                {
                    lastMergeSourceCommitObject["commitId"] = ExpressionConverter.ConvertO(__workflow_pullRequestlastMergeSourceCommitcommitId);
                    lastMergeSourceCommitObjectpropCount++;
                }

                if (lastMergeSourceCommitObjectpropCount > 0)
                {
                    pullRequest["lastMergeSourceCommit"] = lastMergeSourceCommitObject;
                    pullRequestpropCount++;
                }

                var completionOptionsObject = new JObject();
                var completionOptionsObjectpropCount = 0;
                if (__workflow_pullRequestcompletionOptionsdeleteSourceBranch != null)
                {
                    completionOptionsObject["deleteSourceBranch"] = ExpressionConverter.ConvertO(__workflow_pullRequestcompletionOptionsdeleteSourceBranch);
                    completionOptionsObjectpropCount++;
                }

                if (__workflow_pullRequestcompletionOptionssquashMerge != null)
                {
                    completionOptionsObject["squashMerge"] = ExpressionConverter.ConvertO(__workflow_pullRequestcompletionOptionssquashMerge);
                    completionOptionsObjectpropCount++;
                }

                if (__workflow_pullRequestcompletionOptionsbypassPolicy != null)
                {
                    completionOptionsObject["bypassPolicy"] = ExpressionConverter.ConvertO(__workflow_pullRequestcompletionOptionsbypassPolicy);
                    completionOptionsObjectpropCount++;
                }

                if (__workflow_pullRequestcompletionOptionsbypassReason != null)
                {
                    completionOptionsObject["bypassReason"] = ExpressionConverter.ConvertO(__workflow_pullRequestcompletionOptionsbypassReason);
                    completionOptionsObjectpropCount++;
                }

                if (__workflow_pullRequestcompletionOptionsmergeCommitMessage != null)
                {
                    completionOptionsObject["mergeCommitMessage"] = ExpressionConverter.ConvertO(__workflow_pullRequestcompletionOptionsmergeCommitMessage);
                    completionOptionsObjectpropCount++;
                }

                if (__workflow_pullRequestcompletionOptionstransitionWorkItems != null)
                {
                    completionOptionsObject["transitionWorkItems"] = ExpressionConverter.ConvertO(__workflow_pullRequestcompletionOptionstransitionWorkItems);
                    completionOptionsObjectpropCount++;
                }

                if (completionOptionsObjectpropCount > 0)
                {
                    pullRequest["completionOptions"] = completionOptionsObject;
                    pullRequestpropCount++;
                }

                if (pullRequestpropCount > 0)
                {
                    callPayload.Body = pullRequest;
                }

                return new ApiConnectionAction<GitPullRequestResponse>(callPayload);
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

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("templateParameters")]
        public JToken TemplateParameters { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum queryOrderInput
    {
        [EnumMember(Value = "finishTimeAscending")]
        FinishTimeAscending,
        [EnumMember(Value = "finishTimeDescending")]
        FinishTimeDescending,
        [EnumMember(Value = "queueTimeAscending")]
        QueueTimeAscending,
        [EnumMember(Value = "queueTimeDescending")]
        QueueTimeDescending,
        [EnumMember(Value = "startTimeAscending")]
        StartTimeAscending,
        [EnumMember(Value = "startTimeDescending")]
        StartTimeDescending
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum releaseStartMetadatareasonInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum parametersmethodInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum workItemlinkTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "html")]
        Html
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum linkRequestlinkTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum linkRequestlinkRelationTypeInput
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

    public class PipelineRun
    {
        [JsonProperty("id")]
        public int RunId { get; set; }

        [JsonProperty("name")]
        public string RunName { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("finishedDate")]
        public string FinishedDate { get; set; }

        [JsonProperty("url")]
        public string RunURL { get; set; }

        [JsonProperty("templateParameters")]
        public JToken TemplateParameters { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }

        [JsonProperty("resources")]
        public JToken Resources { get; set; }

        [JsonProperty("pipeline")]
        public PipelineRunPipelineType Pipeline { get; set; }
    }

    public class PipelineRunPipelineType
    {
        [JsonProperty("id")]
        public int PipelineId { get; set; }

        [JsonProperty("name")]
        public string PipelineName { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("url")]
        public string PipelineURL { get; set; }
    }

    public class GitItem
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("commitId")]
        public string CommitId { get; set; }

        [JsonProperty("gitObjectType")]
        public string GitObjectType { get; set; }

        [JsonProperty("path")]
        public string ItemPath { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("url")]
        public string ItemURL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum versionDescriptorVersionTypeInput
    {
        [EnumMember(Value = "branch")]
        Branch,
        [EnumMember(Value = "commit")]
        Commit,
        [EnumMember(Value = "tag")]
        Tag
    }

    public class GitRefList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GitRefItem[] Refs { get; set; }
    }

    public class GitRefItem
    {
        [JsonProperty("name")]
        public string RefName { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("peeledObjectId")]
        public string PeeledObjectId { get; set; }

        [JsonProperty("url")]
        public string RefURL { get; set; }

        [JsonProperty("creator")]
        public JToken Creator { get; set; }
    }

    public class GitPushResponse
    {
        [JsonProperty("pushId")]
        public int PushId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string PushURL { get; set; }

        [JsonProperty("pushedBy")]
        public JToken PushedBy { get; set; }

        [JsonProperty("refUpdates")]
        public GitRefItem[] RefUpdates { get; set; }

        [JsonProperty("commits")]
        public GitPushResponseCommitsTypeItem[] Commits { get; set; }
    }

    public class GitPushResponseCommitsTypeItem
    {
        [JsonProperty("commitId")]
        public string CommitId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("url")]
        public string CommitURL { get; set; }
    }

    public class GitRefUpdateRequest
    {
        [JsonProperty("name")]
        public string RefName { get; set; }

        [JsonProperty("oldObjectId")]
        public string OldObjectId { get; set; }

        [JsonProperty("newObjectId")]
        public string NewObjectId { get; set; }
    }

    public class GitCommitRequest
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("changes")]
        public GitChange[] Changes { get; set; }
    }

    public class GitChange
    {
        [JsonProperty("changeType")]
        public GitChangeChangeTypeType ChangeType { get; set; }

        [JsonProperty("item")]
        public GitChangeItemType Item { get; set; }

        [JsonProperty("newContent")]
        public GitChangeNewContentType NewContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GitChangeChangeTypeType
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "edit")]
        Edit,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "rename")]
        Rename
    }

    public class GitChangeItemType
    {
        [JsonProperty("path")]
        public string ItemPath { get; set; }
    }

    public class GitChangeNewContentType
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public GitChangeNewContentTypeContentTypeType ContentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GitChangeNewContentTypeContentTypeType
    {
        [EnumMember(Value = "rawtext")]
        Rawtext,
        [EnumMember(Value = "base64encoded")]
        Base64encoded
    }

    public class GitPullRequestResponse
    {
        [JsonProperty("pullRequestId")]
        public int PullRequestId { get; set; }

        [JsonProperty("codeReviewId")]
        public int CodeReviewId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceRefName")]
        public string SourceBranch { get; set; }

        [JsonProperty("targetRefName")]
        public string TargetBranch { get; set; }

        [JsonProperty("mergeStatus")]
        public string MergeStatus { get; set; }

        [JsonProperty("isDraft")]
        public bool IsDraft { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("url")]
        public string PullRequestURL { get; set; }

        [JsonProperty("createdBy")]
        public JToken CreatedBy { get; set; }

        [JsonProperty("repository")]
        public JToken Repository { get; set; }
    }

    public class GitPullRequestWorkItemRef
    {
        [JsonProperty("id")]
        public string WorkItemId { get; set; }
    }

    public class GitPullRequestReviewerRef
    {
        [JsonProperty("id")]
        public string ReviewerId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }

    public class pullRequestlabelsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum pullRequeststatusInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "abandoned")]
        Abandoned,
        [EnumMember(Value = "completed")]
        Completed
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