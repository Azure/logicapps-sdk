//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Visualstudioteamservices
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VisualstudioteamservicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemSearchResponse> SearchWorkItemsAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> searchRequestsearchText, [WorkflowExpression] Func<int> searchRequestskip = null, [WorkflowExpression] Func<int> searchRequesttop = null, [WorkflowExpression] Func<bool> searchRequestincludeFacets = null, [WorkflowExpression] Func<SortOption[]> searchRequestorderBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_apis/search/workitemsearchresults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                var searchRequest = new JObject();
                var searchRequestpropCount = 0;
                searchRequestpropCount++;
                searchRequest["searchText"] = SourceExpressionConverter.ConvertToken(searchRequestsearchText);
                if (searchRequestskip != null)
                {
                    searchRequest["$skip"] = SourceExpressionConverter.ConvertToken(searchRequestskip);
                    searchRequestpropCount++;
                }

                if (searchRequesttop != null)
                {
                    searchRequest["$top"] = SourceExpressionConverter.ConvertToken(searchRequesttop);
                    searchRequestpropCount++;
                }

                var filtersObject = new JObject();
                var filtersObjectpropCount = 0;
                if (filtersObjectpropCount > 0)
                {
                    searchRequest["filters"] = filtersObject;
                    searchRequestpropCount++;
                }

                if (searchRequestincludeFacets != null)
                {
                    searchRequest["includeFacets"] = SourceExpressionConverter.ConvertToken(searchRequestincludeFacets);
                    searchRequestpropCount++;
                }

                if (searchRequestorderBy != null)
                {
                    searchRequest["$orderBy"] = SourceExpressionConverter.ConvertToken(searchRequestorderBy);
                    searchRequestpropCount++;
                }

                if (searchRequestpropCount > 0)
                {
                    callPayload.Body = searchRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<BuildResult> GetBuildAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> buildId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/builds/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(buildId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<BuildResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Timeline> GetBuildTimelineAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> buildId, [WorkflowExpression] Func<string> timelineId = null, [WorkflowExpression] Func<int> changeId = null, [WorkflowExpression] Func<string> planId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/builds/{1}/timeline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(buildId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (timelineId != null)
                    callPayload.Queries["timelineId"] = SourceExpressionConverter.ConvertO(timelineId);
                if (changeId != null)
                    callPayload.Queries["changeId"] = SourceExpressionConverter.ConvertO(changeId);
                if (planId != null)
                    callPayload.Queries["planId"] = SourceExpressionConverter.ConvertO(planId);
                return callPayload;
            }

            return new ApiConnectionAction<Timeline>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListAccount> ListAccounts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_apis/Accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListAccount>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Profile> GetProfile([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/profile/profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Profile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListTeamSettingsIteration> ListIterations([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/iterations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListTeamSettingsIteration>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListGitRef> ListBuildBranchesAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/branches", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListGitRef>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListBuildResult> ListBuilds([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> definitions = null, [WorkflowExpression] Func<string> buildNumber = null, [WorkflowExpression] Func<string> branchName = null, [WorkflowExpression] Func<resultFilterInput> resultFilter = null, [WorkflowExpression] Func<statusFilterInput> statusFilter = null, [WorkflowExpression] Func<reasonFilterInput> reasonFilter = null, [WorkflowExpression] Func<string> requestedFor = null, [WorkflowExpression] Func<string> minTime = null, [WorkflowExpression] Func<string> maxTime = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/builds", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (definitions != null)
                    callPayload.Queries["definitions"] = SourceExpressionConverter.ConvertO(definitions);
                if (buildNumber != null)
                    callPayload.Queries["buildNumber"] = SourceExpressionConverter.ConvertO(buildNumber);
                if (branchName != null)
                    callPayload.Queries["branchName"] = SourceExpressionConverter.ConvertO(branchName);
                if (resultFilter != null)
                    callPayload.Queries["resultFilter"] = SourceExpressionConverter.Convert(resultFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.Convert(statusFilter);
                if (reasonFilter != null)
                    callPayload.Queries["reasonFilter"] = SourceExpressionConverter.Convert(reasonFilter);
                if (requestedFor != null)
                    callPayload.Queries["requestedFor"] = SourceExpressionConverter.ConvertO(requestedFor);
                if (minTime != null)
                    callPayload.Queries["minTime"] = SourceExpressionConverter.ConvertO(minTime);
                if (maxTime != null)
                    callPayload.Queries["maxTime"] = SourceExpressionConverter.ConvertO(maxTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListBuildResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<BuildResult> QueueNewBuild([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> buildDefId, [WorkflowExpression] Func<string> buildDetailssourceBranch = null, [WorkflowExpression] Func<string> buildDetailsparameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/builds", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["buildDefId"] = SourceExpressionConverter.ConvertO(buildDefId);
                var buildDetails = new JObject();
                var buildDetailspropCount = 0;
                if (buildDetailssourceBranch != null)
                {
                    buildDetails["sourceBranch"] = SourceExpressionConverter.ConvertToken(buildDetailssourceBranch);
                    buildDetailspropCount++;
                }

                if (buildDetailsparameters != null)
                {
                    buildDetails["parameters"] = SourceExpressionConverter.ConvertToken(buildDetailsparameters);
                    buildDetailspropCount++;
                }

                if (buildDetailspropCount > 0)
                {
                    callPayload.Body = buildDetails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuildResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListTeamMember> ListBuildRequestersAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/requesters", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListTeamMember>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListGitRepository> ListGitRepositories([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/git/repositories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListGitRepository>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListProject> ListProjects([WorkflowExpression] Func<string> account)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_apis/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListReleaseDefinition> ListReleaseDefinitions([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/definitions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListReleaseDefinition>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Release> CreateRelease([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> releaseDefId, [WorkflowExpression] Func<string> releaseStartMetadatadescription = null, [WorkflowExpression] Func<bool> releaseStartMetadataisDraft = null, [WorkflowExpression] Func<releaseStartMetadatareasonInput> releaseStartMetadatareason = null, [WorkflowExpression] Func<ConfigurationVariable[]> releaseStartMetadatareleaseVariables = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/releases", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["releaseDefId"] = SourceExpressionConverter.ConvertO(releaseDefId);
                var releaseStartMetadata = new JObject();
                var releaseStartMetadatapropCount = 0;
                if (releaseStartMetadatadescription != null)
                {
                    releaseStartMetadata["Description"] = SourceExpressionConverter.ConvertToken(releaseStartMetadatadescription);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadataisDraft != null)
                {
                    releaseStartMetadata["IsDraft"] = SourceExpressionConverter.ConvertToken(releaseStartMetadataisDraft);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadatareason != null)
                {
                    releaseStartMetadata["Reason"] = SourceExpressionConverter.Convert(releaseStartMetadatareason);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadatareleaseVariables != null)
                {
                    releaseStartMetadata["Variables"] = SourceExpressionConverter.ConvertToken(releaseStartMetadatareleaseVariables);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadatapropCount > 0)
                {
                    callPayload.Body = releaseStartMetadata;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Release>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parametersrelativeURI, [WorkflowExpression] Func<string> parametersbody = null, [WorkflowExpression] Func<bool> parametersbodyIsBase64 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["Method"] = SourceExpressionConverter.Convert(parametersmethod);
                parameterspropCount++;
                parameters["Uri"] = SourceExpressionConverter.ConvertToken(parametersrelativeURI);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["Headers"] = headersObject;
                    parameterspropCount++;
                }

                if (parametersbody != null)
                {
                    parameters["Body"] = SourceExpressionConverter.ConvertToken(parametersbody);
                    parameterspropCount++;
                }

                if (parametersbodyIsBase64 != null)
                {
                    parameters["IsBase64"] = SourceExpressionConverter.ConvertToken(parametersbodyIsBase64);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListWorkItemField> ListWorkItemFieldsAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<expandInput> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_apis/wit/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.Convert(expand);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListWorkItemField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListWorkItemType> ListWorkItemTypes([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_apis/wit/workitemtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListWorkItemType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<DynamicWorkItemResponse> GetWorkItemDetails([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> typeName, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["typeName"] = SourceExpressionConverter.ConvertO(typeName);
                return callPayload;
            }

            return new ApiConnectionAction<DynamicWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse> UpdateWorkItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> workItemtitle = null, [WorkflowExpression] Func<string> workItemdescription = null, [WorkflowExpression] Func<int> workItempriority = null, [WorkflowExpression] Func<string> workItemiterationPath = null, [WorkflowExpression] Func<string> workItemareaPath = null, [WorkflowExpression] Func<string> workItemlinkURL = null, [WorkflowExpression] Func<workItemlinkTypeInput> workItemlinkType = null, [WorkflowExpression] Func<string> workItemlinkComment = null, [WorkflowExpression] Func<object> workItemdynamicFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                var workItem = new JObject();
                var workItempropCount = 0;
                if (workItemtitle != null)
                {
                    workItem["title"] = SourceExpressionConverter.ConvertToken(workItemtitle);
                    workItempropCount++;
                }

                if (workItemdescription != null)
                {
                    workItem["description"] = SourceExpressionConverter.ConvertToken(workItemdescription);
                    workItempropCount++;
                }

                if (workItempriority != null)
                {
                    workItem["priority"] = SourceExpressionConverter.ConvertToken(workItempriority);
                    workItempropCount++;
                }

                if (workItemiterationPath != null)
                {
                    workItem["iteration"] = SourceExpressionConverter.ConvertToken(workItemiterationPath);
                    workItempropCount++;
                }

                if (workItemareaPath != null)
                {
                    workItem["area"] = SourceExpressionConverter.ConvertToken(workItemareaPath);
                    workItempropCount++;
                }

                if (workItemlinkURL != null)
                {
                    workItem["linkUrl"] = SourceExpressionConverter.ConvertToken(workItemlinkURL);
                    workItempropCount++;
                }

                if (workItemlinkType != null)
                {
                    workItem["linkType"] = SourceExpressionConverter.Convert(workItemlinkType);
                    workItempropCount++;
                }

                if (workItemlinkComment != null)
                {
                    workItem["linkComment"] = SourceExpressionConverter.ConvertToken(workItemlinkComment);
                    workItempropCount++;
                }

                if (workItemdynamicFields != null)
                {
                    workItem["dynamicFields"] = SourceExpressionConverter.ConvertToken(workItemdynamicFields);
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
                return callPayload;
            }

            return new ApiConnectionAction<PatchWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemDetailsV2Response> GetWorkItemDetailsV2Async([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> typeName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> asOf = null, [WorkflowExpression] Func<expandInput> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/v2/workitems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["typeName"] = SourceExpressionConverter.ConvertO(typeName);
                if (asOf != null)
                    callPayload.Queries["asOf"] = SourceExpressionConverter.ConvertO(asOf);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.Convert(expand);
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemDetailsV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> GetWorkItemChildren([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workItemType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["workItemType"] = Convert.ToString("");
                if (workItemType != null)
                    callPayload.Queries["workItemType"] = SourceExpressionConverter.ConvertO(workItemType);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListListWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemAttachmentResponse> GetWorkItemAttachmentAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> fileName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (fileName != null)
                    callPayload.Queries["fileName"] = SourceExpressionConverter.ConvertO(fileName);
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemAttachmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemCommentsResponse> GetWorkItemCommentsAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> workItemId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<bool> includeDeleted = null, [WorkflowExpression] Func<expandInput> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                callPayload.Queries["includeDeleted"] = Convert.ToString(false);
                if (includeDeleted != null)
                    callPayload.Queries["includeDeleted"] = SourceExpressionConverter.ConvertO(includeDeleted);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.Convert(expand);
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCommentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemComment> CreateWorkItemCommentAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> workItemId, [WorkflowExpression] Func<string> commentcommentText, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workItemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["format"] = Convert.ToString("markdown");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["text"] = SourceExpressionConverter.ConvertToken(commentcommentText);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse> AddWorkItemLinkAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> type, [WorkflowExpression] Func<int> workItemId, [WorkflowExpression] Func<linkRequestlinkTypeInput> linkRequestlinkType, [WorkflowExpression] Func<string> linkRequesttargetURL, [WorkflowExpression] Func<string> linkRequestcomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workItemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                var linkRequest = new JObject();
                var linkRequestpropCount = 0;
                linkRequestpropCount++;
                linkRequest["linkType"] = SourceExpressionConverter.Convert(linkRequestlinkType);
                linkRequestpropCount++;
                linkRequest["targetUrl"] = SourceExpressionConverter.ConvertToken(linkRequesttargetURL);
                if (linkRequestcomment != null)
                {
                    linkRequest["comment"] = SourceExpressionConverter.ConvertToken(linkRequestcomment);
                    linkRequestpropCount++;
                }

                if (linkRequestpropCount > 0)
                {
                    callPayload.Body = linkRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse> DeleteWorkItemLinkAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> type, [WorkflowExpression] Func<int> workItemId, [WorkflowExpression] Func<int> linkRequestrelationId = null, [WorkflowExpression] Func<string> linkRequestworkItemLinkToRemove = null, [WorkflowExpression] Func<linkRequestlinkRelationTypeInput> linkRequestlinkRelationType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/links/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workItemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                var linkRequest = new JObject();
                var linkRequestpropCount = 0;
                if (linkRequestrelationId != null)
                {
                    linkRequest["linkId"] = SourceExpressionConverter.ConvertToken(linkRequestrelationId);
                    linkRequestpropCount++;
                }

                if (linkRequestworkItemLinkToRemove != null)
                {
                    linkRequest["workItemLinkToRemove"] = SourceExpressionConverter.ConvertToken(linkRequestworkItemLinkToRemove);
                    linkRequestpropCount++;
                }

                if (linkRequestlinkRelationType != null)
                {
                    linkRequest["linkType"] = SourceExpressionConverter.Convert(linkRequestlinkRelationType);
                    linkRequestpropCount++;
                }

                if (linkRequestpropCount > 0)
                {
                    callPayload.Body = linkRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<WorkItemComment> UpdateWorkItemCommentAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> workItemId, [WorkflowExpression] Func<int> commentId, [WorkflowExpression] Func<string> commentcommentText, [WorkflowExpression] Func<formatInput> format = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/comments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workItemId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(commentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["format"] = Convert.ToString("markdown");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["text"] = SourceExpressionConverter.ConvertToken(commentcommentText);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IWorkflowAction DeleteWorkItemCommentAsync([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> workItemId, [WorkflowExpression] Func<int> commentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/comments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workItemId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(commentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse> CreateWorkItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> workItemtitle, [WorkflowExpression] Func<bool> shouldReturnAllFields = null, [WorkflowExpression] Func<string> workItemdescription = null, [WorkflowExpression] Func<int> workItempriority = null, [WorkflowExpression] Func<string> workItemiterationPath = null, [WorkflowExpression] Func<string> workItemareaPath = null, [WorkflowExpression] Func<string> workItemlinkURL = null, [WorkflowExpression] Func<workItemlinkTypeInput> workItemlinkType = null, [WorkflowExpression] Func<string> workItemlinkComment = null, [WorkflowExpression] Func<object> workItemdynamicFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/wit/workitems/${1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (shouldReturnAllFields != null)
                    callPayload.Queries["shouldReturnAllFields"] = SourceExpressionConverter.ConvertO(shouldReturnAllFields);
                var workItem = new JObject();
                var workItempropCount = 0;
                workItempropCount++;
                workItem["title"] = SourceExpressionConverter.ConvertToken(workItemtitle);
                if (workItemdescription != null)
                {
                    workItem["description"] = SourceExpressionConverter.ConvertToken(workItemdescription);
                    workItempropCount++;
                }

                if (workItempriority != null)
                {
                    workItem["priority"] = SourceExpressionConverter.ConvertToken(workItempriority);
                    workItempropCount++;
                }

                if (workItemiterationPath != null)
                {
                    workItem["iteration"] = SourceExpressionConverter.ConvertToken(workItemiterationPath);
                    workItempropCount++;
                }

                if (workItemareaPath != null)
                {
                    workItem["area"] = SourceExpressionConverter.ConvertToken(workItemareaPath);
                    workItempropCount++;
                }

                if (workItemlinkURL != null)
                {
                    workItem["linkUrl"] = SourceExpressionConverter.ConvertToken(workItemlinkURL);
                    workItempropCount++;
                }

                if (workItemlinkType != null)
                {
                    workItem["linkType"] = SourceExpressionConverter.Convert(workItemlinkType);
                    workItempropCount++;
                }

                if (workItemlinkComment != null)
                {
                    workItem["linkComment"] = SourceExpressionConverter.ConvertToken(workItemlinkComment);
                    workItempropCount++;
                }

                if (workItemdynamicFields != null)
                {
                    workItem["dynamicFields"] = SourceExpressionConverter.ConvertToken(workItemdynamicFields);
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
                return callPayload;
            }

            return new ApiConnectionAction<PatchWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListRootQueryFolders([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/queries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListQueryHierarchyItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListQueriesInFolder([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> folderPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/queriesInFolder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListQueryHierarchyItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> ListWorkItems([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> workItemIds, [WorkflowExpression] Func<string> workItemType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/wit/workitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["workItemIds"] = SourceExpressionConverter.ConvertO(workItemIds);
                callPayload.Queries["workItemType"] = Convert.ToString("");
                if (workItemType != null)
                    callPayload.Queries["workItemType"] = SourceExpressionConverter.ConvertO(workItemType);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListListWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Pipeline> ListPipelines([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/{0}/_apis/pipelines", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<Pipeline>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Run> ListPipelineRuns([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> pipelineId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/{0}/_apis/pipelines/{1}/runs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pipelineId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                return callPayload;
            }

            return new ApiConnectionAction<Run>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryResultWorkItemResponse> GetQueryResults([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> queryId, [WorkflowExpression] Func<int> workItemsCount = null, [WorkflowExpression] Func<bool> throwIfQueryChanged = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/{0}/queryResults/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["workItemsCount"] = Convert.ToString(200);
                if (workItemsCount != null)
                    callPayload.Queries["workItemsCount"] = SourceExpressionConverter.ConvertO(workItemsCount);
                if (throwIfQueryChanged != null)
                    callPayload.Queries["throwIfQueryChanged"] = SourceExpressionConverter.ConvertO(throwIfQueryChanged);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListQueryResultWorkItemResponse>(BuildSourceInput);
        }
    }

    public class VisualstudioteamservicesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<VstsListBuildResult> OnBuildCompleted([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<resultFilterInput> resultFilter = null, [WorkflowExpression] Func<string> definitions = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/buildcompleted_trigger/{0}/_apis/build/builds", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (resultFilter != null)
                    callPayload.Queries["resultFilter"] = SourceExpressionConverter.Convert(resultFilter);
                if (definitions != null)
                    callPayload.Queries["definitions"] = SourceExpressionConverter.ConvertO(definitions);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListBuildResult>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListGitPush> OnGitPush([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> refName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gitpushed_trigger/{0}/_apis/git/repositories/{1}/pushes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (refName != null)
                    callPayload.Queries["refName"] = SourceExpressionConverter.ConvertO(refName);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListGitPush>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListGitPullRequest> OnGitPullCreated([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> sourceRefName = null, [WorkflowExpression] Func<string> targetRefName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gitpullcreated_trigger/{0}/_apis/git/repositories/{1}/pullrequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (sourceRefName != null)
                    callPayload.Queries["sourceRefName"] = SourceExpressionConverter.ConvertO(sourceRefName);
                if (targetRefName != null)
                    callPayload.Queries["targetRefName"] = SourceExpressionConverter.ConvertO(targetRefName);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListGitPullRequest>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListGitPullRequest> OnGitPullClosed([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> sourceRefName = null, [WorkflowExpression] Func<string> targetRefName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gitpullclosed_trigger/{0}/_apis/git/repositories/{1}/pullrequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (sourceRefName != null)
                    callPayload.Queries["sourceRefName"] = SourceExpressionConverter.ConvertO(sourceRefName);
                if (targetRefName != null)
                    callPayload.Queries["targetRefName"] = SourceExpressionConverter.ConvertO(targetRefName);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListGitPullRequest>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListTfvcChangeset> OnTfvcCheckIn([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> author = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tfvccheckin_trigger/_apis/tfvc/changesets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (team != null)
                    callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                if (author != null)
                    callPayload.Queries["author"] = SourceExpressionConverter.ConvertO(author);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListTfvcChangeset>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemAssigned([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team, [WorkflowExpression] Func<string> wiqlSystemAssignedTo, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/workitemassigned_trigger/{0}/_apis/wit/wiql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                callPayload.Queries["wiql__System_AssignedTo"] = SourceExpressionConverter.ConvertO(wiqlSystemAssignedTo);
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = SourceExpressionConverter.ConvertO(wiqlSystemWorkItemType);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = SourceExpressionConverter.ConvertO(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = SourceExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = SourceExpressionConverter.ConvertO(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = SourceExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = SourceExpressionConverter.ConvertO(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = SourceExpressionConverter.ConvertO(wiqlSystemCreatedBy);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemClosed([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> wiqlSystemAssignedTo = null, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> closedState = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/workitemclosed_trigger/{0}/_apis/wit/wiql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (team != null)
                    callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                if (wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = SourceExpressionConverter.ConvertO(wiqlSystemAssignedTo);
                callPayload.Queries["wiql__System_WorkItemType"] = Convert.ToString("Bug");
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = SourceExpressionConverter.ConvertO(wiqlSystemWorkItemType);
                callPayload.Queries["closedState"] = Convert.ToString("Done, Closed, Completed, Inactive");
                if (closedState != null)
                    callPayload.Queries["closedState"] = SourceExpressionConverter.ConvertO(closedState);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = SourceExpressionConverter.ConvertO(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = SourceExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = SourceExpressionConverter.ConvertO(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = SourceExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = SourceExpressionConverter.ConvertO(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = SourceExpressionConverter.ConvertO(wiqlSystemCreatedBy);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemCreated([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> wiqlSystemAssignedTo = null, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/workitemcreated_trigger/{0}/_apis/wit/wiql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (team != null)
                    callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                if (wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = SourceExpressionConverter.ConvertO(wiqlSystemAssignedTo);
                callPayload.Queries["wiql__System_WorkItemType"] = Convert.ToString("Bug");
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = SourceExpressionConverter.ConvertO(wiqlSystemWorkItemType);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = SourceExpressionConverter.ConvertO(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = SourceExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = SourceExpressionConverter.ConvertO(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = SourceExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = SourceExpressionConverter.ConvertO(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = SourceExpressionConverter.ConvertO(wiqlSystemCreatedBy);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemUpdated([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> wiqlSystemAssignedTo = null, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/workitemupdated_trigger/{0}/_apis/wit/wiql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                if (team != null)
                    callPayload.Queries["team"] = SourceExpressionConverter.ConvertO(team);
                if (wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = SourceExpressionConverter.ConvertO(wiqlSystemAssignedTo);
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = SourceExpressionConverter.ConvertO(wiqlSystemWorkItemType);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = SourceExpressionConverter.ConvertO(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = SourceExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = SourceExpressionConverter.ConvertO(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = SourceExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = SourceExpressionConverter.ConvertO(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = SourceExpressionConverter.ConvertO(wiqlSystemCreatedBy);
                return callPayload;
            }

            return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum ReleaseStatusType
    {
        Undefined,
        Draft,
        Active,
        Abandoned
    }

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

    public enum orderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public enum formatInput
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "html")]
        Html
    }

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

    public enum WorkItemQueryClauseLogicalOperatorType
    {
        NONE,
        AND,
        OR
    }

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

    public enum areaPathComparisonInput
    {
        Equals,
        Under
    }

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