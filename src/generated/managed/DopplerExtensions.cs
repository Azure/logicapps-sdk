//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Doppler
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DopplerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerSecretsListSecrets(Expression<Func<string>> projectName, Expression<Func<string>> configName, Expression<Func<bool>> includeDynamicSecrets = null, Expression<Func<bool>> includeManagedSecrets = null)
        {
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_configName = WorkflowExpression.Compile(configName, nameof(configName), required: true);
            var __workflow_includeDynamicSecrets = WorkflowExpression.Compile(includeDynamicSecrets, nameof(includeDynamicSecrets), required: false);
            var __workflow_includeManagedSecrets = WorkflowExpression.Compile(includeManagedSecrets, nameof(includeManagedSecrets), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Project Name"] = ExpressionConverter.Convert(__workflow_projectName);
                callPayload.Queries["Config Name"] = ExpressionConverter.Convert(__workflow_configName);
                callPayload.Queries["Include Dynamic Secrets"] = Convert.ToString(false);
                if (__workflow_includeDynamicSecrets != null)
                    callPayload.Queries["Include Dynamic Secrets"] = ExpressionConverter.Convert(__workflow_includeDynamicSecrets);
                callPayload.Queries["Include Managed Secrets"] = Convert.ToString(true);
                if (__workflow_includeManagedSecrets != null)
                    callPayload.Queries["Include Managed Secrets"] = ExpressionConverter.Convert(__workflow_includeManagedSecrets);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsUpdateSecretResponse> DopplerSecretsUpdateSecret(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyconfig = WorkflowExpression.Compile(bodyconfig, nameof(bodyconfig), required: true);
            return new DeferredBodyAction<DopplerSecretsUpdateSecretResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfig);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsRetrieveSecretResponse> DopplerSecretsRetrieveSecret(Expression<Func<string>> project, Expression<Func<string>> config, Expression<Func<string>> name)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<DopplerSecretsRetrieveSecretResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["config"] = ExpressionConverter.Convert(__workflow_config);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<DopplerSecretsRetrieveSecretResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerSecretsDeleteSecret(Expression<Func<string>> project, Expression<Func<string>> config, Expression<Func<string>> name)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["config"] = ExpressionConverter.Convert(__workflow_config);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IWorkflowAction DopplerSecretsUpdateSecretNote(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig, Expression<Func<string>> bodysecret, Expression<Func<string>> bodynote)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyconfig = WorkflowExpression.Compile(bodyconfig, nameof(bodyconfig), required: true);
            var __workflow_bodysecret = WorkflowExpression.Compile(bodysecret, nameof(bodysecret), required: true);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets/note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfig);
                bodypropCount++;
                body["secret"] = ExpressionConverter.ConvertO(__workflow_bodysecret);
                bodypropCount++;
                body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigListConfigResponse> DopplerConfigListConfig(Expression<Func<string>> project, Expression<Func<int>> page, Expression<Func<int>> perPage)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: true);
            return new DeferredBodyAction<DopplerConfigListConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<DopplerConfigListConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCreateConfigResponse> DopplerConfigCreateConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyenvironment, Expression<Func<string>> bodyname)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyenvironment = WorkflowExpression.Compile(bodyenvironment, nameof(bodyenvironment), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<DopplerConfigCreateConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["environment"] = ExpressionConverter.ConvertO(__workflow_bodyenvironment);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigCreateConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigRetrieveConfigResponse> DopplerConfigRetrieveConfig(Expression<Func<string>> project, Expression<Func<string>> config = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: false);
            return new DeferredBodyAction<DopplerConfigRetrieveConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_config != null)
                    callPayload.Queries["config"] = ExpressionConverter.Convert(__workflow_config);
                return new ApiConnectionAction<DopplerConfigRetrieveConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUpdateConfigNameResponse> DopplerConfigUpdateConfigName(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig, Expression<Func<string>> bodyname)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyconfig = WorkflowExpression.Compile(bodyconfig, nameof(bodyconfig), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<DopplerConfigUpdateConfigNameResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfig);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigUpdateConfigNameResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCloneConfigResponse> DopplerConfigCloneConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig, Expression<Func<string>> bodyname)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyconfig = WorkflowExpression.Compile(bodyconfig, nameof(bodyconfig), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<DopplerConfigCloneConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfig);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigCloneConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigLockConfigResponse> DopplerConfigLockConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyconfig = WorkflowExpression.Compile(bodyconfig, nameof(bodyconfig), required: true);
            return new DeferredBodyAction<DopplerConfigLockConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfig);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigLockConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUnlockConfigResponse> DopplerConfigUnlockConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyconfig = WorkflowExpression.Compile(bodyconfig, nameof(bodyconfig), required: true);
            return new DeferredBodyAction<DopplerConfigUnlockConfigResponse>(() =>
            {
                var apiCallPath = "/v3/configs/config/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfig);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerConfigUnlockConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsListResponse> DopplerProjectsList(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<DopplerProjectsListResponse>(() =>
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<DopplerProjectsListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsCreateResponse> DopplerProjectsCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            return new DeferredBodyAction<DopplerProjectsCreateResponse>(() =>
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectsCreateResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsRetrieveResponse> DopplerProjectsRetrieve(Expression<Func<string>> project)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<DopplerProjectsRetrieveResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<DopplerProjectsRetrieveResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsUpdateResponse> DopplerProjectsUpdate(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription)
        {
            var __workflow_bodyproject = WorkflowExpression.Compile(bodyproject, nameof(bodyproject), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            return new DeferredBodyAction<DopplerProjectsUpdateResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = ExpressionConverter.ConvertO(__workflow_bodyproject);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectsUpdateResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
        public IBodyWorkflowAction<DopplerProjectRolesRetrieveResponse> DopplerProjectRolesRetrieve(Expression<Func<string>> role)
        {
            var __workflow_role = WorkflowExpression.Compile(role, nameof(role), required: true);
            return new DeferredBodyAction<DopplerProjectRolesRetrieveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/roles/role/{0}", __workflow_role.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DopplerProjectRolesRetrieveResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerProjectRolesDelete(Expression<Func<string>> role)
        {
            var __workflow_role = WorkflowExpression.Compile(role, nameof(role), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/roles/role/{0}", __workflow_role.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersListResponse> DopplerProjectMembersList(Expression<Func<string>> project, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<DopplerProjectMembersListResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(20);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<DopplerProjectMembersListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersAddResponse> DopplerProjectMembersAdd(Expression<Func<string>> project, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyslug, Expression<Func<string>> bodyrole = null, Expression<Func<string[]>> bodyenvironments = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodyenvironments = WorkflowExpression.Compile(bodyenvironments, nameof(bodyenvironments), required: false);
            return new DeferredBodyAction<DopplerProjectMembersAddResponse>(() =>
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodyenvironments != null)
                {
                    body["environments"] = ExpressionConverter.ConvertO(__workflow_bodyenvironments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectMembersAddResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersRetrieveResponse> DopplerProjectMembersRetrieve(Expression<Func<typeInput>> type, Expression<Func<string>> slug, Expression<Func<string>> project)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<DopplerProjectMembersRetrieveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/project/members/member/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<DopplerProjectMembersRetrieveResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerProjectMembersDelete(Expression<Func<string>> type, Expression<Func<string>> slug, Expression<Func<string>> project)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/project/members/member/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersUpdateResponse> DopplerProjectMembersUpdate(Expression<Func<string>> type, Expression<Func<string>> slug, Expression<Func<string>> project, Expression<Func<string>> bodyrole = null, Expression<Func<string[]>> bodyenvironments = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodyenvironments = WorkflowExpression.Compile(bodyenvironments, nameof(bodyenvironments), required: false);
            return new DeferredBodyAction<DopplerProjectMembersUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/project/members/member/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodyenvironments != null)
                {
                    body["environments"] = ExpressionConverter.ConvertO(__workflow_bodyenvironments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DopplerProjectMembersUpdateResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
