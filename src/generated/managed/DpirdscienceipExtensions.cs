//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdscienceip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdscienceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationsResponse> GetStations([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<string> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (group != null)
                    callPayload.Queries["group"] = SourceExpressionConverter.Convert(group);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationResponse> GetStation([WorkflowExpression] Func<string> stationCode)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/station/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetNearbyWeatherStationsResponse> GetNearbyWeatherStations([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<string> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stations/nearby";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (group != null)
                    callPayload.Queries["group"] = SourceExpressionConverter.Convert(group);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                return callPayload;
            }

            return new ApiConnectionAction<GetNearbyWeatherStationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetStationRainfallResponse> GetStationRainfall([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> summerStartDate = null, [WorkflowExpression] Func<string> growingSeasonStartDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> forecastDate = null, [WorkflowExpression] Func<string> select = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/rainfall/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (summerStartDate != null)
                    callPayload.Queries["summerStartDate"] = SourceExpressionConverter.ConvertO(summerStartDate);
                if (growingSeasonStartDate != null)
                    callPayload.Queries["growingSeasonStartDate"] = SourceExpressionConverter.ConvertO(growingSeasonStartDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (forecastDate != null)
                    callPayload.Queries["forecastDate"] = SourceExpressionConverter.ConvertO(forecastDate);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationRainfallResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetPotentialYieldResponse> GetPotentialYield([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<string> summerStartDate = null, [WorkflowExpression] Func<string> growingSeasonStartDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> forecastDate = null, [WorkflowExpression] Func<int> waterUseEfficiency = null, [WorkflowExpression] Func<int> evaporation = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/potential-yield";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (summerStartDate != null)
                    callPayload.Queries["summerStartDate"] = SourceExpressionConverter.ConvertO(summerStartDate);
                if (growingSeasonStartDate != null)
                    callPayload.Queries["growingSeasonStartDate"] = SourceExpressionConverter.ConvertO(growingSeasonStartDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (forecastDate != null)
                    callPayload.Queries["forecastDate"] = SourceExpressionConverter.ConvertO(forecastDate);
                if (waterUseEfficiency != null)
                    callPayload.Queries["waterUseEfficiency"] = SourceExpressionConverter.ConvertO(waterUseEfficiency);
                if (evaporation != null)
                    callPayload.Queries["evaporation"] = SourceExpressionConverter.ConvertO(evaporation);
                return callPayload;
            }

            return new ApiConnectionAction<GetPotentialYieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetSoilWaterResponse> GetSoilWater([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<soilTypeInput> soilType, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<int> faoInitialisationDays = null, [WorkflowExpression] Func<double> faoInitialisationCropCoefficient = null, [WorkflowExpression] Func<int> faoDevelopmentDays = null, [WorkflowExpression] Func<double> faoDevelopmentCropCoefficient = null, [WorkflowExpression] Func<int> faoMidSeasonDays = null, [WorkflowExpression] Func<double> faoMidSeasonCropCoefficient = null, [WorkflowExpression] Func<int> faoLateSeasonDays = null, [WorkflowExpression] Func<double> faoLateSeasonCropCoefficient = null, [WorkflowExpression] Func<int> faoBreakOfSeason3Days25April = null, [WorkflowExpression] Func<int> faoBreakOfSeason3Days5June = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/soilwater";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["soilType"] = SourceExpressionConverter.Convert(soilType);
                if (faoInitialisationDays != null)
                    callPayload.Queries["faoInitialisationDays"] = SourceExpressionConverter.ConvertO(faoInitialisationDays);
                if (faoInitialisationCropCoefficient != null)
                    callPayload.Queries["faoInitialisationCropCoefficient"] = SourceExpressionConverter.ConvertO(faoInitialisationCropCoefficient);
                if (faoDevelopmentDays != null)
                    callPayload.Queries["faoDevelopmentDays"] = SourceExpressionConverter.ConvertO(faoDevelopmentDays);
                if (faoDevelopmentCropCoefficient != null)
                    callPayload.Queries["faoDevelopmentCropCoefficient"] = SourceExpressionConverter.ConvertO(faoDevelopmentCropCoefficient);
                if (faoMidSeasonDays != null)
                    callPayload.Queries["faoMidSeasonDays"] = SourceExpressionConverter.ConvertO(faoMidSeasonDays);
                if (faoMidSeasonCropCoefficient != null)
                    callPayload.Queries["faoMidSeasonCropCoefficient"] = SourceExpressionConverter.ConvertO(faoMidSeasonCropCoefficient);
                if (faoLateSeasonDays != null)
                    callPayload.Queries["faoLateSeasonDays"] = SourceExpressionConverter.ConvertO(faoLateSeasonDays);
                if (faoLateSeasonCropCoefficient != null)
                    callPayload.Queries["faoLateSeasonCropCoefficient"] = SourceExpressionConverter.ConvertO(faoLateSeasonCropCoefficient);
                if (faoBreakOfSeason3Days25April != null)
                    callPayload.Queries["faoBreakOfSeason3Days25April"] = SourceExpressionConverter.ConvertO(faoBreakOfSeason3Days25April);
                if (faoBreakOfSeason3Days5June != null)
                    callPayload.Queries["faoBreakOfSeason3Days5June"] = SourceExpressionConverter.ConvertO(faoBreakOfSeason3Days5June);
                return callPayload;
            }

            return new ApiConnectionAction<GetSoilWaterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdscienceip")]
        public IBodyWorkflowAction<GetYellowSpotResponse> GetYellowSpot([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> select = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/yellowspot";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<GetYellowSpotResponse>(BuildSourceInput);
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