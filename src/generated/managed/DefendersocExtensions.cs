//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Defendersoc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DefendersocActions([ConnectionName] string connectionId)
    {
    }

    public class DefendersocTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenDefenderOrSentinelAlertCreated()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/alerts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenDefenderCaseCreatedOrUpdated()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/cases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class BodyInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Defendersoc;

    public partial class WorkflowManagedActions
    {
        public DefendersocActions Defendersoc(string connectionId) => new DefendersocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DefendersocTriggers Defendersoc(string connectionId) => new DefendersocTriggers(connectionId);
    }
}