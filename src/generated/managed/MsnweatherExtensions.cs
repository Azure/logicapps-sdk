//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather
{
    using System.Net;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class MsnweatherExtensions
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public static IOutputWorkflowAction<CurrentWeather> CurrentWeather([ConnectionName] string connectionId, Expression<Func<string>> location, Expression<Func<CurrentWeatherunitsInput>> units)
        {
            var apiCallPath = String.Format("/current/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionAction<CurrentWeather>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public static IOutputWorkflowTrigger<CurrentWeather> WhenOnCurrentWeatherChange([ConnectionName] string connectionId, Expression<Func<string>> location, Expression<Func<OnCurrentWeatherChangeMeasureInput>> measure, Expression<Func<OnCurrentWeatherChangeWhenInput>> when, Expression<Func<double>> target, [DynamicValues("GetMeasureUnits")] Expression<Func<string>> units)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public static IOutputWorkflowTrigger<CurrentWeather> WhenOnCurrentConditionsChange([ConnectionName] string connectionId, Expression<Func<string>> location, Expression<Func<OnCurrentConditionsChangeunitsInput>> units)
        {
            var apiCallPath = String.Format("/trigger/current/conditions/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionTrigger<CurrentWeather>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public static IOutputWorkflowAction<WeatherForecast> TodaysForecast([ConnectionName] string connectionId, Expression<Func<string>> location, Expression<Func<TodaysForecastunitsInput>> units)
        {
            var apiCallPath = String.Format("/forecast/today/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionAction<WeatherForecast>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public static IOutputWorkflowAction<WeatherForecast> TomorrowsForecast([ConnectionName] string connectionId, Expression<Func<string>> location, Expression<Func<TomorrowsForecastunitsInput>> units)
        {
            var apiCallPath = String.Format("/forecast/tomorrow/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["units"] = ExpressionConverter.Convert(units);
            return new ApiConnectionAction<WeatherForecast>(callPayload);
        }
    }

    public class MsnweatherInstance(string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public IOutputWorkflowAction<CurrentWeather> CurrentWeather(Expression<Func<string>> location, Expression<Func<CurrentWeatherunitsInput>> units) => MsnweatherExtensions.CurrentWeather(connectionId, location, units);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public IOutputWorkflowAction<WeatherForecast> TodaysForecast(Expression<Func<string>> location, Expression<Func<TodaysForecastunitsInput>> units) => MsnweatherExtensions.TodaysForecast(connectionId, location, units);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        public IOutputWorkflowAction<WeatherForecast> TomorrowsForecast(Expression<Func<string>> location, Expression<Func<TomorrowsForecastunitsInput>> units) => MsnweatherExtensions.TomorrowsForecast(connectionId, location, units);
    }

    public class MsnweatherInstanceTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CurrentWeather> WhenOnCurrentWeatherChange(Expression<Func<string>> location, Expression<Func<OnCurrentWeatherChangeMeasureInput>> measure, Expression<Func<OnCurrentWeatherChangeWhenInput>> when, Expression<Func<double>> target, [DynamicValues("GetMeasureUnits")] Expression<Func<string>> units) => MsnweatherExtensions.WhenOnCurrentWeatherChange(connectionId, location, measure, when, target, units);
        public IOutputWorkflowTrigger<CurrentWeather> WhenOnCurrentConditionsChange(Expression<Func<string>> location, Expression<Func<OnCurrentConditionsChangeunitsInput>> units) => MsnweatherExtensions.WhenOnCurrentConditionsChange(connectionId, location, units);
    }

    public class CurrentWeatherResponsesTypeWeatherTypeCurrentType
    {
        [JsonProperty("baro")]
        public double Baro { get; set; }

        [JsonProperty("cap")]
        public string Cap { get; set; }

        [JsonProperty("dewPt")]
        public double DewPt { get; set; }

        [JsonProperty("feels")]
        public double Feels { get; set; }

        [JsonProperty("rh")]
        public double Rh { get; set; }

        [JsonProperty("wx")]
        public string Wx { get; set; }

        [JsonProperty("sky")]
        public string Sky { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("uvDesc")]
        public string UvDesc { get; set; }

        [JsonProperty("vis")]
        public double Vis { get; set; }

        [JsonProperty("windDir")]
        public int WindDir { get; set; }

        [JsonProperty("windSpd")]
        public double WindSpd { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class CurrentWeatherResponsesTypeWeatherType
    {
        [JsonProperty("current")]
        public CurrentWeatherResponsesTypeWeatherTypeCurrentType Current { get; set; }
    }

    public class CurrentWeatherResponsesTypeSourceTypeCoordinatesType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }
    }

    public class CurrentWeatherResponsesTypeSourceType
    {
        [JsonProperty("coordinates")]
        public CurrentWeatherResponsesTypeSourceTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class CurrentWeatherResponsesType
    {
        [JsonProperty("weather")]
        public CurrentWeatherResponsesTypeWeatherType Weather { get; set; }

        [JsonProperty("source")]
        public CurrentWeatherResponsesTypeSourceType Source { get; set; }
    }

    public class CurrentWeatherUnitsType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }

    public class CurrentWeather
    {
        [JsonProperty("responses")]
        public CurrentWeatherResponsesType Responses { get; set; }

        [JsonProperty("units")]
        public CurrentWeatherUnitsType Units { get; set; }
    }

    public class WeatherForecastResponsesTypeDailyTypeDayType
    {
        [JsonProperty("cap")]
        public string Cap { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("wx")]
        public string Wx { get; set; }

        [JsonProperty("sky")]
        public string Sky { get; set; }

        [JsonProperty("windDir")]
        public int WindDir { get; set; }

        [JsonProperty("windSpd")]
        public double WindSpd { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class WeatherForecastResponsesTypeDailyTypeNightType
    {
        [JsonProperty("cap")]
        public string Cap { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("wx")]
        public string Wx { get; set; }

        [JsonProperty("sky")]
        public string Sky { get; set; }

        [JsonProperty("windDir")]
        public int WindDir { get; set; }

        [JsonProperty("windSpd")]
        public double WindSpd { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class WeatherForecastResponsesTypeDailyType
    {
        [JsonProperty("day")]
        public WeatherForecastResponsesTypeDailyTypeDayType Day { get; set; }

        [JsonProperty("night")]
        public WeatherForecastResponsesTypeDailyTypeNightType Night { get; set; }

        [JsonProperty("pvdrCap")]
        public string PvdrCap { get; set; }

        [JsonProperty("valid")]
        public string Valid { get; set; }

        [JsonProperty("precip")]
        public double Precip { get; set; }

        [JsonProperty("windMax")]
        public double WindMax { get; set; }

        [JsonProperty("windMaxDir")]
        public int WindMaxDir { get; set; }

        [JsonProperty("rhHi")]
        public double RhHi { get; set; }

        [JsonProperty("rhLo")]
        public double RhLo { get; set; }

        [JsonProperty("tempHi")]
        public double TempHi { get; set; }

        [JsonProperty("tempLo")]
        public double TempLo { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("uvDesc")]
        public string UvDesc { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class WeatherForecastResponsesTypeAlmanacType
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }

        [JsonProperty("moonset")]
        public string Moonset { get; set; }

        [JsonProperty("moonPhase")]
        public string MoonPhase { get; set; }

        [JsonProperty("moonPhaseCode")]
        public string MoonPhaseCode { get; set; }
    }

    public class WeatherForecastResponsesTypeSourceTypeCoordinatesType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }
    }

    public class WeatherForecastResponsesTypeSourceType
    {
        [JsonProperty("coordinates")]
        public WeatherForecastResponsesTypeSourceTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
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

    public class WeatherForecastUnitsType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("temperature")]
        public string Temperature { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }

    public class WeatherForecast
    {
        [JsonProperty("responses")]
        public WeatherForecastResponsesType Responses { get; set; }

        [JsonProperty("units")]
        public WeatherForecastUnitsType Units { get; set; }
    }

    public class MeasureUnitsItem
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public enum CurrentWeatherunitsInput
    {
        [EnumMember(Value = "I")]
        Imperial,
        [EnumMember(Value = "C")]
        Metric
    }

    public enum OnCurrentWeatherChangeMeasureInput
    {
        Temperature,
        [EnumMember(Value = "UV Index")]
        UVIndex,
        Humidity,
        [EnumMember(Value = "Wind Speed")]
        WindSpeed
    }

    public enum OnCurrentWeatherChangeWhenInput
    {
        [EnumMember(Value = "Is equal to")]
        IsEqualTo,
        [EnumMember(Value = "Goes over")]
        GoesOver,
        [EnumMember(Value = "Goes below")]
        GoesBelow
    }

    public enum OnCurrentConditionsChangeunitsInput
    {
        [EnumMember(Value = "I")]
        Imperial,
        [EnumMember(Value = "C")]
        Metric
    }

    public enum TodaysForecastunitsInput
    {
        [EnumMember(Value = "I")]
        Imperial,
        [EnumMember(Value = "C")]
        Metric
    }

    public enum TomorrowsForecastunitsInput
    {
        [EnumMember(Value = "I")]
        Imperial,
        [EnumMember(Value = "C")]
        Metric
    }

    public enum GetMeasureUnitsMeasureInput
    {
        Temperature,
        [EnumMember(Value = "UV Index")]
        UVIndex,
        Humidity,
        [EnumMember(Value = "Wind Speed")]
        WindSpeed
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather;

    public static class MsnweatherTriggerInstanceExtensions
    {
        public static MsnweatherInstanceTriggers Msnweather(this WorkflowManagedTriggers t, string connectionId) => new MsnweatherInstanceTriggers(connectionId);
        public static MsnweatherInstance Msnweather(this WorkflowManagedActions t, string connectionId) => new MsnweatherInstance(connectionId);
    }
}