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
        public IWorkflowAction MoveEffect(Expression<Func<string>> lights, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<double>> bodyperiod = null, Expression<Func<double>> bodycycles = null, Expression<Func<bool>> bodypowerOn = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/move", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydirection != null)
            {
                if (bodydirection != null)
                {
                    body["direction"] = CSharpExpressionConverter.Convert(bodydirection);
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
                    body["period"] = CSharpExpressionConverter.ConvertToken(bodyperiod);
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
                body["cycles"] = CSharpExpressionConverter.ConvertToken(bodycycles);
                bodypropCount++;
            }

            if (bodypowerOn != null)
            {
                body["power_on"] = CSharpExpressionConverter.ConvertToken(bodypowerOn);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction PulseEffect(Expression<Func<string>> lights, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<bodyfromColorInput>> bodyfromColor = null, Expression<Func<double>> bodyperiod = null, Expression<Func<double>> bodycycles = null, Expression<Func<bool>> bodypersist = null, Expression<Func<bool>> bodypowerOn = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/pulse", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["color"] = CSharpExpressionConverter.Convert(bodycolor);
            if (bodyfromColor != null)
            {
                body["from_color"] = CSharpExpressionConverter.Convert(bodyfromColor);
                bodypropCount++;
            }

            if (bodyperiod != null)
            {
                if (bodyperiod != null)
                {
                    body["period"] = CSharpExpressionConverter.ConvertToken(bodyperiod);
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
                    body["cycles"] = CSharpExpressionConverter.ConvertToken(bodycycles);
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
                body["persist"] = CSharpExpressionConverter.ConvertToken(bodypersist);
                bodypropCount++;
            }

            if (bodypowerOn != null)
            {
                if (bodypowerOn != null)
                {
                    body["power_on"] = CSharpExpressionConverter.ConvertToken(bodypowerOn);
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

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction ActivateScene(Expression<Func<string>> scene, Expression<Func<int>> bodyduration = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/scenes/{0}/activate", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(scene, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyduration != null)
            {
                if (bodyduration != null)
                {
                    body["duration"] = CSharpExpressionConverter.ConvertToken(bodyduration);
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

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IBodyWorkflowAction<SetStateResponse> SetState(Expression<Func<string>> lights, Expression<Func<bodypowerInput>> bodypower = null, Expression<Func<bodycolorInput>> bodycolor = null, Expression<Func<double>> bodybrightness = null, Expression<Func<double>> bodyduration = null, Expression<Func<double>> bodyinfrared = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/state", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypower != null)
            {
                body["power"] = CSharpExpressionConverter.Convert(bodypower);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = CSharpExpressionConverter.Convert(bodycolor);
                bodypropCount++;
            }

            if (bodybrightness != null)
            {
                if (bodybrightness != null)
                {
                    body["brightness"] = CSharpExpressionConverter.ConvertToken(bodybrightness);
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
                    body["duration"] = CSharpExpressionConverter.ConvertToken(bodyduration);
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
                body["infrared"] = CSharpExpressionConverter.ConvertToken(bodyinfrared);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetStateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction EffectsOff(Expression<Func<string>> lights, Expression<Func<bool>> bodypowerOff = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/off", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypowerOff != null)
            {
                body["power_off"] = CSharpExpressionConverter.ConvertToken(bodypowerOff);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction SetStates(Expression<Func<bodystatesInputItem[]>> bodystates, Expression<Func<bodydefaultspowerInput>> bodydefaultspower = null, Expression<Func<bodydefaultscolorInput>> bodydefaultscolor = null, Expression<Func<double>> bodydefaultsbrightness = null, Expression<Func<double>> bodydefaultsduration = null, Expression<Func<double>> bodydefaultsinfrared = null)
        {
            var apiCallPath = "/v1/lights/states";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["states"] = CSharpExpressionConverter.ConvertToken(bodystates);
            var defaultsObject = new JObject();
            var defaultsObjectpropCount = 0;
            if (bodydefaultspower != null)
            {
                defaultsObject["power"] = CSharpExpressionConverter.Convert(bodydefaultspower);
                defaultsObjectpropCount++;
            }

            if (bodydefaultscolor != null)
            {
                defaultsObject["color"] = CSharpExpressionConverter.Convert(bodydefaultscolor);
                defaultsObjectpropCount++;
            }

            if (bodydefaultsbrightness != null)
            {
                if (bodydefaultsbrightness != null)
                {
                    defaultsObject["brightness"] = CSharpExpressionConverter.ConvertToken(bodydefaultsbrightness);
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
                    defaultsObject["duration"] = CSharpExpressionConverter.ConvertToken(bodydefaultsduration);
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
                defaultsObject["infrared"] = CSharpExpressionConverter.ConvertToken(bodydefaultsinfrared);
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

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction TogglePower(Expression<Func<string>> lights, Expression<Func<double>> bodyduration = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/toggle", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyduration != null)
            {
                if (bodyduration != null)
                {
                    body["duration"] = CSharpExpressionConverter.ConvertToken(bodyduration);
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

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction BreatheEffect(Expression<Func<string>> lights, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<bodyfromColorInput>> bodyfromColor = null, Expression<Func<double>> bodyperiod = null, Expression<Func<double>> bodycycles = null, Expression<Func<bool>> bodypersist = null, Expression<Func<bool>> bodypowerOn = null, Expression<Func<double>> bodypeak = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/breathe", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["color"] = CSharpExpressionConverter.Convert(bodycolor);
            if (bodyfromColor != null)
            {
                body["from_color"] = CSharpExpressionConverter.Convert(bodyfromColor);
                bodypropCount++;
            }

            if (bodyperiod != null)
            {
                if (bodyperiod != null)
                {
                    body["period"] = CSharpExpressionConverter.ConvertToken(bodyperiod);
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
                    body["cycles"] = CSharpExpressionConverter.ConvertToken(bodycycles);
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
                body["persist"] = CSharpExpressionConverter.ConvertToken(bodypersist);
                bodypropCount++;
            }

            if (bodypowerOn != null)
            {
                if (bodypowerOn != null)
                {
                    body["power_on"] = CSharpExpressionConverter.ConvertToken(bodypowerOn);
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
                    body["peak"] = CSharpExpressionConverter.ConvertToken(bodypeak);
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

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction MorphEffect(Expression<Func<string>> lights, Expression<Func<int>> bodyperiod = null, Expression<Func<int>> bodyduration = null, Expression<Func<string[]>> bodypalette = null, Expression<Func<bool>> bodypowerOn = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/morph", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lights, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyperiod != null)
            {
                body["period"] = CSharpExpressionConverter.ConvertToken(bodyperiod);
                bodypropCount++;
            }

            if (bodyduration != null)
            {
                body["duration"] = CSharpExpressionConverter.ConvertToken(bodyduration);
                bodypropCount++;
            }

            if (bodypalette != null)
            {
                body["palette"] = CSharpExpressionConverter.ConvertToken(bodypalette);
                bodypropCount++;
            }

            if (bodypowerOn != null)
            {
                body["power_on"] = CSharpExpressionConverter.ConvertToken(bodypowerOn);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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