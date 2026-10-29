//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Neum
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NeumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelinePostResponse, ApiConnectionActionConfiguration> Pipeline(Expression<Func<PipelinePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PipelinePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pipelines";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PipelinePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelineTestPostResponse, ApiConnectionActionConfiguration> PipelineTest(Expression<Func<string>> pipelineId, Expression<Func<PipelineTestPostInput>> body = null)
        {
            var __workflow_pipelineId = WorkflowExpression.Compile(pipelineId, nameof(pipelineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PipelineTestPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pipelines/{0}/search", __workflow_pipelineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PipelineTestPostResponse>(callPayload);
            });
        }
    }

    public class NeumTriggers([ConnectionName] string connectionId)
    {
    }

    public class PipelinePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public PipelinePostResponseSourceType Source { get; set; }

        [JsonProperty("sink")]
        public PipelinePostResponseSinkType Sink { get; set; }

        [JsonProperty("embed")]
        public PipelinePostResponseEmbedType Embed { get; set; }

        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("trigger_schedule")]
        public PipelinePostResponseTriggerScheduleType TriggerSchedule { get; set; }
    }

    public class PipelinePostResponseSourceType
    {
        [JsonProperty("source_name")]
        public string SourceName { get; set; }
    }

    public class PipelinePostResponseSinkType
    {
        [JsonProperty("sink_name")]
        public string SinkName { get; set; }
    }

    public class PipelinePostResponseEmbedType
    {
        [JsonProperty("embed_name")]
        public string EmbedName { get; set; }
    }

    public class PipelinePostResponseTriggerScheduleType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("cadence")]
        public string Cadence { get; set; }
    }

    public class PipelinePostInput
    {
        [JsonProperty("source")]
        public PipelinePostInputSourceType Source { get; set; }

        [JsonProperty("embed")]
        public PipelinePostInputEmbedType Embed { get; set; }

        [JsonProperty("sink")]
        public PipelinePostInputSinkType Sink { get; set; }

        [JsonProperty("trigger_schedule")]
        public PipelinePostInputTriggerScheduleType TriggerSchedule { get; set; }
    }

    public class PipelinePostInputSourceType
    {
        [JsonProperty("source_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceName { get; set; }

        [JsonProperty("metadata")]
        public PipelinePostInputSourceTypeMetadataType Metadata { get; set; }
    }

    public class PipelinePostInputSourceTypeMetadataType
    {
        [JsonProperty("connection_string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionString { get; set; }

        [JsonProperty("container_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContainerName { get; set; }
    }

    public class PipelinePostInputEmbedType
    {
        [JsonProperty("embed_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmbedName { get; set; }

        [JsonProperty("metadata")]
        public PipelinePostInputEmbedTypeMetadataType Metadata { get; set; }
    }

    public class PipelinePostInputEmbedTypeMetadataType
    {
        [JsonProperty("api_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("organization", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Organization { get; set; }
    }

    public class PipelinePostInputSinkType
    {
        [JsonProperty("sink_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SinkName { get; set; }

        [JsonProperty("metadata")]
        public PipelinePostInputSinkTypeMetadataType Metadata { get; set; }
    }

    public class PipelinePostInputSinkTypeMetadataType
    {
        [JsonProperty("api_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("environment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Environment { get; set; }

        [JsonProperty("index", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Index { get; set; }

        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }
    }

    public class PipelinePostInputTriggerScheduleType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("cadence")]
        public string Cadence { get; set; }
    }

    public class PipelineTestPostResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class PipelineTestPostInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("number_of_results", DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfResults { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Neum;

    public partial class WorkflowManagedActions
    {
        public NeumActions Neum(string connectionId) => new NeumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NeumTriggers Neum(string connectionId) => new NeumTriggers(connectionId);
    }
}