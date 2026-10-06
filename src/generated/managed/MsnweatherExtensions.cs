//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Msnweather
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MsnweatherActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        [WorkflowExpressionFactory(nameof(__BuildCurrentWeather))]
        public IBodyWorkflowAction<CurrentWeather> CurrentWeather([WorkflowExpression] Func<string> location, [WorkflowExpression] Func<unitsInput> units)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CurrentWeather> __BuildCurrentWeather(WorkflowExpression<string> location, WorkflowExpression<unitsInput> units)
        {
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(units, nameof(units), required: true);
            return new DeferredBodyAction<CurrentWeather>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/current/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                return new ApiConnectionAction<CurrentWeather>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        [WorkflowExpressionFactory(nameof(__BuildTodaysForecast))]
        public IBodyWorkflowAction<WeatherForecast> TodaysForecast([WorkflowExpression] Func<string> location, [WorkflowExpression] Func<unitsInput> units)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WeatherForecast> __BuildTodaysForecast(WorkflowExpression<string> location, WorkflowExpression<unitsInput> units)
        {
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(units, nameof(units), required: true);
            return new DeferredBodyAction<WeatherForecast>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/forecast/today/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                return new ApiConnectionAction<WeatherForecast>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        [WorkflowExpressionFactory(nameof(__BuildTomorrowsForecast))]
        public IBodyWorkflowAction<WeatherForecast> TomorrowsForecast([WorkflowExpression] Func<string> location, [WorkflowExpression] Func<unitsInput> units)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msnweather")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WeatherForecast> __BuildTomorrowsForecast(WorkflowExpression<string> location, WorkflowExpression<unitsInput> units)
        {
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(units, nameof(units), required: true);
            return new DeferredBodyAction<WeatherForecast>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/forecast/tomorrow/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                return new ApiConnectionAction<WeatherForecast>(callPayload);
            });
        }
    }

    public class MsnweatherTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnCurrentWeatherChange))]
        public IBodyWorkflowTrigger<CurrentWeather> OnCurrentWeatherChange([WorkflowExpression] Func<string> location,[WorkflowExpression] Func<measureInput> measure,[WorkflowExpression] Func<whenInput> when,[WorkflowExpression] Func<double> target,[WorkflowExpression] Func<string> units,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CurrentWeather> __BuildOnCurrentWeatherChange(WorkflowExpression<string> location,WorkflowExpression<measureInput> measure,WorkflowExpression<whenInput> when,WorkflowExpression<double> target,WorkflowExpression<string> units,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(measure, nameof(measure), required: true);
            WorkflowExpression.Validate(when, nameof(when), required: true);
            WorkflowExpression.Validate(target, nameof(target), required: true);
            WorkflowExpression.Validate(units, nameof(units), required: true);
            return new DeferredBodyTrigger<CurrentWeather>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/current/weather/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Measure"] = ExpressionConverter.Convert(measure);
                callPayload.Queries["When"] = ExpressionConverter.Convert(when);
                callPayload.Queries["Target"] = ExpressionConverter.Convert(target);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                return new ApiConnectionTrigger<CurrentWeather>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnCurrentConditionsChange))]
        public IBodyWorkflowTrigger<CurrentWeather> OnCurrentConditionsChange([WorkflowExpression] Func<string> location,[WorkflowExpression] Func<unitsInput> units,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CurrentWeather> __BuildOnCurrentConditionsChange(WorkflowExpression<string> location,WorkflowExpression<unitsInput> units,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(location, nameof(location), required: true);
            WorkflowExpression.Validate(units, nameof(units), required: true);
            return new DeferredBodyTrigger<CurrentWeather>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/current/conditions/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                return new ApiConnectionTrigger<CurrentWeather>(callPayload, recurrence: recurrence);
            });
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