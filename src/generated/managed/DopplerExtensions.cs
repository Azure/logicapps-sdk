//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Doppler
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DopplerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerSecretsListSecrets([WorkflowExpression] Func<string> projectName, [WorkflowExpression] Func<string> configName, [WorkflowExpression] Func<bool> includeDynamicSecrets = null, [WorkflowExpression] Func<bool> includeManagedSecrets = null)
        {
            SourceExpression.Validate(projectName, nameof(projectName), required: true);
            SourceExpression.Validate(configName, nameof(configName), required: true);
            SourceExpression.Validate(includeDynamicSecrets, nameof(includeDynamicSecrets), required: false);
            SourceExpression.Validate(includeManagedSecrets, nameof(includeManagedSecrets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Project Name"] = SourceExpressionConverter.ConvertO(projectName);
                callPayload.Queries["Config Name"] = SourceExpressionConverter.ConvertO(configName);
                callPayload.Queries["Include Dynamic Secrets"] = Convert.ToString(false);
                if (includeDynamicSecrets != null)
                    callPayload.Queries["Include Dynamic Secrets"] = SourceExpressionConverter.ConvertO(includeDynamicSecrets);
                callPayload.Queries["Include Managed Secrets"] = Convert.ToString(true);
                if (includeManagedSecrets != null)
                    callPayload.Queries["Include Managed Secrets"] = SourceExpressionConverter.ConvertO(includeManagedSecrets);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsUpdateSecretResponse> DopplerSecretsUpdateSecret([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfig);
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
                return callPayload;
            }

            return new ApiConnectionAction<DopplerSecretsUpdateSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerSecretsRetrieveSecretResponse> DopplerSecretsRetrieveSecret([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> config, [WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(config, nameof(config), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["config"] = SourceExpressionConverter.ConvertO(config);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerSecretsRetrieveSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerSecretsDeleteSecret([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> config, [WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(config, nameof(config), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/secret";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["config"] = SourceExpressionConverter.ConvertO(config);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IWorkflowAction DopplerSecretsUpdateSecretNote([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig, [WorkflowExpression] Func<string> bodysecret, [WorkflowExpression] Func<string> bodynote)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            SourceExpression.Validate(bodysecret, nameof(bodysecret), required: true);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/secrets/note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfig);
                bodypropCount++;
                body["secret"] = SourceExpressionConverter.ConvertToken(bodysecret);
                bodypropCount++;
                body["note"] = SourceExpressionConverter.ConvertToken(bodynote);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigListConfigResponse> DopplerConfigListConfig([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> perPage)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(perPage, nameof(perPage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigListConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCreateConfigResponse> DopplerConfigCreateConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyenvironment, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyenvironment, nameof(bodyenvironment), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["environment"] = SourceExpressionConverter.ConvertToken(bodyenvironment);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigCreateConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigRetrieveConfigResponse> DopplerConfigRetrieveConfig([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> config = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(config, nameof(config), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (config != null)
                    callPayload.Queries["config"] = SourceExpressionConverter.ConvertO(config);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigRetrieveConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUpdateConfigNameResponse> DopplerConfigUpdateConfigName([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfig);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigUpdateConfigNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigCloneConfigResponse> DopplerConfigCloneConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfig);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigCloneConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigLockConfigResponse> DopplerConfigLockConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfig);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigLockConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerConfigUnlockConfigResponse> DopplerConfigUnlockConfig([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyconfig)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyconfig, nameof(bodyconfig), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/configs/config/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfig);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerConfigUnlockConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsListResponse> DopplerProjectsList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(20);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsCreateResponse> DopplerProjectsCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectsCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsRetrieveResponse> DopplerProjectsRetrieve([WorkflowExpression] Func<string> project)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectsRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectsUpdateResponse> DopplerProjectsUpdate([WorkflowExpression] Func<string> bodyproject, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription)
        {
            SourceExpression.Validate(bodyproject, nameof(bodyproject), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["project"] = SourceExpressionConverter.ConvertToken(bodyproject);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectsUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectRolesListResponse> DopplerProjectRolesList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects/roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectRolesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectRolesRetrieveResponse> DopplerProjectRolesRetrieve([WorkflowExpression] Func<string> role)
        {
            SourceExpression.Validate(role, nameof(role), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/projects/roles/role/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(role, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectRolesRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerProjectRolesDelete([WorkflowExpression] Func<string> role)
        {
            SourceExpression.Validate(role, nameof(role), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/projects/roles/role/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(role, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersListResponse> DopplerProjectMembersList([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(20);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectMembersListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersAddResponse> DopplerProjectMembersAdd([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyslug, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string[]> bodyenvironments = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: true);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodyenvironments, nameof(bodyenvironments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/projects/project/members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodyenvironments != null)
                {
                    body["environments"] = SourceExpressionConverter.ConvertToken(bodyenvironments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectMembersAddResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersRetrieveResponse> DopplerProjectMembersRetrieve([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> project)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(slug, nameof(slug), required: true);
            SourceExpression.Validate(project, nameof(project), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/projects/project/members/member/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectMembersRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<JToken> DopplerProjectMembersDelete([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> project)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(slug, nameof(slug), required: true);
            SourceExpression.Validate(project, nameof(project), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/projects/project/members/member/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "doppler")]
        public IBodyWorkflowAction<DopplerProjectMembersUpdateResponse> DopplerProjectMembersUpdate([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string[]> bodyenvironments = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(slug, nameof(slug), required: true);
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodyenvironments, nameof(bodyenvironments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/projects/project/members/member/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(slug, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodyenvironments != null)
                {
                    body["environments"] = SourceExpressionConverter.ConvertToken(bodyenvironments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DopplerProjectMembersUpdateResponse>(BuildSourceInput);
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