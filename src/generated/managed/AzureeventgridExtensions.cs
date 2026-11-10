//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureeventgridActions([ConnectionName] string connectionId)
    {
    }

    public class AzureeventgridTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateSubscription(Expression<Func<string>> subscriptionId, Expression<Func<string>> resourceType, Expression<Func<BodyInput>> body, Expression<Func<string>> subscriptionName = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_resourceType = WorkflowExpression.Compile(resourceType, nameof(resourceType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/providers/{1}/resource/eventSubscriptions", __workflow_subscriptionId.WithUrlEncoding(1), __workflow_resourceType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-api-version"] = Convert.ToString("2017-09-15-preview");
                if (__workflow_subscriptionName != null)
                    callPayload.Queries["subscriptionName"] = ExpressionConverter.Convert(__workflow_subscriptionName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class BodyInput
    {
        public BodyInput(BodyInputPropertiesType properties)
        {
            this.Properties = properties;
        }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesType Properties { get; set; }
    }

    public class BodyInputPropertiesType
    {
        public BodyInputPropertiesType(string resourceName)
        {
            this.ResourceName = resourceName;
        }

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourceName { get; set; }

        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesTypeDestinationType Destination { get; set; } = new BodyInputPropertiesTypeDestinationType();

        [JsonProperty("filter")]
        public BodyInputPropertiesTypeFilterType Filter { get; set; }
    }

    public class BodyInputPropertiesTypeDestinationType
    {
        [JsonProperty("endpointType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EndpointType { get; set; } = "webhook";

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
        [JsonProperty("subjectBeginsWith")]
        public string PrefixFilter { get; set; }

        [JsonProperty("subjectEndsWith")]
        public string SuffixFilter { get; set; }

        [JsonProperty("includedEventTypes")]
        public string[] EventType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid;

    public partial class WorkflowManagedActions
    {
        public AzureeventgridActions Azureeventgrid(string connectionId) => new AzureeventgridActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureeventgridTriggers Azureeventgrid(string connectionId) => new AzureeventgridTriggers(connectionId);
    }
}