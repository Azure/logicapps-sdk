//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdradarip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdradaripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRadars))]
        public IBodyWorkflowAction<GetRadarsResponse> GetRadars([WorkflowExpression] Func<string> radarCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRadarsResponse> __BuildGetRadars(WorkflowValue<string> radarCode = null, WorkflowValue<int> offset = null, WorkflowValue<int> limit = null, WorkflowValue<string> sort = null, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(radarCode, nameof(radarCode), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetRadarsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRadar))]
        public IBodyWorkflowAction<GetRadarResponse> GetRadar([WorkflowExpression] Func<string> radarCode, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRadarResponse> __BuildGetRadar(WorkflowValue<string> radarCode, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(radarCode, nameof(radarCode), required: true);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetRadarResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/radars/{0}", ExpressionConverter.ConvertWithUrlEncoding(radarCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["select"] = Convert.ToString("code,location,state,bounds,online,offline_reason");
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetRadarResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        [WorkflowExpressionFactory(nameof(__BuildGetNearbyRadar))]
        public IBodyWorkflowAction<GetNearbyRadarResponse> GetNearbyRadar([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<dataSetInput> dataSet = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetNearbyRadarResponse> __BuildGetNearbyRadar(WorkflowValue<double> latitude, WorkflowValue<double> longitude, WorkflowValue<dataSetInput> dataSet = null)
        {
            WorkflowValue.Validate(latitude, nameof(latitude), required: true);
            WorkflowValue.Validate(longitude, nameof(longitude), required: true);
            WorkflowValue.Validate(dataSet, nameof(dataSet), required: false);
            return new DeferredBodyAction<GetNearbyRadarResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRadarRainfall))]
        public IBodyWorkflowAction<GetRadarRainfallResponse> GetRadarRainfall([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<string> radarCode = null, [WorkflowExpression] Func<dataSetInput> dataSet = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRadarRainfallResponse> __BuildGetRadarRainfall(WorkflowValue<double> latitude, WorkflowValue<double> longitude, WorkflowValue<string> radarCode = null, WorkflowValue<dataSetInput> dataSet = null, WorkflowValue<string> select = null, WorkflowValue<int> offset = null, WorkflowValue<int> limit = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(latitude, nameof(latitude), required: true);
            WorkflowValue.Validate(longitude, nameof(longitude), required: true);
            WorkflowValue.Validate(radarCode, nameof(radarCode), required: false);
            WorkflowValue.Validate(dataSet, nameof(dataSet), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetRadarRainfallResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRadarDailySummaries))]
        public IBodyWorkflowAction<GetRadarDailySummariesResponse> GetRadarDailySummaries([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<dataSetInput> dataSet = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRadarDailySummariesResponse> __BuildGetRadarDailySummaries(WorkflowValue<string> startDate, WorkflowValue<string> endDate, WorkflowValue<double> latitude, WorkflowValue<double> longitude, WorkflowValue<dataSetInput> dataSet = null, WorkflowValue<string> select = null, WorkflowValue<int> offset = null, WorkflowValue<int> limit = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(startDate, nameof(startDate), required: true);
            WorkflowValue.Validate(endDate, nameof(endDate), required: true);
            WorkflowValue.Validate(latitude, nameof(latitude), required: true);
            WorkflowValue.Validate(longitude, nameof(longitude), required: true);
            WorkflowValue.Validate(dataSet, nameof(dataSet), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetRadarDailySummariesResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdradarip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRadarMonthlySummaries))]
        public IBodyWorkflowAction<GetRadarMonthlySummariesResponse> GetRadarMonthlySummaries([WorkflowExpression] Func<string> startMonth, [WorkflowExpression] Func<string> endMonth, [WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<dataSetInput> dataSet = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRadarMonthlySummariesResponse> __BuildGetRadarMonthlySummaries(WorkflowValue<string> startMonth, WorkflowValue<string> endMonth, WorkflowValue<double> latitude, WorkflowValue<double> longitude, WorkflowValue<dataSetInput> dataSet = null, WorkflowValue<string> select = null, WorkflowValue<int> offset = null, WorkflowValue<int> limit = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(startMonth, nameof(startMonth), required: true);
            WorkflowValue.Validate(endMonth, nameof(endMonth), required: true);
            WorkflowValue.Validate(latitude, nameof(latitude), required: true);
            WorkflowValue.Validate(longitude, nameof(longitude), required: true);
            WorkflowValue.Validate(dataSet, nameof(dataSet), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetRadarMonthlySummariesResponse>(() =>
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
            });
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
