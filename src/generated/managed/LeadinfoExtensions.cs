//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leadinfo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeadinfoActions([ConnectionName] string connectionId)
    {
    }

    public class LeadinfoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerCompanyResponse, ApiConnectionTriggerConfiguration> TriggerCompany(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TriggerCompanyResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Body = new TriggerCompanyInput().ToJToken();
                return new ApiConnectionTrigger<TriggerCompanyResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ShareContactResponse, ApiConnectionTriggerConfiguration> ShareContact(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ShareContactResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/share_contact";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Body = new ShareContactInput().ToJToken();
                return new ApiConnectionTrigger<ShareContactResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TriggerContactResponse, ApiConnectionTriggerConfiguration> TriggerContact(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TriggerContactResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/trigger_contact";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Body = new TriggerContactInput().ToJToken();
                return new ApiConnectionTrigger<TriggerContactResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ShareCompanyResponse, ApiConnectionTriggerConfiguration> ShareCompany(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ShareCompanyResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhook/share";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Body = new ShareCompanyInput().ToJToken();
                return new ApiConnectionTrigger<ShareCompanyResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TriggerCompanyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TriggerCompanyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "trigger";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("integration", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Integration { get; set; } = "microsoftpowerautomate";
    }

    public class ShareContactResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ShareContactInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "share_contact";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("integration", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Integration { get; set; } = "microsoftpowerautomate";
    }

    public class TriggerContactResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TriggerContactInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "trigger_contact";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("integration", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Integration { get; set; } = "microsoftpowerautomate";
    }

    public class ShareCompanyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ShareCompanyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "share";

        [JsonProperty("integration", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Integration { get; set; } = "microsoftpowerautomate";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Leadinfo;

    public partial class WorkflowManagedActions
    {
        public LeadinfoActions Leadinfo(string connectionId) => new LeadinfoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeadinfoTriggers Leadinfo(string connectionId) => new LeadinfoTriggers(connectionId);
    }
}