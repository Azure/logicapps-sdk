//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calendly
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CalendlyActions([ConnectionName] string connectionId)
    {
    }

    public class CalendlyTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> WebhookCreateInvitee()
        {
            return new DeferredBodyTrigger<string, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook1/api/v1/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<string>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> WebhookCancelInvitee()
        {
            return new DeferredBodyTrigger<string, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook2/api/v1/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<string>(callPayload);
            });
        }
    }

    public class BodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Calendly;

    public partial class WorkflowManagedActions
    {
        public CalendlyActions Calendly(string connectionId) => new CalendlyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CalendlyTriggers Calendly(string connectionId) => new CalendlyTriggers(connectionId);
    }
}