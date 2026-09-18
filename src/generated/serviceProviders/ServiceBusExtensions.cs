//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ServiceBusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> SendMessage([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<SendMessageInputMessageType> message)
        {
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["entityName"] = SourceExpressionConverter.ConvertToken(entityName);
                serviceProviderParameters["message"] = SourceExpressionConverter.ConvertToken(message);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "sendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> SendMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<SendMessagesInputMessagesTypeItem[]> messages)
        {
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(messages, nameof(messages), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["entityName"] = SourceExpressionConverter.ConvertToken(entityName);
                serviceProviderParameters["messages"] = SourceExpressionConverter.ConvertToken(messages);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "sendMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> ReplicateMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<bool> skipAlreadyReplicated)
        {
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(skipAlreadyReplicated, nameof(skipAlreadyReplicated), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["entityName"] = SourceExpressionConverter.ConvertToken(entityName);
                serviceProviderParameters["skipAlreadyReplicated"] = SourceExpressionConverter.ConvertToken(skipAlreadyReplicated);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "replicateMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CompleteQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> AbandonQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeadLetterQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            SourceExpression.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            SourceExpression.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                if (deadLetterReason != null)
                {
                    serviceProviderParameters["deadLetterReason"] = SourceExpressionConverter.ConvertToken(deadLetterReason);
                }

                if (deadLetterErrorDescription != null)
                {
                    serviceProviderParameters["deadLetterErrorDescription"] = SourceExpressionConverter.ConvertToken(deadLetterErrorDescription);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewLockQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewLockQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeferQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueV2Output> GetDeferredMessageFromQueueV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sequenceNumber)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["sequenceNumber"] = SourceExpressionConverter.ConvertToken(sequenceNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromQueueV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetDeferredMessageFromQueueV2Output>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromQueueV2OutputItem[]> GetMessagesFromQueueV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessages = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(maxMessages, nameof(maxMessages), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = SourceExpressionConverter.ConvertToken(maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromQueueV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetMessagesFromQueueV2OutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CompleteTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> AbandonTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeadLetterTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            SourceExpression.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            SourceExpression.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                if (deadLetterReason != null)
                {
                    serviceProviderParameters["deadLetterReason"] = SourceExpressionConverter.ConvertToken(deadLetterReason);
                }

                if (deadLetterErrorDescription != null)
                {
                    serviceProviderParameters["deadLetterErrorDescription"] = SourceExpressionConverter.ConvertToken(deadLetterErrorDescription);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewLockTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewLockTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeferTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicV2Output> GetDeferredMessageFromTopicV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sequenceNumber)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["sequenceNumber"] = SourceExpressionConverter.ConvertToken(sequenceNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromTopicV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetDeferredMessageFromTopicV2Output>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromTopicV2OutputItem[]> GetMessagesFromTopicV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessages = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(maxMessages, nameof(maxMessages), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = SourceExpressionConverter.ConvertToken(maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromTopicV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetMessagesFromTopicV2OutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CreateTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> topicSubscriptionName, [WorkflowExpression] Func<CreateTopicSubscriptionInputTopicSubscriptionFilterTypeType> topicSubscriptionFilterType, [WorkflowExpression] Func<object> topicSubscriptionCorrelationFilter = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(topicSubscriptionName, nameof(topicSubscriptionName), required: true);
            SourceExpression.Validate(topicSubscriptionFilterType, nameof(topicSubscriptionFilterType), required: true);
            SourceExpression.Validate(topicSubscriptionCorrelationFilter, nameof(topicSubscriptionCorrelationFilter), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["topicSubscriptionName"] = SourceExpressionConverter.ConvertToken(topicSubscriptionName);
                serviceProviderParameters["topicSubscriptionFilterType"] = SourceExpressionConverter.ConvertToken(topicSubscriptionFilterType);
                if (topicSubscriptionCorrelationFilter != null)
                {
                    serviceProviderParameters["topicSubscriptionCorrelationFilter"] = SourceExpressionConverter.ConvertToken(topicSubscriptionCorrelationFilter);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "createTopicSubscription", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeleteTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> topicSubscriptionName)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(topicSubscriptionName, nameof(topicSubscriptionName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["topicSubscriptionName"] = SourceExpressionConverter.ConvertToken(topicSubscriptionName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deleteTopicSubscription", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CompleteMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = SourceExpressionConverter.ConvertToken(messageId);
                if (lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> AbandonMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = SourceExpressionConverter.ConvertToken(messageId);
                if (lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeadLetterMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: false);
            SourceExpression.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            SourceExpression.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = SourceExpressionConverter.ConvertToken(messageId);
                if (lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                }

                if (deadLetterReason != null)
                {
                    serviceProviderParameters["deadLetterReason"] = SourceExpressionConverter.ConvertToken(deadLetterReason);
                }

                if (deadLetterErrorDescription != null)
                {
                    serviceProviderParameters["deadLetterErrorDescription"] = SourceExpressionConverter.ConvertToken(deadLetterErrorDescription);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeferMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(lockToken, nameof(lockToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = SourceExpressionConverter.ConvertToken(messageId);
                if (lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = SourceExpressionConverter.ConvertToken(lockToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueSessionOutput> GetDeferredMessageFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sequenceNumber, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["sequenceNumber"] = SourceExpressionConverter.ConvertToken(sequenceNumber);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                if (acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = SourceExpressionConverter.ConvertToken(acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetDeferredMessageFromQueueSessionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicSessionOutput> GetDeferredMessageFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sequenceNumber, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["sequenceNumber"] = SourceExpressionConverter.ConvertToken(sequenceNumber);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                if (acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = SourceExpressionConverter.ConvertToken(acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetDeferredMessageFromTopicSessionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromQueueSessionOutputItem[]> GetMessagesFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<int> maxMessages = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(maxMessages, nameof(maxMessages), required: false);
            SourceExpression.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                if (maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = SourceExpressionConverter.ConvertToken(maxMessages);
                }

                if (acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = SourceExpressionConverter.ConvertToken(acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetMessagesFromQueueSessionOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromTopicSessionOutputItem[]> GetMessagesFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<int> maxMessages = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(maxMessages, nameof(maxMessages), required: false);
            SourceExpression.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                if (maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = SourceExpressionConverter.ConvertToken(maxMessages);
                }

                if (acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = SourceExpressionConverter.ConvertToken(acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetMessagesFromTopicSessionOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CloseQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "closeQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CloseTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "closeTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }
    }

    public class ServiceBusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutputItem[]> ReceiveQueueMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            SourceExpression.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = SourceExpressionConverter.ConvertToken(isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = SourceExpressionConverter.ConvertToken(maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveQueueMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveQueueMessagesOutputItem[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<ReceiveTopicMessagesOutputItem[]> ReceiveTopicMessages([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            SourceExpression.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = SourceExpressionConverter.ConvertToken(isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = SourceExpressionConverter.ConvertToken(maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveTopicMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveTopicMessagesOutputItem[]>(BuildSourceInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveQueueMessagesForReplication([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            SourceExpression.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = SourceExpressionConverter.ConvertToken(isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = SourceExpressionConverter.ConvertToken(maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveQueueMessagesForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputTrigger<JToken>(BuildSourceInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveTopicMessagesForReplication([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            SourceExpression.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = SourceExpressionConverter.ConvertToken(isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = SourceExpressionConverter.ConvertToken(maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveTopicMessagesForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputTrigger<JToken>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<PeekLockQueueMessagesV2OutputItem[]> PeekLockQueueMessagesV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = SourceExpressionConverter.ConvertToken(maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "peekLockQueueMessagesV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<PeekLockQueueMessagesV2OutputItem[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<PeekLockTopicMessagesV2OutputItem[]> PeekLockTopicMessagesV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = SourceExpressionConverter.ConvertToken(maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "peekLockTopicMessagesV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<PeekLockTopicMessagesV2OutputItem[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromQueueSessionOutputItem[]> OnNewMessagesFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(maxMessages, nameof(maxMessages), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                if (maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = SourceExpressionConverter.ConvertToken(maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onNewMessagesFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<OnNewMessagesFromQueueSessionOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromTopicSessionOutputItem[]> OnNewMessagesFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(maxMessages, nameof(maxMessages), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                if (maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = SourceExpressionConverter.ConvertToken(maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onNewMessagesFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<OnNewMessagesFromTopicSessionOutputItem[]>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromQueueSessionOutput> OnSingleNewMessageFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onSingleNewMessageFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<OnSingleNewMessageFromQueueSessionOutput>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromTopicSessionOutput> OnSingleNewMessageFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["subscriptionName"] = SourceExpressionConverter.ConvertToken(subscriptionName);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onSingleNewMessageFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<OnSingleNewMessageFromTopicSessionOutput>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }
    }

    public class ReceiveQueueMessagesOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class ReceiveTopicMessagesOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class PeekLockQueueMessagesV2OutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class PeekLockTopicMessagesV2OutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class OnNewMessagesFromQueueSessionOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class OnNewMessagesFromTopicSessionOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class OnSingleNewMessageFromQueueSessionOutput
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class OnSingleNewMessageFromTopicSessionOutput
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class SendMessageInputMessageType
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }
    }

    public class SendMessagesInputMessagesTypeItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }
    }

    public class GetDeferredMessageFromQueueV2Output
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class GetMessagesFromQueueV2OutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class GetDeferredMessageFromTopicV2Output
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class GetMessagesFromTopicV2OutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateTopicSubscriptionInputTopicSubscriptionFilterTypeType
    {
        None,
        Correlation
    }

    public class GetDeferredMessageFromQueueSessionOutput
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class GetDeferredMessageFromTopicSessionOutput
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class GetMessagesFromQueueSessionOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }

    public class GetMessagesFromTopicSessionOutputItem
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("lockToken")]
        public string LockToken { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToSession")]
        public string ReplyToSession { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("scheduledEnqueueTimeUtc")]
        public string ScheduledEnqueueTimeUtc { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeToLive")]
        public string TimeToLive { get; set; }

        [JsonProperty("deadletterSource")]
        public string DeadletterSource { get; set; }

        [JsonProperty("deliveryCount")]
        public int DeliveryCount { get; set; }

        [JsonProperty("enqueuedSequenceNumber")]
        public string EnqueuedSequenceNumber { get; set; }

        [JsonProperty("enqueuedTimeUtc")]
        public string EnqueuedTimeUtc { get; set; }

        [JsonProperty("lockedUntilUtc")]
        public string LockedUntilUtc { get; set; }

        [JsonProperty("sequenceNumber")]
        public string SequenceNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;

    public partial class WorkflowServiceProviderActions
    {
        public ServiceBusActions ServiceBus(string connectionId) => new ServiceBusActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public ServiceBusTriggers ServiceBus(string connectionId) => new ServiceBusTriggers(connectionId);
    }
}