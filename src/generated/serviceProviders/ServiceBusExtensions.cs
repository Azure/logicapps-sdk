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
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IOutputWorkflowAction<JToken> SendMessage([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<SendMessageInputMessageType> message)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildSendMessage(WorkflowValue<string> entityName, WorkflowValue<SendMessageInputMessageType> message)
        {
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(message, nameof(message), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessages))]
        public IOutputWorkflowAction<JToken> SendMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<SendMessagesInputMessagesTypeItem[]> messages)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildSendMessages(WorkflowValue<string> entityName, WorkflowValue<SendMessagesInputMessagesTypeItem[]> messages)
        {
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(messages, nameof(messages), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildReplicateMessages))]
        public IOutputWorkflowAction<JToken> ReplicateMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<bool> skipAlreadyReplicated)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildReplicateMessages(WorkflowValue<string> entityName, WorkflowValue<bool> skipAlreadyReplicated)
        {
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(skipAlreadyReplicated, nameof(skipAlreadyReplicated), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteQueueMessageV2))]
        public IOutputWorkflowAction<JToken> CompleteQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCompleteQueueMessageV2(WorkflowValue<string> queueName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildAbandonQueueMessageV2))]
        public IOutputWorkflowAction<JToken> AbandonQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildAbandonQueueMessageV2(WorkflowValue<string> queueName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeadLetterQueueMessageV2))]
        public IOutputWorkflowAction<JToken> DeadLetterQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeadLetterQueueMessageV2(WorkflowValue<string> queueName, WorkflowValue<string> lockToken, WorkflowValue<string> deadLetterReason = null, WorkflowValue<string> deadLetterErrorDescription = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowValue.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewLockQueueMessageV2))]
        public IOutputWorkflowAction<JToken> RenewLockQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildRenewLockQueueMessageV2(WorkflowValue<string> queueName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeferQueueMessageV2))]
        public IOutputWorkflowAction<JToken> DeferQueueMessageV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeferQueueMessageV2(WorkflowValue<string> queueName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeferredMessageFromQueueV2))]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueV2Output> GetDeferredMessageFromQueueV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sequenceNumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueV2Output> __BuildGetDeferredMessageFromQueueV2(WorkflowValue<string> queueName, WorkflowValue<string> sequenceNumber)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            return new DeferredBodyAction<GetDeferredMessageFromQueueV2Output>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromQueueV2))]
        public IBodyWorkflowAction<GetMessagesFromQueueV2OutputItem[]> GetMessagesFromQueueV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessages = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesFromQueueV2OutputItem[]> __BuildGetMessagesFromQueueV2(WorkflowValue<string> queueName, WorkflowValue<int> maxMessages = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyAction<GetMessagesFromQueueV2OutputItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteTopicMessageV2))]
        public IOutputWorkflowAction<JToken> CompleteTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCompleteTopicMessageV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildAbandonTopicMessageV2))]
        public IOutputWorkflowAction<JToken> AbandonTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildAbandonTopicMessageV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeadLetterTopicMessageV2))]
        public IOutputWorkflowAction<JToken> DeadLetterTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeadLetterTopicMessageV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken, WorkflowValue<string> deadLetterReason = null, WorkflowValue<string> deadLetterErrorDescription = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowValue.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewLockTopicMessageV2))]
        public IOutputWorkflowAction<JToken> RenewLockTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildRenewLockTopicMessageV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeferTopicMessageV2))]
        public IOutputWorkflowAction<JToken> DeferTopicMessageV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeferTopicMessageV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeferredMessageFromTopicV2))]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicV2Output> GetDeferredMessageFromTopicV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sequenceNumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicV2Output> __BuildGetDeferredMessageFromTopicV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sequenceNumber)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            return new DeferredBodyAction<GetDeferredMessageFromTopicV2Output>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromTopicV2))]
        public IBodyWorkflowAction<GetMessagesFromTopicV2OutputItem[]> GetMessagesFromTopicV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessages = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesFromTopicV2OutputItem[]> __BuildGetMessagesFromTopicV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<int> maxMessages = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyAction<GetMessagesFromTopicV2OutputItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTopicSubscription))]
        public IOutputWorkflowAction<JToken> CreateTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> topicSubscriptionName, [WorkflowExpression] Func<CreateTopicSubscriptionInputTopicSubscriptionFilterTypeType> topicSubscriptionFilterType, [WorkflowExpression] Func<object> topicSubscriptionCorrelationFilter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCreateTopicSubscription(WorkflowValue<string> topicName, WorkflowValue<string> topicSubscriptionName, WorkflowValue<CreateTopicSubscriptionInputTopicSubscriptionFilterTypeType> topicSubscriptionFilterType, WorkflowValue<object> topicSubscriptionCorrelationFilter = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(topicSubscriptionName, nameof(topicSubscriptionName), required: true);
            WorkflowValue.Validate(topicSubscriptionFilterType, nameof(topicSubscriptionFilterType), required: true);
            WorkflowValue.Validate(topicSubscriptionCorrelationFilter, nameof(topicSubscriptionCorrelationFilter), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTopicSubscription))]
        public IOutputWorkflowAction<JToken> DeleteTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> topicSubscriptionName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeleteTopicSubscription(WorkflowValue<string> topicName, WorkflowValue<string> topicSubscriptionName)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(topicSubscriptionName, nameof(topicSubscriptionName), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteMessageInSession))]
        public IOutputWorkflowAction<JToken> CompleteMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCompleteMessageInSession(WorkflowValue<string> messageId, WorkflowValue<string> lockToken = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildAbandonMessageInSession))]
        public IOutputWorkflowAction<JToken> AbandonMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildAbandonMessageInSession(WorkflowValue<string> messageId, WorkflowValue<string> lockToken = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeadLetterMessageInSession))]
        public IOutputWorkflowAction<JToken> DeadLetterMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeadLetterMessageInSession(WorkflowValue<string> messageId, WorkflowValue<string> lockToken = null, WorkflowValue<string> deadLetterReason = null, WorkflowValue<string> deadLetterErrorDescription = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: false);
            WorkflowValue.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowValue.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildDeferMessageInSession))]
        public IOutputWorkflowAction<JToken> DeferMessageInSession([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> lockToken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeferMessageInSession(WorkflowValue<string> messageId, WorkflowValue<string> lockToken = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: false);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeferredMessageFromQueueSession))]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueSessionOutput> GetDeferredMessageFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sequenceNumber, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueSessionOutput> __BuildGetDeferredMessageFromQueueSession(WorkflowValue<string> queueName, WorkflowValue<string> sequenceNumber, WorkflowValue<string> sessionId = null, WorkflowValue<bool> acquireNewSession = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetDeferredMessageFromQueueSessionOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeferredMessageFromTopicSession))]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicSessionOutput> GetDeferredMessageFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sequenceNumber, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicSessionOutput> __BuildGetDeferredMessageFromTopicSession(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sequenceNumber, WorkflowValue<string> sessionId = null, WorkflowValue<bool> acquireNewSession = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetDeferredMessageFromTopicSessionOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromQueueSession))]
        public IBodyWorkflowAction<GetMessagesFromQueueSessionOutputItem[]> GetMessagesFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<int> maxMessages = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesFromQueueSessionOutputItem[]> __BuildGetMessagesFromQueueSession(WorkflowValue<string> queueName, WorkflowValue<string> sessionId, WorkflowValue<int> maxMessages = null, WorkflowValue<bool> acquireNewSession = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowValue.Validate(maxMessages, nameof(maxMessages), required: false);
            WorkflowValue.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetMessagesFromQueueSessionOutputItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromTopicSession))]
        public IBodyWorkflowAction<GetMessagesFromTopicSessionOutputItem[]> GetMessagesFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<int> maxMessages = null, [WorkflowExpression] Func<bool> acquireNewSession = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesFromTopicSessionOutputItem[]> __BuildGetMessagesFromTopicSession(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId, WorkflowValue<int> maxMessages = null, WorkflowValue<bool> acquireNewSession = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowValue.Validate(maxMessages, nameof(maxMessages), required: false);
            WorkflowValue.Validate(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetMessagesFromTopicSessionOutputItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewQueueSession))]
        public IOutputWorkflowAction<JToken> RenewQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildRenewQueueSession(WorkflowValue<string> queueName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewTopicSession))]
        public IOutputWorkflowAction<JToken> RenewTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildRenewTopicSession(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildCloseQueueSession))]
        public IOutputWorkflowAction<JToken> CloseQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCloseQueueSession(WorkflowValue<string> queueName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        [WorkflowExpressionFactory(nameof(__BuildCloseTopicSession))]
        public IOutputWorkflowAction<JToken> CloseTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCloseTopicSession(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }
    }

    public class ServiceBusTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildReceiveQueueMessages))]
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutputItem[]> ReceiveQueueMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutputItem[]> __BuildReceiveQueueMessages(WorkflowValue<string> queueName, WorkflowValue<bool> isSessionsEnabled = null, WorkflowValue<double> maxMessageBatchSize = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            WorkflowValue.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<ReceiveQueueMessagesOutputItem[]>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildReceiveTopicMessages))]
        public IBodyWorkflowTrigger<ReceiveTopicMessagesOutputItem[]> ReceiveTopicMessages([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveTopicMessagesOutputItem[]> __BuildReceiveTopicMessages(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<bool> isSessionsEnabled = null, WorkflowValue<double> maxMessageBatchSize = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            WorkflowValue.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<ReceiveTopicMessagesOutputItem[]>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildReceiveQueueMessagesForReplication))]
        public IOutputWorkflowTrigger<JToken> ReceiveQueueMessagesForReplication([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowTrigger<JToken> __BuildReceiveQueueMessagesForReplication(WorkflowValue<string> queueName, WorkflowValue<bool> isSessionsEnabled = null, WorkflowValue<double> maxMessageBatchSize = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            WorkflowValue.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredOutputTrigger<JToken>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildReceiveTopicMessagesForReplication))]
        public IOutputWorkflowTrigger<JToken> ReceiveTopicMessagesForReplication([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<bool> isSessionsEnabled = null, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowTrigger<JToken> __BuildReceiveTopicMessagesForReplication(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<bool> isSessionsEnabled = null, WorkflowValue<double> maxMessageBatchSize = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            WorkflowValue.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredOutputTrigger<JToken>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildPeekLockQueueMessagesV2))]
        public IBodyWorkflowTrigger<PeekLockQueueMessagesV2OutputItem[]> PeekLockQueueMessagesV2([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PeekLockQueueMessagesV2OutputItem[]> __BuildPeekLockQueueMessagesV2(WorkflowValue<string> queueName, WorkflowValue<double> maxMessageBatchSize = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<PeekLockQueueMessagesV2OutputItem[]>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildPeekLockTopicMessagesV2))]
        public IBodyWorkflowTrigger<PeekLockTopicMessagesV2OutputItem[]> PeekLockTopicMessagesV2([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<double> maxMessageBatchSize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PeekLockTopicMessagesV2OutputItem[]> __BuildPeekLockTopicMessagesV2(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<double> maxMessageBatchSize = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<PeekLockTopicMessagesV2OutputItem[]>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewMessagesFromQueueSession))]
        public IBodyWorkflowTrigger<OnNewMessagesFromQueueSessionOutputItem[]> OnNewMessagesFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewMessagesFromQueueSessionOutputItem[]> __BuildOnNewMessagesFromQueueSession(WorkflowValue<string> queueName, WorkflowValue<string> sessionId = null, WorkflowValue<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyTrigger<OnNewMessagesFromQueueSessionOutputItem[]>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewMessagesFromTopicSession))]
        public IBodyWorkflowTrigger<OnNewMessagesFromTopicSessionOutputItem[]> OnNewMessagesFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewMessagesFromTopicSessionOutputItem[]> __BuildOnNewMessagesFromTopicSession(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId = null, WorkflowValue<int> maxMessages = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyTrigger<OnNewMessagesFromTopicSessionOutputItem[]>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildOnSingleNewMessageFromQueueSession))]
        public IBodyWorkflowTrigger<OnSingleNewMessageFromQueueSessionOutput> OnSingleNewMessageFromQueueSession([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnSingleNewMessageFromQueueSessionOutput> __BuildOnSingleNewMessageFromQueueSession(WorkflowValue<string> queueName, WorkflowValue<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<OnSingleNewMessageFromQueueSessionOutput>(() =>
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
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildOnSingleNewMessageFromTopicSession))]
        public IBodyWorkflowTrigger<OnSingleNewMessageFromTopicSessionOutput> OnSingleNewMessageFromTopicSession([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnSingleNewMessageFromTopicSessionOutput> __BuildOnSingleNewMessageFromTopicSession(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<OnSingleNewMessageFromTopicSessionOutput>(() =>
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
            }, "ServiceProviderTrigger");
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
