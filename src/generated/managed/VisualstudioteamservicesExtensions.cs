//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Visualstudioteamservices
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<Profile> GetProfile(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<Profile>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/profile/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Profile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListTeamSettingsIteration> ListIterations(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_team = team == null ? null : WorkflowExpression.Compile(team);
            WorkflowExpression.Validate(__workflow_team, nameof(team), required: true);
            return new DeferredBodyAction<VstsListTeamSettingsIteration>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/iterations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["team"] = ExpressionConverter.Convert(__workflow_team);
                return new ApiConnectionAction<VstsListTeamSettingsIteration>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<BuildResult> QueueNewBuild(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> buildDefId, Expression<Func<string>> buildDetailssourceBranch = null, Expression<Func<string>> buildDetailsparameters = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_buildDefId = buildDefId == null ? null : WorkflowExpression.Compile(buildDefId);
            WorkflowExpression.Validate(__workflow_buildDefId, nameof(buildDefId), required: true);
            var __workflow_buildDetailssourceBranch = buildDetailssourceBranch == null ? null : WorkflowExpression.Compile(buildDetailssourceBranch);
            WorkflowExpression.Validate(__workflow_buildDetailssourceBranch, nameof(buildDetailssourceBranch), required: false);
            var __workflow_buildDetailsparameters = buildDetailsparameters == null ? null : WorkflowExpression.Compile(buildDetailsparameters);
            WorkflowExpression.Validate(__workflow_buildDetailsparameters, nameof(buildDetailsparameters), required: false);
            return new DeferredBodyAction<BuildResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/build/builds", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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
        public IBodyWorkflowAction<VstsListGitRepository> ListGitRepositories(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListGitRepository>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/git/repositories", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListGitRepository>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListProject> ListProjects(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<VstsListProject>(() =>
            {
                var apiCallPath = "/_apis/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListReleaseDefinition> ListReleaseDefinitions(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListReleaseDefinition>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/definitions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListReleaseDefinition>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Release> CreateRelease(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> releaseDefId, Expression<Func<string>> releaseStartMetadatadescription = null, Expression<Func<bool>> releaseStartMetadataisDraft = null, Expression<Func<releaseStartMetadatareasonInput>> releaseStartMetadatareason = null, Expression<Func<ConfigurationVariable[]>> releaseStartMetadatareleaseVariables = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_releaseDefId = releaseDefId == null ? null : WorkflowExpression.Compile(releaseDefId);
            WorkflowExpression.Validate(__workflow_releaseDefId, nameof(releaseDefId), required: true);
            var __workflow_releaseStartMetadatadescription = releaseStartMetadatadescription == null ? null : WorkflowExpression.Compile(releaseStartMetadatadescription);
            WorkflowExpression.Validate(__workflow_releaseStartMetadatadescription, nameof(releaseStartMetadatadescription), required: false);
            var __workflow_releaseStartMetadataisDraft = releaseStartMetadataisDraft == null ? null : WorkflowExpression.Compile(releaseStartMetadataisDraft);
            WorkflowExpression.Validate(__workflow_releaseStartMetadataisDraft, nameof(releaseStartMetadataisDraft), required: false);
            var __workflow_releaseStartMetadatareason = releaseStartMetadatareason == null ? null : WorkflowExpression.Compile(releaseStartMetadatareason);
            WorkflowExpression.Validate(__workflow_releaseStartMetadatareason, nameof(releaseStartMetadatareason), required: false);
            var __workflow_releaseStartMetadatareleaseVariables = releaseStartMetadatareleaseVariables == null ? null : WorkflowExpression.Compile(releaseStartMetadatareleaseVariables);
            WorkflowExpression.Validate(__workflow_releaseStartMetadatareleaseVariables, nameof(releaseStartMetadatareleaseVariables), required: false);
            return new DeferredBodyAction<Release>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/releases", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> account, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parametersrelativeURI, Expression<Func<string>> parametersbody = null, Expression<Func<bool>> parametersbodyIsBase64 = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_parametersmethod = parametersmethod == null ? null : WorkflowExpression.Compile(parametersmethod);
            WorkflowExpression.Validate(__workflow_parametersmethod, nameof(parametersmethod), required: true);
            var __workflow_parametersrelativeURI = parametersrelativeURI == null ? null : WorkflowExpression.Compile(parametersrelativeURI);
            WorkflowExpression.Validate(__workflow_parametersrelativeURI, nameof(parametersrelativeURI), required: true);
            var __workflow_parametersbody = parametersbody == null ? null : WorkflowExpression.Compile(parametersbody);
            WorkflowExpression.Validate(__workflow_parametersbody, nameof(parametersbody), required: false);
            var __workflow_parametersbodyIsBase64 = parametersbodyIsBase64 == null ? null : WorkflowExpression.Compile(parametersbodyIsBase64);
            WorkflowExpression.Validate(__workflow_parametersbodyIsBase64, nameof(parametersbodyIsBase64), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<VstsListWorkItemType> ListWorkItemTypes(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListWorkItemType>(() =>
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
        public IBodyWorkflowAction<DynamicWorkItemResponse> GetWorkItemDetails(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> typeName, Expression<Func<string>> id)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_typeName = typeName == null ? null : WorkflowExpression.Compile(typeName);
            WorkflowExpression.Validate(__workflow_typeName, nameof(typeName), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<DynamicWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["typeName"] = ExpressionConverter.Convert(__workflow_typeName);
                return new ApiConnectionAction<DynamicWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<PatchWorkItemResponse> UpdateWorkItem(Expression<Func<string>> account, Expression<Func<string>> id, Expression<Func<string>> project = null, Expression<Func<string>> type = null, Expression<Func<string>> workItemtitle = null, Expression<Func<string>> workItemdescription = null, Expression<Func<int>> workItempriority = null, Expression<Func<string>> workItemiterationPath = null, Expression<Func<string>> workItemareaPath = null, Expression<Func<string>> workItemlinkURL = null, Expression<Func<workItemlinkTypeInput>> workItemlinkType = null, Expression<Func<string>> workItemlinkComment = null, Expression<Func<object>> workItemdynamicFields = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_workItemtitle = workItemtitle == null ? null : WorkflowExpression.Compile(workItemtitle);
            WorkflowExpression.Validate(__workflow_workItemtitle, nameof(workItemtitle), required: false);
            var __workflow_workItemdescription = workItemdescription == null ? null : WorkflowExpression.Compile(workItemdescription);
            WorkflowExpression.Validate(__workflow_workItemdescription, nameof(workItemdescription), required: false);
            var __workflow_workItempriority = workItempriority == null ? null : WorkflowExpression.Compile(workItempriority);
            WorkflowExpression.Validate(__workflow_workItempriority, nameof(workItempriority), required: false);
            var __workflow_workItemiterationPath = workItemiterationPath == null ? null : WorkflowExpression.Compile(workItemiterationPath);
            WorkflowExpression.Validate(__workflow_workItemiterationPath, nameof(workItemiterationPath), required: false);
            var __workflow_workItemareaPath = workItemareaPath == null ? null : WorkflowExpression.Compile(workItemareaPath);
            WorkflowExpression.Validate(__workflow_workItemareaPath, nameof(workItemareaPath), required: false);
            var __workflow_workItemlinkURL = workItemlinkURL == null ? null : WorkflowExpression.Compile(workItemlinkURL);
            WorkflowExpression.Validate(__workflow_workItemlinkURL, nameof(workItemlinkURL), required: false);
            var __workflow_workItemlinkType = workItemlinkType == null ? null : WorkflowExpression.Compile(workItemlinkType);
            WorkflowExpression.Validate(__workflow_workItemlinkType, nameof(workItemlinkType), required: false);
            var __workflow_workItemlinkComment = workItemlinkComment == null ? null : WorkflowExpression.Compile(workItemlinkComment);
            WorkflowExpression.Validate(__workflow_workItemlinkComment, nameof(workItemlinkComment), required: false);
            var __workflow_workItemdynamicFields = workItemdynamicFields == null ? null : WorkflowExpression.Compile(workItemdynamicFields);
            WorkflowExpression.Validate(__workflow_workItemdynamicFields, nameof(workItemdynamicFields), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
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
        public IBodyWorkflowAction<VstsListListWorkItemResponse> GetWorkItemChildren(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> id, Expression<Func<string>> workItemType = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_workItemType = workItemType == null ? null : WorkflowExpression.Compile(workItemType);
            WorkflowExpression.Validate(__workflow_workItemType, nameof(workItemType), required: false);
            return new DeferredBodyAction<VstsListListWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_apis/wit/workitems/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
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
        public IBodyWorkflowAction<PatchWorkItemResponse> CreateWorkItem(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> type, Expression<Func<string>> workItemtitle, Expression<Func<bool>> shouldReturnAllFields = null, Expression<Func<string>> workItemdescription = null, Expression<Func<int>> workItempriority = null, Expression<Func<string>> workItemiterationPath = null, Expression<Func<string>> workItemareaPath = null, Expression<Func<string>> workItemlinkURL = null, Expression<Func<workItemlinkTypeInput>> workItemlinkType = null, Expression<Func<string>> workItemlinkComment = null, Expression<Func<object>> workItemdynamicFields = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            var __workflow_workItemtitle = workItemtitle == null ? null : WorkflowExpression.Compile(workItemtitle);
            WorkflowExpression.Validate(__workflow_workItemtitle, nameof(workItemtitle), required: true);
            var __workflow_shouldReturnAllFields = shouldReturnAllFields == null ? null : WorkflowExpression.Compile(shouldReturnAllFields);
            WorkflowExpression.Validate(__workflow_shouldReturnAllFields, nameof(shouldReturnAllFields), required: false);
            var __workflow_workItemdescription = workItemdescription == null ? null : WorkflowExpression.Compile(workItemdescription);
            WorkflowExpression.Validate(__workflow_workItemdescription, nameof(workItemdescription), required: false);
            var __workflow_workItempriority = workItempriority == null ? null : WorkflowExpression.Compile(workItempriority);
            WorkflowExpression.Validate(__workflow_workItempriority, nameof(workItempriority), required: false);
            var __workflow_workItemiterationPath = workItemiterationPath == null ? null : WorkflowExpression.Compile(workItemiterationPath);
            WorkflowExpression.Validate(__workflow_workItemiterationPath, nameof(workItemiterationPath), required: false);
            var __workflow_workItemareaPath = workItemareaPath == null ? null : WorkflowExpression.Compile(workItemareaPath);
            WorkflowExpression.Validate(__workflow_workItemareaPath, nameof(workItemareaPath), required: false);
            var __workflow_workItemlinkURL = workItemlinkURL == null ? null : WorkflowExpression.Compile(workItemlinkURL);
            WorkflowExpression.Validate(__workflow_workItemlinkURL, nameof(workItemlinkURL), required: false);
            var __workflow_workItemlinkType = workItemlinkType == null ? null : WorkflowExpression.Compile(workItemlinkType);
            WorkflowExpression.Validate(__workflow_workItemlinkType, nameof(workItemlinkType), required: false);
            var __workflow_workItemlinkComment = workItemlinkComment == null ? null : WorkflowExpression.Compile(workItemlinkComment);
            WorkflowExpression.Validate(__workflow_workItemlinkComment, nameof(workItemlinkComment), required: false);
            var __workflow_workItemdynamicFields = workItemdynamicFields == null ? null : WorkflowExpression.Compile(workItemdynamicFields);
            WorkflowExpression.Validate(__workflow_workItemdynamicFields, nameof(workItemdynamicFields), required: false);
            return new DeferredBodyAction<PatchWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/wit/workitems/${1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_type, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_shouldReturnAllFields != null)
                    callPayload.Queries["shouldReturnAllFields"] = ExpressionConverter.Convert(__workflow_shouldReturnAllFields);
                var workItem = new JObject();
                var workItempropCount = 0;
                workItempropCount++;
                workItem["title"] = ExpressionConverter.ConvertO(__workflow_workItemtitle);
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
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListRootQueryFolders(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/queries", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListQueriesInFolder(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> folderPath)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_folderPath = folderPath == null ? null : WorkflowExpression.Compile(folderPath);
            WorkflowExpression.Validate(__workflow_folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/queriesInFolder", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> ListWorkItems(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> workItemIds, Expression<Func<string>> workItemType = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_workItemIds = workItemIds == null ? null : WorkflowExpression.Compile(workItemIds);
            WorkflowExpression.Validate(__workflow_workItemIds, nameof(workItemIds), required: true);
            var __workflow_workItemType = workItemType == null ? null : WorkflowExpression.Compile(workItemType);
            WorkflowExpression.Validate(__workflow_workItemType, nameof(workItemType), required: false);
            return new DeferredBodyAction<VstsListListWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/_apis/wit/workitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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
        public IBodyWorkflowAction<Pipeline> ListPipelines(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            return new DeferredBodyAction<Pipeline>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/{0}/_apis/pipelines", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<Pipeline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<Run> ListPipelineRuns(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<int>> pipelineId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_pipelineId = pipelineId == null ? null : WorkflowExpression.Compile(pipelineId);
            WorkflowExpression.Validate(__workflow_pipelineId, nameof(pipelineId), required: true);
            return new DeferredBodyAction<Run>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/{0}/_apis/pipelines/{1}/runs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_pipelineId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<Run>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "visualstudioteamservices")]
        public IBodyWorkflowAction<VstsListQueryResultWorkItemResponse> GetQueryResults(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> queryId, Expression<Func<int>> workItemsCount = null, Expression<Func<bool>> throwIfQueryChanged = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_queryId = queryId == null ? null : WorkflowExpression.Compile(queryId);
            WorkflowExpression.Validate(__workflow_queryId, nameof(queryId), required: true);
            var __workflow_workItemsCount = workItemsCount == null ? null : WorkflowExpression.Compile(workItemsCount);
            WorkflowExpression.Validate(__workflow_workItemsCount, nameof(workItemsCount), required: false);
            var __workflow_throwIfQueryChanged = throwIfQueryChanged == null ? null : WorkflowExpression.Compile(throwIfQueryChanged);
            WorkflowExpression.Validate(__workflow_throwIfQueryChanged, nameof(throwIfQueryChanged), required: false);
            return new DeferredBodyAction<VstsListQueryResultWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/{0}/queryResults/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_queryId, 1));
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
        public IBodyWorkflowTrigger<VstsListBuildResult> OnBuildCompleted(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<resultFilterInput>> resultFilter = null, Expression<Func<string>> definitions = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_resultFilter = resultFilter == null ? null : WorkflowExpression.Compile(resultFilter);
            WorkflowExpression.Validate(__workflow_resultFilter, nameof(resultFilter), required: false);
            var __workflow_definitions = definitions == null ? null : WorkflowExpression.Compile(definitions);
            WorkflowExpression.Validate(__workflow_definitions, nameof(definitions), required: false);
            return new DeferredBodyTrigger<VstsListBuildResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/buildcompleted_trigger/{0}/_apis/build/builds", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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

        public IBodyWorkflowTrigger<VstsListGitPush> OnGitPush(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repository, Expression<Func<string>> refName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_repository = repository == null ? null : WorkflowExpression.Compile(repository);
            WorkflowExpression.Validate(__workflow_repository, nameof(repository), required: true);
            var __workflow_refName = refName == null ? null : WorkflowExpression.Compile(refName);
            WorkflowExpression.Validate(__workflow_refName, nameof(refName), required: false);
            return new DeferredBodyTrigger<VstsListGitPush>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gitpushed_trigger/{0}/_apis/git/repositories/{1}/pushes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_repository, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_refName != null)
                    callPayload.Queries["refName"] = ExpressionConverter.Convert(__workflow_refName);
                return new ApiConnectionTrigger<VstsListGitPush>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VstsListGitPullRequest> OnGitPullCreated(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repository, Expression<Func<string>> sourceRefName = null, Expression<Func<string>> targetRefName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_repository = repository == null ? null : WorkflowExpression.Compile(repository);
            WorkflowExpression.Validate(__workflow_repository, nameof(repository), required: true);
            var __workflow_sourceRefName = sourceRefName == null ? null : WorkflowExpression.Compile(sourceRefName);
            WorkflowExpression.Validate(__workflow_sourceRefName, nameof(sourceRefName), required: false);
            var __workflow_targetRefName = targetRefName == null ? null : WorkflowExpression.Compile(targetRefName);
            WorkflowExpression.Validate(__workflow_targetRefName, nameof(targetRefName), required: false);
            return new DeferredBodyTrigger<VstsListGitPullRequest>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gitpullcreated_trigger/{0}/_apis/git/repositories/{1}/pullrequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_repository, 1));
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

        public IBodyWorkflowTrigger<VstsListGitPullRequest> OnGitPullClosed(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> repository, Expression<Func<string>> sourceRefName = null, Expression<Func<string>> targetRefName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_repository = repository == null ? null : WorkflowExpression.Compile(repository);
            WorkflowExpression.Validate(__workflow_repository, nameof(repository), required: true);
            var __workflow_sourceRefName = sourceRefName == null ? null : WorkflowExpression.Compile(sourceRefName);
            WorkflowExpression.Validate(__workflow_sourceRefName, nameof(sourceRefName), required: false);
            var __workflow_targetRefName = targetRefName == null ? null : WorkflowExpression.Compile(targetRefName);
            WorkflowExpression.Validate(__workflow_targetRefName, nameof(targetRefName), required: false);
            return new DeferredBodyTrigger<VstsListGitPullRequest>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gitpullclosed_trigger/{0}/_apis/git/repositories/{1}/pullrequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_repository, 1));
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

        public IBodyWorkflowTrigger<VstsListTfvcChangeset> OnTfvcCheckIn(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> author = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_team = team == null ? null : WorkflowExpression.Compile(team);
            WorkflowExpression.Validate(__workflow_team, nameof(team), required: false);
            var __workflow_author = author == null ? null : WorkflowExpression.Compile(author);
            WorkflowExpression.Validate(__workflow_author, nameof(author), required: false);
            return new DeferredBodyTrigger<VstsListTfvcChangeset>(() =>
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

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemAssigned(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team, Expression<Func<string>> wiqlSystemAssignedTo, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_team = team == null ? null : WorkflowExpression.Compile(team);
            WorkflowExpression.Validate(__workflow_team, nameof(team), required: true);
            var __workflow_wiqlSystemAssignedTo = wiqlSystemAssignedTo == null ? null : WorkflowExpression.Compile(wiqlSystemAssignedTo);
            WorkflowExpression.Validate(__workflow_wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: true);
            var __workflow_wiqlSystemWorkItemType = wiqlSystemWorkItemType == null ? null : WorkflowExpression.Compile(wiqlSystemWorkItemType);
            WorkflowExpression.Validate(__workflow_wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_wiqlSystemAreaPath = wiqlSystemAreaPath == null ? null : WorkflowExpression.Compile(wiqlSystemAreaPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = areaPathComparison == null ? null : WorkflowExpression.Compile(areaPathComparison);
            WorkflowExpression.Validate(__workflow_areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = wiqlSystemIterationPath == null ? null : WorkflowExpression.Compile(wiqlSystemIterationPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = iterationPathComparison == null ? null : WorkflowExpression.Compile(iterationPathComparison);
            WorkflowExpression.Validate(__workflow_iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = wiqlMicrosoftVSTSCommonPriority == null ? null : WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority);
            WorkflowExpression.Validate(__workflow_wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = wiqlSystemCreatedBy == null ? null : WorkflowExpression.Compile(wiqlSystemCreatedBy);
            WorkflowExpression.Validate(__workflow_wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemassigned_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemClosed(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> wiqlSystemAssignedTo = null, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> closedState = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_team = team == null ? null : WorkflowExpression.Compile(team);
            WorkflowExpression.Validate(__workflow_team, nameof(team), required: false);
            var __workflow_wiqlSystemAssignedTo = wiqlSystemAssignedTo == null ? null : WorkflowExpression.Compile(wiqlSystemAssignedTo);
            WorkflowExpression.Validate(__workflow_wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            var __workflow_wiqlSystemWorkItemType = wiqlSystemWorkItemType == null ? null : WorkflowExpression.Compile(wiqlSystemWorkItemType);
            WorkflowExpression.Validate(__workflow_wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_closedState = closedState == null ? null : WorkflowExpression.Compile(closedState);
            WorkflowExpression.Validate(__workflow_closedState, nameof(closedState), required: false);
            var __workflow_wiqlSystemAreaPath = wiqlSystemAreaPath == null ? null : WorkflowExpression.Compile(wiqlSystemAreaPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = areaPathComparison == null ? null : WorkflowExpression.Compile(areaPathComparison);
            WorkflowExpression.Validate(__workflow_areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = wiqlSystemIterationPath == null ? null : WorkflowExpression.Compile(wiqlSystemIterationPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = iterationPathComparison == null ? null : WorkflowExpression.Compile(iterationPathComparison);
            WorkflowExpression.Validate(__workflow_iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = wiqlMicrosoftVSTSCommonPriority == null ? null : WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority);
            WorkflowExpression.Validate(__workflow_wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = wiqlSystemCreatedBy == null ? null : WorkflowExpression.Compile(wiqlSystemCreatedBy);
            WorkflowExpression.Validate(__workflow_wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemclosed_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemCreated(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> wiqlSystemAssignedTo = null, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_team = team == null ? null : WorkflowExpression.Compile(team);
            WorkflowExpression.Validate(__workflow_team, nameof(team), required: false);
            var __workflow_wiqlSystemAssignedTo = wiqlSystemAssignedTo == null ? null : WorkflowExpression.Compile(wiqlSystemAssignedTo);
            WorkflowExpression.Validate(__workflow_wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            var __workflow_wiqlSystemWorkItemType = wiqlSystemWorkItemType == null ? null : WorkflowExpression.Compile(wiqlSystemWorkItemType);
            WorkflowExpression.Validate(__workflow_wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_wiqlSystemAreaPath = wiqlSystemAreaPath == null ? null : WorkflowExpression.Compile(wiqlSystemAreaPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = areaPathComparison == null ? null : WorkflowExpression.Compile(areaPathComparison);
            WorkflowExpression.Validate(__workflow_areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = wiqlSystemIterationPath == null ? null : WorkflowExpression.Compile(wiqlSystemIterationPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = iterationPathComparison == null ? null : WorkflowExpression.Compile(iterationPathComparison);
            WorkflowExpression.Validate(__workflow_iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = wiqlMicrosoftVSTSCommonPriority == null ? null : WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority);
            WorkflowExpression.Validate(__workflow_wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = wiqlSystemCreatedBy == null ? null : WorkflowExpression.Compile(wiqlSystemCreatedBy);
            WorkflowExpression.Validate(__workflow_wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemcreated_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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

        public IBodyWorkflowTrigger<VstsListTriggerWorkItemResponse> OnWorkItemUpdated(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> team = null, Expression<Func<string>> wiqlSystemAssignedTo = null, Expression<Func<string>> wiqlSystemWorkItemType = null, Expression<Func<string>> wiqlSystemAreaPath = null, Expression<Func<areaPathComparisonInput>> areaPathComparison = null, Expression<Func<string>> wiqlSystemIterationPath = null, Expression<Func<iterationPathComparisonInput>> iterationPathComparison = null, Expression<Func<string>> wiqlMicrosoftVSTSCommonPriority = null, Expression<Func<string>> wiqlSystemCreatedBy = null, FlowRecurrence recurrence = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_project = project == null ? null : WorkflowExpression.Compile(project);
            WorkflowExpression.Validate(__workflow_project, nameof(project), required: true);
            var __workflow_team = team == null ? null : WorkflowExpression.Compile(team);
            WorkflowExpression.Validate(__workflow_team, nameof(team), required: false);
            var __workflow_wiqlSystemAssignedTo = wiqlSystemAssignedTo == null ? null : WorkflowExpression.Compile(wiqlSystemAssignedTo);
            WorkflowExpression.Validate(__workflow_wiqlSystemAssignedTo, nameof(wiqlSystemAssignedTo), required: false);
            var __workflow_wiqlSystemWorkItemType = wiqlSystemWorkItemType == null ? null : WorkflowExpression.Compile(wiqlSystemWorkItemType);
            WorkflowExpression.Validate(__workflow_wiqlSystemWorkItemType, nameof(wiqlSystemWorkItemType), required: false);
            var __workflow_wiqlSystemAreaPath = wiqlSystemAreaPath == null ? null : WorkflowExpression.Compile(wiqlSystemAreaPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemAreaPath, nameof(wiqlSystemAreaPath), required: false);
            var __workflow_areaPathComparison = areaPathComparison == null ? null : WorkflowExpression.Compile(areaPathComparison);
            WorkflowExpression.Validate(__workflow_areaPathComparison, nameof(areaPathComparison), required: false);
            var __workflow_wiqlSystemIterationPath = wiqlSystemIterationPath == null ? null : WorkflowExpression.Compile(wiqlSystemIterationPath);
            WorkflowExpression.Validate(__workflow_wiqlSystemIterationPath, nameof(wiqlSystemIterationPath), required: false);
            var __workflow_iterationPathComparison = iterationPathComparison == null ? null : WorkflowExpression.Compile(iterationPathComparison);
            WorkflowExpression.Validate(__workflow_iterationPathComparison, nameof(iterationPathComparison), required: false);
            var __workflow_wiqlMicrosoftVSTSCommonPriority = wiqlMicrosoftVSTSCommonPriority == null ? null : WorkflowExpression.Compile(wiqlMicrosoftVSTSCommonPriority);
            WorkflowExpression.Validate(__workflow_wiqlMicrosoftVSTSCommonPriority, nameof(wiqlMicrosoftVSTSCommonPriority), required: false);
            var __workflow_wiqlSystemCreatedBy = wiqlSystemCreatedBy == null ? null : WorkflowExpression.Compile(wiqlSystemCreatedBy);
            WorkflowExpression.Validate(__workflow_wiqlSystemCreatedBy, nameof(wiqlSystemCreatedBy), required: false);
            return new DeferredBodyTrigger<VstsListTriggerWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/workitemupdated_trigger/{0}/_apis/wit/wiql", ExpressionConverter.ConvertWithUrlEncoding(__workflow_project, 1));
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
