//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Copilotforservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CopilotforserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copilotforservice")]
        public IBodyWorkflowAction<OrchestratorConnectorResponse> NaturalQueryTextSearch([WorkflowExpression] Func<string> bodyprompt = null)
        {
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/orchestrator/connector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrchestratorConnectorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copilotforservice")]
        public IBodyWorkflowAction<OrchestratorConnectorResponse> ExecuteSkill([WorkflowExpression] Func<string> bodyskillId = null)
        {
            SourceExpression.Validate(bodyskillId, nameof(bodyskillId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/orchestrator/executeSkill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyskillId != null)
                {
                    body["SkillId"] = SourceExpressionConverter.ConvertToken(bodyskillId);
                    bodypropCount++;
                }

                var inputParametersObject = new JObject();
                var inputParametersObjectpropCount = 0;
                if (inputParametersObjectpropCount > 0)
                {
                    body["InputParameters"] = inputParametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrchestratorConnectorResponse>(BuildSourceInput);
        }
    }

    public class CopilotforserviceTriggers([ConnectionName] string connectionId)
    {
    }

    public class OrchestratorConnectorResponse
    {
        [JsonProperty("results")]
        public ConnectorDynamicTemplateContainerBase[] Results { get; set; }

        [JsonProperty("metadata")]
        public OrchestratorExecutionMetadata Metadata { get; set; }

        [JsonProperty("templates")]
        public JToken Templates { get; set; }
    }

    public class ConnectorDynamicTemplateContainerBase
    {
        [JsonProperty("containerType")]
        public string ContainerType { get; set; }

        [JsonProperty("dynamicTemplatesPath")]
        public string DynamicTemplatesPath { get; set; }

        [JsonProperty("previewCardTitle")]
        public string PreviewCardTitle { get; set; }

        [JsonProperty("previewCardSubtitle")]
        public string PreviewCardSubtitle { get; set; }

        [JsonProperty("previewCardUrl")]
        public string PreviewCardUrl { get; set; }
    }

    public class OrchestratorExecutionMetadata
    {
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("retrievedSkills")]
        public OrchestratorSkillMetadata[] RetrievedSkills { get; set; }

        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }
    }

    public class OrchestratorSkillMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameters")]
        public OrchestratorSkillMetadataParameter[] Parameters { get; set; }

        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }
    }

    public class OrchestratorSkillMetadataParameter
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isMandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("allowedValues")]
        public JToken[] AllowedValues { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Copilotforservice;

    public partial class WorkflowManagedActions
    {
        public CopilotforserviceActions Copilotforservice(string connectionId) => new CopilotforserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CopilotforserviceTriggers Copilotforservice(string connectionId) => new CopilotforserviceTriggers(connectionId);
    }
}