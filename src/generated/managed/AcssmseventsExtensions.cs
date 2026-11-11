//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acssmsevents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcssmseventsActions([ConnectionName] string connectionId)
    {
    }

    public class AcssmseventsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateSmsReceivedEventSubscription(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceGroupName, Expression<Func<string>> resourceName, Expression<Func<BodyInput>> body)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceGroupName = WorkflowExpression.Compile(resourceGroupName, nameof(resourceGroupName), required: true);
            var __workflow_resourceName = WorkflowExpression.Compile(resourceName, nameof(resourceName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Communication/CommunicationServices/{2}/providers/Microsoft.EventGrid/eventSubscriptions", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceGroupName.WithUrlEncoding(1), __workflow_resourceName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2022-06-15");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class BodyInput
    {
        [JsonProperty("toPhoneNumbers")]
        public string[] FilterByToPhoneNumber { get; set; }

        [JsonProperty("fromPhoneNumbers")]
        public string[] FilterByFromPhoneNumber { get; set; }

        [JsonProperty("eventSubscriptionName")]
        public string EventSubscriptionName { get; set; }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesType Properties { get; set; } = new BodyInputPropertiesType();
    }

    public class BodyInputPropertiesType
    {
        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesTypeDestinationType Destination { get; set; } = new BodyInputPropertiesTypeDestinationType();

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesTypeFilterType Filter { get; set; } = new BodyInputPropertiesTypeFilterType();
    }

    public class BodyInputPropertiesTypeDestinationType
    {
        [JsonProperty("endpointType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EndpointType { get; set; } = "WebHook";

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesTypeDestinationTypePropertiesType Properties { get; set; } = new BodyInputPropertiesTypeDestinationTypePropertiesType();
    }

    public class BodyInputPropertiesTypeDestinationTypePropertiesType
    {
        [JsonProperty("endpointUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EndpointURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class BodyInputPropertiesTypeFilterType
    {
        [JsonProperty("includedEventTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] IncludedEventTypes { get; set; } = new string[]
        {
            "Microsoft.Communication.SMSReceived"
        };
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acssmsevents;

    public partial class WorkflowManagedActions
    {
        public AcssmseventsActions Acssmsevents(string connectionId) => new AcssmseventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcssmseventsTriggers Acssmsevents(string connectionId) => new AcssmseventsTriggers(connectionId);
    }
}