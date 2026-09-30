//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Securitycopilot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecuritycopilotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "securitycopilot")]
        public IBodyWorkflowAction<ExecutionDetail> ExecuteAgent([WorkflowExpression] Func<string> agentId, [WorkflowExpression] Func<string> triggerName, [WorkflowExpression] Func<object> agentInputsinputs = null)
        {
            SourceExpression.Validate(agentId, nameof(agentId), required: true);
            SourceExpression.Validate(triggerName, nameof(triggerName), required: true);
            SourceExpression.Validate(agentInputsinputs, nameof(agentInputsinputs), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/agents/{0}/triggers/{1}/execute", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(agentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(triggerName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var agentInputs = new JObject();
                var agentInputspropCount = 0;
                if (agentInputsinputs != null)
                {
                    agentInputs["Inputs"] = SourceExpressionConverter.ConvertToken(agentInputsinputs);
                    agentInputspropCount++;
                }

                if (agentInputspropCount > 0)
                {
                    callPayload.Body = agentInputs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExecutionDetail>(BuildSourceInput);
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

    public enum ExecutionStatus
    {
        Pending,
        InProgress,
        Completed,
        Failed
    }

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