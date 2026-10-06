//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Visualstudioteamservices
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VisualstudioteamservicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListAccount> ListAccounts()
        {
            var apiCallPath = "/_apis/Accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VstsListAccount>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildGetProfile))]
        public IBodyWorkflowAction<Profile> GetProfile([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Profile> __BuildGetProfile(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<Profile>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/profile/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Profile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListIterations))]
        public IBodyWorkflowAction<VstsListTeamSettingsIteration> ListIterations([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListTeamSettingsIteration> __BuildListIterations(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> team)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: true);
            return new DeferredBodyAction<VstsListTeamSettingsIteration>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/iterations", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                return new ApiConnectionAction<VstsListTeamSettingsIteration>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildQueueNewBuild))]
        public IBodyWorkflowAction<BuildResult> QueueNewBuild([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> buildDefId, [WorkflowExpression] Func<string> buildDetailssourceBranch = null, [WorkflowExpression] Func<string> buildDetailsparameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuildResult> __BuildQueueNewBuild(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> buildDefId, WorkflowExpression<string> buildDetailssourceBranch = null, WorkflowExpression<string> buildDetailsparameters = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(buildDefId, nameof(buildDefId), required: true);
            WorkflowExpression.Validate(buildDetailssourceBranch, nameof(buildDetailssourceBranch), required: false);
            WorkflowExpression.Validate(buildDetailsparameters, nameof(buildDetailsparameters), required: false);
            return new DeferredBodyAction<BuildResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/builds", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["buildDefId"] = ExpressionConverter.Convert(buildDefId);
                var buildDetails = new JObject();
                var buildDetailspropCount = 0;
                if (buildDetailssourceBranch != null)
                {
                    buildDetails["sourceBranch"] = ExpressionConverter.ConvertO(buildDetailssourceBranch);
                    buildDetailspropCount++;
                }

                if (buildDetailsparameters != null)
                {
                    buildDetails["parameters"] = ExpressionConverter.ConvertO(buildDetailsparameters);
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
        [WorkflowExpressionFactory(nameof(__BuildListGitRepositories))]
        public IBodyWorkflowAction<VstsListGitRepository> ListGitRepositories([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListGitRepository> __BuildListGitRepositories(WorkflowExpression<string> account, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListGitRepository>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/git/repositories", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<VstsListGitRepository>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListProjects))]
        public IBodyWorkflowAction<VstsListProject> ListProjects([WorkflowExpression] Func<string> account)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListProject> __BuildListProjects(WorkflowExpression<string> account)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            return new DeferredBodyAction<VstsListProject>(() =>
            {
                var apiCallPath = "/_apis/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<VstsListProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListReleaseDefinitions))]
        public IBodyWorkflowAction<VstsListReleaseDefinition> ListReleaseDefinitions([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListReleaseDefinition> __BuildListReleaseDefinitions(WorkflowExpression<string> account, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListReleaseDefinition>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/definitions", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<VstsListReleaseDefinition>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRelease))]
        public IBodyWorkflowAction<Release> CreateRelease([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> releaseDefId, [WorkflowExpression] Func<string> releaseStartMetadatadescription = null, [WorkflowExpression] Func<bool> releaseStartMetadataisDraft = null, [WorkflowExpression] Func<releaseStartMetadatareasonInput> releaseStartMetadatareason = null, [WorkflowExpression] Func<ConfigurationVariable[]> releaseStartMetadatareleaseVariables = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Release> __BuildCreateRelease(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> releaseDefId, WorkflowExpression<string> releaseStartMetadatadescription = null, WorkflowExpression<bool> releaseStartMetadataisDraft = null, WorkflowExpression<releaseStartMetadatareasonInput> releaseStartMetadatareason = null, WorkflowExpression<ConfigurationVariable[]> releaseStartMetadatareleaseVariables = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(releaseDefId, nameof(releaseDefId), required: true);
            WorkflowExpression.Validate(releaseStartMetadatadescription, nameof(releaseStartMetadatadescription), required: false);
            WorkflowExpression.Validate(releaseStartMetadataisDraft, nameof(releaseStartMetadataisDraft), required: false);
            WorkflowExpression.Validate(releaseStartMetadatareason, nameof(releaseStartMetadatareason), required: false);
            WorkflowExpression.Validate(releaseStartMetadatareleaseVariables, nameof(releaseStartMetadatareleaseVariables), required: false);
            return new DeferredBodyAction<Release>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/releases", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["releaseDefId"] = ExpressionConverter.Convert(releaseDefId);
                var releaseStartMetadata = new JObject();
                var releaseStartMetadatapropCount = 0;
                if (releaseStartMetadatadescription != null)
                {
                    releaseStartMetadata["Description"] = ExpressionConverter.ConvertO(releaseStartMetadatadescription);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadataisDraft != null)
                {
                    releaseStartMetadata["IsDraft"] = ExpressionConverter.ConvertO(releaseStartMetadataisDraft);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadatareason != null)
                {
                    releaseStartMetadata["Reason"] = ExpressionConverter.ConvertO(releaseStartMetadatareason);
                    releaseStartMetadatapropCount++;
                }

                if (releaseStartMetadatareleaseVariables != null)
                {
                    releaseStartMetadata["Variables"] = ExpressionConverter.ConvertO(releaseStartMetadatareleaseVariables);
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
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parametersrelativeURI, [WorkflowExpression] Func<string> parametersbody = null, [WorkflowExpression] Func<bool> parametersbodyIsBase64 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowExpression<string> account, WorkflowExpression<parametersmethodInput> parametersmethod, WorkflowExpression<string> parametersrelativeURI, WorkflowExpression<string> parametersbody = null, WorkflowExpression<bool> parametersbodyIsBase64 = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(parametersmethod, nameof(parametersmethod), required: true);
            WorkflowExpression.Validate(parametersrelativeURI, nameof(parametersrelativeURI), required: true);
            WorkflowExpression.Validate(parametersbody, nameof(parametersbody), required: false);
            WorkflowExpression.Validate(parametersbodyIsBase64, nameof(parametersbodyIsBase64), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["Method"] = ExpressionConverter.ConvertO(parametersmethod);
                parameterspropCount++;
                parameters["Uri"] = ExpressionConverter.ConvertO(parametersrelativeURI);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["Headers"] = headersObject;
                    parameterspropCount++;
                }

                if (parametersbody != null)
                {
                    parameters["Body"] = ExpressionConverter.ConvertO(parametersbody);
                    parameterspropCount++;
                }

                if (parametersbodyIsBase64 != null)
                {
                    parameters["IsBase64"] = ExpressionConverter.ConvertO(parametersbodyIsBase64);
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
        [WorkflowExpressionFactory(nameof(__BuildListWorkItemTypes))]
        public IBodyWorkflowAction<VstsListWorkItemType> ListWorkItemTypes([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListWorkItemType> __BuildListWorkItemTypes(WorkflowExpression<string> account, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListWorkItemType>(() =>
            {
                var apiCallPath = "/_apis/wit/workitemtypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                return new ApiConnectionAction<VstsListWorkItemType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkItemDetails))]
        public IBodyWorkflowAction<DynamicWorkItemResponse> GetWorkItemDetails([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> typeName, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DynamicWorkItemResponse> __BuildGetWorkItemDetails(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> typeName, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(typeName, nameof(typeName), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<DynamicWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["typeName"] = ExpressionConverter.Convert(typeName);
                return new ApiConnectionAction<DynamicWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkItem))]
        public IBodyWorkflowAction<PatchWorkItemResponse> UpdateWorkItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> workItemtitle = null, [WorkflowExpression] Func<string> workItemdescription = null, [WorkflowExpression] Func<int> workItempriority = null, [WorkflowExpression] Func<string> workItemiterationPath = null, [WorkflowExpression] Func<string> workItemareaPath = null, [WorkflowExpression] Func<string> workItemlinkURL = null, [WorkflowExpression] Func<workItemlinkTypeInput> workItemlinkType = null, [WorkflowExpression] Func<string> workItemlinkComment = null, [WorkflowExpression] Func<object> workItemdynamicFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchWorkItemResponse> __BuildUpdateWorkItem(WorkflowExpression<string> account, WorkflowExpression<string> id, WorkflowExpression<string> project = null, WorkflowExpression<string> type = null, WorkflowExpression<string> workItemtitle = null, WorkflowExpression<string> workItemdescription = null, WorkflowExpression<int> workItempriority = null, WorkflowExpression<string> workItemiterationPath = null, WorkflowExpression<string> workItemareaPath = null, WorkflowExpression<string> workItemlinkURL = null, WorkflowExpression<workItemlinkTypeInput> workItemlinkType = null, WorkflowExpression<string> workItemlinkComment = null, WorkflowExpression<object> workItemdynamicFields = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(workItemtitle, nameof(workItemtitle), required: false);
            WorkflowExpression.Validate(workItemdescription, nameof(workItemdescription), required: false);
            WorkflowExpression.Validate(workItempriority, nameof(workItempriority), required: false);
            WorkflowExpression.Validate(workItemiterationPath, nameof(workItemiterationPath), required: false);
            WorkflowExpression.Validate(workItemareaPath, nameof(workItemareaPath), required: false);
            WorkflowExpression.Validate(workItemlinkURL, nameof(workItemlinkURL), required: false);
            WorkflowExpression.Validate(workItemlinkType, nameof(workItemlinkType), required: false);
            WorkflowExpression.Validate(workItemlinkComment, nameof(workItemlinkComment), required: false);
            WorkflowExpression.Validate(workItemdynamicFields, nameof(workItemdynamicFields), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (project != null)
                    callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                var workItem = new JObject();
                var workItempropCount = 0;
                if (workItemtitle != null)
                {
                    workItem["title"] = ExpressionConverter.ConvertO(workItemtitle);
                    workItempropCount++;
                }

                if (workItemdescription != null)
                {
                    workItem["description"] = ExpressionConverter.ConvertO(workItemdescription);
                    workItempropCount++;
                }

                if (workItempriority != null)
                {
                    workItem["priority"] = ExpressionConverter.ConvertO(workItempriority);
                    workItempropCount++;
                }

                if (workItemiterationPath != null)
                {
                    workItem["iteration"] = ExpressionConverter.ConvertO(workItemiterationPath);
                    workItempropCount++;
                }

                if (workItemareaPath != null)
                {
                    workItem["area"] = ExpressionConverter.ConvertO(workItemareaPath);
                    workItempropCount++;
                }

                if (workItemlinkURL != null)
                {
                    workItem["linkUrl"] = ExpressionConverter.ConvertO(workItemlinkURL);
                    workItempropCount++;
                }

                if (workItemlinkType != null)
                {
                    workItem["linkType"] = ExpressionConverter.ConvertO(workItemlinkType);
                    workItempropCount++;
                }

                if (workItemlinkComment != null)
                {
                    workItem["linkComment"] = ExpressionConverter.ConvertO(workItemlinkComment);
                    workItempropCount++;
                }

                if (workItemdynamicFields != null)
                {
                    workItem["dynamicFields"] = ExpressionConverter.ConvertO(workItemdynamicFields);
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
        [WorkflowExpressionFactory(nameof(__BuildGetWorkItemChildren))]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> GetWorkItemChildren([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> workItemType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> __BuildGetWorkItemChildren(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> id, WorkflowExpression<string> workItemType = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(workItemType, nameof(workItemType), required: false);
            return new DeferredBodyAction<VstsListListWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["workItemType"] = Convert.ToString("");
                if (workItemType != null)
                    callPayload.Queries["workItemType"] = ExpressionConverter.Convert(workItemType);
                return new ApiConnectionAction<VstsListListWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkItem))]
        public IBodyWorkflowAction<PatchWorkItemResponse> CreateWorkItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> workItemtitle, [WorkflowExpression] Func<bool> shouldReturnAllFields = null, [WorkflowExpression] Func<string> workItemdescription = null, [WorkflowExpression] Func<int> workItempriority = null, [WorkflowExpression] Func<string> workItemiterationPath = null, [WorkflowExpression] Func<string> workItemareaPath = null, [WorkflowExpression] Func<string> workItemlinkURL = null, [WorkflowExpression] Func<workItemlinkTypeInput> workItemlinkType = null, [WorkflowExpression] Func<string> workItemlinkComment = null, [WorkflowExpression] Func<object> workItemdynamicFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchWorkItemResponse> __BuildCreateWorkItem(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> type, WorkflowExpression<string> workItemtitle, WorkflowExpression<bool> shouldReturnAllFields = null, WorkflowExpression<string> workItemdescription = null, WorkflowExpression<int> workItempriority = null, WorkflowExpression<string> workItemiterationPath = null, WorkflowExpression<string> workItemareaPath = null, WorkflowExpression<string> workItemlinkURL = null, WorkflowExpression<workItemlinkTypeInput> workItemlinkType = null, WorkflowExpression<string> workItemlinkComment = null, WorkflowExpression<object> workItemdynamicFields = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(workItemtitle, nameof(workItemtitle), required: true);
            WorkflowExpression.Validate(shouldReturnAllFields, nameof(shouldReturnAllFields), required: false);
            WorkflowExpression.Validate(workItemdescription, nameof(workItemdescription), required: false);
            WorkflowExpression.Validate(workItempriority, nameof(workItempriority), required: false);
            WorkflowExpression.Validate(workItemiterationPath, nameof(workItemiterationPath), required: false);
            WorkflowExpression.Validate(workItemareaPath, nameof(workItemareaPath), required: false);
            WorkflowExpression.Validate(workItemlinkURL, nameof(workItemlinkURL), required: false);
            WorkflowExpression.Validate(workItemlinkType, nameof(workItemlinkType), required: false);
            WorkflowExpression.Validate(workItemlinkComment, nameof(workItemlinkComment), required: false);
            WorkflowExpression.Validate(workItemdynamicFields, nameof(workItemdynamicFields), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/wit/workitems/${1}", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(type, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (shouldReturnAllFields != null)
                    callPayload.Queries["shouldReturnAllFields"] = ExpressionConverter.Convert(shouldReturnAllFields);
                var workItem = new JObject();
                var workItempropCount = 0;
                workItempropCount++;
                workItem["title"] = ExpressionConverter.ConvertO(workItemtitle);
                if (workItemdescription != null)
                {
                    workItem["description"] = ExpressionConverter.ConvertO(workItemdescription);
                    workItempropCount++;
                }

                if (workItempriority != null)
                {
                    workItem["priority"] = ExpressionConverter.ConvertO(workItempriority);
                    workItempropCount++;
                }

                if (workItemiterationPath != null)
                {
                    workItem["iteration"] = ExpressionConverter.ConvertO(workItemiterationPath);
                    workItempropCount++;
                }

                if (workItemareaPath != null)
                {
                    workItem["area"] = ExpressionConverter.ConvertO(workItemareaPath);
                    workItempropCount++;
                }

                if (workItemlinkURL != null)
                {
                    workItem["linkUrl"] = ExpressionConverter.ConvertO(workItemlinkURL);
                    workItempropCount++;
                }

                if (workItemlinkType != null)
                {
                    workItem["linkType"] = ExpressionConverter.ConvertO(workItemlinkType);
                    workItempropCount++;
                }

                if (workItemlinkComment != null)
                {
                    workItem["linkComment"] = ExpressionConverter.ConvertO(workItemlinkComment);
                    workItempropCount++;
                }

                if (workItemdynamicFields != null)
                {
                    workItem["dynamicFields"] = ExpressionConverter.ConvertO(workItemdynamicFields);
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
        [WorkflowExpressionFactory(nameof(__BuildListRootQueryFolders))]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListRootQueryFolders([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> __BuildListRootQueryFolders(WorkflowExpression<string> account, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/queries", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListQueriesInFolder))]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListQueriesInFolder([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> folderPath)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> __BuildListQueriesInFolder(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> folderPath)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/queriesInFolder", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListWorkItems))]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> ListWorkItems([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> workItemIds, [WorkflowExpression] Func<string> workItemType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> __BuildListWorkItems(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> workItemIds, WorkflowExpression<string> workItemType = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(workItemIds, nameof(workItemIds), required: true);
            WorkflowExpression.Validate(workItemType, nameof(workItemType), required: false);
            return new DeferredBodyAction<VstsListListWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/wit/workitems", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["workItemIds"] = ExpressionConverter.Convert(workItemIds);
                callPayload.Queries["workItemType"] = Convert.ToString("");
                if (workItemType != null)
                    callPayload.Queries["workItemType"] = ExpressionConverter.Convert(workItemType);
                return new ApiConnectionAction<VstsListListWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListPipelines))]
        public IBodyWorkflowAction<Pipeline> ListPipelines([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Pipeline> __BuildListPipelines(WorkflowExpression<string> account, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<Pipeline>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/{0}/_apis/pipelines", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<Pipeline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildListPipelineRuns))]
        public IBodyWorkflowAction<Run> ListPipelineRuns([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> pipelineId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Run> __BuildListPipelineRuns(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<int> pipelineId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(pipelineId, nameof(pipelineId), required: true);
            return new DeferredBodyAction<Run>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/{0}/_apis/pipelines/{1}/runs", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncodingWithInt(pipelineId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<Run>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [WorkflowExpressionFactory(nameof(__BuildGetQueryResults))]
        public IBodyWorkflowAction<VstsListQueryResultWorkItemResponse> GetQueryResults([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> queryId, [WorkflowExpression] Func<int> workItemsCount = null, [WorkflowExpression] Func<bool> throwIfQueryChanged = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VstsListQueryResultWorkItemResponse> __BuildGetQueryResults(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> queryId, WorkflowExpression<int> workItemsCount = null, WorkflowExpression<bool> throwIfQueryChanged = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(queryId, nameof(queryId), required: true);
            WorkflowExpression.Validate(workItemsCount, nameof(workItemsCount), required: false);
            WorkflowExpression.Validate(throwIfQueryChanged, nameof(throwIfQueryChanged), required: false);
            return new DeferredBodyAction<VstsListQueryResultWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/{0}/queryResults/{1}", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(queryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["workItemsCount"] = Convert.ToString(200);
                if (workItemsCount != null)
                    callPayload.Queries["workItemsCount"] = ExpressionConverter.Convert(workItemsCount);
                if (throwIfQueryChanged != null)
                    callPayload.Queries["throwIfQueryChanged"] = ExpressionConverter.Convert(throwIfQueryChanged);
                return new ApiConnectionAction<VstsListQueryResultWorkItemResponse>(callPayload);
            });
        }
    }

    public class VisualstudioteamservicesTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnBuildCompleted))]
        public IBodyWorkflowTrigger<VstsListBuildResult> OnBuildCompleted([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<resultFilterInput> resultFilter = null, [WorkflowExpression] Func<string> definitions = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListBuildResult> __BuildOnBuildCompleted(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<resultFilterInput> resultFilter = null, WorkflowExpression<string> definitions = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(resultFilter, nameof(resultFilter), required: false);
            WorkflowExpression.Validate(definitions, nameof(definitions), required: false);
            return new DeferredBodyTrigger<VstsListBuildResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/buildcompleted_trigger/{0}/_apis/build/builds", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (resultFilter != null)
                    callPayload.Queries["resultFilter"] = ExpressionConverter.Convert(resultFilter);
                if (definitions != null)
                    callPayload.Queries["definitions"] = ExpressionConverter.Convert(definitions);
                return new ApiConnectionTrigger<VstsListBuildResult>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnGitPush))]
        public IBodyWorkflowTrigger<VstsListGitPush> OnGitPush([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> refName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListGitPush> __BuildOnGitPush(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> repository, WorkflowExpression<string> refName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(repository, nameof(repository), required: true);
            WorkflowExpression.Validate(refName, nameof(refName), required: false);
            return new DeferredBodyTrigger<VstsListGitPush>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gitpushed_trigger/{0}/_apis/git/repositories/{1}/pushes", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (refName != null)
                    callPayload.Queries["refName"] = ExpressionConverter.Convert(refName);
                return new ApiConnectionTrigger<VstsListGitPush>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnGitPullCreated))]
        public IBodyWorkflowTrigger<VstsListGitPullRequest> OnGitPullCreated([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> sourceRefName = null, [WorkflowExpression] Func<string> targetRefName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListGitPullRequest> __BuildOnGitPullCreated(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> repository, WorkflowExpression<string> sourceRefName = null, WorkflowExpression<string> targetRefName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(repository, nameof(repository), required: true);
            WorkflowExpression.Validate(sourceRefName, nameof(sourceRefName), required: false);
            WorkflowExpression.Validate(targetRefName, nameof(targetRefName), required: false);
            return new DeferredBodyTrigger<VstsListGitPullRequest>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gitpullcreated_trigger/{0}/_apis/git/repositories/{1}/pullrequests", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (sourceRefName != null)
                    callPayload.Queries["sourceRefName"] = ExpressionConverter.Convert(sourceRefName);
                if (targetRefName != null)
                    callPayload.Queries["targetRefName"] = ExpressionConverter.Convert(targetRefName);
                return new ApiConnectionTrigger<VstsListGitPullRequest>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnGitPullClosed))]
        public IBodyWorkflowTrigger<VstsListGitPullRequest> OnGitPullClosed([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> sourceRefName = null, [WorkflowExpression] Func<string> targetRefName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListGitPullRequest> __BuildOnGitPullClosed(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> repository, WorkflowExpression<string> sourceRefName = null, WorkflowExpression<string> targetRefName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(repository, nameof(repository), required: true);
            WorkflowExpression.Validate(sourceRefName, nameof(sourceRefName), required: false);
            WorkflowExpression.Validate(targetRefName, nameof(targetRefName), required: false);
            return new DeferredBodyTrigger<VstsListGitPullRequest>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gitpullclosed_trigger/{0}/_apis/git/repositories/{1}/pullrequests", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (sourceRefName != null)
                    callPayload.Queries["sourceRefName"] = ExpressionConverter.Convert(sourceRefName);
                if (targetRefName != null)
                    callPayload.Queries["targetRefName"] = ExpressionConverter.Convert(targetRefName);
                return new ApiConnectionTrigger<VstsListGitPullRequest>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnTfvcCheckIn))]
        public IBodyWorkflowTrigger<VstsListTfvcChangeset> OnTfvcCheckIn([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> author = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListTfvcChangeset> __BuildOnTfvcCheckIn(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> team = null, WorkflowExpression<string> author = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: false);
            WorkflowExpression.Validate(author, nameof(author), required: false);
            return new DeferredBodyTrigger<VstsListTfvcChangeset>(() =>
            {
                var apiCallPath = "/tfvccheckin_trigger/_apis/tfvc/changesets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                if (team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                if (author != null)
                    callPayload.Queries["author"] = ExpressionConverter.Convert(author);
                return new ApiConnectionTrigger<VstsListTfvcChangeset>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnWorkItemAssigned))]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemAssigned([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team, [WorkflowExpression] Func<string> wiqlSystemAssignedTo, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> __BuildOnWorkItemAssigned(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> team, WorkflowExpression<string> wiqlSystemAssignedTo, WorkflowExpression<string> wiqlSystemWorkItemType = null, WorkflowExpression<string> wiqlSystemAreaPath = null, WorkflowExpression<areaPathComparisonInput> areaPathComparison = null, WorkflowExpression<string> wiqlSystemIterationPath = null, WorkflowExpression<iterationPathComparisonInput> iterationPathComparison = null, WorkflowExpression<string> wiqlMicrosoftVSTSCommonPriority = null, WorkflowExpression<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: true);
            WorkflowExpression.Validate(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: true);
            WorkflowExpression.Validate(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            WorkflowExpression.Validate(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            WorkflowExpression.Validate(areaPathComparison, nameof(areaPathComparison), required: false);
            WorkflowExpression.Validate(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            WorkflowExpression.Validate(iterationPathComparison, nameof(iterationPathComparison), required: false);
            WorkflowExpression.Validate(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            WorkflowExpression.Validate(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemassigned_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(wiqlSystemAssignedTo);
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(wiqlSystemWorkItemType);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnWorkItemClosed))]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemClosed([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> wiqlSystemAssignedTo = null, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> closedState = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> __BuildOnWorkItemClosed(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> team = null, WorkflowExpression<string> wiqlSystemAssignedTo = null, WorkflowExpression<string> wiqlSystemWorkItemType = null, WorkflowExpression<string> closedState = null, WorkflowExpression<string> wiqlSystemAreaPath = null, WorkflowExpression<areaPathComparisonInput> areaPathComparison = null, WorkflowExpression<string> wiqlSystemIterationPath = null, WorkflowExpression<iterationPathComparisonInput> iterationPathComparison = null, WorkflowExpression<string> wiqlMicrosoftVSTSCommonPriority = null, WorkflowExpression<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: false);
            WorkflowExpression.Validate(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            WorkflowExpression.Validate(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            WorkflowExpression.Validate(closedState, nameof(closedState), required: false);
            WorkflowExpression.Validate(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            WorkflowExpression.Validate(areaPathComparison, nameof(areaPathComparison), required: false);
            WorkflowExpression.Validate(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            WorkflowExpression.Validate(iterationPathComparison, nameof(iterationPathComparison), required: false);
            WorkflowExpression.Validate(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            WorkflowExpression.Validate(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemclosed_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                if (wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(wiqlSystemAssignedTo);
                callPayload.Queries["wiql__System_WorkItemType"] = Convert.ToString("Bug");
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(wiqlSystemWorkItemType);
                callPayload.Queries["closedState"] = Convert.ToString("Done, Closed, Completed, Inactive");
                if (closedState != null)
                    callPayload.Queries["closedState"] = ExpressionConverter.Convert(closedState);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnWorkItemCreated))]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemCreated([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> wiqlSystemAssignedTo = null, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> __BuildOnWorkItemCreated(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> team = null, WorkflowExpression<string> wiqlSystemAssignedTo = null, WorkflowExpression<string> wiqlSystemWorkItemType = null, WorkflowExpression<string> wiqlSystemAreaPath = null, WorkflowExpression<areaPathComparisonInput> areaPathComparison = null, WorkflowExpression<string> wiqlSystemIterationPath = null, WorkflowExpression<iterationPathComparisonInput> iterationPathComparison = null, WorkflowExpression<string> wiqlMicrosoftVSTSCommonPriority = null, WorkflowExpression<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: false);
            WorkflowExpression.Validate(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            WorkflowExpression.Validate(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            WorkflowExpression.Validate(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            WorkflowExpression.Validate(areaPathComparison, nameof(areaPathComparison), required: false);
            WorkflowExpression.Validate(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            WorkflowExpression.Validate(iterationPathComparison, nameof(iterationPathComparison), required: false);
            WorkflowExpression.Validate(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            WorkflowExpression.Validate(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemcreated_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                if (wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(wiqlSystemAssignedTo);
                callPayload.Queries["wiql__System_WorkItemType"] = Convert.ToString("Bug");
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(wiqlSystemWorkItemType);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnWorkItemUpdated))]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemUpdated([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> team = null, [WorkflowExpression] Func<string> wiqlSystemAssignedTo = null, [WorkflowExpression] Func<string> wiqlSystemWorkItemType = null, [WorkflowExpression] Func<string> wiqlSystemAreaPath = null, [WorkflowExpression] Func<areaPathComparisonInput> areaPathComparison = null, [WorkflowExpression] Func<string> wiqlSystemIterationPath = null, [WorkflowExpression] Func<iterationPathComparisonInput> iterationPathComparison = null, [WorkflowExpression] Func<string> wiqlMicrosoftVSTSCommonPriority = null, [WorkflowExpression] Func<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> __BuildOnWorkItemUpdated(WorkflowExpression<string> account, WorkflowExpression<string> project, WorkflowExpression<string> team = null, WorkflowExpression<string> wiqlSystemAssignedTo = null, WorkflowExpression<string> wiqlSystemWorkItemType = null, WorkflowExpression<string> wiqlSystemAreaPath = null, WorkflowExpression<areaPathComparisonInput> areaPathComparison = null, WorkflowExpression<string> wiqlSystemIterationPath = null, WorkflowExpression<iterationPathComparisonInput> iterationPathComparison = null, WorkflowExpression<string> wiqlMicrosoftVSTSCommonPriority = null, WorkflowExpression<string> wiqlSystemCreatedBy = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(team, nameof(team), required: false);
            WorkflowExpression.Validate(wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            WorkflowExpression.Validate(wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            WorkflowExpression.Validate(wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            WorkflowExpression.Validate(areaPathComparison, nameof(areaPathComparison), required: false);
            WorkflowExpression.Validate(wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            WorkflowExpression.Validate(iterationPathComparison, nameof(iterationPathComparison), required: false);
            WorkflowExpression.Validate(wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            WorkflowExpression.Validate(wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemupdated_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                if (team != null)
                    callPayload.Queries["team"] = ExpressionConverter.Convert(team);
                if (wiqlSystemAssignedTo != null)
                    callPayload.Queries["wiql__System_AssignedTo"] = ExpressionConverter.Convert(wiqlSystemAssignedTo);
                if (wiqlSystemWorkItemType != null)
                    callPayload.Queries["wiql__System_WorkItemType"] = ExpressionConverter.Convert(wiqlSystemWorkItemType);
                if (wiqlSystemAreaPath != null)
                    callPayload.Queries["wiql__System_AreaPath"] = ExpressionConverter.Convert(wiqlSystemAreaPath);
                callPayload.Queries["areaPathComparison"] = Convert.ToString("Equals");
                if (areaPathComparison != null)
                    callPayload.Queries["areaPathComparison"] = ExpressionConverter.Convert(areaPathComparison);
                if (wiqlSystemIterationPath != null)
                    callPayload.Queries["wiql__System_IterationPath"] = ExpressionConverter.Convert(wiqlSystemIterationPath);
                callPayload.Queries["iterationPathComparison"] = Convert.ToString("Equals");
                if (iterationPathComparison != null)
                    callPayload.Queries["iterationPathComparison"] = ExpressionConverter.Convert(iterationPathComparison);
                if (wiqlMicrosoftVSTSCommonPriority != null)
                    callPayload.Queries["wiql__Microsoft_VSTS_Common_Priority"] = ExpressionConverter.Convert(wiqlMicrosoftVSTSCommonPriority);
                if (wiqlSystemCreatedBy != null)
                    callPayload.Queries["wiql__System_CreatedBy"] = ExpressionConverter.Convert(wiqlSystemCreatedBy);
                return new ApiConnectionTrigger<VstsListTriggerWorkItemResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
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

    public class WorkItemFieldOperation
    {
        public string Name { get; set; }
        public string ReferenceName { get; set; }
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