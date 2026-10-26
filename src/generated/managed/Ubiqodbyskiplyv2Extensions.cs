//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiplyv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ubiqodbyskiplyv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Ubiqodbyskiplyv2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveDataFromTrackersResponseItem[], ApiConnectionTriggerConfiguration> ReceiveDataFromTrackers(Expression<Func<ReceiveDataFromTrackersInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ReceiveDataFromTrackersResponseItem[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/zapier/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ReceiveDataFromTrackersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ReceiveDataFromTrackersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ReceiveDataFromTrackersInput
    {
        [JsonProperty("hookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HookUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("dispatchType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string DispatchType { get; set; } = "POWERAUTOMATE";

        [JsonProperty("hookName")]
        public string HookName { get; set; }

        [JsonProperty("dispatchId")]
        public string DispatchId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ubiqodbyskiplyv2;

    public partial class WorkflowManagedActions
    {
        public Ubiqodbyskiplyv2Actions Ubiqodbyskiplyv2(string connectionId) => new Ubiqodbyskiplyv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ubiqodbyskiplyv2Triggers Ubiqodbyskiplyv2(string connectionId) => new Ubiqodbyskiplyv2Triggers(connectionId);
    }
}