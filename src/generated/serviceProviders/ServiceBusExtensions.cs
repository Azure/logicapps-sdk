//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ServiceBusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> SendMessage([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<SendMessageInputMessageType> message)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["entityName"] = ExpressionConverter.ConvertO(entityName);
            serviceProviderParameters["message"] = ExpressionConverter.ConvertO(message);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "sendMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> SendMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<SendMessagesInputMessagesTypeItem[]> messages)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["entityName"] = ExpressionConverter.ConvertO(entityName);
            serviceProviderParameters["messages"] = ExpressionConverter.ConvertO(messages);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "sendMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> ReplicateMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<bool> skipAlreadyReplicated)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["entityName"] = ExpressionConverter.ConvertO(entityName);
            serviceProviderParameters["skipAlreadyReplicated"] = ExpressionConverter.ConvertO(skipAlreadyReplicated);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "replicateMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CompleteQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeQueueMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> AbandonQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonQueueMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeadLetterQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            if (deadLetterReason != null)
            {
                serviceProviderParameters["deadLetterReason"] = ExpressionConverter.ConvertO(deadLetterReason);
            }

            if (deadLetterErrorDescription != null)
            {
                serviceProviderParameters["deadLetterErrorDescription"] = ExpressionConverter.ConvertO(deadLetterErrorDescription);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterQueueMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewLockQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewLockQueueMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeferQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferQueueMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueV2Output> GetDeferredMessageFromQueueV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sequenceNumber)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(sequenceNumber);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromQueueV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetDeferredMessageFromQueueV2Output>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromQueueV2OutputItem[]> GetMessagesFromQueueV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessages = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (maxMessages != null)
            {
                serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(maxMessages);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromQueueV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesFromQueueV2OutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CompleteTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeTopicMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> AbandonTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonTopicMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeadLetterTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            if (deadLetterReason != null)
            {
                serviceProviderParameters["deadLetterReason"] = ExpressionConverter.ConvertO(deadLetterReason);
            }

            if (deadLetterErrorDescription != null)
            {
                serviceProviderParameters["deadLetterErrorDescription"] = ExpressionConverter.ConvertO(deadLetterErrorDescription);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterTopicMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewLockTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewLockTopicMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeferTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferTopicMessageV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicV2Output> GetDeferredMessageFromTopicV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sequenceNumber)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(sequenceNumber);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromTopicV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetDeferredMessageFromTopicV2Output>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromTopicV2OutputItem[]> GetMessagesFromTopicV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessages = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (maxMessages != null)
            {
                serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(maxMessages);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromTopicV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesFromTopicV2OutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CreateTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> topicSubscriptionName, [WorkflowExpression] Func<CreateTopicSubscriptionInputTopicSubscriptionFilterTypeType> topicSubscriptionFilterType, [WorkflowExpression] Func<object> topicSubscriptionCorrelationFilter = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["topicSubscriptionName"] = ExpressionConverter.ConvertO(topicSubscriptionName);
            serviceProviderParameters["topicSubscriptionFilterType"] = ExpressionConverter.ConvertO(topicSubscriptionFilterType);
            if (topicSubscriptionCorrelationFilter != null)
            {
                serviceProviderParameters["topicSubscriptionCorrelationFilter"] = ExpressionConverter.ConvertO(topicSubscriptionCorrelationFilter);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "createTopicSubscription", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeleteTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> topicSubscriptionName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["topicSubscriptionName"] = ExpressionConverter.ConvertO(topicSubscriptionName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deleteTopicSubscription", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CompleteMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            if (lockToken != null)
            {
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeMessageInSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> AbandonMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            if (lockToken != null)
            {
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonMessageInSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeadLetterMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            if (lockToken != null)
            {
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            }

            if (deadLetterReason != null)
            {
                serviceProviderParameters["deadLetterReason"] = ExpressionConverter.ConvertO(deadLetterReason);
            }

            if (deadLetterErrorDescription != null)
            {
                serviceProviderParameters["deadLetterErrorDescription"] = ExpressionConverter.ConvertO(deadLetterErrorDescription);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterMessageInSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> DeferMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            if (lockToken != null)
            {
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(lockToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferMessageInSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueSessionOutput> GetDeferredMessageFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sequenceNumber, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(sequenceNumber);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            if (acquireNewSession != null)
            {
                serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(acquireNewSession);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromQueueSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetDeferredMessageFromQueueSessionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicSessionOutput> GetDeferredMessageFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sequenceNumber, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(sequenceNumber);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            if (acquireNewSession != null)
            {
                serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(acquireNewSession);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromTopicSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetDeferredMessageFromTopicSessionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromQueueSessionOutputItem[]> GetMessagesFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<int> maxMessages = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            if (maxMessages != null)
            {
                serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(maxMessages);
            }

            if (acquireNewSession != null)
            {
                serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(acquireNewSession);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromQueueSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesFromQueueSessionOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromTopicSessionOutputItem[]> GetMessagesFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<int> maxMessages = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            if (maxMessages != null)
            {
                serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(maxMessages);
            }

            if (acquireNewSession != null)
            {
                serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(acquireNewSession);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromTopicSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesFromTopicSessionOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewQueueSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> RenewTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewTopicSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CloseQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "closeQueueSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> CloseTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "closeTopicSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }
    }

    public class ServiceBusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutputItem[]> ReceiveQueueMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
            }
            else
            {
                serviceProviderParameters["isSessionsEnabled"] = false;
            }

            if (maxMessageBatchSize != null)
            {
                serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(maxMessageBatchSize);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveQueueMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveQueueMessagesOutputItem[]>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<ReceiveTopicMessagesOutputItem[]> ReceiveTopicMessages([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
            }
            else
            {
                serviceProviderParameters["isSessionsEnabled"] = false;
            }

            if (maxMessageBatchSize != null)
            {
                serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(maxMessageBatchSize);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveTopicMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveTopicMessagesOutputItem[]>(serviceProviderInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveQueueMessagesForReplication([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
            }
            else
            {
                serviceProviderParameters["isSessionsEnabled"] = false;
            }

            if (maxMessageBatchSize != null)
            {
                serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(maxMessageBatchSize);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveQueueMessagesForReplication", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputTrigger<JToken>(serviceProviderInput);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveTopicMessagesForReplication([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
            }
            else
            {
                serviceProviderParameters["isSessionsEnabled"] = false;
            }

            if (maxMessageBatchSize != null)
            {
                serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(maxMessageBatchSize);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveTopicMessagesForReplication", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputTrigger<JToken>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<PeekLockQueueMessagesV2OutputItem[]> PeekLockQueueMessagesV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (maxMessageBatchSize != null)
            {
                serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(maxMessageBatchSize);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "peekLockQueueMessagesV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<PeekLockQueueMessagesV2OutputItem[]>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<PeekLockTopicMessagesV2OutputItem[]> PeekLockTopicMessagesV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (maxMessageBatchSize != null)
            {
                serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(maxMessageBatchSize);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "peekLockTopicMessagesV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<PeekLockTopicMessagesV2OutputItem[]>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromQueueSessionOutputItem[]> OnNewMessagesFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            if (maxMessages != null)
            {
                serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(maxMessages);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onNewMessagesFromQueueSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<OnNewMessagesFromQueueSessionOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromTopicSessionOutputItem[]> OnNewMessagesFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            if (maxMessages != null)
            {
                serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(maxMessages);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onNewMessagesFromTopicSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<OnNewMessagesFromTopicSessionOutputItem[]>(serviceProviderInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromQueueSessionOutput> OnSingleNewMessageFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onSingleNewMessageFromQueueSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<OnSingleNewMessageFromQueueSessionOutput>(serviceProviderInput, isPolling: true, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromTopicSessionOutput> OnSingleNewMessageFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onSingleNewMessageFromTopicSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<OnSingleNewMessageFromTopicSessionOutput>(serviceProviderInput, isPolling: true, recurrence: recurrence);
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