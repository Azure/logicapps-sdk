//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nationalweatherservice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NationalweatherserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> Tafs(Expression<Func<string>> stationId)
        {
            var __workflow_stationId = WorkflowExpression.Compile(stationId, nameof(stationId), required: true);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_stationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> Taf(Expression<Func<string>> stationId, Expression<Func<string>> date, Expression<Func<string>> time)
        {
            var __workflow_stationId = WorkflowExpression.Compile(stationId, nameof(stationId), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: true);
            var __workflow_time = WorkflowExpression.Compile(time, nameof(time), required: true);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_stationId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_date, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_time, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> RadarQueue(Expression<Func<string>> host, Expression<Func<int>> limit = null, Expression<Func<string>> arrived = null, Expression<Func<string>> created = null, Expression<Func<string>> published = null, Expression<Func<string>> station = null, Expression<Func<string>> type = null, Expression<Func<string>> feed = null, Expression<Func<int>> resolution = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_arrived = WorkflowExpression.Compile(arrived, nameof(arrived), required: false);
            var __workflow_created = WorkflowExpression.Compile(created, nameof(created), required: false);
            var __workflow_published = WorkflowExpression.Compile(published, nameof(published), required: false);
            var __workflow_station = WorkflowExpression.Compile(station, nameof(station), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_feed = WorkflowExpression.Compile(feed, nameof(feed), required: false);
            var __workflow_resolution = WorkflowExpression.Compile(resolution, nameof(resolution), required: false);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/radar/queues/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_arrived != null)
                    callPayload.Queries["arrived"] = ExpressionConverter.Convert(__workflow_arrived);
                if (__workflow_created != null)
                    callPayload.Queries["created"] = ExpressionConverter.Convert(__workflow_created);
                if (__workflow_published != null)
                    callPayload.Queries["published"] = ExpressionConverter.Convert(__workflow_published);
                if (__workflow_station != null)
                    callPayload.Queries["station"] = ExpressionConverter.Convert(__workflow_station);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_feed != null)
                    callPayload.Queries["feed"] = ExpressionConverter.Convert(__workflow_feed);
                if (__workflow_resolution != null)
                    callPayload.Queries["resolution"] = ExpressionConverter.Convert(__workflow_resolution);
                return new ApiConnectionAction<ProblemDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> RadarProfiler(Expression<Func<string>> stationId, Expression<Func<string>> time = null, Expression<Func<string>> interval = null)
        {
            var __workflow_stationId = WorkflowExpression.Compile(stationId, nameof(stationId), required: true);
            var __workflow_time = WorkflowExpression.Compile(time, nameof(time), required: false);
            var __workflow_interval = WorkflowExpression.Compile(interval, nameof(interval), required: false);
            return new DeferredBodyAction<ProblemDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/radar/profilers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_stationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(__workflow_time);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
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
