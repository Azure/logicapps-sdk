//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Govee
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GoveeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<RunCommandOnDeviceResponse> RunCommandOnDevice(Expression<Func<string>> bodydeviceMACAddress, Expression<Func<string>> bodydeviceModel, Expression<Func<bodycmdcommandNameInput>> bodycmdcommandName = null, Expression<Func<bodyturnInput>> bodyturn = null, Expression<Func<int>> bodybrightness = null, Expression<Func<int>> bodycolorcolorRed = null, Expression<Func<int>> bodycolorcolorGreen = null, Expression<Func<int>> bodycolorcolorBlue = null, Expression<Func<int>> bodycolorTemperature = null)
        {
            var __workflow_bodydeviceMACAddress = WorkflowExpression.Compile(bodydeviceMACAddress, nameof(bodydeviceMACAddress), required: true);
            var __workflow_bodydeviceModel = WorkflowExpression.Compile(bodydeviceModel, nameof(bodydeviceModel), required: true);
            var __workflow_bodycmdcommandName = WorkflowExpression.Compile(bodycmdcommandName, nameof(bodycmdcommandName), required: false);
            var __workflow_bodyturn = WorkflowExpression.Compile(bodyturn, nameof(bodyturn), required: false);
            var __workflow_bodybrightness = WorkflowExpression.Compile(bodybrightness, nameof(bodybrightness), required: false);
            var __workflow_bodycolorcolorRed = WorkflowExpression.Compile(bodycolorcolorRed, nameof(bodycolorcolorRed), required: false);
            var __workflow_bodycolorcolorGreen = WorkflowExpression.Compile(bodycolorcolorGreen, nameof(bodycolorcolorGreen), required: false);
            var __workflow_bodycolorcolorBlue = WorkflowExpression.Compile(bodycolorcolorBlue, nameof(bodycolorcolorBlue), required: false);
            var __workflow_bodycolorTemperature = WorkflowExpression.Compile(bodycolorTemperature, nameof(bodycolorTemperature), required: false);
            return new DeferredBodyAction<RunCommandOnDeviceResponse>(() =>
            {
                var apiCallPath = "/devices/control";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["device"] = ExpressionConverter.ConvertO(__workflow_bodydeviceMACAddress);
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodydeviceModel);
                var cmdObject = new JObject();
                var cmdObjectpropCount = 0;
                if (__workflow_bodycmdcommandName != null)
                {
                    cmdObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycmdcommandName);
                    cmdObjectpropCount++;
                }

                if (cmdObjectpropCount > 0)
                {
                    body["cmd"] = cmdObject;
                    bodypropCount++;
                }

                if (__workflow_bodyturn != null)
                {
                    body["turn"] = ExpressionConverter.ConvertO(__workflow_bodyturn);
                    bodypropCount++;
                }

                if (__workflow_bodybrightness != null)
                {
                    body["brightness"] = ExpressionConverter.ConvertO(__workflow_bodybrightness);
                    bodypropCount++;
                }

                var colorObject = new JObject();
                var colorObjectpropCount = 0;
                if (__workflow_bodycolorcolorRed != null)
                {
                    colorObject["r"] = ExpressionConverter.ConvertO(__workflow_bodycolorcolorRed);
                    colorObjectpropCount++;
                }

                if (__workflow_bodycolorcolorGreen != null)
                {
                    colorObject["g"] = ExpressionConverter.ConvertO(__workflow_bodycolorcolorGreen);
                    colorObjectpropCount++;
                }

                if (__workflow_bodycolorcolorBlue != null)
                {
                    colorObject["b"] = ExpressionConverter.ConvertO(__workflow_bodycolorcolorBlue);
                    colorObjectpropCount++;
                }

                if (colorObjectpropCount > 0)
                {
                    body["color"] = colorObject;
                    bodypropCount++;
                }

                if (__workflow_bodycolorTemperature != null)
                {
                    body["colorTem"] = ExpressionConverter.ConvertO(__workflow_bodycolorTemperature);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RunCommandOnDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<GetDeviceInformationResponse> GetDeviceInformation(Expression<Func<string>> device = null, Expression<Func<string>> model = null)
        {
            var __workflow_device = WorkflowExpression.Compile(device, nameof(device), required: false);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: false);
            return new DeferredBodyAction<GetDeviceInformationResponse>(() =>
            {
                var apiCallPath = "/devices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_device != null)
                    callPayload.Queries["device"] = ExpressionConverter.Convert(__workflow_device);
                if (__workflow_model != null)
                    callPayload.Queries["model"] = ExpressionConverter.Convert(__workflow_model);
                return new ApiConnectionAction<GetDeviceInformationResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
