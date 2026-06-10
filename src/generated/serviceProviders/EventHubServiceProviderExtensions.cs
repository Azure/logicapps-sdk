//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventHub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventHubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> SendEvent(Expression<Func<string>> eventHubName, Expression<Func<SendEventEventDataType>> eventData, Expression<Func<string>> partitionKey = null)
        {
            var parameters = new JObject();
            parameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            parameters["eventData"] = ExpressionConverter.ConvertO(eventData);
            if (partitionKey != null)
            {
                parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvent", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> SendEvents(Expression<Func<string>> eventHubName, Expression<Func<SendEventsEventDatasTypeItem[]>> eventDatas, Expression<Func<string>> partitionKey = null)
        {
            var parameters = new JObject();
            parameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            parameters["eventDatas"] = ExpressionConverter.ConvertO(eventDatas);
            if (partitionKey != null)
            {
                parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvents", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> ReplicateEvents(Expression<Func<string>> eventHubName, Expression<Func<bool>> skipAlreadyReplicated)
        {
            var parameters = new JObject();
            parameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            parameters["skipAlreadyReplicated"] = ExpressionConverter.ConvertO(skipAlreadyReplicated);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "replicateEvents", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }
    }

    public class EventHubTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveEventsOutputItem[]> ReceiveEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            if (consumerGroup != null)
            {
                parameters["consumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEvents", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<ReceiveEventsOutputItem[]>(input, triggerName);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveEventsForReplication(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            if (consumerGroup != null)
            {
                parameters["consumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEventsForReplication", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputTrigger<JToken>(input, triggerName);
        }
    }

    public class SendEventEventDataType
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }

    public class SendEventsEventDatasTypeItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }

    public class ReceiveEventsOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventHub;

    public partial class WorkflowServiceProviderActions
    {
        public EventHubActions EventHub(string connectionId) => new EventHubActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public EventHubTriggers EventHub(string connectionId) => new EventHubTriggers(connectionId);
    }
}