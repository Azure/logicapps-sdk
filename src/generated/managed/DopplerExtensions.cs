//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Doppler
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DopplerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerSecretsListSecrets(Expression<Func<string>> projectName, Expression<Func<string>> configName, Expression<Func<bool>> includeDynamicSecrets = null, Expression<Func<bool>> includeManagedSecrets = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsUpdateSecretResponse> DopplerSecretsUpdateSecret(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsRetrieveSecretResponse> DopplerSecretsRetrieveSecret(Expression<Func<string>> project, Expression<Func<string>> config, Expression<Func<string>> name)
        {
            var apiCallPath = "/v3/configs/config/secret";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["config"] = ExpressionConverter.Convert(config);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<DopplerSecretsRetrieveSecretResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerSecretsDeleteSecret(Expression<Func<string>> project, Expression<Func<string>> config, Expression<Func<string>> name)
        {
            var apiCallPath = "/v3/configs/config/secret";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["config"] = ExpressionConverter.Convert(config);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IWorkflowAction DopplerSecretsUpdateSecretNote(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig, Expression<Func<string>> bodysecret, Expression<Func<string>> bodynote)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigListConfigResponse> DopplerConfigListConfig(Expression<Func<string>> project, Expression<Func<int>> page, Expression<Func<int>> perPage)
        {
            var apiCallPath = "/v3/configs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<DopplerConfigListConfigResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCreateConfigResponse> DopplerConfigCreateConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyenvironment, Expression<Func<string>> bodyname)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigRetrieveConfigResponse> DopplerConfigRetrieveConfig(Expression<Func<string>> project, Expression<Func<string>> config = null)
        {
            var apiCallPath = "/v3/configs/config";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            if (config != null)
                callPayload.Queries["config"] = ExpressionConverter.Convert(config);
            return new ApiConnectionAction<DopplerConfigRetrieveConfigResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUpdateConfigNameResponse> DopplerConfigUpdateConfigName(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig, Expression<Func<string>> bodyname)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCloneConfigResponse> DopplerConfigCloneConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig, Expression<Func<string>> bodyname)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigLockConfigResponse> DopplerConfigLockConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUnlockConfigResponse> DopplerConfigUnlockConfig(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyconfig)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsListResponse> DopplerProjectsList(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsCreateResponse> DopplerProjectsCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsRetrieveResponse> DopplerProjectsRetrieve(Expression<Func<string>> project)
        {
            var apiCallPath = "/v3/projects/project";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            return new ApiConnectionAction<DopplerProjectsRetrieveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsUpdateResponse> DopplerProjectsUpdate(Expression<Func<string>> bodyproject, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription)
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
            var apiCallPath = String.Format("/v3/projects/roles/role/{0}", ExpressionConverter.ConvertWithUrlEncoding(role, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DopplerProjectRolesRetrieveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerProjectRolesDelete(Expression<Func<string>> role)
        {
            var apiCallPath = String.Format("/v3/projects/roles/role/{0}", ExpressionConverter.ConvertWithUrlEncoding(role, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersListResponse> DopplerProjectMembersList(Expression<Func<string>> project, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersAddResponse> DopplerProjectMembersAdd(Expression<Func<string>> project, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyslug, Expression<Func<string>> bodyrole = null, Expression<Func<string[]>> bodyenvironments = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersRetrieveResponse> DopplerProjectMembersRetrieve(Expression<Func<typeInput>> type, Expression<Func<string>> slug, Expression<Func<string>> project)
        {
            var apiCallPath = String.Format("/v3/projects/project/members/member/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            return new ApiConnectionAction<DopplerProjectMembersRetrieveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerProjectMembersDelete(Expression<Func<string>> type, Expression<Func<string>> slug, Expression<Func<string>> project)
        {
            var apiCallPath = String.Format("/v3/projects/project/members/member/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersUpdateResponse> DopplerProjectMembersUpdate(Expression<Func<string>> type, Expression<Func<string>> slug, Expression<Func<string>> project, Expression<Func<string>> bodyrole = null, Expression<Func<string[]>> bodyenvironments = null)
        {
            var apiCallPath = String.Format("/v3/projects/project/members/member/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(slug, 1));
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
    using Microsoft.Azure.Workflows.Sdk.Doppler;

    public partial class WorkflowManagedActions
    {
        public DopplerActions Doppler(string connectionId) => new DopplerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DopplerTriggers Doppler(string connectionId) => new DopplerTriggers(connectionId);
    }
}