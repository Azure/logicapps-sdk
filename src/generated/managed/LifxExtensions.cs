//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lifx
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LifxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveEffect(Expression<Func<string>> lights, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<double>> bodyperiod = null, Expression<Func<double>> bodycycles = null, Expression<Func<bool>> bodypowerOn = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodydirection = WorkflowExpression.Compile(bodydirection, nameof(bodydirection), required: false);
            var __workflow_bodyperiod = WorkflowExpression.Compile(bodyperiod, nameof(bodyperiod), required: false);
            var __workflow_bodycycles = WorkflowExpression.Compile(bodycycles, nameof(bodycycles), required: false);
            var __workflow_bodypowerOn = WorkflowExpression.Compile(bodypowerOn, nameof(bodypowerOn), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/effects/move", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydirection != null)
                {
                    if (__workflow_bodydirection != null)
                    {
                        body["direction"] = ExpressionConverter.ConvertO(__workflow_bodydirection);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["direction"] = "forward";
                    bodypropCount++;
                }

                if (__workflow_bodyperiod != null)
                {
                    if (__workflow_bodyperiod != null)
                    {
                        body["period"] = ExpressionConverter.ConvertO(__workflow_bodyperiod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["period"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodycycles != null)
                {
                    body["cycles"] = ExpressionConverter.ConvertO(__workflow_bodycycles);
                    bodypropCount++;
                }

                if (__workflow_bodypowerOn != null)
                {
                    body["power_on"] = ExpressionConverter.ConvertO(__workflow_bodypowerOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PulseEffect(Expression<Func<string>> lights, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<bodyfromColorInput>> bodyfromColor = null, Expression<Func<double>> bodyperiod = null, Expression<Func<double>> bodycycles = null, Expression<Func<bool>> bodypersist = null, Expression<Func<bool>> bodypowerOn = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodycolor = WorkflowExpression.Compile(bodycolor, nameof(bodycolor), required: true);
            var __workflow_bodyfromColor = WorkflowExpression.Compile(bodyfromColor, nameof(bodyfromColor), required: false);
            var __workflow_bodyperiod = WorkflowExpression.Compile(bodyperiod, nameof(bodyperiod), required: false);
            var __workflow_bodycycles = WorkflowExpression.Compile(bodycycles, nameof(bodycycles), required: false);
            var __workflow_bodypersist = WorkflowExpression.Compile(bodypersist, nameof(bodypersist), required: false);
            var __workflow_bodypowerOn = WorkflowExpression.Compile(bodypowerOn, nameof(bodypowerOn), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/effects/pulse", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                if (__workflow_bodyfromColor != null)
                {
                    body["from_color"] = ExpressionConverter.ConvertO(__workflow_bodyfromColor);
                    bodypropCount++;
                }

                if (__workflow_bodyperiod != null)
                {
                    if (__workflow_bodyperiod != null)
                    {
                        body["period"] = ExpressionConverter.ConvertO(__workflow_bodyperiod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["period"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodycycles != null)
                {
                    if (__workflow_bodycycles != null)
                    {
                        body["cycles"] = ExpressionConverter.ConvertO(__workflow_bodycycles);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["cycles"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodypersist != null)
                {
                    body["persist"] = ExpressionConverter.ConvertO(__workflow_bodypersist);
                    bodypropCount++;
                }

                if (__workflow_bodypowerOn != null)
                {
                    if (__workflow_bodypowerOn != null)
                    {
                        body["power_on"] = ExpressionConverter.ConvertO(__workflow_bodypowerOn);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ActivateScene(Expression<Func<string>> scene, Expression<Func<int>> bodyduration = null)
        {
            var __workflow_scene = WorkflowExpression.Compile(scene, nameof(scene), required: true);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/scenes/{0}/activate", __workflow_scene.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyduration != null)
                {
                    if (__workflow_bodyduration != null)
                    {
                        body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IBodyWorkflowAction<SetStateResponse, ApiConnectionActionConfiguration> SetState(Expression<Func<string>> lights, Expression<Func<bodypowerInput>> bodypower = null, Expression<Func<bodycolorInput>> bodycolor = null, Expression<Func<double>> bodybrightness = null, Expression<Func<double>> bodyduration = null, Expression<Func<double>> bodyinfrared = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodypower = WorkflowExpression.Compile(bodypower, nameof(bodypower), required: false);
            var __workflow_bodycolor = WorkflowExpression.Compile(bodycolor, nameof(bodycolor), required: false);
            var __workflow_bodybrightness = WorkflowExpression.Compile(bodybrightness, nameof(bodybrightness), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodyinfrared = WorkflowExpression.Compile(bodyinfrared, nameof(bodyinfrared), required: false);
            return new DeferredBodyAction<SetStateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/state", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypower != null)
                {
                    body["power"] = ExpressionConverter.ConvertO(__workflow_bodypower);
                    bodypropCount++;
                }

                if (__workflow_bodycolor != null)
                {
                    body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                    bodypropCount++;
                }

                if (__workflow_bodybrightness != null)
                {
                    if (__workflow_bodybrightness != null)
                    {
                        body["brightness"] = ExpressionConverter.ConvertO(__workflow_bodybrightness);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["brightness"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    if (__workflow_bodyduration != null)
                    {
                        body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["duration"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodyinfrared != null)
                {
                    body["infrared"] = ExpressionConverter.ConvertO(__workflow_bodyinfrared);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EffectsOff(Expression<Func<string>> lights, Expression<Func<bool>> bodypowerOff = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodypowerOff = WorkflowExpression.Compile(bodypowerOff, nameof(bodypowerOff), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/effects/off", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypowerOff != null)
                {
                    body["power_off"] = ExpressionConverter.ConvertO(__workflow_bodypowerOff);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetStates(Expression<Func<bodystatesInputItem[]>> bodystates, Expression<Func<bodydefaultspowerInput>> bodydefaultspower = null, Expression<Func<bodydefaultscolorInput>> bodydefaultscolor = null, Expression<Func<double>> bodydefaultsbrightness = null, Expression<Func<double>> bodydefaultsduration = null, Expression<Func<double>> bodydefaultsinfrared = null)
        {
            var __workflow_bodystates = WorkflowExpression.Compile(bodystates, nameof(bodystates), required: true);
            var __workflow_bodydefaultspower = WorkflowExpression.Compile(bodydefaultspower, nameof(bodydefaultspower), required: false);
            var __workflow_bodydefaultscolor = WorkflowExpression.Compile(bodydefaultscolor, nameof(bodydefaultscolor), required: false);
            var __workflow_bodydefaultsbrightness = WorkflowExpression.Compile(bodydefaultsbrightness, nameof(bodydefaultsbrightness), required: false);
            var __workflow_bodydefaultsduration = WorkflowExpression.Compile(bodydefaultsduration, nameof(bodydefaultsduration), required: false);
            var __workflow_bodydefaultsinfrared = WorkflowExpression.Compile(bodydefaultsinfrared, nameof(bodydefaultsinfrared), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/lights/states";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["states"] = ExpressionConverter.ConvertO(__workflow_bodystates);
                var defaultsObject = new JObject();
                var defaultsObjectpropCount = 0;
                if (__workflow_bodydefaultspower != null)
                {
                    defaultsObject["power"] = ExpressionConverter.ConvertO(__workflow_bodydefaultspower);
                    defaultsObjectpropCount++;
                }

                if (__workflow_bodydefaultscolor != null)
                {
                    defaultsObject["color"] = ExpressionConverter.ConvertO(__workflow_bodydefaultscolor);
                    defaultsObjectpropCount++;
                }

                if (__workflow_bodydefaultsbrightness != null)
                {
                    if (__workflow_bodydefaultsbrightness != null)
                    {
                        defaultsObject["brightness"] = ExpressionConverter.ConvertO(__workflow_bodydefaultsbrightness);
                        defaultsObjectpropCount++;
                    }

                    defaultsObjectpropCount++;
                }
                else
                {
                    defaultsObject["brightness"] = 1;
                    defaultsObjectpropCount++;
                }

                if (__workflow_bodydefaultsduration != null)
                {
                    if (__workflow_bodydefaultsduration != null)
                    {
                        defaultsObject["duration"] = ExpressionConverter.ConvertO(__workflow_bodydefaultsduration);
                        defaultsObjectpropCount++;
                    }

                    defaultsObjectpropCount++;
                }
                else
                {
                    defaultsObject["duration"] = 0;
                    defaultsObjectpropCount++;
                }

                if (__workflow_bodydefaultsinfrared != null)
                {
                    defaultsObject["infrared"] = ExpressionConverter.ConvertO(__workflow_bodydefaultsinfrared);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TogglePower(Expression<Func<string>> lights, Expression<Func<double>> bodyduration = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/toggle", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyduration != null)
                {
                    if (__workflow_bodyduration != null)
                    {
                        body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BreatheEffect(Expression<Func<string>> lights, Expression<Func<bodycolorInput>> bodycolor, Expression<Func<bodyfromColorInput>> bodyfromColor = null, Expression<Func<double>> bodyperiod = null, Expression<Func<double>> bodycycles = null, Expression<Func<bool>> bodypersist = null, Expression<Func<bool>> bodypowerOn = null, Expression<Func<double>> bodypeak = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodycolor = WorkflowExpression.Compile(bodycolor, nameof(bodycolor), required: true);
            var __workflow_bodyfromColor = WorkflowExpression.Compile(bodyfromColor, nameof(bodyfromColor), required: false);
            var __workflow_bodyperiod = WorkflowExpression.Compile(bodyperiod, nameof(bodyperiod), required: false);
            var __workflow_bodycycles = WorkflowExpression.Compile(bodycycles, nameof(bodycycles), required: false);
            var __workflow_bodypersist = WorkflowExpression.Compile(bodypersist, nameof(bodypersist), required: false);
            var __workflow_bodypowerOn = WorkflowExpression.Compile(bodypowerOn, nameof(bodypowerOn), required: false);
            var __workflow_bodypeak = WorkflowExpression.Compile(bodypeak, nameof(bodypeak), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/effects/breathe", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                if (__workflow_bodyfromColor != null)
                {
                    body["from_color"] = ExpressionConverter.ConvertO(__workflow_bodyfromColor);
                    bodypropCount++;
                }

                if (__workflow_bodyperiod != null)
                {
                    if (__workflow_bodyperiod != null)
                    {
                        body["period"] = ExpressionConverter.ConvertO(__workflow_bodyperiod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["period"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodycycles != null)
                {
                    if (__workflow_bodycycles != null)
                    {
                        body["cycles"] = ExpressionConverter.ConvertO(__workflow_bodycycles);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["cycles"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodypersist != null)
                {
                    body["persist"] = ExpressionConverter.ConvertO(__workflow_bodypersist);
                    bodypropCount++;
                }

                if (__workflow_bodypowerOn != null)
                {
                    if (__workflow_bodypowerOn != null)
                    {
                        body["power_on"] = ExpressionConverter.ConvertO(__workflow_bodypowerOn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["power_on"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodypeak != null)
                {
                    if (__workflow_bodypeak != null)
                    {
                        body["peak"] = ExpressionConverter.ConvertO(__workflow_bodypeak);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MorphEffect(Expression<Func<string>> lights, Expression<Func<int>> bodyperiod = null, Expression<Func<int>> bodyduration = null, Expression<Func<string[]>> bodypalette = null, Expression<Func<bool>> bodypowerOn = null)
        {
            var __workflow_lights = WorkflowExpression.Compile(lights, nameof(lights), required: true);
            var __workflow_bodyperiod = WorkflowExpression.Compile(bodyperiod, nameof(bodyperiod), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodypalette = WorkflowExpression.Compile(bodypalette, nameof(bodypalette), required: false);
            var __workflow_bodypowerOn = WorkflowExpression.Compile(bodypowerOn, nameof(bodypowerOn), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/lights/{0}/effects/morph", __workflow_lights.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyperiod != null)
                {
                    body["period"] = ExpressionConverter.ConvertO(__workflow_bodyperiod);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodypalette != null)
                {
                    body["palette"] = ExpressionConverter.ConvertO(__workflow_bodypalette);
                    bodypropCount++;
                }

                if (__workflow_bodypowerOn != null)
                {
                    body["power_on"] = ExpressionConverter.ConvertO(__workflow_bodypowerOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LifxTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydirectionInput
    {
        [EnumMember(Value = "forward")]
        Forward,
        [EnumMember(Value = "backward")]
        Backward
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatesInputItemPowerType
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydefaultspowerInput
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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