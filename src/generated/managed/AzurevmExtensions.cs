//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurevm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurevmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IBodyWorkflowAction<VirtualMachineInScaleSet> VirtualMachineInScaleSetGet([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction<VirtualMachineInScaleSet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetDeallocate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/deallocate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetPowerOff([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/poweroff", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetRedeploy([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/redeploy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetReimage([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/reimage", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/restart", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineInScaleSetStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            SourceExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineScaleSetName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IBodyWorkflowAction<VirtualMachine> VirtualMachineGet([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction<VirtualMachine>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineDeallocate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/deallocate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachinePoweroff([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/powerOff", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineReapply([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/reapply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineRedeploy([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/redeploy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        public IWorkflowAction VirtualMachineRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            SourceExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            SourceExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/restart", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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