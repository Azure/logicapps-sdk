//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lifx
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LifxActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [WorkflowExpressionFactory(nameof(__BuildMoveEffect))]
        public IWorkflowAction MoveEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<double> bodyperiod = null, [WorkflowExpression] Func<double> bodycycles = null, [WorkflowExpression] Func<bool> bodypowerOn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveEffect(WorkflowExpression<string> lights, WorkflowExpression<bodydirectionInput> bodydirection = null, WorkflowExpression<double> bodyperiod = null, WorkflowExpression<double> bodycycles = null, WorkflowExpression<bool> bodypowerOn = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodydirection, nameof(bodydirection), required: false);
            WorkflowExpression.Validate(bodyperiod, nameof(bodyperiod), required: false);
            WorkflowExpression.Validate(bodycycles, nameof(bodycycles), required: false);
            WorkflowExpression.Validate(bodypowerOn, nameof(bodypowerOn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/move", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydirection != null)
                {
                    if (bodydirection != null)
                    {
                        body["direction"] = ExpressionConverter.ConvertO(bodydirection);
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
                        body["period"] = ExpressionConverter.ConvertO(bodyperiod);
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
                    body["cycles"] = ExpressionConverter.ConvertO(bodycycles);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    body["power_on"] = ExpressionConverter.ConvertO(bodypowerOn);
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
        [WorkflowExpressionFactory(nameof(__BuildPulseEffect))]
        public IWorkflowAction PulseEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodycolorInput> bodycolor, [WorkflowExpression] Func<bodyfromColorInput> bodyfromColor = null, [WorkflowExpression] Func<double> bodyperiod = null, [WorkflowExpression] Func<double> bodycycles = null, [WorkflowExpression] Func<bool> bodypersist = null, [WorkflowExpression] Func<bool> bodypowerOn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPulseEffect(WorkflowExpression<string> lights, WorkflowExpression<bodycolorInput> bodycolor, WorkflowExpression<bodyfromColorInput> bodyfromColor = null, WorkflowExpression<double> bodyperiod = null, WorkflowExpression<double> bodycycles = null, WorkflowExpression<bool> bodypersist = null, WorkflowExpression<bool> bodypowerOn = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodycolor, nameof(bodycolor), required: true);
            WorkflowExpression.Validate(bodyfromColor, nameof(bodyfromColor), required: false);
            WorkflowExpression.Validate(bodyperiod, nameof(bodyperiod), required: false);
            WorkflowExpression.Validate(bodycycles, nameof(bodycycles), required: false);
            WorkflowExpression.Validate(bodypersist, nameof(bodypersist), required: false);
            WorkflowExpression.Validate(bodypowerOn, nameof(bodypowerOn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/pulse", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                if (bodyfromColor != null)
                {
                    body["from_color"] = ExpressionConverter.ConvertO(bodyfromColor);
                    bodypropCount++;
                }

                if (bodyperiod != null)
                {
                    if (bodyperiod != null)
                    {
                        body["period"] = ExpressionConverter.ConvertO(bodyperiod);
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
                        body["cycles"] = ExpressionConverter.ConvertO(bodycycles);
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
                    body["persist"] = ExpressionConverter.ConvertO(bodypersist);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    if (bodypowerOn != null)
                    {
                        body["power_on"] = ExpressionConverter.ConvertO(bodypowerOn);
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
        [WorkflowExpressionFactory(nameof(__BuildActivateScene))]
        public IWorkflowAction ActivateScene([WorkflowExpression] Func<string> scene, [WorkflowExpression] Func<int> bodyduration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildActivateScene(WorkflowExpression<string> scene, WorkflowExpression<int> bodyduration = null)
        {
            WorkflowExpression.Validate(scene, nameof(scene), required: true);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/scenes/{0}/activate", ExpressionConverter.ConvertWithUrlEncoding(scene, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyduration != null)
                {
                    if (bodyduration != null)
                    {
                        body["duration"] = ExpressionConverter.ConvertO(bodyduration);
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
        [WorkflowExpressionFactory(nameof(__BuildSetState))]
        public IBodyWorkflowAction<SetStateResponse> SetState([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodypowerInput> bodypower = null, [WorkflowExpression] Func<bodycolorInput> bodycolor = null, [WorkflowExpression] Func<double> bodybrightness = null, [WorkflowExpression] Func<double> bodyduration = null, [WorkflowExpression] Func<double> bodyinfrared = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetStateResponse> __BuildSetState(WorkflowExpression<string> lights, WorkflowExpression<bodypowerInput> bodypower = null, WorkflowExpression<bodycolorInput> bodycolor = null, WorkflowExpression<double> bodybrightness = null, WorkflowExpression<double> bodyduration = null, WorkflowExpression<double> bodyinfrared = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodypower, nameof(bodypower), required: false);
            WorkflowExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            WorkflowExpression.Validate(bodybrightness, nameof(bodybrightness), required: false);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            WorkflowExpression.Validate(bodyinfrared, nameof(bodyinfrared), required: false);
            return new DeferredBodyAction<SetStateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/state", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypower != null)
                {
                    body["power"] = ExpressionConverter.ConvertO(bodypower);
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    body["color"] = ExpressionConverter.ConvertO(bodycolor);
                    bodypropCount++;
                }

                if (bodybrightness != null)
                {
                    if (bodybrightness != null)
                    {
                        body["brightness"] = ExpressionConverter.ConvertO(bodybrightness);
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
                        body["duration"] = ExpressionConverter.ConvertO(bodyduration);
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
                    body["infrared"] = ExpressionConverter.ConvertO(bodyinfrared);
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
        [WorkflowExpressionFactory(nameof(__BuildEffectsOff))]
        public IWorkflowAction EffectsOff([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bool> bodypowerOff = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEffectsOff(WorkflowExpression<string> lights, WorkflowExpression<bool> bodypowerOff = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodypowerOff, nameof(bodypowerOff), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/off", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypowerOff != null)
                {
                    body["power_off"] = ExpressionConverter.ConvertO(bodypowerOff);
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
        [WorkflowExpressionFactory(nameof(__BuildSetStates))]
        public IWorkflowAction SetStates([WorkflowExpression] Func<bodystatesInputItem[]> bodystates, [WorkflowExpression] Func<bodydefaultspowerInput> bodydefaultspower = null, [WorkflowExpression] Func<bodydefaultscolorInput> bodydefaultscolor = null, [WorkflowExpression] Func<double> bodydefaultsbrightness = null, [WorkflowExpression] Func<double> bodydefaultsduration = null, [WorkflowExpression] Func<double> bodydefaultsinfrared = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetStates(WorkflowExpression<bodystatesInputItem[]> bodystates, WorkflowExpression<bodydefaultspowerInput> bodydefaultspower = null, WorkflowExpression<bodydefaultscolorInput> bodydefaultscolor = null, WorkflowExpression<double> bodydefaultsbrightness = null, WorkflowExpression<double> bodydefaultsduration = null, WorkflowExpression<double> bodydefaultsinfrared = null)
        {
            WorkflowExpression.Validate(bodystates, nameof(bodystates), required: true);
            WorkflowExpression.Validate(bodydefaultspower, nameof(bodydefaultspower), required: false);
            WorkflowExpression.Validate(bodydefaultscolor, nameof(bodydefaultscolor), required: false);
            WorkflowExpression.Validate(bodydefaultsbrightness, nameof(bodydefaultsbrightness), required: false);
            WorkflowExpression.Validate(bodydefaultsduration, nameof(bodydefaultsduration), required: false);
            WorkflowExpression.Validate(bodydefaultsinfrared, nameof(bodydefaultsinfrared), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/lights/states";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["states"] = ExpressionConverter.ConvertO(bodystates);
                var defaultsObject = new JObject();
                var defaultsObjectpropCount = 0;
                if (bodydefaultspower != null)
                {
                    defaultsObject["power"] = ExpressionConverter.ConvertO(bodydefaultspower);
                    defaultsObjectpropCount++;
                }

                if (bodydefaultscolor != null)
                {
                    defaultsObject["color"] = ExpressionConverter.ConvertO(bodydefaultscolor);
                    defaultsObjectpropCount++;
                }

                if (bodydefaultsbrightness != null)
                {
                    if (bodydefaultsbrightness != null)
                    {
                        defaultsObject["brightness"] = ExpressionConverter.ConvertO(bodydefaultsbrightness);
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
                        defaultsObject["duration"] = ExpressionConverter.ConvertO(bodydefaultsduration);
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
                    defaultsObject["infrared"] = ExpressionConverter.ConvertO(bodydefaultsinfrared);
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
        [WorkflowExpressionFactory(nameof(__BuildTogglePower))]
        public IWorkflowAction TogglePower([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<double> bodyduration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTogglePower(WorkflowExpression<string> lights, WorkflowExpression<double> bodyduration = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/toggle", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyduration != null)
                {
                    if (bodyduration != null)
                    {
                        body["duration"] = ExpressionConverter.ConvertO(bodyduration);
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
        [WorkflowExpressionFactory(nameof(__BuildBreatheEffect))]
        public IWorkflowAction BreatheEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<bodycolorInput> bodycolor, [WorkflowExpression] Func<bodyfromColorInput> bodyfromColor = null, [WorkflowExpression] Func<double> bodyperiod = null, [WorkflowExpression] Func<double> bodycycles = null, [WorkflowExpression] Func<bool> bodypersist = null, [WorkflowExpression] Func<bool> bodypowerOn = null, [WorkflowExpression] Func<double> bodypeak = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBreatheEffect(WorkflowExpression<string> lights, WorkflowExpression<bodycolorInput> bodycolor, WorkflowExpression<bodyfromColorInput> bodyfromColor = null, WorkflowExpression<double> bodyperiod = null, WorkflowExpression<double> bodycycles = null, WorkflowExpression<bool> bodypersist = null, WorkflowExpression<bool> bodypowerOn = null, WorkflowExpression<double> bodypeak = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodycolor, nameof(bodycolor), required: true);
            WorkflowExpression.Validate(bodyfromColor, nameof(bodyfromColor), required: false);
            WorkflowExpression.Validate(bodyperiod, nameof(bodyperiod), required: false);
            WorkflowExpression.Validate(bodycycles, nameof(bodycycles), required: false);
            WorkflowExpression.Validate(bodypersist, nameof(bodypersist), required: false);
            WorkflowExpression.Validate(bodypowerOn, nameof(bodypowerOn), required: false);
            WorkflowExpression.Validate(bodypeak, nameof(bodypeak), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/breathe", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                if (bodyfromColor != null)
                {
                    body["from_color"] = ExpressionConverter.ConvertO(bodyfromColor);
                    bodypropCount++;
                }

                if (bodyperiod != null)
                {
                    if (bodyperiod != null)
                    {
                        body["period"] = ExpressionConverter.ConvertO(bodyperiod);
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
                        body["cycles"] = ExpressionConverter.ConvertO(bodycycles);
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
                    body["persist"] = ExpressionConverter.ConvertO(bodypersist);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    if (bodypowerOn != null)
                    {
                        body["power_on"] = ExpressionConverter.ConvertO(bodypowerOn);
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
                        body["peak"] = ExpressionConverter.ConvertO(bodypeak);
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
        [WorkflowExpressionFactory(nameof(__BuildMorphEffect))]
        public IWorkflowAction MorphEffect([WorkflowExpression] Func<string> lights, [WorkflowExpression] Func<int> bodyperiod = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<string[]> bodypalette = null, [WorkflowExpression] Func<bool> bodypowerOn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lifx")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMorphEffect(WorkflowExpression<string> lights, WorkflowExpression<int> bodyperiod = null, WorkflowExpression<int> bodyduration = null, WorkflowExpression<string[]> bodypalette = null, WorkflowExpression<bool> bodypowerOn = null)
        {
            WorkflowExpression.Validate(lights, nameof(lights), required: true);
            WorkflowExpression.Validate(bodyperiod, nameof(bodyperiod), required: false);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            WorkflowExpression.Validate(bodypalette, nameof(bodypalette), required: false);
            WorkflowExpression.Validate(bodypowerOn, nameof(bodypowerOn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/lights/{0}/effects/morph", ExpressionConverter.ConvertWithUrlEncoding(lights, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyperiod != null)
                {
                    body["period"] = ExpressionConverter.ConvertO(bodyperiod);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                    bodypropCount++;
                }

                if (bodypalette != null)
                {
                    body["palette"] = ExpressionConverter.ConvertO(bodypalette);
                    bodypropCount++;
                }

                if (bodypowerOn != null)
                {
                    body["power_on"] = ExpressionConverter.ConvertO(bodypowerOn);
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