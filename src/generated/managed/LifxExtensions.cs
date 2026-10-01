//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lifx
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LifxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction MoveEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<double> bodyperiod = null, [WorkflowExpression] Func<double> bodycycles = null, [WorkflowExpression] Func<bool> bodypowerOn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/move", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydirection != null)
                {
                    if (bodydirection != null)
                    {
                        body["direction"] = SourceExpressionConverter.Convert(bodydirection);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["direction"] = "forward";
                    bodypropCount++;
                }

                if (bodyperiod != null)
                {
                    if (bodyperiod != null)
                    {
                        body["period"] = SourceExpressionConverter.ConvertToken(bodyperiod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["period"] = 1;
                    bodypropCount++;
                }

                if (bodycycles != null)
                {
                    body["cycles"] = SourceExpressionConverter.ConvertToken(bodycycles);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    body["power_on"] = SourceExpressionConverter.ConvertToken(bodypowerOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction PulseEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodycolorInput> bodycolor, [WorkflowExpression] Func<bodyfromColorInput> bodyfromColor = null, [WorkflowExpression] Func<double> bodyperiod = null, [WorkflowExpression] Func<double> bodycycles = null, [WorkflowExpression] Func<bool> bodypersist = null, [WorkflowExpression] Func<bool> bodypowerOn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/pulse", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["color"] = SourceExpressionConverter.Convert(bodycolor);
                if (bodyfromColor != null)
                {
                    body["from_color"] = SourceExpressionConverter.Convert(bodyfromColor);
                    bodypropCount++;
                }

                if (bodyperiod != null)
                {
                    if (bodyperiod != null)
                    {
                        body["period"] = SourceExpressionConverter.ConvertToken(bodyperiod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["period"] = 1;
                    bodypropCount++;
                }

                if (bodycycles != null)
                {
                    if (bodycycles != null)
                    {
                        body["cycles"] = SourceExpressionConverter.ConvertToken(bodycycles);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["cycles"] = 1;
                    bodypropCount++;
                }

                if (bodypersist != null)
                {
                    body["persist"] = SourceExpressionConverter.ConvertToken(bodypersist);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    if (bodypowerOn != null)
                    {
                        body["power_on"] = SourceExpressionConverter.ConvertToken(bodypowerOn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["power_on"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction ActivateScene([WorkflowExpression] Func<string> scene, [WorkflowExpression] Func<int> bodyduration = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/scenes/{0}/activate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scene, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyduration != null)
                {
                    if (bodyduration != null)
                    {
                        body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["duration"] = 0;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IBodyWorkflowAction<SetStateResponse> SetState([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodypowerInput> bodypower = null, [WorkflowExpression] Func<bodycolorInput> bodycolor = null, [WorkflowExpression] Func<double> bodybrightness = null, [WorkflowExpression] Func<double> bodyduration = null, [WorkflowExpression] Func<double> bodyinfrared = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/state", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypower != null)
                {
                    body["power"] = SourceExpressionConverter.Convert(bodypower);
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    body["color"] = SourceExpressionConverter.Convert(bodycolor);
                    bodypropCount++;
                }

                if (bodybrightness != null)
                {
                    if (bodybrightness != null)
                    {
                        body["brightness"] = SourceExpressionConverter.ConvertToken(bodybrightness);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["brightness"] = 1;
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    if (bodyduration != null)
                    {
                        body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["duration"] = 0;
                    bodypropCount++;
                }

                if (bodyinfrared != null)
                {
                    body["infrared"] = SourceExpressionConverter.ConvertToken(bodyinfrared);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction EffectsOff([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bool> bodypowerOff = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/off", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypowerOff != null)
                {
                    body["power_off"] = SourceExpressionConverter.ConvertToken(bodypowerOff);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction SetStates([WorkflowExpression] Func<bodystatesInputItem[]> bodystates, [WorkflowExpression] Func<bodydefaultspowerInput> bodydefaultspower = null, [WorkflowExpression] Func<bodydefaultscolorInput> bodydefaultscolor = null, [WorkflowExpression] Func<double> bodydefaultsbrightness = null, [WorkflowExpression] Func<double> bodydefaultsduration = null, [WorkflowExpression] Func<double> bodydefaultsinfrared = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/lights/states";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["states"] = SourceExpressionConverter.ConvertToken(bodystates);
                var defaultsObject = new JObject();
                var defaultsObjectpropCount = 0;
                if (bodydefaultspower != null)
                {
                    defaultsObject["power"] = SourceExpressionConverter.Convert(bodydefaultspower);
                    defaultsObjectpropCount++;
                }

                if (bodydefaultscolor != null)
                {
                    defaultsObject["color"] = SourceExpressionConverter.Convert(bodydefaultscolor);
                    defaultsObjectpropCount++;
                }

                if (bodydefaultsbrightness != null)
                {
                    if (bodydefaultsbrightness != null)
                    {
                        defaultsObject["brightness"] = SourceExpressionConverter.ConvertToken(bodydefaultsbrightness);
                        defaultsObjectpropCount++;
                    }

                    defaultsObjectpropCount++;
                }
                else
                {
                    defaultsObject["brightness"] = 1;
                    defaultsObjectpropCount++;
                }

                if (bodydefaultsduration != null)
                {
                    if (bodydefaultsduration != null)
                    {
                        defaultsObject["duration"] = SourceExpressionConverter.ConvertToken(bodydefaultsduration);
                        defaultsObjectpropCount++;
                    }

                    defaultsObjectpropCount++;
                }
                else
                {
                    defaultsObject["duration"] = 0;
                    defaultsObjectpropCount++;
                }

                if (bodydefaultsinfrared != null)
                {
                    defaultsObject["infrared"] = SourceExpressionConverter.ConvertToken(bodydefaultsinfrared);
                    defaultsObjectpropCount++;
                }

                if (defaultsObjectpropCount > 0)
                {
                    body["defaults"] = defaultsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction TogglePower([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<double> bodyduration = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/toggle", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyduration != null)
                {
                    if (bodyduration != null)
                    {
                        body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["duration"] = 1;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction BreatheEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodycolorInput> bodycolor, [WorkflowExpression] Func<bodyfromColorInput> bodyfromColor = null, [WorkflowExpression] Func<double> bodyperiod = null, [WorkflowExpression] Func<double> bodycycles = null, [WorkflowExpression] Func<bool> bodypersist = null, [WorkflowExpression] Func<bool> bodypowerOn = null, [WorkflowExpression] Func<double> bodypeak = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/breathe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["color"] = SourceExpressionConverter.Convert(bodycolor);
                if (bodyfromColor != null)
                {
                    body["from_color"] = SourceExpressionConverter.Convert(bodyfromColor);
                    bodypropCount++;
                }

                if (bodyperiod != null)
                {
                    if (bodyperiod != null)
                    {
                        body["period"] = SourceExpressionConverter.ConvertToken(bodyperiod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["period"] = 1;
                    bodypropCount++;
                }

                if (bodycycles != null)
                {
                    if (bodycycles != null)
                    {
                        body["cycles"] = SourceExpressionConverter.ConvertToken(bodycycles);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["cycles"] = 1;
                    bodypropCount++;
                }

                if (bodypersist != null)
                {
                    body["persist"] = SourceExpressionConverter.ConvertToken(bodypersist);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    if (bodypowerOn != null)
                    {
                        body["power_on"] = SourceExpressionConverter.ConvertToken(bodypowerOn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["power_on"] = true;
                    bodypropCount++;
                }

                if (bodypeak != null)
                {
                    if (bodypeak != null)
                    {
                        body["peak"] = SourceExpressionConverter.ConvertToken(bodypeak);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["peak"] = 0.5;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction MorphEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<int> bodyperiod = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<string[]> bodypalette = null, [WorkflowExpression] Func<bool> bodypowerOn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/morph", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyperiod != null)
                {
                    body["period"] = SourceExpressionConverter.ConvertToken(bodyperiod);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodypalette != null)
                {
                    body["palette"] = SourceExpressionConverter.ConvertToken(bodypalette);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    body["power_on"] = SourceExpressionConverter.ConvertToken(bodypowerOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class LifxTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodydirectionInput
    {
        [EnumMember(Value = "forward")]
        Forward,
        [EnumMember(Value = "backward")]
        Backward
    }

    public enum bodycolorInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "kelvin:1500")]
        Candlelight,
        [EnumMember(Value = "kelvin:2000")]
        Sunset,
        [EnumMember(Value = "kelvin:2500")]
        UltraWarm,
        [EnumMember(Value = "kelvin:2750")]
        Incandescent,
        [EnumMember(Value = "kelvin:3000")]
        Warm,
        [EnumMember(Value = "kelvin:3200")]
        NeutralWarm,
        [EnumMember(Value = "kelvin:3500")]
        Neutral,
        [EnumMember(Value = "kelvin:4000")]
        Cool,
        [EnumMember(Value = "kelvin:4500")]
        CoolDaylight,
        [EnumMember(Value = "kelvin:5000")]
        SoftDaylight,
        [EnumMember(Value = "kelvin:5500")]
        Daylight,
        [EnumMember(Value = "kelvin:6000")]
        NoonDaylight,
        [EnumMember(Value = "kelvin:6500")]
        BrightDaylight,
        [EnumMember(Value = "kelvin:7000")]
        CloudyDaylight,
        [EnumMember(Value = "kelvin:7500")]
        BlueDaylight,
        [EnumMember(Value = "kelvin:8000")]
        BlueOvercast,
        [EnumMember(Value = "kelvin:8500")]
        BlueWater,
        [EnumMember(Value = "kelvin:9000")]
        BlueIce,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "orange")]
        Orange,
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "cyan")]
        Cyan,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "red saturation:0.5")]
        PastelRed,
        [EnumMember(Value = "orange saturation:0.5")]
        PastelOrange,
        [EnumMember(Value = "yellow saturation:0.5")]
        PastelYellow,
        [EnumMember(Value = "green saturation:0.5")]
        PastelGreen,
        [EnumMember(Value = "cyan saturation:0.5")]
        PastelCyan,
        [EnumMember(Value = "blue saturation:0.5")]
        PastelBlue,
        [EnumMember(Value = "purple saturation:0.5")]
        PastelPurple,
        [EnumMember(Value = "pink saturation:0.5")]
        PastelPink,
        [EnumMember(Value = "random")]
        Random
    }

    public enum bodyfromColorInput
    {
        [EnumMember(Value = "")]
        ExistingColor,
        [EnumMember(Value = "kelvin:1500")]
        Candlelight,
        [EnumMember(Value = "kelvin:2000")]
        Sunset,
        [EnumMember(Value = "kelvin:2500")]
        UltraWarm,
        [EnumMember(Value = "kelvin:2750")]
        Incandescent,
        [EnumMember(Value = "kelvin:3000")]
        Warm,
        [EnumMember(Value = "kelvin:3200")]
        NeutralWarm,
        [EnumMember(Value = "kelvin:3500")]
        Neutral,
        [EnumMember(Value = "kelvin:4000")]
        Cool,
        [EnumMember(Value = "kelvin:4500")]
        CoolDaylight,
        [EnumMember(Value = "kelvin:5000")]
        SoftDaylight,
        [EnumMember(Value = "kelvin:5500")]
        Daylight,
        [EnumMember(Value = "kelvin:6000")]
        NoonDaylight,
        [EnumMember(Value = "kelvin:6500")]
        BrightDaylight,
        [EnumMember(Value = "kelvin:7000")]
        CloudyDaylight,
        [EnumMember(Value = "kelvin:7500")]
        BlueDaylight,
        [EnumMember(Value = "kelvin:8000")]
        BlueOvercast,
        [EnumMember(Value = "kelvin:8500")]
        BlueWater,
        [EnumMember(Value = "kelvin:9000")]
        BlueIce,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "orange")]
        Orange,
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "cyan")]
        Cyan,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "red saturation:0.5")]
        PastelRed,
        [EnumMember(Value = "orange saturation:0.5")]
        PastelOrange,
        [EnumMember(Value = "yellow saturation:0.5")]
        PastelYellow,
        [EnumMember(Value = "green saturation:0.5")]
        PastelGreen,
        [EnumMember(Value = "cyan saturation:0.5")]
        PastelCyan,
        [EnumMember(Value = "blue saturation:0.5")]
        PastelBlue,
        [EnumMember(Value = "purple saturation:0.5")]
        PastelPurple,
        [EnumMember(Value = "pink saturation:0.5")]
        PastelPink,
        [EnumMember(Value = "random")]
        Random
    }

    public class SetStateResponse
    {
        [JsonProperty("results")]
        public SetStateResponseResultsTypeItem[] Results { get; set; }
    }

    public class SetStateResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public enum bodypowerInput
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    public class bodystatesInputItem
    {
        [JsonProperty("selector")]
        public string Selector { get; set; }

        [JsonProperty("power")]
        public bodystatesInputItemPowerType Power { get; set; }

        [JsonProperty("color")]
        public bodystatesInputItemColorType Color { get; set; }

        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("infrared")]
        public double Infrared { get; set; }
    }

    public enum bodystatesInputItemPowerType
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    public enum bodystatesInputItemColorType
    {
        [EnumMember(Value = "")]
        LeaveUnchanged,
        [EnumMember(Value = "kelvin:1500")]
        Candlelight,
        [EnumMember(Value = "kelvin:2000")]
        Sunset,
        [EnumMember(Value = "kelvin:2500")]
        UltraWarm,
        [EnumMember(Value = "kelvin:2750")]
        Incandescent,
        [EnumMember(Value = "kelvin:3000")]
        Warm,
        [EnumMember(Value = "kelvin:3200")]
        NeutralWarm,
        [EnumMember(Value = "kelvin:3500")]
        Neutral,
        [EnumMember(Value = "kelvin:4000")]
        Cool,
        [EnumMember(Value = "kelvin:4500")]
        CoolDaylight,
        [EnumMember(Value = "kelvin:5000")]
        SoftDaylight,
        [EnumMember(Value = "kelvin:5500")]
        Daylight,
        [EnumMember(Value = "kelvin:6000")]
        NoonDaylight,
        [EnumMember(Value = "kelvin:6500")]
        BrightDaylight,
        [EnumMember(Value = "kelvin:7000")]
        CloudyDaylight,
        [EnumMember(Value = "kelvin:7500")]
        BlueDaylight,
        [EnumMember(Value = "kelvin:8000")]
        BlueOvercast,
        [EnumMember(Value = "kelvin:8500")]
        BlueWater,
        [EnumMember(Value = "kelvin:9000")]
        BlueIce,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "orange")]
        Orange,
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "cyan")]
        Cyan,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "red saturation:0.5")]
        PastelRed,
        [EnumMember(Value = "orange saturation:0.5")]
        PastelOrange,
        [EnumMember(Value = "yellow saturation:0.5")]
        PastelYellow,
        [EnumMember(Value = "green saturation:0.5")]
        PastelGreen,
        [EnumMember(Value = "cyan saturation:0.5")]
        PastelCyan,
        [EnumMember(Value = "blue saturation:0.5")]
        PastelBlue,
        [EnumMember(Value = "purple saturation:0.5")]
        PastelPurple,
        [EnumMember(Value = "pink saturation:0.5")]
        PastelPink,
        [EnumMember(Value = "random")]
        Random
    }

    public enum bodydefaultspowerInput
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    public enum bodydefaultscolorInput
    {
        [EnumMember(Value = "")]
        LeaveUnchanged,
        [EnumMember(Value = "kelvin:1500")]
        Candlelight,
        [EnumMember(Value = "kelvin:2000")]
        Sunset,
        [EnumMember(Value = "kelvin:2500")]
        UltraWarm,
        [EnumMember(Value = "kelvin:2750")]
        Incandescent,
        [EnumMember(Value = "kelvin:3000")]
        Warm,
        [EnumMember(Value = "kelvin:3200")]
        NeutralWarm,
        [EnumMember(Value = "kelvin:3500")]
        Neutral,
        [EnumMember(Value = "kelvin:4000")]
        Cool,
        [EnumMember(Value = "kelvin:4500")]
        CoolDaylight,
        [EnumMember(Value = "kelvin:5000")]
        SoftDaylight,
        [EnumMember(Value = "kelvin:5500")]
        Daylight,
        [EnumMember(Value = "kelvin:6000")]
        NoonDaylight,
        [EnumMember(Value = "kelvin:6500")]
        BrightDaylight,
        [EnumMember(Value = "kelvin:7000")]
        CloudyDaylight,
        [EnumMember(Value = "kelvin:7500")]
        BlueDaylight,
        [EnumMember(Value = "kelvin:8000")]
        BlueOvercast,
        [EnumMember(Value = "kelvin:8500")]
        BlueWater,
        [EnumMember(Value = "kelvin:9000")]
        BlueIce,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "orange")]
        Orange,
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "cyan")]
        Cyan,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "red saturation:0.5")]
        PastelRed,
        [EnumMember(Value = "orange saturation:0.5")]
        PastelOrange,
        [EnumMember(Value = "yellow saturation:0.5")]
        PastelYellow,
        [EnumMember(Value = "green saturation:0.5")]
        PastelGreen,
        [EnumMember(Value = "cyan saturation:0.5")]
        PastelCyan,
        [EnumMember(Value = "blue saturation:0.5")]
        PastelBlue,
        [EnumMember(Value = "purple saturation:0.5")]
        PastelPurple,
        [EnumMember(Value = "pink saturation:0.5")]
        PastelPink,
        [EnumMember(Value = "random")]
        Random
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lifx;

    public partial class WorkflowManagedActions
    {
        public LifxActions Lifx(string connectionId) => new LifxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LifxTriggers Lifx(string connectionId) => new LifxTriggers(connectionId);
    }
}