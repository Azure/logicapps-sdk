//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureiotcentral
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureiotcentralActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroupCollection> DeviceGroupsList(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/ga_2022_07_31/deviceGroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceGroupCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroup> DeviceGroupsGet(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/deviceGroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceGroupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceGroup>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroup> DeviceGroupsSet(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyfilter, Expression<Func<string>> bodydeviceGroupID = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyeTag = null, Expression<Func<string[]>> bodyorganizations = null)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/deviceGroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceGroupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeviceGroupID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodydeviceGroupID);
                bodypropCount++;
            }

            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            bodypropCount++;
            body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyeTag != null)
            {
                body["etag"] = ExpressionConverter.ConvertO(bodyeTag);
                bodypropCount++;
            }

            if (bodyorganizations != null)
            {
                body["organizations"] = ExpressionConverter.ConvertO(bodyorganizations);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeviceGroup>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction DeviceGroupsRemove(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/deviceGroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceGroupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceGroupDeviceCollection> DeviceGroupsGetDevices(Expression<Func<string>> application, Expression<Func<string>> deviceGroupId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/deviceGroups/{0}/devices", ExpressionConverter.ConvertWithUrlEncoding(deviceGroupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceGroupDeviceCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTemplateCollectionV1> DeviceTemplatesListV1(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/v1/deviceTemplates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceTemplateCollectionV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTemplateV1> DeviceTemplatesGetV1(Expression<Func<string>> application, Expression<Func<string>> templateId)
        {
            var apiCallPath = String.Format("/api/v1/deviceTemplates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceTemplateV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction DeviceTemplatesRemoveV1(Expression<Func<string>> application, Expression<Func<string>> templateId)
        {
            var apiCallPath = String.Format("/api/v1/deviceTemplates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesGetCloudProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> instanceOf = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}/cloudProperties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (instanceOf != null)
                callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(instanceOf);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesUpdateCloudProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> instanceOf = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}/cloudProperties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (instanceOf != null)
                callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(instanceOf);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCommand> DevicesExecuteComponentCommand(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> instanceOf = null, Expression<Func<bodyInput>> body = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}/components/{1}/commands/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (instanceOf != null)
                callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(instanceOf);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<DeviceCommand>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCommandV1> DevicesGetCommandResponseV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/commands/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCommandV1> DevicesRunCommandV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> commandName, Expression<Func<string>> template = null, Expression<Func<bodyInput>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/commands/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<DeviceCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceComponentCommandV1> DevicesGetComponentCommandResponseV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/components/{1}/commands/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceComponentCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceComponentCommandV1> DevicesRunComponentCommandV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> template = null, Expression<Func<bodyInput>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/components/{1}/commands/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<DeviceComponentCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleCommandV1> DevicesGetModuleCommandResponseV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/commands/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceModuleCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleCommandV1> DevicesRunModuleCommandV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> commandName, Expression<Func<string>> template = null, Expression<Func<bodyInput>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/commands/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<DeviceModuleCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleComponentCommandV1> DevicesGetModuleComponentCommandResponseV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/components/{2}/commands/{3}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceModuleComponentCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleComponentCommandV1> DevicesRunModuleComponentCommandV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> componentName, Expression<Func<string>> commandName, Expression<Func<string>> template = null, Expression<Func<bodyInput>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/components/{2}/commands/{3}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(commandName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<DeviceModuleComponentCommandV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceCollectionV1> DevicesListV1(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/v1/devices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceCollectionV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Device> DevicesGet(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<Device>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Device> DevicesSet(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> bodydeviceID = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodydeviceTemplate = null, Expression<Func<bool>> bodysimulated = null, Expression<Func<bool>> bodyapproved = null, Expression<Func<bool>> bodyprovisioned = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeviceID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodydeviceID);
                bodypropCount++;
            }

            if (bodydeviceName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydeviceName);
                bodypropCount++;
            }

            if (bodydeviceTemplate != null)
            {
                body["instanceOf"] = ExpressionConverter.ConvertO(bodydeviceTemplate);
                bodypropCount++;
            }

            if (bodysimulated != null)
            {
                body["simulated"] = ExpressionConverter.ConvertO(bodysimulated);
                bodypropCount++;
            }

            if (bodyapproved != null)
            {
                body["approved"] = ExpressionConverter.ConvertO(bodyapproved);
                bodypropCount++;
            }

            if (bodyprovisioned != null)
            {
                body["provisioned"] = ExpressionConverter.ConvertO(bodyprovisioned);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Device>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction DevicesRemove(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceV1> DevicesGetV1(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceV1> DevicesSetV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> bodydeviceID = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodydeviceTemplate = null, Expression<Func<bool>> bodysimulated = null, Expression<Func<bool>> bodyenabled = null, Expression<Func<bool>> bodyprovisioned = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeviceID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodydeviceID);
                bodypropCount++;
            }

            if (bodydeviceName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydeviceName);
                bodypropCount++;
            }

            if (bodydeviceTemplate != null)
            {
                body["template"] = ExpressionConverter.ConvertO(bodydeviceTemplate);
                bodypropCount++;
            }

            if (bodysimulated != null)
            {
                body["simulated"] = ExpressionConverter.ConvertO(bodysimulated);
                bodypropCount++;
            }

            if (bodyenabled != null)
            {
                body["enabled"] = ExpressionConverter.ConvertO(bodyenabled);
                bodypropCount++;
            }

            if (bodyprovisioned != null)
            {
                body["provisioned"] = ExpressionConverter.ConvertO(bodyprovisioned);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeviceV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction DevicesRemoveV1(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceV2> DevicesSetV2(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> bodydeviceID = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodydeviceTemplate = null, Expression<Func<bool>> bodysimulated = null, Expression<Func<bool>> bodyenabled = null, Expression<Func<string[]>> bodyorganizations = null, Expression<Func<bool>> bodyprovisioned = null)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/devices/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeviceID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodydeviceID);
                bodypropCount++;
            }

            if (bodydeviceName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydeviceName);
                bodypropCount++;
            }

            if (bodydeviceTemplate != null)
            {
                body["template"] = ExpressionConverter.ConvertO(bodydeviceTemplate);
                bodypropCount++;
            }

            if (bodysimulated != null)
            {
                body["simulated"] = ExpressionConverter.ConvertO(bodysimulated);
                bodypropCount++;
            }

            if (bodyenabled != null)
            {
                body["enabled"] = ExpressionConverter.ConvertO(bodyenabled);
                bodypropCount++;
            }

            if (bodyorganizations != null)
            {
                body["organizations"] = ExpressionConverter.ConvertO(bodyorganizations);
                bodypropCount++;
            }

            if (bodyprovisioned != null)
            {
                body["provisioned"] = ExpressionConverter.ConvertO(bodyprovisioned);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeviceV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesGetProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> instanceOf = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (instanceOf != null)
                callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(instanceOf);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesUpdateProperties(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> instanceOf = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (instanceOf != null)
                callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(instanceOf);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesGetPropertiesV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesUpdatePropertiesV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> template = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesGetModulePropertiesV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/properties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> DevicesUpdateModulePropertiesV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> template = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/properties", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipCollection> DeviceRelationshipsList(Expression<Func<string>> application, Expression<Func<string>> deviceId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/devices/{0}/relationships", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceRelationshipCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipStatic> DeviceRelationshipsGet(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> relationshipId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/devices/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeviceRelationshipStatic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipStatic> DeviceRelationshipsSet(Expression<Func<string>> application, Expression<Func<string>> relationshipId, Expression<Func<string>> deviceId, Expression<Func<string>> bodydeviceRelationshipTargetID, Expression<Func<string>> bodydeviceRelationshipID = null)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/devices/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeviceRelationshipID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodydeviceRelationshipID);
                bodypropCount++;
            }

            bodypropCount++;
            body["target"] = ExpressionConverter.ConvertO(bodydeviceRelationshipTargetID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeviceRelationshipStatic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceRelationshipStatic> DeviceRelationshipsUpdate(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> relationshipId, Expression<Func<string>> bodydeviceRelationshipTargetID, Expression<Func<string>> bodydeviceRelationshipID = null)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/devices/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeviceRelationshipID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodydeviceRelationshipID);
                bodypropCount++;
            }

            bodypropCount++;
            body["target"] = ExpressionConverter.ConvertO(bodydeviceRelationshipTargetID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeviceRelationshipStatic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction DeviceRelationshipsRemove(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> relationshipId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/devices/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTelemetry> DevicesGetComponentTelemetryValue(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> telemetryName, Expression<Func<string>> instanceOf = null)
        {
            var apiCallPath = String.Format("/api/preview/devices/{0}/components/{1}/telemetry/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(telemetryName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (instanceOf != null)
                callPayload.Queries["instanceOf"] = ExpressionConverter.Convert(instanceOf);
            return new ApiConnectionAction<DeviceTelemetry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceTelemetryV1> DevicesGetTelemetryValueV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/telemetry/{1}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(telemetryName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceTelemetryV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceComponentTelemetryV1> DevicesGetComponentTelemetryValueV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> componentName, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/components/{1}/telemetry/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(telemetryName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceComponentTelemetryV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleTelemetryV1> DevicesGetModuleTelemetryValueV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/telemetry/{2}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1), ExpressionConverter.ConvertWithUrlEncoding(telemetryName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceModuleTelemetryV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<DeviceModuleComponentTelemetryV1> DevicesGetModuleComponentTelemetryValueV1(Expression<Func<string>> application, Expression<Func<string>> deviceId, Expression<Func<string>> module, Expression<Func<string>> componentName, Expression<Func<string>> telemetryName, Expression<Func<string>> template = null)
        {
            var apiCallPath = String.Format("/api/v1/devices/{0}/modules/{1}/components/{2}/telemetry/{3}", ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(module, 1), ExpressionConverter.ConvertWithUrlEncoding(componentName, 1), ExpressionConverter.ConvertWithUrlEncoding(telemetryName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<DeviceModuleComponentTelemetryV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobCollection> JobsList(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/ga_2022_07_31/jobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<JobCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobStatic> JobsGet(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<JobStatic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobDeviceStatusCollection> JobsGetDevices(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/jobs/{0}/devices", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<JobDeviceStatusCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction JobsStop(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/jobs/{0}/stop", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction JobsResume(Expression<Func<string>> application, Expression<Func<string>> jobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/jobs/{0}/resume", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JobStatic> JobsRerun(Expression<Func<string>> application, Expression<Func<string>> jobId, Expression<Func<string>> rerunId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/jobs/{0}/rerun/{1}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1), ExpressionConverter.ConvertWithUrlEncoding(rerunId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<JobStatic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<OrganizationCollection> OrganizationsList(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/ga_2022_07_31/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<OrganizationCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Organization> OrganizationsGet(Expression<Func<string>> application, Expression<Func<string>> organizationId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<Organization>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<Organization> OrganizationsSet(Expression<Func<string>> application, Expression<Func<string>> organizationId, Expression<Func<string>> bodyorganizationID = null, Expression<Func<string>> bodyorganizationName = null, Expression<Func<string>> bodyparent = null)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyorganizationID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
            }

            if (bodyorganizationName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodyorganizationName);
                bodypropCount++;
            }

            if (bodyparent != null)
            {
                body["parent"] = ExpressionConverter.ConvertO(bodyparent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Organization>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction OrganizationsRemove(Expression<Func<string>> application, Expression<Func<string>> organizationId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<RoleCollectionV1> RolesListV1(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/v1/roles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<RoleCollectionV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<RoleV1> RolesGetV1(Expression<Func<string>> application, Expression<Func<string>> roleId)
        {
            var apiCallPath = String.Format("/api/v1/roles/{0}", ExpressionConverter.ConvertWithUrlEncoding(roleId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<RoleV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJobCollection> ScheduledJobsList(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/ga_2022_07_31/scheduledJobs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<ScheduledJobCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJob> ScheduledJobsGet(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/scheduledJobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(scheduledJobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<ScheduledJob>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction ScheduledJobsRemove(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/scheduledJobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(scheduledJobId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<ScheduledJobJobCollection> ScheduledJobsListJobs(Expression<Func<string>> application, Expression<Func<string>> scheduledJobId)
        {
            var apiCallPath = String.Format("/api/ga_2022_07_31/scheduledJobs/{0}/jobs", ExpressionConverter.ConvertWithUrlEncoding(scheduledJobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<ScheduledJobJobCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<UserCollectionV1> UsersListV1(Expression<Func<string>> application)
        {
            var apiCallPath = "/api/v1/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<UserCollectionV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<UserStaticV1> UsersGetV1(Expression<Func<string>> application, Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/api/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<UserStaticV1>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> UsersCreateV1(Expression<Func<string>> application, Expression<Func<string>> userId, Expression<Func<userTypeInput>> userType = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (userType != null)
                callPayload.Queries["user_type"] = ExpressionConverter.Convert(userType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IBodyWorkflowAction<JToken> UsersUpdateV1(Expression<Func<string>> application, Expression<Func<string>> userId, Expression<Func<userTypeInput>> userType = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (userType != null)
                callPayload.Queries["user_type"] = ExpressionConverter.Convert(userType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureiotcentral")]
        public IWorkflowAction UsersRemoveV1(Expression<Func<string>> application, Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/api/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AzureiotcentralTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<WorkflowTrigger> WorkflowCreateTrigger(Expression<Func<string>> application, Expression<Func<string>> bodyrule, Expression<Func<string>> bodyworkflowTriggerID = null, string triggerName = null)
        {
            var apiCallPath = "/api/preview/_internal/workflow/triggers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyworkflowTriggerID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyworkflowTriggerID);
                bodypropCount++;
            }

            bodypropCount++;
            body["rule"] = ExpressionConverter.ConvertO(bodyrule);
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WorkflowTrigger>(callPayload);
        }
    }

    public class DeviceGroupCollection
    {
        [JsonProperty("value")]
        public DeviceGroup[] DeviceGroupID { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceGroup
    {
        [JsonProperty("id")]
        public string DeviceGroupID { get; set; }

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
        public string DeviceID { get; set; }

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

    public class DeviceTemplateCollectionV1
    {
        [JsonProperty("value")]
        public DeviceTemplateV1[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class DeviceTemplateV1
    {
        [JsonProperty("@id")]
        public string DeviceTemplateID { get; set; }

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

    public class DeviceCommand
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestID { get; set; }

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
        public string DeviceCommandRequestID { get; set; }

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

    public class DeviceCommandV1
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestID { get; set; }

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
        public string DeviceCommandRequestID { get; set; }

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

    public class DeviceModuleCommandV1
    {
        [JsonProperty("id")]
        public string DeviceCommandRequestID { get; set; }

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
        public string DeviceCommandRequestID { get; set; }

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

    public class DeviceCollectionV1
    {
        [JsonProperty("value")]
        public DeviceV1[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class Device
    {
        [JsonProperty("id")]
        public string DeviceID { get; set; }

        [JsonProperty("etag")]
        public string DeviceETag { get; set; }

        [JsonProperty("displayName")]
        public string DeviceName { get; set; }

        [JsonProperty("instanceOf")]
        public string DeviceTemplate { get; set; }

        [JsonProperty("simulated")]
        public bool Simulated { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("provisioned")]
        public bool Provisioned { get; set; }
    }

    public class DeviceV2
    {
        [JsonProperty("id")]
        public string DeviceID { get; set; }

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
        public string DeviceRelationshipID { get; set; }

        [JsonProperty("source")]
        public string DeviceRelationshipSourceID { get; set; }

        [JsonProperty("target")]
        public string DeviceRelationshipTargetID { get; set; }
    }

    public class DeviceTelemetry
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

    public class DeviceComponentTelemetryV1
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

    public class DeviceModuleComponentTelemetryV1
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
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
        public string JobID { get; set; }

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
        public string ScheduledJobID { get; set; }
    }

    public class JobBatch
    {
        [JsonProperty("type")]
        public JobBatchBatchTypeType BatchType { get; set; }

        [JsonProperty("value")]
        public double BatchValue { get; set; }
    }

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

    public enum JobCancellationThresholdCancellationThresholdTypeType
    {
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "percentage")]
        Percentage
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
        public string DeviceID { get; set; }

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
        public string OrganizationID { get; set; }

        [JsonProperty("displayName")]
        public string OrganizationName { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    public class RoleCollectionV1
    {
        [JsonProperty("value")]
        public RoleV1[] Value { get; set; }
    }

    public class RoleV1
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
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
        public string ScheduledJobID { get; set; }

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

    public class ScheduledJobJobCollection
    {
        [JsonProperty("value")]
        public JobStatic[] Value { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class UserCollectionV1
    {
        [JsonProperty("value")]
        public UserStaticV1[] Users { get; set; }
    }

    public class UserStaticV1
    {
        [JsonProperty("id")]
        public string UserID { get; set; }

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

    public enum userTypeInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal
    }

    public class WorkflowTrigger
    {
        [JsonProperty("id")]
        public string WorkflowTriggerID { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("url")]
        public string WorkflowTriggerURL { get; set; }
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