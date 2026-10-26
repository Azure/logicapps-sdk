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
        public IBodyWorkflowAction<PipelinePostResponse, ApiConnectionActionConfiguration> Pipeline(Expression<Func<string>> bodysourcesourceName, Expression<Func<string>> bodysourcemetadataconnectionString, Expression<Func<string>> bodysourcemetadatacontainerName, Expression<Func<string>> bodyembedembedName, Expression<Func<string>> bodyembedmetadataapiKey, Expression<Func<string>> bodyembedmetadataorganization, Expression<Func<string>> bodysinksinkName, Expression<Func<string>> bodysinkmetadataapiKey, Expression<Func<string>> bodysinkmetadataenvironment, Expression<Func<string>> bodysinkmetadataindex, Expression<Func<string>> bodysinkmetadataNamespace, Expression<Func<string>> bodytriggerSchedulestartDate = null, Expression<Func<string>> bodytriggerSchedulecadence = null)
        {
            var __workflow_bodysourcesourceName = WorkflowExpression.Compile(bodysourcesourceName, nameof(bodysourcesourceName), required: true);
            var __workflow_bodysourcemetadataconnectionString = WorkflowExpression.Compile(bodysourcemetadataconnectionString, nameof(bodysourcemetadataconnectionString), required: true);
            var __workflow_bodysourcemetadatacontainerName = WorkflowExpression.Compile(bodysourcemetadatacontainerName, nameof(bodysourcemetadatacontainerName), required: true);
            var __workflow_bodyembedembedName = WorkflowExpression.Compile(bodyembedembedName, nameof(bodyembedembedName), required: true);
            var __workflow_bodyembedmetadataapiKey = WorkflowExpression.Compile(bodyembedmetadataapiKey, nameof(bodyembedmetadataapiKey), required: true);
            var __workflow_bodyembedmetadataorganization = WorkflowExpression.Compile(bodyembedmetadataorganization, nameof(bodyembedmetadataorganization), required: true);
            var __workflow_bodysinksinkName = WorkflowExpression.Compile(bodysinksinkName, nameof(bodysinksinkName), required: true);
            var __workflow_bodysinkmetadataapiKey = WorkflowExpression.Compile(bodysinkmetadataapiKey, nameof(bodysinkmetadataapiKey), required: true);
            var __workflow_bodysinkmetadataenvironment = WorkflowExpression.Compile(bodysinkmetadataenvironment, nameof(bodysinkmetadataenvironment), required: true);
            var __workflow_bodysinkmetadataindex = WorkflowExpression.Compile(bodysinkmetadataindex, nameof(bodysinkmetadataindex), required: true);
            var __workflow_bodysinkmetadataNamespace = WorkflowExpression.Compile(bodysinkmetadataNamespace, nameof(bodysinkmetadataNamespace), required: true);
            var __workflow_bodytriggerSchedulestartDate = WorkflowExpression.Compile(bodytriggerSchedulestartDate, nameof(bodytriggerSchedulestartDate), required: false);
            var __workflow_bodytriggerSchedulecadence = WorkflowExpression.Compile(bodytriggerSchedulecadence, nameof(bodytriggerSchedulecadence), required: false);
            return new DeferredBodyAction<PipelinePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pipelines";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                sourceObjectpropCount++;
                sourceObject["source_name"] = ExpressionConverter.ConvertO(__workflow_bodysourcesourceName);
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["connection_string"] = ExpressionConverter.ConvertO(__workflow_bodysourcemetadataconnectionString);
                metadataObjectpropCount++;
                metadataObject["container_name"] = ExpressionConverter.ConvertO(__workflow_bodysourcemetadatacontainerName);
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
                embedObject["embed_name"] = ExpressionConverter.ConvertO(__workflow_bodyembedembedName);
                var metadataObject2 = new JObject();
                var metadataObject2propCount = 0;
                metadataObject2propCount++;
                metadataObject2["api_key"] = ExpressionConverter.ConvertO(__workflow_bodyembedmetadataapiKey);
                metadataObject2propCount++;
                metadataObject2["organization"] = ExpressionConverter.ConvertO(__workflow_bodyembedmetadataorganization);
                if (metadataObject2propCount > 0)
                {
                    embedObject["metadata"] = metadataObject2;
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
                sinkObject["sink_name"] = ExpressionConverter.ConvertO(__workflow_bodysinksinkName);
                var metadataObject3 = new JObject();
                var metadataObject3propCount = 0;
                metadataObject3propCount++;
                metadataObject3["api_key"] = ExpressionConverter.ConvertO(__workflow_bodysinkmetadataapiKey);
                metadataObject3propCount++;
                metadataObject3["environment"] = ExpressionConverter.ConvertO(__workflow_bodysinkmetadataenvironment);
                metadataObject3propCount++;
                metadataObject3["index"] = ExpressionConverter.ConvertO(__workflow_bodysinkmetadataindex);
                metadataObject3propCount++;
                metadataObject3["namespace"] = ExpressionConverter.ConvertO(__workflow_bodysinkmetadataNamespace);
                if (metadataObject3propCount > 0)
                {
                    sinkObject["metadata"] = metadataObject3;
                    sinkObjectpropCount++;
                }

                if (sinkObjectpropCount > 0)
                {
                    body["sink"] = sinkObject;
                    bodypropCount++;
                }

                var triggerScheduleObject = new JObject();
                var triggerScheduleObjectpropCount = 0;
                if (__workflow_bodytriggerSchedulestartDate != null)
                {
                    triggerScheduleObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodytriggerSchedulestartDate);
                    triggerScheduleObjectpropCount++;
                }

                if (__workflow_bodytriggerSchedulecadence != null)
                {
                    triggerScheduleObject["cadence"] = ExpressionConverter.ConvertO(__workflow_bodytriggerSchedulecadence);
                    triggerScheduleObjectpropCount++;
                }

                if (triggerScheduleObjectpropCount > 0)
                {
                    body["trigger_schedule"] = triggerScheduleObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PipelinePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelineTestPostResponse, ApiConnectionActionConfiguration> PipelineTest(Expression<Func<string>> pipelineId, Expression<Func<string>> bodyquery, Expression<Func<int>> bodynumberOfResults)
        {
            var __workflow_pipelineId = WorkflowExpression.Compile(pipelineId, nameof(pipelineId), required: true);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodynumberOfResults = WorkflowExpression.Compile(bodynumberOfResults, nameof(bodynumberOfResults), required: true);
            return new DeferredBodyAction<PipelineTestPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pipelines/{0}/search", __workflow_pipelineId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                bodypropCount++;
                body["number_of_results"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfResults);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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