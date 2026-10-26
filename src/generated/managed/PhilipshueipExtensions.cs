//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Philipshueip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PhilipshueipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetLightsResponse, ApiConnectionActionConfiguration> GetLights()
        {
            return new DeferredBodyAction<GetLightsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clip/v2/resource/light";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLightsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetLightResponse, ApiConnectionActionConfiguration> GetLight(Expression<Func<string>> deviceId)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            return new DeferredBodyAction<GetLightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clip/v2/resource/light/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<ExecuteLightResponse, ApiConnectionActionConfiguration> ExecuteLight(Expression<Func<string>> deviceId, Expression<Func<ExecuteLightInput>> body = null)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExecuteLightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clip/v2/resource/light/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExecuteLightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetDevicesResponse, ApiConnectionActionConfiguration> GetDevices()
        {
            return new DeferredBodyAction<GetDevicesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clip/v2/resource/device";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDevicesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetDeviceResponse, ApiConnectionActionConfiguration> GetDevice(Expression<Func<string>> deviceId)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            return new DeferredBodyAction<GetDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clip/v2/resource/device/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<ExecuteDeviceResponse, ApiConnectionActionConfiguration> ExecuteDevice(Expression<Func<string>> deviceId, Expression<Func<ExecuteDeviceInput>> body = null)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExecuteDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clip/v2/resource/device/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExecuteDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetRoomsResponse, ApiConnectionActionConfiguration> GetRooms()
        {
            return new DeferredBodyAction<GetRoomsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clip/v2/resource/room";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetScenesResponse, ApiConnectionActionConfiguration> GetScenes()
        {
            return new DeferredBodyAction<GetScenesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/clip/v2/resource/scene";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetScenesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<GetSceneResponse, ApiConnectionActionConfiguration> GetScene(Expression<Func<string>> sceneId)
        {
            var __workflow_sceneId = WorkflowExpression.Compile(sceneId, nameof(sceneId), required: true);
            return new DeferredBodyAction<GetSceneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clip/v2/resource/scene/{0}", __workflow_sceneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSceneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "philipshueip")]
        public IBodyWorkflowAction<DeleteSceneResponse, ApiConnectionActionConfiguration> DeleteScene(Expression<Func<string>> sceneId)
        {
            var __workflow_sceneId = WorkflowExpression.Compile(sceneId, nameof(sceneId), required: true);
            return new DeferredBodyAction<DeleteSceneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/clip/v2/resource/scene/{0}", __workflow_sceneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteSceneResponse>(callPayload);
            });
        }
    }

    public class PhilipshueipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLightsResponse
    {
        [JsonProperty("errors")]
        public GetLightsResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetLightsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetLightsResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetLightsResponseDataTypeItem
    {
        [JsonProperty("alert")]
        public GetLightsResponseDataTypeItemAlertType Alert { get; set; }

        [JsonProperty("color")]
        public GetLightsResponseDataTypeItemColorType Color { get; set; }

        [JsonProperty("color_temperature")]
        public GetLightsResponseDataTypeItemColorTemperatureType ColorTemperature { get; set; }

        [JsonProperty("dimming")]
        public GetLightsResponseDataTypeItemDimmingType Dimming { get; set; }

        [JsonProperty("dynamics")]
        public GetLightsResponseDataTypeItemDynamicsType Dynamics { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetLightsResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("on")]
        public GetLightsResponseDataTypeItemOnType On { get; set; }

        [JsonProperty("owner")]
        public GetLightsResponseDataTypeItemOwnerType Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLightsResponseDataTypeItemAlertType
    {
        [JsonProperty("action_values")]
        public string[] ActionValues { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorType
    {
        [JsonProperty("gamut")]
        public GetLightsResponseDataTypeItemColorTypeGamutType Gamut { get; set; }

        [JsonProperty("gamut_type")]
        public string GamutType { get; set; }

        [JsonProperty("xy")]
        public GetLightsResponseDataTypeItemColorTypeXyType Xy { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTypeGamutType
    {
        [JsonProperty("blue")]
        public GetLightsResponseDataTypeItemColorTypeGamutTypeBlueType Blue { get; set; }

        [JsonProperty("green")]
        public GetLightsResponseDataTypeItemColorTypeGamutTypeGreenType Green { get; set; }

        [JsonProperty("red")]
        public GetLightsResponseDataTypeItemColorTypeGamutTypeRedType Red { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTypeGamutTypeBlueType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTypeGamutTypeGreenType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTypeGamutTypeRedType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTypeXyType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int Mirek { get; set; }

        [JsonProperty("mirek_schema")]
        public GetLightsResponseDataTypeItemColorTemperatureTypeMirekSchemaType MirekSchema { get; set; }

        [JsonProperty("mirek_valid")]
        public bool MirekValid { get; set; }
    }

    public class GetLightsResponseDataTypeItemColorTemperatureTypeMirekSchemaType
    {
        [JsonProperty("mirek_maximum")]
        public int MirekMaximum { get; set; }

        [JsonProperty("mirek_minimum")]
        public int MirekMinimum { get; set; }
    }

    public class GetLightsResponseDataTypeItemDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("min_dim_level")]
        public double MinDimLevel { get; set; }
    }

    public class GetLightsResponseDataTypeItemDynamicsType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("speed_valid")]
        public bool SpeedValid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_values")]
        public string[] StatusValues { get; set; }
    }

    public class GetLightsResponseDataTypeItemMetadataType
    {
        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetLightsResponseDataTypeItemOnType
    {
        [JsonProperty("on")]
        public bool On { get; set; }
    }

    public class GetLightsResponseDataTypeItemOwnerType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetLightResponse
    {
        [JsonProperty("errors")]
        public GetLightResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetLightResponseDataTypeItem[] Data { get; set; }
    }

    public class GetLightResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetLightResponseDataTypeItem
    {
        [JsonProperty("alert")]
        public GetLightResponseDataTypeItemAlertType Alert { get; set; }

        [JsonProperty("color")]
        public GetLightResponseDataTypeItemColorType Color { get; set; }

        [JsonProperty("color_temperature")]
        public GetLightResponseDataTypeItemColorTemperatureType ColorTemperature { get; set; }

        [JsonProperty("dimming")]
        public GetLightResponseDataTypeItemDimmingType Dimming { get; set; }

        [JsonProperty("dynamics")]
        public GetLightResponseDataTypeItemDynamicsType Dynamics { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetLightResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("on")]
        public GetLightResponseDataTypeItemOnType On { get; set; }

        [JsonProperty("owner")]
        public GetLightResponseDataTypeItemOwnerType Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLightResponseDataTypeItemAlertType
    {
        [JsonProperty("action_values")]
        public string[] ActionValues { get; set; }
    }

    public class GetLightResponseDataTypeItemColorType
    {
        [JsonProperty("gamut")]
        public GetLightResponseDataTypeItemColorTypeGamutType Gamut { get; set; }

        [JsonProperty("gamut_type")]
        public string GamutType { get; set; }

        [JsonProperty("xy")]
        public GetLightResponseDataTypeItemColorTypeXyType Xy { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTypeGamutType
    {
        [JsonProperty("blue")]
        public GetLightResponseDataTypeItemColorTypeGamutTypeBlueType Blue { get; set; }

        [JsonProperty("green")]
        public GetLightResponseDataTypeItemColorTypeGamutTypeGreenType Green { get; set; }

        [JsonProperty("red")]
        public GetLightResponseDataTypeItemColorTypeGamutTypeRedType Red { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTypeGamutTypeBlueType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTypeGamutTypeGreenType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTypeGamutTypeRedType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTypeXyType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int Mirek { get; set; }

        [JsonProperty("mirek_schema")]
        public GetLightResponseDataTypeItemColorTemperatureTypeMirekSchemaType MirekSchema { get; set; }

        [JsonProperty("mirek_valid")]
        public bool MirekValid { get; set; }
    }

    public class GetLightResponseDataTypeItemColorTemperatureTypeMirekSchemaType
    {
        [JsonProperty("mirek_maximum")]
        public int MirekMaximum { get; set; }

        [JsonProperty("mirek_minimum")]
        public int MirekMinimum { get; set; }
    }

    public class GetLightResponseDataTypeItemDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("min_dim_level")]
        public double MinDimLevel { get; set; }
    }

    public class GetLightResponseDataTypeItemDynamicsType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("speed_valid")]
        public bool SpeedValid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_values")]
        public string[] StatusValues { get; set; }
    }

    public class GetLightResponseDataTypeItemMetadataType
    {
        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetLightResponseDataTypeItemOnType
    {
        [JsonProperty("on")]
        public bool On { get; set; }
    }

    public class GetLightResponseDataTypeItemOwnerType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class ExecuteLightResponse
    {
        [JsonProperty("data")]
        public ExecuteLightResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("errors")]
        public ExecuteLightResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class ExecuteLightResponseDataTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class ExecuteLightResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ExecuteLightInput
    {
        [JsonProperty("metadata")]
        public ExecuteLightInputMetadataType Metadata { get; set; }

        [JsonProperty("on")]
        public ExecuteLightInputOnType On { get; set; }

        [JsonProperty("dimming")]
        public ExecuteLightInputDimmingType Dimming { get; set; }

        [JsonProperty("color_temperature")]
        public ExecuteLightInputColorTemperatureType ColorTemperature { get; set; }

        [JsonProperty("color")]
        public ExecuteLightInputColorType Color { get; set; }

        [JsonProperty("dynamics")]
        public ExecuteLightInputDynamicsType Dynamics { get; set; }

        [JsonProperty("alert")]
        public ExecuteLightInputAlertType Alert { get; set; }

        [JsonProperty("gradient")]
        public ExecuteLightInputGradientType Gradient { get; set; }
    }

    public class ExecuteLightInputMetadataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ExecuteLightInputOnType
    {
        [JsonProperty("on")]
        public bool? On { get; set; }
    }

    public class ExecuteLightInputDimmingType
    {
        [JsonProperty("brightness")]
        public double? Brightness { get; set; }
    }

    public class ExecuteLightInputColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int? Mirek { get; set; }
    }

    public class ExecuteLightInputColorType
    {
        [JsonProperty("xy")]
        public ExecuteLightInputColorTypeXyType Xy { get; set; }
    }

    public class ExecuteLightInputColorTypeXyType
    {
        [JsonProperty("x")]
        public double? X { get; set; }

        [JsonProperty("y")]
        public double? Y { get; set; }
    }

    public class ExecuteLightInputDynamicsType
    {
        [JsonProperty("speed")]
        public double? Speed { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }
    }

    public class ExecuteLightInputAlertType
    {
        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Action { get; set; } = "breathe";
    }

    public class ExecuteLightInputGradientType
    {
        [JsonProperty("points")]
        public ExecuteLightInputGradientTypePointsTypeItem[] Points { get; set; }
    }

    public class ExecuteLightInputGradientTypePointsTypeItem
    {
        [JsonProperty("color")]
        public ExecuteLightInputGradientTypePointsTypeItemColorType Color { get; set; }
    }

    public class ExecuteLightInputGradientTypePointsTypeItemColorType
    {
        [JsonProperty("xy")]
        public ExecuteLightInputGradientTypePointsTypeItemColorTypeXyType Xy { get; set; }
    }

    public class ExecuteLightInputGradientTypePointsTypeItemColorTypeXyType
    {
        [JsonProperty("x")]
        public double? X { get; set; }

        [JsonProperty("y")]
        public double? Y { get; set; }
    }

    public class GetDevicesResponse
    {
        [JsonProperty("errors")]
        public GetDevicesResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetDevicesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetDevicesResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetDevicesResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetDevicesResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("product_data")]
        public GetDevicesResponseDataTypeItemProductDataType ProductData { get; set; }

        [JsonProperty("services")]
        public GetDevicesResponseDataTypeItemServicesTypeItem[] Services { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDevicesResponseDataTypeItemMetadataType
    {
        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetDevicesResponseDataTypeItemProductDataType
    {
        [JsonProperty("certified")]
        public bool Certified { get; set; }

        [JsonProperty("manufacturer_name")]
        public string ManufacturerName { get; set; }

        [JsonProperty("model_id")]
        public string ModelId { get; set; }

        [JsonProperty("product_archetype")]
        public string ProductArchetype { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("software_version")]
        public string SoftwareVersion { get; set; }
    }

    public class GetDevicesResponseDataTypeItemServicesTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetDeviceResponse
    {
        [JsonProperty("errors")]
        public GetDeviceResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetDeviceResponseDataTypeItem[] Data { get; set; }
    }

    public class GetDeviceResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetDeviceResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetDeviceResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("product_data")]
        public GetDeviceResponseDataTypeItemProductDataType ProductData { get; set; }

        [JsonProperty("services")]
        public GetDeviceResponseDataTypeItemServicesTypeItem[] Services { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDeviceResponseDataTypeItemMetadataType
    {
        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetDeviceResponseDataTypeItemProductDataType
    {
        [JsonProperty("certified")]
        public bool Certified { get; set; }

        [JsonProperty("manufacturer_name")]
        public string ManufacturerName { get; set; }

        [JsonProperty("model_id")]
        public string ModelId { get; set; }

        [JsonProperty("product_archetype")]
        public string ProductArchetype { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("software_version")]
        public string SoftwareVersion { get; set; }
    }

    public class GetDeviceResponseDataTypeItemServicesTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class ExecuteDeviceResponse
    {
        [JsonProperty("data")]
        public ExecuteDeviceResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("errors")]
        public ExecuteDeviceResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class ExecuteDeviceResponseDataTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class ExecuteDeviceResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ExecuteDeviceInput
    {
        [JsonProperty("metadata")]
        public ExecuteDeviceInputMetadataType Metadata { get; set; }

        [JsonProperty("identify")]
        public ExecuteDeviceInputIdentifyType Identify { get; set; }
    }

    public class ExecuteDeviceInputMetadataType
    {
        [JsonProperty("archetype")]
        public ExecuteDeviceInputMetadataTypeArchetypeType? Archetype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExecuteDeviceInputMetadataTypeArchetypeType
    {
        [EnumMember(Value = "bridge_v2")]
        BridgeV2,
        [EnumMember(Value = "unknown_archetype")]
        UnknownArchetype,
        [EnumMember(Value = "classic_bulb")]
        ClassicBulb,
        [EnumMember(Value = "sultan_bulb")]
        SultanBulb,
        [EnumMember(Value = "flood_bulb")]
        FloodBulb,
        [EnumMember(Value = "spot_bulb")]
        SpotBulb,
        [EnumMember(Value = "candle_bulb")]
        CandleBulb,
        [EnumMember(Value = "luster_bulb")]
        LusterBulb,
        [EnumMember(Value = "pendant_round")]
        PendantRound,
        [EnumMember(Value = "pendant_long")]
        PendantLong,
        [EnumMember(Value = "ceiling_round")]
        CeilingRound,
        [EnumMember(Value = "ceiling_square")]
        CeilingSquare,
        [EnumMember(Value = "floor_shade")]
        FloorShade,
        [EnumMember(Value = "floor_lantern")]
        FloorLantern,
        [EnumMember(Value = "table_shade")]
        TableShade,
        [EnumMember(Value = "recessed_ceiling")]
        RecessedCeiling,
        [EnumMember(Value = "recessed_floor")]
        RecessedFloor,
        [EnumMember(Value = "single_spot")]
        SingleSpot,
        [EnumMember(Value = "double_spot")]
        DoubleSpot,
        [EnumMember(Value = "table_wash")]
        TableWash,
        [EnumMember(Value = "wall_lantern")]
        WallLantern,
        [EnumMember(Value = "wall_shade")]
        WallShade,
        [EnumMember(Value = "flexible_lamp")]
        FlexibleLamp,
        [EnumMember(Value = "ground_spot")]
        GroundSpot,
        [EnumMember(Value = "wall_spot")]
        WallSpot,
        [EnumMember(Value = "plug")]
        Plug,
        [EnumMember(Value = "hue_go")]
        HueGo,
        [EnumMember(Value = "hue_lightstrip")]
        HueLightstrip,
        [EnumMember(Value = "hue_iris")]
        HueIris,
        [EnumMember(Value = "hue_bloom")]
        HueBloom,
        [EnumMember(Value = "bollard")]
        Bollard,
        [EnumMember(Value = "wall_washer")]
        WallWasher,
        [EnumMember(Value = "hue_play")]
        HuePlay,
        [EnumMember(Value = "vintage_bulb")]
        VintageBulb,
        [EnumMember(Value = "christmas_tree")]
        ChristmasTree,
        [EnumMember(Value = "hue_centris")]
        HueCentris,
        [EnumMember(Value = "hue_lightstrip_tv")]
        HueLightstripTv,
        [EnumMember(Value = "hue_tube")]
        HueTube,
        [EnumMember(Value = "hue_signe")]
        HueSigne
    }

    public class ExecuteDeviceInputIdentifyType
    {
        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Action { get; set; } = "identify";
    }

    public class GetRoomsResponse
    {
        [JsonProperty("errors")]
        public GetRoomsResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetRoomsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetRoomsResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetRoomsResponseDataTypeItem
    {
        [JsonProperty("children")]
        public GetRoomsResponseDataTypeItemChildrenTypeItem[] Children { get; set; }

        [JsonProperty("grouped_services")]
        public GetRoomsResponseDataTypeItemGroupedServicesTypeItem[] GroupedServices { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetRoomsResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("services")]
        public GetRoomsResponseDataTypeItemServicesTypeItem[] Services { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetRoomsResponseDataTypeItemChildrenTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetRoomsResponseDataTypeItemGroupedServicesTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetRoomsResponseDataTypeItemMetadataType
    {
        [JsonProperty("archetype")]
        public string Archetype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetRoomsResponseDataTypeItemServicesTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetScenesResponse
    {
        [JsonProperty("errors")]
        public GetScenesResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetScenesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetScenesResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetScenesResponseDataTypeItem
    {
        [JsonProperty("actions")]
        public GetScenesResponseDataTypeItemActionsTypeItem[] Actions { get; set; }

        [JsonProperty("group")]
        public GetScenesResponseDataTypeItemGroupType Group { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetScenesResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("palette")]
        public GetScenesResponseDataTypeItemPaletteType Palette { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItem
    {
        [JsonProperty("action")]
        public GetScenesResponseDataTypeItemActionsTypeItemActionType Action { get; set; }

        [JsonProperty("target")]
        public GetScenesResponseDataTypeItemActionsTypeItemTargetType Target { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemActionType
    {
        [JsonProperty("color")]
        public GetScenesResponseDataTypeItemActionsTypeItemActionTypeColorType Color { get; set; }

        [JsonProperty("dimming")]
        public GetScenesResponseDataTypeItemActionsTypeItemActionTypeDimmingType Dimming { get; set; }

        [JsonProperty("on")]
        public GetScenesResponseDataTypeItemActionsTypeItemActionTypeOnType On { get; set; }

        [JsonProperty("color_temperature")]
        public GetScenesResponseDataTypeItemActionsTypeItemActionTypeColorTemperatureType ColorTemperature { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemActionTypeColorType
    {
        [JsonProperty("xy")]
        public GetScenesResponseDataTypeItemActionsTypeItemActionTypeColorTypeXyType Xy { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemActionTypeColorTypeXyType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemActionTypeDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemActionTypeOnType
    {
        [JsonProperty("on")]
        public bool On { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemActionTypeColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int Mirek { get; set; }
    }

    public class GetScenesResponseDataTypeItemActionsTypeItemTargetType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetScenesResponseDataTypeItemGroupType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetScenesResponseDataTypeItemMetadataType
    {
        [JsonProperty("image")]
        public GetScenesResponseDataTypeItemMetadataTypeImageType Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetScenesResponseDataTypeItemMetadataTypeImageType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteType
    {
        [JsonProperty("color")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTypeItem[] Color { get; set; }

        [JsonProperty("color_temperature")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTemperatureTypeItem[] ColorTemperature { get; set; }

        [JsonProperty("dimming")]
        public GetScenesResponseDataTypeItemPaletteTypeDimmingTypeItem[] Dimming { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTypeItem
    {
        [JsonProperty("color")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTypeItemColorType Color { get; set; }

        [JsonProperty("dimming")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTypeItemDimmingType Dimming { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTypeItemColorType
    {
        [JsonProperty("xy")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTypeItemColorTypeXyType Xy { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTypeItemColorTypeXyType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTypeItemDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTemperatureTypeItem
    {
        [JsonProperty("color_temperature")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTemperatureTypeItemColorTemperatureType ColorTemperature { get; set; }

        [JsonProperty("dimming")]
        public GetScenesResponseDataTypeItemPaletteTypeColorTemperatureTypeItemDimmingType Dimming { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTemperatureTypeItemColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int Mirek { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeColorTemperatureTypeItemDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetScenesResponseDataTypeItemPaletteTypeDimmingTypeItem
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetSceneResponse
    {
        [JsonProperty("errors")]
        public GetSceneResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("data")]
        public GetSceneResponseDataTypeItem[] Data { get; set; }
    }

    public class GetSceneResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetSceneResponseDataTypeItem
    {
        [JsonProperty("actions")]
        public GetSceneResponseDataTypeItemActionsTypeItem[] Actions { get; set; }

        [JsonProperty("group")]
        public GetSceneResponseDataTypeItemGroupType Group { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("id_v1")]
        public string IdV1 { get; set; }

        [JsonProperty("metadata")]
        public GetSceneResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("palette")]
        public GetSceneResponseDataTypeItemPaletteType Palette { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItem
    {
        [JsonProperty("action")]
        public GetSceneResponseDataTypeItemActionsTypeItemActionType Action { get; set; }

        [JsonProperty("target")]
        public GetSceneResponseDataTypeItemActionsTypeItemTargetType Target { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemActionType
    {
        [JsonProperty("color")]
        public GetSceneResponseDataTypeItemActionsTypeItemActionTypeColorType Color { get; set; }

        [JsonProperty("dimming")]
        public GetSceneResponseDataTypeItemActionsTypeItemActionTypeDimmingType Dimming { get; set; }

        [JsonProperty("on")]
        public GetSceneResponseDataTypeItemActionsTypeItemActionTypeOnType On { get; set; }

        [JsonProperty("color_temperature")]
        public GetSceneResponseDataTypeItemActionsTypeItemActionTypeColorTemperatureType ColorTemperature { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemActionTypeColorType
    {
        [JsonProperty("xy")]
        public GetSceneResponseDataTypeItemActionsTypeItemActionTypeColorTypeXyType Xy { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemActionTypeColorTypeXyType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemActionTypeDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemActionTypeOnType
    {
        [JsonProperty("on")]
        public bool On { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemActionTypeColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int Mirek { get; set; }
    }

    public class GetSceneResponseDataTypeItemActionsTypeItemTargetType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetSceneResponseDataTypeItemGroupType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetSceneResponseDataTypeItemMetadataType
    {
        [JsonProperty("image")]
        public GetSceneResponseDataTypeItemMetadataTypeImageType Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetSceneResponseDataTypeItemMetadataTypeImageType
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteType
    {
        [JsonProperty("color")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTypeItem[] Color { get; set; }

        [JsonProperty("color_temperature")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTemperatureTypeItem[] ColorTemperature { get; set; }

        [JsonProperty("dimming")]
        public GetSceneResponseDataTypeItemPaletteTypeDimmingTypeItem[] Dimming { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTypeItem
    {
        [JsonProperty("color")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTypeItemColorType Color { get; set; }

        [JsonProperty("dimming")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTypeItemDimmingType Dimming { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTypeItemColorType
    {
        [JsonProperty("xy")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTypeItemColorTypeXyType Xy { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTypeItemColorTypeXyType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTypeItemDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTemperatureTypeItem
    {
        [JsonProperty("color_temperature")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTemperatureTypeItemColorTemperatureType ColorTemperature { get; set; }

        [JsonProperty("dimming")]
        public GetSceneResponseDataTypeItemPaletteTypeColorTemperatureTypeItemDimmingType Dimming { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTemperatureTypeItemColorTemperatureType
    {
        [JsonProperty("mirek")]
        public int Mirek { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeColorTemperatureTypeItemDimmingType
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class GetSceneResponseDataTypeItemPaletteTypeDimmingTypeItem
    {
        [JsonProperty("brightness")]
        public double Brightness { get; set; }
    }

    public class DeleteSceneResponse
    {
        [JsonProperty("data")]
        public DeleteSceneResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("errors")]
        public DeleteSceneResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class DeleteSceneResponseDataTypeItem
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("rtype")]
        public string Rtype { get; set; }
    }

    public class DeleteSceneResponseErrorsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Philipshueip;

    public partial class WorkflowManagedActions
    {
        public PhilipshueipActions Philipshueip(string connectionId) => new PhilipshueipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PhilipshueipTriggers Philipshueip(string connectionId) => new PhilipshueipTriggers(connectionId);
    }
}