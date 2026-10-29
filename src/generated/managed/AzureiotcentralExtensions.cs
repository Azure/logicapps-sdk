//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureiotcentral
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureiotcentralActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroupCollection, ApiConnectionActionConfiguration> DeviceGroupsList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<DeviceGroupCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ga_2022_07_31/deviceGroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceGroupCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroup, ApiConnectionActionConfiguration> DeviceGroupsGet(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceGroupId = WorkflowExpression.Compile(deviceGroupId, nameof(deviceGroupId), required: true);
            return new DeferredBodyAction<DeviceGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/deviceGroups/{0}", __workflow_deviceGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroup, ApiConnectionActionConfiguration> DeviceGroupsSet(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId, Expression<Func<DeviceGroupsSetInput>> body)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceGroupId = WorkflowExpression.Compile(deviceGroupId, nameof(deviceGroupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeviceGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/deviceGroups/{0}", __workflow_deviceGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeviceGroupsRemove(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceGroupId = WorkflowExpression.Compile(deviceGroupId, nameof(deviceGroupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/deviceGroups/{0}", __workflow_deviceGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroupDeviceCollection, ApiConnectionActionConfiguration> DeviceGroupsGetDevices(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceGroupId = WorkflowExpression.Compile(deviceGroupId, nameof(deviceGroupId), required: true);
            return new DeferredBodyAction<DeviceGroupDeviceCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/deviceGroups/{0}/devices", __workflow_deviceGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceGroupDeviceCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DevicesGetCloudProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> instanceOf = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_instanceOf = WorkflowExpression.Compile(instanceOf, nameof(instanceOf), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/preview/devices/{0}/cloudProperties", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_instanceOf != null)
                    callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(__workflow_instanceOf);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DevicesUpdateCloudProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<object>> body, Expression<Func<string>> instanceOf = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_instanceOf = WorkflowExpression.Compile(instanceOf, nameof(instanceOf), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/preview/devices/{0}/cloudProperties", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_instanceOf != null)
                    callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(__workflow_instanceOf);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCommand, ApiConnectionActionConfiguration> DevicesExecuteComponentCommand(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<bodyInput>> body, Expression<Func<string>> instanceOf = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_instanceOf = WorkflowExpression.Compile(instanceOf, nameof(instanceOf), required: false);
            return new DeferredBodyAction<DeviceCommand, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/preview/devices/{0}/components/{1}/commands/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_instanceOf != null)
                    callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(__workflow_instanceOf);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceCommand>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipCollection, ApiConnectionActionConfiguration> DeviceRelationshipsList(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            return new DeferredBodyAction<DeviceRelationshipCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/devices/{0}/relationships", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceRelationshipCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipStatic, ApiConnectionActionConfiguration> DeviceRelationshipsGet(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> relationshipId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            return new DeferredBodyAction<DeviceRelationshipStatic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/devices/{0}/relationships/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceRelationshipStatic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipStatic, ApiConnectionActionConfiguration> DeviceRelationshipsSet(Expression<Func<string>> application, Expression<Func<string>> relationshipId, Expression<Func<string>> deviceId, Expression<Func<DeviceRelationshipsSetInput>> body)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeviceRelationshipStatic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/devices/{0}/relationships/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceRelationshipStatic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipStatic, ApiConnectionActionConfiguration> DeviceRelationshipsUpdate(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> relationshipId, Expression<Func<DeviceRelationshipsUpdateInput>> body)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeviceRelationshipStatic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/devices/{0}/relationships/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceRelationshipStatic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeviceRelationshipsRemove(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> relationshipId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/devices/{0}/relationships/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobCollection, ApiConnectionActionConfiguration> JobsList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<JobCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ga_2022_07_31/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<JobCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobStatic, ApiConnectionActionConfiguration> JobsGet(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JobStatic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<JobStatic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Job, ApiConnectionActionConfiguration> JobsSet(Expression<Func<string>> application, Expression<Func<string>> jobId, Expression<Func<bodyInput2>> body, Expression<Func<jobTypeInput>> jobType = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_jobType = WorkflowExpression.Compile(jobType, nameof(jobType), required: false);
            return new DeferredBodyAction<Job, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_jobType != null)
                    callPayload.Queries["job_type"] = ExpressionConverter.Convert(__workflow_jobType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Job>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobDeviceStatusCollection, ApiConnectionActionConfiguration> JobsGetDevices(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JobDeviceStatusCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/jobs/{0}/devices", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<JobDeviceStatusCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JobsStop(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/jobs/{0}/stop", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JobsResume(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/jobs/{0}/resume", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobStatic, ApiConnectionActionConfiguration> JobsRerun(Expression<Func<string>> application, Expression<Func<string>> jobId, Expression<Func<string>> rerunId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_rerunId = WorkflowExpression.Compile(rerunId, nameof(rerunId), required: true);
            return new DeferredBodyAction<JobStatic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/jobs/{0}/rerun/{1}", __workflow_jobId.WithUrlEncoding(1), __workflow_rerunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<JobStatic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<OrganizationCollection, ApiConnectionActionConfiguration> OrganizationsList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<OrganizationCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ga_2022_07_31/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<OrganizationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Organization, ApiConnectionActionConfiguration> OrganizationsGet(Expression<Func<string>> application, Expression<Func<string>> organizationId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<Organization, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/organizations/{0}", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<Organization>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Organization, ApiConnectionActionConfiguration> OrganizationsSet(Expression<Func<string>> application, Expression<Func<string>> organizationId, Expression<Func<OrganizationsSetInput>> body)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Organization, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/organizations/{0}", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Organization>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OrganizationsRemove(Expression<Func<string>> application, Expression<Func<string>> organizationId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/organizations/{0}", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJobCollection, ApiConnectionActionConfiguration> ScheduledJobsList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<ScheduledJobCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ga_2022_07_31/scheduledJobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<ScheduledJobCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJob, ApiConnectionActionConfiguration> ScheduledJobsGet(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_scheduledJobId = WorkflowExpression.Compile(scheduledJobId, nameof(scheduledJobId), required: true);
            return new DeferredBodyAction<ScheduledJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/scheduledJobs/{0}", __workflow_scheduledJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<ScheduledJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJob, ApiConnectionActionConfiguration> ScheduledJobsSet(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId, Expression<Func<bodyInput22>> body, Expression<Func<jobTypeInput>> jobType = null, Expression<Func<scheduledJobEndTypeInput>> scheduledJobEndType = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_scheduledJobId = WorkflowExpression.Compile(scheduledJobId, nameof(scheduledJobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_jobType = WorkflowExpression.Compile(jobType, nameof(jobType), required: false);
            var __workflow_scheduledJobEndType = WorkflowExpression.Compile(scheduledJobEndType, nameof(scheduledJobEndType), required: false);
            return new DeferredBodyAction<ScheduledJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/scheduledJobs/{0}", __workflow_scheduledJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_jobType != null)
                    callPayload.Queries["job_type"] = ExpressionConverter.Convert(__workflow_jobType);
                if (__workflow_scheduledJobEndType != null)
                    callPayload.Queries["scheduled_job_end_type"] = ExpressionConverter.Convert(__workflow_scheduledJobEndType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduledJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJobStatic, ApiConnectionActionConfiguration> ScheduledJobsUpdate(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId, Expression<Func<bodyInput222>> body, Expression<Func<scheduledJobEndTypeInput>> scheduledJobEndType = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_scheduledJobId = WorkflowExpression.Compile(scheduledJobId, nameof(scheduledJobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_scheduledJobEndType = WorkflowExpression.Compile(scheduledJobEndType, nameof(scheduledJobEndType), required: false);
            return new DeferredBodyAction<ScheduledJobStatic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/scheduledJobs/{0}", __workflow_scheduledJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_scheduledJobEndType != null)
                    callPayload.Queries["scheduled_job_end_type"] = ExpressionConverter.Convert(__workflow_scheduledJobEndType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduledJobStatic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduledJobsRemove(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_scheduledJobId = WorkflowExpression.Compile(scheduledJobId, nameof(scheduledJobId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/scheduledJobs/{0}", __workflow_scheduledJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJobJobCollection, ApiConnectionActionConfiguration> ScheduledJobsListJobs(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_scheduledJobId = WorkflowExpression.Compile(scheduledJobId, nameof(scheduledJobId), required: true);
            return new DeferredBodyAction<ScheduledJobJobCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/scheduledJobs/{0}/jobs", __workflow_scheduledJobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<ScheduledJobJobCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceV1, ApiConnectionActionConfiguration> DevicesGet(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            return new DeferredBodyAction<DeviceV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCommandV1, ApiConnectionActionConfiguration> DevicesGetCommandResponse(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/commands/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceComponentCommandV1, ApiConnectionActionConfiguration> DevicesGetComponentCommandResponse(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceComponentCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/components/{1}/commands/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceComponentCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceComponentTelemetryV1, ApiConnectionActionConfiguration> DevicesGetComponentTelemetryValue(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_telemetryName = WorkflowExpression.Compile(telemetryName, nameof(telemetryName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceComponentTelemetryV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/components/{1}/telemetry/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_telemetryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceComponentTelemetryV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleCommandV1, ApiConnectionActionConfiguration> DevicesGetModuleCommandResponse(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceModuleCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/commands/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceModuleCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleComponentCommandV1, ApiConnectionActionConfiguration> DevicesGetModuleComponentCommandResponse(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceModuleComponentCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/components/{2}/commands/{3}", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceModuleComponentCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleComponentTelemetryV1, ApiConnectionActionConfiguration> DevicesGetModuleComponentTelemetryValue(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> componentName, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_telemetryName = WorkflowExpression.Compile(telemetryName, nameof(telemetryName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceModuleComponentTelemetryV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/components/{2}/telemetry/{3}", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_telemetryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceModuleComponentTelemetryV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DevicesGetModuleProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/properties", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleTelemetryV1, ApiConnectionActionConfiguration> DevicesGetModuleTelemetryValue(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_telemetryName = WorkflowExpression.Compile(telemetryName, nameof(telemetryName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceModuleTelemetryV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/telemetry/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1), __workflow_telemetryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceModuleTelemetryV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DevicesGetProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/properties", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTelemetryV1, ApiConnectionActionConfiguration> DevicesGetTelemetryValue(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_telemetryName = WorkflowExpression.Compile(telemetryName, nameof(telemetryName), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceTelemetryV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/telemetry/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_telemetryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DeviceTelemetryV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCollectionV1, ApiConnectionActionConfiguration> DevicesList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<DeviceCollectionV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/devices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceCollectionV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DevicesRemove(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCommandV1, ApiConnectionActionConfiguration> DevicesRunCommand(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> commandName, Expression<Func<bodyInput>> body, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/commands/{1}", __workflow_deviceId.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceComponentCommandV1, ApiConnectionActionConfiguration> DevicesRunComponentCommand(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<bodyInput>> body, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceComponentCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/components/{1}/commands/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceComponentCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleCommandV1, ApiConnectionActionConfiguration> DevicesRunModuleCommand(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> commandName, Expression<Func<bodyInput>> body, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceModuleCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/commands/{2}", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceModuleCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleComponentCommandV1, ApiConnectionActionConfiguration> DevicesRunModuleComponentCommand(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<bodyInput>> body, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_componentName = WorkflowExpression.Compile(componentName, nameof(componentName), required: true);
            var __workflow_commandName = WorkflowExpression.Compile(commandName, nameof(commandName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<DeviceModuleComponentCommandV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/components/{2}/commands/{3}", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1), __workflow_componentName.WithUrlEncoding(1), __workflow_commandName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceModuleComponentCommandV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceV2, ApiConnectionActionConfiguration> DevicesSet(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<DevicesSetV2Input>> body)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeviceV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ga_2022_07_31/devices/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeviceV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DevicesUpdateModuleProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<object>> body, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/modules/{1}/properties", __workflow_deviceId.WithUrlEncoding(1), __workflow_module.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DevicesUpdateProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<object>> body, Expression<Func<string>> template = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/devices/{0}/properties", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTemplateV1, ApiConnectionActionConfiguration> DeviceTemplatesGet(Expression<Func<string>> application, Expression<Func<string>> templateId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<DeviceTemplateV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/deviceTemplates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceTemplateV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTemplateCollectionV1, ApiConnectionActionConfiguration> DeviceTemplatesList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<DeviceTemplateCollectionV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/deviceTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeviceTemplateCollectionV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeviceTemplatesRemove(Expression<Func<string>> application, Expression<Func<string>> templateId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/deviceTemplates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<RoleV1, ApiConnectionActionConfiguration> RolesGet(Expression<Func<string>> application, Expression<Func<string>> roleId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_roleId = WorkflowExpression.Compile(roleId, nameof(roleId), required: true);
            return new DeferredBodyAction<RoleV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/roles/{0}", __workflow_roleId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<RoleV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<RoleCollectionV1, ApiConnectionActionConfiguration> RolesList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<RoleCollectionV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<RoleCollectionV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UsersCreate(Expression<Func<string>> application, Expression<Func<string>> userId, Expression<Func<object>> body, Expression<Func<userTypeInput>> userType = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_userType != null)
                    callPayload.Queries["user_type"] = ExpressionConverter.Convert(__workflow_userType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<UserStaticV1, ApiConnectionActionConfiguration> UsersGet(Expression<Func<string>> application, Expression<Func<string>> userId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserStaticV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<UserStaticV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<UserCollectionV1, ApiConnectionActionConfiguration> UsersList(Expression<Func<string>> application)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            return new DeferredBodyAction<UserCollectionV1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<UserCollectionV1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UsersRemove(Expression<Func<string>> application, Expression<Func<string>> userId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UsersUpdate(Expression<Func<string>> application, Expression<Func<string>> userId, Expression<Func<object>> body, Expression<Func<userTypeInput>> userType = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_userType = WorkflowExpression.Compile(userType, nameof(userType), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_userType != null)
                    callPayload.Queries["user_type"] = ExpressionConverter.Convert(__workflow_userType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AzureiotcentralTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WorkflowTrigger, ApiConnectionTriggerConfiguration> WorkflowCreateTrigger(Expression<Func<string>> application, Expression<Func<WorkflowCreateTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WorkflowTrigger, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/preview/_internal/workflow/triggers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WorkflowTrigger>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class DeviceGroupCollection
    {
        [JsonProperty("value")]
        public DeviceGroup[] DeviceGroupId { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceGroup
    {
        [JsonProperty("id")]
        public string DeviceGroupId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }
    }

    public class DeviceGroupsSetInput
    {
        [JsonProperty("id")]
        public string DeviceGroupId { get; set; }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filter { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }
    }

    public class DeviceGroupDeviceCollection
    {
        [JsonProperty("value")]
        public DeviceV1[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceV1
    {
        [JsonProperty("id")]
        public string DeviceId { get; set; }

        [JsonProperty("etag")]
        public string DeviceETag { get; set; }

        [JsonProperty("displayName")]
        public string DeviceName { get; set; }

        [JsonProperty("template")]
        public string DeviceTemplate { get; set; }

        [JsonProperty("simulated")]
        public bool Simulated { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("provisioned")]
        public bool Provisioned { get; set; }
    }

    public class DeviceCommand
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestId { get; set; }

        [JsonProperty("request")]
        public JToken DeviceCommandRequestPayload { get; set; }

        [JsonProperty("response")]
        public JToken DeviceCommandResponsePayload { get; set; }

        [JsonProperty("connectionTimeout")]
        public int DeviceCommandConnectionTimeout { get; set; }

        [JsonProperty("responseTimeout")]
        public int DeviceCommandResponseTimeout { get; set; }

        [JsonProperty("responseCode")]
        public int DeviceCommandResponseStatus { get; set; }
    }

    public class bodyInput
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestId { get; set; }

        [JsonProperty("request")]
        public JToken DeviceCommandRequestPayload { get; set; }

        [JsonProperty("response")]
        public JToken DeviceCommandResponsePayload { get; set; }

        [JsonProperty("connectionTimeout")]
        public int DeviceCommandConnectionTimeout { get; set; }

        [JsonProperty("responseTimeout")]
        public int DeviceCommandResponseTimeout { get; set; }

        [JsonProperty("responseCode")]
        public int DeviceCommandResponseStatus { get; set; }
    }

    public class DeviceRelationshipCollection
    {
        [JsonProperty("value")]
        public DeviceRelationshipStatic[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceRelationshipStatic
    {
        [JsonProperty("id")]
        public string DeviceRelationshipId { get; set; }

        [JsonProperty("source")]
        public string DeviceRelationshipSourceId { get; set; }

        [JsonProperty("target")]
        public string DeviceRelationshipTargetId { get; set; }
    }

    public class DeviceRelationshipsSetInput
    {
        [JsonProperty("id")]
        public string DeviceRelationshipId { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceRelationshipTargetId { get; set; }
    }

    public class DeviceRelationshipsUpdateInput
    {
        [JsonProperty("id")]
        public string DeviceRelationshipId { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceRelationshipTargetId { get; set; }
    }

    public class JobCollection
    {
        [JsonProperty("value")]
        public JobStatic[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class JobStatic
    {
        [JsonProperty("id")]
        public string JobId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("group")]
        public string DeviceGroup { get; set; }

        [JsonProperty("batch")]
        public JobBatch Batch { get; set; }

        [JsonProperty("cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("scheduledJobId")]
        public string ScheduledJobId { get; set; }
    }

    public class JobBatch
    {
        [JsonProperty("type")]
        public JobBatchBatchTypeType BatchType { get; set; }

        [JsonProperty("value")]
        public double BatchValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobBatchBatchTypeType
    {
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "percentage")]
        Percentage
    }

    public class JobCancellationThreshold
    {
        [JsonProperty("type")]
        public JobCancellationThresholdCancellationThresholdTypeType CancellationThresholdType { get; set; }

        [JsonProperty("value")]
        public double CancellationThresholdValue { get; set; }

        [JsonProperty("batch")]
        public bool CancellationThresholdBatch { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobCancellationThresholdCancellationThresholdTypeType
    {
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "percentage")]
        Percentage
    }

    public class Job
    {
        [JsonProperty("id")]
        public string JobId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("group")]
        public string DeviceGroup { get; set; }

        [JsonProperty("batch")]
        public JobBatch Batch { get; set; }

        [JsonProperty("cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("scheduledJobId")]
        public string ScheduledJobId { get; set; }
    }

    public class bodyInput2
    {
        [JsonProperty("id")]
        public string JobId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("group")]
        public string DeviceGroup { get; set; }

        [JsonProperty("batch")]
        public JobBatch Batch { get; set; }

        [JsonProperty("cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("scheduledJobId")]
        public string ScheduledJobId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jobTypeInput
    {
        [EnumMember(Value = "cloudProperty")]
        CloudProperty,
        [EnumMember(Value = "command")]
        Command,
        [EnumMember(Value = "deviceTemplateMigration")]
        DeviceTemplateMigration,
        [EnumMember(Value = "property")]
        Property
    }

    public class JobDeviceStatusCollection
    {
        [JsonProperty("value")]
        public JobDeviceStatus[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class JobDeviceStatus
    {
        [JsonProperty("id")]
        public string DeviceId { get; set; }

        [JsonProperty("status")]
        public string DeviceStatus { get; set; }
    }

    public class OrganizationCollection
    {
        [JsonProperty("value")]
        public Organization[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class Organization
    {
        [JsonProperty("id")]
        public string OrganizationId { get; set; }

        [JsonProperty("displayName")]
        public string OrganizationName { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    public class OrganizationsSetInput
    {
        [JsonProperty("id")]
        public string OrganizationId { get; set; }

        [JsonProperty("displayName")]
        public string OrganizationName { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    public class ScheduledJobCollection
    {
        [JsonProperty("value")]
        public ScheduledJob[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ScheduledJob
    {
        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("group")]
        public string DeviceGroup { get; set; }

        [JsonProperty("batch")]
        public JobBatch Batch { get; set; }

        [JsonProperty("cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("schedule")]
        public JToken Schedule { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class bodyInput22
    {
        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("group")]
        public string DeviceGroup { get; set; }

        [JsonProperty("batch")]
        public JobBatch Batch { get; set; }

        [JsonProperty("cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("schedule")]
        public JToken Schedule { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum scheduledJobEndTypeInput
    {
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "occurrences")]
        Occurrences
    }

    public class ScheduledJobStatic
    {
        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("group")]
        public string DeviceGroup { get; set; }

        [JsonProperty("batch")]
        public JobBatch Batch { get; set; }

        [JsonProperty("cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("schedule")]
        public JToken Schedule { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class bodyInput222
    {
        [JsonProperty("etag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("schedule")]
        public JToken Schedule { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class ScheduledJobJobCollection
    {
        [JsonProperty("value")]
        public JobStatic[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceCommandV1
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestId { get; set; }

        [JsonProperty("request")]
        public JToken DeviceCommandRequestPayload { get; set; }

        [JsonProperty("response")]
        public JToken DeviceCommandResponsePayload { get; set; }

        [JsonProperty("connectionTimeout")]
        public int DeviceCommandConnectionTimeout { get; set; }

        [JsonProperty("responseTimeout")]
        public int DeviceCommandResponseTimeout { get; set; }

        [JsonProperty("responseCode")]
        public int DeviceCommandResponseStatus { get; set; }
    }

    public class DeviceComponentCommandV1
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestId { get; set; }

        [JsonProperty("request")]
        public JToken DeviceCommandRequestPayload { get; set; }

        [JsonProperty("response")]
        public JToken DeviceCommandResponsePayload { get; set; }

        [JsonProperty("connectionTimeout")]
        public int DeviceCommandConnectionTimeout { get; set; }

        [JsonProperty("responseTimeout")]
        public int DeviceCommandResponseTimeout { get; set; }

        [JsonProperty("responseCode")]
        public int DeviceCommandResponseStatus { get; set; }
    }

    public class DeviceComponentTelemetryV1
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DeviceModuleCommandV1
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestId { get; set; }

        [JsonProperty("request")]
        public JToken DeviceCommandRequestPayload { get; set; }

        [JsonProperty("response")]
        public JToken DeviceCommandResponsePayload { get; set; }

        [JsonProperty("connectionTimeout")]
        public int DeviceCommandConnectionTimeout { get; set; }

        [JsonProperty("responseTimeout")]
        public int DeviceCommandResponseTimeout { get; set; }

        [JsonProperty("responseCode")]
        public int DeviceCommandResponseStatus { get; set; }
    }

    public class DeviceModuleComponentCommandV1
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestId { get; set; }

        [JsonProperty("request")]
        public JToken DeviceCommandRequestPayload { get; set; }

        [JsonProperty("response")]
        public JToken DeviceCommandResponsePayload { get; set; }

        [JsonProperty("connectionTimeout")]
        public int DeviceCommandConnectionTimeout { get; set; }

        [JsonProperty("responseTimeout")]
        public int DeviceCommandResponseTimeout { get; set; }

        [JsonProperty("responseCode")]
        public int DeviceCommandResponseStatus { get; set; }
    }

    public class DeviceModuleComponentTelemetryV1
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DeviceModuleTelemetryV1
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DeviceTelemetryV1
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class DeviceCollectionV1
    {
        [JsonProperty("value")]
        public DeviceV1[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceV2
    {
        [JsonProperty("id")]
        public string DeviceId { get; set; }

        [JsonProperty("etag")]
        public string DeviceETag { get; set; }

        [JsonProperty("displayName")]
        public string DeviceName { get; set; }

        [JsonProperty("template")]
        public string DeviceTemplate { get; set; }

        [JsonProperty("simulated")]
        public bool Simulated { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("provisioned")]
        public bool Provisioned { get; set; }
    }

    public class DevicesSetV2Input
    {
        [JsonProperty("id")]
        public string DeviceId { get; set; }

        [JsonProperty("displayName")]
        public string DeviceName { get; set; }

        [JsonProperty("template")]
        public string DeviceTemplate { get; set; }

        [JsonProperty("simulated")]
        public bool? Simulated { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("organizations")]
        public string[] Organizations { get; set; }

        [JsonProperty("provisioned")]
        public bool? Provisioned { get; set; }
    }

    public class DeviceTemplateV1
    {
        [JsonProperty("@id")]
        public string DeviceTemplateId { get; set; }

        [JsonProperty("etag")]
        public string DeviceTemplateETag { get; set; }

        [JsonProperty("@type")]
        public string[] DeviceTemplateTypes { get; set; }

        [JsonProperty("displayName")]
        public string DeviceTemplateName { get; set; }

        [JsonProperty("description")]
        public string DeviceTemplateDescription { get; set; }

        [JsonProperty("capabilityModel")]
        public JToken DeviceTemplateCapabilityModel { get; set; }
    }

    public class DeviceTemplateCollectionV1
    {
        [JsonProperty("value")]
        public DeviceTemplateV1[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class RoleV1
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class RoleCollectionV1
    {
        [JsonProperty("value")]
        public RoleV1[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum userTypeInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal
    }

    public class UserStaticV1
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("type")]
        public string UserType { get; set; }

        [JsonProperty("roles")]
        public RoleAssignmentV1[] Roles { get; set; }
    }

    public class RoleAssignmentV1
    {
        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class UserCollectionV1
    {
        [JsonProperty("value")]
        public UserStaticV1[] Users { get; set; }
    }

    public class WorkflowTrigger
    {
        [JsonProperty("id")]
        public string WorkflowTriggerId { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("url")]
        public string WorkflowTriggerURL { get; set; }
    }

    public class WorkflowCreateTriggerInput
    {
        [JsonProperty("id")]
        public string WorkflowTriggerId { get; set; }

        [JsonProperty("rule", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Rule { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WorkflowTriggerURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureiotcentral;

    public partial class WorkflowManagedActions
    {
        public AzureiotcentralActions Azureiotcentral(string connectionId) => new AzureiotcentralActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureiotcentralTriggers Azureiotcentral(string connectionId) => new AzureiotcentralTriggers(connectionId);
    }
}