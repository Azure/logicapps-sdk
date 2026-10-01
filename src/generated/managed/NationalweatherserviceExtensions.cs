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
        public IBodyWorkflowAction<ProblemDetail> Tafs([WorkflowExpression] Func<string> stationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> Taf([WorkflowExpression] Func<string> stationId, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> time)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stations/{0}/tafs/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(time, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> RadarQueue([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> arrived = null, [WorkflowExpression] Func<string> created = null, [WorkflowExpression] Func<string> published = null, [WorkflowExpression] Func<string> station = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> feed = null, [WorkflowExpression] Func<int> resolution = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/radar/queues/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (arrived != null)
                    callPayload.Queries["arrived"] = SourceExpressionConverter.ConvertO(arrived);
                if (created != null)
                    callPayload.Queries["created"] = SourceExpressionConverter.ConvertO(created);
                if (published != null)
                    callPayload.Queries["published"] = SourceExpressionConverter.ConvertO(published);
                if (station != null)
                    callPayload.Queries["station"] = SourceExpressionConverter.ConvertO(station);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (feed != null)
                    callPayload.Queries["feed"] = SourceExpressionConverter.ConvertO(feed);
                if (resolution != null)
                    callPayload.Queries["resolution"] = SourceExpressionConverter.ConvertO(resolution);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalweatherservice")]
        public IBodyWorkflowAction<ProblemDetail> RadarProfiler([WorkflowExpression] Func<string> stationId, [WorkflowExpression] Func<string> time = null, [WorkflowExpression] Func<string> interval = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/radar/profilers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (time != null)
                    callPayload.Queries["time"] = SourceExpressionConverter.ConvertO(time);
                if (interval != null)
                    callPayload.Queries["interval"] = SourceExpressionConverter.ConvertO(interval);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetail>(BuildSourceInput);
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