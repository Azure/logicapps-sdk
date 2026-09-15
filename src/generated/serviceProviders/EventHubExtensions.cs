//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventHub
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class EventHubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> SendEvent(Expression<Func<string>> eventHubName, Expression<Func<SendEventInputEventDataType>> eventData, Expression<Func<string>> partitionKey = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = CSharpExpressionConverter.ConvertToken(eventHubName);
            serviceProviderParameters["eventData"] = CSharpExpressionConverter.ConvertToken(eventData);
            if (partitionKey != null)
            {
                serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvent", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> SendEvents(Expression<Func<string>> eventHubName, Expression<Func<SendEventsInputEventDatasTypeItem[]>> eventDatas, Expression<Func<string>> partitionKey = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = CSharpExpressionConverter.ConvertToken(eventHubName);
            serviceProviderParameters["eventDatas"] = CSharpExpressionConverter.ConvertToken(eventDatas);
            if (partitionKey != null)
            {
                serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvents", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> ReplicateEvents(Expression<Func<string>> eventHubName, Expression<Func<bool>> skipAlreadyReplicated)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = CSharpExpressionConverter.ConvertToken(eventHubName);
            serviceProviderParameters["skipAlreadyReplicated"] = CSharpExpressionConverter.ConvertToken(skipAlreadyReplicated);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "replicateEvents", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }
    }

    public class EventHubTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveEventsOutputItem[]> ReceiveEvents(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = CSharpExpressionConverter.ConvertToken(eventHubName);
            if (consumerGroup != null)
            {
                serviceProviderParameters["consumerGroup"] = CSharpExpressionConverter.ConvertToken(consumerGroup);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEvents", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveEventsOutputItem[]>(serviceProviderInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveEventsForReplication(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = CSharpExpressionConverter.ConvertToken(eventHubName);
            if (consumerGroup != null)
            {
                serviceProviderParameters["consumerGroup"] = CSharpExpressionConverter.ConvertToken(consumerGroup);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEventsForReplication", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputTrigger<JToken>(serviceProviderInput);
        }
    }

    public class ReceiveEventsOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }

    public class SendEventInputEventDataType
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }
        public JToken Properties { get; set; }
    }

    public class SendEventsInputEventDatasTypeItem
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