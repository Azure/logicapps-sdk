//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Govee
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoveeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        [WorkflowExpressionFactory(nameof(__BuildRunCommandOnDevice))]
        public IBodyWorkflowAction<RunCommandOnDeviceResponse> RunCommandOnDevice([WorkflowExpression] Func<string> bodydeviceMACAddress, [WorkflowExpression] Func<string> bodydeviceModel, [WorkflowExpression] Func<bodycmdcommandNameInput> bodycmdcommandName = null, [WorkflowExpression] Func<bodyturnInput> bodyturn = null, [WorkflowExpression] Func<int> bodybrightness = null, [WorkflowExpression] Func<int> bodycolorcolorRed = null, [WorkflowExpression] Func<int> bodycolorcolorGreen = null, [WorkflowExpression] Func<int> bodycolorcolorBlue = null, [WorkflowExpression] Func<int> bodycolorTemperature = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunCommandOnDeviceResponse> __BuildRunCommandOnDevice(WorkflowExpression<string> bodydeviceMACAddress, WorkflowExpression<string> bodydeviceModel, WorkflowExpression<bodycmdcommandNameInput> bodycmdcommandName = null, WorkflowExpression<bodyturnInput> bodyturn = null, WorkflowExpression<int> bodybrightness = null, WorkflowExpression<int> bodycolorcolorRed = null, WorkflowExpression<int> bodycolorcolorGreen = null, WorkflowExpression<int> bodycolorcolorBlue = null, WorkflowExpression<int> bodycolorTemperature = null)
        {
            WorkflowExpression.Validate(bodydeviceMACAddress, nameof(bodydeviceMACAddress), required: true);
            WorkflowExpression.Validate(bodydeviceModel, nameof(bodydeviceModel), required: true);
            WorkflowExpression.Validate(bodycmdcommandName, nameof(bodycmdcommandName), required: false);
            WorkflowExpression.Validate(bodyturn, nameof(bodyturn), required: false);
            WorkflowExpression.Validate(bodybrightness, nameof(bodybrightness), required: false);
            WorkflowExpression.Validate(bodycolorcolorRed, nameof(bodycolorcolorRed), required: false);
            WorkflowExpression.Validate(bodycolorcolorGreen, nameof(bodycolorcolorGreen), required: false);
            WorkflowExpression.Validate(bodycolorcolorBlue, nameof(bodycolorcolorBlue), required: false);
            WorkflowExpression.Validate(bodycolorTemperature, nameof(bodycolorTemperature), required: false);
            return new DeferredBodyAction<RunCommandOnDeviceResponse>(() =>
            {
                var apiCallPath = "/devices/control";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["device"] = ExpressionConverter.ConvertO(bodydeviceMACAddress);
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodydeviceModel);
                var cmdObject = new JObject();
                var cmdObjectpropCount = 0;
                if (bodycmdcommandName != null)
                {
                    cmdObject["name"] = ExpressionConverter.ConvertO(bodycmdcommandName);
                    cmdObjectpropCount++;
                }

                if (cmdObjectpropCount > 0)
                {
                    body["cmd"] = cmdObject;
                    bodypropCount++;
                }

                if (bodyturn != null)
                {
                    body["turn"] = ExpressionConverter.ConvertO(bodyturn);
                    bodypropCount++;
                }

                if (bodybrightness != null)
                {
                    body["brightness"] = ExpressionConverter.ConvertO(bodybrightness);
                    bodypropCount++;
                }

                var colorObject = new JObject();
                var colorObjectpropCount = 0;
                if (bodycolorcolorRed != null)
                {
                    colorObject["r"] = ExpressionConverter.ConvertO(bodycolorcolorRed);
                    colorObjectpropCount++;
                }

                if (bodycolorcolorGreen != null)
                {
                    colorObject["g"] = ExpressionConverter.ConvertO(bodycolorcolorGreen);
                    colorObjectpropCount++;
                }

                if (bodycolorcolorBlue != null)
                {
                    colorObject["b"] = ExpressionConverter.ConvertO(bodycolorcolorBlue);
                    colorObjectpropCount++;
                }

                if (colorObjectpropCount > 0)
                {
                    body["color"] = colorObject;
                    bodypropCount++;
                }

                if (bodycolorTemperature != null)
                {
                    body["colorTem"] = ExpressionConverter.ConvertO(bodycolorTemperature);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDeviceInformation))]
        public IBodyWorkflowAction<GetDeviceInformationResponse> GetDeviceInformation([WorkflowExpression] Func<string> device = null, [WorkflowExpression] Func<string> model = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDeviceInformationResponse> __BuildGetDeviceInformation(WorkflowExpression<string> device = null, WorkflowExpression<string> model = null)
        {
            WorkflowExpression.Validate(device, nameof(device), required: false);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            return new DeferredBodyAction<GetDeviceInformationResponse>(() =>
            {
                var apiCallPath = "/devices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (device != null)
                    callPayload.Queries["device"] = ExpressionConverter.Convert(device);
                if (model != null)
                    callPayload.Queries["model"] = ExpressionConverter.Convert(model);
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