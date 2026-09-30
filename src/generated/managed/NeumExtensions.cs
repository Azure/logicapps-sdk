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
        public IBodyWorkflowAction<PipelinePostResponse> Pipeline([WorkflowExpression] Func<string> bodysourcesourceName, [WorkflowExpression] Func<string> bodysourcemetadataconnectionString, [WorkflowExpression] Func<string> bodysourcemetadatacontainerName, [WorkflowExpression] Func<string> bodyembedembedName, [WorkflowExpression] Func<string> bodyembedmetadataapiKey, [WorkflowExpression] Func<string> bodyembedmetadataorganization, [WorkflowExpression] Func<string> bodysinksinkName, [WorkflowExpression] Func<string> bodysinkmetadataapiKey, [WorkflowExpression] Func<string> bodysinkmetadataenvironment, [WorkflowExpression] Func<string> bodysinkmetadataindex, [WorkflowExpression] Func<string> bodysinkmetadataNamespace, [WorkflowExpression] Func<string> bodytriggerSchedulestartDate = null, [WorkflowExpression] Func<string> bodytriggerSchedulecadence = null)
        {
            SourceExpression.Validate(bodysourcesourceName, nameof(bodysourcesourceName), required: true);
            SourceExpression.Validate(bodysourcemetadataconnectionString, nameof(bodysourcemetadataconnectionString), required: true);
            SourceExpression.Validate(bodysourcemetadatacontainerName, nameof(bodysourcemetadatacontainerName), required: true);
            SourceExpression.Validate(bodyembedembedName, nameof(bodyembedembedName), required: true);
            SourceExpression.Validate(bodyembedmetadataapiKey, nameof(bodyembedmetadataapiKey), required: true);
            SourceExpression.Validate(bodyembedmetadataorganization, nameof(bodyembedmetadataorganization), required: true);
            SourceExpression.Validate(bodysinksinkName, nameof(bodysinksinkName), required: true);
            SourceExpression.Validate(bodysinkmetadataapiKey, nameof(bodysinkmetadataapiKey), required: true);
            SourceExpression.Validate(bodysinkmetadataenvironment, nameof(bodysinkmetadataenvironment), required: true);
            SourceExpression.Validate(bodysinkmetadataindex, nameof(bodysinkmetadataindex), required: true);
            SourceExpression.Validate(bodysinkmetadataNamespace, nameof(bodysinkmetadataNamespace), required: true);
            SourceExpression.Validate(bodytriggerSchedulestartDate, nameof(bodytriggerSchedulestartDate), required: false);
            SourceExpression.Validate(bodytriggerSchedulecadence, nameof(bodytriggerSchedulecadence), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pipelines";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                sourceObjectpropCount++;
                sourceObject["source_name"] = SourceExpressionConverter.ConvertToken(bodysourcesourceName);
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["connection_string"] = SourceExpressionConverter.ConvertToken(bodysourcemetadataconnectionString);
                metadataObjectpropCount++;
                metadataObject["container_name"] = SourceExpressionConverter.ConvertToken(bodysourcemetadatacontainerName);
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
                embedObject["embed_name"] = SourceExpressionConverter.ConvertToken(bodyembedembedName);
                var metadataObject2 = new JObject();
                var metadataObject2propCount = 0;
                metadataObject2propCount++;
                metadataObject2["api_key"] = SourceExpressionConverter.ConvertToken(bodyembedmetadataapiKey);
                metadataObject2propCount++;
                metadataObject2["organization"] = SourceExpressionConverter.ConvertToken(bodyembedmetadataorganization);
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
                sinkObject["sink_name"] = SourceExpressionConverter.ConvertToken(bodysinksinkName);
                var metadataObject3 = new JObject();
                var metadataObject3propCount = 0;
                metadataObject3propCount++;
                metadataObject3["api_key"] = SourceExpressionConverter.ConvertToken(bodysinkmetadataapiKey);
                metadataObject3propCount++;
                metadataObject3["environment"] = SourceExpressionConverter.ConvertToken(bodysinkmetadataenvironment);
                metadataObject3propCount++;
                metadataObject3["index"] = SourceExpressionConverter.ConvertToken(bodysinkmetadataindex);
                metadataObject3propCount++;
                metadataObject3["namespace"] = SourceExpressionConverter.ConvertToken(bodysinkmetadataNamespace);
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
                if (bodytriggerSchedulestartDate != null)
                {
                    triggerScheduleObject["start_date"] = SourceExpressionConverter.ConvertToken(bodytriggerSchedulestartDate);
                    triggerScheduleObjectpropCount++;
                }

                if (bodytriggerSchedulecadence != null)
                {
                    triggerScheduleObject["cadence"] = SourceExpressionConverter.ConvertToken(bodytriggerSchedulecadence);
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
                return callPayload;
            }

            return new ApiConnectionAction<PipelinePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "neum")]
        public IBodyWorkflowAction<PipelineTestPostResponse> PipelineTest([WorkflowExpression] Func<string> pipelineId, [WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<int> bodynumberOfResults)
        {
            SourceExpression.Validate(pipelineId, nameof(pipelineId), required: true);
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodynumberOfResults, nameof(bodynumberOfResults), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pipelines/{0}/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pipelineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
                body["number_of_results"] = SourceExpressionConverter.ConvertToken(bodynumberOfResults);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PipelineTestPostResponse>(BuildSourceInput);
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