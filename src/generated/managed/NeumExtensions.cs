//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Neum
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NeumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelinePostResponse> PipelinePost(Expression<Func<string>> bodysourcesourceName, Expression<Func<string>> bodysourcemetadataconnectionString, Expression<Func<string>> bodysourcemetadatacontainerName, Expression<Func<string>> bodyembedembedName, Expression<Func<string>> bodyembedmetadataapiKey, Expression<Func<string>> bodyembedmetadataorganization, Expression<Func<string>> bodysinksinkName, Expression<Func<string>> bodysinkmetadataapiKey, Expression<Func<string>> bodysinkmetadataenvironment, Expression<Func<string>> bodysinkmetadataindex, Expression<Func<string>> bodysinkmetadatanamespace, Expression<Func<string>> bodytriggerSchedulestartDate = null, Expression<Func<string>> bodytriggerSchedulecadence = null)
        {
            var apiCallPath = "/pipelines";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var sourceObject = new JObject();
            var sourceObjectpropCount = 0;
            sourceObjectpropCount++;
            sourceObject["source_name"] = ExpressionConverter.ConvertO(bodysourcesourceName);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["connection_string"] = ExpressionConverter.ConvertO(bodysourcemetadataconnectionString);
            metadataObjectpropCount++;
            metadataObject["container_name"] = ExpressionConverter.ConvertO(bodysourcemetadatacontainerName);
            if (metadataObjectpropCount > 0)
            {
                sourceObject["metadata"] = metadataObject;
                sourceObjectpropCount++;
            }

            if (sourceObjectpropCount > 0)
            {
                body["source"] = sourceObject;
                bodypropCount++;
            }

            var embedObject = new JObject();
            var embedObjectpropCount = 0;
            embedObjectpropCount++;
            embedObject["embed_name"] = ExpressionConverter.ConvertO(bodyembedembedName);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["api_key"] = ExpressionConverter.ConvertO(bodyembedmetadataapiKey);
            metadataObjectpropCount++;
            metadataObject["organization"] = ExpressionConverter.ConvertO(bodyembedmetadataorganization);
            if (metadataObjectpropCount > 0)
            {
                embedObject["metadata"] = metadataObject;
                embedObjectpropCount++;
            }

            if (embedObjectpropCount > 0)
            {
                body["embed"] = embedObject;
                bodypropCount++;
            }

            var sinkObject = new JObject();
            var sinkObjectpropCount = 0;
            sinkObjectpropCount++;
            sinkObject["sink_name"] = ExpressionConverter.ConvertO(bodysinksinkName);
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["api_key"] = ExpressionConverter.ConvertO(bodysinkmetadataapiKey);
            metadataObjectpropCount++;
            metadataObject["environment"] = ExpressionConverter.ConvertO(bodysinkmetadataenvironment);
            metadataObjectpropCount++;
            metadataObject["index"] = ExpressionConverter.ConvertO(bodysinkmetadataindex);
            metadataObjectpropCount++;
            metadataObject["namespace"] = ExpressionConverter.ConvertO(bodysinkmetadatanamespace);
            if (metadataObjectpropCount > 0)
            {
                sinkObject["metadata"] = metadataObject;
                sinkObjectpropCount++;
            }

            if (sinkObjectpropCount > 0)
            {
                body["sink"] = sinkObject;
                bodypropCount++;
            }

            var trigger_scheduleObject = new JObject();
            var trigger_scheduleObjectpropCount = 0;
            if (bodytriggerSchedulestartDate != null)
            {
                trigger_scheduleObject["start_date"] = ExpressionConverter.ConvertO(bodytriggerSchedulestartDate);
                trigger_scheduleObjectpropCount++;
            }

            if (bodytriggerSchedulecadence != null)
            {
                trigger_scheduleObject["cadence"] = ExpressionConverter.ConvertO(bodytriggerSchedulecadence);
                trigger_scheduleObjectpropCount++;
            }

            if (trigger_scheduleObjectpropCount > 0)
            {
                body["trigger_schedule"] = trigger_scheduleObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PipelinePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelineTestPostResponse> PipelineTestPost(Expression<Func<string>> pipelineId, Expression<Func<string>> bodyquery, Expression<Func<int>> bodynumberOfResults)
        {
            var apiCallPath = String.Format("/pipelines/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(pipelineId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = ExpressionConverter.ConvertO(bodyquery);
            bodypropCount++;
            body["number_of_results"] = ExpressionConverter.ConvertO(bodynumberOfResults);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PipelineTestPostResponse>(callPayload);
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

    public class PipelineTestPostResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
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