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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FlicButtonTrigger(Expression<Func<string>> buttonUuid, Expression<Func<FlicButtonTriggerInput>> requestBodyOfWebhook, FlowRecurrence recurrence = null)
        {
            var __workflow_buttonUuid = WorkflowExpression.Compile(buttonUuid, nameof(buttonUuid), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/msflow/subscribe/{0}", __workflow_buttonUuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FlicTaskTrigger(Expression<Func<string>> taskUuid, Expression<Func<FlicTaskTriggerInput>> requestBodyOfWebhook = null, FlowRecurrence recurrence = null)
        {
            var __workflow_taskUuid = WorkflowExpression.Compile(taskUuid, nameof(taskUuid), required: true);
            var __workflow_requestBodyOfWebhook = WorkflowExpression.Compile(requestBodyOfWebhook, nameof(requestBodyOfWebhook), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/msflow/subscribe/{0}", __workflow_taskUuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestBodyOfWebhook != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhook);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class FlicButtonTriggerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public FlicButtonTriggerInputEventsType? Events { get; set; } = FlicButtonTriggerInputEventsType.Any;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FlicButtonTriggerInputEventsType
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

    public class FlicTaskTriggerInput
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