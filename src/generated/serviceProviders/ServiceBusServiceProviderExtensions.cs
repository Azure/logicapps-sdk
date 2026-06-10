//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServiceBusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken> SendMessage(Expression<Func<string>> entityName, Expression<Func<SendMessageMessageType>> message)
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
        public IOutputWorkflowAction<JToken> SendMessages(Expression<Func<string>> entityName, Expression<Func<SendMessagesMessagesTypeItem[]>> messages)
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
        public IOutputWorkflowAction<JToken> ReplicateMessages(Expression<Func<string>> entityName, Expression<Func<bool>> skipAlreadyReplicated)
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
        public IOutputWorkflowAction<JToken> CompleteQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
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
        public IOutputWorkflowAction<JToken> AbandonQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
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
        public IOutputWorkflowAction<JToken> DeadLetterQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
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
        public IOutputWorkflowAction<JToken> RenewLockQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
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
        public IOutputWorkflowAction<JToken> DeferQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
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
        public IBodyWorkflowAction<GetDeferredMessageFromQueueV2Output> GetDeferredMessageFromQueueV2(Expression<Func<string>> queueName, Expression<Func<string>> sequenceNumber)
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
        public IBodyWorkflowAction<GetMessagesFromQueueV2OutputItem[]> GetMessagesFromQueueV2(Expression<Func<string>> queueName, Expression<Func<int>> maxMessages = null)
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
        public IOutputWorkflowAction<JToken> CompleteTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
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
        public IOutputWorkflowAction<JToken> AbandonTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
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
        public IOutputWorkflowAction<JToken> DeadLetterTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
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
        public IOutputWorkflowAction<JToken> RenewLockTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
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
        public IOutputWorkflowAction<JToken> DeferTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
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
        public IBodyWorkflowAction<GetDeferredMessageFromTopicV2Output> GetDeferredMessageFromTopicV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sequenceNumber)
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
        public IBodyWorkflowAction<GetMessagesFromTopicV2OutputItem[]> GetMessagesFromTopicV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessages = null)
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
        public IOutputWorkflowAction<JToken> CreateTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> topicSubscriptionName, Expression<Func<CreateTopicSubscriptionTopicSubscriptionFilterTypeType>> topicSubscriptionFilterType, Expression<Func<object>> topicSubscriptionCorrelationFilter = null)
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
        public IOutputWorkflowAction<JToken> DeleteTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> topicSubscriptionName)
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
        public IOutputWorkflowAction<JToken> CompleteMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null)
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
        public IOutputWorkflowAction<JToken> AbandonMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null)
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
        public IOutputWorkflowAction<JToken> DeadLetterMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
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
        public IOutputWorkflowAction<JToken> DeferMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null)
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
        public IBodyWorkflowAction<GetDeferredMessageFromQueueSessionOutput> GetDeferredMessageFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sequenceNumber, Expression<Func<string>> sessionId = null, Expression<Func<bool>> acquireNewSession = null)
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
        public IBodyWorkflowAction<GetDeferredMessageFromTopicSessionOutput> GetDeferredMessageFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sequenceNumber, Expression<Func<string>> sessionId = null, Expression<Func<bool>> acquireNewSession = null)
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
        public IBodyWorkflowAction<GetMessagesFromQueueSessionOutputItem[]> GetMessagesFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId, Expression<Func<int>> maxMessages = null, Expression<Func<bool>> acquireNewSession = null)
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
        public IBodyWorkflowAction<GetMessagesFromTopicSessionOutputItem[]> GetMessagesFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId, Expression<Func<int>> maxMessages = null, Expression<Func<bool>> acquireNewSession = null)
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
        public IOutputWorkflowAction<JToken> RenewQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
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
        public IOutputWorkflowAction<JToken> RenewTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
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
        public IOutputWorkflowAction<JToken> CloseQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
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
        public IOutputWorkflowAction<JToken> CloseTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
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
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutputItem[]> ReceiveQueueMessages(Expression<Func<string>> queueName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null, string triggerName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
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
            return new ServiceProviderTrigger<ReceiveQueueMessagesOutputItem[]>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<ReceiveTopicMessagesOutputItem[]> ReceiveTopicMessages(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null, string triggerName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
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
            return new ServiceProviderTrigger<ReceiveTopicMessagesOutputItem[]>(serviceProviderInput, triggerName);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveQueueMessagesForReplication(Expression<Func<string>> queueName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null, string triggerName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
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
            return new ServiceProviderOutputTrigger<JToken>(serviceProviderInput, triggerName);
        }

        public IOutputWorkflowTrigger<JToken> ReceiveTopicMessagesForReplication(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null, string triggerName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(topicName);
            serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(subscriptionName);
            if (isSessionsEnabled != null)
            {
                serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(isSessionsEnabled);
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
            return new ServiceProviderOutputTrigger<JToken>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<PeekLockQueueMessagesV2OutputItem[]> PeekLockQueueMessagesV2(Expression<Func<string>> queueName, Expression<Func<double>> maxMessageBatchSize = null, string triggerName = null)
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
            return new ServiceProviderTrigger<PeekLockQueueMessagesV2OutputItem[]>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<PeekLockTopicMessagesV2OutputItem[]> PeekLockTopicMessagesV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<double>> maxMessageBatchSize = null, string triggerName = null)
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
            return new ServiceProviderTrigger<PeekLockTopicMessagesV2OutputItem[]>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromQueueSessionOutputItem[]> OnNewMessagesFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId = null, Expression<Func<int>> maxMessages = null, string triggerName = null)
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
            return new ServiceProviderTrigger<OnNewMessagesFromQueueSessionOutputItem[]>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromTopicSessionOutputItem[]> OnNewMessagesFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId = null, Expression<Func<int>> maxMessages = null, string triggerName = null)
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
            return new ServiceProviderTrigger<OnNewMessagesFromTopicSessionOutputItem[]>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromQueueSessionOutput> OnSingleNewMessageFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId = null, string triggerName = null)
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
            return new ServiceProviderTrigger<OnSingleNewMessageFromQueueSessionOutput>(serviceProviderInput, triggerName);
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromTopicSessionOutput> OnSingleNewMessageFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId = null, string triggerName = null)
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
            return new ServiceProviderTrigger<OnSingleNewMessageFromTopicSessionOutput>(serviceProviderInput, triggerName);
        }
    }

    public class SendMessageMessageType
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

    public class SendMessagesMessagesTypeItem
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

    public enum CreateTopicSubscriptionTopicSubscriptionFilterTypeType
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