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
        public IOutputWorkflowAction<JToken> SendEvent([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<SendEventInputEventDataType> eventData, [WorkflowExpression] Func<string> partitionKey = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(eventData, nameof(eventData), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = SourceExpressionConverter.ConvertToken(eventHubName);
                serviceProviderParameters["eventData"] = SourceExpressionConverter.ConvertToken(eventData);
                if (partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvent", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> SendEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<SendEventsInputEventDatasTypeItem[]> eventDatas, [WorkflowExpression] Func<string> partitionKey = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(eventDatas, nameof(eventDatas), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = SourceExpressionConverter.ConvertToken(eventHubName);
                serviceProviderParameters["eventDatas"] = SourceExpressionConverter.ConvertToken(eventDatas);
                if (partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "sendEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "eventHub")]
        public IOutputWorkflowAction<JToken> ReplicateEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<bool> skipAlreadyReplicated)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(skipAlreadyReplicated, nameof(skipAlreadyReplicated), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = SourceExpressionConverter.ConvertToken(eventHubName);
                serviceProviderParameters["skipAlreadyReplicated"] = SourceExpressionConverter.ConvertToken(skipAlreadyReplicated);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "replicateEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }
    }

    public class EventHubTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveEventsOutputItem[]> ReceiveEvents([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> consumerGroup = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(consumerGroup, nameof(consumerGroup), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = SourceExpressionConverter.ConvertToken(eventHubName);
                if (consumerGroup != null)
                {
                    serviceProviderParameters["consumerGroup"] = SourceExpressionConverter.ConvertToken(consumerGroup);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEvents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveEventsOutputItem[]>(BuildSourceInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveEventsForReplication([WorkflowExpression] Func<string> eventHubName, [WorkflowExpression] Func<string> consumerGroup = null)
        {
            SourceExpression.Validate(eventHubName, nameof(eventHubName), required: true);
            SourceExpression.Validate(consumerGroup, nameof(consumerGroup), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["eventHubName"] = SourceExpressionConverter.ConvertToken(eventHubName);
                if (consumerGroup != null)
                {
                    serviceProviderParameters["consumerGroup"] = SourceExpressionConverter.ConvertToken(consumerGroup);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/eventHub", operationId: "receiveEventsForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputTrigger<JToken>(BuildSourceInput);
        }
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