//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stormglassip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StormglassipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildWeatherPointRequest))]
        public IBodyWorkflowAction<WeatherPointRequestResponse> WeatherPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> @params, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WeatherPointRequestResponse> __BuildWeatherPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> @params, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> source = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(@params, nameof(@params), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<WeatherPointRequestResponse>(() =>
            {
                var apiCallPath = "/weather/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                callPayload.Queries["params"] = ExpressionConverter.Convert(@params);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<WeatherPointRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildBioPointRequest))]
        public IBodyWorkflowAction<BioPointRequestResponse> BioPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> @params, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BioPointRequestResponse> __BuildBioPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> @params, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> source = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(@params, nameof(@params), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<BioPointRequestResponse>(() =>
            {
                var apiCallPath = "/bio/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                callPayload.Queries["params"] = ExpressionConverter.Convert(@params);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<BioPointRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildTimeExtremesPointRequest))]
        public IBodyWorkflowAction<TimeExtremesPointRequestResponse> TimeExtremesPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> datum = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeExtremesPointRequestResponse> __BuildTimeExtremesPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> datum = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(datum, nameof(datum), required: false);
            return new DeferredBodyAction<TimeExtremesPointRequestResponse>(() =>
            {
                var apiCallPath = "/tide/extremes/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (datum != null)
                    callPayload.Queries["datum"] = ExpressionConverter.Convert(datum);
                return new ApiConnectionAction<TimeExtremesPointRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildTimeSealLevelPointRequest))]
        public IBodyWorkflowAction<TimeSealLevelPointRequestResponse> TimeSealLevelPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> datum = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeSealLevelPointRequestResponse> __BuildTimeSealLevelPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> datum = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(datum, nameof(datum), required: false);
            return new DeferredBodyAction<TimeSealLevelPointRequestResponse>(() =>
            {
                var apiCallPath = "/tide/sea-level/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (datum != null)
                    callPayload.Queries["datum"] = ExpressionConverter.Convert(datum);
                return new ApiConnectionAction<TimeSealLevelPointRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        public IBodyWorkflowAction<GetTideStationsResponse> GetTideStations()
        {
            var apiCallPath = "/tide/stations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTideStationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTideStationsArea))]
        public IBodyWorkflowAction<GetTideStationsAreaResponse> GetTideStationsArea([WorkflowExpression] Func<string> box)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTideStationsAreaResponse> __BuildGetTideStationsArea(WorkflowExpression<string> box)
        {
            WorkflowExpression.Validate(box, nameof(box), required: true);
            return new DeferredBodyAction<GetTideStationsAreaResponse>(() =>
            {
                var apiCallPath = "/tide/stations/area";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["box"] = ExpressionConverter.Convert(box);
                return new ApiConnectionAction<GetTideStationsAreaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildAstronomyPointRequest))]
        public IBodyWorkflowAction<AstronomyPointRequestResponse> AstronomyPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> start = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AstronomyPointRequestResponse> __BuildAstronomyPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> end = null, WorkflowExpression<string> start = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            return new DeferredBodyAction<AstronomyPointRequestResponse>(() =>
            {
                var apiCallPath = "/astronomy/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                return new ApiConnectionAction<AstronomyPointRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildSolarPointRequest))]
        public IBodyWorkflowAction<SolarPointRequestResponse> SolarPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> @params, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SolarPointRequestResponse> __BuildSolarPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> @params, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> source = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(@params, nameof(@params), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<SolarPointRequestResponse>(() =>
            {
                var apiCallPath = "/solar/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                callPayload.Queries["params"] = ExpressionConverter.Convert(@params);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<SolarPointRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [WorkflowExpressionFactory(nameof(__BuildElevationPointRequest))]
        public IBodyWorkflowAction<ElevationPointRequestResponse> ElevationPointRequest([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormglassip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ElevationPointRequestResponse> __BuildElevationPointRequest(WorkflowExpression<double> lat, WorkflowExpression<double> lng)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            return new DeferredBodyAction<ElevationPointRequestResponse>(() =>
            {
                var apiCallPath = "/elevation/point";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<ElevationPointRequestResponse>(callPayload);
            });
        }
    }

    public class StormglassipTriggers([ConnectionName] string connectionId)
    {
    }

    public class WeatherPointRequestResponse
    {
        [JsonProperty("hours")]
        public WeatherPointRequestResponseHoursTypeItem[] Hours { get; set; }

        [JsonProperty("meta")]
        public MetaDataModel Meta { get; set; }
    }

    public class WeatherPointRequestResponseHoursTypeItem
    {
        [JsonProperty("airTemperature")]
        public JToken AirTemperature { get; set; }

        [JsonProperty("airTemperature1000hpa")]
        public JToken AirTemperature1000hpa { get; set; }

        [JsonProperty("airTemperature100m")]
        public JToken AirTemperature100m { get; set; }

        [JsonProperty("airTemperature200hpa")]
        public JToken AirTemperature200hpa { get; set; }

        [JsonProperty("airTemperature500hpa")]
        public JToken AirTemperature500hpa { get; set; }

        [JsonProperty("airTemperature800hpa")]
        public JToken AirTemperature800hpa { get; set; }

        [JsonProperty("airTemperature80m")]
        public JToken AirTemperature80m { get; set; }

        [JsonProperty("cloudCover")]
        public JToken CloudCover { get; set; }

        [JsonProperty("currentDirection")]
        public JToken CurrentDirection { get; set; }

        [JsonProperty("currentSpeed")]
        public JToken CurrentSpeed { get; set; }

        [JsonProperty("gust")]
        public JToken Gust { get; set; }

        [JsonProperty("humidity")]
        public JToken Humidity { get; set; }

        [JsonProperty("iceCover")]
        public JToken IceCover { get; set; }

        [JsonProperty("precipitation")]
        public JToken Precipitation { get; set; }

        [JsonProperty("pressure")]
        public JToken Pressure { get; set; }

        [JsonProperty("seaLevel")]
        public JToken SeaLevel { get; set; }

        [JsonProperty("secondarySwellDirection")]
        public JToken SecondarySwellDirection { get; set; }

        [JsonProperty("secondarySwellHeight")]
        public JToken SecondarySwellHeight { get; set; }

        [JsonProperty("secondarySwellPeriod")]
        public JToken SecondarySwellPeriod { get; set; }

        [JsonProperty("snowDepth")]
        public JToken SnowDepth { get; set; }

        [JsonProperty("swellDirection")]
        public JToken SwellDirection { get; set; }

        [JsonProperty("swellHeight")]
        public JToken SwellHeight { get; set; }

        [JsonProperty("swellPeriod")]
        public JToken SwellPeriod { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("visibility")]
        public JToken Visibility { get; set; }

        [JsonProperty("waterTemperature")]
        public JToken WaterTemperature { get; set; }

        [JsonProperty("waveDirection")]
        public JToken WaveDirection { get; set; }

        [JsonProperty("waveHeight")]
        public JToken WaveHeight { get; set; }

        [JsonProperty("wavePeriod")]
        public JToken WavePeriod { get; set; }

        [JsonProperty("windDirection")]
        public JToken WindDirection { get; set; }

        [JsonProperty("windDirection1000hpa")]
        public JToken WindDirection1000hpa { get; set; }

        [JsonProperty("windDirection100m")]
        public JToken WindDirection100m { get; set; }

        [JsonProperty("windDirection200hpa")]
        public JToken WindDirection200hpa { get; set; }

        [JsonProperty("windDirection20m")]
        public JToken WindDirection20m { get; set; }

        [JsonProperty("windDirection30m")]
        public JToken WindDirection30m { get; set; }

        [JsonProperty("windDirection40m")]
        public JToken WindDirection40m { get; set; }

        [JsonProperty("windDirection500hpa")]
        public JToken WindDirection500hpa { get; set; }

        [JsonProperty("windDirection50m")]
        public JToken WindDirection50m { get; set; }

        [JsonProperty("windDirection800hpa")]
        public JToken WindDirection800hpa { get; set; }

        [JsonProperty("windDirection80m")]
        public JToken WindDirection80m { get; set; }

        [JsonProperty("windSpeed")]
        public JToken WindSpeed { get; set; }

        [JsonProperty("windSpeed1000hpa")]
        public JToken WindSpeed1000hpa { get; set; }

        [JsonProperty("windSpeed100m")]
        public JToken WindSpeed100m { get; set; }

        [JsonProperty("windSpeed200hpa")]
        public JToken WindSpeed200hpa { get; set; }

        [JsonProperty("windSpeed20m")]
        public JToken WindSpeed20m { get; set; }

        [JsonProperty("windSpeed30m")]
        public JToken WindSpeed30m { get; set; }

        [JsonProperty("windSpeed40m")]
        public JToken WindSpeed40m { get; set; }

        [JsonProperty("windSpeed500hpa")]
        public JToken WindSpeed500hpa { get; set; }

        [JsonProperty("windSpeed50m")]
        public JToken WindSpeed50m { get; set; }

        [JsonProperty("windSpeed800hpa")]
        public JToken WindSpeed800hpa { get; set; }

        [JsonProperty("windSpeed80m")]
        public JToken WindSpeed80m { get; set; }

        [JsonProperty("windWaveDirection")]
        public JToken WindWaveDirection { get; set; }

        [JsonProperty("windWaveHeight")]
        public JToken WindWaveHeight { get; set; }

        [JsonProperty("windWavePeriod")]
        public JToken WindWavePeriod { get; set; }
    }

    public class MetaDataModel
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("dailyQuota")]
        public int DailyQuota { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("params")]
        public string[] Params { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class BioPointRequestResponse
    {
        [JsonProperty("hours")]
        public BioPointRequestResponseHoursTypeItem[] Hours { get; set; }

        [JsonProperty("meta")]
        public MetaDataModel Meta { get; set; }
    }

    public class BioPointRequestResponseHoursTypeItem
    {
        [JsonProperty("chlorophyll")]
        public JToken Chlorophyll { get; set; }

        [JsonProperty("iron")]
        public JToken Iron { get; set; }

        [JsonProperty("nitrate")]
        public JToken Nitrate { get; set; }

        [JsonProperty("oxygen")]
        public JToken Oxygen { get; set; }

        [JsonProperty("ph")]
        public JToken Ph { get; set; }

        [JsonProperty("phosphate")]
        public JToken Phosphate { get; set; }

        [JsonProperty("phyto")]
        public JToken Phyto { get; set; }

        [JsonProperty("phytoplankton")]
        public JToken Phytoplankton { get; set; }

        [JsonProperty("salinity")]
        public JToken Salinity { get; set; }

        [JsonProperty("silicate")]
        public JToken Silicate { get; set; }

        [JsonProperty("soilMoisture")]
        public JToken SoilMoisture { get; set; }

        [JsonProperty("soilMoisture100cm")]
        public JToken SoilMoisture100cm { get; set; }

        [JsonProperty("soilMoisture10cm")]
        public JToken SoilMoisture10cm { get; set; }

        [JsonProperty("soilMoisture40cm")]
        public JToken SoilMoisture40cm { get; set; }

        [JsonProperty("soilTemperature")]
        public JToken SoilTemperature { get; set; }

        [JsonProperty("soilTemperature100cm")]
        public JToken SoilTemperature100cm { get; set; }

        [JsonProperty("soilTemperature10cm")]
        public JToken SoilTemperature10cm { get; set; }

        [JsonProperty("soilTemperature40cm")]
        public JToken SoilTemperature40cm { get; set; }

        [JsonProperty("surfaceTemperature")]
        public JToken SurfaceTemperature { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class TimeExtremesPointRequestResponse
    {
        [JsonProperty("data")]
        public TimeExtremesPointRequestResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public TideMetaDataModel Meta { get; set; }
    }

    public class TimeExtremesPointRequestResponseDataTypeItem
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TideMetaDataModel
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("dailyQuota")]
        public int DailyQuota { get; set; }

        [JsonProperty("datum")]
        public string Datum { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("station")]
        public TideMetaDataModelStationType Station { get; set; }
    }

    public class TideMetaDataModelStationType
    {
        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class TimeSealLevelPointRequestResponse
    {
        [JsonProperty("data")]
        public TimeSealLevelPointRequestResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public TideMetaDataModel Meta { get; set; }
    }

    public class TimeSealLevelPointRequestResponseDataTypeItem
    {
        [JsonProperty("icon")]
        public double Icon { get; set; }

        [JsonProperty("noaa")]
        public double Noaa { get; set; }

        [JsonProperty("meteo")]
        public double Meteo { get; set; }

        [JsonProperty("dwd")]
        public double Dwd { get; set; }

        [JsonProperty("meto")]
        public double Meto { get; set; }

        [JsonProperty("fcoo")]
        public double Fcoo { get; set; }

        [JsonProperty("fmi")]
        public double Fmi { get; set; }

        [JsonProperty("yr")]
        public double Yr { get; set; }

        [JsonProperty("smhi")]
        public double Smhi { get; set; }

        [JsonProperty("sg")]
        public double Sg { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class GetTideStationsResponse
    {
        [JsonProperty("data")]
        public GetTideStationsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public StationMetaDataModel Meta { get; set; }
    }

    public class GetTideStationsResponseDataTypeItem
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class StationMetaDataModel
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("dailyQuota")]
        public int DailyQuota { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }
    }

    public class GetTideStationsAreaResponse
    {
        [JsonProperty("data")]
        public GetTideStationsAreaResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public StationMetaDataModel Meta { get; set; }
    }

    public class GetTideStationsAreaResponseDataTypeItem
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class AstronomyPointRequestResponse
    {
        [JsonProperty("data")]
        public AstronomyPointRequestResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public AstronomyPointRequestResponseMetaType Meta { get; set; }
    }

    public class AstronomyPointRequestResponseDataTypeItem
    {
        [JsonProperty("astronomicalDawn")]
        public string AstronomicalDawn { get; set; }

        [JsonProperty("astronomicalDusk")]
        public string AstronomicalDusk { get; set; }

        [JsonProperty("civilDawn")]
        public string CivilDawn { get; set; }

        [JsonProperty("civilDusk")]
        public string CivilDusk { get; set; }

        [JsonProperty("moonFraction")]
        public double MoonFraction { get; set; }

        [JsonProperty("moonPhase")]
        public AstronomyPointRequestResponseDataTypeItemMoonPhaseType MoonPhase { get; set; }

        [JsonProperty("moonrise")]
        public string Moonrise { get; set; }

        [JsonProperty("moonset")]
        public string Moonset { get; set; }

        [JsonProperty("nauticalDawn")]
        public string NauticalDawn { get; set; }

        [JsonProperty("nauticalDusk")]
        public string NauticalDusk { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class AstronomyPointRequestResponseDataTypeItemMoonPhaseType
    {
        [JsonProperty("closest")]
        public AstronomyPointRequestResponseDataTypeItemMoonPhaseTypeClosestType Closest { get; set; }

        [JsonProperty("current")]
        public AstronomyPointRequestResponseDataTypeItemMoonPhaseTypeCurrentType Current { get; set; }
    }

    public class AstronomyPointRequestResponseDataTypeItemMoonPhaseTypeClosestType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class AstronomyPointRequestResponseDataTypeItemMoonPhaseTypeCurrentType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class AstronomyPointRequestResponseMetaType
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("dailyQuota")]
        public int DailyQuota { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class SolarPointRequestResponse
    {
        public SolarPointRequestResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaDataModel Meta { get; set; }
    }

    public class SolarPointRequestResponseDataTypeItem
    {
        [JsonProperty("uvIndex")]
        public JToken UvIndex { get; set; }

        [JsonProperty("downwardShortWaveRadiationFlux")]
        public JToken DownwardShortWaveRadiationFlux { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class ElevationPointRequestResponse
    {
        [JsonProperty("data")]
        public ElevationPointRequestResponseDataType Data { get; set; }

        [JsonProperty("meta")]
        public ElevationPointRequestResponseMetaType Meta { get; set; }
    }

    public class ElevationPointRequestResponseDataType
    {
        [JsonProperty("elevation")]
        public double Elevation { get; set; }
    }

    public class ElevationPointRequestResponseMetaType
    {
        [JsonProperty("dailyQuota")]
        public int DailyQuota { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("elevation")]
        public ElevationPointRequestResponseMetaTypeElevationType Elevation { get; set; }
    }

    public class ElevationPointRequestResponseMetaTypeElevationType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Stormglassip;

    public partial class WorkflowManagedActions
    {
        public StormglassipActions Stormglassip(string connectionId) => new StormglassipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StormglassipTriggers Stormglassip(string connectionId) => new StormglassipTriggers(connectionId);
    }
}