//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Govee
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoveeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<GetDeviceInformationResponse> GetDeviceInformation(Expression<Func<string>> device = null, Expression<Func<string>> model = null)
        {
            var apiCallPath = "/devices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (device != null)
                callPayload.Queries["device"] = ExpressionConverter.Convert(device);
            if (model != null)
                callPayload.Queries["model"] = ExpressionConverter.Convert(model);
            return new ApiConnectionAction<GetDeviceInformationResponse>(callPayload);
        }
    }

    public class GoveeTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDeviceInformationResponse
    {
        [JsonProperty("data")]
        public GetDeviceInformationResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int StatusCode { get; set; }
    }

    public class GetDeviceInformationResponseDataType
    {
        [JsonProperty("devices")]
        public GetDeviceInformationResponseDataTypeDevicesTypeItem[] Devices { get; set; }
    }

    public class GetDeviceInformationResponseDataTypeDevicesTypeItem
    {
        [JsonProperty("device")]
        public string DeviceMACAddress { get; set; }

        [JsonProperty("model")]
        public string DeviceModel { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("controllable")]
        public bool Controllable { get; set; }

        [JsonProperty("properties")]
        public GetDeviceInformationResponseDataTypeDevicesTypeItemPropertiesType Properties { get; set; }

        [JsonProperty("retrievable")]
        public bool Retrievable { get; set; }

        [JsonProperty("supportCmds")]
        public string[] SupportedCommands { get; set; }
    }

    public class GetDeviceInformationResponseDataTypeDevicesTypeItemPropertiesType
    {
        [JsonProperty("colorTem")]
        public GetDeviceInformationResponseDataTypeDevicesTypeItemPropertiesTypeColorTemperatureType ColorTemperature { get; set; }
    }

    public class GetDeviceInformationResponseDataTypeDevicesTypeItemPropertiesTypeColorTemperatureType
    {
        [JsonProperty("range")]
        public GetDeviceInformationResponseDataTypeDevicesTypeItemPropertiesTypeColorTemperatureTypeRangeType Range { get; set; }
    }

    public class GetDeviceInformationResponseDataTypeDevicesTypeItemPropertiesTypeColorTemperatureTypeRangeType
    {
        [JsonProperty("min")]
        public int Minimum { get; set; }

        [JsonProperty("max")]
        public int Maximum { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Govee;

    public partial class WorkflowManagedActions
    {
        public GoveeActions Govee(string connectionId) => new GoveeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoveeTriggers Govee(string connectionId) => new GoveeTriggers(connectionId);
    }
}