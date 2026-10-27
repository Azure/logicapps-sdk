//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Forcemanagercrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ForcemanagercrmActions([ConnectionName] string connectionId)
    {
    }

    public class ForcemanagercrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> CreateAccountWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/accounts/hooks/insert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateAccountWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> UpdateAccountWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/accounts/hooks/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new UpdateAccountWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> CreateContactWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/contacts/hooks/insert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateContactWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> UpdateContactWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/contacts/hooks/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new UpdateContactWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> CreateOpportunityWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/opportunities/hooks/insert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateOpportunityWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> UpdateOpportunityWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/opportunities/hooks/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new UpdateOpportunityWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> CreateSalesOrderWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/salesorders/hooks/insert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateSalesOrderWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> UpdateSalesOrderWebhook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/salesorders/hooks/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new UpdateSalesOrderWebhookInput().ToJToken();
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebhookResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("user_created")]
        public int UserCreated { get; set; }

        [JsonProperty("user_updated")]
        public string UserUpdated { get; set; }

        [JsonProperty("user_deleted")]
        public string UserDeleted { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public string DateUpdated { get; set; }

        [JsonProperty("date_deleted")]
        public string DateDeleted { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class CreateAccountWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Account";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "insert";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "account";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class UpdateAccountWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Account";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "update";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "account";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateContactWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Contact";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "insert";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "contact";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class UpdateContactWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Contact";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "update";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "contact";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateOpportunityWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Opportunity";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "insert";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "opportunity";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class UpdateOpportunityWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Opportunity";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "update";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "opportunity";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateSalesOrderWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Sales Order";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "insert";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "salesorder";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class UpdateSalesOrderWebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Webhook - Insert Sales Order";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "update";

        [JsonProperty("entity", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Entity { get; set; } = "salesorder";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Forcemanagercrm;

    public partial class WorkflowManagedActions
    {
        public ForcemanagercrmActions Forcemanagercrm(string connectionId) => new ForcemanagercrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ForcemanagercrmTriggers Forcemanagercrm(string connectionId) => new ForcemanagercrmTriggers(connectionId);
    }
}