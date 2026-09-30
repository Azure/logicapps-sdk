//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tomorrowioip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TomorrowioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tomorrowioip")]
        public IBodyWorkflowAction<ForecastGetResponse> ForecastGet([WorkflowExpression] Func<string> location, [WorkflowExpression] Func<string[]> timesteps = null, [WorkflowExpression] Func<unitsInput> units = null)
        {
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(timesteps, nameof(timesteps), required: false);
            SourceExpression.Validate(units, nameof(units), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/weather/forecast";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (timesteps != null)
                    callPayload.Queries["timesteps"] = SourceExpressionConverter.ConvertO(timesteps);
                if (units != null)
                    callPayload.Queries["units"] = SourceExpressionConverter.Convert(units);
                return callPayload;
            }

            return new ApiConnectionAction<ForecastGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tomorrowioip")]
        public IBodyWorkflowAction<RealtimeGetResponse> RealtimeGet([WorkflowExpression] Func<string> location, [WorkflowExpression] Func<unitsInput> units = null)
        {
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(units, nameof(units), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/weather/realtime";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (units != null)
                    callPayload.Queries["units"] = SourceExpressionConverter.Convert(units);
                return callPayload;
            }

            return new ApiConnectionAction<RealtimeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tomorrowioip")]
        public IBodyWorkflowAction<TimelinePostResponse> Timeline([WorkflowExpression] Func<string> bodylocation, [WorkflowExpression] Func<string[]> bodyfields, [WorkflowExpression] Func<bodyunitsInput> bodyunits = null, [WorkflowExpression] Func<string[]> bodytimesteps = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            SourceExpression.Validate(bodylocation, nameof(bodylocation), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            SourceExpression.Validate(bodyunits, nameof(bodyunits), required: false);
            SourceExpression.Validate(bodytimesteps, nameof(bodytimesteps), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/timelines";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodyunits != null)
                {
                    body["units"] = SourceExpressionConverter.Convert(bodyunits);
                    bodypropCount++;
                }

                if (bodytimesteps != null)
                {
                    body["timesteps"] = SourceExpressionConverter.ConvertToken(bodytimesteps);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimelinePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tomorrowioip")]
        public IBodyWorkflowAction<MapGetResponse> MapGet([WorkflowExpression] Func<string> zoom, [WorkflowExpression] Func<string> x, [WorkflowExpression] Func<string> y, [WorkflowExpression] Func<string> field, [WorkflowExpression] Func<string> time)
        {
            SourceExpression.Validate(zoom, nameof(zoom), required: true);
            SourceExpression.Validate(x, nameof(x), required: true);
            SourceExpression.Validate(y, nameof(y), required: true);
            SourceExpression.Validate(field, nameof(field), required: true);
            SourceExpression.Validate(time, nameof(time), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/map/tile/{0}/{1}/{2}/{3}/{4}.{5}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(zoom, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(x, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(y, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(field, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(time, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "png"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MapGetResponse>(BuildSourceInput);
        }
    }

    public class TomorrowioipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ForecastGetResponse
    {
        [JsonProperty("timelines")]
        public ForecastGetResponseTimelinesType Timelines { get; set; }

        [JsonProperty("location")]
        public ForecastGetResponseLocationType Location { get; set; }
    }

    public class ForecastGetResponseTimelinesType
    {
        [JsonProperty("minutely")]
        public ForecastGetResponseTimelinesTypeMinutelyTypeItem[] Minutely { get; set; }

        [JsonProperty("hourly")]
        public ForecastGetResponseTimelinesTypeHourlyTypeItem[] Hourly { get; set; }

        [JsonProperty("daily")]
        public ForecastGetResponseTimelinesTypeDailyTypeItem[] Daily { get; set; }
    }

    public class ForecastGetResponseTimelinesTypeMinutelyTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("values")]
        public ForecastGetResponseTimelinesTypeMinutelyTypeItemValuesType Values { get; set; }
    }

    public class ForecastGetResponseTimelinesTypeMinutelyTypeItemValuesType
    {
        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("freezingRainIntensity")]
        public int FreezingRainIntensity { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("precipitationProbability")]
        public int PrecipitationProbability { get; set; }

        [JsonProperty("pressureSurfaceLevel")]
        public double PressureSurfaceLevel { get; set; }

        [JsonProperty("rainIntensity")]
        public int RainIntensity { get; set; }

        [JsonProperty("sleetIntensity")]
        public int SleetIntensity { get; set; }

        [JsonProperty("snowIntensity")]
        public int SnowIntensity { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("temperatureApparent")]
        public double TemperatureApparent { get; set; }

        [JsonProperty("uvHealthConcern")]
        public int UvHealthConcern { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("weatherCode")]
        public int WeatherCode { get; set; }

        [JsonProperty("windDirection")]
        public double WindDirection { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }

    public class ForecastGetResponseTimelinesTypeHourlyTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("values")]
        public ForecastGetResponseTimelinesTypeHourlyTypeItemValuesType Values { get; set; }
    }

    public class ForecastGetResponseTimelinesTypeHourlyTypeItemValuesType
    {
        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("evapotranspiration")]
        public double Evapotranspiration { get; set; }

        [JsonProperty("freezingRainIntensity")]
        public int FreezingRainIntensity { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("iceAccumulation")]
        public int IceAccumulation { get; set; }

        [JsonProperty("iceAccumulationLwe")]
        public int IceAccumulationLwe { get; set; }

        [JsonProperty("precipitationProbability")]
        public int PrecipitationProbability { get; set; }

        [JsonProperty("pressureSurfaceLevel")]
        public double PressureSurfaceLevel { get; set; }

        [JsonProperty("rainAccumulation")]
        public int RainAccumulation { get; set; }

        [JsonProperty("rainAccumulationLwe")]
        public int RainAccumulationLwe { get; set; }

        [JsonProperty("rainIntensity")]
        public int RainIntensity { get; set; }

        [JsonProperty("sleetAccumulation")]
        public int SleetAccumulation { get; set; }

        [JsonProperty("sleetAccumulationLwe")]
        public int SleetAccumulationLwe { get; set; }

        [JsonProperty("sleetIntensity")]
        public int SleetIntensity { get; set; }

        [JsonProperty("snowAccumulation")]
        public int SnowAccumulation { get; set; }

        [JsonProperty("snowAccumulationLwe")]
        public int SnowAccumulationLwe { get; set; }

        [JsonProperty("snowIntensity")]
        public int SnowIntensity { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("temperatureApparent")]
        public double TemperatureApparent { get; set; }

        [JsonProperty("uvHealthConcern")]
        public int UvHealthConcern { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("weatherCode")]
        public int WeatherCode { get; set; }

        [JsonProperty("windDirection")]
        public double WindDirection { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }

    public class ForecastGetResponseTimelinesTypeDailyTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("values")]
        public ForecastGetResponseTimelinesTypeDailyTypeItemValuesType Values { get; set; }
    }

    public class ForecastGetResponseTimelinesTypeDailyTypeItemValuesType
    {
        [JsonProperty("cloudBaseAvg")]
        public double CloudBaseAvg { get; set; }

        [JsonProperty("cloudBaseMax")]
        public double CloudBaseMax { get; set; }

        [JsonProperty("cloudBaseMin")]
        public int CloudBaseMin { get; set; }

        [JsonProperty("cloudCeilingAvg")]
        public double CloudCeilingAvg { get; set; }

        [JsonProperty("cloudCeilingMax")]
        public double CloudCeilingMax { get; set; }

        [JsonProperty("cloudCeilingMin")]
        public int CloudCeilingMin { get; set; }

        [JsonProperty("cloudCoverAvg")]
        public double CloudCoverAvg { get; set; }

        [JsonProperty("cloudCoverMax")]
        public double CloudCoverMax { get; set; }

        [JsonProperty("cloudCoverMin")]
        public double CloudCoverMin { get; set; }

        [JsonProperty("dewPointAvg")]
        public double DewPointAvg { get; set; }

        [JsonProperty("dewPointMax")]
        public double DewPointMax { get; set; }

        [JsonProperty("dewPointMin")]
        public double DewPointMin { get; set; }

        [JsonProperty("evapotranspirationAvg")]
        public double EvapotranspirationAvg { get; set; }

        [JsonProperty("evapotranspirationMax")]
        public double EvapotranspirationMax { get; set; }

        [JsonProperty("evapotranspirationMin")]
        public double EvapotranspirationMin { get; set; }

        [JsonProperty("evapotranspirationSum")]
        public double EvapotranspirationSum { get; set; }

        [JsonProperty("freezingRainIntensityAvg")]
        public int FreezingRainIntensityAvg { get; set; }

        [JsonProperty("freezingRainIntensityMax")]
        public int FreezingRainIntensityMax { get; set; }

        [JsonProperty("freezingRainIntensityMin")]
        public int FreezingRainIntensityMin { get; set; }

        [JsonProperty("humidityAvg")]
        public double HumidityAvg { get; set; }

        [JsonProperty("humidityMax")]
        public double HumidityMax { get; set; }

        [JsonProperty("humidityMin")]
        public double HumidityMin { get; set; }

        [JsonProperty("iceAccumulationAvg")]
        public int IceAccumulationAvg { get; set; }

        [JsonProperty("iceAccumulationLweAvg")]
        public int IceAccumulationLweAvg { get; set; }

        [JsonProperty("iceAccumulationLweMax")]
        public int IceAccumulationLweMax { get; set; }

        [JsonProperty("iceAccumulationLweMin")]
        public int IceAccumulationLweMin { get; set; }

        [JsonProperty("iceAccumulationLweSum")]
        public int IceAccumulationLweSum { get; set; }

        [JsonProperty("iceAccumulationMax")]
        public int IceAccumulationMax { get; set; }

        [JsonProperty("iceAccumulationMin")]
        public int IceAccumulationMin { get; set; }

        [JsonProperty("iceAccumulationSum")]
        public int IceAccumulationSum { get; set; }

        [JsonProperty("moonriseTime")]
        public string MoonriseTime { get; set; }

        [JsonProperty("moonsetTime")]
        public string MoonsetTime { get; set; }

        [JsonProperty("precipitationProbabilityAvg")]
        public int PrecipitationProbabilityAvg { get; set; }

        [JsonProperty("precipitationProbabilityMax")]
        public int PrecipitationProbabilityMax { get; set; }

        [JsonProperty("precipitationProbabilityMin")]
        public int PrecipitationProbabilityMin { get; set; }

        [JsonProperty("pressureSurfaceLevelAvg")]
        public double PressureSurfaceLevelAvg { get; set; }

        [JsonProperty("pressureSurfaceLevelMax")]
        public double PressureSurfaceLevelMax { get; set; }

        [JsonProperty("pressureSurfaceLevelMin")]
        public double PressureSurfaceLevelMin { get; set; }

        [JsonProperty("rainAccumulationAvg")]
        public int RainAccumulationAvg { get; set; }

        [JsonProperty("rainAccumulationLweAvg")]
        public int RainAccumulationLweAvg { get; set; }

        [JsonProperty("rainAccumulationLweMax")]
        public int RainAccumulationLweMax { get; set; }

        [JsonProperty("rainAccumulationLweMin")]
        public int RainAccumulationLweMin { get; set; }

        [JsonProperty("rainAccumulationMax")]
        public int RainAccumulationMax { get; set; }

        [JsonProperty("rainAccumulationMin")]
        public int RainAccumulationMin { get; set; }

        [JsonProperty("rainAccumulationSum")]
        public int RainAccumulationSum { get; set; }

        [JsonProperty("rainIntensityAvg")]
        public int RainIntensityAvg { get; set; }

        [JsonProperty("rainIntensityMax")]
        public int RainIntensityMax { get; set; }

        [JsonProperty("rainIntensityMin")]
        public int RainIntensityMin { get; set; }

        [JsonProperty("sleetAccumulationAvg")]
        public int SleetAccumulationAvg { get; set; }

        [JsonProperty("sleetAccumulationLweAvg")]
        public int SleetAccumulationLweAvg { get; set; }

        [JsonProperty("sleetAccumulationLweMax")]
        public int SleetAccumulationLweMax { get; set; }

        [JsonProperty("sleetAccumulationLweMin")]
        public int SleetAccumulationLweMin { get; set; }

        [JsonProperty("sleetAccumulationLweSum")]
        public int SleetAccumulationLweSum { get; set; }

        [JsonProperty("sleetAccumulationMax")]
        public int SleetAccumulationMax { get; set; }

        [JsonProperty("sleetAccumulationMin")]
        public int SleetAccumulationMin { get; set; }

        [JsonProperty("sleetIntensityAvg")]
        public int SleetIntensityAvg { get; set; }

        [JsonProperty("sleetIntensityMax")]
        public int SleetIntensityMax { get; set; }

        [JsonProperty("sleetIntensityMin")]
        public int SleetIntensityMin { get; set; }

        [JsonProperty("snowAccumulationAvg")]
        public int SnowAccumulationAvg { get; set; }

        [JsonProperty("snowAccumulationLweAvg")]
        public int SnowAccumulationLweAvg { get; set; }

        [JsonProperty("snowAccumulationLweMax")]
        public int SnowAccumulationLweMax { get; set; }

        [JsonProperty("snowAccumulationLweMin")]
        public int SnowAccumulationLweMin { get; set; }

        [JsonProperty("snowAccumulationLweSum")]
        public int SnowAccumulationLweSum { get; set; }

        [JsonProperty("snowAccumulationMax")]
        public int SnowAccumulationMax { get; set; }

        [JsonProperty("snowAccumulationMin")]
        public int SnowAccumulationMin { get; set; }

        [JsonProperty("snowAccumulationSum")]
        public int SnowAccumulationSum { get; set; }

        [JsonProperty("snowIntensityAvg")]
        public int SnowIntensityAvg { get; set; }

        [JsonProperty("snowIntensityMax")]
        public int SnowIntensityMax { get; set; }

        [JsonProperty("snowIntensityMin")]
        public int SnowIntensityMin { get; set; }

        [JsonProperty("sunriseTime")]
        public string SunriseTime { get; set; }

        [JsonProperty("sunsetTime")]
        public string SunsetTime { get; set; }

        [JsonProperty("temperatureApparentAvg")]
        public double TemperatureApparentAvg { get; set; }

        [JsonProperty("temperatureApparentMax")]
        public double TemperatureApparentMax { get; set; }

        [JsonProperty("temperatureApparentMin")]
        public double TemperatureApparentMin { get; set; }

        [JsonProperty("temperatureAvg")]
        public double TemperatureAvg { get; set; }

        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }

        [JsonProperty("uvHealthConcernAvg")]
        public int UvHealthConcernAvg { get; set; }

        [JsonProperty("uvHealthConcernMax")]
        public int UvHealthConcernMax { get; set; }

        [JsonProperty("uvHealthConcernMin")]
        public int UvHealthConcernMin { get; set; }

        [JsonProperty("uvIndexAvg")]
        public int UvIndexAvg { get; set; }

        [JsonProperty("uvIndexMax")]
        public int UvIndexMax { get; set; }

        [JsonProperty("uvIndexMin")]
        public int UvIndexMin { get; set; }

        [JsonProperty("visibilityAvg")]
        public double VisibilityAvg { get; set; }

        [JsonProperty("visibilityMax")]
        public double VisibilityMax { get; set; }

        [JsonProperty("visibilityMin")]
        public double VisibilityMin { get; set; }

        [JsonProperty("weatherCodeMax")]
        public int WeatherCodeMax { get; set; }

        [JsonProperty("weatherCodeMin")]
        public int WeatherCodeMin { get; set; }

        [JsonProperty("windDirectionAvg")]
        public double WindDirectionAvg { get; set; }

        [JsonProperty("windGustAvg")]
        public double WindGustAvg { get; set; }

        [JsonProperty("windGustMax")]
        public double WindGustMax { get; set; }

        [JsonProperty("windGustMin")]
        public double WindGustMin { get; set; }

        [JsonProperty("windSpeedAvg")]
        public double WindSpeedAvg { get; set; }

        [JsonProperty("windSpeedMax")]
        public double WindSpeedMax { get; set; }

        [JsonProperty("windSpeedMin")]
        public double WindSpeedMin { get; set; }
    }

    public class ForecastGetResponseLocationType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum unitsInput
    {
        [EnumMember(Value = "metric")]
        Metric,
        [EnumMember(Value = "imperial")]
        Imperial
    }

    public class RealtimeGetResponse
    {
        [JsonProperty("data")]
        public RealtimeGetResponseDataType Data { get; set; }

        [JsonProperty("location")]
        public RealtimeGetResponseLocationType Location { get; set; }
    }

    public class RealtimeGetResponseDataType
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("values")]
        public RealtimeGetResponseDataTypeValuesType Values { get; set; }
    }

    public class RealtimeGetResponseDataTypeValuesType
    {
        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("freezingRainIntensity")]
        public int FreezingRainIntensity { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("precipitationProbability")]
        public int PrecipitationProbability { get; set; }

        [JsonProperty("pressureSurfaceLevel")]
        public double PressureSurfaceLevel { get; set; }

        [JsonProperty("rainIntensity")]
        public int RainIntensity { get; set; }

        [JsonProperty("sleetIntensity")]
        public int SleetIntensity { get; set; }

        [JsonProperty("snowIntensity")]
        public int SnowIntensity { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("temperatureApparent")]
        public double TemperatureApparent { get; set; }

        [JsonProperty("uvHealthConcern")]
        public int UvHealthConcern { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("weatherCode")]
        public int WeatherCode { get; set; }

        [JsonProperty("windDirection")]
        public double WindDirection { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }

    public class RealtimeGetResponseLocationType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TimelinePostResponse
    {
        [JsonProperty("data")]
        public TimelinePostResponseDataType Data { get; set; }
    }

    public class TimelinePostResponseDataType
    {
        [JsonProperty("timelines")]
        public TimelinePostResponseDataTypeTimelinesTypeItem[] Timelines { get; set; }
    }

    public class TimelinePostResponseDataTypeTimelinesTypeItem
    {
        [JsonProperty("timestep")]
        public string Timestep { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("intervals")]
        public TimelinePostResponseDataTypeTimelinesTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class TimelinePostResponseDataTypeTimelinesTypeItemIntervalsTypeItem
    {
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("values")]
        public TimelinePostResponseDataTypeTimelinesTypeItemIntervalsTypeItemValuesType Values { get; set; }
    }

    public class TimelinePostResponseDataTypeTimelinesTypeItemIntervalsTypeItemValuesType
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
    }

    public enum bodyunitsInput
    {
        [EnumMember(Value = "metric")]
        Metric,
        [EnumMember(Value = "imperial")]
        Imperial
    }

    public class MapGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tomorrowioip;

    public partial class WorkflowManagedActions
    {
        public TomorrowioipActions Tomorrowioip(string connectionId) => new TomorrowioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TomorrowioipTriggers Tomorrowioip(string connectionId) => new TomorrowioipTriggers(connectionId);
    }
}