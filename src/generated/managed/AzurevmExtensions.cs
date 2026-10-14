//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurevm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzurevmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IBodyWorkflowAction<VirtualMachineInScaleSet> VirtualMachineInScaleSetGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredBodyAction<VirtualMachineInScaleSet>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction<VirtualMachineInScaleSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetDeallocate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/deallocate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetPowerOff(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/poweroff", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetRedeploy(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/redeploy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetReimage(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/reimage", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetRestart(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/restart", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetStart(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineScaleSetName, Expression<Func<string>> virtualMachineInScaleSetInstanceId)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineScaleSetName = virtualMachineScaleSetName == null ? null : WorkflowExpression.Compile(virtualMachineScaleSetName);
            WorkflowExpression.Validate(__workflow_virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            var __workflow_virtualMachineInScaleSetInstanceId = virtualMachineInScaleSetInstanceId == null ? null : WorkflowExpression.Compile(virtualMachineInScaleSetInstanceId);
            WorkflowExpression.Validate(__workflow_virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/start", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IBodyWorkflowAction<VirtualMachine> VirtualMachineGet(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredBodyAction<VirtualMachine>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction<VirtualMachine>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineStart(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/start", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineDeallocate(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/deallocate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachinePoweroff(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/powerOff", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineReapply(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/reapply", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineRedeploy(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/redeploy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineRestart(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> virtualMachineName)
        {
            var __workflow_subscriptionId = subscriptionId == null ? null : WorkflowExpression.Compile(subscriptionId);
            WorkflowExpression.Validate(__workflow_subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = resourceGroupName == null ? null : WorkflowExpression.Compile(resourceGroupName);
            WorkflowExpression.Validate(__workflow_resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_virtualMachineName = virtualMachineName == null ? null : WorkflowExpression.Compile(virtualMachineName);
            WorkflowExpression.Validate(__workflow_virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/restart", ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzurevmTriggers([ConnectionName] string connectionId)
    {
    }

    public class VirtualMachineInScaleSet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("properties")]
        public VirtualMachineInScaleSetProperties Properties { get; set; }
    }

    public class VirtualMachineInScaleSetProperties
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }
    }

    public class VirtualMachine
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public VirtualMachineProperties Properties { get; set; }
    }

    public class VirtualMachineProperties
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurevm;

    public partial class WorkflowManagedActions
    {
        public AzurevmActions Azurevm(string connectionId) => new AzurevmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurevmTriggers Azurevm(string connectionId) => new AzurevmTriggers(connectionId);
    }
}
