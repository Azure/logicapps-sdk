//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yeelight
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YeelightActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<DiscoverResponseItem[], ApiConnectionActionConfiguration> Discover()
        {
            return new DeferredBodyAction<DiscoverResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ms-flow/discover";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DiscoverResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<SwitchResponseItem[], ApiConnectionActionConfiguration> Switch(Expression<Func<SwitchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SwitchResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ms-flow/switch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SwitchResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<ColorResponseItem[], ApiConnectionActionConfiguration> Color(Expression<Func<ColorInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ColorResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ms-flow/color";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ColorResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<BrightnessResponseItem[], ApiConnectionActionConfiguration> Brightness(Expression<Func<BrightnessInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BrightnessResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ms-flow/brightness";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BrightnessResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<TemperatureResponseItem[], ApiConnectionActionConfiguration> Temperature(Expression<Func<TemperatureInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TemperatureResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ms-flow/temperature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TemperatureResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<QueryResponse, ApiConnectionActionConfiguration> Query(Expression<Func<QueryInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ms-flow/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QueryResponse>(callPayload);
            });
        }
    }

    public class YeelightTriggers([ConnectionName] string connectionId)
    {
    }

    public class DiscoverResponseItem
    {
        [JsonProperty("did")]
        public string Did { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }
    }

    public class SwitchResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SwitchInput
    {
        [JsonProperty("did")]
        public string Did { get; set; }

        [JsonProperty("on")]
        public bool? On { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ColorResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ColorInput
    {
        [JsonProperty("did")]
        public string Did { get; set; }

        [JsonProperty("spectrumRGB")]
        public int? SpectrumRGB { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class BrightnessResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class BrightnessInput
    {
        [JsonProperty("did")]
        public string Did { get; set; }

        [JsonProperty("brightness")]
        public int? Brightness { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TemperatureResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class TemperatureInput
    {
        [JsonProperty("did")]
        public string Did { get; set; }

        [JsonProperty("temperature")]
        public int? Temperature { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class QueryResponse
    {
        public QueryResponseM1GAxtaW9A0LXNwZWMtdjIVgoAFGA55ZWVsaWdodC1sYW1wMRUUGAg0NTAxOTQ4MhWsAgAType M1GAxtaW9A0LXNwZWMtdjIVgoAFGA55ZWVsaWdodC1sYW1wMRUUGAg0NTAxOTQ4MhWsAgA { get; set; }
    }

    public class QueryResponseM1GAxtaW9A0LXNwZWMtdjIVgoAFGA55ZWVsaWdodC1sYW1wMRUUGAg0NTAxOTQ4MhWsAgAType
    {
        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("on")]
        public bool On { get; set; }

        [JsonProperty("brightness")]
        public int Brightness { get; set; }

        [JsonProperty("color-temperature")]
        public int ColorTemperature { get; set; }
    }

    public class QueryInput
    {
        [JsonProperty("did")]
        public string Did { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yeelight;

    public partial class WorkflowManagedActions
    {
        public YeelightActions Yeelight(string connectionId) => new YeelightActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YeelightTriggers Yeelight(string connectionId) => new YeelightTriggers(connectionId);
    }
}