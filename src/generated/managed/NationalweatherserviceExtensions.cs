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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildTafs(WorkflowExpression<string> stationId)
        {
            WorkflowExpression.Validate(stationId, nameof(stationId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildTaf(WorkflowExpression<string> stationId, WorkflowExpression<string> date, WorkflowExpression<string> time)
        {
            WorkflowExpression.Validate(stationId, nameof(stationId), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: true);
            WorkflowExpression.Validate(time, nameof(time), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildRadarQueue(WorkflowExpression<string> host, WorkflowExpression<int> limit = null, WorkflowExpression<string> arrived = null, WorkflowExpression<string> created = null, WorkflowExpression<string> published = null, WorkflowExpression<string> station = null, WorkflowExpression<string> type = null, WorkflowExpression<string> feed = null, WorkflowExpression<int> resolution = null)
        {
            WorkflowExpression.Validate(host, nameof(host), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(arrived, nameof(arrived), required: false);
            WorkflowExpression.Validate(created, nameof(created), required: false);
            WorkflowExpression.Validate(published, nameof(published), required: false);
            WorkflowExpression.Validate(station, nameof(station), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(feed, nameof(feed), required: false);
            WorkflowExpression.Validate(resolution, nameof(resolution), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetail> __BuildRadarProfiler(WorkflowExpression<string> stationId, WorkflowExpression<string> time = null, WorkflowExpression<string> interval = null)
        {
            WorkflowExpression.Validate(stationId, nameof(stationId), required: true);
            WorkflowExpression.Validate(time, nameof(time), required: false);
            WorkflowExpression.Validate(interval, nameof(interval), required: false);
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