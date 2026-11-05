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
        public IBodyWorkflowAction<StepOutput, ApiConnectionActionConfiguration> ExecuteStep(Expression<Func<string>> moduleId, Expression<Func<string>> stepId, Expression<Func<ExecuteStepInput>> input)
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
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreateValidateWebhook(Expression<Func<CreateValidateWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/webhooksValidate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreatePublishWebhook(Expression<Func<CreatePublishWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/webhooksPublish";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreateGenericWebhook(Expression<Func<CreateGenericWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/webhooksGeneric";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
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
        public Variable[] Outputs { get; set; }
    }

    public class Variable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }
    }

    public class ExecuteStepInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public Variable2[] Inputs { get; set; }
    }

    public class Variable2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class CreateValidateWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Validate Webhook From Power Automate";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("resourcePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourcePath { get; set; } = "/";

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateValidateWebhookInputStateType State { get; set; } = CreateValidateWebhookInputStateType.Success;

        [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateValidateWebhookInputConditionType Condition { get; set; } = new CreateValidateWebhookInputConditionType();

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateValidateWebhookInputCallbackType Callback { get; set; } = new CreateValidateWebhookInputCallbackType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateValidateWebhookInputStateType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure
    }

    public class CreateValidateWebhookInputConditionType
    {
        [JsonProperty("callbackContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackContentType { get; set; } = "application/vnd.sas.webhook.callback.validate";
    }

    public class CreateValidateWebhookInputCallbackType
    {
        [JsonProperty("uri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Uri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreatePublishWebhookInput
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
        internal CreatePublishWebhookInputConditionType Condition { get; set; } = new CreatePublishWebhookInputConditionType();

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreatePublishWebhookInputCallbackType Callback { get; set; } = new CreatePublishWebhookInputCallbackType();
    }

    public class CreatePublishWebhookInputConditionType
    {
        [JsonProperty("callbackContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackContentType { get; set; } = "application/vnd.sas.webhook.callback.publish";
    }

    public class CreatePublishWebhookInputCallbackType
    {
        [JsonProperty("uri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Uri { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateGenericWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Generic Webhook From Power Automate";

        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGenericWebhookInputConditionType Condition { get; set; } = new CreateGenericWebhookInputConditionType();

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateGenericWebhookInputCallbackType Callback { get; set; } = new CreateGenericWebhookInputCallbackType();
    }

    public class CreateGenericWebhookInputConditionType
    {
        [JsonProperty("callbackContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CallbackContentType { get; set; } = "application/vnd.sas.webhook.callback.publish";

        [JsonProperty("callbackContentFilter")]
        public string CallbackContentFilter { get; set; }
    }

    public class CreateGenericWebhookInputCallbackType
    {
        [JsonProperty("uri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Uri { get; set; } = "#{listCallbackUrl()}";
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