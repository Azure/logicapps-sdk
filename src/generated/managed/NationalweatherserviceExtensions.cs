//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nationalweatherservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NationalweatherserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> Tafs(Expression<Func<string>> stationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProblemDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> Taf(Expression<Func<string>> stationId, Expression<Func<string>> date, Expression<Func<string>> time)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(time, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProblemDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> RadarQueue(Expression<Func<string>> host, Expression<Func<int>> limit = null, Expression<Func<string>> arrived = null, Expression<Func<string>> created = null, Expression<Func<string>> published = null, Expression<Func<string>> station = null, Expression<Func<string>> type = null, Expression<Func<string>> feed = null, Expression<Func<int>> resolution = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/radar/queues/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (arrived != null)
                callPayload.Queries["arrived"] = CSharpExpressionConverter.ConvertO(arrived);
            if (created != null)
                callPayload.Queries["created"] = CSharpExpressionConverter.ConvertO(created);
            if (published != null)
                callPayload.Queries["published"] = CSharpExpressionConverter.ConvertO(published);
            if (station != null)
                callPayload.Queries["station"] = CSharpExpressionConverter.ConvertO(station);
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.ConvertO(type);
            if (feed != null)
                callPayload.Queries["feed"] = CSharpExpressionConverter.ConvertO(feed);
            if (resolution != null)
                callPayload.Queries["resolution"] = CSharpExpressionConverter.ConvertO(resolution);
            return new ApiConnectionAction<ProblemDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> RadarProfiler(Expression<Func<string>> stationId, Expression<Func<string>> time = null, Expression<Func<string>> interval = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/radar/profilers/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (time != null)
                callPayload.Queries["time"] = CSharpExpressionConverter.ConvertO(time);
            if (interval != null)
                callPayload.Queries["interval"] = CSharpExpressionConverter.ConvertO(interval);
            return new ApiConnectionAction<ProblemDetail>(callPayload);
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