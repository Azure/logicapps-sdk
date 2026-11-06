//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flic
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlicActions([ConnectionName] string connectionId)
    {
    }

    public class FlicTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FlicButtonTrigger(Expression<Func<string>> buttonUuid, Expression<Func<FlicButtonTriggerRequestBodyOfWebhookInput>> requestBodyOfWebhook)
        {
            var __workflow_buttonUuid = WorkflowExpression.Compile(buttonUuid, nameof(buttonUuid), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/msflow/subscribe/{0}", __workflow_buttonUuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FlicTaskTrigger(Expression<Func<string>> taskUuid)
        {
            var __workflow_taskUuid = WorkflowExpression.Compile(taskUuid, nameof(taskUuid), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/msflow/subscribe/{0}", __workflow_taskUuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new FlicTaskTriggerRequestBodyOfWebhookInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class FlicButtonTriggerRequestBodyOfWebhookInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestBodyOfWebhookInputEventsType? Events { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Flic.RequestBodyOfWebhookInputEventsType.Any;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestBodyOfWebhookInputEventsType
    {
        [EnumMember(Value = "click")]
        Click,
        [EnumMember(Value = "double click")]
        DoubleClick,
        [EnumMember(Value = "hold")]
        Hold,
        [EnumMember(Value = "any")]
        Any
    }

    public class FlicTaskTriggerRequestBodyOfWebhookInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flic;

    public partial class WorkflowManagedActions
    {
        public FlicActions Flic(string connectionId) => new FlicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlicTriggers Flic(string connectionId) => new FlicTriggers(connectionId);
    }
}