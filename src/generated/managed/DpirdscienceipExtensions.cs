//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdscienceip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DpirdscienceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationsResponse> GetStations(Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null, Expression<Func<string>> state = null)
        {
            var __workflow_stationCode = stationCode == null ? null : WorkflowExpression.Compile(stationCode);
            WorkflowExpression.Validate(__workflow_stationCode, nameof(stationCode), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_group = group == null ? null : WorkflowExpression.Compile(group);
            WorkflowExpression.Validate(__workflow_group, nameof(group), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<GetStationsResponse>(() =>
            {
                var apiCallPath = "/stations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(__workflow_stationCode);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<GetStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationResponse> GetStation(Expression<Func<string>> stationCode)
        {
            var __workflow_stationCode = stationCode == null ? null : WorkflowExpression.Compile(stationCode);
            WorkflowExpression.Validate(__workflow_stationCode, nameof(stationCode), required: true);
            return new DeferredBodyAction<GetStationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/station/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetNearbyWeatherStationsResponse> GetNearbyWeatherStations(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<int>> radius = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null, Expression<Func<string>> state = null)
        {
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: true);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: true);
            var __workflow_radius = radius == null ? null : WorkflowExpression.Compile(radius);
            WorkflowExpression.Validate(__workflow_radius, nameof(radius), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_group = group == null ? null : WorkflowExpression.Compile(group);
            WorkflowExpression.Validate(__workflow_group, nameof(group), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<GetNearbyWeatherStationsResponse>(() =>
            {
                var apiCallPath = "/stations/nearby";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<GetNearbyWeatherStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationRainfallResponse> GetStationRainfall(Expression<Func<string>> stationCode, Expression<Func<string>> summerStartDate = null, Expression<Func<string>> growingSeasonStartDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> forecastDate = null, Expression<Func<string>> select = null)
        {
            var __workflow_stationCode = stationCode == null ? null : WorkflowExpression.Compile(stationCode);
            WorkflowExpression.Validate(__workflow_stationCode, nameof(stationCode), required: true);
            var __workflow_summerStartDate = summerStartDate == null ? null : WorkflowExpression.Compile(summerStartDate);
            WorkflowExpression.Validate(__workflow_summerStartDate, nameof(summerStartDate), required: false);
            var __workflow_growingSeasonStartDate = growingSeasonStartDate == null ? null : WorkflowExpression.Compile(growingSeasonStartDate);
            WorkflowExpression.Validate(__workflow_growingSeasonStartDate, nameof(growingSeasonStartDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
            var __workflow_forecastDate = forecastDate == null ? null : WorkflowExpression.Compile(forecastDate);
            WorkflowExpression.Validate(__workflow_forecastDate, nameof(forecastDate), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationRainfallResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/rainfall/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_summerStartDate != null)
                    callPayload.Queries["summerStartDate"] = ExpressionConverter.Convert(__workflow_summerStartDate);
                if (__workflow_growingSeasonStartDate != null)
                    callPayload.Queries["growingSeasonStartDate"] = ExpressionConverter.Convert(__workflow_growingSeasonStartDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_forecastDate != null)
                    callPayload.Queries["forecastDate"] = ExpressionConverter.Convert(__workflow_forecastDate);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GetStationRainfallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetPotentialYieldResponse> GetPotentialYield(Expression<Func<string>> stationCode = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<string>> summerStartDate = null, Expression<Func<string>> growingSeasonStartDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> forecastDate = null, Expression<Func<int>> waterUseEfficiency = null, Expression<Func<int>> evaporation = null)
        {
            var __workflow_stationCode = stationCode == null ? null : WorkflowExpression.Compile(stationCode);
            WorkflowExpression.Validate(__workflow_stationCode, nameof(stationCode), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_summerStartDate = summerStartDate == null ? null : WorkflowExpression.Compile(summerStartDate);
            WorkflowExpression.Validate(__workflow_summerStartDate, nameof(summerStartDate), required: false);
            var __workflow_growingSeasonStartDate = growingSeasonStartDate == null ? null : WorkflowExpression.Compile(growingSeasonStartDate);
            WorkflowExpression.Validate(__workflow_growingSeasonStartDate, nameof(growingSeasonStartDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
            var __workflow_forecastDate = forecastDate == null ? null : WorkflowExpression.Compile(forecastDate);
            WorkflowExpression.Validate(__workflow_forecastDate, nameof(forecastDate), required: false);
            var __workflow_waterUseEfficiency = waterUseEfficiency == null ? null : WorkflowExpression.Compile(waterUseEfficiency);
            WorkflowExpression.Validate(__workflow_waterUseEfficiency, nameof(waterUseEfficiency), required: false);
            var __workflow_evaporation = evaporation == null ? null : WorkflowExpression.Compile(evaporation);
            WorkflowExpression.Validate(__workflow_evaporation, nameof(evaporation), required: false);
            return new DeferredBodyAction<GetPotentialYieldResponse>(() =>
            {
                var apiCallPath = "/potential-yield";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(__workflow_stationCode);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_summerStartDate != null)
                    callPayload.Queries["summerStartDate"] = ExpressionConverter.Convert(__workflow_summerStartDate);
                if (__workflow_growingSeasonStartDate != null)
                    callPayload.Queries["growingSeasonStartDate"] = ExpressionConverter.Convert(__workflow_growingSeasonStartDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_forecastDate != null)
                    callPayload.Queries["forecastDate"] = ExpressionConverter.Convert(__workflow_forecastDate);
                if (__workflow_waterUseEfficiency != null)
                    callPayload.Queries["waterUseEfficiency"] = ExpressionConverter.Convert(__workflow_waterUseEfficiency);
                if (__workflow_evaporation != null)
                    callPayload.Queries["evaporation"] = ExpressionConverter.Convert(__workflow_evaporation);
                return new ApiConnectionAction<GetPotentialYieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetSoilWaterResponse> GetSoilWater(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<soilTypeInput>> soilType, Expression<Func<string>> stationCode = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<int>> faoInitialisationDays = null, Expression<Func<double>> faoInitialisationCropCoefficient = null, Expression<Func<int>> faoDevelopmentDays = null, Expression<Func<double>> faoDevelopmentCropCoefficient = null, Expression<Func<int>> faoMidSeasonDays = null, Expression<Func<double>> faoMidSeasonCropCoefficient = null, Expression<Func<int>> faoLateSeasonDays = null, Expression<Func<double>> faoLateSeasonCropCoefficient = null, Expression<Func<int>> faoBreakOfSeason3Days25April = null, Expression<Func<int>> faoBreakOfSeason3Days5June = null)
        {
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: true);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: true);
            var __workflow_soilType = soilType == null ? null : WorkflowExpression.Compile(soilType);
            WorkflowExpression.Validate(__workflow_soilType, nameof(soilType), required: true);
            var __workflow_stationCode = stationCode == null ? null : WorkflowExpression.Compile(stationCode);
            WorkflowExpression.Validate(__workflow_stationCode, nameof(stationCode), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_faoInitialisationDays = faoInitialisationDays == null ? null : WorkflowExpression.Compile(faoInitialisationDays);
            WorkflowExpression.Validate(__workflow_faoInitialisationDays, nameof(faoInitialisationDays), required: false);
            var __workflow_faoInitialisationCropCoefficient = faoInitialisationCropCoefficient == null ? null : WorkflowExpression.Compile(faoInitialisationCropCoefficient);
            WorkflowExpression.Validate(__workflow_faoInitialisationCropCoefficient, nameof(faoInitialisationCropCoefficient), required: false);
            var __workflow_faoDevelopmentDays = faoDevelopmentDays == null ? null : WorkflowExpression.Compile(faoDevelopmentDays);
            WorkflowExpression.Validate(__workflow_faoDevelopmentDays, nameof(faoDevelopmentDays), required: false);
            var __workflow_faoDevelopmentCropCoefficient = faoDevelopmentCropCoefficient == null ? null : WorkflowExpression.Compile(faoDevelopmentCropCoefficient);
            WorkflowExpression.Validate(__workflow_faoDevelopmentCropCoefficient, nameof(faoDevelopmentCropCoefficient), required: false);
            var __workflow_faoMidSeasonDays = faoMidSeasonDays == null ? null : WorkflowExpression.Compile(faoMidSeasonDays);
            WorkflowExpression.Validate(__workflow_faoMidSeasonDays, nameof(faoMidSeasonDays), required: false);
            var __workflow_faoMidSeasonCropCoefficient = faoMidSeasonCropCoefficient == null ? null : WorkflowExpression.Compile(faoMidSeasonCropCoefficient);
            WorkflowExpression.Validate(__workflow_faoMidSeasonCropCoefficient, nameof(faoMidSeasonCropCoefficient), required: false);
            var __workflow_faoLateSeasonDays = faoLateSeasonDays == null ? null : WorkflowExpression.Compile(faoLateSeasonDays);
            WorkflowExpression.Validate(__workflow_faoLateSeasonDays, nameof(faoLateSeasonDays), required: false);
            var __workflow_faoLateSeasonCropCoefficient = faoLateSeasonCropCoefficient == null ? null : WorkflowExpression.Compile(faoLateSeasonCropCoefficient);
            WorkflowExpression.Validate(__workflow_faoLateSeasonCropCoefficient, nameof(faoLateSeasonCropCoefficient), required: false);
            var __workflow_faoBreakOfSeason3Days25April = faoBreakOfSeason3Days25April == null ? null : WorkflowExpression.Compile(faoBreakOfSeason3Days25April);
            WorkflowExpression.Validate(__workflow_faoBreakOfSeason3Days25April, nameof(faoBreakOfSeason3Days25April), required: false);
            var __workflow_faoBreakOfSeason3Days5June = faoBreakOfSeason3Days5June == null ? null : WorkflowExpression.Compile(faoBreakOfSeason3Days5June);
            WorkflowExpression.Validate(__workflow_faoBreakOfSeason3Days5June, nameof(faoBreakOfSeason3Days5June), required: false);
            return new DeferredBodyAction<GetSoilWaterResponse>(() =>
            {
                var apiCallPath = "/soilwater";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(__workflow_stationCode);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["soilType"] = ExpressionConverter.Convert(__workflow_soilType);
                if (__workflow_faoInitialisationDays != null)
                    callPayload.Queries["faoInitialisationDays"] = ExpressionConverter.Convert(__workflow_faoInitialisationDays);
                if (__workflow_faoInitialisationCropCoefficient != null)
                    callPayload.Queries["faoInitialisationCropCoefficient"] = ExpressionConverter.Convert(__workflow_faoInitialisationCropCoefficient);
                if (__workflow_faoDevelopmentDays != null)
                    callPayload.Queries["faoDevelopmentDays"] = ExpressionConverter.Convert(__workflow_faoDevelopmentDays);
                if (__workflow_faoDevelopmentCropCoefficient != null)
                    callPayload.Queries["faoDevelopmentCropCoefficient"] = ExpressionConverter.Convert(__workflow_faoDevelopmentCropCoefficient);
                if (__workflow_faoMidSeasonDays != null)
                    callPayload.Queries["faoMidSeasonDays"] = ExpressionConverter.Convert(__workflow_faoMidSeasonDays);
                if (__workflow_faoMidSeasonCropCoefficient != null)
                    callPayload.Queries["faoMidSeasonCropCoefficient"] = ExpressionConverter.Convert(__workflow_faoMidSeasonCropCoefficient);
                if (__workflow_faoLateSeasonDays != null)
                    callPayload.Queries["faoLateSeasonDays"] = ExpressionConverter.Convert(__workflow_faoLateSeasonDays);
                if (__workflow_faoLateSeasonCropCoefficient != null)
                    callPayload.Queries["faoLateSeasonCropCoefficient"] = ExpressionConverter.Convert(__workflow_faoLateSeasonCropCoefficient);
                if (__workflow_faoBreakOfSeason3Days25April != null)
                    callPayload.Queries["faoBreakOfSeason3Days25April"] = ExpressionConverter.Convert(__workflow_faoBreakOfSeason3Days25April);
                if (__workflow_faoBreakOfSeason3Days5June != null)
                    callPayload.Queries["faoBreakOfSeason3Days5June"] = ExpressionConverter.Convert(__workflow_faoBreakOfSeason3Days5June);
                return new ApiConnectionAction<GetSoilWaterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetYellowSpotResponse> GetYellowSpot(Expression<Func<string>> stationCode = null, Expression<Func<string>> date = null, Expression<Func<string>> select = null)
        {
            var __workflow_stationCode = stationCode == null ? null : WorkflowExpression.Compile(stationCode);
            WorkflowExpression.Validate(__workflow_stationCode, nameof(stationCode), required: false);
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            return new DeferredBodyAction<GetYellowSpotResponse>(() =>
            {
                var apiCallPath = "/yellowspot";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(__workflow_stationCode);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<GetYellowSpotResponse>(callPayload);
            });
        }
    }

    public class DpirdscienceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetStationsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationModel[] Collection { get; set; }
    }

    public class ApiMetaDataModel
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }

        [JsonProperty("collection")]
        public PaginationModel Collection { get; set; }
    }

    public class LinksModelItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }
    }

    public class PaginationModel
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }
    }

    public class StationModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("startYear")]
        public double StartYear { get; set; }

        [JsonProperty("endYear")]
        public bool EndYear { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum groupInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "api")]
        Api,
        [EnumMember(Value = "web")]
        Web,
        [EnumMember(Value = "rtd")]
        Rtd
    }

    public class GetStationResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public StationModel Data { get; set; }
    }

    public class GetNearbyWeatherStationsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationModel[] Collection { get; set; }
    }

    public class GetStationRainfallResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public StationRainfallModel Data { get; set; }
    }

    public class StationRainfallModel
    {
        [JsonProperty("forecastDate")]
        public string ForecastDate { get; set; }

        [JsonProperty("summary")]
        public StationRainfallModelSummaryType Summary { get; set; }
    }

    public class StationRainfallModelSummaryType
    {
        [JsonProperty("summer")]
        public StationRainfallModelSummaryTypeSummerType Summer { get; set; }

        [JsonProperty("season")]
        public StationRainfallModelSummaryTypeSeasonType Season { get; set; }

        [JsonProperty("currentSeasonalRainfall")]
        public StationRainfallModelSummaryTypeCurrentSeasonalRainfallTypeItem[] CurrentSeasonalRainfall { get; set; }

        [JsonProperty("projectedSeasonalRainfall")]
        public StationRainfallModelSummaryTypeProjectedSeasonalRainfallTypeItem[] ProjectedSeasonalRainfall { get; set; }

        [JsonProperty("historicalRainfall")]
        public StationRainfallModelSummaryTypeHistoricalRainfallTypeItem[] HistoricalRainfall { get; set; }
    }

    public class StationRainfallModelSummaryTypeSummerType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("cumulativeRainfall")]
        public double CumulativeRainfall { get; set; }

        [JsonProperty("decile")]
        public int Decile { get; set; }
    }

    public class StationRainfallModelSummaryTypeSeasonType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("cumulativeRainfall")]
        public double CumulativeRainfall { get; set; }

        [JsonProperty("decile")]
        public int Decile { get; set; }
    }

    public class StationRainfallModelSummaryTypeCurrentSeasonalRainfallTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }

        [JsonProperty("cumulativeRainfall")]
        public double CumulativeRainfall { get; set; }
    }

    public class StationRainfallModelSummaryTypeProjectedSeasonalRainfallTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("deciles")]
        public StationRainfallModelSummaryTypeProjectedSeasonalRainfallTypeItemDecilesTypeItem[] Deciles { get; set; }
    }

    public class StationRainfallModelSummaryTypeProjectedSeasonalRainfallTypeItemDecilesTypeItem
    {
        [JsonProperty("decile")]
        public int Decile { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }
    }

    public class StationRainfallModelSummaryTypeHistoricalRainfallTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("deciles")]
        public StationRainfallModelSummaryTypeHistoricalRainfallTypeItemDecilesTypeItem[] Deciles { get; set; }
    }

    public class StationRainfallModelSummaryTypeHistoricalRainfallTypeItemDecilesTypeItem
    {
        [JsonProperty("decile")]
        public int Decile { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }
    }

    public class GetPotentialYieldResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public PotentialYieldModel Data { get; set; }
    }

    public class PotentialYieldModel
    {
        [JsonProperty("summary")]
        public PotentialYieldModelSummaryType Summary { get; set; }

        [JsonProperty("potentialYield")]
        public PotentialYieldModelPotentialYieldTypeItem[] PotentialYield { get; set; }
    }

    public class PotentialYieldModelSummaryType
    {
        [JsonProperty("forecastDate")]
        public string ForecastDate { get; set; }

        [JsonProperty("inGrowingSeason")]
        public bool InGrowingSeason { get; set; }

        [JsonProperty("summer")]
        public PotentialYieldModelSummaryTypeSummerType Summer { get; set; }

        [JsonProperty("growingSeason")]
        public PotentialYieldModelSummaryTypeGrowingSeasonType GrowingSeason { get; set; }
    }

    public class PotentialYieldModelSummaryTypeSummerType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("cumulativeRainfall")]
        public double CumulativeRainfall { get; set; }

        [JsonProperty("decile")]
        public int Decile { get; set; }
    }

    public class PotentialYieldModelSummaryTypeGrowingSeasonType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("cumulativeRainfall")]
        public double CumulativeRainfall { get; set; }

        [JsonProperty("decile")]
        public int Decile { get; set; }
    }

    public class PotentialYieldModelPotentialYieldTypeItem
    {
        [JsonProperty("decile")]
        public int Decile { get; set; }

        [JsonProperty("projectedRainfall")]
        public double ProjectedRainfall { get; set; }

        [JsonProperty("potentialYield")]
        public JToken PotentialYield { get; set; }
    }

    public class GetSoilWaterResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public SoilWaterModel Data { get; set; }
    }

    public class SoilWaterModel
    {
        [JsonProperty("soilWater")]
        public SoilWaterModelSoilWaterTypeItem[] SoilWater { get; set; }

        [JsonProperty("breakOfSeason")]
        public string BreakOfSeason { get; set; }
    }

    public class SoilWaterModelSoilWaterTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }

        [JsonProperty("fallow")]
        public double Fallow { get; set; }

        [JsonProperty("crop")]
        public double Crop { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum soilTypeInput
    {
        [EnumMember(Value = "gravel")]
        Gravel,
        [EnumMember(Value = "shallow-soil")]
        ShallowSoil,
        [EnumMember(Value = "sand")]
        Sand,
        [EnumMember(Value = "sandy-earth")]
        SandyEarth,
        [EnumMember(Value = "shallow-sandy-duplex")]
        ShallowSandyDuplex,
        [EnumMember(Value = "deep-sandy-duplex")]
        DeepSandyDuplex,
        [EnumMember(Value = "shallow-loamy-duplex")]
        ShallowLoamyDuplex,
        [EnumMember(Value = "deep-loamy-duplex")]
        DeepLoamyDuplex,
        [EnumMember(Value = "loamy-earth")]
        LoamyEarth,
        [EnumMember(Value = "clay")]
        Clay
    }

    public class GetYellowSpotResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public GetYellowSpotResponseDataType Data { get; set; }
    }

    public class GetYellowSpotResponseDataType
    {
        [JsonProperty("moin")]
        public GetYellowSpotResponseDataTypeMoinType Moin { get; set; }

        [JsonProperty("chris")]
        public GetYellowSpotResponseDataTypeChrisType Chris { get; set; }
    }

    public class GetYellowSpotResponseDataTypeMoinType
    {
        [JsonProperty("maturation")]
        public MaturationModel Maturation { get; set; }

        [JsonProperty("model")]
        public YellowSpotModelItem[] Model { get; set; }
    }

    public class MaturationModel
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }
    }

    public class YellowSpotModelItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("temperature")]
        public YellowSpotModelItemTemperatureType Temperature { get; set; }

        [JsonProperty("rainfall")]
        public YellowSpotModelItemRainfallType Rainfall { get; set; }

        [JsonProperty("suitable")]
        public JToken Suitable { get; set; }

        [JsonProperty("maturationProgress")]
        public JToken MaturationProgress { get; set; }
    }

    public class YellowSpotModelItemTemperatureType
    {
        [JsonProperty("minimum")]
        public double Minimum { get; set; }

        [JsonProperty("maximum")]
        public double Maximum { get; set; }

        [JsonProperty("average")]
        public double Average { get; set; }

        [JsonProperty("movingAverage")]
        public double MovingAverage { get; set; }
    }

    public class YellowSpotModelItemRainfallType
    {
        [JsonProperty("rain")]
        public double Rain { get; set; }

        [JsonProperty("movingSum")]
        public double MovingSum { get; set; }
    }

    public class GetYellowSpotResponseDataTypeChrisType
    {
        [JsonProperty("maturation")]
        public MaturationModel Maturation { get; set; }

        [JsonProperty("model")]
        public YellowSpotModelItem[] Model { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdscienceip;

    public partial class WorkflowManagedActions
    {
        public DpirdscienceipActions Dpirdscienceip(string connectionId) => new DpirdscienceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DpirdscienceipTriggers Dpirdscienceip(string connectionId) => new DpirdscienceipTriggers(connectionId);
    }
}
