//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.EventHub
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class EventHubActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        [WorkflowExpressionFactory(nameof(__BuildSendEvent))]
        public IOutputWorkflowAction<JToken> SendEvent([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<SendEventInputEventDataType> eventData, [WorkflowExpression] Func<string> partitionKey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildSendEvent(WorkflowExpression<string> eventHubName, WorkflowExpression<SendEventInputEventDataType> eventData, WorkflowExpression<string> partitionKey = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(eventData, nameof(eventData), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        [WorkflowExpressionFactory(nameof(__BuildSendEvents))]
        public IOutputWorkflowAction<JToken> SendEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<SendEventsInputEventDatasTypeItem[]> eventDatas, [WorkflowExpression] Func<string> partitionKey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildSendEvents(WorkflowExpression<string> eventHubName, WorkflowExpression<SendEventsInputEventDatasTypeItem[]> eventDatas, WorkflowExpression<string> partitionKey = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(eventDatas, nameof(eventDatas), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        [WorkflowExpressionFactory(nameof(__BuildReplicateEvents))]
        public IOutputWorkflowAction<JToken> ReplicateEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<bool> skipAlreadyReplicated)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildReplicateEvents(WorkflowExpression<string> eventHubName, WorkflowExpression<bool> skipAlreadyReplicated)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(skipAlreadyReplicated, nameof(skipAlreadyReplicated), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
                serviceProviderParameters["skipAlreadyReplicated"] = ExpressionConverter.ConvertO(skipAlreadyReplicated);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "replicateEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }
    }

    public class EventHubTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildReceiveEvents))]
        public IBodyWorkflowTrigger<ReceiveEventsOutputItem[]> ReceiveEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> consumerGroup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveEventsOutputItem[]> __BuildReceiveEvents(WorkflowExpression<string> eventHubName, WorkflowExpression<string> consumerGroup = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(consumerGroup, nameof(consumerGroup), required: false);
            return new DeferredBodyTrigger<ReceiveEventsOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
                if (consumerGroup != null)
                {
                    serviceProviderParameters["consumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveEventsOutputItem[]>(serviceProviderInput);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildReceiveEventsForReplication))]
        public IOutputWorkflowTrigger<JToken> ReceiveEventsForReplication([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> consumerGroup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowTrigger<JToken> __BuildReceiveEventsForReplication(WorkflowExpression<string> eventHubName, WorkflowExpression<string> consumerGroup = null)
        {
            WorkflowExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            WorkflowExpression.Validate(consumerGroup, nameof(consumerGroup), required: false);
            return new DeferredOutputTrigger<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = ExpressionConverter.ConvertO(eventHubName);
                if (consumerGroup != null)
                {
                    serviceProviderParameters["consumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEventsForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputTrigger<JToken>(serviceProviderInput);
            });
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