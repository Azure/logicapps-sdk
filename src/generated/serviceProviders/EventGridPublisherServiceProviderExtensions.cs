//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventGridPublisher
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventGridPublisherActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventGridPublisher")]
        public IOutputWorkflowAction<JToken> PublishEvents(Expression<Func<PublishEventsEventsTypeItem[]>> events)
        {
            var parameters = new JObject();
            parameters["events"] = ExpressionConverter.ConvertO(events);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventGridPublisher", operationId: "publishEvents", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }
    }

    public class EventGridPublisherTriggers([ConnectionName] string connectionId)
    {
    }

    public class PublishEventsEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("data")]
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

    public partial class WorkflowServiceProviderTriggers
    {
        public EventGridPublisherTriggers EventGridPublisher(string connectionId) => new EventGridPublisherTriggers(connectionId);
    }
}