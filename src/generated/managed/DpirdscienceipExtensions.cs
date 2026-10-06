//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdscienceip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdscienceipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStations))]
        public IBodyWorkflowAction<GetStationsResponse> GetStations([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<string> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsResponse> __BuildGetStations(WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<string> state = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<GetStationsResponse>(() =>
            {
                var apiCallPath = "/stations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<GetStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStation))]
        public IBodyWorkflowAction<GetStationResponse> GetStation([WorkflowExpression] Func<string> stationCode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationResponse> __BuildGetStation(WorkflowExpression<string> stationCode)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            return new DeferredBodyAction<GetStationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/station/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetNearbyWeatherStations))]
        public IBodyWorkflowAction<GetNearbyWeatherStationsResponse> GetNearbyWeatherStations([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<string> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetNearbyWeatherStationsResponse> __BuildGetNearbyWeatherStations(WorkflowExpression<double> latitude, WorkflowExpression<double> longitude, WorkflowExpression<int> radius = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<string> state = null)
        {
            WorkflowExpression.Validate(latitude, nameof(latitude), required: true);
            WorkflowExpression.Validate(longitude, nameof(longitude), required: true);
            WorkflowExpression.Validate(radius, nameof(radius), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<GetNearbyWeatherStationsResponse>(() =>
            {
                var apiCallPath = "/stations/nearby";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<GetNearbyWeatherStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationRainfall))]
        public IBodyWorkflowAction<GetStationRainfallResponse> GetStationRainfall([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> summerStartDate = null, [WorkflowExpression] Func<string> growingSeasonStartDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> forecastDate = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationRainfallResponse> __BuildGetStationRainfall(WorkflowExpression<string> stationCode, WorkflowExpression<string> summerStartDate = null, WorkflowExpression<string> growingSeasonStartDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> forecastDate = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(summerStartDate, nameof(summerStartDate), required: false);
            WorkflowExpression.Validate(growingSeasonStartDate, nameof(growingSeasonStartDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(forecastDate, nameof(forecastDate), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationRainfallResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/rainfall/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (summerStartDate != null)
                    callPayload.Queries["summerStartDate"] = ExpressionConverter.Convert(summerStartDate);
                if (growingSeasonStartDate != null)
                    callPayload.Queries["growingSeasonStartDate"] = ExpressionConverter.Convert(growingSeasonStartDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (forecastDate != null)
                    callPayload.Queries["forecastDate"] = ExpressionConverter.Convert(forecastDate);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationRainfallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetPotentialYield))]
        public IBodyWorkflowAction<GetPotentialYieldResponse> GetPotentialYield([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<string> summerStartDate = null, [WorkflowExpression] Func<string> growingSeasonStartDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> forecastDate = null, [WorkflowExpression] Func<int> waterUseEfficiency = null, [WorkflowExpression] Func<int> evaporation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPotentialYieldResponse> __BuildGetPotentialYield(WorkflowExpression<string> stationCode = null, WorkflowExpression<double> latitude = null, WorkflowExpression<double> longitude = null, WorkflowExpression<string> summerStartDate = null, WorkflowExpression<string> growingSeasonStartDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> forecastDate = null, WorkflowExpression<int> waterUseEfficiency = null, WorkflowExpression<int> evaporation = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(latitude, nameof(latitude), required: false);
            WorkflowExpression.Validate(longitude, nameof(longitude), required: false);
            WorkflowExpression.Validate(summerStartDate, nameof(summerStartDate), required: false);
            WorkflowExpression.Validate(growingSeasonStartDate, nameof(growingSeasonStartDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(forecastDate, nameof(forecastDate), required: false);
            WorkflowExpression.Validate(waterUseEfficiency, nameof(waterUseEfficiency), required: false);
            WorkflowExpression.Validate(evaporation, nameof(evaporation), required: false);
            return new DeferredBodyAction<GetPotentialYieldResponse>(() =>
            {
                var apiCallPath = "/potential-yield";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (summerStartDate != null)
                    callPayload.Queries["summerStartDate"] = ExpressionConverter.Convert(summerStartDate);
                if (growingSeasonStartDate != null)
                    callPayload.Queries["growingSeasonStartDate"] = ExpressionConverter.Convert(growingSeasonStartDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (forecastDate != null)
                    callPayload.Queries["forecastDate"] = ExpressionConverter.Convert(forecastDate);
                if (waterUseEfficiency != null)
                    callPayload.Queries["waterUseEfficiency"] = ExpressionConverter.Convert(waterUseEfficiency);
                if (evaporation != null)
                    callPayload.Queries["evaporation"] = ExpressionConverter.Convert(evaporation);
                return new ApiConnectionAction<GetPotentialYieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSoilWater))]
        public IBodyWorkflowAction<GetSoilWaterResponse> GetSoilWater([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<soilTypeInput> soilType, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<int> faoInitialisationDays = null, [WorkflowExpression] Func<double> faoInitialisationCropCoefficient = null, [WorkflowExpression] Func<int> faoDevelopmentDays = null, [WorkflowExpression] Func<double> faoDevelopmentCropCoefficient = null, [WorkflowExpression] Func<int> faoMidSeasonDays = null, [WorkflowExpression] Func<double> faoMidSeasonCropCoefficient = null, [WorkflowExpression] Func<int> faoLateSeasonDays = null, [WorkflowExpression] Func<double> faoLateSeasonCropCoefficient = null, [WorkflowExpression] Func<int> faoBreakOfSeason3Days25April = null, [WorkflowExpression] Func<int> faoBreakOfSeason3Days5June = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSoilWaterResponse> __BuildGetSoilWater(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<soilTypeInput> soilType, WorkflowExpression<string> stationCode = null, WorkflowExpression<double> latitude = null, WorkflowExpression<double> longitude = null, WorkflowExpression<int> faoInitialisationDays = null, WorkflowExpression<double> faoInitialisationCropCoefficient = null, WorkflowExpression<int> faoDevelopmentDays = null, WorkflowExpression<double> faoDevelopmentCropCoefficient = null, WorkflowExpression<int> faoMidSeasonDays = null, WorkflowExpression<double> faoMidSeasonCropCoefficient = null, WorkflowExpression<int> faoLateSeasonDays = null, WorkflowExpression<double> faoLateSeasonCropCoefficient = null, WorkflowExpression<int> faoBreakOfSeason3Days25April = null, WorkflowExpression<int> faoBreakOfSeason3Days5June = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(soilType, nameof(soilType), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(latitude, nameof(latitude), required: false);
            WorkflowExpression.Validate(longitude, nameof(longitude), required: false);
            WorkflowExpression.Validate(faoInitialisationDays, nameof(faoInitialisationDays), required: false);
            WorkflowExpression.Validate(faoInitialisationCropCoefficient, nameof(faoInitialisationCropCoefficient), required: false);
            WorkflowExpression.Validate(faoDevelopmentDays, nameof(faoDevelopmentDays), required: false);
            WorkflowExpression.Validate(faoDevelopmentCropCoefficient, nameof(faoDevelopmentCropCoefficient), required: false);
            WorkflowExpression.Validate(faoMidSeasonDays, nameof(faoMidSeasonDays), required: false);
            WorkflowExpression.Validate(faoMidSeasonCropCoefficient, nameof(faoMidSeasonCropCoefficient), required: false);
            WorkflowExpression.Validate(faoLateSeasonDays, nameof(faoLateSeasonDays), required: false);
            WorkflowExpression.Validate(faoLateSeasonCropCoefficient, nameof(faoLateSeasonCropCoefficient), required: false);
            WorkflowExpression.Validate(faoBreakOfSeason3Days25April, nameof(faoBreakOfSeason3Days25April), required: false);
            WorkflowExpression.Validate(faoBreakOfSeason3Days5June, nameof(faoBreakOfSeason3Days5June), required: false);
            return new DeferredBodyAction<GetSoilWaterResponse>(() =>
            {
                var apiCallPath = "/soilwater";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                callPayload.Queries["soilType"] = ExpressionConverter.Convert(soilType);
                if (faoInitialisationDays != null)
                    callPayload.Queries["faoInitialisationDays"] = ExpressionConverter.Convert(faoInitialisationDays);
                if (faoInitialisationCropCoefficient != null)
                    callPayload.Queries["faoInitialisationCropCoefficient"] = ExpressionConverter.Convert(faoInitialisationCropCoefficient);
                if (faoDevelopmentDays != null)
                    callPayload.Queries["faoDevelopmentDays"] = ExpressionConverter.Convert(faoDevelopmentDays);
                if (faoDevelopmentCropCoefficient != null)
                    callPayload.Queries["faoDevelopmentCropCoefficient"] = ExpressionConverter.Convert(faoDevelopmentCropCoefficient);
                if (faoMidSeasonDays != null)
                    callPayload.Queries["faoMidSeasonDays"] = ExpressionConverter.Convert(faoMidSeasonDays);
                if (faoMidSeasonCropCoefficient != null)
                    callPayload.Queries["faoMidSeasonCropCoefficient"] = ExpressionConverter.Convert(faoMidSeasonCropCoefficient);
                if (faoLateSeasonDays != null)
                    callPayload.Queries["faoLateSeasonDays"] = ExpressionConverter.Convert(faoLateSeasonDays);
                if (faoLateSeasonCropCoefficient != null)
                    callPayload.Queries["faoLateSeasonCropCoefficient"] = ExpressionConverter.Convert(faoLateSeasonCropCoefficient);
                if (faoBreakOfSeason3Days25April != null)
                    callPayload.Queries["faoBreakOfSeason3Days25April"] = ExpressionConverter.Convert(faoBreakOfSeason3Days25April);
                if (faoBreakOfSeason3Days5June != null)
                    callPayload.Queries["faoBreakOfSeason3Days5June"] = ExpressionConverter.Convert(faoBreakOfSeason3Days5June);
                return new ApiConnectionAction<GetSoilWaterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [WorkflowExpressionFactory(nameof(__BuildGetYellowSpot))]
        public IBodyWorkflowAction<GetYellowSpotResponse> GetYellowSpot([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetYellowSpotResponse> __BuildGetYellowSpot(WorkflowExpression<string> stationCode = null, WorkflowExpression<string> date = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetYellowSpotResponse>(() =>
            {
                var apiCallPath = "/yellowspot";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
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