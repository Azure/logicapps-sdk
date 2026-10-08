//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventGridPublisher
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class EventGridPublisherActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventGridPublisher")]
        [WorkflowExpressionFactory(nameof(__BuildPublishEvents))]
        public IOutputWorkflowAction<JToken> PublishEvents([WorkflowExpression] Func<PublishEventsInputEventsTypeItem[]> events)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildPublishEvents(WorkflowExpression<PublishEventsInputEventsTypeItem[]> events)
        {
            WorkflowExpression.Validate(events, nameof(events), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["events"] = ExpressionConverter.ConvertO(events);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventGridPublisher", operationId: "publishEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }
    }

    public class PublishEventsInputEventsTypeItem
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("eventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventType { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }

        [JsonProperty("dataVersion")]
        public string DataVersion { get; set; }

        [JsonProperty("eventTime")]
        public string EventTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventGridPublisher;

    public partial class WorkflowServiceProviderActions
    {
        public EventGridPublisherActions EventGridPublisher(string connectionId) => new EventGridPublisherActions(connectionId);
    }
}