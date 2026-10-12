//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aci
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AciActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsList))]
        public IBodyWorkflowAction<ContainerGroupListResult> ContainerGroupsList([WorkflowExpression] Func<string> subscriptionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerGroupListResult> __BuildContainerGroupsList(WorkflowExpression<string> subscriptionId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<ContainerGroupListResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/containerGroups", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<ContainerGroupListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsListByResourceGroup))]
        public IBodyWorkflowAction<ContainerGroupListResult> ContainerGroupsListByResourceGroup([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerGroupListResult> __BuildContainerGroupsListByResourceGroup(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            return new DeferredBodyAction<ContainerGroupListResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<ContainerGroupListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsGet))]
        public IBodyWorkflowAction<ContainerGroup> ContainerGroupsGet([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerGroup> __BuildContainerGroupsGet(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            return new DeferredBodyAction<ContainerGroup>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<ContainerGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsUpdate))]
        public IBodyWorkflowAction<ContainerGroup> ContainerGroupsUpdate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> resourceid = null, [WorkflowExpression] Func<string> resourcename = null, [WorkflowExpression] Func<string> resourcetype = null, [WorkflowExpression] Func<string> resourcelocation = null, [WorkflowExpression] Func<string[]> resourcezones = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerGroup> __BuildContainerGroupsUpdate(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName, WorkflowExpression<string> resourceid = null, WorkflowExpression<string> resourcename = null, WorkflowExpression<string> resourcetype = null, WorkflowExpression<string> resourcelocation = null, WorkflowExpression<string[]> resourcezones = null)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            WorkflowExpression.Validate(resourceid, nameof(resourceid), required: false);
            WorkflowExpression.Validate(resourcename, nameof(resourcename), required: false);
            WorkflowExpression.Validate(resourcetype, nameof(resourcetype), required: false);
            WorkflowExpression.Validate(resourcelocation, nameof(resourcelocation), required: false);
            WorkflowExpression.Validate(resourcezones, nameof(resourcezones), required: false);
            return new DeferredBodyAction<ContainerGroup>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                var resource = new JObject();
                var resourcepropCount = 0;
                if (resourceid != null)
                {
                    resource["id"] = ExpressionConverter.ConvertO(resourceid);
                    resourcepropCount++;
                }

                if (resourcename != null)
                {
                    resource["name"] = ExpressionConverter.ConvertO(resourcename);
                    resourcepropCount++;
                }

                if (resourcetype != null)
                {
                    resource["type"] = ExpressionConverter.ConvertO(resourcetype);
                    resourcepropCount++;
                }

                if (resourcelocation != null)
                {
                    resource["location"] = ExpressionConverter.ConvertO(resourcelocation);
                    resourcepropCount++;
                }

                var tagsObject = new JObject();
                var tagsObjectpropCount = 0;
                if (tagsObjectpropCount > 0)
                {
                    resource["tags"] = tagsObject;
                    resourcepropCount++;
                }

                if (resourcezones != null)
                {
                    resource["zones"] = ExpressionConverter.ConvertO(resourcezones);
                    resourcepropCount++;
                }

                if (resourcepropCount > 0)
                {
                    callPayload.Body = resource;
                }

                return new ApiConnectionAction<ContainerGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsDelete))]
        public IBodyWorkflowAction<ContainerGroup> ContainerGroupsDelete([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerGroup> __BuildContainerGroupsDelete(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            return new DeferredBodyAction<ContainerGroup>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<ContainerGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsRestart))]
        public IWorkflowAction ContainerGroupsRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContainerGroupsRestart(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/restart", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsStop))]
        public IWorkflowAction ContainerGroupsStop([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContainerGroupsStop(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/stop", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsStart))]
        public IWorkflowAction ContainerGroupsStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContainerGroupsStart(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/start", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildLocationListUsage))]
        public IBodyWorkflowAction<UsageListResult> LocationListUsage([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> location)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UsageListResult> __BuildLocationListUsage(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> location)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            return new DeferredBodyAction<UsageListResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/locations/{1}/usages", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<UsageListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerLogsList))]
        public IBodyWorkflowAction<Logs> ContainerLogsList([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<int> tail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Logs> __BuildContainerLogsList(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName, WorkflowExpression<string> containerName, WorkflowExpression<int> tail = null)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(tail, nameof(tail), required: false);
            return new DeferredBodyAction<Logs>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/containers/{3}/logs", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                if (tail != null)
                    callPayload.Queries["tail"] = ExpressionConverter.Convert(tail);
                return new ApiConnectionAction<Logs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainersExecuteCommand))]
        public IBodyWorkflowAction<ContainerExecResponse> ContainersExecuteCommand([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> containerExecRequestcommand = null, [WorkflowExpression] Func<int> containerExecRequestterminalSizerows = null, [WorkflowExpression] Func<int> containerExecRequestterminalSizecols = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerExecResponse> __BuildContainersExecuteCommand(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName, WorkflowExpression<string> containerName, WorkflowExpression<string> containerExecRequestcommand = null, WorkflowExpression<int> containerExecRequestterminalSizerows = null, WorkflowExpression<int> containerExecRequestterminalSizecols = null)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            WorkflowExpression.Validate(containerExecRequestcommand, nameof(containerExecRequestcommand), required: false);
            WorkflowExpression.Validate(containerExecRequestterminalSizerows, nameof(containerExecRequestterminalSizerows), required: false);
            WorkflowExpression.Validate(containerExecRequestterminalSizecols, nameof(containerExecRequestterminalSizecols), required: false);
            return new DeferredBodyAction<ContainerExecResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/containers/{3}/exec", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                var containerExecRequest = new JObject();
                var containerExecRequestpropCount = 0;
                if (containerExecRequestcommand != null)
                {
                    containerExecRequest["command"] = ExpressionConverter.ConvertO(containerExecRequestcommand);
                    containerExecRequestpropCount++;
                }

                var terminalSizeObject = new JObject();
                var terminalSizeObjectpropCount = 0;
                if (containerExecRequestterminalSizerows != null)
                {
                    terminalSizeObject["rows"] = ExpressionConverter.ConvertO(containerExecRequestterminalSizerows);
                    terminalSizeObjectpropCount++;
                }

                if (containerExecRequestterminalSizecols != null)
                {
                    terminalSizeObject["cols"] = ExpressionConverter.ConvertO(containerExecRequestterminalSizecols);
                    terminalSizeObjectpropCount++;
                }

                if (terminalSizeObjectpropCount > 0)
                {
                    containerExecRequest["terminalSize"] = terminalSizeObject;
                    containerExecRequestpropCount++;
                }

                if (containerExecRequestpropCount > 0)
                {
                    callPayload.Body = containerExecRequest;
                }

                return new ApiConnectionAction<ContainerExecResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainersAttach))]
        public IBodyWorkflowAction<ContainerAttachResponse> ContainersAttach([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> containerName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContainerAttachResponse> __BuildContainersAttach(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName, WorkflowExpression<string> containerName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            WorkflowExpression.Validate(containerName, nameof(containerName), required: true);
            return new DeferredBodyAction<ContainerAttachResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/containers/{3}/attach", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<ContainerAttachResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildLocationListCachedImages))]
        public IBodyWorkflowAction<CachedImagesListResult> LocationListCachedImages([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> location)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CachedImagesListResult> __BuildLocationListCachedImages(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> location)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            return new DeferredBodyAction<CachedImagesListResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/locations/{1}/cachedImages", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<CachedImagesListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildLocationListCapabilities))]
        public IBodyWorkflowAction<CapabilitiesListResult> LocationListCapabilities([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> location)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CapabilitiesListResult> __BuildLocationListCapabilities(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> location)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(location, nameof(location), required: true);
            return new DeferredBodyAction<CapabilitiesListResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/locations/{1}/capabilities", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<CapabilitiesListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildContainerGroupsGetOutboundNetworkDependenciesEndpoints))]
        public IBodyWorkflowAction<string[]> ContainerGroupsGetOutboundNetworkDependenciesEndpoints([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildContainerGroupsGetOutboundNetworkDependenciesEndpoints(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> containerGroupName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(containerGroupName, nameof(containerGroupName), required: true);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/outboundNetworkDependenciesEndpoints", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        [WorkflowExpressionFactory(nameof(__BuildSubnetServiceAssociationLinkDelete))]
        public IWorkflowAction SubnetServiceAssociationLinkDelete([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualNetworkName, [WorkflowExpression] Func<string> subnetName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubnetServiceAssociationLinkDelete(WorkflowExpression<string> subscriptionId, WorkflowExpression<string> resourceGroupName, WorkflowExpression<string> virtualNetworkName, WorkflowExpression<string> subnetName)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(resourceGroupName, nameof(resourceGroupName), required: true);
            WorkflowExpression.Validate(virtualNetworkName, nameof(virtualNetworkName), required: true);
            WorkflowExpression.Validate(subnetName, nameof(subnetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Network/virtualNetworks/{2}/subnets/{3}/providers/Microsoft.ContainerInstance/serviceAssociationLinks/default", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1), ExpressionConverter.ConvertWithUrlEncoding(resourceGroupName, 1), ExpressionConverter.ConvertWithUrlEncoding(virtualNetworkName, 1), ExpressionConverter.ConvertWithUrlEncoding(subnetName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AciTriggers([ConnectionName] string connectionId)
    {
    }

    public class ContainerGroupListResult
    {
        [JsonProperty("value")]
        public ContainerGroup[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ContainerGroup
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

        [JsonProperty("zones")]
        public string[] Zones { get; set; }

        [JsonProperty("identity")]
        public ContainerGroupIdentity Identity { get; set; }

        [JsonProperty("properties")]
        public ContainerGroupProperties Properties { get; set; }
    }

    public class ContainerGroupIdentity
    {
        [JsonProperty("principalId")]
        public string PrincipalId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("type")]
        public ContainerGroupIdentityTypeType Type { get; set; }

        [JsonProperty("userAssignedIdentities")]
        public JToken UserAssignedIdentities { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerGroupIdentityTypeType
    {
        SystemAssigned,
        UserAssigned,
        [EnumMember(Value = "SystemAssigned, UserAssigned")]
        SystemAssignedUserAssigned,
        None
    }

    public class ContainerGroupProperties
    {
        [JsonProperty("provisioningState")]
        public string ProvisioningState { get; set; }

        [JsonProperty("containers")]
        public Container[] Containers { get; set; }

        [JsonProperty("imageRegistryCredentials")]
        public ImageRegistryCredential[] ImageRegistryCredentials { get; set; }

        [JsonProperty("restartPolicy")]
        public ContainerGroupPropertiesRestartPolicyType RestartPolicy { get; set; }

        [JsonProperty("ipAddress")]
        public IpAddress IpAddress { get; set; }

        [JsonProperty("osType")]
        public ContainerGroupPropertiesOsTypeType OsType { get; set; }

        [JsonProperty("volumes")]
        public Volume[] Volumes { get; set; }

        [JsonProperty("instanceView")]
        public ContainerGroupPropertiesInstanceViewType InstanceView { get; set; }

        [JsonProperty("diagnostics")]
        public ContainerGroupDiagnostics Diagnostics { get; set; }

        [JsonProperty("subnetIds")]
        public ContainerGroupSubnetId[] SubnetIds { get; set; }

        [JsonProperty("dnsConfig")]
        public DnsConfiguration DnsConfig { get; set; }

        [JsonProperty("sku")]
        public ContainerGroupSku Sku { get; set; }

        [JsonProperty("encryptionProperties")]
        public EncryptionProperties EncryptionProperties { get; set; }

        [JsonProperty("initContainers")]
        public InitContainerDefinition[] InitContainers { get; set; }

        [JsonProperty("extensions")]
        public DeploymentExtensionSpec[] Extensions { get; set; }

        [JsonProperty("confidentialComputeProperties")]
        public ConfidentialComputeProperties ConfidentialComputeProperties { get; set; }

        [JsonProperty("priority")]
        public ContainerGroupPropertiesPriorityType Priority { get; set; }
    }

    public class Container
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public ContainerProperties Properties { get; set; }
    }

    public class ContainerProperties
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("command")]
        public string[] Command { get; set; }

        [JsonProperty("ports")]
        public ContainerPort[] Ports { get; set; }

        [JsonProperty("environmentVariables")]
        public EnvironmentVariable[] EnvironmentVariables { get; set; }

        [JsonProperty("instanceView")]
        public ContainerPropertiesInstanceViewType InstanceView { get; set; }

        [JsonProperty("resources")]
        public ResourceRequirements Resources { get; set; }

        [JsonProperty("volumeMounts")]
        public VolumeMount[] VolumeMounts { get; set; }

        [JsonProperty("livenessProbe")]
        public ContainerProbe LivenessProbe { get; set; }

        [JsonProperty("readinessProbe")]
        public ContainerProbe ReadinessProbe { get; set; }

        [JsonProperty("securityContext")]
        public SecurityContextDefinition SecurityContext { get; set; }
    }

    public class ContainerPort
    {
        [JsonProperty("protocol")]
        public ContainerPortProtocolType Protocol { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerPortProtocolType
    {
        TCP,
        UDP
    }

    public class EnvironmentVariable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("secureValue")]
        public string SecureValue { get; set; }
    }

    public class ContainerPropertiesInstanceViewType
    {
        [JsonProperty("restartCount")]
        public int RestartCount { get; set; }

        [JsonProperty("currentState")]
        public ContainerState CurrentState { get; set; }

        [JsonProperty("previousState")]
        public ContainerState PreviousState { get; set; }

        [JsonProperty("events")]
        public Event[] Events { get; set; }
    }

    public class ContainerState
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("exitCode")]
        public int ExitCode { get; set; }

        [JsonProperty("finishTime")]
        public string FinishTime { get; set; }

        [JsonProperty("detailStatus")]
        public string DetailStatus { get; set; }
    }

    public class Event
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("firstTimestamp")]
        public string FirstTimestamp { get; set; }

        [JsonProperty("lastTimestamp")]
        public string LastTimestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ResourceRequirements
    {
        [JsonProperty("requests")]
        public ResourceRequests Requests { get; set; }

        [JsonProperty("limits")]
        public ResourceLimits Limits { get; set; }
    }

    public class ResourceRequests
    {
        [JsonProperty("memoryInGB")]
        public double MemoryInGB { get; set; }

        [JsonProperty("cpu")]
        public double Cpu { get; set; }

        [JsonProperty("gpu")]
        public GpuResource Gpu { get; set; }
    }

    public class GpuResource
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("sku")]
        public GpuResourceSkuType Sku { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GpuResourceSkuType
    {
        K80,
        P100,
        V100
    }

    public class ResourceLimits
    {
        [JsonProperty("memoryInGB")]
        public double MemoryInGB { get; set; }

        [JsonProperty("cpu")]
        public double Cpu { get; set; }

        [JsonProperty("gpu")]
        public GpuResource Gpu { get; set; }
    }

    public class VolumeMount
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mountPath")]
        public string MountPath { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }

    public class ContainerProbe
    {
        [JsonProperty("exec")]
        public ContainerExec Exec { get; set; }

        [JsonProperty("httpGet")]
        public ContainerHttpGet HttpGet { get; set; }

        [JsonProperty("initialDelaySeconds")]
        public int InitialDelaySeconds { get; set; }

        [JsonProperty("periodSeconds")]
        public int PeriodSeconds { get; set; }

        [JsonProperty("failureThreshold")]
        public int FailureThreshold { get; set; }

        [JsonProperty("successThreshold")]
        public int SuccessThreshold { get; set; }

        [JsonProperty("timeoutSeconds")]
        public int TimeoutSeconds { get; set; }
    }

    public class ContainerExec
    {
        [JsonProperty("command")]
        public string[] Command { get; set; }
    }

    public class ContainerHttpGet
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("scheme")]
        public ContainerHttpGetSchemeType Scheme { get; set; }

        [JsonProperty("httpHeaders")]
        public HttpHeader[] HttpHeaders { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerHttpGetSchemeType
    {
        [EnumMember(Value = "http")]
        Http,
        [EnumMember(Value = "https")]
        Https
    }

    public class HttpHeader
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SecurityContextDefinition
    {
        [JsonProperty("privileged")]
        public bool Privileged { get; set; }

        [JsonProperty("allowPrivilegeEscalation")]
        public bool AllowPrivilegeEscalation { get; set; }

        [JsonProperty("capabilities")]
        public SecurityContextCapabilitiesDefinition Capabilities { get; set; }

        [JsonProperty("runAsGroup")]
        public int RunAsGroup { get; set; }

        [JsonProperty("runAsUser")]
        public int RunAsUser { get; set; }

        [JsonProperty("seccompProfile")]
        public string SeccompProfile { get; set; }
    }

    public class SecurityContextCapabilitiesDefinition
    {
        [JsonProperty("add")]
        public string[] Add { get; set; }

        [JsonProperty("drop")]
        public string[] Drop { get; set; }
    }

    public class ImageRegistryCredential
    {
        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("identityUrl")]
        public string IdentityUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerGroupPropertiesRestartPolicyType
    {
        Always,
        OnFailure,
        Never
    }

    public class IpAddress
    {
        [JsonProperty("ports")]
        public PortInfo[] Ports { get; set; }

        [JsonProperty("type")]
        public IpAddressTypeType Type { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("dnsNameLabel")]
        public string DnsNameLabel { get; set; }

        [JsonProperty("autoGeneratedDomainNameLabelScope")]
        public IpAddressAutoGeneratedDomainNameLabelScopeType AutoGeneratedDomainNameLabelScope { get; set; }

        [JsonProperty("fqdn")]
        public string Fqdn { get; set; }
    }

    public class PortInfo
    {
        [JsonProperty("protocol")]
        public PortProtocolType Protocol { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PortProtocolType
    {
        TCP,
        UDP
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IpAddressTypeType
    {
        Public,
        Private
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IpAddressAutoGeneratedDomainNameLabelScopeType
    {
        Unsecure,
        TenantReuse,
        SubscriptionReuse,
        ResourceGroupReuse,
        Noreuse
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerGroupPropertiesOsTypeType
    {
        Windows,
        Linux
    }

    public class Volume
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("azureFile")]
        public AzureFileVolume AzureFile { get; set; }

        [JsonProperty("emptyDir")]
        public JToken EmptyDir { get; set; }

        [JsonProperty("secret")]
        public JToken Secret { get; set; }

        [JsonProperty("gitRepo")]
        public GitRepoVolume GitRepo { get; set; }
    }

    public class AzureFileVolume
    {
        [JsonProperty("shareName")]
        public string ShareName { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("storageAccountName")]
        public string StorageAccountName { get; set; }

        [JsonProperty("storageAccountKey")]
        public string StorageAccountKey { get; set; }
    }

    public class GitRepoVolume
    {
        [JsonProperty("directory")]
        public string Directory { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("revision")]
        public string Revision { get; set; }
    }

    public class ContainerGroupPropertiesInstanceViewType
    {
        [JsonProperty("events")]
        public Event[] Events { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class ContainerGroupDiagnostics
    {
        [JsonProperty("logAnalytics")]
        public LogAnalytics LogAnalytics { get; set; }
    }

    public class LogAnalytics
    {
        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspaceKey")]
        public string WorkspaceKey { get; set; }

        [JsonProperty("logType")]
        public LogAnalyticsLogTypeType LogType { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("workspaceResourceId")]
        public string WorkspaceResourceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LogAnalyticsLogTypeType
    {
        ContainerInsights,
        ContainerInstanceLogs
    }

    public class ContainerGroupSubnetId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DnsConfiguration
    {
        [JsonProperty("nameServers")]
        public string[] NameServers { get; set; }

        [JsonProperty("searchDomains")]
        public string SearchDomains { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerGroupSku
    {
        Standard,
        Dedicated,
        Confidential
    }

    public class EncryptionProperties
    {
        [JsonProperty("vaultBaseUrl")]
        public string VaultBaseUrl { get; set; }

        [JsonProperty("keyName")]
        public string KeyName { get; set; }

        [JsonProperty("keyVersion")]
        public string KeyVersion { get; set; }

        [JsonProperty("identity")]
        public string Identity { get; set; }
    }

    public class InitContainerDefinition
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public InitContainerPropertiesDefinition Properties { get; set; }
    }

    public class InitContainerPropertiesDefinition
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("command")]
        public string[] Command { get; set; }

        [JsonProperty("environmentVariables")]
        public EnvironmentVariable[] EnvironmentVariables { get; set; }

        [JsonProperty("instanceView")]
        public InitContainerPropertiesDefinitionInstanceViewType InstanceView { get; set; }

        [JsonProperty("volumeMounts")]
        public VolumeMount[] VolumeMounts { get; set; }

        [JsonProperty("securityContext")]
        public SecurityContextDefinition SecurityContext { get; set; }
    }

    public class InitContainerPropertiesDefinitionInstanceViewType
    {
        [JsonProperty("restartCount")]
        public int RestartCount { get; set; }

        [JsonProperty("currentState")]
        public ContainerState CurrentState { get; set; }

        [JsonProperty("previousState")]
        public ContainerState PreviousState { get; set; }

        [JsonProperty("events")]
        public Event[] Events { get; set; }
    }

    public class DeploymentExtensionSpec
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public DeploymentExtensionSpecPropertiesType Properties { get; set; }
    }

    public class DeploymentExtensionSpecPropertiesType
    {
        [JsonProperty("extensionType")]
        public string ExtensionType { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("settings")]
        public JToken Settings { get; set; }

        [JsonProperty("protectedSettings")]
        public JToken ProtectedSettings { get; set; }
    }

    public class ConfidentialComputeProperties
    {
        [JsonProperty("ccePolicy")]
        public string CcePolicy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContainerGroupPropertiesPriorityType
    {
        Regular,
        Spot
    }

    public class UsageListResult
    {
        [JsonProperty("value")]
        public Usage[] Value { get; set; }
    }

    public class Usage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("currentValue")]
        public int CurrentValue { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("name")]
        public UsageNameType Name { get; set; }
    }

    public class UsageNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("localizedValue")]
        public string LocalizedValue { get; set; }
    }

    public class Logs
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ContainerExecResponse
    {
        [JsonProperty("webSocketUri")]
        public string WebSocketUri { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class ContainerAttachResponse
    {
        [JsonProperty("webSocketUri")]
        public string WebSocketUri { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class CachedImagesListResult
    {
        [JsonProperty("value")]
        public CachedImages[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class CachedImages
    {
        [JsonProperty("osType")]
        public string OsType { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class CapabilitiesListResult
    {
        [JsonProperty("value")]
        public CapabilitiesInfo[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class CapabilitiesInfo
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("osType")]
        public string OsType { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("ipAddressType")]
        public string IpAddressType { get; set; }

        [JsonProperty("gpu")]
        public string Gpu { get; set; }

        [JsonProperty("capabilities")]
        public CapabilitiesCapabilitiesType Capabilities { get; set; }
    }

    public class CapabilitiesCapabilitiesType
    {
        [JsonProperty("maxMemoryInGB")]
        public double MaxMemoryInGB { get; set; }

        [JsonProperty("maxCpu")]
        public double MaxCpu { get; set; }

        [JsonProperty("maxGpuCount")]
        public double MaxGpuCount { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aci;

    public partial class WorkflowManagedActions
    {
        public AciActions Aci(string connectionId) => new AciActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AciTriggers Aci(string connectionId) => new AciTriggers(connectionId);
    }
}