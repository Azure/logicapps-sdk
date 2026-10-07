//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerplatformadminv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Powerplatformadminv2Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteRecommendationAction))]
        public IBodyWorkflowAction<AdvisorActionResponse> ExecuteRecommendationAction([WorkflowExpression] Func<string> bodyrecommendationName, [WorkflowExpression] Func<object> bodyparameters, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AdvisorActionResponse> __BuildExecuteRecommendationAction(WorkflowExpression<string> bodyrecommendationName, WorkflowExpression<object> bodyparameters, WorkflowExpression<string> actionName, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(bodyrecommendationName, nameof(bodyrecommendationName), required: true);
            WorkflowExpression.Validate(bodyparameters, nameof(bodyparameters), required: true);
            WorkflowExpression.Validate(actionName, nameof(actionName), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/analytics/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["scenario"] = ExpressionConverter.ConvertO(bodyrecommendationName);
                bodypropCount++;
                body["actionParameters"] = ExpressionConverter.ConvertO(bodyparameters);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AdvisorActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecommendations))]
        public IBodyWorkflowAction<AdvisorRecommendationIEnumerableResponseWithContinuation> GetRecommendations([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AdvisorRecommendationIEnumerableResponseWithContinuation> __BuildGetRecommendations(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorRecommendationIEnumerableResponseWithContinuation>(() =>
            {
                var apiCallPath = "/analytics/advisorRecommendations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<AdvisorRecommendationIEnumerableResponseWithContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecommendationResources))]
        public IBodyWorkflowAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation> GetRecommendationResources([WorkflowExpression] Func<string> scenario, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation> __BuildGetRecommendationResources(WorkflowExpression<string> scenario, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(scenario, nameof(scenario), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/analytics/advisorRecommendations/{0}/resources", ExpressionConverter.ConvertWithUrlEncoding(scenario, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetTenantApplicationPackage))]
        public IBodyWorkflowAction<TenantApplicationPackageContinuationResponse> GetTenantApplicationPackage([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TenantApplicationPackageContinuationResponse> __BuildGetTenantApplicationPackage(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantApplicationPackageContinuationResponse>(() =>
            {
                var apiCallPath = "/appmanagement/applicationPackages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<TenantApplicationPackageContinuationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvironmentApplicationPackage))]
        public IBodyWorkflowAction<ApplicationPackageContinuationResponse> GetEnvironmentApplicationPackage([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<appInstallStateInput> appInstallState = null, [WorkflowExpression] Func<string> lcid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApplicationPackageContinuationResponse> __BuildGetEnvironmentApplicationPackage(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<appInstallStateInput> appInstallState = null, WorkflowExpression<string> lcid = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(appInstallState, nameof(appInstallState), required: false);
            WorkflowExpression.Validate(lcid, nameof(lcid), required: false);
            return new DeferredBodyAction<ApplicationPackageContinuationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/appmanagement/environments/{0}/applicationPackages", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (appInstallState != null)
                    callPayload.Queries["appInstallState"] = ExpressionConverter.Convert(appInstallState);
                if (lcid != null)
                    callPayload.Queries["lcid"] = ExpressionConverter.Convert(lcid);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ApplicationPackageContinuationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildInstallApplicationPackage))]
        public IBodyWorkflowAction<InstancePackage> InstallApplicationPackage([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> uniqueName, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodypayloadValue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InstancePackage> __BuildInstallApplicationPackage(WorkflowExpression<string> environmentId, WorkflowExpression<string> uniqueName, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodypayloadValue = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(uniqueName, nameof(uniqueName), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodypayloadValue, nameof(bodypayloadValue), required: false);
            return new DeferredBodyAction<InstancePackage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/appmanagement/environments/{0}/applicationPackages/{1}/install", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(uniqueName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypayloadValue != null)
                {
                    body["payloadValue"] = ExpressionConverter.ConvertO(bodypayloadValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InstancePackage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetApplicationPackageInstallStatus))]
        public IBodyWorkflowAction<InstancePackageOperationPollingResponse> GetApplicationPackageInstallStatus([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> operationId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InstancePackageOperationPollingResponse> __BuildGetApplicationPackageInstallStatus(WorkflowExpression<string> environmentId, WorkflowExpression<string> operationId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(operationId, nameof(operationId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<InstancePackageOperationPollingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/appmanagement/environments/{0}/operations/{1}", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(operationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<InstancePackageOperationPollingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRoleAssignments))]
        public IBodyWorkflowAction<RoleAssignmentResponse> ListRoleAssignments([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RoleAssignmentResponse> __BuildListRoleAssignments(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleAssignmentResponse>(() =>
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRoleAssignment))]
        public IBodyWorkflowAction<RoleAssignmentResponse> CreateRoleAssignment([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyprincipalObjectId = null, [WorkflowExpression] Func<string> bodyroleDefinitionId = null, [WorkflowExpression] Func<string> bodyscope = null, [WorkflowExpression] Func<string> bodyprincipalType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RoleAssignmentResponse> __BuildCreateRoleAssignment(WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyprincipalObjectId = null, WorkflowExpression<string> bodyroleDefinitionId = null, WorkflowExpression<string> bodyscope = null, WorkflowExpression<string> bodyprincipalType = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            WorkflowExpression.Validate(bodyroleDefinitionId, nameof(bodyroleDefinitionId), required: false);
            WorkflowExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            WorkflowExpression.Validate(bodyprincipalType, nameof(bodyprincipalType), required: false);
            return new DeferredBodyAction<RoleAssignmentResponse>(() =>
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = ExpressionConverter.ConvertO(bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (bodyroleDefinitionId != null)
                {
                    body["roleDefinitionId"] = ExpressionConverter.ConvertO(bodyroleDefinitionId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["scope"] = ExpressionConverter.ConvertO(bodyscope);
                    bodypropCount++;
                }

                if (bodyprincipalType != null)
                {
                    body["principalType"] = ExpressionConverter.ConvertO(bodyprincipalType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRoleAssignment))]
        public IWorkflowAction DeleteRoleAssignment([WorkflowExpression] Func<string> roleAssignmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRoleAssignment(WorkflowExpression<string> roleAssignmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(roleAssignmentId, nameof(roleAssignmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/authorization/roleAssignments/{0}", ExpressionConverter.ConvertWithUrlEncoding(roleAssignmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRoleDefinitions))]
        public IBodyWorkflowAction<RoleDefinitionResponse> ListRoleDefinitions([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RoleDefinitionResponse> __BuildListRoleDefinitions(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleDefinitionResponse>(() =>
            {
                var apiCallPath = "/authorization/roleDefinitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<RoleDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListConnectors))]
        public IBodyWorkflowAction<ListConnectorsResponse> ListConnectors([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListConnectorsResponse> __BuildListConnectors(WorkflowExpression<string> environmentId, WorkflowExpression<string> filter, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListConnectorsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/connectivity/environments/{0}/connectors", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ListConnectorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetConnectorById))]
        public IBodyWorkflowAction<GetConnectorByIdResponse> GetConnectorById([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> connectorId, [WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConnectorByIdResponse> __BuildGetConnectorById(WorkflowExpression<string> environmentId, WorkflowExpression<string> connectorId, WorkflowExpression<string> filter, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(connectorId, nameof(connectorId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<GetConnectorByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/connectivity/environments/{0}/connectors/{1}", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(connectorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<GetConnectorByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetBotQuarantineStatus))]
        public IBodyWorkflowAction<BotQuarantineStatus> GetBotQuarantineStatus([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotQuarantineStatus> __BuildGetBotQuarantineStatus(WorkflowExpression<string> environmentId, WorkflowExpression<string> botId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildSetBotAsQuarantined))]
        public IBodyWorkflowAction<BotQuarantineStatus> SetBotAsQuarantined([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotQuarantineStatus> __BuildSetBotAsQuarantined(WorkflowExpression<string> environmentId, WorkflowExpression<string> botId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsQuarantined", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildSetBotAsUnquarantined))]
        public IBodyWorkflowAction<BotQuarantineStatus> SetBotAsUnquarantined([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BotQuarantineStatus> __BuildSetBotAsUnquarantined(WorkflowExpression<string> environmentId, WorkflowExpression<string> botId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsUnquarantined", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEnvironmentBackup))]
        public IBodyWorkflowAction<ValidationResponse> DeleteEnvironmentBackup([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> backupId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildDeleteEnvironmentBackup(WorkflowExpression<string> environmentId, WorkflowExpression<string> backupId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(backupId, nameof(backupId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/backups/{1}", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(backupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDisableEnvironment))]
        public IBodyWorkflowAction<ValidationResponse> DisableEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null, [WorkflowExpression] Func<string> bodyreason = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildDisableEnvironment(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null, WorkflowExpression<string> bodyreason = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/Disable", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDisableDisasterRecovery))]
        public IBodyWorkflowAction<OperationExecutionResult> DisableDisasterRecovery([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationExecutionResult> __BuildDisableDisasterRecovery(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/disableDisasterRecovery", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildPerformDRDrill))]
        public IBodyWorkflowAction<OperationExecutionResult> PerformDRDrill([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationExecutionResult> __BuildPerformDRDrill(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/disasterRecoveryDrill", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildEnableEnvironment))]
        public IBodyWorkflowAction<ValidationResponse> EnableEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null, [WorkflowExpression] Func<string> bodyreason = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildEnableEnvironment(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null, WorkflowExpression<string> bodyreason = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/Enable", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildEnableDisasterRecovery))]
        public IBodyWorkflowAction<OperationExecutionResult> EnableDisasterRecovery([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationExecutionResult> __BuildEnableDisasterRecovery(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/enableDisasterRecovery", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildPerformForceFailover))]
        public IBodyWorkflowAction<OperationExecutionResult> PerformForceFailover([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodylastSyncTime, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationExecutionResult> __BuildPerformForceFailover(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodylastSyncTime, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodylastSyncTime, nameof(bodylastSyncTime), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/forceFailover", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["lastSyncTime"] = ExpressionConverter.ConvertO(bodylastSyncTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildRecoverEnvironment))]
        public IBodyWorkflowAction<ValidationResponse> RecoverEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildRecoverEnvironment(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/recover", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildCopyEnvironment))]
        public IBodyWorkflowAction<ValidationResponse> CopyEnvironment([WorkflowExpression] Func<string> targetEnvironmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodysourceEnvironmentId, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null, [WorkflowExpression] Func<bodycopyTypeInput> bodycopyType = null, [WorkflowExpression] Func<string> bodycopyOptionsenvironmentNameToOverride = null, [WorkflowExpression] Func<string> bodycopyOptionssecurityGroupIdToOverride = null, [WorkflowExpression] Func<bool> bodycopyOptionsskipAuditData = null, [WorkflowExpression] Func<bool> bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildCopyEnvironment(WorkflowExpression<string> targetEnvironmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodysourceEnvironmentId, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null, WorkflowExpression<bodycopyTypeInput> bodycopyType = null, WorkflowExpression<string> bodycopyOptionsenvironmentNameToOverride = null, WorkflowExpression<string> bodycopyOptionssecurityGroupIdToOverride = null, WorkflowExpression<bool> bodycopyOptionsskipAuditData = null, WorkflowExpression<bool> bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations = null)
        {
            WorkflowExpression.Validate(targetEnvironmentId, nameof(targetEnvironmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodysourceEnvironmentId, nameof(bodysourceEnvironmentId), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            WorkflowExpression.Validate(bodycopyType, nameof(bodycopyType), required: false);
            WorkflowExpression.Validate(bodycopyOptionsenvironmentNameToOverride, nameof(bodycopyOptionsenvironmentNameToOverride), required: false);
            WorkflowExpression.Validate(bodycopyOptionssecurityGroupIdToOverride, nameof(bodycopyOptionssecurityGroupIdToOverride), required: false);
            WorkflowExpression.Validate(bodycopyOptionsskipAuditData, nameof(bodycopyOptionsskipAuditData), required: false);
            WorkflowExpression.Validate(bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations, nameof(bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(targetEnvironmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceEnvironmentId"] = ExpressionConverter.ConvertO(bodysourceEnvironmentId);
                if (bodycopyType != null)
                {
                    body["copyType"] = ExpressionConverter.ConvertO(bodycopyType);
                    bodypropCount++;
                }

                var copyOptionsObject = new JObject();
                var copyOptionsObjectpropCount = 0;
                if (bodycopyOptionsenvironmentNameToOverride != null)
                {
                    copyOptionsObject["environmentNameToOverride"] = ExpressionConverter.ConvertO(bodycopyOptionsenvironmentNameToOverride);
                    copyOptionsObjectpropCount++;
                }

                if (bodycopyOptionssecurityGroupIdToOverride != null)
                {
                    copyOptionsObject["securityGroupIdToOverride"] = ExpressionConverter.ConvertO(bodycopyOptionssecurityGroupIdToOverride);
                    copyOptionsObjectpropCount++;
                }

                if (bodycopyOptionsskipAuditData != null)
                {
                    copyOptionsObject["skipAuditData"] = ExpressionConverter.ConvertO(bodycopyOptionsskipAuditData);
                    copyOptionsObjectpropCount++;
                }

                if (bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations != null)
                {
                    copyOptionsObject["executeAdvancedCopyForFinanceAndOperations"] = ExpressionConverter.ConvertO(bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations);
                    copyOptionsObjectpropCount++;
                }

                if (copyOptionsObjectpropCount > 0)
                {
                    body["copyOptions"] = copyOptionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildRestoreEnvironment))]
        public IBodyWorkflowAction<ValidationResponse> RestoreEnvironment([WorkflowExpression] Func<string> targetEnvironmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyrestorePointDateTime, [WorkflowExpression] Func<string> bodysourceEnvironmentId, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null, [WorkflowExpression] Func<bool> bodyskipAuditData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildRestoreEnvironment(WorkflowExpression<string> targetEnvironmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyrestorePointDateTime, WorkflowExpression<string> bodysourceEnvironmentId, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null, WorkflowExpression<bool> bodyskipAuditData = null)
        {
            WorkflowExpression.Validate(targetEnvironmentId, nameof(targetEnvironmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyrestorePointDateTime, nameof(bodyrestorePointDateTime), required: true);
            WorkflowExpression.Validate(bodysourceEnvironmentId, nameof(bodysourceEnvironmentId), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            WorkflowExpression.Validate(bodyskipAuditData, nameof(bodyskipAuditData), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}/Restore", ExpressionConverter.ConvertWithUrlEncoding(targetEnvironmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["restorePointDateTime"] = ExpressionConverter.ConvertO(bodyrestorePointDateTime);
                if (bodyskipAuditData != null)
                {
                    body["skipAuditData"] = ExpressionConverter.ConvertO(bodyskipAuditData);
                    bodypropCount++;
                }

                bodypropCount++;
                body["sourceEnvironmentId"] = ExpressionConverter.ConvertO(bodysourceEnvironmentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvironmentGroupOperation))]
        public IBodyWorkflowAction<ProblemDetails> GetEnvironmentGroupOperation([WorkflowExpression] Func<string> operationId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetails> __BuildGetEnvironmentGroupOperation(WorkflowExpression<string> operationId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(operationId, nameof(operationId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroupOperations/{0}", ExpressionConverter.ConvertWithUrlEncoding(operationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEnvironmentGroup))]
        public IBodyWorkflowAction<ProblemDetails> DeleteEnvironmentGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetails> __BuildDeleteEnvironmentGroup(WorkflowExpression<string> groupId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildAddEnvironmentToGroup))]
        public IBodyWorkflowAction<ProblemDetails> AddEnvironmentToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetails> __BuildAddEnvironmentToGroup(WorkflowExpression<string> groupId, WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroups/{0}/addEnvironment/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveEnvironmentFromGroup))]
        public IBodyWorkflowAction<ProblemDetails> RemoveEnvironmentFromGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetails> __BuildRemoveEnvironmentFromGroup(WorkflowExpression<string> groupId, WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environmentGroups/{0}/removeEnvironment/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListEnvironmentsForUser))]
        public IBodyWorkflowAction<EnvironmentList> ListEnvironmentsForUser([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnvironmentList> __BuildListEnvironmentsForUser(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<EnvironmentList>(() =>
            {
                var apiCallPath = "/environmentmanagement/environments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<EnvironmentList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvironmentByIdForUser))]
        public IBodyWorkflowAction<EnvironmentResponse> GetEnvironmentByIdForUser([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnvironmentResponse> __BuildGetEnvironmentByIdForUser(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<EnvironmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<EnvironmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEnvironmentByID))]
        public IBodyWorkflowAction<ValidationResponse> DeleteEnvironmentByID([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> validateOnly = null, [WorkflowExpression] Func<string> validateProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidationResponse> __BuildDeleteEnvironmentByID(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<bool> validateOnly = null, WorkflowExpression<string> validateProperties = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(validateOnly, nameof(validateOnly), required: false);
            WorkflowExpression.Validate(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/environmentmanagement/environments/{0}", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(validateOnly);
                if (validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRuleBasedPolicy))]
        public IBodyWorkflowAction<Policy> CreateRuleBasedPolicy([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<RuleSet[]> bodyruleSets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Policy> __BuildCreateRuleBasedPolicy(WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyname = null, WorkflowExpression<RuleSet[]> bodyruleSets = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<Policy>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyruleSets != null)
                {
                    body["ruleSets"] = ExpressionConverter.ConvertO(bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Policy>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRuleBasedPolicies))]
        public IBodyWorkflowAction<ListPolicyResponse> ListRuleBasedPolicies([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPolicyResponse> __BuildListRuleBasedPolicies(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListPolicyResponse>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ListPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetRuleBasedPolicyByID))]
        public IBodyWorkflowAction<Policy> GetRuleBasedPolicyByID([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Policy> __BuildGetRuleBasedPolicyByID(WorkflowExpression<string> policyId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(policyId, nameof(policyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<Policy>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<Policy>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRuleBasedPolicyByID))]
        public IBodyWorkflowAction<RuleAssignment> UpdateRuleBasedPolicyByID([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<RuleSet[]> bodyruleSets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RuleAssignment> __BuildUpdateRuleBasedPolicyByID(WorkflowExpression<string> policyId, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyname = null, WorkflowExpression<RuleSet[]> bodyruleSets = null)
        {
            WorkflowExpression.Validate(policyId, nameof(policyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<RuleAssignment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyruleSets != null)
                {
                    body["ruleSets"] = ExpressionConverter.ConvertO(bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RuleAssignment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRuleAssignmentsByPolicyId))]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByPolicyId([WorkflowExpression] Func<string> policyId, [WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RuleAssignmentsResponse> __BuildListRuleAssignmentsByPolicyId(WorkflowExpression<string> policyId, WorkflowExpression<bool> includeRuleSetCounts, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(policyId, nameof(policyId), required: true);
            WorkflowExpression.Validate(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/{0}/assignments", ExpressionConverter.ConvertWithUrlEncoding(policyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRuleAssignments))]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignments([WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RuleAssignmentsResponse> __BuildListRuleAssignments(WorkflowExpression<bool> includeRuleSetCounts, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies/assignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRuleAssignmentsByEnvironmentGroupId))]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByEnvironmentGroupId([WorkflowExpression] Func<string> environmentGroupId, [WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RuleAssignmentsResponse> __BuildListRuleAssignmentsByEnvironmentGroupId(WorkflowExpression<string> environmentGroupId, WorkflowExpression<bool> includeRuleSetCounts, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentGroupId, nameof(environmentGroupId), required: true);
            WorkflowExpression.Validate(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/environmentGroups/{0}/assignments", ExpressionConverter.ConvertWithUrlEncoding(environmentGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListRuleAssignmentsByEnvironmentId))]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByEnvironmentId([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<bool> includeRuleSetCounts, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RuleAssignmentsResponse> __BuildListRuleAssignmentsByEnvironmentId(WorkflowExpression<string> environmentId, WorkflowExpression<bool> includeRuleSetCounts, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/governance/ruleBasedPolicies/environments/{0}/assignments", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListCrossTenantConnectionReports))]
        public IBodyWorkflowAction<CrossTenantConnectionReportsResponseWithOdataContinuation> ListCrossTenantConnectionReports([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CrossTenantConnectionReportsResponseWithOdataContinuation> __BuildListCrossTenantConnectionReports(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CrossTenantConnectionReportsResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = "/governance/crossTenantConnectionReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<CrossTenantConnectionReportsResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetCrossTenantConnectionReport))]
        public IBodyWorkflowAction<CrossTenantConnectionReport> GetCrossTenantConnectionReport([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CrossTenantConnectionReport> __BuildGetCrossTenantConnectionReport(WorkflowExpression<string> reportId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(reportId, nameof(reportId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CrossTenantConnectionReport>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/governance/crossTenantConnectionReports/{0}", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<CrossTenantConnectionReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildQueryResources))]
        public IBodyWorkflowAction<ResourceQueryResponse> QueryResources([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodytableName, [WorkflowExpression] Func<Clause[]> bodyclauses, [WorkflowExpression] Func<int> bodyoptionstop = null, [WorkflowExpression] Func<int> bodyoptionsskip = null, [WorkflowExpression] Func<string> bodyoptionsskipToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResourceQueryResponse> __BuildQueryResources(WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodytableName, WorkflowExpression<Clause[]> bodyclauses, WorkflowExpression<int> bodyoptionstop = null, WorkflowExpression<int> bodyoptionsskip = null, WorkflowExpression<string> bodyoptionsskipToken = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodytableName, nameof(bodytableName), required: true);
            WorkflowExpression.Validate(bodyclauses, nameof(bodyclauses), required: true);
            WorkflowExpression.Validate(bodyoptionstop, nameof(bodyoptionstop), required: false);
            WorkflowExpression.Validate(bodyoptionsskip, nameof(bodyoptionsskip), required: false);
            WorkflowExpression.Validate(bodyoptionsskipToken, nameof(bodyoptionsskipToken), required: false);
            return new DeferredBodyAction<ResourceQueryResponse>(() =>
            {
                var apiCallPath = "/resourcequery/resources/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TableName"] = ExpressionConverter.ConvertO(bodytableName);
                bodypropCount++;
                body["Clauses"] = ExpressionConverter.ConvertO(bodyclauses);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionstop != null)
                {
                    optionsObject["Top"] = ExpressionConverter.ConvertO(bodyoptionstop);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsskip != null)
                {
                    optionsObject["Skip"] = ExpressionConverter.ConvertO(bodyoptionsskip);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsskipToken != null)
                {
                    optionsObject["SkipToken"] = ExpressionConverter.ConvertO(bodyoptionsskipToken);
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

                return new ApiConnectionAction<ResourceQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListBillingPolicies))]
        public IBodyWorkflowAction<BillingPolicyResponseModelResponseWithOdataContinuation> ListBillingPolicies([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyResponseModelResponseWithOdataContinuation> __BuildListBillingPolicies(WorkflowExpression<string> apiVersion, WorkflowExpression<string> top = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModelResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModelResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBillingPolicy))]
        public IBodyWorkflowAction<BillingPolicyResponseModel> CreateBillingPolicy([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodybillingInstrumentsubscriptionId = null, [WorkflowExpression] Func<string> bodybillingInstrumentresourceGroup = null, [WorkflowExpression] Func<string> bodybillingInstrumentid = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyResponseModel> __BuildCreateBillingPolicy(WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodylocation = null, WorkflowExpression<string> bodybillingInstrumentsubscriptionId = null, WorkflowExpression<string> bodybillingInstrumentresourceGroup = null, WorkflowExpression<string> bodybillingInstrumentid = null, WorkflowExpression<bodystatusInput> bodystatus = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowExpression.Validate(bodybillingInstrumentsubscriptionId, nameof(bodybillingInstrumentsubscriptionId), required: false);
            WorkflowExpression.Validate(bodybillingInstrumentresourceGroup, nameof(bodybillingInstrumentresourceGroup), required: false);
            WorkflowExpression.Validate(bodybillingInstrumentid, nameof(bodybillingInstrumentid), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                var billingInstrumentObject = new JObject();
                var billingInstrumentObjectpropCount = 0;
                if (bodybillingInstrumentsubscriptionId != null)
                {
                    billingInstrumentObject["subscriptionId"] = ExpressionConverter.ConvertO(bodybillingInstrumentsubscriptionId);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentresourceGroup != null)
                {
                    billingInstrumentObject["resourceGroup"] = ExpressionConverter.ConvertO(bodybillingInstrumentresourceGroup);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentid != null)
                {
                    billingInstrumentObject["id"] = ExpressionConverter.ConvertO(bodybillingInstrumentid);
                    billingInstrumentObjectpropCount++;
                }

                if (billingInstrumentObjectpropCount > 0)
                {
                    body["billingInstrument"] = billingInstrumentObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetBillingPolicy))]
        public IBodyWorkflowAction<BillingPolicyResponseModel> GetBillingPolicy([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyResponseModel> __BuildGetBillingPolicy(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateBillingPolicy))]
        public IBodyWorkflowAction<BillingPolicyResponseModel> UpdateBillingPolicy([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyResponseModel> __BuildUpdateBillingPolicy(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyname = null, WorkflowExpression<bodystatusInput> bodystatus = null)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteBillingPolicy))]
        public IWorkflowAction DeleteBillingPolicy([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteBillingPolicy(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListBillingPolicyEnvironments))]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation> ListBillingPolicyEnvironments([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation> __BuildListBillingPolicyEnvironments(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetBillingPolicyEnvironment))]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1> GetBillingPolicyEnvironment([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1> __BuildGetBillingPolicyEnvironment(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyEnvironmentResponseModelV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments/{1}", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildAddBillingPolicyEnvironment))]
        public IWorkflowAction AddBillingPolicyEnvironment([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string[]> bodyenvironmentIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddBillingPolicyEnvironment(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion, WorkflowExpression<string[]> bodyenvironmentIds = null)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyenvironmentIds, nameof(bodyenvironmentIds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments/add", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyenvironmentIds != null)
                {
                    body["environmentIds"] = ExpressionConverter.ConvertO(bodyenvironmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveBillingPolicyEnvironment))]
        public IWorkflowAction RemoveBillingPolicyEnvironment([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string[]> bodyenvironmentIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveBillingPolicyEnvironment(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion, WorkflowExpression<string[]> bodyenvironmentIds = null)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyenvironmentIds, nameof(bodyenvironmentIds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/environments/remove", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyenvironmentIds != null)
                {
                    body["environmentIds"] = ExpressionConverter.ConvertO(bodyenvironmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildRefreshProvisioningStatus))]
        public IBodyWorkflowAction<BillingPolicyResponseModel> RefreshProvisioningStatus([WorkflowExpression] Func<string> billingPolicyId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyResponseModel> __BuildRefreshProvisioningStatus(WorkflowExpression<string> billingPolicyId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(billingPolicyId, nameof(billingPolicyId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/billingPolicies/{0}/refreshProvisioningStatus", ExpressionConverter.ConvertWithUrlEncoding(billingPolicyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetCurrencyAllocationByEnvironment))]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> GetCurrencyAllocationByEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> __BuildGetCurrencyAllocationByEnvironment(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AllocationsByEnvironmentResponseModelV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/allocations", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildPatchCurrencyAllocationByEnvironment))]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> PatchCurrencyAllocationByEnvironment([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<CurrencyAllocationRequestModelV1[]> bodycurrencyAllocations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> __BuildPatchCurrencyAllocationByEnvironment(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<CurrencyAllocationRequestModelV1[]> bodycurrencyAllocations = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodycurrencyAllocations, nameof(bodycurrencyAllocations), required: false);
            return new DeferredBodyAction<AllocationsByEnvironmentResponseModelV1>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/allocations", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycurrencyAllocations != null)
                {
                    body["currencyAllocations"] = ExpressionConverter.ConvertO(bodycurrencyAllocations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvironmentBillingPolicy))]
        public IBodyWorkflowAction<BillingPolicyResponseModel> GetEnvironmentBillingPolicy([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BillingPolicyResponseModel> __BuildGetEnvironmentBillingPolicy(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/environments/{0}/billingPolicy", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListISVContracts))]
        public IBodyWorkflowAction<IsvContractResponseModelResponseWithOdataContinuation> ListISVContracts([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsvContractResponseModelResponseWithOdataContinuation> __BuildListISVContracts(WorkflowExpression<string> apiVersion, WorkflowExpression<string> top = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<IsvContractResponseModelResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<IsvContractResponseModelResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateISVContract))]
        public IBodyWorkflowAction<IsvContractResponseModel> CreateISVContract([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodygeo, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyconsumertenantId = null, [WorkflowExpression] Func<bool> bodyconditionsapiFilterallowOtherPremiumConnectors = null, [WorkflowExpression] Func<BillingPolicyConditionsApiModel[]> bodyconditionsapiFilterrequiredApis = null, [WorkflowExpression] Func<string> bodybillingInstrumentsubscriptionId = null, [WorkflowExpression] Func<string> bodybillingInstrumentresourceGroup = null, [WorkflowExpression] Func<string> bodybillingInstrumentid = null, [WorkflowExpression] Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsvContractResponseModel> __BuildCreateISVContract(WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodygeo, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodyconsumertenantId = null, WorkflowExpression<bool> bodyconditionsapiFilterallowOtherPremiumConnectors = null, WorkflowExpression<BillingPolicyConditionsApiModel[]> bodyconditionsapiFilterrequiredApis = null, WorkflowExpression<string> bodybillingInstrumentsubscriptionId = null, WorkflowExpression<string> bodybillingInstrumentresourceGroup = null, WorkflowExpression<string> bodybillingInstrumentid = null, WorkflowExpression<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, WorkflowExpression<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, WorkflowExpression<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodygeo, nameof(bodygeo), required: true);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyconsumertenantId, nameof(bodyconsumertenantId), required: false);
            WorkflowExpression.Validate(bodyconditionsapiFilterallowOtherPremiumConnectors, nameof(bodyconditionsapiFilterallowOtherPremiumConnectors), required: false);
            WorkflowExpression.Validate(bodyconditionsapiFilterrequiredApis, nameof(bodyconditionsapiFilterrequiredApis), required: false);
            WorkflowExpression.Validate(bodybillingInstrumentsubscriptionId, nameof(bodybillingInstrumentsubscriptionId), required: false);
            WorkflowExpression.Validate(bodybillingInstrumentresourceGroup, nameof(bodybillingInstrumentresourceGroup), required: false);
            WorkflowExpression.Validate(bodybillingInstrumentid, nameof(bodybillingInstrumentid), required: false);
            WorkflowExpression.Validate(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState, nameof(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState), required: false);
            WorkflowExpression.Validate(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState), required: false);
            WorkflowExpression.Validate(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState), required: false);
            return new DeferredBodyAction<IsvContractResponseModel>(() =>
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["geo"] = ExpressionConverter.ConvertO(bodygeo);
                var consumerObject = new JObject();
                var consumerObjectpropCount = 0;
                if (bodyconsumertenantId != null)
                {
                    consumerObject["tenantId"] = ExpressionConverter.ConvertO(bodyconsumertenantId);
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
                    apiFilterObject["allowOtherPremiumConnectors"] = ExpressionConverter.ConvertO(bodyconditionsapiFilterallowOtherPremiumConnectors);
                    apiFilterObjectpropCount++;
                }

                if (bodyconditionsapiFilterrequiredApis != null)
                {
                    apiFilterObject["requiredApis"] = ExpressionConverter.ConvertO(bodyconditionsapiFilterrequiredApis);
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
                    billingInstrumentObject["subscriptionId"] = ExpressionConverter.ConvertO(bodybillingInstrumentsubscriptionId);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentresourceGroup != null)
                {
                    billingInstrumentObject["resourceGroup"] = ExpressionConverter.ConvertO(bodybillingInstrumentresourceGroup);
                    billingInstrumentObjectpropCount++;
                }

                if (bodybillingInstrumentid != null)
                {
                    billingInstrumentObject["id"] = ExpressionConverter.ConvertO(bodybillingInstrumentid);
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
                    powerAutomatePolicyObject["cloudFlowRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowUnattendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowAttendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState);
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

                return new ApiConnectionAction<IsvContractResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetISVContract))]
        public IBodyWorkflowAction<IsvContractResponseModel> GetISVContract([WorkflowExpression] Func<string> isvContractId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsvContractResponseModel> __BuildGetISVContract(WorkflowExpression<string> isvContractId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(isvContractId, nameof(isvContractId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<IsvContractResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/isvContracts/{0}", ExpressionConverter.ConvertWithUrlEncoding(isvContractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<IsvContractResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateISVContract))]
        public IBodyWorkflowAction<IsvContractResponseModel> UpdateISVContract([WorkflowExpression] Func<string> isvContractId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bool> bodyconditionsapiFilterallowOtherPremiumConnectors = null, [WorkflowExpression] Func<BillingPolicyConditionsApiModel[]> bodyconditionsapiFilterrequiredApis = null, [WorkflowExpression] Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, [WorkflowExpression] Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsvContractResponseModel> __BuildUpdateISVContract(WorkflowExpression<string> isvContractId, WorkflowExpression<string> apiVersion, WorkflowExpression<string> bodyname = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<bool> bodyconditionsapiFilterallowOtherPremiumConnectors = null, WorkflowExpression<BillingPolicyConditionsApiModel[]> bodyconditionsapiFilterrequiredApis = null, WorkflowExpression<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, WorkflowExpression<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, WorkflowExpression<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            WorkflowExpression.Validate(isvContractId, nameof(isvContractId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyconditionsapiFilterallowOtherPremiumConnectors, nameof(bodyconditionsapiFilterallowOtherPremiumConnectors), required: false);
            WorkflowExpression.Validate(bodyconditionsapiFilterrequiredApis, nameof(bodyconditionsapiFilterrequiredApis), required: false);
            WorkflowExpression.Validate(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState, nameof(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState), required: false);
            WorkflowExpression.Validate(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState), required: false);
            WorkflowExpression.Validate(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState), required: false);
            return new DeferredBodyAction<IsvContractResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/isvContracts/{0}", ExpressionConverter.ConvertWithUrlEncoding(isvContractId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var conditionsObject = new JObject();
                var conditionsObjectpropCount = 0;
                var apiFilterObject = new JObject();
                var apiFilterObjectpropCount = 0;
                if (bodyconditionsapiFilterallowOtherPremiumConnectors != null)
                {
                    apiFilterObject["allowOtherPremiumConnectors"] = ExpressionConverter.ConvertO(bodyconditionsapiFilterallowOtherPremiumConnectors);
                    apiFilterObjectpropCount++;
                }

                if (bodyconditionsapiFilterrequiredApis != null)
                {
                    apiFilterObject["requiredApis"] = ExpressionConverter.ConvertO(bodyconditionsapiFilterrequiredApis);
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
                    powerAutomatePolicyObject["cloudFlowRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowUnattendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowAttendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState);
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

                return new ApiConnectionAction<IsvContractResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteISVContract))]
        public IWorkflowAction DeleteISVContract([WorkflowExpression] Func<string> isvContractId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteISVContract(WorkflowExpression<string> isvContractId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(isvContractId, nameof(isvContractId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licensing/isvContracts/{0}", ExpressionConverter.ConvertWithUrlEncoding(isvContractId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetTenantCapacityDetails))]
        public IBodyWorkflowAction<TenantCapacityDetailsModel> GetTenantCapacityDetails([WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TenantCapacityDetailsModel> __BuildGetTenantCapacityDetails(WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantCapacityDetailsModel>(() =>
            {
                var apiCallPath = "/licensing/tenantCapacity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<TenantCapacityDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildListCurrencyReports))]
        public IBodyWorkflowAction<CurrencyReportV2[]> ListCurrencyReports([WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<bool> includeAllocations = null, [WorkflowExpression] Func<bool> includeConsumptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CurrencyReportV2[]> __BuildListCurrencyReports(WorkflowExpression<string> apiVersion, WorkflowExpression<bool> includeAllocations = null, WorkflowExpression<bool> includeConsumptions = null)
        {
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(includeAllocations, nameof(includeAllocations), required: false);
            WorkflowExpression.Validate(includeConsumptions, nameof(includeConsumptions), required: false);
            return new DeferredBodyAction<CurrencyReportV2[]>(() =>
            {
                var apiCallPath = "/licensing/tenantCapacity/currencyReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAllocations"] = Convert.ToString(true);
                if (includeAllocations != null)
                    callPayload.Queries["includeAllocations"] = ExpressionConverter.Convert(includeAllocations);
                callPayload.Queries["includeConsumptions"] = Convert.ToString(false);
                if (includeConsumptions != null)
                    callPayload.Queries["includeConsumptions"] = ExpressionConverter.Convert(includeConsumptions);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<CurrencyReportV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetAdminApps))]
        public IBodyWorkflowAction<ResourceArrayPowerApp> GetAdminApps([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResourceArrayPowerApp> __BuildGetAdminApps(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion, WorkflowExpression<int> top = null, WorkflowExpression<string> skiptoken = null)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ResourceArrayPowerApp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/powerapps/environments/{0}/apps", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(250);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<ResourceArrayPowerApp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetAdminApp))]
        public IBodyWorkflowAction<PowerApp> GetAdminApp([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> app, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PowerApp> __BuildGetAdminApp(WorkflowExpression<string> environmentId, WorkflowExpression<string> app, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(app, nameof(app), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<PowerApp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/powerapps/environments/{0}/apps/{1}", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(app, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction<PowerApp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildApplyAdminRole))]
        public IWorkflowAction ApplyAdminRole([WorkflowExpression] Func<string> environmentId, [WorkflowExpression] Func<string> apiVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApplyAdminRole(WorkflowExpression<string> environmentId, WorkflowExpression<string> apiVersion)
        {
            WorkflowExpression.Validate(environmentId, nameof(environmentId), required: true);
            WorkflowExpression.Validate(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/usermanagement/environments/{0}/user/applyAdminRole", ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [WorkflowExpressionFactory(nameof(__BuildMcpEnvironmentManagement))]
        public IBodyWorkflowAction<MCPQueryResponse> McpEnvironmentManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MCPQueryResponse> __BuildMcpEnvironmentManagement(WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/EnvironmentManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
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

                return new ApiConnectionAction<MCPQueryResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CatalogVisibility
    {
        None,
        AdminCenter,
        Teams,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class ValidationResponse
    {
        [JsonProperty("errorDetail")]
        public ErrorInfo ErrorDetail { get; set; }
    }

    public class ErrorInfo
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("fieldErrors")]
        public JToken FieldErrors { get; set; }
    }

    public class OperationExecutionResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public OperationStatus Status { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("updatedEnvironment")]
        public Environment UpdatedEnvironment { get; set; }

        [JsonProperty("requestedBy")]
        public UserIdentity RequestedBy { get; set; }

        [JsonProperty("errorDetail")]
        public ErrorInfo ErrorDetail { get; set; }

        [JsonProperty("stageStatuses")]
        public StageStatus[] StageStatuses { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationStatus
    {
        Queued,
        InProgress,
        Succeeded,
        ValidationFailed,
        Failed,
        NoOperation,
        ValidationPassed
    }

    public class Environment
    {
        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dataverseOrganizationUrl")]
        public string DataverseOrganizationUrl { get; set; }
    }

    public class UserIdentity
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    public class StageStatus
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("errorDetail")]
        public ErrorInfo ErrorDetail { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycopyTypeInput
    {
        Minimal,
        Full
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
    }

    public class EnvironmentResponseRetentionDetailsType
    {
        [JsonProperty("retentionPeriod")]
        public string RetentionPeriod { get; set; }

        [JsonProperty("availableFromDateTime")]
        public string AvailableFromDateTime { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CrossTenantConnectionConnectionTypeType
    {
        Inbound,
        Outbound
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResourceQueryResponseResultTruncatedType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public Principal CreatedBy { get; set; }

        [JsonProperty("lastModifiedOn")]
        public string LastModifiedOn { get; set; }

        [JsonProperty("lastModifiedBy")]
        public Principal LastModifiedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class Principal
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public Principal CreatedBy { get; set; }

        [JsonProperty("lastModifiedOn")]
        public string LastModifiedOn { get; set; }

        [JsonProperty("lastModifiedBy")]
        public Principal LastModifiedBy { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PayAsYouGoState
    {
        Enabled,
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput
    {
        Enabled,
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput
    {
        Enabled,
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CapacityAvailabilityStatus
    {
        None,
        Available,
        AvailableByOverflow,
        NotAvailable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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