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
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetGet))]
        public IBodyWorkflowAction<VirtualMachineInScaleSet> VirtualMachineInScaleSetGet([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VirtualMachineInScaleSet> __BuildVirtualMachineInScaleSetGet(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredBodyAction<VirtualMachineInScaleSet>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction<VirtualMachineInScaleSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetDeallocate))]
        public IWorkflowAction VirtualMachineInScaleSetDeallocate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineInScaleSetDeallocate(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/deallocate", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetPowerOff))]
        public IWorkflowAction VirtualMachineInScaleSetPowerOff([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineInScaleSetPowerOff(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/poweroff", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetRedeploy))]
        public IWorkflowAction VirtualMachineInScaleSetRedeploy([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineInScaleSetRedeploy(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/redeploy", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetReimage))]
        public IWorkflowAction VirtualMachineInScaleSetReimage([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineInScaleSetReimage(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/reimage", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetRestart))]
        public IWorkflowAction VirtualMachineInScaleSetRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineInScaleSetRestart(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/restart", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineInScaleSetStart))]
        public IWorkflowAction VirtualMachineInScaleSetStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineScaleSetName, [WorkflowExpression] Func<string> virtualMachineInScaleSetInstanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineInScaleSetStart(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineScaleSetName, WorkflowExpression<string> virtualMachineInScaleSetInstanceId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName), required: true);
            WorkflowExpression.Validate(virtualMachineInScaleSetInstanceId, nameof(virtualMachineInScaleSetInstanceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachineScaleSets/{2}/virtualMachines/{3}/start", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineScaleSetName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineInScaleSetInstanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineGet))]
        public IBodyWorkflowAction<VirtualMachine> VirtualMachineGet([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VirtualMachine> __BuildVirtualMachineGet(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredBodyAction<VirtualMachine>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction<VirtualMachine>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineStart))]
        public IWorkflowAction VirtualMachineStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineStart(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/start", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineDeallocate))]
        public IWorkflowAction VirtualMachineDeallocate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineDeallocate(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/deallocate", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachinePoweroff))]
        public IWorkflowAction VirtualMachinePoweroff([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachinePoweroff(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/powerOff", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineReapply))]
        public IWorkflowAction VirtualMachineReapply([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineReapply(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/reapply", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineRedeploy))]
        public IWorkflowAction VirtualMachineRedeploy([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineRedeploy(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/redeploy", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2019-12-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [WorkflowExpressionFactory(nameof(__BuildVirtualMachineRestart))]
        public IWorkflowAction VirtualMachineRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualMachineName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurevm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildVirtualMachineRestart(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualMachineName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualMachineName, nameof(virtualMachineName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}/restart", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualMachineName, 1));
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