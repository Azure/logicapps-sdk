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
            serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            serviceProviderParameters["eventData"] = ExpressionConverter.ConvertO(eventData);
            if (partitionKey != null)
            {
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/eventHub", "sendEvent", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> SendEvents(Expression<Func<string>> eventHubName, Expression<Func<SendEventsInputEventDatasTypeItem[]>> eventDatas, Expression<Func<string>> partitionKey = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            serviceProviderParameters["eventDatas"] = ExpressionConverter.ConvertO(eventDatas);
            if (partitionKey != null)
            {
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/eventHub", "sendEvents", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> ReplicateEvents(Expression<Func<string>> eventHubName, Expression<Func<bool>> skipAlreadyReplicated)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            serviceProviderParameters["skipAlreadyReplicated"] = ExpressionConverter.ConvertO(skipAlreadyReplicated);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/eventHub", "replicateEvents", connectionId),
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
            serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            if (consumerGroup != null)
            {
                serviceProviderParameters["consumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/eventHub", "receiveEvents", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveEventsOutputItem[]>(serviceProviderInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveEventsForReplication(Expression<Func<string>> eventHubName, Expression<Func<string>> consumerGroup = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
            if (consumerGroup != null)
            {
                serviceProviderParameters["consumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/eventHub", "receiveEventsForReplication", connectionId),
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