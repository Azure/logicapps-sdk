//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MsnweatherActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public IBodyWorkflowAction<CurrentWeather> CurrentWeather(Expression<Func<string>> location, Expression<Func<unitsInput>> units)
        {
            var apiCallPath = String.Format("/current/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionAction<CurrentWeather>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public IBodyWorkflowAction<WeatherForecast> TodaysForecast(Expression<Func<string>> location, Expression<Func<unitsInput>> units)
        {
            var apiCallPath = String.Format("/forecast/today/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionAction<WeatherForecast>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public IBodyWorkflowAction<WeatherForecast> TomorrowsForecast(Expression<Func<string>> location, Expression<Func<unitsInput>> units)
        {
            var apiCallPath = String.Format("/forecast/tomorrow/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionAction<WeatherForecast>(callPayload);
        }
    }

    public class MsnweatherTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CurrentWeather> OnCurrentWeatherChange(Expression<Func<string>> location, Expression<Func<measureInput>> measure, Expression<Func<whenInput>> when, Expression<Func<double>> target, Expression<Func<string>> units, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/current/weather/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Measure"] = ExpressionConverter.Convert(measure);
            callPayload.Queries["When"] = ExpressionConverter.Convert(when);
            callPayload.Queries["Target"] = ExpressionConverter.Convert(target);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionTrigger<CurrentWeather>(callPayload);
        }

        public IOutputWorkflowTrigger<CurrentWeather> OnCurrentConditionsChange(Expression<Func<string>> location, Expression<Func<unitsInput>> units, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/current/conditions/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionTrigger<CurrentWeather>(callPayload);
        }
    }

    public class CurrentWeather
    {
        [JsonProperty("responses")]
        public CurrentWeatherResponsesType Responses { get; set; }

        [JsonProperty("units")]
        public CurrentWeatherUnitsType Units { get; set; }
    }

    public class CurrentWeatherResponsesType
    {
        [JsonProperty("weather")]
        public CurrentWeatherResponsesTypeWeatherType Weather { get; set; }

        [JsonProperty("source")]
        public CurrentWeatherResponsesTypeSourceType Source { get; set; }
    }

    public class CurrentWeatherResponsesTypeWeatherType
    {
        [JsonProperty("current")]
        public CurrentWeatherResponsesTypeWeatherTypeCurrentType Current { get; set; }
    }

    public class CurrentWeatherResponsesTypeWeatherTypeCurrentType
    {
        [JsonProperty("baro")]
        public double Pressure { get; set; }

        [JsonProperty("cap")]
        public string Conditions { get; set; }

        [JsonProperty("dewPt")]
        public double Dewpoint { get; set; }

        [JsonProperty("feels")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("rh")]
        public double Humidity { get; set; }

        [JsonProperty("wx")]
        public string METARWeatherConditions { get; set; }

        [JsonProperty("sky")]
        public string METARSkyConditions { get; set; }

        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("uv")]
        public double UVIndex { get; set; }

        [JsonProperty("uvDesc")]
        public string UVIndexDescription { get; set; }

        [JsonProperty("vis")]
        public double VisibilityDistance { get; set; }

        [JsonProperty("windDir")]
        public int WindDirection { get; set; }

        [JsonProperty("windSpd")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGustSpeed { get; set; }

        [JsonProperty("created")]
        public string LastUpdated { get; set; }
    }

    public class CurrentWeatherResponsesTypeSourceType
    {
        [JsonProperty("coordinates")]
        public CurrentWeatherResponsesTypeSourceTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class CurrentWeatherResponsesTypeSourceTypeCoordinatesType
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }

    public class CurrentWeatherUnitsType
    {
        [JsonProperty("system")]
        public string UnitSystem { get; set; }

        [JsonProperty("pressure")]
        public string PressureUnits { get; set; }

        [JsonProperty("temperature")]
        public string TemperatureUnits { get; set; }

        [JsonProperty("speed")]
        public string SpeedUnits { get; set; }

        [JsonProperty("distance")]
        public string DistanceUnits { get; set; }
    }

    public enum unitsInput
    {
        [EnumMember(Value = "I")]
        Imperial,
        [EnumMember(Value = "C")]
        Metric
    }

    public class WeatherForecast
    {
        [JsonProperty("responses")]
        public WeatherForecastResponsesType Responses { get; set; }

        [JsonProperty("units")]
        public WeatherForecastUnitsType Units { get; set; }
    }

    public class WeatherForecastResponsesType
    {
        [JsonProperty("daily")]
        public WeatherForecastResponsesTypeDailyType Daily { get; set; }

        [JsonProperty("almanac")]
        public WeatherForecastResponsesTypeAlmanacType Almanac { get; set; }

        [JsonProperty("source")]
        public WeatherForecastResponsesTypeSourceType Source { get; set; }
    }

    public class WeatherForecastResponsesTypeDailyType
    {
        [JsonProperty("day")]
        public WeatherForecastResponsesTypeDailyTypeDayType Day { get; set; }

        [JsonProperty("night")]
        public WeatherForecastResponsesTypeDailyTypeNightType Night { get; set; }

        [JsonProperty("pvdrCap")]
        public string Conditions { get; set; }

        [JsonProperty("valid")]
        public string Date { get; set; }

        [JsonProperty("precip")]
        public double RainChance { get; set; }

        [JsonProperty("windMax")]
        public double MaxWindSpeed { get; set; }

        [JsonProperty("windMaxDir")]
        public int MaxWindDirection { get; set; }

        [JsonProperty("rhHi")]
        public double HumidityHigh { get; set; }

        [JsonProperty("rhLo")]
        public double HumidityLow { get; set; }

        [JsonProperty("tempHi")]
        public double TemperatureHigh { get; set; }

        [JsonProperty("tempLo")]
        public double TemperatureLow { get; set; }

        [JsonProperty("uv")]
        public double UVIndex { get; set; }

        [JsonProperty("uvDesc")]
        public string UVIndexDescription { get; set; }

        [JsonProperty("created")]
        public string ForecastDate { get; set; }
    }

    public class WeatherForecastResponsesTypeDailyTypeDayType
    {
        [JsonProperty("cap")]
        public string Conditions { get; set; }

        [JsonProperty("precip")]
        public double RainChance { get; set; }

        [JsonProperty("wx")]
        public string METARWeatherConditions { get; set; }

        [JsonProperty("sky")]
        public string METARSkyConditions { get; set; }

        [JsonProperty("windDir")]
        public int WindDirection { get; set; }

        [JsonProperty("windSpd")]
        public double WindSpeed { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class WeatherForecastResponsesTypeDailyTypeNightType
    {
        [JsonProperty("cap")]
        public string Conditions { get; set; }

        [JsonProperty("precip")]
        public double RainChance { get; set; }

        [JsonProperty("wx")]
        public string METARWeatherConditions { get; set; }

        [JsonProperty("sky")]
        public string METARSkyConditions { get; set; }

        [JsonProperty("windDir")]
        public int WindDirection { get; set; }

        [JsonProperty("windSpd")]
        public double WindSpeed { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class WeatherForecastResponsesTypeAlmanacType
    {
        [JsonProperty("sunrise")]
        public string SunriseTime { get; set; }

        [JsonProperty("sunset")]
        public string SunsetTime { get; set; }

        [JsonProperty("moonrise")]
        public string MoonriseTime { get; set; }

        [JsonProperty("moonset")]
        public string MoonsetTime { get; set; }

        [JsonProperty("moonPhase")]
        public string MoonPhase { get; set; }

        [JsonProperty("moonPhaseCode")]
        public string MoonPhaseCode { get; set; }
    }

    public class WeatherForecastResponsesTypeSourceType
    {
        [JsonProperty("coordinates")]
        public WeatherForecastResponsesTypeSourceTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class WeatherForecastResponsesTypeSourceTypeCoordinatesType
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }

    public class WeatherForecastUnitsType
    {
        [JsonProperty("system")]
        public string UnitSystem { get; set; }

        [JsonProperty("pressure")]
        public string PressureUnits { get; set; }

        [JsonProperty("temperature")]
        public string TemperatureUnits { get; set; }

        [JsonProperty("speed")]
        public string SpeedUnits { get; set; }

        [JsonProperty("distance")]
        public string DistanceUnits { get; set; }
    }

    public enum measureInput
    {
        Temperature,
        [EnumMember(Value = "UV Index")]
        UVIndex,
        Humidity,
        [EnumMember(Value = "Wind Speed")]
        WindSpeed
    }

    public enum whenInput
    {
        [EnumMember(Value = "Is equal to")]
        IsEqualTo,
        [EnumMember(Value = "Goes over")]
        GoesOver,
        [EnumMember(Value = "Goes below")]
        GoesBelow
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;

    public partial class WorkflowManagedActions
    {
        public MsnweatherActions Msnweather(string connectionId) => new MsnweatherActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MsnweatherTriggers Msnweather(string connectionId) => new MsnweatherTriggers(connectionId);
    }
}