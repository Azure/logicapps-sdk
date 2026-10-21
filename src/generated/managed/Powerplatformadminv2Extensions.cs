//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerplatformadminv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Powerplatformadminv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorActionResponse> ExecuteRecommendationAction(Expression<Func<string>> bodyrecommendationName, Expression<Func<object>> bodyparameters, Expression<Func<string>> actionName, Expression<Func<string>> apiVersion)
        {
            var __workflow_bodyrecommendationName = WorkflowExpression.Compile(bodyrecommendationName, nameof(bodyrecommendationName), required: true);
            var __workflow_bodyparameters = WorkflowExpression.Compile(bodyparameters, nameof(bodyparameters), required: true);
            var __workflow_actionName = WorkflowExpression.Compile(actionName, nameof(actionName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/analytics/actions/{0}", __workflow_actionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["scenario"] = ExpressionConverter.ConvertO(__workflow_bodyrecommendationName);
                bodypropCount++;
                body["actionParameters"] = ExpressionConverter.ConvertO(__workflow_bodyparameters);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AdvisorActionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorRecommendationIEnumerableResponseWithContinuation> GetRecommendations(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorRecommendationIEnumerableResponseWithContinuation>(() =>
            {
                var apiCallPath = "/analytics/advisorRecommendations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AdvisorRecommendationIEnumerableResponseWithContinuation>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation> GetRecommendationResources(Expression<Func<string>> scenario, Expression<Func<string>> apiVersion)
        {
            var __workflow_scenario = WorkflowExpression.Compile(scenario, nameof(scenario), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/analytics/advisorRecommendations/{0}/resources", __workflow_scenario.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantApplicationPackageContinuationResponse> GetTenantApplicationPackage(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantApplicationPackageContinuationResponse>(() =>
            {
                var apiCallPath = "/appmanagement/applicationPackages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TenantApplicationPackageContinuationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ApplicationPackageContinuationResponse> GetEnvironmentApplicationPackage(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<appInstallStateInput>> appInstallState = null, Expression<Func<string>> lcid = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_appInstallState = WorkflowExpression.Compile(appInstallState, nameof(appInstallState), required: false);
            var __workflow_lcid = WorkflowExpression.Compile(lcid, nameof(lcid), required: false);
            return new DeferredBodyAction<ApplicationPackageContinuationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/appmanagement/environments/{0}/applicationPackages", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_appInstallState != null)
                    callPayload.Queries["appInstallState"] = ExpressionConverter.Convert(__workflow_appInstallState);
                if (__workflow_lcid != null)
                    callPayload.Queries["lcid"] = ExpressionConverter.Convert(__workflow_lcid);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ApplicationPackageContinuationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<InstancePackage> InstallApplicationPackage(Expression<Func<string>> environmentId, Expression<Func<string>> uniqueName, Expression<Func<string>> apiVersion, Expression<Func<string>> bodypayloadValue = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_uniqueName = WorkflowExpression.Compile(uniqueName, nameof(uniqueName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodypayloadValue = WorkflowExpression.Compile(bodypayloadValue, nameof(bodypayloadValue), required: false);
            return new DeferredBodyAction<InstancePackage>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/appmanagement/environments/{0}/applicationPackages/{1}/install", __workflow_environmentId.WithUrlEncoding(1), __workflow_uniqueName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypayloadValue != null)
                {
                    body["payloadValue"] = ExpressionConverter.ConvertO(__workflow_bodypayloadValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InstancePackage>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<InstancePackageOperationPollingResponse> GetApplicationPackageInstallStatus(Expression<Func<string>> environmentId, Expression<Func<string>> operationId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<InstancePackageOperationPollingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/appmanagement/environments/{0}/operations/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<InstancePackageOperationPollingResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> ListRoleAssignments(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleAssignmentResponse>(() =>
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse> CreateRoleAssignment(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyprincipalObjectId = null, Expression<Func<string>> bodyroleDefinitionId = null, Expression<Func<string>> bodyscope = null, Expression<Func<string>> bodyprincipalType = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyprincipalObjectId = WorkflowExpression.Compile(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            var __workflow_bodyroleDefinitionId = WorkflowExpression.Compile(bodyroleDefinitionId, nameof(bodyroleDefinitionId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            var __workflow_bodyprincipalType = WorkflowExpression.Compile(bodyprincipalType, nameof(bodyprincipalType), required: false);
            return new DeferredBodyAction<RoleAssignmentResponse>(() =>
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (__workflow_bodyroleDefinitionId != null)
                {
                    body["roleDefinitionId"] = ExpressionConverter.ConvertO(__workflow_bodyroleDefinitionId);
                    bodypropCount++;
                }

                if (__workflow_bodyscope != null)
                {
                    body["scope"] = ExpressionConverter.ConvertO(__workflow_bodyscope);
                    bodypropCount++;
                }

                if (__workflow_bodyprincipalType != null)
                {
                    body["principalType"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteRoleAssignment(Expression<Func<string>> roleAssignmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_roleAssignmentId = WorkflowExpression.Compile(roleAssignmentId, nameof(roleAssignmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/roleAssignments/{0}", __workflow_roleAssignmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleDefinitionResponse> ListRoleDefinitions(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleDefinitionResponse>(() =>
            {
                var apiCallPath = "/authorization/roleDefinitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RoleDefinitionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListConnectorsResponse> ListConnectors(Expression<Func<string>> environmentId, Expression<Func<string>> filter, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListConnectorsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connectivity/environments/{0}/connectors", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListConnectorsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<GetConnectorByIdResponse> GetConnectorById(Expression<Func<string>> environmentId, Expression<Func<string>> connectorId, Expression<Func<string>> filter, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_connectorId = WorkflowExpression.Compile(connectorId, nameof(connectorId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<GetConnectorByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connectivity/environments/{0}/connectors/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_connectorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<GetConnectorByIdResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus> GetBotQuarantineStatus(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus> SetBotAsQuarantined(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsQuarantined", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus> SetBotAsUnquarantined(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsUnquarantined", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> DeleteEnvironmentBackup(Expression<Func<string>> environmentId, Expression<Func<string>> backupId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_backupId = WorkflowExpression.Compile(backupId, nameof(backupId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/backups/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_backupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ValidationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> DisableEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null, Expression<Func<string>> bodyreason = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/Disable", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<OperationExecutionResult> DisableDisasterRecovery(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/disableDisasterRecovery", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<OperationExecutionResult> PerformDRDrill(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/disasterRecoveryDrill", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> EnableEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null, Expression<Func<string>> bodyreason = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/Enable", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<OperationExecutionResult> EnableDisasterRecovery(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/enableDisasterRecovery", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<OperationExecutionResult> PerformForceFailover(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodylastSyncTime, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodylastSyncTime = WorkflowExpression.Compile(bodylastSyncTime, nameof(bodylastSyncTime), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<OperationExecutionResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/forceFailover", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["lastSyncTime"] = ExpressionConverter.ConvertO(__workflow_bodylastSyncTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OperationExecutionResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> RecoverEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/recover", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ValidationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> CopyEnvironment(Expression<Func<string>> targetEnvironmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodysourceEnvironmentId, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null, Expression<Func<bodycopyTypeInput>> bodycopyType = null, Expression<Func<string>> bodycopyOptionsenvironmentNameToOverride = null, Expression<Func<string>> bodycopyOptionssecurityGroupIdToOverride = null, Expression<Func<bool>> bodycopyOptionsskipAuditData = null, Expression<Func<bool>> bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations = null)
        {
            var __workflow_targetEnvironmentId = WorkflowExpression.Compile(targetEnvironmentId, nameof(targetEnvironmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodysourceEnvironmentId = WorkflowExpression.Compile(bodysourceEnvironmentId, nameof(bodysourceEnvironmentId), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            var __workflow_bodycopyType = WorkflowExpression.Compile(bodycopyType, nameof(bodycopyType), required: false);
            var __workflow_bodycopyOptionsenvironmentNameToOverride = WorkflowExpression.Compile(bodycopyOptionsenvironmentNameToOverride, nameof(bodycopyOptionsenvironmentNameToOverride), required: false);
            var __workflow_bodycopyOptionssecurityGroupIdToOverride = WorkflowExpression.Compile(bodycopyOptionssecurityGroupIdToOverride, nameof(bodycopyOptionssecurityGroupIdToOverride), required: false);
            var __workflow_bodycopyOptionsskipAuditData = WorkflowExpression.Compile(bodycopyOptionsskipAuditData, nameof(bodycopyOptionsskipAuditData), required: false);
            var __workflow_bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations = WorkflowExpression.Compile(bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations, nameof(bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/copy", __workflow_targetEnvironmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sourceEnvironmentId"] = ExpressionConverter.ConvertO(__workflow_bodysourceEnvironmentId);
                if (__workflow_bodycopyType != null)
                {
                    body["copyType"] = ExpressionConverter.ConvertO(__workflow_bodycopyType);
                    bodypropCount++;
                }

                var copyOptionsObject = new JObject();
                var copyOptionsObjectpropCount = 0;
                if (__workflow_bodycopyOptionsenvironmentNameToOverride != null)
                {
                    copyOptionsObject["environmentNameToOverride"] = ExpressionConverter.ConvertO(__workflow_bodycopyOptionsenvironmentNameToOverride);
                    copyOptionsObjectpropCount++;
                }

                if (__workflow_bodycopyOptionssecurityGroupIdToOverride != null)
                {
                    copyOptionsObject["securityGroupIdToOverride"] = ExpressionConverter.ConvertO(__workflow_bodycopyOptionssecurityGroupIdToOverride);
                    copyOptionsObjectpropCount++;
                }

                if (__workflow_bodycopyOptionsskipAuditData != null)
                {
                    copyOptionsObject["skipAuditData"] = ExpressionConverter.ConvertO(__workflow_bodycopyOptionsskipAuditData);
                    copyOptionsObjectpropCount++;
                }

                if (__workflow_bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations != null)
                {
                    copyOptionsObject["executeAdvancedCopyForFinanceAndOperations"] = ExpressionConverter.ConvertO(__workflow_bodycopyOptionsexecuteAdvancedCopyForFinanceAndOperations);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> RestoreEnvironment(Expression<Func<string>> targetEnvironmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyrestorePointDateTime, Expression<Func<string>> bodysourceEnvironmentId, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null, Expression<Func<bool>> bodyskipAuditData = null)
        {
            var __workflow_targetEnvironmentId = WorkflowExpression.Compile(targetEnvironmentId, nameof(targetEnvironmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyrestorePointDateTime = WorkflowExpression.Compile(bodyrestorePointDateTime, nameof(bodyrestorePointDateTime), required: true);
            var __workflow_bodysourceEnvironmentId = WorkflowExpression.Compile(bodysourceEnvironmentId, nameof(bodysourceEnvironmentId), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            var __workflow_bodyskipAuditData = WorkflowExpression.Compile(bodyskipAuditData, nameof(bodyskipAuditData), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}/Restore", __workflow_targetEnvironmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["restorePointDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyrestorePointDateTime);
                if (__workflow_bodyskipAuditData != null)
                {
                    body["skipAuditData"] = ExpressionConverter.ConvertO(__workflow_bodyskipAuditData);
                    bodypropCount++;
                }

                bodypropCount++;
                body["sourceEnvironmentId"] = ExpressionConverter.ConvertO(__workflow_bodysourceEnvironmentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> GetEnvironmentGroupOperation(Expression<Func<string>> operationId, Expression<Func<string>> apiVersion)
        {
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroupOperations/{0}", __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> DeleteEnvironmentGroup(Expression<Func<string>> groupId, Expression<Func<string>> apiVersion)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> AddEnvironmentToGroup(Expression<Func<string>> groupId, Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroups/{0}/addEnvironment/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails> RemoveEnvironmentFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroups/{0}/removeEnvironment/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentList> ListEnvironmentsForUser(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<EnvironmentList>(() =>
            {
                var apiCallPath = "/environmentmanagement/environments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<EnvironmentList>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentResponse> GetEnvironmentByIdForUser(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<EnvironmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<EnvironmentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ValidationResponse> DeleteEnvironmentByID(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<bool>> validateOnly = null, Expression<Func<string>> validateProperties = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_validateOnly = WorkflowExpression.Compile(validateOnly, nameof(validateOnly), required: false);
            var __workflow_validateProperties = WorkflowExpression.Compile(validateProperties, nameof(validateProperties), required: false);
            return new DeferredBodyAction<ValidationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_validateOnly != null)
                    callPayload.Queries["ValidateOnly"] = ExpressionConverter.Convert(__workflow_validateOnly);
                if (__workflow_validateProperties != null)
                    callPayload.Queries["ValidateProperties"] = ExpressionConverter.Convert(__workflow_validateProperties);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ValidationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy> CreateRuleBasedPolicy(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<RuleSet[]>> bodyruleSets = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyruleSets = WorkflowExpression.Compile(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<Policy>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyruleSets != null)
                {
                    body["ruleSets"] = ExpressionConverter.ConvertO(__workflow_bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Policy>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListPolicyResponse> ListRuleBasedPolicies(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListPolicyResponse>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListPolicyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy> GetRuleBasedPolicyByID(Expression<Func<string>> policyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<Policy>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<Policy>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignment> UpdateRuleBasedPolicyByID(Expression<Func<string>> policyId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<RuleSet[]>> bodyruleSets = null)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyruleSets = WorkflowExpression.Compile(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<RuleAssignment>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyruleSets != null)
                {
                    body["ruleSets"] = ExpressionConverter.ConvertO(__workflow_bodyruleSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RuleAssignment>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByPolicyId(Expression<Func<string>> policyId, Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}/assignments", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignments(Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies/assignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByEnvironmentGroupId(Expression<Func<string>> environmentGroupId, Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentGroupId = WorkflowExpression.Compile(environmentGroupId, nameof(environmentGroupId), required: true);
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/environmentGroups/{0}/assignments", __workflow_environmentGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse> ListRuleAssignmentsByEnvironmentId(Expression<Func<string>> environmentId, Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/environments/{0}/assignments", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CrossTenantConnectionReportsResponseWithOdataContinuation> ListCrossTenantConnectionReports(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CrossTenantConnectionReportsResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = "/governance/crossTenantConnectionReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<CrossTenantConnectionReportsResponseWithOdataContinuation>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CrossTenantConnectionReport> GetCrossTenantConnectionReport(Expression<Func<string>> reportId, Expression<Func<string>> apiVersion)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CrossTenantConnectionReport>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/crossTenantConnectionReports/{0}", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<CrossTenantConnectionReport>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceQueryResponse> QueryResources(Expression<Func<string>> apiVersion, Expression<Func<string>> bodytableName, Expression<Func<Clause[]>> bodyclauses, Expression<Func<int>> bodyoptionstop = null, Expression<Func<int>> bodyoptionsskip = null, Expression<Func<string>> bodyoptionsskipToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodytableName = WorkflowExpression.Compile(bodytableName, nameof(bodytableName), required: true);
            var __workflow_bodyclauses = WorkflowExpression.Compile(bodyclauses, nameof(bodyclauses), required: true);
            var __workflow_bodyoptionstop = WorkflowExpression.Compile(bodyoptionstop, nameof(bodyoptionstop), required: false);
            var __workflow_bodyoptionsskip = WorkflowExpression.Compile(bodyoptionsskip, nameof(bodyoptionsskip), required: false);
            var __workflow_bodyoptionsskipToken = WorkflowExpression.Compile(bodyoptionsskipToken, nameof(bodyoptionsskipToken), required: false);
            return new DeferredBodyAction<ResourceQueryResponse>(() =>
            {
                var apiCallPath = "/resourcequery/resources/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TableName"] = ExpressionConverter.ConvertO(__workflow_bodytableName);
                bodypropCount++;
                body["Clauses"] = ExpressionConverter.ConvertO(__workflow_bodyclauses);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionstop != null)
                {
                    optionsObject["Top"] = ExpressionConverter.ConvertO(__workflow_bodyoptionstop);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsskip != null)
                {
                    optionsObject["Skip"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsskip);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsskipToken != null)
                {
                    optionsObject["SkipToken"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsskipToken);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModelResponseWithOdataContinuation> ListBillingPolicies(Expression<Func<string>> apiVersion, Expression<Func<string>> top = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModelResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModelResponseWithOdataContinuation>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> CreateBillingPolicy(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodybillingInstrumentsubscriptionId = null, Expression<Func<string>> bodybillingInstrumentresourceGroup = null, Expression<Func<string>> bodybillingInstrumentid = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodybillingInstrumentsubscriptionId = WorkflowExpression.Compile(bodybillingInstrumentsubscriptionId, nameof(bodybillingInstrumentsubscriptionId), required: false);
            var __workflow_bodybillingInstrumentresourceGroup = WorkflowExpression.Compile(bodybillingInstrumentresourceGroup, nameof(bodybillingInstrumentresourceGroup), required: false);
            var __workflow_bodybillingInstrumentid = WorkflowExpression.Compile(bodybillingInstrumentid, nameof(bodybillingInstrumentid), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                var billingInstrumentObject = new JObject();
                var billingInstrumentObjectpropCount = 0;
                if (__workflow_bodybillingInstrumentsubscriptionId != null)
                {
                    billingInstrumentObject["subscriptionId"] = ExpressionConverter.ConvertO(__workflow_bodybillingInstrumentsubscriptionId);
                    billingInstrumentObjectpropCount++;
                }

                if (__workflow_bodybillingInstrumentresourceGroup != null)
                {
                    billingInstrumentObject["resourceGroup"] = ExpressionConverter.ConvertO(__workflow_bodybillingInstrumentresourceGroup);
                    billingInstrumentObjectpropCount++;
                }

                if (__workflow_bodybillingInstrumentid != null)
                {
                    billingInstrumentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodybillingInstrumentid);
                    billingInstrumentObjectpropCount++;
                }

                if (billingInstrumentObjectpropCount > 0)
                {
                    body["billingInstrument"] = billingInstrumentObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> GetBillingPolicy(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> UpdateBillingPolicy(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteBillingPolicy(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation> ListBillingPolicyEnvironments(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/environments", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1> GetBillingPolicyEnvironment(Expression<Func<string>> billingPolicyId, Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyEnvironmentResponseModelV1>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/environments/{1}", __workflow_billingPolicyId.WithUrlEncoding(1), __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction AddBillingPolicyEnvironment(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion, Expression<Func<string[]>> bodyenvironmentIds = null)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyenvironmentIds = WorkflowExpression.Compile(bodyenvironmentIds, nameof(bodyenvironmentIds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/environments/add", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyenvironmentIds != null)
                {
                    body["environmentIds"] = ExpressionConverter.ConvertO(__workflow_bodyenvironmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction RemoveBillingPolicyEnvironment(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion, Expression<Func<string[]>> bodyenvironmentIds = null)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyenvironmentIds = WorkflowExpression.Compile(bodyenvironmentIds, nameof(bodyenvironmentIds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/environments/remove", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyenvironmentIds != null)
                {
                    body["environmentIds"] = ExpressionConverter.ConvertO(__workflow_bodyenvironmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> RefreshProvisioningStatus(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/refreshProvisioningStatus", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> GetCurrencyAllocationByEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AllocationsByEnvironmentResponseModelV1>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/allocations", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1> PatchCurrencyAllocationByEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<CurrencyAllocationRequestModelV1[]>> bodycurrencyAllocations = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodycurrencyAllocations = WorkflowExpression.Compile(bodycurrencyAllocations, nameof(bodycurrencyAllocations), required: false);
            return new DeferredBodyAction<AllocationsByEnvironmentResponseModelV1>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/allocations", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycurrencyAllocations != null)
                {
                    body["currencyAllocations"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyAllocations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel> GetEnvironmentBillingPolicy(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/billingPolicy", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModelResponseWithOdataContinuation> ListISVContracts(Expression<Func<string>> apiVersion, Expression<Func<string>> top = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<IsvContractResponseModelResponseWithOdataContinuation>(() =>
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<IsvContractResponseModelResponseWithOdataContinuation>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel> CreateISVContract(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname, Expression<Func<string>> bodygeo, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyconsumertenantId = null, Expression<Func<bool>> bodyconditionsapiFilterallowOtherPremiumConnectors = null, Expression<Func<BillingPolicyConditionsApiModel[]>> bodyconditionsapiFilterrequiredApis = null, Expression<Func<string>> bodybillingInstrumentsubscriptionId = null, Expression<Func<string>> bodybillingInstrumentresourceGroup = null, Expression<Func<string>> bodybillingInstrumentid = null, Expression<Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput>> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodygeo = WorkflowExpression.Compile(bodygeo, nameof(bodygeo), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyconsumertenantId = WorkflowExpression.Compile(bodyconsumertenantId, nameof(bodyconsumertenantId), required: false);
            var __workflow_bodyconditionsapiFilterallowOtherPremiumConnectors = WorkflowExpression.Compile(bodyconditionsapiFilterallowOtherPremiumConnectors, nameof(bodyconditionsapiFilterallowOtherPremiumConnectors), required: false);
            var __workflow_bodyconditionsapiFilterrequiredApis = WorkflowExpression.Compile(bodyconditionsapiFilterrequiredApis, nameof(bodyconditionsapiFilterrequiredApis), required: false);
            var __workflow_bodybillingInstrumentsubscriptionId = WorkflowExpression.Compile(bodybillingInstrumentsubscriptionId, nameof(bodybillingInstrumentsubscriptionId), required: false);
            var __workflow_bodybillingInstrumentresourceGroup = WorkflowExpression.Compile(bodybillingInstrumentresourceGroup, nameof(bodybillingInstrumentresourceGroup), required: false);
            var __workflow_bodybillingInstrumentid = WorkflowExpression.Compile(bodybillingInstrumentid, nameof(bodybillingInstrumentid), required: false);
            var __workflow_bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = WorkflowExpression.Compile(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState, nameof(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState), required: false);
            var __workflow_bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = WorkflowExpression.Compile(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState), required: false);
            var __workflow_bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = WorkflowExpression.Compile(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState), required: false);
            return new DeferredBodyAction<IsvContractResponseModel>(() =>
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["geo"] = ExpressionConverter.ConvertO(__workflow_bodygeo);
                var consumerObject = new JObject();
                var consumerObjectpropCount = 0;
                if (__workflow_bodyconsumertenantId != null)
                {
                    consumerObject["tenantId"] = ExpressionConverter.ConvertO(__workflow_bodyconsumertenantId);
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
                if (__workflow_bodyconditionsapiFilterallowOtherPremiumConnectors != null)
                {
                    apiFilterObject["allowOtherPremiumConnectors"] = ExpressionConverter.ConvertO(__workflow_bodyconditionsapiFilterallowOtherPremiumConnectors);
                    apiFilterObjectpropCount++;
                }

                if (__workflow_bodyconditionsapiFilterrequiredApis != null)
                {
                    apiFilterObject["requiredApis"] = ExpressionConverter.ConvertO(__workflow_bodyconditionsapiFilterrequiredApis);
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
                if (__workflow_bodybillingInstrumentsubscriptionId != null)
                {
                    billingInstrumentObject["subscriptionId"] = ExpressionConverter.ConvertO(__workflow_bodybillingInstrumentsubscriptionId);
                    billingInstrumentObjectpropCount++;
                }

                if (__workflow_bodybillingInstrumentresourceGroup != null)
                {
                    billingInstrumentObject["resourceGroup"] = ExpressionConverter.ConvertO(__workflow_bodybillingInstrumentresourceGroup);
                    billingInstrumentObjectpropCount++;
                }

                if (__workflow_bodybillingInstrumentid != null)
                {
                    billingInstrumentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodybillingInstrumentid);
                    billingInstrumentObjectpropCount++;
                }

                if (billingInstrumentObjectpropCount > 0)
                {
                    body["billingInstrument"] = billingInstrumentObject;
                    bodypropCount++;
                }

                var powerAutomatePolicyObject = new JObject();
                var powerAutomatePolicyObjectpropCount = 0;
                if (__workflow_bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["cloudFlowRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(__workflow_bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (__workflow_bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowUnattendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(__workflow_bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (__workflow_bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowAttendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(__workflow_bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel> GetISVContract(Expression<Func<string>> isvContractId, Expression<Func<string>> apiVersion)
        {
            var __workflow_isvContractId = WorkflowExpression.Compile(isvContractId, nameof(isvContractId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<IsvContractResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/isvContracts/{0}", __workflow_isvContractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<IsvContractResponseModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel> UpdateISVContract(Expression<Func<string>> isvContractId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodyconditionsapiFilterallowOtherPremiumConnectors = null, Expression<Func<BillingPolicyConditionsApiModel[]>> bodyconditionsapiFilterrequiredApis = null, Expression<Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput>> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
        {
            var __workflow_isvContractId = WorkflowExpression.Compile(isvContractId, nameof(isvContractId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyconditionsapiFilterallowOtherPremiumConnectors = WorkflowExpression.Compile(bodyconditionsapiFilterallowOtherPremiumConnectors, nameof(bodyconditionsapiFilterallowOtherPremiumConnectors), required: false);
            var __workflow_bodyconditionsapiFilterrequiredApis = WorkflowExpression.Compile(bodyconditionsapiFilterrequiredApis, nameof(bodyconditionsapiFilterrequiredApis), required: false);
            var __workflow_bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = WorkflowExpression.Compile(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState, nameof(bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState), required: false);
            var __workflow_bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = WorkflowExpression.Compile(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState), required: false);
            var __workflow_bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = WorkflowExpression.Compile(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState, nameof(bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState), required: false);
            return new DeferredBodyAction<IsvContractResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/isvContracts/{0}", __workflow_isvContractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var conditionsObject = new JObject();
                var conditionsObjectpropCount = 0;
                var apiFilterObject = new JObject();
                var apiFilterObjectpropCount = 0;
                if (__workflow_bodyconditionsapiFilterallowOtherPremiumConnectors != null)
                {
                    apiFilterObject["allowOtherPremiumConnectors"] = ExpressionConverter.ConvertO(__workflow_bodyconditionsapiFilterallowOtherPremiumConnectors);
                    apiFilterObjectpropCount++;
                }

                if (__workflow_bodyconditionsapiFilterrequiredApis != null)
                {
                    apiFilterObject["requiredApis"] = ExpressionConverter.ConvertO(__workflow_bodyconditionsapiFilterrequiredApis);
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
                if (__workflow_bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["cloudFlowRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(__workflow_bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (__workflow_bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowUnattendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(__workflow_bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState);
                    powerAutomatePolicyObjectpropCount++;
                }

                if (__workflow_bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState != null)
                {
                    powerAutomatePolicyObject["desktopFlowAttendedRunsPayAsYouGoState"] = ExpressionConverter.ConvertO(__workflow_bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction DeleteISVContract(Expression<Func<string>> isvContractId, Expression<Func<string>> apiVersion)
        {
            var __workflow_isvContractId = WorkflowExpression.Compile(isvContractId, nameof(isvContractId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/isvContracts/{0}", __workflow_isvContractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantCapacityDetailsModel> GetTenantCapacityDetails(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantCapacityDetailsModel>(() =>
            {
                var apiCallPath = "/licensing/tenantCapacity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TenantCapacityDetailsModel>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CurrencyReportV2[]> ListCurrencyReports(Expression<Func<string>> apiVersion, Expression<Func<bool>> includeAllocations = null, Expression<Func<bool>> includeConsumptions = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_includeAllocations = WorkflowExpression.Compile(includeAllocations, nameof(includeAllocations), required: false);
            var __workflow_includeConsumptions = WorkflowExpression.Compile(includeConsumptions, nameof(includeConsumptions), required: false);
            return new DeferredBodyAction<CurrencyReportV2[]>(() =>
            {
                var apiCallPath = "/licensing/tenantCapacity/currencyReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAllocations"] = Convert.ToString(true);
                if (__workflow_includeAllocations != null)
                    callPayload.Queries["includeAllocations"] = ExpressionConverter.Convert(__workflow_includeAllocations);
                callPayload.Queries["includeConsumptions"] = Convert.ToString(false);
                if (__workflow_includeConsumptions != null)
                    callPayload.Queries["includeConsumptions"] = ExpressionConverter.Convert(__workflow_includeConsumptions);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<CurrencyReportV2[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceArrayPowerApp> GetAdminApps(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ResourceArrayPowerApp>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/powerapps/environments/{0}/apps", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$top"] = Convert.ToString(250);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ResourceArrayPowerApp>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerApp> GetAdminApp(Expression<Func<string>> environmentId, Expression<Func<string>> app, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_app = WorkflowExpression.Compile(app, nameof(app), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<PowerApp>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/powerapps/environments/{0}/apps/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_app.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerApp>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction ApplyAdminRole(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/usermanagement/environments/{0}/user/applyAdminRole", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<MCPQueryResponse> McpEnvironmentManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/EnvironmentManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
