//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aci
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AciActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerGroupListResult> ContainerGroupsList([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/containerGroups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<ContainerGroupListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerGroupListResult> ContainerGroupsListByResourceGroup([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<ContainerGroupListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerGroup> ContainerGroupsGet([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<ContainerGroup>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerGroup> ContainerGroupsUpdate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> resourceid = null, [WorkflowExpression] Func<string> resourcename = null, [WorkflowExpression] Func<string> resourcetype = null, [WorkflowExpression] Func<string> resourcelocation = null, [WorkflowExpression] Func<string[]> resourcezones = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                var resource = new JObject();
                var resourcepropCount = 0;
                if (resourceid != null)
                {
                    resource["id"] = SourceExpressionConverter.ConvertToken(resourceid);
                    resourcepropCount++;
                }

                if (resourcename != null)
                {
                    resource["name"] = SourceExpressionConverter.ConvertToken(resourcename);
                    resourcepropCount++;
                }

                if (resourcetype != null)
                {
                    resource["type"] = SourceExpressionConverter.ConvertToken(resourcetype);
                    resourcepropCount++;
                }

                if (resourcelocation != null)
                {
                    resource["location"] = SourceExpressionConverter.ConvertToken(resourcelocation);
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
                    resource["zones"] = SourceExpressionConverter.ConvertToken(resourcezones);
                    resourcepropCount++;
                }

                if (resourcepropCount > 0)
                {
                    callPayload.Body = resource;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContainerGroup>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerGroup> ContainerGroupsDelete([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<ContainerGroup>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IWorkflowAction ContainerGroupsRestart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/restart", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IWorkflowAction ContainerGroupsStop([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/stop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IWorkflowAction ContainerGroupsStart([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<UsageListResult> LocationListUsage([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> location)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/locations/{1}/usages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<UsageListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<Logs> ContainerLogsList([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<int> tail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/containers/{3}/logs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                if (tail != null)
                    callPayload.Queries["tail"] = SourceExpressionConverter.ConvertO(tail);
                return callPayload;
            }

            return new ApiConnectionAction<Logs>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerExecResponse> ContainersExecuteCommand([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> containerName, [WorkflowExpression] Func<string> containerExecRequestcommand = null, [WorkflowExpression] Func<int> containerExecRequestterminalSizerows = null, [WorkflowExpression] Func<int> containerExecRequestterminalSizecols = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/containers/{3}/exec", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                var containerExecRequest = new JObject();
                var containerExecRequestpropCount = 0;
                if (containerExecRequestcommand != null)
                {
                    containerExecRequest["command"] = SourceExpressionConverter.ConvertToken(containerExecRequestcommand);
                    containerExecRequestpropCount++;
                }

                var terminalSizeObject = new JObject();
                var terminalSizeObjectpropCount = 0;
                if (containerExecRequestterminalSizerows != null)
                {
                    terminalSizeObject["rows"] = SourceExpressionConverter.ConvertToken(containerExecRequestterminalSizerows);
                    terminalSizeObjectpropCount++;
                }

                if (containerExecRequestterminalSizecols != null)
                {
                    terminalSizeObject["cols"] = SourceExpressionConverter.ConvertToken(containerExecRequestterminalSizecols);
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
                return callPayload;
            }

            return new ApiConnectionAction<ContainerExecResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<ContainerAttachResponse> ContainersAttach([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName, [WorkflowExpression] Func<string> containerName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/containers/{3}/attach", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<ContainerAttachResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<CachedImagesListResult> LocationListCachedImages([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> location)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/locations/{1}/cachedImages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<CachedImagesListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<CapabilitiesListResult> LocationListCapabilities([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> location)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/providers/Microsoft.ContainerInstance/locations/{1}/capabilities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<CapabilitiesListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IBodyWorkflowAction<string[]> ContainerGroupsGetOutboundNetworkDependenciesEndpoints([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> containerGroupName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.ContainerInstance/containerGroups/{2}/outboundNetworkDependenciesEndpoints", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerGroupName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aci")]
        public IWorkflowAction SubnetServiceAssociationLinkDelete([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<string> resourceGroupName, [WorkflowExpression] Func<string> virtualNetworkName, [WorkflowExpression] Func<string> subnetName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resourcegroups/{1}/providers/Microsoft.Network/virtualNetworks/{2}/subnets/{3}/providers/Microsoft.ContainerInstance/serviceAssociationLinks/default", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resourceGroupName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(virtualNetworkName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subnetName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2023-05-01");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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

    public enum PortProtocolType
    {
        TCP,
        UDP
    }

    public enum IpAddressTypeType
    {
        Public,
        Private
    }

    public enum IpAddressAutoGeneratedDomainNameLabelScopeType
    {
        Unsecure,
        TenantReuse,
        SubscriptionReuse,
        ResourceGroupReuse,
        Noreuse
    }

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