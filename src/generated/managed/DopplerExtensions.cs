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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DopplerSecretsListSecrets(Expression<Func<string>> projectName, Expression<Func<string>> configName, Expression<Func<bool>> includeDynamicSecrets = null, Expression<Func<bool>> includeManagedSecrets = null)
        {
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            var __workflow_configName = WorkflowExpression.Compile(configName, nameof(configName), required: true);
            var __workflow_includeDynamicSecrets = WorkflowExpression.Compile(includeDynamicSecrets, nameof(includeDynamicSecrets), required: false);
            var __workflow_includeManagedSecrets = WorkflowExpression.Compile(includeManagedSecrets, nameof(includeManagedSecrets), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsUpdateSecretResponse, ApiConnectionActionConfiguration> DopplerSecretsUpdateSecret(Expression<Func<DopplerSecretsUpdateSecretInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerSecretsUpdateSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerSecretsUpdateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsRetrieveSecretResponse, ApiConnectionActionConfiguration> DopplerSecretsRetrieveSecret(Expression<Func<string>> project, Expression<Func<string>> config, Expression<Func<string>> name)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<DopplerSecretsRetrieveSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["config"] = ExpressionConverter.Convert(__workflow_config);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<DopplerSecretsRetrieveSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DopplerSecretsDeleteSecret(Expression<Func<string>> project, Expression<Func<string>> config, Expression<Func<string>> name)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["config"] = ExpressionConverter.Convert(__workflow_config);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DopplerSecretsUpdateSecretNote(Expression<Func<DopplerSecretsUpdateSecretNoteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/secrets/note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigListConfigResponse, ApiConnectionActionConfiguration> DopplerConfigListConfig(Expression<Func<string>> project, Expression<Func<int>> page, Expression<Func<int>> perPage)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: true);
            return new DeferredBodyAction<DopplerConfigListConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<DopplerConfigListConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCreateConfigResponse, ApiConnectionActionConfiguration> DopplerConfigCreateConfig(Expression<Func<DopplerConfigCreateConfigInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerConfigCreateConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerConfigCreateConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigRetrieveConfigResponse, ApiConnectionActionConfiguration> DopplerConfigRetrieveConfig(Expression<Func<string>> project, Expression<Func<string>> config = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_config = WorkflowExpression.Compile(config, nameof(config), required: false);
            return new DeferredBodyAction<DopplerConfigRetrieveConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_config != null)
                    callPayload.Queries["config"] = ExpressionConverter.Convert(__workflow_config);
                return new ApiConnectionAction<DopplerConfigRetrieveConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUpdateConfigNameResponse, ApiConnectionActionConfiguration> DopplerConfigUpdateConfigName(Expression<Func<DopplerConfigUpdateConfigNameInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerConfigUpdateConfigNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerConfigUpdateConfigNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCloneConfigResponse, ApiConnectionActionConfiguration> DopplerConfigCloneConfig(Expression<Func<DopplerConfigCloneConfigInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerConfigCloneConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerConfigCloneConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigLockConfigResponse, ApiConnectionActionConfiguration> DopplerConfigLockConfig(Expression<Func<DopplerConfigLockConfigInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerConfigLockConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerConfigLockConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUnlockConfigResponse, ApiConnectionActionConfiguration> DopplerConfigUnlockConfig(Expression<Func<DopplerConfigUnlockConfigInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerConfigUnlockConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/configs/config/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerConfigUnlockConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsListResponse, ApiConnectionActionConfiguration> DopplerProjectsList(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<DopplerProjectsListResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsCreateResponse, ApiConnectionActionConfiguration> DopplerProjectsCreate(Expression<Func<DopplerProjectsCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerProjectsCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerProjectsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsRetrieveResponse, ApiConnectionActionConfiguration> DopplerProjectsRetrieve(Expression<Func<string>> project)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<DopplerProjectsRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<DopplerProjectsRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsUpdateResponse, ApiConnectionActionConfiguration> DopplerProjectsUpdate(Expression<Func<DopplerProjectsUpdateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerProjectsUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerProjectsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectRolesListResponse, ApiConnectionActionConfiguration> DopplerProjectRolesList()
        {
            return new DeferredBodyAction<DopplerProjectRolesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/projects/roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DopplerProjectRolesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectRolesRetrieveResponse, ApiConnectionActionConfiguration> DopplerProjectRolesRetrieve(Expression<Func<string>> role)
        {
            var __workflow_role = WorkflowExpression.Compile(role, nameof(role), required: true);
            return new DeferredBodyAction<DopplerProjectRolesRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/roles/role/{0}", __workflow_role.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DopplerProjectRolesRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DopplerProjectRolesDelete(Expression<Func<string>> role)
        {
            var __workflow_role = WorkflowExpression.Compile(role, nameof(role), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/roles/role/{0}", __workflow_role.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersListResponse, ApiConnectionActionConfiguration> DopplerProjectMembersList(Expression<Func<string>> project, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<DopplerProjectMembersListResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersAddResponse, ApiConnectionActionConfiguration> DopplerProjectMembersAdd(Expression<Func<string>> project, Expression<Func<DopplerProjectMembersAddInput>> body)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DopplerProjectMembersAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DopplerProjectMembersAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersRetrieveResponse, ApiConnectionActionConfiguration> DopplerProjectMembersRetrieve(Expression<Func<typeInput>> type, Expression<Func<string>> slug, Expression<Func<string>> project)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<DopplerProjectMembersRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/project/members/member/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<DopplerProjectMembersRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DopplerProjectMembersDelete(Expression<Func<string>> type, Expression<Func<string>> slug, Expression<Func<string>> project)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/project/members/member/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersUpdateResponse, ApiConnectionActionConfiguration> DopplerProjectMembersUpdate(Expression<Func<string>> type, Expression<Func<string>> slug, Expression<Func<string>> project, Expression<Func<DopplerProjectMembersUpdateInput>> body = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DopplerProjectMembersUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/projects/project/members/member/{0}/{1}", __workflow_type.WithUrlEncoding(1), __workflow_slug.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class DopplerSecretsUpdateSecretInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Config { get; set; }

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

    public class DopplerSecretsUpdateSecretNoteInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Config { get; set; }

        [JsonProperty("secret", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Secret { get; set; }

        [JsonProperty("note", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class DopplerConfigCreateConfigInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("environment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Environment { get; set; } = "ENVIRONMENT_ID";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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

    public class DopplerConfigUpdateConfigNameInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Config { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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

    public class DopplerConfigCloneConfigInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Config { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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

    public class DopplerConfigLockConfigInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Config { get; set; }
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

    public class DopplerConfigUnlockConfigInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Config { get; set; }
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

    public class DopplerProjectsCreateInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; } = "My_awesome_project";

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }
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

    public class DopplerProjectsUpdateInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Project { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }
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

    public class DopplerProjectMembersAddInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public DopplerProjectMembersAddInputTypeType Type { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("environments")]
        public string[] Environments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DopplerProjectMembersAddInputTypeType
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

    public class DopplerProjectMembersUpdateInput
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("environments")]
        public string[] Environments { get; set; }
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