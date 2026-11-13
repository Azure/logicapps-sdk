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
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CCEEventTrigger(Expression<Func<CCEEventTriggerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register/cce";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> HorizonEventTrigger(Expression<Func<HorizonEventTriggerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/register/horizon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class CCEEventTriggerBodyInput
    {
        [JsonProperty("webHook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHook { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("action")]
        public BodyInputActionType? Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActionType
    {
        TaskEvent,
        DocumentEvent,
        File,
        Commitment,
        CheckWriting
    }

    public class HorizonEventTriggerBodyInput
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