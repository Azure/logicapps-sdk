//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Doppler
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DopplerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerSecretsListSecrets))]
        public IBodyWorkflowAction<JToken> DopplerSecretsListSecrets([WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> configName, [WorkflowExpression] Func<bool> includeDynamicSecrets = null, [WorkflowExpression] Func<bool> includeManagedSecrets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDopplerSecretsListSecrets(WorkflowExpression<string> projectName, WorkflowExpression<string> configName, WorkflowExpression<bool> includeDynamicSecrets = null, WorkflowExpression<bool> includeManagedSecrets = null)
        {
            WorkflowExpression.Validate(projectName, nameof(projectName), required: true);
            WorkflowExpression.Validate(configName, nameof(configName), required: true);
            WorkflowExpression.Validate(includeDynamicSecrets, nameof(includeDynamicSecrets), required: false);
            WorkflowExpression.Validate(includeManagedSecrets, nameof(includeManagedSecrets), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Project Name"] = ExpressionConverter.Convert(projectName);
                callPayload.Queries["Config Name"] = ExpressionConverter.Convert(configName);
                callPayload.Queries["Include Dynamic Secrets"] = Convert.ToString(false);
                if (includeDynamicSecrets != null)
                    callPayload.Queries["Include Dynamic Secrets"] = ExpressionConverter.Convert(includeDynamicSecrets);
                callPayload.Queries["Include Managed Secrets"] = Convert.ToString(true);
                if (includeManagedSecrets != null)
                    callPayload.Queries["Include Managed Secrets"] = ExpressionConverter.Convert(includeManagedSecrets);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerSecretsUpdateSecret))]
        public IBodyWorkflowAction<DopplerSecretsUpdateSecretResponse> DopplerSecretsUpdateSecret([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerSecretsUpdateSecretResponse> __BuildDopplerSecretsUpdateSecret(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyconfig)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            return new DeferredBodyAction<DopplerSecretsUpdateSecretResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(bodyconfig);
                var secretsObject = new JObject();
                var secretsObjectpropCount = 0;
                if (secretsObjectpropCount > 0)
                {
                    body["secrets"] = secretsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerSecretsUpdateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerSecretsRetrieveSecret))]
        public IBodyWorkflowAction<DopplerSecretsRetrieveSecretResponse> DopplerSecretsRetrieveSecret([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> config, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerSecretsRetrieveSecretResponse> __BuildDopplerSecretsRetrieveSecret(WorkflowExpression<string> project, WorkflowExpression<string> config, WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(config, nameof(config), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<DopplerSecretsRetrieveSecretResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["config"] = ExpressionConverter.Convert(config);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                return new ApiConnectionAction<DopplerSecretsRetrieveSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerSecretsDeleteSecret))]
        public IBodyWorkflowAction<JToken> DopplerSecretsDeleteSecret([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> config, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDopplerSecretsDeleteSecret(WorkflowExpression<string> project, WorkflowExpression<string> config, WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(config, nameof(config), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["config"] = ExpressionConverter.Convert(config);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerSecretsUpdateSecretNote))]
        public IWorkflowAction DopplerSecretsUpdateSecretNote([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig, [WorkflowExpression] Func<string> bodysecret, [WorkflowExpression] Func<string> bodynote)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDopplerSecretsUpdateSecretNote(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyconfig, WorkflowExpression<string> bodysecret, WorkflowExpression<string> bodynote)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            WorkflowExpression.Validate(bodysecret, nameof(bodysecret), required: true);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets/note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(bodyconfig);
                bodypropCount++;
                body["secret"] = ExpressionConverter.ConvertO(bodysecret);
                bodypropCount++;
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigListConfig))]
        public IBodyWorkflowAction<DopplerConfigListConfigResponse> DopplerConfigListConfig([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> perPage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigListConfigResponse> __BuildDopplerConfigListConfig(WorkflowExpression<string> project, WorkflowExpression<int> page, WorkflowExpression<int> perPage)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: true);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: true);
            return new DeferredBodyAction<DopplerConfigListConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<DopplerConfigListConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigCreateConfig))]
        public IBodyWorkflowAction<DopplerConfigCreateConfigResponse> DopplerConfigCreateConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyenvironment, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigCreateConfigResponse> __BuildDopplerConfigCreateConfig(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyenvironment, WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyenvironment, nameof(bodyenvironment), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<DopplerConfigCreateConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["environment"] = ExpressionConverter.ConvertO(bodyenvironment);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigCreateConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigRetrieveConfig))]
        public IBodyWorkflowAction<DopplerConfigRetrieveConfigResponse> DopplerConfigRetrieveConfig([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> config = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigRetrieveConfigResponse> __BuildDopplerConfigRetrieveConfig(WorkflowExpression<string> project, WorkflowExpression<string> config = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(config, nameof(config), required: false);
            return new DeferredBodyAction<DopplerConfigRetrieveConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                if (config != null)
                    callPayload.Queries["config"] = ExpressionConverter.Convert(config);
                return new ApiConnectionAction<DopplerConfigRetrieveConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigUpdateConfigName))]
        public IBodyWorkflowAction<DopplerConfigUpdateConfigNameResponse> DopplerConfigUpdateConfigName([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigUpdateConfigNameResponse> __BuildDopplerConfigUpdateConfigName(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyconfig, WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<DopplerConfigUpdateConfigNameResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(bodyconfig);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigUpdateConfigNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigCloneConfig))]
        public IBodyWorkflowAction<DopplerConfigCloneConfigResponse> DopplerConfigCloneConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigCloneConfigResponse> __BuildDopplerConfigCloneConfig(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyconfig, WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<DopplerConfigCloneConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(bodyconfig);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigCloneConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigLockConfig))]
        public IBodyWorkflowAction<DopplerConfigLockConfigResponse> DopplerConfigLockConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigLockConfigResponse> __BuildDopplerConfigLockConfig(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyconfig)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            return new DeferredBodyAction<DopplerConfigLockConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(bodyconfig);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigLockConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerConfigUnlockConfig))]
        public IBodyWorkflowAction<DopplerConfigUnlockConfigResponse> DopplerConfigUnlockConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerConfigUnlockConfigResponse> __BuildDopplerConfigUnlockConfig(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyconfig)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            return new DeferredBodyAction<DopplerConfigUnlockConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(bodyconfig);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigUnlockConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectsList))]
        public IBodyWorkflowAction<DopplerProjectsListResponse> DopplerProjectsList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectsListResponse> __BuildDopplerProjectsList(WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<DopplerProjectsListResponse>(() =>
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<DopplerProjectsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectsCreate))]
        public IBodyWorkflowAction<DopplerProjectsCreateResponse> DopplerProjectsCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectsCreateResponse> __BuildDopplerProjectsCreate(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydescription)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            return new DeferredBodyAction<DopplerProjectsCreateResponse>(() =>
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectsRetrieve))]
        public IBodyWorkflowAction<DopplerProjectsRetrieveResponse> DopplerProjectsRetrieve([WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectsRetrieveResponse> __BuildDopplerProjectsRetrieve(WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<DopplerProjectsRetrieveResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                return new ApiConnectionAction<DopplerProjectsRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectsUpdate))]
        public IBodyWorkflowAction<DopplerProjectsUpdateResponse> DopplerProjectsUpdate([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectsUpdateResponse> __BuildDopplerProjectsUpdate(WorkflowExpression<string> bodyproject, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydescription)
        {
            WorkflowExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            return new DeferredBodyAction<DopplerProjectsUpdateResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectRolesListResponse> DopplerProjectRolesList()
        {
            var apiCallPath = "/v3/projects/roles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DopplerProjectRolesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectRolesRetrieve))]
        public IBodyWorkflowAction<DopplerProjectRolesRetrieveResponse> DopplerProjectRolesRetrieve([WorkflowExpression] Func<string> role)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectRolesRetrieveResponse> __BuildDopplerProjectRolesRetrieve(WorkflowExpression<string> role)
        {
            WorkflowExpression.Validate(role, nameof(role), required: true);
            return new DeferredBodyAction<DopplerProjectRolesRetrieveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/projects/roles/role/{0}", ExpressionConverter.ConvertWithUrlEncoding(role, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DopplerProjectRolesRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectRolesDelete))]
        public IBodyWorkflowAction<JToken> DopplerProjectRolesDelete([WorkflowExpression] Func<string> role)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDopplerProjectRolesDelete(WorkflowExpression<string> role)
        {
            WorkflowExpression.Validate(role, nameof(role), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/projects/roles/role/{0}", ExpressionConverter.ConvertWithUrlEncoding(role, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectMembersList))]
        public IBodyWorkflowAction<DopplerProjectMembersListResponse> DopplerProjectMembersList([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectMembersListResponse> __BuildDopplerProjectMembersList(WorkflowExpression<string> project, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<DopplerProjectMembersListResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["per_page"] = Convert.ToString(20);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<DopplerProjectMembersListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectMembersAdd))]
        public IBodyWorkflowAction<DopplerProjectMembersAddResponse> DopplerProjectMembersAdd([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string[]> bodyenvironments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectMembersAddResponse> __BuildDopplerProjectMembersAdd(WorkflowExpression<string> project, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<string> bodyslug, WorkflowExpression<string> bodyrole = null, WorkflowExpression<string[]> bodyenvironments = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodyenvironments, nameof(bodyenvironments), required: false);
            return new DeferredBodyAction<DopplerProjectMembersAddResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodyenvironments != null)
                {
                    body["environments"] = ExpressionConverter.ConvertO(bodyenvironments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectMembersAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectMembersRetrieve))]
        public IBodyWorkflowAction<DopplerProjectMembersRetrieveResponse> DopplerProjectMembersRetrieve([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectMembersRetrieveResponse> __BuildDopplerProjectMembersRetrieve(WorkflowExpression<typeInput> type, WorkflowExpression<string> slug, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<DopplerProjectMembersRetrieveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/projects/project/members/member/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                return new ApiConnectionAction<DopplerProjectMembersRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectMembersDelete))]
        public IBodyWorkflowAction<JToken> DopplerProjectMembersDelete([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> project)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDopplerProjectMembersDelete(WorkflowExpression<string> type, WorkflowExpression<string> slug, WorkflowExpression<string> project)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/projects/project/members/member/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        [WorkflowExpressionFactory(nameof(__BuildDopplerProjectMembersUpdate))]
        public IBodyWorkflowAction<DopplerProjectMembersUpdateResponse> DopplerProjectMembersUpdate([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string[]> bodyenvironments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DopplerProjectMembersUpdateResponse> __BuildDopplerProjectMembersUpdate(WorkflowExpression<string> type, WorkflowExpression<string> slug, WorkflowExpression<string> project, WorkflowExpression<string> bodyrole = null, WorkflowExpression<string[]> bodyenvironments = null)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodyenvironments, nameof(bodyenvironments), required: false);
            return new DeferredBodyAction<DopplerProjectMembersUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/projects/project/members/member/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodyenvironments != null)
                {
                    body["environments"] = ExpressionConverter.ConvertO(bodyenvironments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectMembersUpdateResponse>(callPayload);
            });
        }
    }

    public class DopplerTriggers([ConnectionName] string connectionId)
    {
    }

    public class DopplerSecretsUpdateSecretResponse
    {
        [JsonProperty("secrets")]
        public JToken Secrets { get; set; }
    }

    public class DopplerSecretsRetrieveSecretResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public DopplerSecretsRetrieveSecretResponseValueType Value { get; set; }
    }

    public class DopplerSecretsRetrieveSecretResponseValueType
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("computed")]
        public string Computed { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class DopplerConfigListConfigResponse
    {
        [JsonProperty("configs")]
        public DopplerConfigListConfigResponseConfigsTypeItem[] Configs { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class DopplerConfigListConfigResponseConfigsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class DopplerConfigCreateConfigResponse
    {
        [JsonProperty("config")]
        public DopplerConfigCreateConfigResponseConfigType Config { get; set; }
    }

    public class DopplerConfigCreateConfigResponseConfigType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }

    public class DopplerConfigRetrieveConfigResponse
    {
        [JsonProperty("config")]
        public DopplerConfigRetrieveConfigResponseConfigType Config { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class DopplerConfigRetrieveConfigResponseConfigType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class DopplerConfigUpdateConfigNameResponse
    {
        [JsonProperty("config")]
        public DopplerConfigUpdateConfigNameResponseConfigType Config { get; set; }
    }

    public class DopplerConfigUpdateConfigNameResponseConfigType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }

    public class DopplerConfigCloneConfigResponse
    {
        [JsonProperty("config")]
        public DopplerConfigCloneConfigResponseConfigType Config { get; set; }
    }

    public class DopplerConfigCloneConfigResponseConfigType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }

    public class DopplerConfigLockConfigResponse
    {
        [JsonProperty("config")]
        public DopplerConfigLockConfigResponseConfigType Config { get; set; }
    }

    public class DopplerConfigLockConfigResponseConfigType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }

    public class DopplerConfigUnlockConfigResponse
    {
        [JsonProperty("config")]
        public DopplerConfigUnlockConfigResponseConfigType Config { get; set; }
    }

    public class DopplerConfigUnlockConfigResponseConfigType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("initial_fetch_at")]
        public string InitialFetchAt { get; set; }

        [JsonProperty("last_fetch_at")]
        public string LastFetchAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }

    public class DopplerProjectsListResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("projects")]
        public DopplerProjectsListResponseProjectsTypeItem[] Projects { get; set; }
    }

    public class DopplerProjectsListResponseProjectsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class DopplerProjectsCreateResponse
    {
        [JsonProperty("project")]
        public DopplerProjectsCreateResponseProjectType Project { get; set; }
    }

    public class DopplerProjectsCreateResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class DopplerProjectsRetrieveResponse
    {
        [JsonProperty("project")]
        public DopplerProjectsRetrieveResponseProjectType Project { get; set; }
    }

    public class DopplerProjectsRetrieveResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class DopplerProjectsUpdateResponse
    {
        [JsonProperty("project")]
        public DopplerProjectsUpdateResponseProjectType Project { get; set; }
    }

    public class DopplerProjectsUpdateResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class DopplerProjectRolesListResponse
    {
        [JsonProperty("roles")]
        public DopplerProjectRolesListResponseRolesTypeItem[] Roles { get; set; }
    }

    public class DopplerProjectRolesListResponseRolesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_custom_role")]
        public bool IsCustomRole { get; set; }
    }

    public class DopplerProjectRolesRetrieveResponse
    {
        [JsonProperty("role")]
        public DopplerProjectRolesRetrieveResponseRoleType Role { get; set; }
    }

    public class DopplerProjectRolesRetrieveResponseRoleType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_custom_role")]
        public bool IsCustomRole { get; set; }
    }

    public class DopplerProjectMembersListResponse
    {
        [JsonProperty("members")]
        public DopplerProjectMembersListResponseMembersTypeItem[] Members { get; set; }
    }

    public class DopplerProjectMembersListResponseMembersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("role")]
        public DopplerProjectMembersListResponseMembersTypeItemRoleType Role { get; set; }

        [JsonProperty("access_all_environments")]
        public bool AccessAllEnvironments { get; set; }

        [JsonProperty("environments")]
        public string[] Environments { get; set; }
    }

    public class DopplerProjectMembersListResponseMembersTypeItemRoleType
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    public class DopplerProjectMembersAddResponse
    {
        [JsonProperty("member")]
        public DopplerProjectMembersAddResponseMemberType Member { get; set; }
    }

    public class DopplerProjectMembersAddResponseMemberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("role")]
        public DopplerProjectMembersAddResponseMemberTypeRoleType Role { get; set; }

        [JsonProperty("access_all_environments")]
        public bool AccessAllEnvironments { get; set; }

        [JsonProperty("environments")]
        public string[] Environments { get; set; }
    }

    public class DopplerProjectMembersAddResponseMemberTypeRoleType
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        [EnumMember(Value = "workplace_user")]
        WorkplaceUser,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "invite")]
        Invite,
        [EnumMember(Value = "service_account")]
        ServiceAccount
    }

    public class DopplerProjectMembersRetrieveResponse
    {
        [JsonProperty("member")]
        public DopplerProjectMembersRetrieveResponseMemberType Member { get; set; }
    }

    public class DopplerProjectMembersRetrieveResponseMemberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("role")]
        public DopplerProjectMembersRetrieveResponseMemberTypeRoleType Role { get; set; }

        [JsonProperty("access_all_environments")]
        public bool AccessAllEnvironments { get; set; }

        [JsonProperty("environments")]
        public string[] Environments { get; set; }
    }

    public class DopplerProjectMembersRetrieveResponseMemberTypeRoleType
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "workplace_user")]
        WorkplaceUser,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "invite")]
        Invite,
        [EnumMember(Value = "service_account")]
        ServiceAccount
    }

    public class DopplerProjectMembersUpdateResponse
    {
        [JsonProperty("member")]
        public DopplerProjectMembersUpdateResponseMemberType Member { get; set; }
    }

    public class DopplerProjectMembersUpdateResponseMemberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("role")]
        public DopplerProjectMembersUpdateResponseMemberTypeRoleType Role { get; set; }

        [JsonProperty("access_all_environments")]
        public bool AccessAllEnvironments { get; set; }

        [JsonProperty("environments")]
        public string[] Environments { get; set; }
    }

    public class DopplerProjectMembersUpdateResponseMemberTypeRoleType
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Doppler;

    public partial class WorkflowManagedActions
    {
        public DopplerActions Doppler(string connectionId) => new DopplerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DopplerTriggers Doppler(string connectionId) => new DopplerTriggers(connectionId);
    }
}