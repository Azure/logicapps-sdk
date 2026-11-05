//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Peakboard
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PeakboardActions([ConnectionName] string connectionId)
    {
    }

    public class PeakboardTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenAlertIsSent(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/PowerAutomate/Subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Peakboard;

    public partial class WorkflowManagedActions
    {
        public PeakboardActions Peakboard(string connectionId) => new PeakboardActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PeakboardTriggers Peakboard(string connectionId) => new PeakboardTriggers(connectionId);
    }
}