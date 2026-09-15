//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Govee
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoveeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<RunCommandOnDeviceResponse> RunCommandOnDevice(Expression<Func<string>> bodydeviceMACAddress, Expression<Func<string>> bodydeviceModel, Expression<Func<bodycmdcommandNameInput>> bodycmdcommandName = null, Expression<Func<bodyturnInput>> bodyturn = null, Expression<Func<int>> bodybrightness = null, Expression<Func<int>> bodycolorcolorRed = null, Expression<Func<int>> bodycolorcolorGreen = null, Expression<Func<int>> bodycolorcolorBlue = null, Expression<Func<int>> bodycolorTemperature = null)
        {
            var apiCallPath = "/devices/control";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["device"] = CSharpExpressionConverter.ConvertToken(bodydeviceMACAddress);
            bodypropCount++;
            body["model"] = CSharpExpressionConverter.ConvertToken(bodydeviceModel);
            var cmdObject = new JObject();
            var cmdObjectpropCount = 0;
            if (bodycmdcommandName != null)
            {
                cmdObject["name"] = CSharpExpressionConverter.Convert(bodycmdcommandName);
                cmdObjectpropCount++;
            }

            if (cmdObjectpropCount > 0)
            {
                body["cmd"] = cmdObject;
                bodypropCount++;
            }

            if (bodyturn != null)
            {
                body["turn"] = CSharpExpressionConverter.Convert(bodyturn);
                bodypropCount++;
            }

            if (bodybrightness != null)
            {
                body["brightness"] = CSharpExpressionConverter.ConvertToken(bodybrightness);
                bodypropCount++;
            }

            var colorObject = new JObject();
            var colorObjectpropCount = 0;
            if (bodycolorcolorRed != null)
            {
                colorObject["r"] = CSharpExpressionConverter.ConvertToken(bodycolorcolorRed);
                colorObjectpropCount++;
            }

            if (bodycolorcolorGreen != null)
            {
                colorObject["g"] = CSharpExpressionConverter.ConvertToken(bodycolorcolorGreen);
                colorObjectpropCount++;
            }

            if (bodycolorcolorBlue != null)
            {
                colorObject["b"] = CSharpExpressionConverter.ConvertToken(bodycolorcolorBlue);
                colorObjectpropCount++;
            }

            if (colorObjectpropCount > 0)
            {
                body["color"] = colorObject;
                bodypropCount++;
            }

            if (bodycolorTemperature != null)
            {
                body["colorTem"] = CSharpExpressionConverter.ConvertToken(bodycolorTemperature);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RunCommandOnDeviceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<GetDeviceInformationResponse> GetDeviceInformation(Expression<Func<string>> device = null, Expression<Func<string>> model = null)
        {
            var apiCallPath = "/devices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (device != null)
                callPayload.Queries["device"] = CSharpExpressionConverter.ConvertO(device);
            if (model != null)
                callPayload.Queries["model"] = CSharpExpressionConverter.ConvertO(model);
            return new ApiConnectionAction<GetDeviceInformationResponse>(callPayload);
        }
    }

    public class GoveeTriggers([ConnectionName] string connectionId)
    {
    }

    public class RunCommandOnDeviceResponse
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public enum bodycmdcommandNameInput
    {
        [EnumMember(Value = "turn")]
        Turn,
        [EnumMember(Value = "brightness")]
        Brightness,
        [EnumMember(Value = "color")]
        Color,
        [EnumMember(Value = "colorTem")]
        ColorTem
    }

    public enum bodyturnInput
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Govee;

    public partial class WorkflowManagedActions
    {
        public GoveeActions Govee(string connectionId) => new GoveeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoveeTriggers Govee(string connectionId) => new GoveeTriggers(connectionId);
    }
}