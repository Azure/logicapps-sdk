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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ms-flow/discover";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DiscoverResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<SwitchResponseItem[]> Switch([WorkflowExpression] Func<string> bodydid = null, [WorkflowExpression] Func<bool> bodyon = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ms-flow/switch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydid != null)
                {
                    body["did"] = SourceExpressionConverter.ConvertToken(bodydid);
                    bodypropCount++;
                }

                if (bodyon != null)
                {
                    body["on"] = SourceExpressionConverter.ConvertToken(bodyon);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SwitchResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<ColorResponseItem[]> Color([WorkflowExpression] Func<string> bodydid = null, [WorkflowExpression] Func<int> bodyspectrumRGB = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ms-flow/color";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydid != null)
                {
                    body["did"] = SourceExpressionConverter.ConvertToken(bodydid);
                    bodypropCount++;
                }

                if (bodyspectrumRGB != null)
                {
                    body["spectrumRGB"] = SourceExpressionConverter.ConvertToken(bodyspectrumRGB);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ColorResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<BrightnessResponseItem[]> Brightness([WorkflowExpression] Func<string> bodydid = null, [WorkflowExpression] Func<int> bodybrightness = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ms-flow/brightness";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydid != null)
                {
                    body["did"] = SourceExpressionConverter.ConvertToken(bodydid);
                    bodypropCount++;
                }

                if (bodybrightness != null)
                {
                    body["brightness"] = SourceExpressionConverter.ConvertToken(bodybrightness);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BrightnessResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<TemperatureResponseItem[]> Temperature([WorkflowExpression] Func<string> bodydid = null, [WorkflowExpression] Func<int> bodytemperature = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ms-flow/temperature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydid != null)
                {
                    body["did"] = SourceExpressionConverter.ConvertToken(bodydid);
                    bodypropCount++;
                }

                if (bodytemperature != null)
                {
                    body["temperature"] = SourceExpressionConverter.ConvertToken(bodytemperature);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TemperatureResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeelight")]
        public IBodyWorkflowAction<QueryResponse> Query([WorkflowExpression] Func<string> bodydid = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ms-flow/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydid != null)
                {
                    body["did"] = SourceExpressionConverter.ConvertToken(bodydid);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryResponse>(BuildSourceInput);
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