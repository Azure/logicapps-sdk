//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurevm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurevmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IBodyWorkflowAction<VirtualMachineInScaleSet> VirtualMachineInScaleSetGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction<VirtualMachineInScaleSet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetDeallocate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/deallocate", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetPowerOff([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/poweroff", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetRedeploy([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/redeploy", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetReimage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/reimage", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetRestart([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/restart", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetStart([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/start", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IBodyWorkflowAction<VirtualMachine> VirtualMachineGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction<VirtualMachine>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineStart([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/start", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineDeallocate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/deallocate", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachinePoweroff([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/powerOff", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineReapply([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/reapply", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineRedeploy([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/redeploy", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineRestart([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            var apiCallPath = String.Format("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/restart", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
            return new ApiConnectionAction(callPayload);
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