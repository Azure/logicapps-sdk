//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yeelight
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YeelightActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<DiscoverResponseItem[]> Discover()
        {
            var apiCallPath = "/api/ms-flow/discover";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DiscoverResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<SwitchResponseItem[]> Switch(Expression<Func<string>> bodydid = null, Expression<Func<bool>> bodyon = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/api/ms-flow/switch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydid != null)
            {
                body["did"] = CSharpExpressionConverter.ConvertToken(bodydid);
                bodypropCount++;
            }

            if (bodyon != null)
            {
                body["on"] = CSharpExpressionConverter.ConvertToken(bodyon);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SwitchResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<ColorResponseItem[]> Color(Expression<Func<string>> bodydid = null, Expression<Func<int>> bodyspectrumRGB = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/api/ms-flow/color";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydid != null)
            {
                body["did"] = CSharpExpressionConverter.ConvertToken(bodydid);
                bodypropCount++;
            }

            if (bodyspectrumRGB != null)
            {
                body["spectrumRGB"] = CSharpExpressionConverter.ConvertToken(bodyspectrumRGB);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ColorResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<BrightnessResponseItem[]> Brightness(Expression<Func<string>> bodydid = null, Expression<Func<int>> bodybrightness = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/api/ms-flow/brightness";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydid != null)
            {
                body["did"] = CSharpExpressionConverter.ConvertToken(bodydid);
                bodypropCount++;
            }

            if (bodybrightness != null)
            {
                body["brightness"] = CSharpExpressionConverter.ConvertToken(bodybrightness);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BrightnessResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<TemperatureResponseItem[]> Temperature(Expression<Func<string>> bodydid = null, Expression<Func<int>> bodytemperature = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/api/ms-flow/temperature";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydid != null)
            {
                body["did"] = CSharpExpressionConverter.ConvertToken(bodydid);
                bodypropCount++;
            }

            if (bodytemperature != null)
            {
                body["temperature"] = CSharpExpressionConverter.ConvertToken(bodytemperature);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TemperatureResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<QueryResponse> Query(Expression<Func<string>> bodydid = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/api/ms-flow/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydid != null)
            {
                body["did"] = CSharpExpressionConverter.ConvertToken(bodydid);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryResponse>(callPayload);
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

    public class ColorResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class BrightnessResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class TemperatureResponseItem
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
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