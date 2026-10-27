//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Slascone
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SlasconeActions([ConnectionName] string connectionId)
    {
    }

    public class SlasconeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookRegistrationDto, ApiConnectionTriggerConfiguration> CreateCustomerTrigger(Expression<Func<string>> isvId, FlowRecurrence recurrence = null)
        {
            var __workflow_isvId = WorkflowExpression.Compile(isvId, nameof(isvId), required: true);
            return new DeferredBodyTrigger<WebHookRegistrationDto, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/WebhookRegistration/isv/{0}", __workflow_isvId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateCustomerTriggerInput().ToJToken();
                return new ApiConnectionTrigger<WebHookRegistrationDto>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebHookRegistrationDto
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("createdDateUtc")]
        public string CreatedDateUtc { get; set; }

        [JsonProperty("events")]
        public WebHookRegistrationDtoEventsTypeItem[] Events { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum WebHookRegistrationDtoEventsTypeItem
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _14 = 14
    }

    public class CreateCustomerTriggerInput
    {
        [JsonProperty("active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCustomerTriggerInputEventsTypeItem[] Events { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "msflow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public enum CreateCustomerTriggerInputEventsTypeItem
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _14 = 14
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Slascone;

    public partial class WorkflowManagedActions
    {
        public SlasconeActions Slascone(string connectionId) => new SlasconeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SlasconeTriggers Slascone(string connectionId) => new SlasconeTriggers(connectionId);
    }
}