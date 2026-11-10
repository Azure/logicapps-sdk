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
        public IBodyWorkflowAction<PipelineResponse, ApiConnectionActionConfiguration> Pipeline(Expression<Func<PipelineBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PipelineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pipelines";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PipelineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelineTestResponse, ApiConnectionActionConfiguration> PipelineTest(Expression<Func<string>> pipelineId, Expression<Func<PipelineTestBodyInput>> body)
        {
            var __workflow_pipelineId = WorkflowExpression.Compile(pipelineId, nameof(pipelineId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PipelineTestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pipelines/{0}/search", __workflow_pipelineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PipelineTestResponse>(callPayload);
            });
        }
    }

    public class NeumTriggers([ConnectionName] string connectionId)
    {
    }

    public class PipelineResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public PipelineResponseSourceType Source { get; set; }

        [JsonProperty("sink")]
        public PipelineResponseSinkType Sink { get; set; }

        [JsonProperty("embed")]
        public PipelineResponseEmbedType Embed { get; set; }

        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("trigger_schedule")]
        public PipelineResponseTriggerScheduleType TriggerSchedule { get; set; }
    }

    public class PipelineResponseSourceType
    {
        [JsonProperty("source_name")]
        public string SourceName { get; set; }
    }

    public class PipelineResponseSinkType
    {
        [JsonProperty("sink_name")]
        public string SinkName { get; set; }
    }

    public class PipelineResponseEmbedType
    {
        [JsonProperty("embed_name")]
        public string EmbedName { get; set; }
    }

    public class PipelineResponseTriggerScheduleType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("cadence")]
        public string Cadence { get; set; }
    }

    public class PipelineBodyInput
    {
        [JsonProperty("source")]
        public BodyInputSourceType Source { get; set; }

        [JsonProperty("embed")]
        public BodyInputEmbedType Embed { get; set; }

        [JsonProperty("sink")]
        public BodyInputSinkType Sink { get; set; }

        [JsonProperty("trigger_schedule")]
        public BodyInputTriggerScheduleType TriggerSchedule { get; set; }
    }

    public class BodyInputSourceType
    {
        public BodyInputSourceType(string sourceName)
        {
            this.SourceName = sourceName;
        }

        [JsonProperty("source_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceName { get; set; }

        [JsonProperty("metadata")]
        public BodyInputSourceTypeMetadataType Metadata { get; set; }
    }

    public class BodyInputSourceTypeMetadataType
    {
        public BodyInputSourceTypeMetadataType(string connectionString, string containerName)
        {
            this.ConnectionString = connectionString;
            this.ContainerName = containerName;
        }

        [JsonProperty("connection_string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionString { get; set; }

        [JsonProperty("container_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContainerName { get; set; }
    }

    public class BodyInputEmbedType
    {
        public BodyInputEmbedType(string embedName)
        {
            this.EmbedName = embedName;
        }

        [JsonProperty("embed_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmbedName { get; set; }

        [JsonProperty("metadata")]
        public BodyInputEmbedTypeMetadataType Metadata { get; set; }
    }

    public class BodyInputEmbedTypeMetadataType
    {
        public BodyInputEmbedTypeMetadataType(string apiKey, string organization)
        {
            this.ApiKey = apiKey;
            this.Organization = organization;
        }

        [JsonProperty("api_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("organization", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Organization { get; set; }
    }

    public class BodyInputSinkType
    {
        public BodyInputSinkType(string sinkName)
        {
            this.SinkName = sinkName;
        }

        [JsonProperty("sink_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SinkName { get; set; }

        [JsonProperty("metadata")]
        public BodyInputSinkTypeMetadataType Metadata { get; set; }
    }

    public class BodyInputSinkTypeMetadataType
    {
        public BodyInputSinkTypeMetadataType(string apiKey, string environment, string index, string @namespace)
        {
            this.ApiKey = apiKey;
            this.Environment = environment;
            this.Index = index;
            this.Namespace = @namespace;
        }

        [JsonProperty("api_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("environment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Environment { get; set; }

        [JsonProperty("index", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Index { get; set; }

        [JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Namespace { get; set; }
    }

    public class BodyInputTriggerScheduleType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("cadence")]
        public string Cadence { get; set; }
    }

    public class PipelineTestResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class PipelineTestBodyInput
    {
        public PipelineTestBodyInput(string query, int numberOfResults)
        {
            this.Query = query;
            this.NumberOfResults = numberOfResults;
        }

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