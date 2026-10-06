//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Weatherforecastip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WeatherforecastipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weatherforecastip")]
        [WorkflowExpressionFactory(nameof(__BuildCity))]
        public IBodyWorkflowAction<CityResponse> City([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> appid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "weatherforecastip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CityResponse> __BuildCity(WorkflowExpression<string> q = null, WorkflowExpression<string> appid = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(appid, nameof(appid), required: false);
            return new DeferredBodyAction<CityResponse>(() =>
            {
                var apiCallPath = "/data/2.5/weather";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (appid != null)
                    callPayload.Queries["appid"] = ExpressionConverter.Convert(appid);
                return new ApiConnectionAction<CityResponse>(callPayload);
            });
        }
    }

    public class WeatherforecastipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CityResponse
    {
        [JsonProperty("coord")]
        public CityResponseCoordType Coord { get; set; }

        [JsonProperty("weather")]
        public CityResponseWeatherTypeItem[] Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public CityResponseMainType Main { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind")]
        public CityResponseWindType Wind { get; set; }

        [JsonProperty("clouds")]
        public CityResponseCloudsType Clouds { get; set; }

        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("sys")]
        public CityResponseSysType Sys { get; set; }

        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cod")]
        public int Cod { get; set; }
    }

    public class CityResponseCoordType
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class CityResponseWeatherTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class CityResponseMainType
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("sea_level")]
        public int SeaLevel { get; set; }

        [JsonProperty("grnd_level")]
        public int GrndLevel { get; set; }
    }

    public class CityResponseWindType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public int Deg { get; set; }
    }

    public class CityResponseCloudsType
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

    public class CityResponseSysType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Weatherforecastip;

    public partial class WorkflowManagedActions
    {
        public WeatherforecastipActions Weatherforecastip(string connectionId) => new WeatherforecastipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WeatherforecastipTriggers Weatherforecastip(string connectionId) => new WeatherforecastipTriggers(connectionId);
    }
}