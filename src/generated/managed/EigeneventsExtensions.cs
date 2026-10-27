//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eigenevents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EigeneventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eigenevents")]
        public IBodyWorkflowAction<SupportedEventsBody, ApiConnectionActionConfiguration> GetSupportedEvents()
        {
            return new DeferredBodyAction<SupportedEventsBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events/api/events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SupportedEventsBody>(callPayload);
            });
        }
    }

    public class EigeneventsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhook(Expression<Func<double>> eventIds, Expression<Func<CreateWebhookInput>> bodyOfTriggerRequest, FlowRecurrence recurrence = null)
        {
            var __workflow_eventIds = WorkflowExpression.Compile(eventIds, nameof(eventIds), required: true);
            var __workflow_bodyOfTriggerRequest = WorkflowExpression.Compile(bodyOfTriggerRequest, nameof(bodyOfTriggerRequest), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/events/api/webhook/{0}", __workflow_eventIds.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_bodyOfTriggerRequest);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SupportedEventsBody
    {
        [JsonProperty("events")]
        public SupportedEventsBodyEventsTypeItem[] Events { get; set; }
    }

    public class SupportedEventsBodyEventsTypeItem
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("success")]
        public bool WebhookCreated { get; set; }

        [JsonProperty("description")]
        public string OperationSucceeded { get; set; }

        [JsonProperty("value")]
        public WebhookCreationResponseValueType Value { get; set; }
    }

    public class WebhookCreationResponseValueType
    {
        [JsonProperty("webhookId")]
        public string WebhookId { get; set; }
    }

    public class CreateWebhookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Eigenevents;

    public partial class WorkflowManagedActions
    {
        public EigeneventsActions Eigenevents(string connectionId) => new EigeneventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EigeneventsTriggers Eigenevents(string connectionId) => new EigeneventsTriggers(connectionId);
    }
}