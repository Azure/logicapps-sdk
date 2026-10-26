//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestevents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RamquesteventsActions([ConnectionName] string connectionId)
    {
    }

    public class RamquesteventsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CCEEventTrigger(Expression<Func<CCEEventTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register/cce";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> HorizonEventTrigger(Expression<Func<HorizonEventTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register/horizon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CCEEventTriggerInput
    {
        [JsonProperty("webHook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHook { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("action")]
        public CCEEventTriggerInputActionType? Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CCEEventTriggerInputActionType
    {
        TaskEvent,
        DocumentEvent,
        File,
        Commitment,
        CheckWriting
    }

    public class HorizonEventTriggerInput
    {
        [JsonProperty("webHook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHook { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("action")]
        public string Action { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestevents;

    public partial class WorkflowManagedActions
    {
        public RamquesteventsActions Ramquestevents(string connectionId) => new RamquesteventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RamquesteventsTriggers Ramquestevents(string connectionId) => new RamquesteventsTriggers(connectionId);
    }
}