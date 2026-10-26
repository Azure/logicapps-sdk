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
        public IWorkflowAction<ApiConnectionActionConfiguration> InvokeAdvisorMCP(Expression<Func<string>> mcpSessionId = null, Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null)
        {
            var __workflow_mcpSessionId = WorkflowExpression.Compile(mcpSessionId, nameof(mcpSessionId), required: false);
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/analytics/mcp/Advisor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("1");
                if (__workflow_mcpSessionId != null)
                    callPayload.Headers["Mcp-Session-Id"] = ExpressionConverter.Convert(__workflow_mcpSessionId);
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

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorActionResponse, ApiConnectionActionConfiguration> ExecuteRecommendationAction(Expression<Func<string>> bodyrecommendationName, Expression<Func<object>> bodyparameters, Expression<Func<string>> actionName, Expression<Func<string>> apiVersion)
        {
            var __workflow_bodyrecommendationName = WorkflowExpression.Compile(bodyrecommendationName, nameof(bodyrecommendationName), required: true);
            var __workflow_bodyparameters = WorkflowExpression.Compile(bodyparameters, nameof(bodyparameters), required: true);
            var __workflow_actionName = WorkflowExpression.Compile(actionName, nameof(actionName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorActionResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorRecommendationIEnumerableResponseWithContinuation, ApiConnectionActionConfiguration> GetRecommendations(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorRecommendationIEnumerableResponseWithContinuation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/analytics/advisorRecommendations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AdvisorRecommendationIEnumerableResponseWithContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation, ApiConnectionActionConfiguration> GetRecommendationResources(Expression<Func<string>> scenario, Expression<Func<string>> apiVersion)
        {
            var __workflow_scenario = WorkflowExpression.Compile(scenario, nameof(scenario), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/analytics/advisorRecommendations/{0}/resources", __workflow_scenario.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AdvisorRecommendationResourceIEnumerableResponseWithContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantApplicationPackageContinuationResponse, ApiConnectionActionConfiguration> GetTenantApplicationPackage(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantApplicationPackageContinuationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/appmanagement/applicationPackages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TenantApplicationPackageContinuationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ApplicationPackageContinuationResponse, ApiConnectionActionConfiguration> GetEnvironmentApplicationPackage(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<appInstallStateInput>> appInstallState = null, Expression<Func<string>> lcid = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_appInstallState = WorkflowExpression.Compile(appInstallState, nameof(appInstallState), required: false);
            var __workflow_lcid = WorkflowExpression.Compile(lcid, nameof(lcid), required: false);
            return new DeferredBodyAction<ApplicationPackageContinuationResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<InstancePackage, ApiConnectionActionConfiguration> InstallApplicationPackage(Expression<Func<string>> environmentId, Expression<Func<string>> uniqueName, Expression<Func<string>> apiVersion, Expression<Func<string>> bodypayloadValue = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_uniqueName = WorkflowExpression.Compile(uniqueName, nameof(uniqueName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodypayloadValue = WorkflowExpression.Compile(bodypayloadValue, nameof(bodypayloadValue), required: false);
            return new DeferredBodyAction<InstancePackage, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<InstancePackageOperationPollingResponse, ApiConnectionActionConfiguration> GetApplicationPackageInstallStatus(Expression<Func<string>> environmentId, Expression<Func<string>> operationId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<InstancePackageOperationPollingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/appmanagement/environments/{0}/operations/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<InstancePackageOperationPollingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse, ApiConnectionActionConfiguration> ListEnvironmentGroupRoleAssignments(Expression<Func<string>> environmentGroupId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentGroupId = WorkflowExpression.Compile(environmentGroupId, nameof(environmentGroupId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleAssignmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environmentGroups/{0}/roleAssignments", __workflow_environmentGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse, ApiConnectionActionConfiguration> CreateEnvironmentGroupRoleAssignment(Expression<Func<string>> environmentGroupId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyprincipalObjectId = null, Expression<Func<string>> bodyroleDefinitionId = null, Expression<Func<string>> bodyscope = null, Expression<Func<string>> bodyprincipalType = null)
        {
            var __workflow_environmentGroupId = WorkflowExpression.Compile(environmentGroupId, nameof(environmentGroupId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyprincipalObjectId = WorkflowExpression.Compile(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            var __workflow_bodyroleDefinitionId = WorkflowExpression.Compile(bodyroleDefinitionId, nameof(bodyroleDefinitionId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            var __workflow_bodyprincipalType = WorkflowExpression.Compile(bodyprincipalType, nameof(bodyprincipalType), required: false);
            return new DeferredBodyAction<RoleAssignmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environmentGroups/{0}/roleAssignments", __workflow_environmentGroupId.WithUrlEncoding(1)));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnvironmentGroupRoleAssignment(Expression<Func<string>> environmentGroupId, Expression<Func<string>> roleAssignmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentGroupId = WorkflowExpression.Compile(environmentGroupId, nameof(environmentGroupId), required: true);
            var __workflow_roleAssignmentId = WorkflowExpression.Compile(roleAssignmentId, nameof(roleAssignmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environmentGroups/{0}/roleAssignments/{1}", __workflow_environmentGroupId.WithUrlEncoding(1), __workflow_roleAssignmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<SearchRoleAssignmentsResponse, ApiConnectionActionConfiguration> SearchEnvironmentRoleAssignments(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyscope, Expression<Func<string>> continuationToken = null, Expression<Func<string>> bodyprincipalType = null, Expression<Func<string>> bodyprincipalObjectId = null, Expression<Func<string>> bodypermission = null, Expression<Func<bool>> bodyincludeNestedScopes = null, Expression<Func<bool>> bodyincludeParentScopes = null, Expression<Func<bool>> bodyexpandEnvironmentGroups = null, Expression<Func<bool>> bodyexpandEnvironmentClusters = null, Expression<Func<bool>> bodyexpandSecurityGroups = null, Expression<Func<bool>> bodyincludeVirtualEntraRoleAssignments = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_bodyprincipalType = WorkflowExpression.Compile(bodyprincipalType, nameof(bodyprincipalType), required: false);
            var __workflow_bodyprincipalObjectId = WorkflowExpression.Compile(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            var __workflow_bodypermission = WorkflowExpression.Compile(bodypermission, nameof(bodypermission), required: false);
            var __workflow_bodyincludeNestedScopes = WorkflowExpression.Compile(bodyincludeNestedScopes, nameof(bodyincludeNestedScopes), required: false);
            var __workflow_bodyincludeParentScopes = WorkflowExpression.Compile(bodyincludeParentScopes, nameof(bodyincludeParentScopes), required: false);
            var __workflow_bodyexpandEnvironmentGroups = WorkflowExpression.Compile(bodyexpandEnvironmentGroups, nameof(bodyexpandEnvironmentGroups), required: false);
            var __workflow_bodyexpandEnvironmentClusters = WorkflowExpression.Compile(bodyexpandEnvironmentClusters, nameof(bodyexpandEnvironmentClusters), required: false);
            var __workflow_bodyexpandSecurityGroups = WorkflowExpression.Compile(bodyexpandSecurityGroups, nameof(bodyexpandSecurityGroups), required: false);
            var __workflow_bodyincludeVirtualEntraRoleAssignments = WorkflowExpression.Compile(bodyincludeVirtualEntraRoleAssignments, nameof(bodyincludeVirtualEntraRoleAssignments), required: false);
            return new DeferredBodyAction<SearchRoleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environments/{0}/listRoleAssignments", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["scope"] = ExpressionConverter.ConvertO(__workflow_bodyscope);
                if (__workflow_bodyprincipalType != null)
                {
                    body["principalType"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalType);
                    bodypropCount++;
                }

                if (__workflow_bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (__workflow_bodypermission != null)
                {
                    body["permission"] = ExpressionConverter.ConvertO(__workflow_bodypermission);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeNestedScopes != null)
                {
                    if (__workflow_bodyincludeNestedScopes != null)
                    {
                        body["includeNestedScopes"] = ExpressionConverter.ConvertO(__workflow_bodyincludeNestedScopes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeNestedScopes"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeParentScopes != null)
                {
                    if (__workflow_bodyincludeParentScopes != null)
                    {
                        body["includeParentScopes"] = ExpressionConverter.ConvertO(__workflow_bodyincludeParentScopes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeParentScopes"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpandEnvironmentGroups != null)
                {
                    if (__workflow_bodyexpandEnvironmentGroups != null)
                    {
                        body["expandEnvironmentGroups"] = ExpressionConverter.ConvertO(__workflow_bodyexpandEnvironmentGroups);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expandEnvironmentGroups"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpandEnvironmentClusters != null)
                {
                    if (__workflow_bodyexpandEnvironmentClusters != null)
                    {
                        body["expandEnvironmentClusters"] = ExpressionConverter.ConvertO(__workflow_bodyexpandEnvironmentClusters);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expandEnvironmentClusters"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpandSecurityGroups != null)
                {
                    if (__workflow_bodyexpandSecurityGroups != null)
                    {
                        body["expandSecurityGroups"] = ExpressionConverter.ConvertO(__workflow_bodyexpandSecurityGroups);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expandSecurityGroups"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeVirtualEntraRoleAssignments != null)
                {
                    if (__workflow_bodyincludeVirtualEntraRoleAssignments != null)
                    {
                        body["includeVirtualEntraRoleAssignments"] = ExpressionConverter.ConvertO(__workflow_bodyincludeVirtualEntraRoleAssignments);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeVirtualEntraRoleAssignments"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchRoleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse, ApiConnectionActionConfiguration> ListEnvironmentRoleAssignments(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleAssignmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environments/{0}/roleAssignments", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse, ApiConnectionActionConfiguration> CreateEnvironmentRoleAssignment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyprincipalObjectId = null, Expression<Func<string>> bodyroleDefinitionId = null, Expression<Func<string>> bodyscope = null, Expression<Func<string>> bodyprincipalType = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyprincipalObjectId = WorkflowExpression.Compile(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            var __workflow_bodyroleDefinitionId = WorkflowExpression.Compile(bodyroleDefinitionId, nameof(bodyroleDefinitionId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            var __workflow_bodyprincipalType = WorkflowExpression.Compile(bodyprincipalType, nameof(bodyprincipalType), required: false);
            return new DeferredBodyAction<RoleAssignmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environments/{0}/roleAssignments", __workflow_environmentId.WithUrlEncoding(1)));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnvironmentRoleAssignment(Expression<Func<string>> environmentId, Expression<Func<string>> roleAssignmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_roleAssignmentId = WorkflowExpression.Compile(roleAssignmentId, nameof(roleAssignmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/environments/{0}/roleAssignments/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_roleAssignmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<SearchRoleAssignmentsResponse, ApiConnectionActionConfiguration> SearchRoleAssignments(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyscope, Expression<Func<string>> continuationToken = null, Expression<Func<string>> bodyprincipalType = null, Expression<Func<string>> bodyprincipalObjectId = null, Expression<Func<string>> bodypermission = null, Expression<Func<bool>> bodyincludeNestedScopes = null, Expression<Func<bool>> bodyincludeParentScopes = null, Expression<Func<bool>> bodyexpandEnvironmentGroups = null, Expression<Func<bool>> bodyexpandEnvironmentClusters = null, Expression<Func<bool>> bodyexpandSecurityGroups = null, Expression<Func<bool>> bodyincludeVirtualEntraRoleAssignments = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_bodyprincipalType = WorkflowExpression.Compile(bodyprincipalType, nameof(bodyprincipalType), required: false);
            var __workflow_bodyprincipalObjectId = WorkflowExpression.Compile(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            var __workflow_bodypermission = WorkflowExpression.Compile(bodypermission, nameof(bodypermission), required: false);
            var __workflow_bodyincludeNestedScopes = WorkflowExpression.Compile(bodyincludeNestedScopes, nameof(bodyincludeNestedScopes), required: false);
            var __workflow_bodyincludeParentScopes = WorkflowExpression.Compile(bodyincludeParentScopes, nameof(bodyincludeParentScopes), required: false);
            var __workflow_bodyexpandEnvironmentGroups = WorkflowExpression.Compile(bodyexpandEnvironmentGroups, nameof(bodyexpandEnvironmentGroups), required: false);
            var __workflow_bodyexpandEnvironmentClusters = WorkflowExpression.Compile(bodyexpandEnvironmentClusters, nameof(bodyexpandEnvironmentClusters), required: false);
            var __workflow_bodyexpandSecurityGroups = WorkflowExpression.Compile(bodyexpandSecurityGroups, nameof(bodyexpandSecurityGroups), required: false);
            var __workflow_bodyincludeVirtualEntraRoleAssignments = WorkflowExpression.Compile(bodyincludeVirtualEntraRoleAssignments, nameof(bodyincludeVirtualEntraRoleAssignments), required: false);
            return new DeferredBodyAction<SearchRoleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/authorization/listRoleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["scope"] = ExpressionConverter.ConvertO(__workflow_bodyscope);
                if (__workflow_bodyprincipalType != null)
                {
                    body["principalType"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalType);
                    bodypropCount++;
                }

                if (__workflow_bodyprincipalObjectId != null)
                {
                    body["principalObjectId"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalObjectId);
                    bodypropCount++;
                }

                if (__workflow_bodypermission != null)
                {
                    body["permission"] = ExpressionConverter.ConvertO(__workflow_bodypermission);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeNestedScopes != null)
                {
                    if (__workflow_bodyincludeNestedScopes != null)
                    {
                        body["includeNestedScopes"] = ExpressionConverter.ConvertO(__workflow_bodyincludeNestedScopes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeNestedScopes"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeParentScopes != null)
                {
                    if (__workflow_bodyincludeParentScopes != null)
                    {
                        body["includeParentScopes"] = ExpressionConverter.ConvertO(__workflow_bodyincludeParentScopes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeParentScopes"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpandEnvironmentGroups != null)
                {
                    if (__workflow_bodyexpandEnvironmentGroups != null)
                    {
                        body["expandEnvironmentGroups"] = ExpressionConverter.ConvertO(__workflow_bodyexpandEnvironmentGroups);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expandEnvironmentGroups"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpandEnvironmentClusters != null)
                {
                    if (__workflow_bodyexpandEnvironmentClusters != null)
                    {
                        body["expandEnvironmentClusters"] = ExpressionConverter.ConvertO(__workflow_bodyexpandEnvironmentClusters);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expandEnvironmentClusters"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyexpandSecurityGroups != null)
                {
                    if (__workflow_bodyexpandSecurityGroups != null)
                    {
                        body["expandSecurityGroups"] = ExpressionConverter.ConvertO(__workflow_bodyexpandSecurityGroups);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["expandSecurityGroups"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeVirtualEntraRoleAssignments != null)
                {
                    if (__workflow_bodyincludeVirtualEntraRoleAssignments != null)
                    {
                        body["includeVirtualEntraRoleAssignments"] = ExpressionConverter.ConvertO(__workflow_bodyincludeVirtualEntraRoleAssignments);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeVirtualEntraRoleAssignments"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchRoleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse, ApiConnectionActionConfiguration> ListRoleAssignments(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleAssignmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/authorization/roleAssignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RoleAssignmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleAssignmentResponse, ApiConnectionActionConfiguration> CreateRoleAssignment(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyprincipalObjectId = null, Expression<Func<string>> bodyroleDefinitionId = null, Expression<Func<string>> bodyscope = null, Expression<Func<string>> bodyprincipalType = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyprincipalObjectId = WorkflowExpression.Compile(bodyprincipalObjectId, nameof(bodyprincipalObjectId), required: false);
            var __workflow_bodyroleDefinitionId = WorkflowExpression.Compile(bodyroleDefinitionId, nameof(bodyroleDefinitionId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            var __workflow_bodyprincipalType = WorkflowExpression.Compile(bodyprincipalType, nameof(bodyprincipalType), required: false);
            return new DeferredBodyAction<RoleAssignmentResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRoleAssignment(Expression<Func<string>> roleAssignmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_roleAssignmentId = WorkflowExpression.Compile(roleAssignmentId, nameof(roleAssignmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/authorization/roleAssignments/{0}", __workflow_roleAssignmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RoleDefinitionResponse, ApiConnectionActionConfiguration> ListRoleDefinitions(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RoleDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/authorization/roleDefinitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RoleDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListConnectionsResponse, ApiConnectionActionConfiguration> ListConnections(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListConnectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connectivity/environments/{0}/connections", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListConnectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListConnectorsResponse, ApiConnectionActionConfiguration> ListConnectors(Expression<Func<string>> environmentId, Expression<Func<string>> filter, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListConnectorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connectivity/environments/{0}/connectors", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListConnectorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<GetConnectorByIdResponse, ApiConnectionActionConfiguration> GetConnectorById(Expression<Func<string>> environmentId, Expression<Func<string>> connectorId, Expression<Func<string>> filter, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_connectorId = WorkflowExpression.Compile(connectorId, nameof(connectorId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<GetConnectorByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connectivity/environments/{0}/connectors/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_connectorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<GetConnectorByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadAgentChannelManifest(Expression<Func<string>> environmentId, Expression<Func<string>> agentId, Expression<Func<string>> channelName, Expression<Func<string>> apiVersion, Expression<Func<bool>> includeAgentSchema = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_channelName = WorkflowExpression.Compile(channelName, nameof(channelName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_includeAgentSchema = WorkflowExpression.Compile(includeAgentSchema, nameof(includeAgentSchema), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/agents/{1}/channels/{2}/download", __workflow_environmentId.WithUrlEncoding(1), __workflow_agentId.WithUrlEncoding(1), __workflow_channelName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAgentSchema"] = Convert.ToString(false);
                if (__workflow_includeAgentSchema != null)
                    callPayload.Queries["includeAgentSchema"] = ExpressionConverter.Convert(__workflow_includeAgentSchema);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCopilotAgent(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botAdminOperations", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReassignCopilotAgent(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodynewOwnerAadUserId)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodynewOwnerAadUserId = WorkflowExpression.Compile(bodynewOwnerAadUserId, nameof(bodynewOwnerAadUserId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botAdminOperations/reassign", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["NewOwnerAadUserId"] = ExpressionConverter.ConvertO(__workflow_bodynewOwnerAadUserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus, ApiConnectionActionConfiguration> GetBotQuarantineStatus(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus, ApiConnectionActionConfiguration> SetBotAsQuarantined(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsQuarantined", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BotQuarantineStatus, ApiConnectionActionConfiguration> SetBotAsUnquarantined(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BotQuarantineStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/botQuarantine/SetAsUnquarantined", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BotQuarantineStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ConnectorConsentBypassResponse, ApiConnectionActionConfiguration> GetConnectorConsentBypass(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ConnectorConsentBypassResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/connectorConsentBypass", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ConnectorConsentBypassResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ConnectorConsentBypassResponse, ApiConnectionActionConfiguration> SetConnectorConsentBypass(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion, Expression<Func<bool>> bodyadminConsentBypass)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyadminConsentBypass = WorkflowExpression.Compile(bodyadminConsentBypass, nameof(bodyadminConsentBypass), required: true);
            return new DeferredBodyAction<ConnectorConsentBypassResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/connectorConsentBypass", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["adminConsentBypass"] = ExpressionConverter.ConvertO(__workflow_bodyadminConsentBypass);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConnectorConsentBypassResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestRunCollection, ApiConnectionActionConfiguration> ListMakerEvaluationTestRuns(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TestRunCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testruns", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TestRunCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestRun, ApiConnectionActionConfiguration> GetMakerEvaluationTestRun(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> testRunId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_testRunId = WorkflowExpression.Compile(testRunId, nameof(testRunId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TestRun, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testruns/{2}", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1), __workflow_testRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TestRun>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadMakerEvaluationSnapshot(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> testRunId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_testRunId = WorkflowExpression.Compile(testRunId, nameof(testRunId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testruns/{2}/snapshot", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1), __workflow_testRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestSetCollection, ApiConnectionActionConfiguration> ListMakerEvaluationTestSets(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TestSetCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testsets", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TestSetCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TestSet, ApiConnectionActionConfiguration> GetMakerEvaluationTestSet(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> testSetId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_testSetId = WorkflowExpression.Compile(testSetId, nameof(testSetId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TestSet, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testsets/{2}", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1), __workflow_testSetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TestSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RunStatusResponse, ApiConnectionActionConfiguration> RunMakerEvaluationTestSet(Expression<Func<string>> environmentId, Expression<Func<string>> botId, Expression<Func<string>> testSetId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyevaluationRunName = null, Expression<Func<string>> bodymcsConnectionId = null, Expression<Func<bool>> bodyrunOnPublishedBot = null, Expression<Func<ToolsConnections[]>> bodytoolsConnections = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_testSetId = WorkflowExpression.Compile(testSetId, nameof(testSetId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyevaluationRunName = WorkflowExpression.Compile(bodyevaluationRunName, nameof(bodyevaluationRunName), required: false);
            var __workflow_bodymcsConnectionId = WorkflowExpression.Compile(bodymcsConnectionId, nameof(bodymcsConnectionId), required: false);
            var __workflow_bodyrunOnPublishedBot = WorkflowExpression.Compile(bodyrunOnPublishedBot, nameof(bodyrunOnPublishedBot), required: false);
            var __workflow_bodytoolsConnections = WorkflowExpression.Compile(bodytoolsConnections, nameof(bodytoolsConnections), required: false);
            return new DeferredBodyAction<RunStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/environments/{0}/bots/{1}/api/makerevaluation/testsets/{2}/run", __workflow_environmentId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1), __workflow_testSetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyevaluationRunName != null)
                {
                    body["evaluationRunName"] = ExpressionConverter.ConvertO(__workflow_bodyevaluationRunName);
                    bodypropCount++;
                }

                if (__workflow_bodymcsConnectionId != null)
                {
                    body["mcsConnectionId"] = ExpressionConverter.ConvertO(__workflow_bodymcsConnectionId);
                    bodypropCount++;
                }

                if (__workflow_bodyrunOnPublishedBot != null)
                {
                    if (__workflow_bodyrunOnPublishedBot != null)
                    {
                        body["runOnPublishedBot"] = ExpressionConverter.ConvertO(__workflow_bodyrunOnPublishedBot);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["runOnPublishedBot"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodytoolsConnections != null)
                {
                    body["toolsConnections"] = ExpressionConverter.ConvertO(__workflow_bodytoolsConnections);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RunStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GenerateLicensingReport(Expression<Func<reportNameInput>> reportName, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyendDate, Expression<Func<string>> bodystartDate, Expression<Func<bodygranularityInput>> bodygranularity = null)
        {
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodygranularity = WorkflowExpression.Compile(bodygranularity, nameof(bodygranularity), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/licensing/reports/{0}", __workflow_reportName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                if (__workflow_bodygranularity != null)
                {
                    if (__workflow_bodygranularity != null)
                    {
                        body["granularity"] = ExpressionConverter.ConvertO(__workflow_bodygranularity);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["granularity"] = "Daily";
                    bodypropCount++;
                }

                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadLicensingReportFile(Expression<Func<reportNameInput>> reportName, Expression<Func<string>> fileName, Expression<Func<string>> apiVersion)
        {
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/licensing/reports/{0}/files/{1}", __workflow_reportName.WithUrlEncoding(1), __workflow_fileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CopilotStudioLicensingReportOperation, ApiConnectionActionConfiguration> GetLicensingReportOperation(Expression<Func<reportNameInput>> reportName, Expression<Func<string>> operationId, Expression<Func<string>> apiVersion)
        {
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: true);
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CopilotStudioLicensingReportOperation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/copilotstudio/licensing/reports/{0}/operations/{1}", __workflow_reportName.WithUrlEncoding(1), __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<CopilotStudioLicensingReportOperation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails, ApiConnectionActionConfiguration> GetEnvironmentGroupOperation(Expression<Func<string>> operationId, Expression<Func<string>> apiVersion)
        {
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroupOperations/{0}", __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails, ApiConnectionActionConfiguration> DeleteEnvironmentGroup(Expression<Func<string>> groupId, Expression<Func<string>> apiVersion)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails, ApiConnectionActionConfiguration> AddEnvironmentToGroup(Expression<Func<string>> groupId, Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroups/{0}/addEnvironment/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ProblemDetails, ApiConnectionActionConfiguration> RemoveEnvironmentFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ProblemDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environmentGroups/{0}/removeEnvironment/{1}", __workflow_groupId.WithUrlEncoding(1), __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentList, ApiConnectionActionConfiguration> ListEnvironmentsForUser(Expression<Func<string>> apiVersion, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<EnvironmentList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/environmentmanagement/environments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<EnvironmentList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentResponse, ApiConnectionActionConfiguration> GetEnvironmentByIdForUser(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> select = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<EnvironmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environmentmanagement/environments/{0}", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<EnvironmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy, ApiConnectionActionConfiguration> CreateRuleBasedPolicy(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<RuleSet[]>> bodyruleSets = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyruleSets = WorkflowExpression.Compile(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<Policy, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ListPolicyResponse, ApiConnectionActionConfiguration> ListRuleBasedPolicies(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListPolicyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy, ApiConnectionActionConfiguration> GetRuleBasedPolicyById(Expression<Func<string>> policyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<Policy, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<Policy>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignment, ApiConnectionActionConfiguration> UpdateRuleBasedPolicyById(Expression<Func<string>> policyId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<RuleSet[]>> bodyruleSets = null)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyruleSets = WorkflowExpression.Compile(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<RuleAssignment, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy, ApiConnectionActionConfiguration> PatchRuleBasedPolicy(Expression<Func<string>> policyId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<RuleSet[]>> bodyruleSets = null)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyruleSets = WorkflowExpression.Compile(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<Policy, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration> ListRuleAssignmentsByPolicyId(Expression<Func<string>> policyId, Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}/assignments", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<Policy, ApiConnectionActionConfiguration> RemoveRuleFromRuleBasedPolicy(Expression<Func<string>> policyId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<RuleSet[]>> bodyruleSets = null)
        {
            var __workflow_policyId = WorkflowExpression.Compile(policyId, nameof(policyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyruleSets = WorkflowExpression.Compile(bodyruleSets, nameof(bodyruleSets), required: false);
            return new DeferredBodyAction<Policy, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/{0}/removeRule", __workflow_policyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration> ListRuleAssignments(Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/governance/ruleBasedPolicies/assignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration> ListRuleAssignmentsByEnvironmentGroupId(Expression<Func<string>> environmentGroupId, Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentGroupId = WorkflowExpression.Compile(environmentGroupId, nameof(environmentGroupId), required: true);
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/environmentGroups/{0}/assignments", __workflow_environmentGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration> ListRuleAssignmentsByEnvironmentId(Expression<Func<string>> environmentId, Expression<Func<bool>> includeRuleSetCounts, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_includeRuleSetCounts = WorkflowExpression.Compile(includeRuleSetCounts, nameof(includeRuleSetCounts), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<RuleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/ruleBasedPolicies/environments/{0}/assignments", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeRuleSetCounts"] = ExpressionConverter.Convert(__workflow_includeRuleSetCounts);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<RuleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CrossTenantConnectionReportsResponseWithOdataContinuation, ApiConnectionActionConfiguration> ListCrossTenantConnectionReports(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CrossTenantConnectionReportsResponseWithOdataContinuation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/governance/crossTenantConnectionReports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<CrossTenantConnectionReportsResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CrossTenantConnectionReport, ApiConnectionActionConfiguration> GetCrossTenantConnectionReport(Expression<Func<string>> reportId, Expression<Func<string>> apiVersion)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<CrossTenantConnectionReport, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/governance/crossTenantConnectionReports/{0}", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<CrossTenantConnectionReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantEntitlementResponseModel, ApiConnectionActionConfiguration> GetEntitlement(Expression<Func<string>> entitlementId, Expression<Func<string>> apiVersion)
        {
            var __workflow_entitlementId = WorkflowExpression.Compile(entitlementId, nameof(entitlementId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantEntitlementResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/entitlements/{0}", __workflow_entitlementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TenantEntitlementResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantEntitlementLicenseTrendResponseModelPagedResponse, ApiConnectionActionConfiguration> GetTenantLicenseTrends(Expression<Func<string>> entitlementId, Expression<Func<string>> fromDate, Expression<Func<string>> toDate, Expression<Func<string>> apiVersion, Expression<Func<int>> top = null, Expression<Func<string>> filter = null)
        {
            var __workflow_entitlementId = WorkflowExpression.Compile(entitlementId, nameof(entitlementId), required: true);
            var __workflow_fromDate = WorkflowExpression.Compile(fromDate, nameof(fromDate), required: true);
            var __workflow_toDate = WorkflowExpression.Compile(toDate, nameof(toDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<TenantEntitlementLicenseTrendResponseModelPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/entitlements/{0}/licenses", __workflow_entitlementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fromDate"] = ExpressionConverter.Convert(__workflow_fromDate);
                callPayload.Queries["toDate"] = ExpressionConverter.Convert(__workflow_toDate);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TenantEntitlementLicenseTrendResponseModelPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceThresholdModel[], ApiConnectionActionConfiguration> GetAllResourceThresholds(Expression<Func<string>> entitlementId, Expression<Func<string>> apiVersion)
        {
            var __workflow_entitlementId = WorkflowExpression.Compile(entitlementId, nameof(entitlementId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ResourceThresholdModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/entitlements/{0}/resourceThresholds", __workflow_entitlementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ResourceThresholdModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EnvironmentEntitlementResponseModel[], ApiConnectionActionConfiguration> GetManyEnvironmentEntitlements(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> filter = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<EnvironmentEntitlementResponseModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/entitlements", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<EnvironmentEntitlementResponseModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceThresholdModel, ApiConnectionActionConfiguration> UpsertResourceThreshold(Expression<Func<string>> environmentId, Expression<Func<string>> entitlementId, Expression<Func<string>> resourceId, Expression<Func<string>> apiVersion, Expression<Func<bool>> bodystopResource = null, Expression<Func<int>> bodylimit = null, Expression<Func<bool>> bodystopIfOverCapacity = null, Expression<Func<bool>> bodynotifyIfOverCapacity = null, Expression<Func<int>> bodynotificationThreshold = null, Expression<Func<double>> bodyresourceConsumption = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_entitlementId = WorkflowExpression.Compile(entitlementId, nameof(entitlementId), required: true);
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodystopResource = WorkflowExpression.Compile(bodystopResource, nameof(bodystopResource), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            var __workflow_bodystopIfOverCapacity = WorkflowExpression.Compile(bodystopIfOverCapacity, nameof(bodystopIfOverCapacity), required: false);
            var __workflow_bodynotifyIfOverCapacity = WorkflowExpression.Compile(bodynotifyIfOverCapacity, nameof(bodynotifyIfOverCapacity), required: false);
            var __workflow_bodynotificationThreshold = WorkflowExpression.Compile(bodynotificationThreshold, nameof(bodynotificationThreshold), required: false);
            var __workflow_bodyresourceConsumption = WorkflowExpression.Compile(bodyresourceConsumption, nameof(bodyresourceConsumption), required: false);
            return new DeferredBodyAction<ResourceThresholdModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/entitlements/{1}/resources/{2}/threshold", __workflow_environmentId.WithUrlEncoding(1), __workflow_entitlementId.WithUrlEncoding(1), __workflow_resourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystopResource != null)
                {
                    body["stopResource"] = ExpressionConverter.ConvertO(__workflow_bodystopResource);
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (__workflow_bodystopIfOverCapacity != null)
                {
                    body["stopIfOverCapacity"] = ExpressionConverter.ConvertO(__workflow_bodystopIfOverCapacity);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyIfOverCapacity != null)
                {
                    body["notifyIfOverCapacity"] = ExpressionConverter.ConvertO(__workflow_bodynotifyIfOverCapacity);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationThreshold != null)
                {
                    body["notificationThreshold"] = ExpressionConverter.ConvertO(__workflow_bodynotificationThreshold);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceConsumption != null)
                {
                    body["resourceConsumption"] = ExpressionConverter.ConvertO(__workflow_bodyresourceConsumption);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResourceThresholdModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationByEnvironmentModel[], ApiConnectionActionConfiguration> ListAllocationsByEnvironment(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AllocationByEnvironmentModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/allocationsByEnvironment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AllocationByEnvironmentModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationByEnvironmentModel, ApiConnectionActionConfiguration> UpdateAllocationsByEnvironment(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyenvironmentId = null, Expression<Func<CurrencyAllocationModel[]>> bodycurrencyAllocations = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyenvironmentId = WorkflowExpression.Compile(bodyenvironmentId, nameof(bodyenvironmentId), required: false);
            var __workflow_bodycurrencyAllocations = WorkflowExpression.Compile(bodycurrencyAllocations, nameof(bodycurrencyAllocations), required: false);
            return new DeferredBodyAction<AllocationByEnvironmentModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/allocationsByEnvironment";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyenvironmentId != null)
                {
                    body["environmentId"] = ExpressionConverter.ConvertO(__workflow_bodyenvironmentId);
                    bodypropCount++;
                }

                if (__workflow_bodycurrencyAllocations != null)
                {
                    body["currencyAllocations"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyAllocations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AllocationByEnvironmentModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationByEnvironmentModel, ApiConnectionActionConfiguration> GetAllocationsByEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AllocationByEnvironmentModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/allocationsByEnvironment/{0}", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AllocationByEnvironmentModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModelResponseWithOdataContinuation, ApiConnectionActionConfiguration> ListBillingPolicies(Expression<Func<string>> apiVersion, Expression<Func<string>> top = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModelResponseWithOdataContinuation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/billingPolicies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModelResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration> CreateBillingPolicy(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodybillingInstrumentsubscriptionId = null, Expression<Func<string>> bodybillingInstrumentresourceGroup = null, Expression<Func<string>> bodybillingInstrumentid = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodybillingInstrumentsubscriptionId = WorkflowExpression.Compile(bodybillingInstrumentsubscriptionId, nameof(bodybillingInstrumentsubscriptionId), required: false);
            var __workflow_bodybillingInstrumentresourceGroup = WorkflowExpression.Compile(bodybillingInstrumentresourceGroup, nameof(bodybillingInstrumentresourceGroup), required: false);
            var __workflow_bodybillingInstrumentid = WorkflowExpression.Compile(bodybillingInstrumentid, nameof(bodybillingInstrumentid), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration> GetBillingPolicy(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration> UpdateBillingPolicy(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteBillingPolicy(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation, ApiConnectionActionConfiguration> ListBillingPolicyEnvironments(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/environments", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1ResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyEnvironmentResponseModelV1, ApiConnectionActionConfiguration> GetBillingPolicyEnvironment(Expression<Func<string>> billingPolicyId, Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyEnvironmentResponseModelV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/environments/{1}", __workflow_billingPolicyId.WithUrlEncoding(1), __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyEnvironmentResponseModelV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddBillingPolicyEnvironment(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion, Expression<Func<string[]>> bodyenvironmentIds = null)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyenvironmentIds = WorkflowExpression.Compile(bodyenvironmentIds, nameof(bodyenvironmentIds), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveBillingPolicyEnvironment(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion, Expression<Func<string[]>> bodyenvironmentIds = null)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyenvironmentIds = WorkflowExpression.Compile(bodyenvironmentIds, nameof(bodyenvironmentIds), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration> RefreshProvisioningStatus(Expression<Func<string>> billingPolicyId, Expression<Func<string>> apiVersion)
        {
            var __workflow_billingPolicyId = WorkflowExpression.Compile(billingPolicyId, nameof(billingPolicyId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/billingPolicies/{0}/refreshProvisioningStatus", __workflow_billingPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1, ApiConnectionActionConfiguration> GetCurrencyAllocationByEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<AllocationsByEnvironmentResponseModelV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/allocations", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AllocationsByEnvironmentResponseModelV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationsByEnvironmentResponseModelV1, ApiConnectionActionConfiguration> PatchCurrencyAllocationByEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<CurrencyAllocationRequestModelV1[]>> bodycurrencyAllocations = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodycurrencyAllocations = WorkflowExpression.Compile(bodycurrencyAllocations, nameof(bodycurrencyAllocations), required: false);
            return new DeferredBodyAction<AllocationsByEnvironmentResponseModelV1, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration> GetEnvironmentBillingPolicy(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<BillingPolicyResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/environments/{0}/billingPolicy", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<BillingPolicyResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModelResponseWithOdataContinuation, ApiConnectionActionConfiguration> ListISVContracts(Expression<Func<string>> apiVersion, Expression<Func<string>> top = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<IsvContractResponseModelResponseWithOdataContinuation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/isvContracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<IsvContractResponseModelResponseWithOdataContinuation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel, ApiConnectionActionConfiguration> CreateISVContract(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname, Expression<Func<string>> bodygeo, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyconsumertenantId = null, Expression<Func<bool>> bodyconditionsapiFilterallowOtherPremiumConnectors = null, Expression<Func<BillingPolicyConditionsApiModel[]>> bodyconditionsapiFilterrequiredApis = null, Expression<Func<string>> bodybillingInstrumentsubscriptionId = null, Expression<Func<string>> bodybillingInstrumentresourceGroup = null, Expression<Func<string>> bodybillingInstrumentid = null, Expression<Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput>> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
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
            return new DeferredBodyAction<IsvContractResponseModel, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel, ApiConnectionActionConfiguration> GetISVContract(Expression<Func<string>> isvContractId, Expression<Func<string>> apiVersion)
        {
            var __workflow_isvContractId = WorkflowExpression.Compile(isvContractId, nameof(isvContractId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<IsvContractResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/isvContracts/{0}", __workflow_isvContractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<IsvContractResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<IsvContractResponseModel, ApiConnectionActionConfiguration> UpdateISVContract(Expression<Func<string>> isvContractId, Expression<Func<string>> apiVersion, Expression<Func<string>> bodyname = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodyconditionsapiFilterallowOtherPremiumConnectors = null, Expression<Func<BillingPolicyConditionsApiModel[]>> bodyconditionsapiFilterrequiredApis = null, Expression<Func<bodypowerAutomatePolicycloudFlowRunsPayAsYouGoStateInput>> bodypowerAutomatePolicycloudFlowRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowUnattendedRunsPayAsYouGoState = null, Expression<Func<bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoStateInput>> bodypowerAutomatePolicydesktopFlowAttendedRunsPayAsYouGoState = null)
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
            return new DeferredBodyAction<IsvContractResponseModel, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteISVContract(Expression<Func<string>> isvContractId, Expression<Func<string>> apiVersion)
        {
            var __workflow_isvContractId = WorkflowExpression.Compile(isvContractId, nameof(isvContractId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/isvContracts/{0}", __workflow_isvContractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<TenantCapacityDetailsModel, ApiConnectionActionConfiguration> GetTenantCapacityDetails(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<TenantCapacityDetailsModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/tenantCapacity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<TenantCapacityDetailsModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<CurrencyReportV2[], ApiConnectionActionConfiguration> ListCurrencyReports(Expression<Func<string>> apiVersion, Expression<Func<bool>> includeAllocations = null, Expression<Func<bool>> includeConsumptions = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_includeAllocations = WorkflowExpression.Compile(includeAllocations, nameof(includeAllocations), required: false);
            var __workflow_includeConsumptions = WorkflowExpression.Compile(includeConsumptions, nameof(includeConsumptions), required: false);
            return new DeferredBodyAction<CurrencyReportV2[], ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceRecord, ApiConnectionActionConfiguration> GetUserPerFlowCapacitySource(Expression<Func<string>> startDate, Expression<Func<string>> apiVersion, Expression<Func<string>> endDate = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> userId = null, Expression<Func<string>> flowContext = null, Expression<Func<string>> flowLicenseCategorization = null, Expression<Func<string>> resourceId = null, Expression<Func<string>> environmentId = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_flowContext = WorkflowExpression.Compile(flowContext, nameof(flowContext), required: false);
            var __workflow_flowLicenseCategorization = WorkflowExpression.Compile(flowLicenseCategorization, nameof(flowLicenseCategorization), required: false);
            var __workflow_resourceId = WorkflowExpression.Compile(resourceId, nameof(resourceId), required: false);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: false);
            return new DeferredBodyAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_flowContext != null)
                    callPayload.Queries["flowContext"] = ExpressionConverter.Convert(__workflow_flowContext);
                if (__workflow_flowLicenseCategorization != null)
                    callPayload.Queries["flowLicenseCategorization"] = ExpressionConverter.Convert(__workflow_flowLicenseCategorization);
                if (__workflow_resourceId != null)
                    callPayload.Queries["resourceId"] = ExpressionConverter.Convert(__workflow_resourceId);
                if (__workflow_environmentId != null)
                    callPayload.Queries["environmentId"] = ExpressionConverter.Convert(__workflow_environmentId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord, ApiConnectionActionConfiguration> GetUserPerFlowCapacitySourceFlowContextSummary(Expression<Func<string>> startDate, Expression<Func<string>> apiVersion, Expression<Func<string>> endDate = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> environmentId = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: false);
            return new DeferredBodyAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource/FlowContextSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_environmentId != null)
                    callPayload.Queries["environmentId"] = ExpressionConverter.Convert(__workflow_environmentId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord, ApiConnectionActionConfiguration> GetUserPerFlowCapacitySourceFlowContextSummaryForUserId(Expression<Func<string>> userId, Expression<Func<string>> startDate, Expression<Func<string>> apiVersion, Expression<Func<string>> endDate = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> environmentId = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: false);
            return new DeferredBodyAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/UserPerFlowCapacitySource/FlowContextSummary/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_environmentId != null)
                    callPayload.Queries["environmentId"] = ExpressionConverter.Convert(__workflow_environmentId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceFlowContextRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<UserPerFlowCapacitySourceTenantContextSummaryRecord[], ApiConnectionActionConfiguration> GetUserPerFlowCapacitySourceTenantContextSummary(Expression<Func<string>> startDate, Expression<Func<string>> apiVersion, Expression<Func<string>> endDate = null, Expression<Func<string>> environmentId = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: false);
            return new DeferredBodyAction<UserPerFlowCapacitySourceTenantContextSummaryRecord[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource/TenantContextSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_environmentId != null)
                    callPayload.Queries["environmentId"] = ExpressionConverter.Convert(__workflow_environmentId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<UserPerFlowCapacitySourceTenantContextSummaryRecord[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord, ApiConnectionActionConfiguration> GetUserPerFlowCapacitySourceUserContextSummary(Expression<Func<string>> startDate, Expression<Func<string>> apiVersion, Expression<Func<string>> endDate = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> environmentId = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: false);
            return new DeferredBodyAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/UserPerFlowCapacitySource/UserContextSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_environmentId != null)
                    callPayload.Queries["environmentId"] = ExpressionConverter.Convert(__workflow_environmentId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord, ApiConnectionActionConfiguration> GetUserPerFlowCapacitySourceUserContextSummaryForUserId(Expression<Func<string>> userId, Expression<Func<string>> startDate, Expression<Func<string>> apiVersion, Expression<Func<string>> endDate = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> environmentId = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: false);
            return new DeferredBodyAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licensing/UserPerFlowCapacitySource/UserContextSummary/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["pageNumber"] = Convert.ToString(1);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["pageSize"] = Convert.ToString(100);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_environmentId != null)
                    callPayload.Queries["environmentId"] = ExpressionConverter.Convert(__workflow_environmentId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerPlatformRequestSnapshotResultWithoutPagesUserPerFlowCapacitySourceUserContextRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceArrayPowerApp, ApiConnectionActionConfiguration> GetAdminApps(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ResourceArrayPowerApp, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<PowerApp, ApiConnectionActionConfiguration> GetAdminApp(Expression<Func<string>> environmentId, Expression<Func<string>> app, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_app = WorkflowExpression.Compile(app, nameof(app), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<PowerApp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/powerapps/environments/{0}/apps/{1}", __workflow_environmentId.WithUrlEncoding(1), __workflow_app.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<PowerApp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<ResourceQueryResponse, ApiConnectionActionConfiguration> QueryResources(Expression<Func<string>> apiVersion, Expression<Func<string>> bodytableName, Expression<Func<Clause[]>> bodyclauses, Expression<Func<int>> bodyoptionstop = null, Expression<Func<int>> bodyoptionsskip = null, Expression<Func<string>> bodyoptionsskipToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodytableName = WorkflowExpression.Compile(bodytableName, nameof(bodytableName), required: true);
            var __workflow_bodyclauses = WorkflowExpression.Compile(bodyclauses, nameof(bodyclauses), required: true);
            var __workflow_bodyoptionstop = WorkflowExpression.Compile(bodyoptionstop, nameof(bodyoptionstop), required: false);
            var __workflow_bodyoptionsskip = WorkflowExpression.Compile(bodyoptionsskip, nameof(bodyoptionsskip), required: false);
            var __workflow_bodyoptionsskipToken = WorkflowExpression.Compile(bodyoptionsskipToken, nameof(bodyoptionsskipToken), required: false);
            return new DeferredBodyAction<ResourceQueryResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ApplyAdminRole(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/usermanagement/environments/{0}/user/applyAdminRole", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrFlowRunsResponse, ApiConnectionActionConfiguration> GetFlowRunActionsForDsr(Expression<Func<string>> aiFlowId, Expression<Func<string>> runId, Expression<Func<string>> apiVersion, Expression<Func<int>> continuationToken = null)
        {
            var __workflow_aiFlowId = WorkflowExpression.Compile(aiFlowId, nameof(aiFlowId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrFlowRunsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/aiFlows/{0}/runs/{1}/actions", __workflow_aiFlowId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrFlowRunsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetApprovals(Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflowsagent/approvals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteApproval(Expression<Func<string>> approvalId, Expression<Func<string>> apiVersion)
        {
            var __workflow_approvalId = WorkflowExpression.Compile(approvalId, nameof(approvalId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/approvals/{0}", __workflow_approvalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetConnections(Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflowsagent/connections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConnection(Expression<Func<string>> connectionIdentifier, Expression<Func<string>> apiVersion)
        {
            var __workflow_connectionIdentifier = WorkflowExpression.Compile(connectionIdentifier, nameof(connectionIdentifier), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/connections/{0}", __workflow_connectionIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrConversationTranscriptsResponse, ApiConnectionActionConfiguration> GetConversationTranscriptsForDsr(Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrConversationTranscriptsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflowsagent/conversationTranscripts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrConversationTranscriptsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrFlowRunsResponse, ApiConnectionActionConfiguration> GetFlowRunActionsWithEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> aiFlowId, Expression<Func<string>> runId, Expression<Func<string>> apiVersion, Expression<Func<int>> continuationToken = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_aiFlowId = WorkflowExpression.Compile(aiFlowId, nameof(aiFlowId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrFlowRunsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/environments/{0}/aiFlows/{1}/runs/{2}/actions", __workflow_environmentId.WithUrlEncoding(1), __workflow_aiFlowId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrFlowRunsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrConversationTranscriptsResponse, ApiConnectionActionConfiguration> GetConversationTranscriptsWithEnvironment(Expression<Func<string>> environmentId, Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrConversationTranscriptsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/environments/{0}/conversationTranscripts", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrConversationTranscriptsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetFlowRunsNonSingleton(Expression<Func<string>> environmentId, Expression<Func<string>> flowId, Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/environments/{0}/flows/{1}/flowRuns", __workflow_environmentId.WithUrlEncoding(1), __workflow_flowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetRunHistoryDataNonSingleton(Expression<Func<string>> environmentId, Expression<Func<string>> flowId, Expression<Func<string>> runId, Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/environments/{0}/flows/{1}/runs/{2}/runHistoryData", __workflow_environmentId.WithUrlEncoding(1), __workflow_flowId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetFlows(Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflowsagent/flows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFlow(Expression<Func<string>> flowId, Expression<Func<string>> apiVersion)
        {
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/flows/{0}", __workflow_flowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetFlowRunsSingleton(Expression<Func<string>> flowId, Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/flows/{0}/flowRuns", __workflow_flowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetRunHistoryData(Expression<Func<string>> flowId, Expression<Func<string>> runId, Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/flows/{0}/runs/{1}/runHistoryData", __workflow_flowId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<DsrPagedResponse, ApiConnectionActionConfiguration> GetPrompts(Expression<Func<string>> apiVersion, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<DsrPagedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflowsagent/prompts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<DsrPagedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletePrompt(Expression<Func<string>> promptId, Expression<Func<string>> apiVersion)
        {
            var __workflow_promptId = WorkflowExpression.Compile(promptId, nameof(promptId), required: true);
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflowsagent/prompts/{0}", __workflow_promptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<MCPQueryResponse, ApiConnectionActionConfiguration> McpEnvironmentManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<MCPQueryResponse, ApiConnectionActionConfiguration> McpGovernance(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/Governance";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<AllocationAvailabilityResponseModel, ApiConnectionActionConfiguration> GetAllocationsAvailability(Expression<Func<string>> apiVersion, Expression<Func<string>> filter = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<AllocationAvailabilityResponseModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/allocationsV2/availability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<AllocationAvailabilityResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<FinOpsLicenseSummaryV2Response, ApiConnectionActionConfiguration> GetFinOpsLicenseSummary(Expression<Func<string>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<FinOpsLicenseSummaryV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/FinOpsLicensing/GetLicenseSummaryV2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<FinOpsLicenseSummaryV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<EntitlementReservedResponseModel[], ApiConnectionActionConfiguration> GetManyEntitlementsReserved(Expression<Func<string>> apiVersion, Expression<Func<string>> filter = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<EntitlementReservedResponseModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/allocationsV2/entitlements/reserved";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<EntitlementReservedResponseModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerplatformadminv2")]
        public IBodyWorkflowAction<NeptuneOperationResult, ApiConnectionActionConfiguration> PutAllocations(Expression<Func<string>> apiVersion, Expression<Func<string>> bodyscopetenantId = null, Expression<Func<string>> bodyscopeenvironmentGroupId = null, Expression<Func<string>> bodyscopeenvironmentId = null, Expression<Func<string>> bodyscoperesourceId = null, Expression<Func<string>> bodyscopeuserId = null, Expression<Func<string>> bodyscopeuserGroupId = null, Expression<Func<EntitlementAllocationModel[]>> bodyallocatedEntitlements = null)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodyscopetenantId = WorkflowExpression.Compile(bodyscopetenantId, nameof(bodyscopetenantId), required: false);
            var __workflow_bodyscopeenvironmentGroupId = WorkflowExpression.Compile(bodyscopeenvironmentGroupId, nameof(bodyscopeenvironmentGroupId), required: false);
            var __workflow_bodyscopeenvironmentId = WorkflowExpression.Compile(bodyscopeenvironmentId, nameof(bodyscopeenvironmentId), required: false);
            var __workflow_bodyscoperesourceId = WorkflowExpression.Compile(bodyscoperesourceId, nameof(bodyscoperesourceId), required: false);
            var __workflow_bodyscopeuserId = WorkflowExpression.Compile(bodyscopeuserId, nameof(bodyscopeuserId), required: false);
            var __workflow_bodyscopeuserGroupId = WorkflowExpression.Compile(bodyscopeuserGroupId, nameof(bodyscopeuserGroupId), required: false);
            var __workflow_bodyallocatedEntitlements = WorkflowExpression.Compile(bodyallocatedEntitlements, nameof(bodyallocatedEntitlements), required: false);
            return new DeferredBodyAction<NeptuneOperationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licensing/allocationsV2";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                var scopeObject = new JObject();
                var scopeObjectpropCount = 0;
                if (__workflow_bodyscopetenantId != null)
                {
                    scopeObject["tenantId"] = ExpressionConverter.ConvertO(__workflow_bodyscopetenantId);
                    scopeObjectpropCount++;
                }

                if (__workflow_bodyscopeenvironmentGroupId != null)
                {
                    scopeObject["environmentGroupId"] = ExpressionConverter.ConvertO(__workflow_bodyscopeenvironmentGroupId);
                    scopeObjectpropCount++;
                }

                if (__workflow_bodyscopeenvironmentId != null)
                {
                    scopeObject["environmentId"] = ExpressionConverter.ConvertO(__workflow_bodyscopeenvironmentId);
                    scopeObjectpropCount++;
                }

                if (__workflow_bodyscoperesourceId != null)
                {
                    scopeObject["resourceId"] = ExpressionConverter.ConvertO(__workflow_bodyscoperesourceId);
                    scopeObjectpropCount++;
                }

                if (__workflow_bodyscopeuserId != null)
                {
                    scopeObject["userId"] = ExpressionConverter.ConvertO(__workflow_bodyscopeuserId);
                    scopeObjectpropCount++;
                }

                if (__workflow_bodyscopeuserGroupId != null)
                {
                    scopeObject["userGroupId"] = ExpressionConverter.ConvertO(__workflow_bodyscopeuserGroupId);
                    scopeObjectpropCount++;
                }

                if (scopeObjectpropCount > 0)
                {
                    body["scope"] = scopeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyallocatedEntitlements != null)
                {
                    body["allocatedEntitlements"] = ExpressionConverter.ConvertO(__workflow_bodyallocatedEntitlements);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NeptuneOperationResult>(callPayload);
            });
        }
    }

    public class Powerplatformadminv2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MonitoringHubTriggeredAlertsPollResponse, ApiConnectionTriggerConfiguration> OnAlertTriggered(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<MonitoringHubTriggeredAlertsPollResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/monitoringhub/powerplatform/triggeredAlerts/poll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("1");
                return new ApiConnectionTrigger<MonitoringHubTriggeredAlertsPollResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AdvisorActionResponse
    {
        [JsonProperty("results")]
        public AdvisorActionResult[] Results { get; set; }
    }

    public class AdvisorActionResult
    {
        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

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
        public string ResourceId { get; set; }

        [JsonProperty("resourceOwnerId")]
        public string OwnerId { get; set; }

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
        public string EnvironmentId { get; set; }

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

    public class SearchRoleAssignmentsResponse
    {
        [JsonProperty("value")]
        public SearchRoleAssignmentsResponseValueTypeItem[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class SearchRoleAssignmentsResponseValueTypeItem
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

        [JsonProperty("source")]
        public string Source { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MetricStatus
    {
        Error,
        Fail,
        Pass,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum reportNameInput
    {
        BillingDetailsPerEnvironment,
        FeatureDetailsPerResource
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygranularityInput
    {
        Daily,
        Summary
    }

    public class CopilotStudioLicensingReportOperation
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("status")]
        public CopilotStudioLicensingReportOperationStatus Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CopilotStudioLicensingReportOperationStatus
    {
        Running,
        Succeeded,
        Failed
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class TenantEntitlementResponseModel
    {
        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("productCategories")]
        public ProductCategory[] ProductCategories { get; set; }

        [JsonProperty("entitlement")]
        public TenantEntitlementDetailServiceModel Entitlement { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LicenseTier
    {
        NotSpecified,
        Paid,
        Trial,
        Internal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvironmentScenario
    {
        None,
        OfficeAi,
        M365CopilotChat,
        M365CompliantContainer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvironmentDisasterRecoveryState
    {
        NotSpecified,
        Enabled,
        Ready,
        Disabled,
        Unavailable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class EnforcementRule
    {
        [JsonProperty("ruleType")]
        public EnforcementRuleTypes RuleType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class LicensingPrincipal
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public PrincipalType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PrincipalType
    {
        None,
        Application,
        User,
        DelegatedAdmin
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
        public string SharedConnectionId { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class MonitoringHubTriggeredAlertsPollResponse
    {
        [JsonProperty("value")]
        public MonitoringHubTriggeredAlert[] Alerts { get; set; }

        [JsonProperty("totalCount")]
        public int AlertCount { get; set; }
    }

    public class MonitoringHubTriggeredAlert
    {
        [JsonProperty("alertId")]
        public string AlertId { get; set; }

        [JsonProperty("alertRuleId")]
        public string AlertRuleId { get; set; }

        [JsonProperty("monitorCondition")]
        public MonitoringHubTriggeredAlertMonitorConditionType MonitorCondition { get; set; }

        [JsonProperty("severity")]
        public MonitoringHubTriggeredAlertSeverityType Severity { get; set; }

        [JsonProperty("firedDateTime")]
        public string FiredTime { get; set; }

        [JsonProperty("resolvedDateTime")]
        public string ResolvedTime { get; set; }

        [JsonProperty("productType")]
        public MonitoringHubTriggeredAlertProductType Product { get; set; }

        [JsonProperty("subProductType")]
        public MonitoringHubTriggeredAlertSubProductType SubProduct { get; set; }

        [JsonProperty("scope")]
        public MonitoringHubTriggeredAlertScopeType Scope { get; set; }

        [JsonProperty("metric")]
        public MonitoringHubTriggeredAlertMetricType Metric { get; set; }

        [JsonProperty("metricUnit")]
        public MonitoringHubTriggeredAlertMetricUnitType MetricUnit { get; set; }

        [JsonProperty("operator")]
        public MonitoringHubTriggeredAlertComparisonOperatorType ComparisonOperator { get; set; }

        [JsonProperty("threshold")]
        public double Threshold { get; set; }

        [JsonProperty("dataReviewPeriod")]
        public string DataReviewPeriod { get; set; }

        [JsonProperty("affectedResourceCount")]
        public int AffectedResourceCount { get; set; }

        [JsonProperty("affectedResources")]
        public MonitoringHubAffectedResource[] AffectedResources { get; set; }

        [JsonProperty("affectedResourcesTruncated")]
        public bool AffectedResourcesTruncated { get; set; }

        [JsonProperty("alertLink")]
        public string AlertLink { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertMonitorConditionType
    {
        Unknown,
        Fired,
        Resolved
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertSeverityType
    {
        Unknown,
        Low,
        Medium,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertProductType
    {
        Unknown,
        PowerApps,
        PowerAutomate,
        PowerPages,
        CopilotStudio
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertSubProductType
    {
        Unknown,
        CanvasApp,
        ModelDrivenApp,
        PowerPages,
        CodeApp,
        DesktopFlow,
        CloudFlow,
        WorkQueue,
        Agent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertScopeType
    {
        Unknown,
        Tenant,
        Environment,
        Resource
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertMetricType
    {
        Unknown,
        CanvasAppAvailability,
        CanvasAppTimeToInteract,
        CanvasAppTimeToFullLoad,
        CanvasAppRecentAppLaunches,
        CanvasAppDataRequest,
        CanvasAppDataRequestLatency,
        CodeAppAvailability,
        CodeAppTimeToInteract,
        CodeAppRecentAppLaunches,
        CodeAppDataRequest,
        CodeAppDataRequestLatency,
        ModelAppAvailability,
        ModelDrivenAppRecentAppLaunches,
        CloudFlowSuccessRate,
        CloudFlowDuration,
        CloudFlowRunCount,
        DesktopFlowSuccessRate,
        DesktopFlowTimeInQueue,
        DesktopFlowDuration,
        DesktopFlowRunCount,
        PowerPagesAvailability,
        PowerPagesPageLoadTime,
        PowerPagesErrorRate,
        PowerPagesSessions,
        PowerPagesSessionTime,
        WorkQueueOutOfSla,
        WorkQueueItException,
        WorkQueueBusinessException,
        WorkQueueGenericException,
        AgentSuccessRate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertMetricUnitType
    {
        Unknown,
        Percent,
        Seconds,
        Count
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MonitoringHubTriggeredAlertComparisonOperatorType
    {
        Unknown,
        IsUnder,
        IsOver,
        Equals,
        IsUnderOrEqual,
        IsOverOrEqual
    }

    public class MonitoringHubAffectedResource
    {
        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("metricValue")]
        public double ObservedMetricValue { get; set; }
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