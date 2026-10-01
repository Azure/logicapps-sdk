//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Occuspace
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OccuspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "occuspace")]
        public IBodyWorkflowAction<LocationListResponse> LocationList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LocationListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "occuspace")]
        public IBodyWorkflowAction<RealTimeDataResponse> RealTimeData([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/location/{0}:/now", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RealTimeDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "occuspace")]
        public IBodyWorkflowAction<HistoricalDataResponse> HistoricalData([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> start, [WorkflowExpression] Func<string> end)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/location/{0}:/counts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<HistoricalDataResponse>(BuildSourceInput);
        }
    }

    public class OccuspaceTriggers([ConnectionName] string connectionId)
    {
    }

    public class LocationListResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public LocationListResponseDataTypeItem[] Data { get; set; }
    }

    public class LocationListResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("earliestCount")]
        public string EarliestCount { get; set; }
    }

    public class RealTimeDataResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public RealTimeDataResponseDataType Data { get; set; }
    }

    public class RealTimeDataResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("percentage")]
        public double Percentage { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("childCounts")]
        public RealTimeDataResponseDataTypeChildCountsTypeItem[] ChildCounts { get; set; }
    }

    public class RealTimeDataResponseDataTypeChildCountsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("percentage")]
        public double Percentage { get; set; }
    }

    public class HistoricalDataResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public HistoricalDataResponseDataType Data { get; set; }
    }

    public class HistoricalDataResponseDataType
    {
        [JsonProperty("counts")]
        public HistoricalDataResponseDataTypeCountsTypeItem[] Counts { get; set; }

        [JsonProperty("maximum")]
        public HistoricalDataResponseDataTypeMaximumType Maximum { get; set; }

        [JsonProperty("minimum")]
        public HistoricalDataResponseDataTypeMinimumType Minimum { get; set; }

        [JsonProperty("average")]
        public int Average { get; set; }
    }

    public class HistoricalDataResponseDataTypeCountsTypeItem
    {
        [JsonProperty("percentage")]
        public double Percentage { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("normalizedDate")]
        public string NormalizedDate { get; set; }

        [JsonProperty("normalizedTime")]
        public string NormalizedTime { get; set; }
    }

    public class HistoricalDataResponseDataTypeMaximumType
    {
        [JsonProperty("percentage")]
        public double Percentage { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("normalizedDate")]
        public string NormalizedDate { get; set; }

        [JsonProperty("normalizedTime")]
        public string NormalizedTime { get; set; }
    }

    public class HistoricalDataResponseDataTypeMinimumType
    {
        [JsonProperty("percentage")]
        public double Percentage { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("normalizedDate")]
        public string NormalizedDate { get; set; }

        [JsonProperty("normalizedTime")]
        public string NormalizedTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Occuspace;

    public partial class WorkflowManagedActions
    {
        public OccuspaceActions Occuspace(string connectionId) => new OccuspaceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OccuspaceTriggers Occuspace(string connectionId) => new OccuspaceTriggers(connectionId);
    }
}