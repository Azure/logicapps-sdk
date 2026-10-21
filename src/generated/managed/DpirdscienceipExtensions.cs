//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdscienceip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdscienceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationsResponse> GetStations(Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null, Expression<Func<string>> state = null)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationResponse> GetStation(Expression<Func<string>> stationCode)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            return new DeferredBodyAction<GetStationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/station/{0}", __workflow_stationCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetNearbyWeatherStationsResponse> GetNearbyWeatherStations(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<int>> radius = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null, Expression<Func<string>> state = null)
        {
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: true);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: true);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationRainfallResponse> GetStationRainfall(Expression<Func<string>> stationCode, Expression<Func<string>> summerStartDate = null, Expression<Func<string>> growingSeasonStartDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> forecastDate = null, Expression<Func<string>> select = null)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            var __workflow_summerStartDate = WorkflowExpression.Compile(summerStartDate, nameof(summerStartDate), required: false);
            var __workflow_growingSeasonStartDate = WorkflowExpression.Compile(growingSeasonStartDate, nameof(growingSeasonStartDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_forecastDate = WorkflowExpression.Compile(forecastDate, nameof(forecastDate), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationRainfallResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/rainfall/{0}", __workflow_stationCode.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetPotentialYieldResponse> GetPotentialYield(Expression<Func<string>> stationCode = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<string>> summerStartDate = null, Expression<Func<string>> growingSeasonStartDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> forecastDate = null, Expression<Func<int>> waterUseEfficiency = null, Expression<Func<int>> evaporation = null)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_summerStartDate = WorkflowExpression.Compile(summerStartDate, nameof(summerStartDate), required: false);
            var __workflow_growingSeasonStartDate = WorkflowExpression.Compile(growingSeasonStartDate, nameof(growingSeasonStartDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_forecastDate = WorkflowExpression.Compile(forecastDate, nameof(forecastDate), required: false);
            var __workflow_waterUseEfficiency = WorkflowExpression.Compile(waterUseEfficiency, nameof(waterUseEfficiency), required: false);
            var __workflow_evaporation = WorkflowExpression.Compile(evaporation, nameof(evaporation), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetSoilWaterResponse> GetSoilWater(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<soilTypeInput>> soilType, Expression<Func<string>> stationCode = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<int>> faoInitialisationDays = null, Expression<Func<double>> faoInitialisationCropCoefficient = null, Expression<Func<int>> faoDevelopmentDays = null, Expression<Func<double>> faoDevelopmentCropCoefficient = null, Expression<Func<int>> faoMidSeasonDays = null, Expression<Func<double>> faoMidSeasonCropCoefficient = null, Expression<Func<int>> faoLateSeasonDays = null, Expression<Func<double>> faoLateSeasonCropCoefficient = null, Expression<Func<int>> faoBreakOfSeason3Days25April = null, Expression<Func<int>> faoBreakOfSeason3Days5June = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_soilType = WorkflowExpression.Compile(soilType, nameof(soilType), required: true);
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_faoInitialisationDays = WorkflowExpression.Compile(faoInitialisationDays, nameof(faoInitialisationDays), required: false);
            var __workflow_faoInitialisationCropCoefficient = WorkflowExpression.Compile(faoInitialisationCropCoefficient, nameof(faoInitialisationCropCoefficient), required: false);
            var __workflow_faoDevelopmentDays = WorkflowExpression.Compile(faoDevelopmentDays, nameof(faoDevelopmentDays), required: false);
            var __workflow_faoDevelopmentCropCoefficient = WorkflowExpression.Compile(faoDevelopmentCropCoefficient, nameof(faoDevelopmentCropCoefficient), required: false);
            var __workflow_faoMidSeasonDays = WorkflowExpression.Compile(faoMidSeasonDays, nameof(faoMidSeasonDays), required: false);
            var __workflow_faoMidSeasonCropCoefficient = WorkflowExpression.Compile(faoMidSeasonCropCoefficient, nameof(faoMidSeasonCropCoefficient), required: false);
            var __workflow_faoLateSeasonDays = WorkflowExpression.Compile(faoLateSeasonDays, nameof(faoLateSeasonDays), required: false);
            var __workflow_faoLateSeasonCropCoefficient = WorkflowExpression.Compile(faoLateSeasonCropCoefficient, nameof(faoLateSeasonCropCoefficient), required: false);
            var __workflow_faoBreakOfSeason3Days25April = WorkflowExpression.Compile(faoBreakOfSeason3Days25April, nameof(faoBreakOfSeason3Days25April), required: false);
            var __workflow_faoBreakOfSeason3Days5June = WorkflowExpression.Compile(faoBreakOfSeason3Days5June, nameof(faoBreakOfSeason3Days5June), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetYellowSpotResponse> GetYellowSpot(Expression<Func<string>> stationCode = null, Expression<Func<string>> date = null, Expression<Func<string>> select = null)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
