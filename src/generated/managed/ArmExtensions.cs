//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<LocationListResult, ApiConnectionActionConfiguration> SubscriptionsListLocations(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<LocationListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/locations", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<LocationListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<Subscription, ApiConnectionActionConfiguration> SubscriptionsGet(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<Subscription, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<Subscription>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<SubscriptionListResult, ApiConnectionActionConfiguration> SubscriptionsList()
        {
            return new DeferredBodyAction<SubscriptionListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<SubscriptionListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<DeploymentExtended, ApiConnectionActionConfiguration> DeploymentsGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> deploymentName, Expression<Func<bool>> wait = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_deploymentName = WorkflowExpression.Compile(deploymentName, nameof(deploymentName), required: true);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            return new DeferredBodyAction<DeploymentExtended, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Resources/deployments/{2}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_deploymentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                return new ApiConnectionAction<DeploymentExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeploymentsDelete(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> deploymentName)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_deploymentName = WorkflowExpression.Compile(deploymentName, nameof(deploymentName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Resources/deployments/{2}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_deploymentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeploymentsCancel(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> deploymentName)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_deploymentName = WorkflowExpression.Compile(deploymentName, nameof(deploymentName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Resources/deployments/{2}/cancel", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_deploymentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<DeploymentExportResult, ApiConnectionActionConfiguration> DeploymentsExportTemplate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> deploymentName)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_deploymentName = WorkflowExpression.Compile(deploymentName, nameof(deploymentName), required: true);
            return new DeferredBodyAction<DeploymentExportResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Resources/deployments/{2}/exportTemplate", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_deploymentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<DeploymentExportResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<DeploymentListResult, ApiConnectionActionConfiguration> DeploymentsList(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> filter = null, Expression<Func<int>> top = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<DeploymentListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Resources/deployments", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<DeploymentListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<DeploymentOperation, ApiConnectionActionConfiguration> DeploymentOperationsGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> deploymentName, Expression<Func<string>> operationId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_deploymentName = WorkflowExpression.Compile(deploymentName, nameof(deploymentName), required: true);
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            return new DeferredBodyAction<DeploymentOperation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/deployments/{2}/operations/{3}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_deploymentName.WithUrlEncoding(1), __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<DeploymentOperation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<DeploymentOperationsListResult, ApiConnectionActionConfiguration> DeploymentOperationsList(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> deploymentName, Expression<Func<int>> top = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_deploymentName = WorkflowExpression.Compile(deploymentName, nameof(deploymentName), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<DeploymentOperationsListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/deployments/{2}/operations", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_deploymentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<DeploymentOperationsListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<Provider, ApiConnectionActionConfiguration> ProvidersUnregister(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceProviderNamespace)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            return new DeferredBodyAction<Provider, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}/unregister", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<Provider>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<Provider, ApiConnectionActionConfiguration> ProvidersRegister(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceProviderNamespace)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            return new DeferredBodyAction<Provider, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}/register", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<Provider>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ProviderListResult, ApiConnectionActionConfiguration> ProvidersList(Expression<Func<string>> subscriptionId, Expression<Func<int>> top = null, Expression<Func<string>> expand = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<ProviderListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<ProviderListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<Provider, ApiConnectionActionConfiguration> ProvidersGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceProviderNamespace, Expression<Func<string>> expand = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<Provider, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<Provider>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ResourceListResult, ApiConnectionActionConfiguration> ResourceGroupsListResources(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<int>> top = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ResourceListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourceGroups/{1}/resources", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ResourceListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ResourceGroup, ApiConnectionActionConfiguration> ResourceGroupsGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            return new DeferredBodyAction<ResourceGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<ResourceGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResourceGroupsDelete(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ResourceGroup, ApiConnectionActionConfiguration> ResourceGroupsPatch(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<ResourceGroupsPatchParametersInput>> parameters)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<ResourceGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ResourceGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ResourceGroupExportResult, ApiConnectionActionConfiguration> ResourceGroupsExportTemplate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<ResourceGroupsExportTemplateParametersInput>> parameters)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<ResourceGroupExportResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/exportTemplate", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<ResourceGroupExportResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ResourceGroupListResult, ApiConnectionActionConfiguration> ResourceGroupsList(Expression<Func<string>> subscriptionId, Expression<Func<string>> filter = null, Expression<Func<int>> top = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ResourceGroupListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ResourceGroupListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<ResourceListResult, ApiConnectionActionConfiguration> ResourcesList(Expression<Func<string>> subscriptionId, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<int>> top = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ResourceListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resources", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<ResourceListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<GenericResource, ApiConnectionActionConfiguration> ResourcesGetById(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> resourceProviderNamespace, Expression<Func<string>> shortResourceId, Expression<Func<string>> xMsApiVersion)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            var __workflow_shortResourceId = WorkflowExpression.Compile(shortResourceId, nameof(shortResourceId), required: true);
            var __workflow_xMsApiVersion = WorkflowExpression.Compile(xMsApiVersion, nameof(xMsApiVersion), required: true);
            return new DeferredBodyAction<GenericResource, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/{2}/{3}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1), __workflow_shortResourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = ExpressionConverter.Convert(__workflow_xMsApiVersion);
                return new ApiConnectionAction<GenericResource>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResourcesDeleteById(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> resourceProviderNamespace, Expression<Func<string>> shortResourceId, Expression<Func<string>> xMsApiVersion)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            var __workflow_shortResourceId = WorkflowExpression.Compile(shortResourceId, nameof(shortResourceId), required: true);
            var __workflow_xMsApiVersion = WorkflowExpression.Compile(xMsApiVersion, nameof(xMsApiVersion), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/{2}/{3}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1), __workflow_shortResourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = ExpressionConverter.Convert(__workflow_xMsApiVersion);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ResourcesInvoke(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> resourceProviderNamespace, Expression<Func<string>> shortResourceId, Expression<Func<string>> xMsApiVersion, Expression<Func<string>> actionName, Expression<Func<object>> body = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            var __workflow_shortResourceId = WorkflowExpression.Compile(shortResourceId, nameof(shortResourceId), required: true);
            var __workflow_xMsApiVersion = WorkflowExpression.Compile(xMsApiVersion, nameof(xMsApiVersion), required: true);
            var __workflow_actionName = WorkflowExpression.Compile(actionName, nameof(actionName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/{2}/{3}/{4}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1), __workflow_shortResourceId.WithUrlEncoding(1), __workflow_actionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = ExpressionConverter.Convert(__workflow_xMsApiVersion);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<GenericResource, ApiConnectionActionConfiguration> ProviderResourcesGetById(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceProviderNamespace, Expression<Func<string>> shortResourceId, Expression<Func<string>> xMsApiVersion)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            var __workflow_shortResourceId = WorkflowExpression.Compile(shortResourceId, nameof(shortResourceId), required: true);
            var __workflow_xMsApiVersion = WorkflowExpression.Compile(xMsApiVersion, nameof(xMsApiVersion), required: true);
            return new DeferredBodyAction<GenericResource, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}/{2}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1), __workflow_shortResourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = ExpressionConverter.Convert(__workflow_xMsApiVersion);
                return new ApiConnectionAction<GenericResource>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ProviderResourcesInvoke(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceProviderNamespace, Expression<Func<string>> shortResourceId, Expression<Func<string>> xMsApiVersion, Expression<Func<object>> body = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceProviderNamespace = WorkflowExpression.Compile(resourceProviderNamespace, nameof(resourceProviderNamespace), required: true);
            var __workflow_shortResourceId = WorkflowExpression.Compile(shortResourceId, nameof(shortResourceId), required: true);
            var __workflow_xMsApiVersion = WorkflowExpression.Compile(xMsApiVersion, nameof(xMsApiVersion), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}/{2}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceProviderNamespace.WithUrlEncoding(1), __workflow_shortResourceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = ExpressionConverter.Convert(__workflow_xMsApiVersion);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TagsDeleteValue(Expression<Func<string>> subscriptionId, Expression<Func<string>> tagName, Expression<Func<string>> tagValue)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: true);
            var __workflow_tagValue = WorkflowExpression.Compile(tagValue, nameof(tagValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/tagNames/{1}/tagValues/{2}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_tagName.WithUrlEncoding(1), __workflow_tagValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TagsDelete(Expression<Func<string>> subscriptionId, Expression<Func<string>> tagName)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/tagNames/{1}", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_tagName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arm")]
        public IBodyWorkflowAction<TagsListResult, ApiConnectionActionConfiguration> TagsList(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<TagsListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/tagNames", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2016-06-01");
                return new ApiConnectionAction<TagsListResult>(callPayload);
            });
        }
    }

    public class ArmTriggers([ConnectionName] string connectionId)
    {
    }

    public class LocationListResult
    {
        [JsonProperty("value")]
        public Location[] Value { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("name")]
        public string LocationName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("state")]
        public SubscriptionStateType State { get; set; }

        [JsonProperty("subscriptionPolicies")]
        public SubscriptionPolicies SubscriptionPolicies { get; set; }

        [JsonProperty("authorizationSource")]
        public string AuthorizationSource { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscriptionStateType
    {
        Enabled,
        Warned,
        PastDue,
        Disabled,
        Deleted
    }

    public class SubscriptionPolicies
    {
        [JsonProperty("locationPlacementId")]
        public string LocationPlacementId { get; set; }

        [JsonProperty("quotaId")]
        public string QuotaId { get; set; }

        [JsonProperty("spendingLimit")]
        public SubscriptionPoliciesSpendingLimitType SpendingLimit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscriptionPoliciesSpendingLimitType
    {
        On,
        Off,
        CurrentPeriodOff
    }

    public class SubscriptionListResult
    {
        [JsonProperty("value")]
        public Subscription[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeploymentExtended
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public DeploymentPropertiesExtended Properties { get; set; }
    }

    public class DeploymentPropertiesExtended
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("outputs")]
        public JToken Outputs { get; set; }

        [JsonProperty("providers")]
        public Provider[] Providers { get; set; }

        [JsonProperty("dependencies")]
        public Dependency[] Dependencies { get; set; }

        [JsonProperty("template")]
        public JToken Template { get; set; }

        [JsonProperty("templateLink")]
        public TemplateLink TemplateLink { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }

        [JsonProperty("parametersLink")]
        public ParametersLink ParametersLink { get; set; }

        [JsonProperty("mode")]
        public DeploymentPropertiesExtendedDeploymentModeType DeploymentMode { get; set; }

        [JsonProperty("debugSetting")]
        public DebugSetting DebugSetting { get; set; }
    }

    public class Provider
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("registrationState")]
        public string RegistrationState { get; set; }

        [JsonProperty("resourceTypes")]
        public ProviderResourceType[] ResourceType { get; set; }
    }

    public class ProviderResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("locations")]
        public JToken[] Locations { get; set; }

        [JsonProperty("aliases")]
        public AliasType[] Aliases { get; set; }

        [JsonProperty("apiVersions")]
        public string[] ApiVersions { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class AliasType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paths")]
        public AliasPathType[] Paths { get; set; }
    }

    public class AliasPathType
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("apiVersions")]
        public string[] ApiVersions { get; set; }
    }

    public class Dependency
    {
        [JsonProperty("dependsOn")]
        public BasicDependency[] DependsOn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("resourceName")]
        public string ResourceName { get; set; }
    }

    public class BasicDependency
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("resourceName")]
        public string ResourceName { get; set; }
    }

    public class TemplateLink
    {
        [JsonProperty("uri")]
        public string TemplateURI { get; set; }

        [JsonProperty("contentVersion")]
        public string TemplateContentVersion { get; set; }
    }

    public class ParametersLink
    {
        [JsonProperty("uri")]
        public string ParametersURI { get; set; }

        [JsonProperty("contentVersion")]
        public string ParametersContentVersion { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeploymentPropertiesExtendedDeploymentModeType
    {
        Incremental,
        Complete
    }

    public class DebugSetting
    {
        [JsonProperty("detailLevel")]
        public string DetailLevel { get; set; }
    }

    public class DeploymentExportResult
    {
        [JsonProperty("template")]
        public JToken Template { get; set; }
    }

    public class DeploymentListResult
    {
        [JsonProperty("value")]
        public DeploymentExtended[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeploymentOperation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("properties")]
        public DeploymentOperationProperties Properties { get; set; }
    }

    public class DeploymentOperationProperties
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("serviceRequestId")]
        public string ServiceRequestId { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("statusMessage")]
        public JToken StatusMessage { get; set; }

        [JsonProperty("targetResource")]
        public TargetResource TargetResource { get; set; }

        [JsonProperty("request")]
        public HttpMessage Request { get; set; }

        [JsonProperty("response")]
        public HttpMessage Response { get; set; }
    }

    public class TargetResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceName")]
        public string Name { get; set; }

        [JsonProperty("resourceType")]
        public string Type { get; set; }
    }

    public class HttpMessage
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }
    }

    public class DeploymentOperationsListResult
    {
        [JsonProperty("value")]
        public DeploymentOperation[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ProviderListResult
    {
        [JsonProperty("value")]
        public Provider[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ResourceListResult
    {
        [JsonProperty("value")]
        public GenericResource[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class GenericResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("sku")]
        public Sku Sku { get; set; }

        [JsonProperty("identity")]
        public Identity Identity { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Plan
    {
        [JsonProperty("name")]
        public string Id { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("promotionCode")]
        public string PromotionCode { get; set; }
    }

    public class Sku
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }
    }

    public class Identity
    {
        [JsonProperty("principalId")]
        public string PrincipalId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("type")]
        public IdentityTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IdentityTypeType
    {
        SystemAssigned
    }

    public class ResourceGroup
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("properties")]
        public ResourceGroupsGetResourceGroupPropertiesResponse Properties { get; set; }
    }

    public class ResourceGroupsGetResourceGroupPropertiesResponse
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }
    }

    public class ResourceGroupsPatchParametersInput
    {
        public ResourceGroupsPatchParametersInput(string location)
        {
            this.Location = location;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; }

        [JsonProperty("managedBy")]
        public string ManagedBy { get; set; }

        [JsonProperty("tags")]
        public JToken Tags { get; set; }

        [JsonProperty("properties")]
        public ResourceGroupsPatchResourceGroupProperties Properties { get; set; }
    }

    public class ResourceGroupsPatchResourceGroupProperties
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }
    }

    public class ResourceGroupExportResult
    {
        [JsonProperty("template")]
        public JToken Template { get; set; }

        [JsonProperty("error")]
        public ResourceManagementErrorWithDetails Error { get; set; }
    }

    public class ResourceManagementErrorWithDetails
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("details")]
        public JToken[] Details { get; set; }
    }

    public class ResourceGroupsExportTemplateParametersInput
    {
        [JsonProperty("resources", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParametersInputResourcesTypeItem[] Resources { get; set; } = new ParametersInputResourcesTypeItem[]
        {
            global::Microsoft.Azure.Workflows.Sdk.Connectors.Arm.ParametersInputResourcesTypeItem.Unnamed
        };

        [JsonProperty("options")]
        public ParametersInputOptionsType? Options { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParametersInputResourcesTypeItem
    {
        [EnumMember(Value = "*")]
        Unnamed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParametersInputOptionsType
    {
        IncludeParameterDefaultValue,
        IncludeComments,
        [EnumMember(Value = "IncludeParameterDefaultValue, IncludeComments")]
        IncludeParameterDefaultValueIncludeComments
    }

    public class ResourceGroupListResult
    {
        [JsonProperty("value")]
        public ResourceGroup[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class TagsListResult
    {
        [JsonProperty("value")]
        public TagDetails[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class TagDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tagName")]
        public string Name { get; set; }

        [JsonProperty("count")]
        public TagCount Count { get; set; }

        [JsonProperty("values")]
        public TagValueInfo[] Values { get; set; }
    }

    public class TagCount
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class TagValueInfo
    {
        [JsonProperty("id")]
        public string TagId { get; set; }

        [JsonProperty("tagValue")]
        public string TagValue { get; set; }

        [JsonProperty("count")]
        public TagCount Count { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Arm;

    public partial class WorkflowManagedActions
    {
        public ArmActions Arm(string connectionId) => new ArmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ArmTriggers Arm(string connectionId) => new ArmTriggers(connectionId);
    }
}