//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Occuspace
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OccuspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "occuspace")]
        public IBodyWorkflowAction<LocationListResponse, ApiConnectionActionConfiguration> LocationList()
        {
            return new DeferredBodyAction<LocationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "occuspace")]
        public IBodyWorkflowAction<RealTimeDataResponse, ApiConnectionActionConfiguration> RealTimeData(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<RealTimeDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/location/{0}:/now", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RealTimeDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "occuspace")]
        public IBodyWorkflowAction<HistoricalDataResponse, ApiConnectionActionConfiguration> HistoricalData(Expression<Func<int>> id, Expression<Func<string>> start, Expression<Func<string>> end)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: true);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: true);
            return new DeferredBodyAction<HistoricalDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/location/{0}:/counts", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<HistoricalDataResponse>(callPayload);
            });
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