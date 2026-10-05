//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nationalweatherservice
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NationalweatherserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        [WorkflowExpressionFactory(nameof(__BuildTafs))]
        public IBodyWorkflowAction<ProblemDetail> Tafs([WorkflowExpression] Func<string> stationId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildTafs(WorkflowValue<string> stationId)
        {
            WorkflowValue.Validate(stationId, nameof(stationId), required: true);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs", ExpressionConverter.ConvertWithUrlEncoding(stationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        [WorkflowExpressionFactory(nameof(__BuildTaf))]
        public IBodyWorkflowAction<ProblemDetail> Taf([WorkflowExpression] Func<string> stationId, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> time)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildTaf(WorkflowValue<string> stationId, WorkflowValue<string> date, WorkflowValue<string> time)
        {
            WorkflowValue.Validate(stationId, nameof(stationId), required: true);
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(time, nameof(time), required: true);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(stationId, 1), ExpressionConverter.ConvertWithUrlEncoding(date, 1), ExpressionConverter.ConvertWithUrlEncoding(time, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        [WorkflowExpressionFactory(nameof(__BuildRadarQueue))]
        public IBodyWorkflowAction<ProblemDetail> RadarQueue([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> arrived = null, [WorkflowExpression] Func<string> created = null, [WorkflowExpression] Func<string> published = null, [WorkflowExpression] Func<string> station = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> feed = null, [WorkflowExpression] Func<int> resolution = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildRadarQueue(WorkflowValue<string> host, WorkflowValue<int> limit = null, WorkflowValue<string> arrived = null, WorkflowValue<string> created = null, WorkflowValue<string> published = null, WorkflowValue<string> station = null, WorkflowValue<string> type = null, WorkflowValue<string> feed = null, WorkflowValue<int> resolution = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(arrived, nameof(arrived), required: false);
            WorkflowValue.Validate(created, nameof(created), required: false);
            WorkflowValue.Validate(published, nameof(published), required: false);
            WorkflowValue.Validate(station, nameof(station), required: false);
            WorkflowValue.Validate(type, nameof(type), required: false);
            WorkflowValue.Validate(feed, nameof(feed), required: false);
            WorkflowValue.Validate(resolution, nameof(resolution), required: false);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/radar/queues/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (arrived != null)
                    callPayload.Queries["arrived"] = ExpressionConverter.Convert(arrived);
                if (created != null)
                    callPayload.Queries["created"] = ExpressionConverter.Convert(created);
                if (published != null)
                    callPayload.Queries["published"] = ExpressionConverter.Convert(published);
                if (station != null)
                    callPayload.Queries["station"] = ExpressionConverter.Convert(station);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (feed != null)
                    callPayload.Queries["feed"] = ExpressionConverter.Convert(feed);
                if (resolution != null)
                    callPayload.Queries["resolution"] = ExpressionConverter.Convert(resolution);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        [WorkflowExpressionFactory(nameof(__BuildRadarProfiler))]
        public IBodyWorkflowAction<ProblemDetail> RadarProfiler([WorkflowExpression] Func<string> stationId, [WorkflowExpression] Func<string> time = null, [WorkflowExpression] Func<string> interval = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildRadarProfiler(WorkflowValue<string> stationId, WorkflowValue<string> time = null, WorkflowValue<string> interval = null)
        {
            WorkflowValue.Validate(stationId, nameof(stationId), required: true);
            WorkflowValue.Validate(time, nameof(time), required: false);
            WorkflowValue.Validate(interval, nameof(interval), required: false);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/radar/profilers/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(time);
                if (interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(interval);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }
    }

    public class NationalweatherserviceTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProblemDetail
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("instance")]
        public string Instance { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nationalweatherservice;

    public partial class WorkflowManagedActions
    {
        public NationalweatherserviceActions Nationalweatherservice(string connectionId) => new NationalweatherserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NationalweatherserviceTriggers Nationalweatherservice(string connectionId) => new NationalweatherserviceTriggers(connectionId);
    }
}
