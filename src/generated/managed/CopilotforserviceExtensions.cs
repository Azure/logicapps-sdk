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
        public IBodyWorkflowAction<OrchestratorConnectorResponse> NaturalQueryTextSearch(Expression<Func<string>> bodyprompt = null)
        {
            var apiCallPath = "/api/orchestrator/connector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyprompt != null)
            {
                body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OrchestratorConnectorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copilotforservice")]
        public IBodyWorkflowAction<OrchestratorConnectorResponse> ExecuteSkill(Expression<Func<string>> bodyskillId = null)
        {
            var apiCallPath = "/api/orchestrator/executeSkill";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyskillId != null)
            {
                body["SkillId"] = ExpressionConverter.ConvertO(bodyskillId);
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

            return new ApiConnectionAction<OrchestratorConnectorResponse>(callPayload);
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