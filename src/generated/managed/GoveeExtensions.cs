//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Govee
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoveeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<RunCommandOnDeviceResponse, ApiConnectionActionConfiguration> RunCommandOnDevice(Expression<Func<RunCommandOnDeviceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RunCommandOnDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/devices/control";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunCommandOnDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "govee")]
        public IBodyWorkflowAction<GetDeviceInformationResponse, ApiConnectionActionConfiguration> GetDeviceInformation(Expression<Func<string>> device = null, Expression<Func<string>> model = null)
        {
            var __workflow_device = WorkflowExpression.Compile(device, nameof(device), required: false);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: false);
            return new DeferredBodyAction<GetDeviceInformationResponse, ApiConnectionActionConfiguration>(() =>
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

    public class RunCommandOnDeviceInput
    {
        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceMACAddress { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceModel { get; set; }

        [JsonProperty("cmd", DefaultValueHandling = DefaultValueHandling.Include)]
        public RunCommandOnDeviceInputCmdType Cmd { get; set; }

        [JsonProperty("turn")]
        public RunCommandOnDeviceInputTurnType? Turn { get; set; }

        [JsonProperty("brightness")]
        public int? Brightness { get; set; }

        [JsonProperty("color")]
        public RunCommandOnDeviceInputColorType Color { get; set; }

        [JsonProperty("colorTem")]
        public int? ColorTemperature { get; set; }
    }

    public class RunCommandOnDeviceInputCmdType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public RunCommandOnDeviceInputCmdTypeCommandNameType CommandName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunCommandOnDeviceInputCmdTypeCommandNameType
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
    public enum RunCommandOnDeviceInputTurnType
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    public class RunCommandOnDeviceInputColorType
    {
        [JsonProperty("r")]
        public int? ColorRed { get; set; }

        [JsonProperty("g")]
        public int? ColorGreen { get; set; }

        [JsonProperty("b")]
        public int? ColorBlue { get; set; }
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