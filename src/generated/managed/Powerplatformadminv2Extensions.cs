//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerplatformadminv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Powerplatformadminv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorActionResponse> ExecuteRecommendationAction([WorkflowExpression] Func<string> bodyrecommendationName, [WorkflowExpression] Func<object> bodyparameters, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/analytics/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["scenario"] = SourceExpressionConverter.ConvertToken(bodyrecommendationName);
                bodypropCount++;
                body["actionParameters"] = SourceExpressionConverter.ConvertToken(bodyparameters);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AdvisorActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorChatMessageResponse> SendAdvisorChatMessage([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyconversationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/analytics/advisor/chat/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodyconversationId != null)
                {
                    body["conversationId"] = SourceExpressionConverter.ConvertToken(bodyconversationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AdvisorChatMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorRecommendationIEnumerableResponseWithContinuation> GetRecommendations([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/analytics/advisorRecommendations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AdvisorRecommendationIEnumerableResponseWithContinuation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation> GetRecommendationResources([WorkflowExpression] Func<string> scenario, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/analytics/advisorRecommendations/{0}/resources", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scenario, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantApplicationPackageContinuationResponse> GetTenantApplicationPackage([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/appmanagement/applicationPackages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantApplicationPackageContinuationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ApplicationPackageContinuationResponse> GetEnvironmentApplicationPackage([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<appInstallStateInput> appInstallState = null, [WorkflowExpression] Func<string> lcid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/appmanagement/environments/{0}/applicationPackages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (appInstallState != null)
                    callPayload.Queries["appInstallState"] = SourceExpressionConverter.Convert(appInstallState);
                if (lcid != null)
                    callPayload.Queries["lcid"] = SourceExpressionConverter.ConvertO(lcid);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ApplicationPackageContinuationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<InstancePackage> InstallApplicationPackage([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> uniqueName, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodypayloadValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/appmanagement/environments/{0}/applicationPackages/{1}/install", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uniqueName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypayloadValue != null)
                {
                    body["payloadValue"] = SourceExpressionConverter.ConvertToken(bodypayloadValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InstancePackage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<InstancePackageOperationPollingResponse> GetApplicationPackageInstallStatus([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> operationId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/appmanagement/environments/{0}/operations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(operationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<InstancePackageOperationPollingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> ListEnvironmentGroupRoleAssignments([WorkflowExpression] Func<string> environmentGroupId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/environmentGroups/{0}/roleAssignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RoleAssignmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> CreateEnvironmentGroupRoleAssignment([WorkflowExpression] Func<string> environmentGroupId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyprincipalObjectId = null, [WorkflowExpression] Func<string> bodyroleDefinitionId = null, [WorkflowExpression] Func<string> bodyscope = null, [WorkflowExpression] Func<string> bodyprincipalType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/environmentGroups/{0}/roleAssignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentGroupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = SourceExpressionConverter.ConvertToken(bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (bodyroleDefinitionId != null)
                {
                    body["roleDefinitionId"] = SourceExpressionConverter.ConvertToken(bodyroleDefinitionId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["scope"] = SourceExpressionConverter.ConvertToken(bodyscope);
                    bodypropCount++;
                }

                if (bodyprincipalType != null)
                {
                    body["principalType"] = SourceExpressionConverter.ConvertToken(bodyprincipalType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RoleAssignmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteEnvironmentGroupRoleAssignment([WorkflowExpression] Func<string> environmentGroupId, [WorkflowExpression] Func<string> roleAssignmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/environmentGroups/{0}/roleAssignments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentGroupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleAssignmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> ListEnvironmentRoleAssignments([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/environments/{0}/roleAssignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RoleAssignmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> CreateEnvironmentRoleAssignment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyprincipalObjectId = null, [WorkflowExpression] Func<string> bodyroleDefinitionId = null, [WorkflowExpression] Func<string> bodyscope = null, [WorkflowExpression] Func<string> bodyprincipalType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/environments/{0}/roleAssignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = SourceExpressionConverter.ConvertToken(bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (bodyroleDefinitionId != null)
                {
                    body["roleDefinitionId"] = SourceExpressionConverter.ConvertToken(bodyroleDefinitionId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["scope"] = SourceExpressionConverter.ConvertToken(bodyscope);
                    bodypropCount++;
                }

                if (bodyprincipalType != null)
                {
                    body["principalType"] = SourceExpressionConverter.ConvertToken(bodyprincipalType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RoleAssignmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteEnvironmentRoleAssignment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> roleAssignmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/environments/{0}/roleAssignments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleAssignmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> ListRoleAssignments([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RoleAssignmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> CreateRoleAssignment([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyprincipalObjectId = null, [WorkflowExpression] Func<string> bodyroleDefinitionId = null, [WorkflowExpression] Func<string> bodyscope = null, [WorkflowExpression] Func<string> bodyprincipalType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = SourceExpressionConverter.ConvertToken(bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (bodyroleDefinitionId != null)
                {
                    body["roleDefinitionId"] = SourceExpressionConverter.ConvertToken(bodyroleDefinitionId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["scope"] = SourceExpressionConverter.ConvertToken(bodyscope);
                    bodypropCount++;
                }

                if (bodyprincipalType != null)
                {
                    body["principalType"] = SourceExpressionConverter.ConvertToken(bodyprincipalType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RoleAssignmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteRoleAssignment([WorkflowExpression] Func<string> roleAssignmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/authorization/roleAssignments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roleAssignmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleDefinitionResponse> ListRoleDefinitions([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/authorization/roleDefinitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RoleDefinitionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListConnectionsResponse> ListConnections([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/connectivity/environments/{0}/connections", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ListConnectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListConnectorsResponse> ListConnectors([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/connectivity/environments/{0}/connectors", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ListConnectorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<GetConnectorByIdResponse> GetConnectorById([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> connectorId, [WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/connectivity/environments/{0}/connectors/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(connectorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<GetConnectorByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<string> DownloadAgentChannelManifest([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> agentId, [WorkflowExpression] Func<string> channelName, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> includeAgentSchema = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/agents/{1}/channels/{2}/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(agentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAgentSchema"] = Convert.ToString(false);
                if (includeAgentSchema != null)
                    callPayload.Queries["includeAgentSchema"] = SourceExpressionConverter.ConvertO(includeAgentSchema);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteCopilotAgent([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botAdminOperations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction ReassignCopilotAgent([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodynewOwnerAadUserId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botAdminOperations/reassign", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["NewOwnerAadUserId"] = SourceExpressionConverter.ConvertToken(bodynewOwnerAadUserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus> GetBotQuarantineStatus([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BotQuarantineStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus> SetBotAsQuarantined([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsQuarantined", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BotQuarantineStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus> SetBotAsUnquarantined([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsUnquarantined", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BotQuarantineStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ConnectorConsentBypassResponse> GetConnectorConsentBypass([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/connectorConsentBypass", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ConnectorConsentBypassResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ConnectorConsentBypassResponse> SetConnectorConsentBypass([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> bodyadminConsentBypass)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/connectorConsentBypass", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["adminConsentBypass"] = SourceExpressionConverter.ConvertToken(bodyadminConsentBypass);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConnectorConsentBypassResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestRunCollection> ListMakerEvaluationTestRuns([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testruns", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TestRunCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestRun> GetMakerEvaluationTestRun([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> testRunId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testruns/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(testRunId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TestRun>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<string> DownloadMakerEvaluationSnapshot([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> testRunId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testruns/{2}/snapshot", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(testRunId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestSetCollection> ListMakerEvaluationTestSets([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testsets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TestSetCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestSet> GetMakerEvaluationTestSet([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> testSetId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testsets/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(testSetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TestSet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RunStatusResponse> RunMakerEvaluationTestSet([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> testSetId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyevaluationRunName = null, [WorkflowExpression] Func<string> bodymcsConnectionId = null, [WorkflowExpression] Func<bool> bodyrunOnPublishedBot = null, [WorkflowExpression] Func<ToolsConnections[]> bodytoolsConnections = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testsets/{2}/run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(testSetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyevaluationRunName != null)
                {
                    body["evaluationRunName"] = SourceExpressionConverter.ConvertToken(bodyevaluationRunName);
                    bodypropCount++;
                }

                if (bodymcsConnectionId != null)
                {
                    body["mcsConnectionId"] = SourceExpressionConverter.ConvertToken(bodymcsConnectionId);
                    bodypropCount++;
                }

                if (bodyrunOnPublishedBot != null)
                {
                    if (bodyrunOnPublishedBot != null)
                    {
                        body["runOnPublishedBot"] = SourceExpressionConverter.ConvertToken(bodyrunOnPublishedBot);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["runOnPublishedBot"] = false;
                    bodypropCount++;
                }

                if (bodytoolsConnections != null)
                {
                    body["toolsConnections"] = SourceExpressionConverter.ConvertToken(bodytoolsConnections);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> GetEnvironmentGroupOperation([WorkflowExpression] Func<string> operationId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroupOperations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(operationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> DeleteEnvironmentGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> AddEnvironmentToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroups/{0}/addEnvironment/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> RemoveEnvironmentFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroups/{0}/removeEnvironment/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentList> ListEnvironmentsForUser([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> orderby = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/environmentmanagement/environments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<EnvironmentList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentResponse> GetEnvironmentByIdForUser([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> select = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<EnvironmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy> CreateRuleBasedPolicy([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<RuleSet[]> bodyruleSets = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyruleSets != null)
                {
                    body["ruleSets"] = SourceExpressionConverter.ConvertToken(bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Policy>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListPolicyResponse> ListRuleBasedPolicies([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ListPolicyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy> GetRuleBasedPolicyById([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<Policy>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignment> UpdateRuleBasedPolicyById([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<RuleSet[]> bodyruleSets = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyruleSets != null)
                {
                    body["ruleSets"] = SourceExpressionConverter.ConvertToken(bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RuleAssignment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy> PatchRuleBasedPolicy([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<RuleSet[]> bodyruleSets = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyruleSets != null)
                {
                    body["ruleSets"] = SourceExpressionConverter.ConvertToken(bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Policy>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByPolicyId([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}/assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = SourceExpressionConverter.ConvertO(includeRuleSetCounts);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RuleAssignmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy> RemoveRuleFromRuleBasedPolicy([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<RuleSet[]> bodyruleSets = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}/removeRule", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyruleSets != null)
                {
                    body["ruleSets"] = SourceExpressionConverter.ConvertToken(bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Policy>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignments([WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/governance/ruleBasedPolicies/assignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = SourceExpressionConverter.ConvertO(includeRuleSetCounts);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RuleAssignmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByEnvironmentGroupId([WorkflowExpression] Func<string> environmentGroupId, [WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/environmentGroups/{0}/assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = SourceExpressionConverter.ConvertO(includeRuleSetCounts);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RuleAssignmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByEnvironmentId([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/environments/{0}/assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = SourceExpressionConverter.ConvertO(includeRuleSetCounts);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<RuleAssignmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CrossTenantConnectionReportsResponseWithOdataContinuation> ListCrossTenantConnectionReports([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/governance/crossTenantConnectionReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<CrossTenantConnectionReportsResponseWithOdataContinuation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CrossTenantConnectionReport> GetCrossTenantConnectionReport([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/governance/crossTenantConnectionReports/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<CrossTenantConnectionReport>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantEntitlementResponseModel> GetEntitlement([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantEntitlementResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentEntitlementSnapshotResponseModelPagedResponse> GetEnvironmentResources([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> fromDate, [WorkflowExpression] Func<string> toDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> searchRequest = null, [WorkflowExpression] Func<string> includeFields = null, [WorkflowExpression] Func<string> orderbyConsumed = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/environments/{1}/resources", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                if (searchRequest != null)
                    callPayload.Queries["searchRequest"] = SourceExpressionConverter.ConvertO(searchRequest);
                if (includeFields != null)
                    callPayload.Queries["includeFields"] = SourceExpressionConverter.ConvertO(includeFields);
                if (orderbyConsumed != null)
                    callPayload.Queries["orderbyConsumed"] = SourceExpressionConverter.ConvertO(orderbyConsumed);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<EnvironmentEntitlementSnapshotResponseModelPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantEntitlementLicenseTrendResponseModelPagedResponse> GetTenantLicenseTrends([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> fromDate, [WorkflowExpression] Func<string> toDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/licenses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantEntitlementLicenseTrendResponseModelPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantEnvironmentResourceSnapshotResponseModelPagedResponse> GetTenantResourcesAcrossEnvironments([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> fromDate, [WorkflowExpression] Func<string> toDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/resources", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantEnvironmentResourceSnapshotResponseModelPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantUserResponseModelPagedResponse> GetTenantUserConsumptionByResource([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> resourceId, [WorkflowExpression] Func<string> fromDate, [WorkflowExpression] Func<string> toDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> searchRequest = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/resources/{1}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (searchRequest != null)
                    callPayload.Queries["searchRequest"] = SourceExpressionConverter.ConvertO(searchRequest);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantUserResponseModelPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceThresholdModel[]> GetAllResourceThresholds([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/resourceThresholds", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ResourceThresholdModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantUserResponseModelPagedResponse> GetTenantUsers([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> fromDate, [WorkflowExpression] Func<string> toDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> searchRequest = null, [WorkflowExpression] Func<string> orderbyConsumed = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (searchRequest != null)
                    callPayload.Queries["searchRequest"] = SourceExpressionConverter.ConvertO(searchRequest);
                if (orderbyConsumed != null)
                    callPayload.Queries["orderbyConsumed"] = SourceExpressionConverter.ConvertO(orderbyConsumed);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantUserResponseModelPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantResourceResponseModelPagedResponse> GetTenantResourceConsumptionByUser([WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> fromDate, [WorkflowExpression] Func<string> toDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> searchRequest = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/entitlements/{0}/users/{1}/resources", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (searchRequest != null)
                    callPayload.Queries["searchRequest"] = SourceExpressionConverter.ConvertO(searchRequest);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantResourceResponseModelPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentEntitlementResponseModel[]> GetManyEnvironmentEntitlements([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/entitlements", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<EnvironmentEntitlementResponseModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceThresholdModel> UpsertResourceThreshold([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> entitlementId, [WorkflowExpression] Func<string> resourceId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> bodystopResource = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<bool> bodystopIfOverCapacity = null, [WorkflowExpression] Func<bool> bodynotifyIfOverCapacity = null, [WorkflowExpression] Func<int> bodynotificationThreshold = null, [WorkflowExpression] Func<double> bodyresourceConsumption = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/entitlements/{1}/resources/{2}/threshold", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entitlementId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystopResource != null)
                {
                    body["stopResource"] = SourceExpressionConverter.ConvertToken(bodystopResource);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodystopIfOverCapacity != null)
                {
                    body["stopIfOverCapacity"] = SourceExpressionConverter.ConvertToken(bodystopIfOverCapacity);
                    bodypropCount++;
                }

                if (bodynotifyIfOverCapacity != null)
                {
                    body["notifyIfOverCapacity"] = SourceExpressionConverter.ConvertToken(bodynotifyIfOverCapacity);
                    bodypropCount++;
                }

                if (bodynotificationThreshold != null)
                {
                    body["notificationThreshold"] = SourceExpressionConverter.ConvertToken(bodynotificationThreshold);
                    bodypropCount++;
                }

                if (bodyresourceConsumption != null)
                {
                    body["resourceConsumption"] = SourceExpressionConverter.ConvertToken(bodyresourceConsumption);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResourceThresholdModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationByEnvironmentModel[]> ListAllocationsByEnvironment([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/allocationsByEnvironment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AllocationByEnvironmentModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationByEnvironmentModel> UpdateAllocationsByEnvironment([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyenvironmentId = null, [WorkflowExpression] Func<CurrencyAllocationModel[]> bodycurrencyAllocations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/allocationsByEnvironment";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyenvironmentId != null)
                {
                    body["environmentId"] = SourceExpressionConverter.ConvertToken(bodyenvironmentId);
                    bodypropCount++;
                }

                if (bodycurrencyAllocations != null)
                {
                    body["currencyAllocations"] = SourceExpressionConverter.ConvertToken(bodycurrencyAllocations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AllocationByEnvironmentModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationByEnvironmentModel> GetAllocationsByEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/allocationsByEnvironment/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AllocationByEnvironmentModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModelResponseWithOdataContinuation> ListBillingPolicies([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyResponseModelResponseWithOdataContinuation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> CreateBillingPolicy([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodybillingInstrumentsubscriptionId = null, [WorkflowExpression] Func<string> bodybillingInstrumentresourceGroup = null, [WorkflowExpression] Func<string> bodybillingInstrumentid = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                var billingInstrumentObject = new JObject();
                var billingInstrumentObjectpropCount = 0;
                if (bodybillingInstrumentsubscriptionId != null)
                {
                    billingInstrumentObject["subscriptionId"] = SourceExpressionConverter.ConvertToken(bodybillingInstrumentsubscriptionId);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentresourceGroup != null)
                {
                    billingInstrumentObject["resourceGroup"] = SourceExpressionConverter.ConvertToken(bodybillingInstrumentresourceGroup);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentid != null)
                {
                    billingInstrumentObject["id"] = SourceExpressionConverter.ConvertToken(bodybillingInstrumentid);
                    billingInstrumentObjectpropCount++;
                }

                if (billingInstrumentObjectpropCount > 0)
                {
                    body["billingInstrument"] = billingInstrumentObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> GetBillingPolicy([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> UpdateBillingPolicy([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteBillingPolicy([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation> ListBillingPolicyEnvironments([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1> GetBillingPolicyEnvironment([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction AddBillingPolicyEnvironment([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string[]> bodyenvironmentIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyenvironmentIds != null)
                {
                    body["environmentIds"] = SourceExpressionConverter.ConvertToken(bodyenvironmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction RemoveBillingPolicyEnvironment([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string[]> bodyenvironmentIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments/remove", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyenvironmentIds != null)
                {
                    body["environmentIds"] = SourceExpressionConverter.ConvertToken(bodyenvironmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> RefreshProvisioningStatus([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/refreshProvisioningStatus", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> GetCurrencyAllocationByEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/allocations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> PatchCurrencyAllocationByEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<CurrencyAllocationRequestModelV1[]> bodycurrencyAllocations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/allocations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycurrencyAllocations != null)
                {
                    body["currencyAllocations"] = SourceExpressionConverter.ConvertToken(bodycurrencyAllocations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> GetEnvironmentBillingPolicy([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/billingPolicy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<BillingPolicyResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModelResponseWithOdataContinuation> ListISVContracts([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<IsvContractResponseModelResponseWithOdataContinuation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel> CreateISVContract([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodygeo, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyconsumertenantId = null, [WorkflowExpression] Func<bool> bodyconditionsapiFilterallowOtherPremiumConnectors = null, [WorkflowExpression] Func<BillingPolicyConditionsApiModel[]> bodyconditionsapiFilterrequiredApis = null, [WorkflowExpression] Func<string> bodybillingInstrumentsubscriptionId = null, [WorkflowExpression] Func<string> bodybillingInstrumentresourceGroup = null, [WorkflowExpression] Func<string> bodybillingInstrumentid = null, [WorkflowExpression] Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["geo"] = SourceExpressionConverter.ConvertToken(bodygeo);
                var consumerObject = new JObject();
                var consumerObjectpropCount = 0;
                if (bodyconsumertenantId != null)
                {
                    consumerObject["tenantId"] = SourceExpressionConverter.ConvertToken(bodyconsumertenantId);
                    consumerObjectpropCount++;
                }

                if (consumerObjectpropCount > 0)
                {
                    body["consumer"] = consumerObject;
                    bodypropCount++;
                }

                var conditionsObject = new JObject();
                var conditionsObjectpropCount = 0;
                var apiFilterObject = new JObject();
                var apiFilterObjectpropCount = 0;
                if (bodyconditionsapiFilterallowOtherPremiumConnectors != null)
                {
                    apiFilterObject["allowOtherPremiumConnectors"] = SourceExpressionConverter.ConvertToken(bodyconditionsapiFilterallowOtherPremiumConnectors);
                    apiFilterObjectpropCount++;
                }

                if (bodyconditionsapiFilterrequiredApis != null)
                {
                    apiFilterObject["requiredApis"] = SourceExpressionConverter.ConvertToken(bodyconditionsapiFilterrequiredApis);
                    apiFilterObjectpropCount++;
                }

                if (apiFilterObjectpropCount > 0)
                {
                    conditionsObject["apiFilter"] = apiFilterObject;
                    conditionsObjectpropCount++;
                }

                if (conditionsObjectpropCount > 0)
                {
                    body["conditions"] = conditionsObject;
                    bodypropCount++;
                }

                var billingInstrumentObject = new JObject();
                var billingInstrumentObjectpropCount = 0;
                if (bodybillingInstrumentsubscriptionId != null)
                {
                    billingInstrumentObject["subscriptionId"] = SourceExpressionConverter.ConvertToken(bodybillingInstrumentsubscriptionId);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentresourceGroup != null)
                {
                    billingInstrumentObject["resourceGroup"] = SourceExpressionConverter.ConvertToken(bodybillingInstrumentresourceGroup);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentid != null)
                {
                    billingInstrumentObject["id"] = SourceExpressionConverter.ConvertToken(bodybillingInstrumentid);
                    billingInstrumentObjectpropCount++;
                }

                if (billingInstrumentObjectpropCount > 0)
                {
                    body["billingInstrument"] = billingInstrumentObject;
                    bodypropCount++;
                }

                var powerAutomatePolicyObject = new JObject();
                var powerAutomatePolicyObjectpropCount = 0;
                if (bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["cloudFlowRunsPayAsYouGoState"] = SourceExpressionConverter.Convert(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowUnattendedRunsPayAsYouGoState"] = SourceExpressionConverter.Convert(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowAttendedRunsPayAsYouGoState"] = SourceExpressionConverter.Convert(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (powerAutomatePolicyObjectpropCount > 0)
                {
                    body["powerAutomatePolicy"] = powerAutomatePolicyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsvContractResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel> GetISVContract([WorkflowExpression] Func<string> isvContractId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/isvContracts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(isvContractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<IsvContractResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel> UpdateISVContract([WorkflowExpression] Func<string> isvContractId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bool> bodyconditionsapiFilterallowOtherPremiumConnectors = null, [WorkflowExpression] Func<BillingPolicyConditionsApiModel[]> bodyconditionsapiFilterrequiredApis = null, [WorkflowExpression] Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/isvContracts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(isvContractId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                var conditionsObject = new JObject();
                var conditionsObjectpropCount = 0;
                var apiFilterObject = new JObject();
                var apiFilterObjectpropCount = 0;
                if (bodyconditionsapiFilterallowOtherPremiumConnectors != null)
                {
                    apiFilterObject["allowOtherPremiumConnectors"] = SourceExpressionConverter.ConvertToken(bodyconditionsapiFilterallowOtherPremiumConnectors);
                    apiFilterObjectpropCount++;
                }

                if (bodyconditionsapiFilterrequiredApis != null)
                {
                    apiFilterObject["requiredApis"] = SourceExpressionConverter.ConvertToken(bodyconditionsapiFilterrequiredApis);
                    apiFilterObjectpropCount++;
                }

                if (apiFilterObjectpropCount > 0)
                {
                    conditionsObject["apiFilter"] = apiFilterObject;
                    conditionsObjectpropCount++;
                }

                if (conditionsObjectpropCount > 0)
                {
                    body["conditions"] = conditionsObject;
                    bodypropCount++;
                }

                var powerAutomatePolicyObject = new JObject();
                var powerAutomatePolicyObjectpropCount = 0;
                if (bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["cloudFlowRunsPayAsYouGoState"] = SourceExpressionConverter.Convert(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowUnattendedRunsPayAsYouGoState"] = SourceExpressionConverter.Convert(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowAttendedRunsPayAsYouGoState"] = SourceExpressionConverter.Convert(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (powerAutomatePolicyObjectpropCount > 0)
                {
                    body["powerAutomatePolicy"] = powerAutomatePolicyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsvContractResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteISVContract([WorkflowExpression] Func<string> isvContractId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/isvContracts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(isvContractId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantCapacityDetailsModel> GetTenantCapacityDetails([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/tenantCapacity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<TenantCapacityDetailsModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CurrencyReportV2[]> ListCurrencyReports([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> includeAllocations = null, [WorkflowExpression] Func<bool> includeConsumptions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/tenantCapacity/currencyReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAllocations"] = Convert.ToString(true);
                if (includeAllocations != null)
                    callPayload.Queries["includeAllocations"] = SourceExpressionConverter.ConvertO(includeAllocations);
                callPayload.Queries["includeConsumptions"] = Convert.ToString(false);
                if (includeConsumptions != null)
                    callPayload.Queries["includeConsumptions"] = SourceExpressionConverter.ConvertO(includeConsumptions);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<CurrencyReportV2[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceRecord> GetUserPerFlowCapacitySource([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<string> flowContext = null, [WorkflowExpression] Func<string> flowLicenseCategorization = null, [WorkflowExpression] Func<string> resourceId = null, [WorkflowExpression] Func<string> environmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (flowContext != null)
                    callPayload.Queries["flowContext"] = SourceExpressionConverter.ConvertO(flowContext);
                if (flowLicenseCategorization != null)
                    callPayload.Queries["flowLicenseCategorization"] = SourceExpressionConverter.ConvertO(flowLicenseCategorization);
                if (resourceId != null)
                    callPayload.Queries["resourceId"] = SourceExpressionConverter.ConvertO(resourceId);
                if (environmentId != null)
                    callPayload.Queries["environmentId"] = SourceExpressionConverter.ConvertO(environmentId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceRecord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord> GetUserPerFlowCapacitySourceFlowContextSummary([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> environmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource/FlowContextSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (environmentId != null)
                    callPayload.Queries["environmentId"] = SourceExpressionConverter.ConvertO(environmentId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord> GetUserPerFlowCapacitySourceFlowContextSummaryForUserId([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> environmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/UserPerFlowCapacitySource/FlowContextSummary/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (environmentId != null)
                    callPayload.Queries["environmentId"] = SourceExpressionConverter.ConvertO(environmentId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<UserPerFlowCapacitySourceTenantContextSummaryRecord[]> GetUserPerFlowCapacitySourceTenantContextSummary([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> environmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource/TenantContextSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (environmentId != null)
                    callPayload.Queries["environmentId"] = SourceExpressionConverter.ConvertO(environmentId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<UserPerFlowCapacitySourceTenantContextSummaryRecord[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord> GetUserPerFlowCapacitySourceUserContextSummary([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> environmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource/UserContextSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (environmentId != null)
                    callPayload.Queries["environmentId"] = SourceExpressionConverter.ConvertO(environmentId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord> GetUserPerFlowCapacitySourceUserContextSummaryForUserId([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> environmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licensing/UserPerFlowCapacitySource/UserContextSummary/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (pageNumber != null)
                    callPayload.Queries["pageNumber"] = SourceExpressionConverter.ConvertO(pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (environmentId != null)
                    callPayload.Queries["environmentId"] = SourceExpressionConverter.ConvertO(environmentId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceArrayPowerApp> GetAdminApps([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/powerapps/environments/{0}/apps", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(250);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ResourceArrayPowerApp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerApp> GetAdminApp([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> app, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/powerapps/environments/{0}/apps/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(app, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<PowerApp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceQueryResponse> QueryResources([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodytableName, [WorkflowExpression] Func<Clause[]> bodyclauses, [WorkflowExpression] Func<int> bodyoptionstop = null, [WorkflowExpression] Func<int> bodyoptionsskip = null, [WorkflowExpression] Func<string> bodyoptionsskipToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resourcequery/resources/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TableName"] = SourceExpressionConverter.ConvertToken(bodytableName);
                bodypropCount++;
                body["Clauses"] = SourceExpressionConverter.ConvertToken(bodyclauses);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionstop != null)
                {
                    optionsObject["Top"] = SourceExpressionConverter.ConvertToken(bodyoptionstop);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsskip != null)
                {
                    optionsObject["Skip"] = SourceExpressionConverter.ConvertToken(bodyoptionsskip);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsskipToken != null)
                {
                    optionsObject["SkipToken"] = SourceExpressionConverter.ConvertToken(bodyoptionsskipToken);
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    body["Options"] = optionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResourceQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction ApplyAdminRole([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/usermanagement/environments/{0}/user/applyAdminRole", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrFlowRunsResponse> GetFlowRunActionsForDsr([WorkflowExpression] Func<string> aiFlowId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/aiFlows/{0}/runs/{1}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aiFlowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrFlowRunsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetApprovals([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflowsagent/approvals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteApproval([WorkflowExpression] Func<string> approvalId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/approvals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(approvalId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetConnections([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflowsagent/connections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteConnection([WorkflowExpression] Func<string> connectionIdentifier, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/connections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(connectionIdentifier, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrConversationTranscriptsResponse> GetConversationTranscriptsForDsr([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflowsagent/conversationTranscripts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrConversationTranscriptsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrFlowRunsResponse> GetFlowRunActionsWithEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> aiFlowId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/environments/{0}/aiFlows/{1}/runs/{2}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aiFlowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrFlowRunsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrConversationTranscriptsResponse> GetConversationTranscriptsWithEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/environments/{0}/conversationTranscripts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrConversationTranscriptsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetFlowRunsNonSingleton([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/environments/{0}/flows/{1}/flowRuns", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(flowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetRunHistoryDataNonSingleton([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/environments/{0}/flows/{1}/runs/{2}/runHistoryData", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(flowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetFlows([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflowsagent/flows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteFlow([WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/flows/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(flowId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetFlowRunsSingleton([WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/flows/{0}/flowRuns", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(flowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetRunHistoryData([WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/flows/{0}/runs/{1}/runHistoryData", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(flowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse> GetPrompts([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflowsagent/prompts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<DsrPagedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeletePrompt([WorkflowExpression] Func<string> promptId, [WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflowsagent/prompts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(promptId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<MCPQueryResponse> McpEnvironmentManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/EnvironmentManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
                    queryRequestpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    queryRequest["params"] = @paramsObject;
                    queryRequestpropCount++;
                }

                var resultObject = new JObject();
                var resultObjectpropCount = 0;
                if (resultObjectpropCount > 0)
                {
                    queryRequest["result"] = resultObject;
                    queryRequestpropCount++;
                }

                var errorObject = new JObject();
                var errorObjectpropCount = 0;
                if (errorObjectpropCount > 0)
                {
                    queryRequest["error"] = errorObject;
                    queryRequestpropCount++;
                }

                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<MCPQueryResponse> McpGovernance([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/Governance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
                    queryRequestpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    queryRequest["params"] = @paramsObject;
                    queryRequestpropCount++;
                }

                var resultObject = new JObject();
                var resultObjectpropCount = 0;
                if (resultObjectpropCount > 0)
                {
                    queryRequest["result"] = resultObject;
                    queryRequestpropCount++;
                }

                var errorObject = new JObject();
                var errorObjectpropCount = 0;
                if (errorObjectpropCount > 0)
                {
                    queryRequest["error"] = errorObject;
                    queryRequestpropCount++;
                }

                if (queryRequestpropCount > 0)
                {
                    callPayload.Body = queryRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationAvailabilityResponseModel> GetAllocationsAvailability([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/allocationsV2/availability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AllocationAvailabilityResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<FinOpsLicenseSummaryV2Response> GetFinOpsLicenseSummary([WorkflowExpression] Func<string> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/FinOpsLicensing/GetLicenseSummaryV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<FinOpsLicenseSummaryV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EntitlementReservedResponseModel[]> GetManyEntitlementsReserved([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/allocationsV2/entitlements/reserved";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<EntitlementReservedResponseModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<NeptuneOperationResult> PutAllocations([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyscopetenantId = null, [WorkflowExpression] Func<string> bodyscopeenvironmentGroupId = null, [WorkflowExpression] Func<string> bodyscopeenvironmentId = null, [WorkflowExpression] Func<string> bodyscoperesourceId = null, [WorkflowExpression] Func<string> bodyscopeuserId = null, [WorkflowExpression] Func<string> bodyscopeuserGroupId = null, [WorkflowExpression] Func<EntitlementAllocationModel[]> bodyallocatedEntitlements = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licensing/allocationsV2";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.ConvertO(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                var scopeObject = new JObject();
                var scopeObjectpropCount = 0;
                if (bodyscopetenantId != null)
                {
                    scopeObject["tenantId"] = SourceExpressionConverter.ConvertToken(bodyscopetenantId);
                    scopeObjectpropCount++;
                }

                if (bodyscopeenvironmentGroupId != null)
                {
                    scopeObject["environmentGroupId"] = SourceExpressionConverter.ConvertToken(bodyscopeenvironmentGroupId);
                    scopeObjectpropCount++;
                }

                if (bodyscopeenvironmentId != null)
                {
                    scopeObject["environmentId"] = SourceExpressionConverter.ConvertToken(bodyscopeenvironmentId);
                    scopeObjectpropCount++;
                }

                if (bodyscoperesourceId != null)
                {
                    scopeObject["resourceId"] = SourceExpressionConverter.ConvertToken(bodyscoperesourceId);
                    scopeObjectpropCount++;
                }

                if (bodyscopeuserId != null)
                {
                    scopeObject["userId"] = SourceExpressionConverter.ConvertToken(bodyscopeuserId);
                    scopeObjectpropCount++;
                }

                if (bodyscopeuserGroupId != null)
                {
                    scopeObject["userGroupId"] = SourceExpressionConverter.ConvertToken(bodyscopeuserGroupId);
                    scopeObjectpropCount++;
                }

                if (scopeObjectpropCount > 0)
                {
                    body["scope"] = scopeObject;
                    bodypropCount++;
                }

                if (bodyallocatedEntitlements != null)
                {
                    body["allocatedEntitlements"] = SourceExpressionConverter.ConvertToken(bodyallocatedEntitlements);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NeptuneOperationResult>(BuildSourceInput);
        }
    }

    public class Powerplatformadminv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class AdvisorActionResponse
    {
        [JsonProperty("results")]
        public AdvisorActionResult[] Results { get; set; }
    }

    public class AdvisorActionResult
    {
        [JsonProperty("resourceId")]
        public string ResourceID { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("actionFinalResult")]
        public string ActionResult { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("error")]
        public string ErrorMessage { get; set; }
    }

    public class AdvisorChatMessageResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("executionTimeMs")]
        public int ExecutionTimeMs { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationID { get; set; }
    }

    public class AdvisorRecommendationIEnumerableResponseWithContinuation
    {
        [JsonProperty("value")]
        public AdvisorRecommendation[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class AdvisorRecommendation
    {
        [JsonProperty("scenario")]
        public string RecommendationName { get; set; }

        [JsonProperty("details")]
        public AdvisorRecommendationDetails Details { get; set; }
    }

    public class AdvisorRecommendationDetails
    {
        [JsonProperty("resourceCount")]
        public int ResourceCount { get; set; }

        [JsonProperty("lastRefreshedTimestamp")]
        public string LastRefreshTimestamp { get; set; }

        [JsonProperty("expectedNextRefreshTimestamp")]
        public string ExpectedNextRefreshTimestamp { get; set; }
    }

    public class AdvisorRecommendationResourceIEnumerableResponseWithContinuation
    {
        [JsonProperty("value")]
        public AdvisorRecommendationResource[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class AdvisorRecommendationResource
    {
        [JsonProperty("resourceName")]
        public string ResourceDisplayName { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceID { get; set; }

        [JsonProperty("resourceOwnerId")]
        public string OwnerID { get; set; }

        [JsonProperty("resourceOwner")]
        public string OwnerName { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("resourceSubType")]
        public string ResourceSubType { get; set; }

        [JsonProperty("resourceDescription")]
        public string ResourceDescription { get; set; }

        [JsonProperty("resourceUsage")]
        public double ResourceUsage { get; set; }

        [JsonProperty("environmentName")]
        public string EnvironmentName { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentID { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModfifiedDate { get; set; }

        [JsonProperty("lastAccessedDate")]
        public string LastUsedDate { get; set; }

        [JsonProperty("resourceActionStatus")]
        public string ActionStatus { get; set; }
    }

    public class TenantApplicationPackageContinuationResponse
    {
        [JsonProperty("value")]
        public TenantApplicationPackage[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class TenantApplicationPackage
    {
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("localizedDescription")]
        public string LocalizedDescription { get; set; }

        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("applicationDescription")]
        public string ApplicationDescription { get; set; }

        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        [JsonProperty("learnMoreUrl")]
        public string LearnMoreUrl { get; set; }

        [JsonProperty("catalogVisibility")]
        public CatalogVisibility CatalogVisibility { get; set; }

        [JsonProperty("applicationVisibility")]
        public ApplicationVisibility ApplicationVisibility { get; set; }

        [JsonProperty("lastError")]
        public ErrorDetails LastError { get; set; }
    }

    public enum CatalogVisibility
    {
        None,
        AdminCenter,
        Teams,
        All
    }

    public enum ApplicationVisibility
    {
        None,
        CrmAdminCenter,
        BapAdminCenter,
        OneAdminCenter,
        All
    }

    public class ErrorDetails
    {
        [JsonProperty("errorName")]
        public string ErrorName { get; set; }

        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class ApplicationPackageContinuationResponse
    {
        [JsonProperty("value")]
        public ApplicationPackage[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class ApplicationPackage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("localizedDescription")]
        public string LocalizedDescription { get; set; }

        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("applicationDescription")]
        public string ApplicationDescription { get; set; }

        [JsonProperty("singlePageApplicationUrl")]
        public string SinglePageApplicationUrl { get; set; }

        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        [JsonProperty("learnMoreUrl")]
        public string LearnMoreUrl { get; set; }

        [JsonProperty("platformMinVersion")]
        public string PlatformMinVersion { get; set; }

        [JsonProperty("platformMaxVersion")]
        public string PlatformMaxVersion { get; set; }

        [JsonProperty("customHandleUpgrade")]
        public bool CustomHandleUpgrade { get; set; }

        [JsonProperty("instancePackageId")]
        public string InstancePackageId { get; set; }

        [JsonProperty("state")]
        public InstancePackageState State { get; set; }

        [JsonProperty("catalogVisibility")]
        public CatalogVisibility CatalogVisibility { get; set; }

        [JsonProperty("applicationVisibility")]
        public ApplicationVisibility ApplicationVisibility { get; set; }

        [JsonProperty("lastError")]
        public ErrorDetails LastError { get; set; }

        [JsonProperty("startDateUtc")]
        public string StartDateUtc { get; set; }

        [JsonProperty("endDateUtc")]
        public string EndDateUtc { get; set; }

        [JsonProperty("supportedCountries")]
        public string[] SupportedCountries { get; set; }
    }

    public enum InstancePackageState
    {
        None,
        Installed,
        Uninstalled,
        InstallRequested,
        UninstallRequested,
        InstallFailed,
        UninstallFailed,
        Installing,
        Uninstalling,
        InstallScheduled,
        InstallRetrying,
        TemplateInstalled
    }

    public enum appInstallStateInput
    {
        All,
        Installed,
        NotInstalled
    }

    public class InstancePackage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("applicationDescription")]
        public string ApplicationDescription { get; set; }

        [JsonProperty("singlePageApplicationUrl")]
        public string SinglePageApplicationUrl { get; set; }

        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        [JsonProperty("packageUniqueName")]
        public string PackageUniqueName { get; set; }

        [JsonProperty("packageVersion")]
        public string PackageVersion { get; set; }

        [JsonProperty("localizedDescription")]
        public string LocalizedDescription { get; set; }

        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }

        [JsonProperty("learnMoreUrl")]
        public string LearnMoreUrl { get; set; }

        [JsonProperty("termsOfServiceBlobUris")]
        public string[] TermsOfServiceBlobUris { get; set; }

        [JsonProperty("applicationVisibility")]
        public ApplicationVisibility ApplicationVisibility { get; set; }

        [JsonProperty("lastOperation")]
        public InstancePackageOperation LastOperation { get; set; }

        [JsonProperty("customHandleUpgrade")]
        public bool CustomHandleUpgrade { get; set; }
    }

    public class InstancePackageOperation
    {
        [JsonProperty("state")]
        public InstancePackageState State { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("errorDetails")]
        public ErrorDetails ErrorDetails { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("instancePackageId")]
        public string InstancePackageId { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }
    }

    public class InstancePackageOperationPollingResponse
    {
        [JsonProperty("status")]
        public InstancePackageOperationStatus Status { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastActionDateTime")]
        public string LastActionDateTime { get; set; }

        [JsonProperty("error")]
        public ErrorDetails Error { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }
    }

    public enum InstancePackageOperationStatus
    {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        Canceled
    }

    public class RoleAssignmentResponse
    {
        [JsonProperty("value")]
        public RoleAssignmentResponseValueTypeItem[] Value { get; set; }
    }

    public class RoleAssignmentResponseValueTypeItem
    {
        [JsonProperty("roleAssignmentId")]
        public string RoleAssignmentId { get; set; }

        [JsonProperty("principalObjectId")]
        public string PrincipalObjectId { get; set; }

        [JsonProperty("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("principalType")]
        public string PrincipalType { get; set; }

        [JsonProperty("createdByPrincipalType")]
        public string CreatedByPrincipalType { get; set; }

        [JsonProperty("createdByPrincipalObjectId")]
        public string CreatedByPrincipalObjectId { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }
    }

    public class RoleDefinitionResponse
    {
        [JsonProperty("value")]
        public RoleDefinitionResponseValueTypeItem[] Value { get; set; }
    }

    public class RoleDefinitionResponseValueTypeItem
    {
        [JsonProperty("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        [JsonProperty("roleDefinitionName")]
        public string RoleDefinitionName { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }
    }

    public class ListConnectionsResponse
    {
        [JsonProperty("value")]
        public Connection[] Value { get; set; }
    }

    public class Connection
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public ConnectionPropertiesType Properties { get; set; }
    }

    public class ConnectionPropertiesType
    {
        [JsonProperty("apiId")]
        public string ApiId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("iconUri")]
        public string IconUri { get; set; }

        [JsonProperty("statuses")]
        public ConnectionStatus[] Statuses { get; set; }

        [JsonProperty("connectionParametersSet")]
        public ConnectionPropertiesTypeConnectionParametersSetType ConnectionParametersSet { get; set; }

        [JsonProperty("connectionParameters")]
        public JToken ConnectionParameters { get; set; }

        [JsonProperty("keywordsRemaining")]
        public int KeywordsRemaining { get; set; }

        [JsonProperty("isSsoConnection")]
        public bool IsSsoConnection { get; set; }

        [JsonProperty("createdBy")]
        public ConnectionCreatedBy CreatedBy { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("testLinks")]
        public ConnectionPropertiesTypeTestLinksTypeItem[] TestLinks { get; set; }

        [JsonProperty("environment")]
        public ConnectionPropertiesTypeEnvironmentType Environment { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("allowSharing")]
        public bool AllowSharing { get; set; }
    }

    public class ConnectionStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("error")]
        public ConnectionStatusErrorType Error { get; set; }
    }

    public class ConnectionStatusErrorType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ConnectionPropertiesTypeConnectionParametersSetType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public JToken Values { get; set; }
    }

    public class ConnectionCreatedBy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class ConnectionPropertiesTypeTestLinksTypeItem
    {
        [JsonProperty("requestUri")]
        public string RequestUri { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class ConnectionPropertiesTypeEnvironmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListConnectorsResponse
    {
        [JsonProperty("value")]
        public GetConnectorByIdResponse[] Value { get; set; }
    }

    public class GetConnectorByIdResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public GetConnectorByIdResponsePropertiesType Properties { get; set; }
    }

    public class GetConnectorByIdResponsePropertiesType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("iconUri")]
        public string IconUri { get; set; }

        [JsonProperty("iconBrandColor")]
        public string IconBrandColor { get; set; }

        [JsonProperty("apiEnvironment")]
        public string ApiEnvironment { get; set; }

        [JsonProperty("isCustomApi")]
        public bool IsCustomApi { get; set; }

        [JsonProperty("blobUrisAreProxied")]
        public bool BlobUrisAreProxied { get; set; }

        [JsonProperty("runtimeUrls")]
        public string[] RuntimeUrls { get; set; }

        [JsonProperty("primaryRuntimeUrl")]
        public string PrimaryRuntimeUrl { get; set; }

        [JsonProperty("doNotUseApiHubNetRuntimeUrl")]
        public string DoNotUseApiHubNetRuntimeUrl { get; set; }

        [JsonProperty("metadata")]
        public GetConnectorByIdResponsePropertiesTypeMetadataType Metadata { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("interfaces")]
        public JToken Interfaces { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("changedTime")]
        public string ChangedTime { get; set; }

        [JsonProperty("releaseTag")]
        public string ReleaseTag { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("rateLimit")]
        public int RateLimit { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }
    }

    public class GetConnectorByIdResponsePropertiesTypeMetadataType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("allowSharing")]
        public bool AllowSharing { get; set; }

        [JsonProperty("useNewApimVersion")]
        public string UseNewApimVersion { get; set; }

        [JsonProperty("version")]
        public GetConnectorByIdResponsePropertiesTypeMetadataTypeVersionType Version { get; set; }
    }

    public class GetConnectorByIdResponsePropertiesTypeMetadataTypeVersionType
    {
        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }
    }

    public class BotQuarantineStatus
    {
        [JsonProperty("isBotQuarantined")]
        public bool IsBotQuarantined { get; set; }

        [JsonProperty("lastUpdateTimeUtc")]
        public string LastUpdateTimeUtc { get; set; }
    }

    public class ConnectorConsentBypassResponse
    {
        [JsonProperty("adminConsentBypass")]
        public bool AdminConsentBypass { get; set; }
    }

    public class TestRunCollection
    {
        [JsonProperty("value")]
        public TestRun[] Value { get; set; }
    }

    public class TestRun
    {
        [JsonProperty("cdsBotId")]
        public string CdsBotId { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mcsConnectionId")]
        public string McsConnectionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("state")]
        public EvaluationRunState State { get; set; }

        [JsonProperty("testCasesResults")]
        public TestCaseResult[] TestCasesResults { get; set; }

        [JsonProperty("testSetId")]
        public string TestSetId { get; set; }

        [JsonProperty("totalTestCases")]
        public int TotalTestCases { get; set; }
    }

    public enum EvaluationRunState
    {
        Abandoned,
        Cancelled,
        Completed,
        Deleted,
        Failed,
        InProgress,
        Queued,
        Unknown
    }

    public class TestCaseResult
    {
        [JsonProperty("metricsResults")]
        public Metric[] MetricsResults { get; set; }

        [JsonProperty("state")]
        public TestCaseState State { get; set; }

        [JsonProperty("testCaseId")]
        public string TestCaseId { get; set; }
    }

    public class Metric
    {
        [JsonProperty("result")]
        public MetricResult Result { get; set; }

        [JsonProperty("type")]
        public MetricType Type { get; set; }
    }

    public class MetricResult
    {
        [JsonProperty("aiResultReason")]
        public string AiResultReason { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("errorReason")]
        public MetricErrorReason ErrorReason { get; set; }

        [JsonProperty("status")]
        public MetricStatus Status { get; set; }
    }

    public enum MetricErrorReason
    {
        AgentResponseIsNullOrEmpty,
        EmptyOrInvalidModelResponse,
        ExpectedInvocationStepsAreNullOrEmpty,
        ExpectedKeywordsAreNullOrEmpty,
        ExpectedOutputIsNullOrEmpty,
        GraderCreationFailed,
        InputOutputCountMismatch,
        IntentMatchInvalidMatchType,
        ModelLabelGraderInvalidLabel,
        QueryIsNullOrEmpty,
        RequestTokenLimitExceeded,
        RetrievedKnowledgeSourcesTextsAreEmpty,
        RetrievedKnowledgeTokenLimitExceeded,
        UnexpectedInternalError
    }

    public enum MetricStatus
    {
        Error,
        Fail,
        Pass,
        Unknown
    }

    public enum MetricType
    {
        AllKeywordMatch,
        AnyKeywordMatch,
        CapabilityUse,
        CompareMeaning,
        CustomLabels,
        ExactMatch,
        GeneralQuality,
        TextSimilarity,
        Unknown
    }

    public enum TestCaseState
    {
        Cancelled,
        Completed,
        Error,
        Running,
        Unknown
    }

    public class TestSetCollection
    {
        [JsonProperty("value")]
        public TestSet[] Value { get; set; }
    }

    public class TestSet
    {
        [JsonProperty("auditInfo")]
        public AuditInfo AuditInfo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public StateCode State { get; set; }

        [JsonProperty("totalTestCases")]
        public int TotalTestCases { get; set; }
    }

    public class AuditInfo
    {
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdTimeUtc")]
        public string CreatedTimeUtc { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedTimeUtc")]
        public string ModifiedTimeUtc { get; set; }
    }

    public enum StateCode
    {
        Active,
        Inactive,
        Unknown
    }

    public class RunStatusResponse
    {
        [JsonProperty("callbackUri")]
        public string CallbackUri { get; set; }

        [JsonProperty("executionState")]
        public ExecutionState ExecutionState { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("runId")]
        public string RunId { get; set; }

        [JsonProperty("state")]
        public EvaluationRunState State { get; set; }

        [JsonProperty("testCasesProcessed")]
        public int TestCasesProcessed { get; set; }

        [JsonProperty("totalTestCases")]
        public int TotalTestCases { get; set; }
    }

    public enum ExecutionState
    {
        Abandoned,
        Cancelled,
        Completed,
        CreatingRunContent,
        Deleted,
        EvaluatingRun,
        Failed,
        Initializing,
        ProcessingRunContent,
        Queued,
        Unknown
    }

    public class ToolsConnections
    {
        [JsonProperty("botId")]
        public string BotId { get; set; }

        [JsonProperty("botSchemaName")]
        public string BotSchemaName { get; set; }

        [JsonProperty("connections")]
        public MakerEvaluationConnection[] Connections { get; set; }
    }

    public class MakerEvaluationConnection
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("connectionReferenceName")]
        public string ConnectionReferenceName { get; set; }

        [JsonProperty("connectorId")]
        public string ConnectorId { get; set; }
    }

    public class ProblemDetails
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("instance")]
        public string Instance { get; set; }

        [JsonProperty("extensions")]
        public JToken Extensions { get; set; }
    }

    public class EnvironmentList
    {
        [JsonProperty("value")]
        public EnvironmentResponse[] Value { get; set; }

        [JsonProperty("@odata.nextlink")]
        public string Nextlink { get; set; }
    }

    public class EnvironmentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("environmentGroupId")]
        public string EnvironmentGroupId { get; set; }

        [JsonProperty("azureRegion")]
        public string AzureRegion { get; set; }

        [JsonProperty("clusterCategory")]
        public string ClusterCategory { get; set; }

        [JsonProperty("createdBy")]
        public EnvironmentPrincipal CreatedBy { get; set; }

        [JsonProperty("createdFor")]
        public EnvironmentPrincipal CreatedFor { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("dataverseId")]
        public string DataverseId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("securityGroupId")]
        public string SecurityGroupId { get; set; }

        [JsonProperty("connectedGroupId")]
        public string ConnectedGroupId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("adminMode")]
        public string AdminMode { get; set; }

        [JsonProperty("backgroundOperationsState")]
        public string BackgroundOperationsState { get; set; }

        [JsonProperty("protectionLevel")]
        public string ProtectionLevel { get; set; }

        [JsonProperty("retentionDetails")]
        public EnvironmentResponseRetentionDetailsType RetentionDetails { get; set; }

        [JsonProperty("finOpsMetadata")]
        public FinOpsMetadata FinOpsMetadata { get; set; }

        [JsonProperty("enterprisePolicies")]
        public EnterprisePolicies EnterprisePolicies { get; set; }

        [JsonProperty("scenarioName")]
        public string ScenarioName { get; set; }
    }

    public class EnvironmentPrincipal
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class EnvironmentResponseRetentionDetailsType
    {
        [JsonProperty("retentionPeriod")]
        public string RetentionPeriod { get; set; }

        [JsonProperty("availableFromDateTime")]
        public string AvailableFromDateTime { get; set; }
    }

    public class FinOpsMetadata
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EnterprisePolicies
    {
        [JsonProperty("encryption")]
        public EnterprisePolicyLink Encryption { get; set; }

        [JsonProperty("identity")]
        public EnterprisePolicyLink Identity { get; set; }

        [JsonProperty("networkInjection")]
        public EnterprisePolicyLink NetworkInjection { get; set; }

        [JsonProperty("privateEndpoint")]
        public EnterprisePolicyLink PrivateEndpoint { get; set; }
    }

    public class EnterprisePolicyLink
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("status")]
        public EnterprisePolicyLinkStatus Status { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public enum EnterprisePolicyLinkStatus
    {
        Linking,
        Unlinking,
        Linked,
        Failed,
        LinkingOnline,
        UnlinkingOnline
    }

    public class Policy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("ruleSets")]
        public RuleSet[] RuleSets { get; set; }

        [JsonProperty("ruleSetCount")]
        public int RuleSetCount { get; set; }
    }

    public class RuleSet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("inputs")]
        public JToken Inputs { get; set; }
    }

    public class ListPolicyResponse
    {
        [JsonProperty("value")]
        public Policy[] Value { get; set; }
    }

    public class RuleAssignment
    {
        [JsonProperty("ruleSetCount")]
        public int RuleSetCount { get; set; }

        [JsonProperty("policyId")]
        public string PolicyId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("resourceType")]
        public RuleAssignmentResourceTypeType ResourceType { get; set; }
    }

    public enum RuleAssignmentResourceTypeType
    {
        NotSpecified,
        EnvironmentGroup,
        Environment
    }

    public class RuleAssignmentsResponse
    {
        [JsonProperty("value")]
        public RuleAssignment[] Value { get; set; }
    }

    public class CrossTenantConnectionReportsResponseWithOdataContinuation
    {
        [JsonProperty("value")]
        public CrossTenantConnectionReport[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class CrossTenantConnectionReport
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("reportId")]
        public string ReportId { get; set; }

        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("status")]
        public CrossTenantConnectionReportStatusType Status { get; set; }

        [JsonProperty("connections")]
        public CrossTenantConnection[] Connections { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public enum CrossTenantConnectionReportStatusType
    {
        Received,
        InProgress,
        Completed,
        Failed
    }

    public class CrossTenantConnection
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("connectionType")]
        public CrossTenantConnectionConnectionTypeType ConnectionType { get; set; }
    }

    public enum CrossTenantConnectionConnectionTypeType
    {
        Inbound,
        Outbound
    }

    public class TenantEntitlementResponseModel
    {
        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("productCategories")]
        public ProductCategory[] ProductCategories { get; set; }

        [JsonProperty("entitlement")]
        public TenantEntitlementDetailServiceModel Entitlement { get; set; }
    }

    public enum ProductCategory
    {
        NotSpecified,
        D365Apps,
        Dataverse,
        Fno,
        PowerApps,
        PowerAutomate,
        PowerPages,
        PowerVirtualAgent,
        CopilotStudio,
        PowerPlatform,
        Project,
        W365,
        D365CustomerInsights,
        D365ContactCenter,
        Teams,
        CloudForSustainability,
        CoWork,
        M365,
        ManagedApps
    }

    public class TenantEntitlementDetailServiceModel
    {
        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }

        [JsonProperty("capacity")]
        public CapacityEntitlementModel Capacity { get; set; }

        [JsonProperty("payGo")]
        public CatalogPayGoEntitlementModel PayGo { get; set; }

        [JsonProperty("licensedPolicy")]
        public LicensedPolicyModel LicensedPolicy { get; set; }
    }

    public enum EntitlementUnit
    {
        NotSpecified,
        MB,
        Count,
        Hour
    }

    public class CapacityEntitlementModel
    {
        [JsonProperty("entitled")]
        public EntitlementEntitledModel Entitled { get; set; }

        [JsonProperty("consumed")]
        public EntitlementConsumedModel Consumed { get; set; }

        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }

        [JsonProperty("allocated")]
        public EntitlementAllocationModelV2 Allocated { get; set; }

        [JsonProperty("availableQuantity")]
        public double AvailableQuantity { get; set; }

        [JsonProperty("status")]
        public OverageStatus Status { get; set; }

        [JsonProperty("licenses")]
        public CapacityLicenseModel[] Licenses { get; set; }
    }

    public class EntitlementEntitledModel
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class EntitlementConsumedModel
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("consumptionType")]
        public EntitlementConsumptionType ConsumptionType { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("writeOff")]
        public double WriteOff { get; set; }
    }

    public enum EntitlementConsumptionType
    {
        NotSpecified,
        Snapshot,
        MonthToDate
    }

    public class EntitlementAllocationModelV2
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("autoAllocated")]
        public double AutoAllocated { get; set; }
    }

    public enum OverageStatus
    {
        NotSpecified,
        WithinCapacity,
        Overage,
        CoveredOverage
    }

    public class CapacityLicenseModel
    {
        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("licenseQuantity")]
        public int LicenseQuantity { get; set; }

        [JsonProperty("entitled")]
        public EntitlementEntitledModel Entitled { get; set; }

        [JsonProperty("licenseTier")]
        public LicenseTier LicenseTier { get; set; }

        [JsonProperty("licenseStatus")]
        public string LicenseStatus { get; set; }

        [JsonProperty("nextLifecycleStatus")]
        public string NextLifecycleStatus { get; set; }

        [JsonProperty("nextLifecycleDate")]
        public string NextLifecycleDate { get; set; }

        [JsonProperty("licenseId")]
        public string LicenseId { get; set; }

        [JsonProperty("licenseSource")]
        public LicenseSource LicenseSource { get; set; }

        [JsonProperty("isUnlimited")]
        public bool IsUnlimited { get; set; }
    }

    public enum LicenseTier
    {
        NotSpecified,
        Paid,
        Trial,
        Internal
    }

    public enum LicenseSource
    {
        NotSpecified,
        CommerceService,
        AppSource,
        Internal,
        PayAsYouGo
    }

    public class CatalogPayGoEntitlementModel
    {
        [JsonProperty("entitled")]
        public EntitlementEntitledModel Entitled { get; set; }

        [JsonProperty("consumed")]
        public EntitlementConsumedModel Consumed { get; set; }
    }

    public class LicensedPolicyModel
    {
        [JsonProperty("entitled")]
        public bool Entitled { get; set; }
    }

    public class EnvironmentEntitlementSnapshotResponseModelPagedResponse
    {
        [JsonProperty("value")]
        public EnvironmentEntitlementSnapshotResponseModel[] Value { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("continuationtoken")]
        public string Continuationtoken { get; set; }
    }

    public class EnvironmentEntitlementSnapshotResponseModel
    {
        [JsonProperty("resources")]
        public EnvironmentResourceEntitlementSnapshotResponseModel[] Resources { get; set; }
    }

    public class EnvironmentResourceEntitlementSnapshotResponseModel
    {
        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("consumed")]
        public double Consumed { get; set; }

        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }

        [JsonProperty("lastRefreshedDate")]
        public string LastRefreshedDate { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class TenantEntitlementLicenseTrendResponseModelPagedResponse
    {
        [JsonProperty("value")]
        public TenantEntitlementLicenseTrendResponseModel[] Value { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("continuationtoken")]
        public string Continuationtoken { get; set; }
    }

    public class TenantEntitlementLicenseTrendResponseModel
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("licenseModelType")]
        public LicenseModelType LicenseModelType { get; set; }

        [JsonProperty("licenses")]
        public TenantEntitlementLicenseModel[] Licenses { get; set; }
    }

    public enum LicenseModelType
    {
        NotSpecified,
        Usl,
        Capacity,
        PayGo,
        TenantLicense
    }

    public class TenantEntitlementLicenseModel
    {
        [JsonProperty("licenseId")]
        public string LicenseId { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("licenseQuantity")]
        public int LicenseQuantity { get; set; }

        [JsonProperty("entitled")]
        public double Entitled { get; set; }

        [JsonProperty("licenseTier")]
        public LicenseTier LicenseTier { get; set; }

        [JsonProperty("licenseStatus")]
        public string LicenseStatus { get; set; }
    }

    public class TenantEnvironmentResourceSnapshotResponseModelPagedResponse
    {
        [JsonProperty("value")]
        public TenantEnvironmentResourceSnapshotResponseModel[] Value { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("continuationtoken")]
        public string Continuationtoken { get; set; }
    }

    public class TenantEnvironmentResourceSnapshotResponseModel
    {
        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("consumed")]
        public double Consumed { get; set; }

        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }

        [JsonProperty("lastRefreshedDate")]
        public string LastRefreshedDate { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }
    }

    public class TenantUserResponseModelPagedResponse
    {
        [JsonProperty("value")]
        public TenantUserResponseModel[] Value { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("continuationtoken")]
        public string Continuationtoken { get; set; }
    }

    public class TenantUserResponseModel
    {
        [JsonProperty("users")]
        public TenantCapacityConsumptionUserSnapshotResponseModel[] Users { get; set; }
    }

    public class TenantCapacityConsumptionUserSnapshotResponseModel
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("consumed")]
        public double Consumed { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }
    }

    public class ResourceThresholdModel
    {
        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("stopResource")]
        public bool StopResource { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("stopIfOverCapacity")]
        public bool StopIfOverCapacity { get; set; }

        [JsonProperty("notifyIfOverCapacity")]
        public bool NotifyIfOverCapacity { get; set; }

        [JsonProperty("notificationThreshold")]
        public int NotificationThreshold { get; set; }

        [JsonProperty("resourceConsumption")]
        public double ResourceConsumption { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }
    }

    public class TenantResourceResponseModelPagedResponse
    {
        [JsonProperty("value")]
        public TenantResourceResponseModel[] Value { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("continuationtoken")]
        public string Continuationtoken { get; set; }
    }

    public class TenantResourceResponseModel
    {
        [JsonProperty("resources")]
        public TenantCapacityConsumptionSnapshotResponseModel[] Resources { get; set; }
    }

    public class TenantCapacityConsumptionSnapshotResponseModel
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("consumed")]
        public double Consumed { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }
    }

    public class EnvironmentEntitlementResponseModel
    {
        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("productCategories")]
        public ProductCategory[] ProductCategories { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("environmentType")]
        public EnvironmentType EnvironmentType { get; set; }

        [JsonProperty("environmentName")]
        public string EnvironmentName { get; set; }

        [JsonProperty("isManagedEnvironment")]
        public bool IsManagedEnvironment { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("scenario")]
        public EnvironmentScenario Scenario { get; set; }

        [JsonProperty("disasterRecoveryState")]
        public EnvironmentDisasterRecoveryState DisasterRecoveryState { get; set; }

        [JsonProperty("disasterRecoveryLocation")]
        public EnvironmentDisasterRecoveryLocation DisasterRecoveryLocation { get; set; }

        [JsonProperty("entitlement")]
        public EnvironmentEntitlementDetailServiceModel Entitlement { get; set; }

        [JsonProperty("addons")]
        public EnvironmentAddonResponseModel[] Addons { get; set; }

        [JsonProperty("permissions")]
        public EnvironmentPermissionResponseModel[] Permissions { get; set; }

        [JsonProperty("cleanupOpportunitySize")]
        public int CleanupOpportunitySize { get; set; }

        [JsonProperty("recommendationCount")]
        public int RecommendationCount { get; set; }
    }

    public enum EnvironmentType
    {
        None,
        Production,
        Sandbox,
        Support,
        Preview,
        Trial,
        Default,
        Developer,
        SubscriptionBasedTrial,
        Teams,
        NotSpecified,
        Platform
    }

    public enum EnvironmentScenario
    {
        None,
        OfficeAi,
        M365CopilotChat,
        M365CompliantContainer
    }

    public enum EnvironmentDisasterRecoveryState
    {
        NotSpecified,
        Enabled,
        Ready,
        Disabled,
        Unavailable
    }

    public enum EnvironmentDisasterRecoveryLocation
    {
        NotSpecified,
        NearCopy,
        FarCopy
    }

    public class EnvironmentEntitlementDetailServiceModel
    {
        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }

        [JsonProperty("capacity")]
        public EnvironmentCapacityEntitlementModel Capacity { get; set; }

        [JsonProperty("payGo")]
        public CatalogPayGoEntitlementModel PayGo { get; set; }
    }

    public class EnvironmentCapacityEntitlementModel
    {
        [JsonProperty("allocated")]
        public EntitlementAllocationModelV2 Allocated { get; set; }

        [JsonProperty("enforcementRules")]
        public AllocationEnforcementRule[] EnforcementRules { get; set; }

        [JsonProperty("consumed")]
        public EntitlementConsumedModel Consumed { get; set; }

        [JsonProperty("availableQuantity")]
        public double AvailableQuantity { get; set; }

        [JsonProperty("status")]
        public OverageStatus Status { get; set; }
    }

    public class AllocationEnforcementRule
    {
        [JsonProperty("ruleType")]
        public AllocationEnforcementRuleTypes RuleType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public enum AllocationEnforcementRuleTypes
    {
        NotSpecified,
        Alert,
        PayGo,
        TenantPool,
        Deny,
        Throttle
    }

    public class EnvironmentAddonResponseModel
    {
        [JsonProperty("addonType")]
        public CurrencyType AddonType { get; set; }

        [JsonProperty("allocated")]
        public double Allocated { get; set; }

        [JsonProperty("addonUnit")]
        public string AddonUnit { get; set; }
    }

    public enum CurrencyType
    {
        None,
        AppPass,
        AI,
        PortalLogins,
        PortalViews,
        PerFlowPlan,
        ApiCalls,
        VAConversations,
        AppPassForTeams,
        PAUnattendedRPA,
        PowerPagesAuthenticated,
        PowerPagesAnonymous,
        PAHostedRPA,
        Invoice,
        PortalAddOns,
        PowerAutomatePerProcess,
        MCSSessions,
        MCSMessages,
        SCMessages,
        ProcessMiningDataStorage,
        W365APAYGO,
        [EnumMember(Value = "Internal_AI_BC")]
        InternalAIBC,
        [EnumMember(Value = "Internal_ISV_DataverseUserSync")]
        InternalISVDataverseUserSync,
        [EnumMember(Value = "Internal_AI_TemporaryCapacity")]
        InternalAITemporaryCapacity,
        [EnumMember(Value = "Internal_OmniChannelRecordRouting")]
        InternalOmniChannelRecordRouting,
        [EnumMember(Value = "Internal_OmniChannelVoice")]
        InternalOmniChannelVoice,
        [EnumMember(Value = "Internal_OmniChannelLiveChat")]
        InternalOmniChannelLiveChat,
        [EnumMember(Value = "Internal_OmniChannelDigitalMessaging")]
        InternalOmniChannelDigitalMessaging,
        [EnumMember(Value = "PowerPagesMigration_PortalAddOns_Authenticated")]
        PowerPagesMigrationPortalAddOnsAuthenticated,
        [EnumMember(Value = "PowerPagesMigration_PortalAddOns_Anonymous")]
        PowerPagesMigrationPortalAddOnsAnonymous,
        [EnumMember(Value = "PowerPagesMigration_PortalLogins")]
        PowerPagesMigrationPortalLogins,
        [EnumMember(Value = "PowerPagesMigration_PortalViews")]
        PowerPagesMigrationPortalViews,
        MCSMessagesStandard,
        MCSMessagesGenAI,
        MCSMessagesUnbillable,
        TenantM365Copilot
    }

    public class EnvironmentPermissionResponseModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class AllocationByEnvironmentModel
    {
        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("currencyAllocations")]
        public CurrencyAllocationModel[] CurrencyAllocations { get; set; }
    }

    public class CurrencyAllocationModel
    {
        [JsonProperty("currencyType")]
        public ExternalCurrencyType CurrencyType { get; set; }

        [JsonProperty("allocated")]
        public int Allocated { get; set; }

        [JsonProperty("autoAllocated")]
        public double AutoAllocated { get; set; }

        [JsonProperty("enforcementRules")]
        public EnforcementRule[] EnforcementRules { get; set; }
    }

    public enum ExternalCurrencyType
    {
        AI,
        AppPass,
        AppPassForTeams,
        Invoice,
        MCSSessions,
        MCSMessages,
        PAHostedRPA,
        PAUnattendedRPA,
        PerFlowPlan,
        PortalAddOns,
        PortalLogins,
        PortalViews,
        PowerPagesAuthenticated,
        PowerPagesAnonymous,
        PowerAutomatePerProcess,
        ProcessMiningDataStorage,
        SCMessages,
        VAConversations
    }

    public class EnforcementRule
    {
        [JsonProperty("ruleType")]
        public EnforcementRuleTypes RuleType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public enum EnforcementRuleTypes
    {
        Alert,
        PayGo,
        TenantPool,
        Deny
    }

    public class BillingPolicyResponseModelResponseWithOdataContinuation
    {
        [JsonProperty("value")]
        public BillingPolicyResponseModel[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class BillingPolicyResponseModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public BillingPolicyStatus Status { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("billingInstrument")]
        public BillingInstrumentModel BillingInstrument { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public LicensingPrincipal CreatedBy { get; set; }

        [JsonProperty("lastModifiedOn")]
        public string LastModifiedOn { get; set; }

        [JsonProperty("lastModifiedBy")]
        public LicensingPrincipal LastModifiedBy { get; set; }
    }

    public enum BillingPolicyStatus
    {
        Enabled,
        Disabled
    }

    public class BillingInstrumentModel
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("resourceGroup")]
        public string ResourceGroup { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class LicensingPrincipal
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public PrincipalType Type { get; set; }
    }

    public enum PrincipalType
    {
        None,
        Application,
        User,
        DelegatedAdmin
    }

    public enum bodystatusInput
    {
        Enabled,
        Disabled
    }

    public class BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation
    {
        [JsonProperty("value")]
        public BillingPolicyEnvironmentResponseModelV1[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class BillingPolicyEnvironmentResponseModelV1
    {
        [JsonProperty("billingPolicyId")]
        public string BillingPolicyId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }
    }

    public class AllocationsByEnvironmentResponseModelV1
    {
        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("currencyAllocations")]
        public CurrencyAllocationResponseModelV1[] CurrencyAllocations { get; set; }
    }

    public class CurrencyAllocationResponseModelV1
    {
        [JsonProperty("currencyType")]
        public ExternalCurrencyType CurrencyType { get; set; }

        [JsonProperty("allocated")]
        public int Allocated { get; set; }
    }

    public class CurrencyAllocationRequestModelV1
    {
        [JsonProperty("currencyType")]
        public ExternalCurrencyType CurrencyType { get; set; }

        [JsonProperty("allocated")]
        public int Allocated { get; set; }
    }

    public class IsvContractResponseModelResponseWithOdataContinuation
    {
        [JsonProperty("value")]
        public IsvContractResponseModel[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class IsvContractResponseModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public BillingPolicyStatus Status { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("consumer")]
        public ConsumerIdentityModel Consumer { get; set; }

        [JsonProperty("conditions")]
        public BillingPolicyConditionsModel Conditions { get; set; }

        [JsonProperty("billingInstrument")]
        public BillingInstrumentModel BillingInstrument { get; set; }

        [JsonProperty("powerAutomatePolicy")]
        public PowerAutomatePolicyModel PowerAutomatePolicy { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public LicensingPrincipal CreatedBy { get; set; }

        [JsonProperty("lastModifiedOn")]
        public string LastModifiedOn { get; set; }

        [JsonProperty("lastModifiedBy")]
        public LicensingPrincipal LastModifiedBy { get; set; }
    }

    public class ConsumerIdentityModel
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class BillingPolicyConditionsModel
    {
        [JsonProperty("apiFilter")]
        public BillingPolicyConditionsApiFilterModel ApiFilter { get; set; }
    }

    public class BillingPolicyConditionsApiFilterModel
    {
        [JsonProperty("allowOtherPremiumConnectors")]
        public bool AllowOtherPremiumConnectors { get; set; }

        [JsonProperty("requiredApis")]
        public BillingPolicyConditionsApiModel[] RequiredApis { get; set; }
    }

    public class BillingPolicyConditionsApiModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PowerAutomatePolicyModel
    {
        [JsonProperty("cloudFlowRunsPayAsYouGoState")]
        public PayAsYouGoState CloudFlowRunsPayAsYouGoState { get; set; }

        [JsonProperty("desktopFlowUnattendedRunsPayAsYouGoState")]
        public PayAsYouGoState DesktopFlowUnattendedRunsPayAsYouGoState { get; set; }

        [JsonProperty("desktopFlowAttendedRunsPayAsYouGoState")]
        public PayAsYouGoState DesktopFlowAttendedRunsPayAsYouGoState { get; set; }
    }

    public enum PayAsYouGoState
    {
        Enabled,
        Disabled
    }

    public enum bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput
    {
        Enabled,
        Disabled
    }

    public enum bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput
    {
        Enabled,
        Disabled
    }

    public enum bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput
    {
        Enabled,
        Disabled
    }

    public class TenantCapacityDetailsModel
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("licenseModelType")]
        public LicenseModel LicenseModelType { get; set; }

        [JsonProperty("capacitySummary")]
        public CapacitySummary CapacitySummary { get; set; }

        [JsonProperty("tenantCapacities")]
        public TenantCapacityAndConsumptionModel[] TenantCapacities { get; set; }

        [JsonProperty("legacyModelCapacity")]
        public LegacyCapacityModel LegacyModelCapacity { get; set; }

        [JsonProperty("temporaryLicenseInfo")]
        public TemporaryLicenseInfo TemporaryLicenseInfo { get; set; }
    }

    public enum LicenseModel
    {
        None,
        Legacy,
        StorageDriven
    }

    public class CapacitySummary
    {
        [JsonProperty("status")]
        public CapacityAvailabilityStatus Status { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("statusMessageCode")]
        public CapacityStatusMessageCode StatusMessageCode { get; set; }

        [JsonProperty("finOpsStatus")]
        public CapacityAvailabilityStatus FinOpsStatus { get; set; }

        [JsonProperty("finOpsStatusMessage")]
        public string FinOpsStatusMessage { get; set; }

        [JsonProperty("finOpsStatusMessageCode")]
        public CapacityStatusMessageCode FinOpsStatusMessageCode { get; set; }
    }

    public enum CapacityAvailabilityStatus
    {
        None,
        Available,
        AvailableByOverflow,
        NotAvailable
    }

    public enum CapacityStatusMessageCode
    {
        AllCapacityAvailable,
        DBCapacityOver,
        LogOverDBCover,
        LogCapacityOver,
        FileOverDBCover,
        FileOverLogCover,
        FileOverDBAndLogCover,
        FileCapacityOver,
        DBAndLogOver,
        DBAndFileOver,
        LogAndFileOverDBCover,
        LogAndFileOver,
        AllCapacityOver,
        LegacyCapacityAvailable,
        LegacyCapacityOver,
        FinOpsAllCapacityAvailable,
        FinOpsNotAvailable,
        FinOpsAllCapacityOver,
        FinOpsDBCapacityOver,
        FinOpsFileCapacityOver,
        LegacyCapacityMoreThanEightyFive,
        DBCapacityMoreThanEightyFive,
        LogCapacityMoreThanEightyFive,
        FileCapacityMoreThanEightyFive,
        DBAndFileCapacityMoreThanEightyFive,
        DBAndLogCapacityMoreThanEightyFive,
        LogAndFileCapacityMoreThanEightyFive,
        AllCapacityMoreThanEightyFive
    }

    public class TenantCapacityAndConsumptionModel
    {
        [JsonProperty("capacityType")]
        public CapacityType CapacityType { get; set; }

        [JsonProperty("capacityUnits")]
        public CapacityUnits CapacityUnits { get; set; }

        [JsonProperty("totalCapacity")]
        public double TotalCapacity { get; set; }

        [JsonProperty("maxCapacity")]
        public double MaxCapacity { get; set; }

        [JsonProperty("consumption")]
        public ConsumptionModel Consumption { get; set; }

        [JsonProperty("status")]
        public CapacityAvailabilityStatus Status { get; set; }

        [JsonProperty("overflowCapacity")]
        public OverflowCapacityModel[] OverflowCapacity { get; set; }

        [JsonProperty("capacityEntitlements")]
        public TenantCapacityEntitlementModel[] CapacityEntitlements { get; set; }
    }

    public enum CapacityType
    {
        None,
        Database,
        File,
        Log,
        TrialDatabase,
        TrialFile,
        TrialLog,
        SubscriptionTrialDatabase,
        SubscriptionTrialFile,
        SubscriptionTrialLog,
        M365Database,
        M365EnvironmentCount,
        SubscriptionTrialEnvironmentCount,
        CapacityPass,
        ApiCallCount,
        FinOpsDatabase,
        FinOpsFile,
        PIProcess
    }

    public enum CapacityUnits
    {
        None,
        Unit,
        MB
    }

    public class ConsumptionModel
    {
        [JsonProperty("actual")]
        public double Actual { get; set; }

        [JsonProperty("rated")]
        public double Rated { get; set; }

        [JsonProperty("actualUpdatedOn")]
        public string ActualUpdatedOn { get; set; }

        [JsonProperty("ratedUpdatedOn")]
        public string RatedUpdatedOn { get; set; }
    }

    public class OverflowCapacityModel
    {
        [JsonProperty("capacityType")]
        public CapacityType CapacityType { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class TenantCapacityEntitlementModel
    {
        [JsonProperty("capacityType")]
        public CapacityType CapacityType { get; set; }

        [JsonProperty("capacitySubType")]
        public CapacityEntitlementType CapacitySubType { get; set; }

        [JsonProperty("totalCapacity")]
        public double TotalCapacity { get; set; }

        [JsonProperty("maxNextLifecycleDate")]
        public string MaxNextLifecycleDate { get; set; }

        [JsonProperty("licenses")]
        public LicenseDetailsModel[] Licenses { get; set; }
    }

    public enum CapacityEntitlementType
    {
        None,
        DatabaseBase,
        DatabaseIncremental,
        DatabaseAddOn,
        FileBase,
        FileIncremental,
        FileAddOn,
        LogBase,
        LogAddOn,
        SubscriptionTrialDatabaseBase,
        SubscriptionTrialFileBase,
        SubscriptionTrialLogBase,
        SubscriptionTrialEnvironmentCountBase,
        SubscriptionTrialEnvironmentCountIncremental,
        TrialDatabaseBase,
        TrialFileBase,
        TrialLogBase,
        M365DatabaseBase,
        M365DatabaseIncremental,
        M365EnvironmentCountBase,
        M365EnvironmentCountIncremental,
        ApiCallCountIncremental,
        ApiCallCountBase,
        CapacityPassBase,
        FinOpsDatabaseBase,
        FinOpsDatabaseIncremental,
        FinOpsFileBase,
        FinOpsFileIncremental
    }

    public class LicenseDetailsModel
    {
        [JsonProperty("entitlementCode")]
        public string EntitlementCode { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isTemporaryLicense")]
        public bool IsTemporaryLicense { get; set; }

        [JsonProperty("temporaryLicenseExpiryDate")]
        public string TemporaryLicenseExpiryDate { get; set; }

        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("paid")]
        public LicenseQuantity Paid { get; set; }

        [JsonProperty("trial")]
        public LicenseQuantity Trial { get; set; }

        [JsonProperty("totalCapacity")]
        public double TotalCapacity { get; set; }

        [JsonProperty("nextLifecycleDate")]
        public string NextLifecycleDate { get; set; }

        [JsonProperty("capabilityStatus")]
        public string CapabilityStatus { get; set; }
    }

    public class LicenseQuantity
    {
        [JsonProperty("enabled")]
        public int Enabled { get; set; }

        [JsonProperty("warning")]
        public int Warning { get; set; }

        [JsonProperty("suspended")]
        public int Suspended { get; set; }
    }

    public class LegacyCapacityModel
    {
        [JsonProperty("totalCapacity")]
        public double TotalCapacity { get; set; }

        [JsonProperty("totalConsumption")]
        public double TotalConsumption { get; set; }

        [JsonProperty("capacityUnits")]
        public CapacityUnits CapacityUnits { get; set; }
    }

    public class TemporaryLicenseInfo
    {
        [JsonProperty("hasTemporaryLicense")]
        public bool HasTemporaryLicense { get; set; }

        [JsonProperty("temporaryLicenseExpiryDate")]
        public string TemporaryLicenseExpiryDate { get; set; }
    }

    public class CurrencyReportV2
    {
        [JsonProperty("currencyType")]
        public ExternalCurrencyType CurrencyType { get; set; }

        [JsonProperty("purchased")]
        public int Purchased { get; set; }

        [JsonProperty("allocated")]
        public int Allocated { get; set; }

        [JsonProperty("consumed")]
        public CurrencyConsumption Consumed { get; set; }
    }

    public class CurrencyConsumption
    {
        [JsonProperty("unitsConsumed")]
        public int UnitsConsumed { get; set; }

        [JsonProperty("lastUpdatedDay")]
        public string LastUpdatedDay { get; set; }
    }

    public class PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceRecord
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("records")]
        public UserPerFlowCapacitySourceRecord[] Records { get; set; }
    }

    public class UserPerFlowCapacitySourceRecord
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("flowContext")]
        public string FlowContext { get; set; }

        [JsonProperty("flowLicenseCategorization")]
        public string FlowLicenseCategorization { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("consumptionUnits")]
        public int ConsumptionUnits { get; set; }

        [JsonProperty("consumptionDate")]
        public string ConsumptionDate { get; set; }
    }

    public class PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("records")]
        public UserPerFlowCapacitySourceFlowContextRecord[] Records { get; set; }
    }

    public class UserPerFlowCapacitySourceFlowContextRecord
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("flowContext")]
        public string FlowContext { get; set; }

        [JsonProperty("flowLicenseCategorization")]
        public string FlowLicenseCategorization { get; set; }

        [JsonProperty("consumptionDate")]
        public string ConsumptionDate { get; set; }

        [JsonProperty("totalConsumption")]
        public int TotalConsumption { get; set; }

        [JsonProperty("flowId")]
        public string FlowId { get; set; }
    }

    public class UserPerFlowCapacitySourceTenantContextSummaryRecord
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("flowContext")]
        public string FlowContext { get; set; }

        [JsonProperty("countOfUsersInCompliance")]
        public int CountOfUsersInCompliance { get; set; }

        [JsonProperty("countOfUsersExceedingCapacity")]
        public int CountOfUsersExceedingCapacity { get; set; }

        [JsonProperty("countOfUsersWithoutALicense")]
        public int CountOfUsersWithoutALicense { get; set; }

        [JsonProperty("countOfUsersWithoutPremiumLicenseUsingPremiumFeatures")]
        public int CountOfUsersWithoutPremiumLicenseUsingPremiumFeatures { get; set; }
    }

    public class PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("records")]
        public UserPerFlowCapacitySourceUserContextRecord[] Records { get; set; }
    }

    public class UserPerFlowCapacitySourceUserContextRecord
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("flowContext")]
        public string FlowContext { get; set; }

        [JsonProperty("flowLicenseCategorization")]
        public string FlowLicenseCategorization { get; set; }

        [JsonProperty("consumptionDate")]
        public string ConsumptionDate { get; set; }

        [JsonProperty("totalConsumption")]
        public int TotalConsumption { get; set; }

        [JsonProperty("totalCapacity")]
        public int TotalCapacity { get; set; }

        [JsonProperty("totalFlows")]
        public int TotalFlows { get; set; }
    }

    public class ResourceArrayPowerApp
    {
        [JsonProperty("value")]
        public PowerApp[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class PowerApp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public PowerAppPropertiesType Properties { get; set; }

        [JsonProperty("tags")]
        public PowerAppTagsType Tags { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PowerAppPropertiesType
    {
        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("createdByClientVersion")]
        public PowerAppPropertiesTypeCreatedByClientVersionType CreatedByClientVersion { get; set; }

        [JsonProperty("minClientVersion")]
        public PowerAppPropertiesTypeMinClientVersionType MinClientVersion { get; set; }

        [JsonProperty("owner")]
        public PowerAppPropertiesTypeOwnerType Owner { get; set; }

        [JsonProperty("createdBy")]
        public PowerAppPropertiesTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public PowerAppPropertiesTypeLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("backgroundImageUri")]
        public string BackgroundImageUri { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("appUris")]
        public PowerAppPropertiesTypeAppUrisType AppUris { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("sharedGroupsCount")]
        public int SharedGroupsCount { get; set; }

        [JsonProperty("sharedUsersCount")]
        public int SharedUsersCount { get; set; }

        [JsonProperty("appOpenProtocolUri")]
        public string AppOpenProtocolUri { get; set; }

        [JsonProperty("appOpenUri")]
        public string AppOpenUri { get; set; }

        [JsonProperty("userAppMetadata")]
        public PowerAppPropertiesTypeUserAppMetadataType UserAppMetadata { get; set; }

        [JsonProperty("isFeaturedApp")]
        public bool IsFeaturedApp { get; set; }

        [JsonProperty("bypassConsent")]
        public bool BypassConsent { get; set; }

        [JsonProperty("isHeroApp")]
        public bool IsHeroApp { get; set; }

        [JsonProperty("environment")]
        public PowerAppPropertiesTypeEnvironmentType Environment { get; set; }

        [JsonProperty("connectionReferences")]
        public ConnectionReference[] ConnectionReferences { get; set; }
    }

    public class PowerAppPropertiesTypeCreatedByClientVersionType
    {
        [JsonProperty("major")]
        public int Major { get; set; }

        [JsonProperty("minor")]
        public int Minor { get; set; }

        [JsonProperty("build")]
        public int Build { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("majorRevision")]
        public int MajorRevision { get; set; }

        [JsonProperty("minorRevision")]
        public int MinorRevision { get; set; }
    }

    public class PowerAppPropertiesTypeMinClientVersionType
    {
        [JsonProperty("major")]
        public int Major { get; set; }

        [JsonProperty("minor")]
        public int Minor { get; set; }

        [JsonProperty("build")]
        public int Build { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("majorRevision")]
        public int MajorRevision { get; set; }

        [JsonProperty("minorRevision")]
        public int MinorRevision { get; set; }
    }

    public class PowerAppPropertiesTypeOwnerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class PowerAppPropertiesTypeCreatedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class PowerAppPropertiesTypeLastModifiedByType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class PowerAppPropertiesTypeAppUrisType
    {
        [JsonProperty("documentUri")]
        public PowerAppPropertiesTypeAppUrisTypeDocumentUriType DocumentUri { get; set; }

        [JsonProperty("imageUris")]
        public string[] ImageUris { get; set; }
    }

    public class PowerAppPropertiesTypeAppUrisTypeDocumentUriType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("readonlyValue")]
        public string ReadonlyValue { get; set; }
    }

    public class PowerAppPropertiesTypeUserAppMetadataType
    {
        [JsonProperty("favorite")]
        public string Favorite { get; set; }

        [JsonProperty("includeInAppsList")]
        public bool IncludeInAppsList { get; set; }
    }

    public class PowerAppPropertiesTypeEnvironmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConnectionReference
    {
        [JsonProperty("id")]
        public string ConnectorId { get; set; }

        [JsonProperty("displayName")]
        public string ConnectorDisplayName { get; set; }

        [JsonProperty("iconUri")]
        public string IconURI { get; set; }

        [JsonProperty("dataSources")]
        public string[] DataSources { get; set; }

        [JsonProperty("dependencies")]
        public string[] Dependencies { get; set; }

        [JsonProperty("dependents")]
        public string[] Dependents { get; set; }

        [JsonProperty("isOnPremiseConnection")]
        public bool IsOnPremiseConnection { get; set; }

        [JsonProperty("bypassConsent")]
        public bool BypassConsent { get; set; }

        [JsonProperty("apiTier")]
        public string APITier { get; set; }

        [JsonProperty("isCustomApiConnection")]
        public bool CustomAPIFlag { get; set; }

        [JsonProperty("runtimePolicyName")]
        public string RuntimePolicyName { get; set; }

        [JsonProperty("executionRestrictions")]
        public JToken ExecutionRestrictions { get; set; }

        [JsonProperty("sharedConnectionId")]
        public string SharedConnectionID { get; set; }
    }

    public class PowerAppTagsType
    {
        [JsonProperty("primaryDeviceWidth")]
        public string PrimaryDeviceWidth { get; set; }

        [JsonProperty("primaryDeviceHeight")]
        public string PrimaryDeviceHeight { get; set; }

        [JsonProperty("sienaVersion")]
        public string SienaVersion { get; set; }

        [JsonProperty("deviceCapabilities")]
        public string DeviceCapabilities { get; set; }

        [JsonProperty("supportsPortrait")]
        public string SupportsPortrait { get; set; }

        [JsonProperty("supportsLandscape")]
        public string SupportsLandscape { get; set; }

        [JsonProperty("primaryFormFactor")]
        public string PrimaryFormFactor { get; set; }

        [JsonProperty("publisherVersion")]
        public string PublisherVersion { get; set; }

        [JsonProperty("minimumRequiredApiVersion")]
        public string MinimumRequiredApiVersion { get; set; }
    }

    public class ResourceQueryResponse
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("resultTruncated")]
        public ResourceQueryResponseResultTruncatedType ResultTruncated { get; set; }

        [JsonProperty("skipToken")]
        public string SkipToken { get; set; }

        [JsonProperty("data")]
        public ResourceItem[] Data { get; set; }
    }

    public enum ResourceQueryResponseResultTruncatedType
    {
        _0 = 0,
        _1 = 1
    }

    public class ResourceItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("resourceGroup")]
        public string ResourceGroup { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("sku")]
        public JToken Sku { get; set; }

        [JsonProperty("plan")]
        public JToken Plan { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("identity")]
        public JToken Identity { get; set; }

        [JsonProperty("zones")]
        public JToken Zones { get; set; }

        [JsonProperty("extendedLocation")]
        public JToken ExtendedLocation { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("environmentId1")]
        public string EnvironmentId1 { get; set; }

        [JsonProperty("environmentName")]
        public string EnvironmentName { get; set; }

        [JsonProperty("environmentRegion")]
        public string EnvironmentRegion { get; set; }

        [JsonProperty("environmentType")]
        public string EnvironmentType { get; set; }

        [JsonProperty("isManagedEnvironment")]
        public bool IsManagedEnvironment { get; set; }
    }

    public class Clause
    {
        [JsonProperty("$type")]
        public ClauseTypeType Type { get; set; }
    }

    public enum ClauseTypeType
    {
        [EnumMember(Value = "where")]
        Where,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "take")]
        Take,
        [EnumMember(Value = "orderby")]
        Orderby,
        [EnumMember(Value = "distinct")]
        Distinct,
        [EnumMember(Value = "count")]
        Count,
        [EnumMember(Value = "summarize")]
        Summarize,
        [EnumMember(Value = "extend")]
        Extend,
        [EnumMember(Value = "join")]
        Join
    }

    public class DsrFlowRunsResponse
    {
        [JsonProperty("flowId")]
        public string FlowId { get; set; }

        [JsonProperty("value")]
        public DsrFlowRunData[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DsrFlowRunData
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }

        [JsonProperty("actionEvents")]
        public ActionEvent[] ActionEvents { get; set; }
    }

    public class ActionEvent
    {
        [JsonProperty("type")]
        public ActionEventType Type { get; set; }
    }

    public enum ActionEventType
    {
        NotSpecified,
        Trigger,
        Thought,
        ConnectorActionStart,
        ConnectorActionEnd,
        ActionValidationResponse,
        ActionSuggestionRequest,
        Output
    }

    public class DsrPagedResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DsrConversationTranscriptsResponse
    {
        [JsonProperty("value")]
        public ConversationTranscript[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ConversationTranscript
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("serviceRequestCorrelationId")]
        public string ServiceRequestCorrelationId { get; set; }

        [JsonProperty("requestCorrelationId")]
        public string RequestCorrelationId { get; set; }

        [JsonProperty("systemMetadata")]
        public ConversationTranscriptSystemMetadata SystemMetadata { get; set; }

        [JsonProperty("request")]
        public ConversationTranscriptRequest Request { get; set; }

        [JsonProperty("response")]
        public ConversationTranscriptResponse Response { get; set; }
    }

    public class ConversationTranscriptSystemMetadata
    {
        [JsonProperty("scenario")]
        public ConversationTranscriptScenario Scenario { get; set; }
    }

    public enum ConversationTranscriptScenario
    {
        WorkflowsAgentRuntime,
        WorkflowsAgentAuthoring
    }

    public class ConversationTranscriptRequest
    {
        [JsonProperty("messages")]
        public ConversationTranscriptMessage[] Messages { get; set; }

        [JsonProperty("tools")]
        public ConversationTranscriptTool[] Tools { get; set; }

        [JsonProperty("toolChoice")]
        public string ToolChoice { get; set; }
    }

    public class ConversationTranscriptMessage
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isCustomerContent")]
        public bool IsCustomerContent { get; set; }

        [JsonProperty("toolCalls")]
        public ConversationTranscriptToolCall[] ToolCalls { get; set; }

        [JsonProperty("toolCallId")]
        public string ToolCallId { get; set; }
    }

    public class ConversationTranscriptToolCall
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("function")]
        public ConversationTranscriptFunction Function { get; set; }
    }

    public class ConversationTranscriptFunction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("arguments")]
        public string Arguments { get; set; }
    }

    public class ConversationTranscriptTool
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("function")]
        public ConversationTranscriptToolFunction Function { get; set; }
    }

    public class ConversationTranscriptToolFunction
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }
    }

    public class ConversationTranscriptResponse
    {
        [JsonProperty("completions")]
        public ConversationTranscriptCompletion[] Completions { get; set; }

        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }
    }

    public class ConversationTranscriptCompletion
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("finishReason")]
        public string FinishReason { get; set; }

        [JsonProperty("toolCalls")]
        public ConversationTranscriptToolCall[] ToolCalls { get; set; }
    }

    public class MCPQueryResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class AllocationAvailabilityResponseModel
    {
        [JsonProperty("scope")]
        public ScopeModel Scope { get; set; }

        [JsonProperty("entitlementAllocationsAvailable")]
        public EntitlementAllocationAvailabilityModel[] EntitlementAllocationsAvailable { get; set; }
    }

    public class ScopeModel
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("environmentGroupId")]
        public string EnvironmentGroupId { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userGroupId")]
        public string UserGroupId { get; set; }
    }

    public class EntitlementAllocationAvailabilityModel
    {
        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("availableQuantity")]
        public double AvailableQuantity { get; set; }

        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }
    }

    public class FinOpsLicenseSummaryV2Response
    {
        [JsonProperty("lastReportRefreshTime")]
        public string LastReportRefreshTime { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("allUsersCount")]
        public int AllUsersCount { get; set; }

        [JsonProperty("usersWithoutLicensesCount")]
        public int UsersWithoutLicensesCount { get; set; }

        [JsonProperty("underLicensedUsersCount")]
        public int UnderLicensedUsersCount { get; set; }

        [JsonProperty("overLicensedUsersCount")]
        public int OverLicensedUsersCount { get; set; }

        [JsonProperty("licensesConsumption")]
        public FinOpsLicensesConsumption LicensesConsumption { get; set; }
    }

    public class FinOpsLicensesConsumption
    {
        [JsonProperty("supplyChainManagement")]
        public FinOpsProductLicenseConsumption SupplyChainManagement { get; set; }

        [JsonProperty("finance")]
        public FinOpsProductLicenseConsumption Finance { get; set; }

        [JsonProperty("commerce")]
        public FinOpsProductLicenseConsumption Commerce { get; set; }

        [JsonProperty("projectOperations")]
        public FinOpsProductLicenseConsumption ProjectOperations { get; set; }

        [JsonProperty("humanResources")]
        public FinOpsProductLicenseConsumption HumanResources { get; set; }

        [JsonProperty("operations")]
        public FinOpsOperationsLicenseConsumption Operations { get; set; }

        [JsonProperty("activity")]
        public FinOpsSimpleLicenseConsumption Activity { get; set; }

        [JsonProperty("teamMember")]
        public FinOpsSimpleLicenseConsumption TeamMember { get; set; }

        [JsonProperty("selfService")]
        public FinOpsSimpleLicenseConsumption SelfService { get; set; }

        [JsonProperty("supplyChainManagementOrFinanceOrCommerce")]
        public FinOpsSupplyChainManagementOrFinanceOrCommerceLicenseConsumption SupplyChainManagementOrFinanceOrCommerce { get; set; }

        [JsonProperty("projectOperationsOrHumanResources")]
        public FinOpsProjectOperationsOrHumanResourcesLicenseConsumption ProjectOperationsOrHumanResources { get; set; }
    }

    public class FinOpsProductLicenseConsumption
    {
        [JsonProperty("licenseRequirements")]
        public FinOpsLicenseRequirements LicenseRequirements { get; set; }

        [JsonProperty("baseConsumption")]
        public FinOpsBaseLicenseConsumption BaseConsumption { get; set; }

        [JsonProperty("attachConsumption")]
        public FinOpsAttachLicenseConsumption AttachConsumption { get; set; }
    }

    public class FinOpsLicenseRequirements
    {
        [JsonProperty("usersNeedingLicenseCount")]
        public int UsersNeedingLicenseCount { get; set; }
    }

    public class FinOpsBaseLicenseConsumption
    {
        [JsonProperty("purchasedBaseUnassignedCount")]
        public int PurchasedBaseUnassignedCount { get; set; }

        [JsonProperty("purchasedBaseAssignedCount")]
        public int PurchasedBaseAssignedCount { get; set; }
    }

    public class FinOpsAttachLicenseConsumption
    {
        [JsonProperty("purchasedAttachUnassignedCount")]
        public int PurchasedAttachUnassignedCount { get; set; }

        [JsonProperty("purchasedAttachAssignedCount")]
        public int PurchasedAttachAssignedCount { get; set; }
    }

    public class FinOpsOperationsLicenseConsumption
    {
        [JsonProperty("licenseRequirements")]
        public FinOpsLicenseRequirements LicenseRequirements { get; set; }

        [JsonProperty("baseConsumption")]
        public FinOpsBaseLicenseConsumption BaseConsumption { get; set; }
    }

    public class FinOpsSimpleLicenseConsumption
    {
        [JsonProperty("licenseRequirements")]
        public FinOpsLicenseRequirements LicenseRequirements { get; set; }

        [JsonProperty("baseConsumption")]
        public FinOpsBaseLicenseConsumption BaseConsumption { get; set; }
    }

    public class FinOpsSupplyChainManagementOrFinanceOrCommerceLicenseConsumption
    {
        [JsonProperty("licenseRequirements")]
        public FinOpsLicenseRequirements LicenseRequirements { get; set; }

        [JsonProperty("supplyChainManagementConsumption")]
        public FinOpsBaseLicenseConsumption SupplyChainManagementConsumption { get; set; }

        [JsonProperty("financeConsumption")]
        public FinOpsBaseLicenseConsumption FinanceConsumption { get; set; }

        [JsonProperty("commerceConsumption")]
        public FinOpsBaseLicenseConsumption CommerceConsumption { get; set; }
    }

    public class FinOpsProjectOperationsOrHumanResourcesLicenseConsumption
    {
        [JsonProperty("licenseRequirements")]
        public FinOpsLicenseRequirements LicenseRequirements { get; set; }

        [JsonProperty("projectOperationsConsumption")]
        public FinOpsBaseLicenseConsumption ProjectOperationsConsumption { get; set; }

        [JsonProperty("humanResourcesConsumption")]
        public FinOpsBaseLicenseConsumption HumanResourcesConsumption { get; set; }
    }

    public class EntitlementReservedResponseModel
    {
        [JsonProperty("reserved")]
        public ReservedModel Reserved { get; set; }

        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }
    }

    public class ReservedModel
    {
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }
    }

    public class NeptuneOperationResult
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("isErrorResult")]
        public bool IsErrorResult { get; set; }
    }

    public class EntitlementAllocationModel
    {
        [JsonProperty("allocation")]
        public AllocationModel Allocation { get; set; }

        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("enforcementRules")]
        public AllocationEnforcementRule[] EnforcementRules { get; set; }
    }

    public class AllocationModel
    {
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("autoAllocated")]
        public double AutoAllocated { get; set; }

        [JsonProperty("unit")]
        public EntitlementUnit Unit { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powerplatformadminv2;

    public partial class WorkflowManagedActions
    {
        public Powerplatformadminv2Actions Powerplatformadminv2(string connectionId) => new Powerplatformadminv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Powerplatformadminv2Triggers Powerplatformadminv2(string connectionId) => new Powerplatformadminv2Triggers(connectionId);
    }
}