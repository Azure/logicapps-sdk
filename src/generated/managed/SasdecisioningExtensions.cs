//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sasdecisioning
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SasdecisioningActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sasdecisioning")]
        public IBodyWorkflowAction<StepOutput, ApiConnectionActionConfiguration> ExecuteStep(Expression<Func<string>> moduleId, Expression<Func<string>> stepId, Expression<Func<InputInput>> input)
        {
            var __workflow_moduleId = WorkflowExpression.Compile(moduleId, nameof(moduleId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<StepOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/microanalyticScore/modules/{0}/steps/{1}", __workflow_moduleId.WithUrlEncoding(1), __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<StepOutput>(callPayload);
            });
        }
    }

    public class SasdecisioningTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateValidateWebhook(Expression<Func<CreateValidateWebhookBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/webhooksValidate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreatePublishWebhook(Expression<Func<CreatePublishWebhookBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/webhooksPublish";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> CreateGenericWebhook(Expression<Func<CreateGenericWebhookBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/webhooksGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }
    }

    public class StepOutput
    {
        [JsonProperty("moduleId")]
        public string ModuleId { get; set; }

        [JsonProperty("stepId")]
        public string StepId { get; set; }

        [JsonProperty("outputs")]
        public ExecuteStepVariableResponse[] Outputs { get; set; }
    }

    public class ExecuteStepVariableResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }
    }

    public class InputInput
    {
        public InputInput(ExecuteStepVariable[] inputs)
        {
            this.Inputs = inputs;
        }

        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExecuteStepVariable[] Inputs { get; set; }
    }

    public class ExecuteStepVariable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class CreateValidateWebhookBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Validate Webhook From Power Automate";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("resourcePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourcePath { get; set; } = "/";

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputStateType State { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Sasdecisioning.BodyInputStateType.Success;

        [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateValidateWebhookBodyInputConditionType Condition { get; set; } = new CreateValidateWebhookBodyInputConditionType();

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputCallbackType Callback { get; set; } = new BodyInputCallbackType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStateType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure
    }

    public class CreateValidateWebhookBodyInputConditionType
    {
        [JsonProperty("callbackContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackContentType { get; set; } = "application/vnd.sas.webhook.callback.validate";
    }

    public class BodyInputCallbackType
    {
        [JsonProperty("uri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Uri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreatePublishWebhookBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Publish Webhook From Power Automate";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("resourcePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourcePath { get; set; } = "/";

        [JsonProperty("destinationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationType { get; set; } = "microAnalyticService";

        [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreatePublishWebhookBodyInputConditionType Condition { get; set; } = new CreatePublishWebhookBodyInputConditionType();

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputCallbackType Callback { get; set; } = new BodyInputCallbackType();
    }

    public class CreatePublishWebhookBodyInputConditionType
    {
        [JsonProperty("callbackContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackContentType { get; set; } = "application/vnd.sas.webhook.callback.publish";
    }

    public class CreateGenericWebhookBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Generic Webhook From Power Automate";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGenericWebhookBodyInputConditionType Condition { get; set; } = new CreateGenericWebhookBodyInputConditionType();

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputCallbackType Callback { get; set; } = new BodyInputCallbackType();
    }

    public class CreateGenericWebhookBodyInputConditionType
    {
        [JsonProperty("callbackContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CallbackContentType { get; set; } = "application/vnd.sas.webhook.callback.publish";

        [JsonProperty("callbackContentFilter")]
        public string CallbackContentFilter { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sasdecisioning;

    public partial class WorkflowManagedActions
    {
        public SasdecisioningActions Sasdecisioning(string connectionId) => new SasdecisioningActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SasdecisioningTriggers Sasdecisioning(string connectionId) => new SasdecisioningTriggers(connectionId);
    }
}