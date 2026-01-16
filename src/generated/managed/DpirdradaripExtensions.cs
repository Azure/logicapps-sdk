//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdradarip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdradaripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        public IBodyWorkflowAction<GetRadarsResponse> GetRadars(Expression<Func<string>> radarCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/radars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (radarCode != null)
                callPayload.Queries["radarCode"] = ExpressionConverter.Convert(radarCode);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Queries["select"] = Convert.ToString("code,location,state,bounds,online,offline_reason");
            if (select != null)
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetRadarsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        public IBodyWorkflowAction<GetRadarResponse> GetRadar(Expression<Func<string>> radarCode, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/radars/{0}", ExpressionConverter.ConvertWithUrlEncoding(radarCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["select"] = Convert.ToString("code,location,state,bounds,online,offline_reason");
            if (select != null)
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetRadarResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        public IBodyWorkflowAction<GetNearbyRadarResponse> GetNearbyRadar(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<dataSetInput>> dataSet = null)
        {
            var apiCallPath = "/nearby";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            callPayload.Queries["dataSet"] = Convert.ToString("ALL");
            if (dataSet != null)
                callPayload.Queries["dataSet"] = ExpressionConverter.Convert(dataSet);
            return new ApiConnectionAction<GetNearbyRadarResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        public IBodyWorkflowAction<GetRadarRainfallResponse> GetRadarRainfall(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<string>> radarCode = null, Expression<Func<dataSetInput>> dataSet = null, Expression<Func<string>> select = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/rainfall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (radarCode != null)
                callPayload.Queries["radarCode"] = ExpressionConverter.Convert(radarCode);
            callPayload.Queries["dataSet"] = Convert.ToString("ALL");
            if (dataSet != null)
                callPayload.Queries["dataSet"] = ExpressionConverter.Convert(dataSet);
            callPayload.Queries["select"] = Convert.ToString("dateTime,radar,radarCode,radarDistance,radarLatitude,radarLongitude,rainfall,rainfallCurrentHour,rainfallMonthToDate,rainfallSince9am,rainfallYrarToDate");
            if (select != null)
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetRadarRainfallResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        public IBodyWorkflowAction<GetRadarDailySummariesResponse> GetRadarDailySummaries(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<dataSetInput>> dataSet = null, Expression<Func<string>> select = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/summaries/daily";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            callPayload.Queries["dataSet"] = Convert.ToString("ALL");
            if (dataSet != null)
                callPayload.Queries["dataSet"] = ExpressionConverter.Convert(dataSet);
            callPayload.Queries["select"] = Convert.ToString("radar,radarCode,radarLatitude,radarLongitude,radarDistance,period,periodFrom,periodTo,periodYear,periodMonth,periodDay,periodHour,periodMinute,rainfall");
            if (select != null)
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetRadarDailySummariesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        public IBodyWorkflowAction<GetRadarMonthlySummariesResponse> GetRadarMonthlySummaries(Expression<Func<string>> startMonth, Expression<Func<string>> endMonth, Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<dataSetInput>> dataSet = null, Expression<Func<string>> select = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/summaries/monthly";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startMonth"] = ExpressionConverter.Convert(startMonth);
            callPayload.Queries["endMonth"] = ExpressionConverter.Convert(endMonth);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            callPayload.Queries["dataSet"] = Convert.ToString("ALL");
            if (dataSet != null)
                callPayload.Queries["dataSet"] = ExpressionConverter.Convert(dataSet);
            callPayload.Queries["select"] = Convert.ToString("radar,radarCode,radarLatitude,radarLongitude,radarDistance,period,periodFrom,periodTo,periodYear,periodMonth,periodDay,periodHour,periodMinute,rainfall");
            if (select != null)
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GetRadarMonthlySummariesResponse>(callPayload);
        }
    }

    public class DpirdradaripTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRadarsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public RadarMetadataModel[] Collection { get; set; }
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

    public class RadarMetadataModel
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("offlineReason")]
        public string OfflineReason { get; set; }

        [JsonProperty("bounds")]
        public double[][] Bounds { get; set; }
    }

    public class GetRadarResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public RadarMetadataModel[] Collection { get; set; }
    }

    public class GetNearbyRadarResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public RadarLocationModel[] Collection { get; set; }
    }

    public class RadarLocationModel
    {
        [JsonProperty("radarCode")]
        public string RadarCode { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("dataSet")]
        public string DataSet { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public enum dataSetInput
    {
        RF3,
        RF2,
        ALL
    }

    public class GetRadarRainfallResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public RainfallModel Data { get; set; }
    }

    public class RainfallModel
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("radar")]
        public RainfallModelRadarType Radar { get; set; }

        [JsonProperty("rainfall")]
        public RainfallModelRainfallType Rainfall { get; set; }
    }

    public class RainfallModelRadarType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("dataSet")]
        public string DataSet { get; set; }
    }

    public class RainfallModelRainfallType
    {
        [JsonProperty("currentHour")]
        public int CurrentHour { get; set; }

        [JsonProperty("monthToDate")]
        public double MonthToDate { get; set; }

        [JsonProperty("yearToDate")]
        public double YearToDate { get; set; }
    }

    public class GetRadarDailySummariesResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public GetRadarDailySummariesResponseDataType Data { get; set; }
    }

    public class GetRadarDailySummariesResponseDataType
    {
        [JsonProperty("radar")]
        public RadarLocationModel2 Radar { get; set; }

        [JsonProperty("summaries")]
        public RainfallSummaryModel[] Summaries { get; set; }
    }

    public class RadarLocationModel2
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }
    }

    public class RainfallSummaryModel
    {
        [JsonProperty("period")]
        public RainfallSummaryModelPeriodType Period { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }
    }

    public class RainfallSummaryModelPeriodType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class GetRadarMonthlySummariesResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public GetRadarMonthlySummariesResponseDataType Data { get; set; }
    }

    public class GetRadarMonthlySummariesResponseDataType
    {
        [JsonProperty("radar")]
        public RadarLocationModel2 Radar { get; set; }

        [JsonProperty("summaries")]
        public RainfallSummaryModel[] Summaries { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdradarip;

    public partial class WorkflowManagedActions
    {
        public DpirdradaripActions Dpirdradarip(string connectionId) => new DpirdradaripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DpirdradaripTriggers Dpirdradarip(string connectionId) => new DpirdradaripTriggers(connectionId);
    }
}