//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ServiceBusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, SendMessageActionConfiguration> SendMessage(Expression<Func<string>> entityName, Expression<Func<SendMessageInputMessageType>> message)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            return new DeferredOutputAction<JToken, SendMessageActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["entityName"] = ExpressionConverter.ConvertO(__workflow_entityName);
                serviceProviderParameters["message"] = ExpressionConverter.ConvertO(__workflow_message);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "sendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, SendMessageActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, SendMessagesActionConfiguration> SendMessages(Expression<Func<string>> entityName, Expression<Func<SendMessagesInputMessagesTypeItem[]>> messages)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_messages = WorkflowExpression.Compile(messages, nameof(messages), required: true);
            return new DeferredOutputAction<JToken, SendMessagesActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["entityName"] = ExpressionConverter.ConvertO(__workflow_entityName);
                serviceProviderParameters["messages"] = ExpressionConverter.ConvertO(__workflow_messages);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "sendMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, SendMessagesActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, ReplicateMessagesActionConfiguration> ReplicateMessages(Expression<Func<string>> entityName, Expression<Func<bool>> skipAlreadyReplicated)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_skipAlreadyReplicated = WorkflowExpression.Compile(skipAlreadyReplicated, nameof(skipAlreadyReplicated), required: true);
            return new DeferredOutputAction<JToken, ReplicateMessagesActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["entityName"] = ExpressionConverter.ConvertO(__workflow_entityName);
                serviceProviderParameters["skipAlreadyReplicated"] = ExpressionConverter.ConvertO(__workflow_skipAlreadyReplicated);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "replicateMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, ReplicateMessagesActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, CompleteQueueMessageV2ActionConfiguration> CompleteQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, CompleteQueueMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, CompleteQueueMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, AbandonQueueMessageV2ActionConfiguration> AbandonQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, AbandonQueueMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, AbandonQueueMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeadLetterQueueMessageV2ActionConfiguration> DeadLetterQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredOutputAction<JToken, DeadLetterQueueMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                if (__workflow_deadLetterReason != null)
                {
                    serviceProviderParameters["deadLetterReason"] = ExpressionConverter.ConvertO(__workflow_deadLetterReason);
                }

                if (__workflow_deadLetterErrorDescription != null)
                {
                    serviceProviderParameters["deadLetterErrorDescription"] = ExpressionConverter.ConvertO(__workflow_deadLetterErrorDescription);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeadLetterQueueMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, RenewLockQueueMessageV2ActionConfiguration> RenewLockQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, RenewLockQueueMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewLockQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, RenewLockQueueMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeferQueueMessageV2ActionConfiguration> DeferQueueMessageV2(Expression<Func<string>> queueName, Expression<Func<string>> lockToken)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, DeferQueueMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferQueueMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeferQueueMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueV2Output, GetDeferredMessageFromQueueV2ActionConfiguration> GetDeferredMessageFromQueueV2(Expression<Func<string>> queueName, Expression<Func<string>> sequenceNumber)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            return new DeferredBodyAction<GetDeferredMessageFromQueueV2Output, GetDeferredMessageFromQueueV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(__workflow_sequenceNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromQueueV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetDeferredMessageFromQueueV2Output, GetDeferredMessageFromQueueV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromQueueV2OutputItem[], GetMessagesFromQueueV2ActionConfiguration> GetMessagesFromQueueV2(Expression<Func<string>> queueName, Expression<Func<int>> maxMessages = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessages = WorkflowExpression.Compile(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyAction<GetMessagesFromQueueV2OutputItem[], GetMessagesFromQueueV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(__workflow_maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromQueueV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetMessagesFromQueueV2OutputItem[], GetMessagesFromQueueV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, CompleteTopicMessageV2ActionConfiguration> CompleteTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, CompleteTopicMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, CompleteTopicMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, AbandonTopicMessageV2ActionConfiguration> AbandonTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, AbandonTopicMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, AbandonTopicMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeadLetterTopicMessageV2ActionConfiguration> DeadLetterTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredOutputAction<JToken, DeadLetterTopicMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                if (__workflow_deadLetterReason != null)
                {
                    serviceProviderParameters["deadLetterReason"] = ExpressionConverter.ConvertO(__workflow_deadLetterReason);
                }

                if (__workflow_deadLetterErrorDescription != null)
                {
                    serviceProviderParameters["deadLetterErrorDescription"] = ExpressionConverter.ConvertO(__workflow_deadLetterErrorDescription);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeadLetterTopicMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, RenewLockTopicMessageV2ActionConfiguration> RenewLockTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, RenewLockTopicMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewLockTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, RenewLockTopicMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeferTopicMessageV2ActionConfiguration> DeferTopicMessageV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            return new DeferredOutputAction<JToken, DeferTopicMessageV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferTopicMessageV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeferTopicMessageV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicV2Output, GetDeferredMessageFromTopicV2ActionConfiguration> GetDeferredMessageFromTopicV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sequenceNumber)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            return new DeferredBodyAction<GetDeferredMessageFromTopicV2Output, GetDeferredMessageFromTopicV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(__workflow_sequenceNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromTopicV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetDeferredMessageFromTopicV2Output, GetDeferredMessageFromTopicV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromTopicV2OutputItem[], GetMessagesFromTopicV2ActionConfiguration> GetMessagesFromTopicV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessages = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessages = WorkflowExpression.Compile(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyAction<GetMessagesFromTopicV2OutputItem[], GetMessagesFromTopicV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(__workflow_maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromTopicV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetMessagesFromTopicV2OutputItem[], GetMessagesFromTopicV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, CreateTopicSubscriptionActionConfiguration> CreateTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> topicSubscriptionName, Expression<Func<CreateTopicSubscriptionInputTopicSubscriptionFilterTypeType>> topicSubscriptionFilterType, Expression<Func<object>> topicSubscriptionCorrelationFilter = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_topicSubscriptionName = WorkflowExpression.Compile(topicSubscriptionName, nameof(topicSubscriptionName), required: true);
            var __workflow_topicSubscriptionFilterType = WorkflowExpression.Compile(topicSubscriptionFilterType, nameof(topicSubscriptionFilterType), required: true);
            var __workflow_topicSubscriptionCorrelationFilter = WorkflowExpression.Compile(topicSubscriptionCorrelationFilter, nameof(topicSubscriptionCorrelationFilter), required: false);
            return new DeferredOutputAction<JToken, CreateTopicSubscriptionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["topicSubscriptionName"] = ExpressionConverter.ConvertO(__workflow_topicSubscriptionName);
                serviceProviderParameters["topicSubscriptionFilterType"] = ExpressionConverter.ConvertO(__workflow_topicSubscriptionFilterType);
                if (__workflow_topicSubscriptionCorrelationFilter != null)
                {
                    serviceProviderParameters["topicSubscriptionCorrelationFilter"] = ExpressionConverter.ConvertO(__workflow_topicSubscriptionCorrelationFilter);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "createTopicSubscription", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, CreateTopicSubscriptionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeleteTopicSubscriptionActionConfiguration> DeleteTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> topicSubscriptionName)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_topicSubscriptionName = WorkflowExpression.Compile(topicSubscriptionName, nameof(topicSubscriptionName), required: true);
            return new DeferredOutputAction<JToken, DeleteTopicSubscriptionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["topicSubscriptionName"] = ExpressionConverter.ConvertO(__workflow_topicSubscriptionName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deleteTopicSubscription", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeleteTopicSubscriptionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, CompleteMessageInSessionActionConfiguration> CompleteMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: false);
            return new DeferredOutputAction<JToken, CompleteMessageInSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(__workflow_messageId);
                if (__workflow_lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "completeMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, CompleteMessageInSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, AbandonMessageInSessionActionConfiguration> AbandonMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: false);
            return new DeferredOutputAction<JToken, AbandonMessageInSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(__workflow_messageId);
                if (__workflow_lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "abandonMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, AbandonMessageInSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeadLetterMessageInSessionActionConfiguration> DeadLetterMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: false);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredOutputAction<JToken, DeadLetterMessageInSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(__workflow_messageId);
                if (__workflow_lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                }

                if (__workflow_deadLetterReason != null)
                {
                    serviceProviderParameters["deadLetterReason"] = ExpressionConverter.ConvertO(__workflow_deadLetterReason);
                }

                if (__workflow_deadLetterErrorDescription != null)
                {
                    serviceProviderParameters["deadLetterErrorDescription"] = ExpressionConverter.ConvertO(__workflow_deadLetterErrorDescription);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deadLetterMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeadLetterMessageInSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, DeferMessageInSessionActionConfiguration> DeferMessageInSession(Expression<Func<string>> messageId, Expression<Func<string>> lockToken = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: false);
            return new DeferredOutputAction<JToken, DeferMessageInSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(__workflow_messageId);
                if (__workflow_lockToken != null)
                {
                    serviceProviderParameters["lockToken"] = ExpressionConverter.ConvertO(__workflow_lockToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "deferMessageInSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, DeferMessageInSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromQueueSessionOutput, GetDeferredMessageFromQueueSessionActionConfiguration> GetDeferredMessageFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sequenceNumber, Expression<Func<string>> sessionId = null, Expression<Func<bool>> acquireNewSession = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_acquireNewSession = WorkflowExpression.Compile(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetDeferredMessageFromQueueSessionOutput, GetDeferredMessageFromQueueSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(__workflow_sequenceNumber);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                if (__workflow_acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(__workflow_acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetDeferredMessageFromQueueSessionOutput, GetDeferredMessageFromQueueSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetDeferredMessageFromTopicSessionOutput, GetDeferredMessageFromTopicSessionActionConfiguration> GetDeferredMessageFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sequenceNumber, Expression<Func<string>> sessionId = null, Expression<Func<bool>> acquireNewSession = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_acquireNewSession = WorkflowExpression.Compile(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetDeferredMessageFromTopicSessionOutput, GetDeferredMessageFromTopicSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["sequenceNumber"] = ExpressionConverter.ConvertO(__workflow_sequenceNumber);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                if (__workflow_acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(__workflow_acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getDeferredMessageFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetDeferredMessageFromTopicSessionOutput, GetDeferredMessageFromTopicSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromQueueSessionOutputItem[], GetMessagesFromQueueSessionActionConfiguration> GetMessagesFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId, Expression<Func<int>> maxMessages = null, Expression<Func<bool>> acquireNewSession = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_maxMessages = WorkflowExpression.Compile(maxMessages, nameof(maxMessages), required: false);
            var __workflow_acquireNewSession = WorkflowExpression.Compile(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetMessagesFromQueueSessionOutputItem[], GetMessagesFromQueueSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                if (__workflow_maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(__workflow_maxMessages);
                }

                if (__workflow_acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(__workflow_acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetMessagesFromQueueSessionOutputItem[], GetMessagesFromQueueSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IBodyWorkflowAction<GetMessagesFromTopicSessionOutputItem[], GetMessagesFromTopicSessionActionConfiguration> GetMessagesFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId, Expression<Func<int>> maxMessages = null, Expression<Func<bool>> acquireNewSession = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_maxMessages = WorkflowExpression.Compile(maxMessages, nameof(maxMessages), required: false);
            var __workflow_acquireNewSession = WorkflowExpression.Compile(acquireNewSession, nameof(acquireNewSession), required: false);
            return new DeferredBodyAction<GetMessagesFromTopicSessionOutputItem[], GetMessagesFromTopicSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                if (__workflow_maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(__workflow_maxMessages);
                }

                if (__workflow_acquireNewSession != null)
                {
                    serviceProviderParameters["acquireNewSession"] = ExpressionConverter.ConvertO(__workflow_acquireNewSession);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "getMessagesFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetMessagesFromTopicSessionOutputItem[], GetMessagesFromTopicSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, RenewQueueSessionActionConfiguration> RenewQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken, RenewQueueSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, RenewQueueSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, RenewTopicSessionActionConfiguration> RenewTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken, RenewTopicSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "renewTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, RenewTopicSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, CloseQueueSessionActionConfiguration> CloseQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken, CloseQueueSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "closeQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, CloseQueueSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "serviceBus")]
        public IOutputWorkflowAction<JToken, CloseTopicSessionActionConfiguration> CloseTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredOutputAction<JToken, CloseTopicSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "closeTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken, CloseTopicSessionActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class SendMessageActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class SendMessagesActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class ReplicateMessagesActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CompleteQueueMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class AbandonQueueMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeadLetterQueueMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class RenewLockQueueMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeferQueueMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetDeferredMessageFromQueueV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetMessagesFromQueueV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CompleteTopicMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class AbandonTopicMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeadLetterTopicMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class RenewLockTopicMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeferTopicMessageV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetDeferredMessageFromTopicV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetMessagesFromTopicV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CreateTopicSubscriptionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeleteTopicSubscriptionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CompleteMessageInSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class AbandonMessageInSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeadLetterMessageInSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class DeferMessageInSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetDeferredMessageFromQueueSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetDeferredMessageFromTopicSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetMessagesFromQueueSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class GetMessagesFromTopicSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class RenewQueueSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class RenewTopicSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CloseQueueSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class CloseTopicSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public class ServiceBusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutputItem[], ReceiveQueueMessagesTriggerConfiguration> ReceiveQueueMessages(Expression<Func<string>> queueName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_isSessionsEnabled = WorkflowExpression.Compile(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            var __workflow_maxMessageBatchSize = WorkflowExpression.Compile(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<ReceiveQueueMessagesOutputItem[], ReceiveQueueMessagesTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(__workflow_isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (__workflow_maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(__workflow_maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveQueueMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveQueueMessagesOutputItem[], ReceiveQueueMessagesTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<ReceiveTopicMessagesOutputItem[], ReceiveTopicMessagesTriggerConfiguration> ReceiveTopicMessages(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_isSessionsEnabled = WorkflowExpression.Compile(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            var __workflow_maxMessageBatchSize = WorkflowExpression.Compile(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<ReceiveTopicMessagesOutputItem[], ReceiveTopicMessagesTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(__workflow_isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (__workflow_maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(__workflow_maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveTopicMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveTopicMessagesOutputItem[], ReceiveTopicMessagesTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IWorkflowTrigger<ReceiveQueueMessagesForReplicationTriggerConfiguration> ReceiveQueueMessagesForReplication(Expression<Func<string>> queueName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_isSessionsEnabled = WorkflowExpression.Compile(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            var __workflow_maxMessageBatchSize = WorkflowExpression.Compile(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredWorkflowTrigger<ReceiveQueueMessagesForReplicationTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(__workflow_isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (__workflow_maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(__workflow_maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveQueueMessagesForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveQueueMessagesForReplicationTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IWorkflowTrigger<ReceiveTopicMessagesForReplicationTriggerConfiguration> ReceiveTopicMessagesForReplication(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<bool>> isSessionsEnabled = null, Expression<Func<double>> maxMessageBatchSize = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_isSessionsEnabled = WorkflowExpression.Compile(isSessionsEnabled, nameof(isSessionsEnabled), required: false);
            var __workflow_maxMessageBatchSize = WorkflowExpression.Compile(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredWorkflowTrigger<ReceiveTopicMessagesForReplicationTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_isSessionsEnabled != null)
                {
                    serviceProviderParameters["isSessionsEnabled"] = ExpressionConverter.ConvertO(__workflow_isSessionsEnabled);
                }
                else
                {
                    serviceProviderParameters["isSessionsEnabled"] = false;
                }

                if (__workflow_maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(__workflow_maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "receiveTopicMessagesForReplication", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveTopicMessagesForReplicationTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<PeekLockQueueMessagesV2OutputItem[], PeekLockQueueMessagesV2TriggerConfiguration> PeekLockQueueMessagesV2(Expression<Func<string>> queueName, Expression<Func<double>> maxMessageBatchSize = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageBatchSize = WorkflowExpression.Compile(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<PeekLockQueueMessagesV2OutputItem[], PeekLockQueueMessagesV2TriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(__workflow_maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "peekLockQueueMessagesV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<PeekLockQueueMessagesV2OutputItem[], PeekLockQueueMessagesV2TriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<PeekLockTopicMessagesV2OutputItem[], PeekLockTopicMessagesV2TriggerConfiguration> PeekLockTopicMessagesV2(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<double>> maxMessageBatchSize = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageBatchSize = WorkflowExpression.Compile(maxMessageBatchSize, nameof(maxMessageBatchSize), required: false);
            return new DeferredBodyTrigger<PeekLockTopicMessagesV2OutputItem[], PeekLockTopicMessagesV2TriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_maxMessageBatchSize != null)
                {
                    serviceProviderParameters["maxMessageBatchSize"] = ExpressionConverter.ConvertO(__workflow_maxMessageBatchSize);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "peekLockTopicMessagesV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<PeekLockTopicMessagesV2OutputItem[], PeekLockTopicMessagesV2TriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromQueueSessionOutputItem[], OnNewMessagesFromQueueSessionTriggerConfiguration> OnNewMessagesFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId = null, Expression<Func<int>> maxMessages = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_maxMessages = WorkflowExpression.Compile(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyTrigger<OnNewMessagesFromQueueSessionOutputItem[], OnNewMessagesFromQueueSessionTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                if (__workflow_maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(__workflow_maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onNewMessagesFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<OnNewMessagesFromQueueSessionOutputItem[], OnNewMessagesFromQueueSessionTriggerConfiguration>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnNewMessagesFromTopicSessionOutputItem[], OnNewMessagesFromTopicSessionTriggerConfiguration> OnNewMessagesFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId = null, Expression<Func<int>> maxMessages = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_maxMessages = WorkflowExpression.Compile(maxMessages, nameof(maxMessages), required: false);
            return new DeferredBodyTrigger<OnNewMessagesFromTopicSessionOutputItem[], OnNewMessagesFromTopicSessionTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                if (__workflow_maxMessages != null)
                {
                    serviceProviderParameters["maxMessages"] = ExpressionConverter.ConvertO(__workflow_maxMessages);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onNewMessagesFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<OnNewMessagesFromTopicSessionOutputItem[], OnNewMessagesFromTopicSessionTriggerConfiguration>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromQueueSessionOutput, OnSingleNewMessageFromQueueSessionTriggerConfiguration> OnSingleNewMessageFromQueueSession(Expression<Func<string>> queueName, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<OnSingleNewMessageFromQueueSessionOutput, OnSingleNewMessageFromQueueSessionTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onSingleNewMessageFromQueueSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<OnSingleNewMessageFromQueueSessionOutput, OnSingleNewMessageFromQueueSessionTriggerConfiguration>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnSingleNewMessageFromTopicSessionOutput, OnSingleNewMessageFromTopicSessionTriggerConfiguration> OnSingleNewMessageFromTopicSession(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<OnSingleNewMessageFromTopicSessionOutput, OnSingleNewMessageFromTopicSessionTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["topicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["subscriptionName"] = ExpressionConverter.ConvertO(__workflow_subscriptionName);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/serviceBus", operationId: "onSingleNewMessageFromTopicSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<OnSingleNewMessageFromTopicSessionOutput, OnSingleNewMessageFromTopicSessionTriggerConfiguration>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }
    }

    public sealed class ReceiveQueueMessagesTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class ReceiveTopicMessagesTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class ReceiveQueueMessagesForReplicationTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class ReceiveTopicMessagesForReplicationTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class PeekLockQueueMessagesV2TriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class PeekLockTopicMessagesV2TriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class OnNewMessagesFromQueueSessionTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class OnNewMessagesFromTopicSessionTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class OnSingleNewMessageFromQueueSessionTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class OnSingleNewMessageFromTopicSessionTriggerConfiguration : IRetryPolicyConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration, ITriggerConcurrencyConfiguration, IClientTrackingIdConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }

        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }

        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }

        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
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