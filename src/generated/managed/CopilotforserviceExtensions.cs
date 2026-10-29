//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Copilotforservice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CopilotforserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copilotforservice")]
        public IBodyWorkflowAction<OrchestratorConnectorResponse, ApiConnectionActionConfiguration> NaturalQueryTextSearch(Expression<Func<NaturalQueryTextSearchInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<OrchestratorConnectorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/orchestrator/connector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrchestratorConnectorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "copilotforservice")]
        public IBodyWorkflowAction<OrchestratorConnectorResponse, ApiConnectionActionConfiguration> ExecuteSkill(Expression<Func<ExecuteSkillInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<OrchestratorConnectorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/orchestrator/executeSkill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrchestratorConnectorResponse>(callPayload);
            });
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

    public class NaturalQueryTextSearchInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }
    }

    public class ExecuteSkillInput
    {
        public string SkillId { get; set; }
        public JToken InputParameters { get; set; }
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