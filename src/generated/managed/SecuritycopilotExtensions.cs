//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securitycopilot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecuritycopilotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securitycopilot")]
        public IBodyWorkflowAction<ExecutionDetail, ApiConnectionActionConfiguration> ExecuteAgent(Expression<Func<string>> agentId, Expression<Func<string>> triggerName, Expression<Func<ExecuteAgentInput>> agentInputs = null)
        {
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_triggerName = WorkflowExpression.Compile(triggerName, nameof(triggerName), required: true);
            var __workflow_agentInputs = WorkflowExpression.Compile(agentInputs, nameof(agentInputs), required: false);
            return new DeferredBodyAction<ExecutionDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/triggers/{1}/execute", __workflow_agentId.WithUrlEncoding(1), __workflow_triggerName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_agentInputs != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_agentInputs);
                return new ApiConnectionAction<ExecutionDetail>(callPayload);
            });
        }
    }

    public class SecuritycopilotTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExecutionDetail
    {
        [JsonProperty("status")]
        public ExecutionStatus Status { get; set; }

        [JsonProperty("numRuns")]
        public int NumRuns { get; set; }

        [JsonProperty("runIds")]
        public string[] RunIds { get; set; }

        [JsonProperty("fetchSkillInputs")]
        public JToken FetchSkillInputs { get; set; }

        [JsonProperty("processSkillInputs")]
        public JToken ProcessSkillInputs { get; set; }

        [JsonProperty("executionId")]
        public string ExecutionId { get; set; }

        [JsonProperty("identityId")]
        public string IdentityId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("promptId")]
        public string PromptId { get; set; }

        [JsonProperty("evaluationId")]
        public string EvaluationId { get; set; }

        [JsonProperty("fetchSkillsetName")]
        public string FetchSkillsetName { get; set; }

        [JsonProperty("fetchSkillName")]
        public string FetchSkillName { get; set; }

        [JsonProperty("processSkillsetName")]
        public string ProcessSkillsetName { get; set; }

        [JsonProperty("processSkillName")]
        public string ProcessSkillName { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("executionType")]
        public ExecutionType ExecutionType { get; set; }

        [JsonProperty("error")]
        public ErrorDetailResponse Error { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExecutionStatus
    {
        Pending,
        InProgress,
        Completed,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExecutionType
    {
        Manual,
        Automated
    }

    public class ErrorDetailResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("details")]
        public ErrorDetailResponse[] Details { get; set; }

        [JsonProperty("innerError")]
        public MedeinaInnerError InnerError { get; set; }
    }

    public class MedeinaInnerError
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("innererror")]
        public MedeinaInnerError Innererror { get; set; }

        [JsonProperty("userMessage")]
        public string UserMessage { get; set; }

        [JsonProperty("evaluationId")]
        public string EvaluationId { get; set; }

        [JsonProperty("promptId")]
        public string PromptId { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("retryable")]
        public bool Retryable { get; set; }
    }

    public class ExecuteAgentInput
    {
        public JToken Inputs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Securitycopilot;

    public partial class WorkflowManagedActions
    {
        public SecuritycopilotActions Securitycopilot(string connectionId) => new SecuritycopilotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecuritycopilotTriggers Securitycopilot(string connectionId) => new SecuritycopilotTriggers(connectionId);
    }
}