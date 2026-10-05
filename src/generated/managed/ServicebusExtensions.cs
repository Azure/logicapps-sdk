//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServicebusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IWorkflowAction SendMessage([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<JToken> messagecontent = null, [WorkflowExpression] Func<string> messagecontentType = null, [WorkflowExpression] Func<string> messagemessageId = null, [WorkflowExpression] Func<string> messageto = null, [WorkflowExpression] Func<string> messagereplyTo = null, [WorkflowExpression] Func<string> messagereplyToSessionId = null, [WorkflowExpression] Func<string> messagelabel = null, [WorkflowExpression] Func<string> messagescheduledEnqueueTimeUtc = null, [WorkflowExpression] Func<string> messagesessionId = null, [WorkflowExpression] Func<string> messagecorrelationId = null, [WorkflowExpression] Func<int> messagesequenceNumber = null, [WorkflowExpression] Func<string> messagelockToken = null, [WorkflowExpression] Func<string> messagetimeToLive = null, [WorkflowExpression] Func<string> systemProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendMessage(WorkflowValue<string> entityName, WorkflowValue<JToken> messagecontent = null, WorkflowValue<string> messagecontentType = null, WorkflowValue<string> messagemessageId = null, WorkflowValue<string> messageto = null, WorkflowValue<string> messagereplyTo = null, WorkflowValue<string> messagereplyToSessionId = null, WorkflowValue<string> messagelabel = null, WorkflowValue<string> messagescheduledEnqueueTimeUtc = null, WorkflowValue<string> messagesessionId = null, WorkflowValue<string> messagecorrelationId = null, WorkflowValue<int> messagesequenceNumber = null, WorkflowValue<string> messagelockToken = null, WorkflowValue<string> messagetimeToLive = null, WorkflowValue<string> systemProperties = null)
        {
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(messagecontent, nameof(messagecontent), required: false);
            WorkflowValue.Validate(messagecontentType, nameof(messagecontentType), required: false);
            WorkflowValue.Validate(messagemessageId, nameof(messagemessageId), required: false);
            WorkflowValue.Validate(messageto, nameof(messageto), required: false);
            WorkflowValue.Validate(messagereplyTo, nameof(messagereplyTo), required: false);
            WorkflowValue.Validate(messagereplyToSessionId, nameof(messagereplyToSessionId), required: false);
            WorkflowValue.Validate(messagelabel, nameof(messagelabel), required: false);
            WorkflowValue.Validate(messagescheduledEnqueueTimeUtc, nameof(messagescheduledEnqueueTimeUtc), required: false);
            WorkflowValue.Validate(messagesessionId, nameof(messagesessionId), required: false);
            WorkflowValue.Validate(messagecorrelationId, nameof(messagecorrelationId), required: false);
            WorkflowValue.Validate(messagesequenceNumber, nameof(messagesequenceNumber), required: false);
            WorkflowValue.Validate(messagelockToken, nameof(messagelockToken), required: false);
            WorkflowValue.Validate(messagetimeToLive, nameof(messagetimeToLive), required: false);
            WorkflowValue.Validate(systemProperties, nameof(systemProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (systemProperties != null)
                    callPayload.Queries["systemProperties"] = ExpressionConverter.Convert(systemProperties);
                var message = new JObject();
                var messagepropCount = 0;
                if (messagecontent != null)
                {
                    message["ContentData"] = ExpressionConverter.ConvertOWithBase64(messagecontent);
                    messagepropCount++;
                }

                if (messagecontentType != null)
                {
                    message["ContentType"] = ExpressionConverter.ConvertO(messagecontentType);
                    messagepropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    message["Properties"] = propertiesObject;
                    messagepropCount++;
                }

                if (messagemessageId != null)
                {
                    message["MessageId"] = ExpressionConverter.ConvertO(messagemessageId);
                    messagepropCount++;
                }

                if (messageto != null)
                {
                    message["To"] = ExpressionConverter.ConvertO(messageto);
                    messagepropCount++;
                }

                if (messagereplyTo != null)
                {
                    message["ReplyTo"] = ExpressionConverter.ConvertO(messagereplyTo);
                    messagepropCount++;
                }

                if (messagereplyToSessionId != null)
                {
                    message["ReplyToSessionId"] = ExpressionConverter.ConvertO(messagereplyToSessionId);
                    messagepropCount++;
                }

                if (messagelabel != null)
                {
                    message["Label"] = ExpressionConverter.ConvertO(messagelabel);
                    messagepropCount++;
                }

                if (messagescheduledEnqueueTimeUtc != null)
                {
                    message["ScheduledEnqueueTimeUtc"] = ExpressionConverter.ConvertO(messagescheduledEnqueueTimeUtc);
                    messagepropCount++;
                }

                if (messagesessionId != null)
                {
                    message["SessionId"] = ExpressionConverter.ConvertO(messagesessionId);
                    messagepropCount++;
                }

                if (messagecorrelationId != null)
                {
                    message["CorrelationId"] = ExpressionConverter.ConvertO(messagecorrelationId);
                    messagepropCount++;
                }

                if (messagesequenceNumber != null)
                {
                    message["SequenceNumber"] = ExpressionConverter.ConvertO(messagesequenceNumber);
                    messagepropCount++;
                }

                if (messagelockToken != null)
                {
                    message["LockToken"] = ExpressionConverter.ConvertO(messagelockToken);
                    messagepropCount++;
                }

                if (messagetimeToLive != null)
                {
                    message["TimeToLive"] = ExpressionConverter.ConvertO(messagetimeToLive);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessages))]
        public IWorkflowAction SendMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<ServiceBusMessage[]> messages = null, [WorkflowExpression] Func<string> systemProperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendMessages(WorkflowValue<string> entityName, WorkflowValue<ServiceBusMessage[]> messages = null, WorkflowValue<string> systemProperties = null)
        {
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(messages, nameof(messages), required: false);
            WorkflowValue.Validate(systemProperties, nameof(systemProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (systemProperties != null)
                    callPayload.Queries["systemProperties"] = ExpressionConverter.Convert(systemProperties);
                callPayload.Body = ExpressionConverter.ConvertO(messages);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteMessageInQueue))]
        public IWorkflowAction CompleteMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompleteMessageInQueue(WorkflowValue<string> queueName, WorkflowValue<string> lockToken, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/complete", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildAbandonMessageInQueue))]
        public IWorkflowAction AbandonMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAbandonMessageInQueue(WorkflowValue<string> queueName, WorkflowValue<string> lockToken, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/abandon", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeferredMessageFromQueue))]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> sequenceNumber, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage> __BuildGetDeferredMessageFromQueue(WorkflowValue<string> queueName, WorkflowValue<int> sequenceNumber, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sequenceNumber"] = ExpressionConverter.Convert(sequenceNumber);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction<ServiceBusMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildDeferMessageInQueue))]
        public IWorkflowAction DeferMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeferMessageInQueue(WorkflowValue<string> queueName, WorkflowValue<string> lockToken, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildDeadLetterMessageInQueue))]
        public IWorkflowAction DeadLetterMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeadLetterMessageInQueue(WorkflowValue<string> queueName, WorkflowValue<string> lockToken, WorkflowValue<string> sessionId = null, WorkflowValue<string> deadLetterReason = null, WorkflowValue<string> deadLetterErrorDescription = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowValue.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/deadletter", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                callPayload.Queries["deadLetterReason"] = Convert.ToString("");
                if (deadLetterReason != null)
                    callPayload.Queries["deadLetterReason"] = ExpressionConverter.Convert(deadLetterReason);
                callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
                if (deadLetterErrorDescription != null)
                    callPayload.Queries["deadLetterErrorDescription"] = ExpressionConverter.Convert(deadLetterErrorDescription);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewLockOnMessageInQueue))]
        public IWorkflowAction RenewLockOnMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnMessageInQueue(WorkflowValue<string> queueName, WorkflowValue<string> lockToken, WorkflowValue<queueTypeInput> queueType = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/renewlock", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromQueueWithPeekLock))]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage[]> __BuildGetMessagesFromQueueWithPeekLock(WorkflowValue<string> queueName, WorkflowValue<int> maxMessageCount = null, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/peek", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction<ServiceBusMessage[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildCloseSessionInQueue))]
        public IWorkflowAction CloseSessionInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseSessionInQueue(WorkflowValue<string> queueName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/close", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewLockOnSessionInQueue))]
        public IWorkflowAction RenewLockOnSessionInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnSessionInQueue(WorkflowValue<string> queueName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/renewlock", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteMessageInTopic))]
        public IWorkflowAction CompleteMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompleteMessageInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/complete", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildAbandonMessageInTopic))]
        public IWorkflowAction AbandonMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAbandonMessageInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/abandon", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildGetDeferredMessageFromTopic))]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> sequenceNumber, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage> __BuildGetDeferredMessageFromTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<int> sequenceNumber, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sequenceNumber"] = ExpressionConverter.Convert(sequenceNumber);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction<ServiceBusMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildDeferMessageInTopic))]
        public IWorkflowAction DeferMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeferMessageInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildDeadLetterMessageInTopic))]
        public IWorkflowAction DeadLetterMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeadLetterMessageInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken, WorkflowValue<string> sessionId = null, WorkflowValue<string> deadLetterReason = null, WorkflowValue<string> deadLetterErrorDescription = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowValue.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/deadletter", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                callPayload.Queries["deadLetterReason"] = Convert.ToString("");
                if (deadLetterReason != null)
                    callPayload.Queries["deadLetterReason"] = ExpressionConverter.Convert(deadLetterReason);
                callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
                if (deadLetterErrorDescription != null)
                    callPayload.Queries["deadLetterErrorDescription"] = ExpressionConverter.Convert(deadLetterErrorDescription);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewLockOnMessageInTopic))]
        public IWorkflowAction RenewLockOnMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnMessageInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> lockToken, WorkflowValue<subscriptionTypeInput> subscriptionType = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/renewlock", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTopicSubscription))]
        public IBodyWorkflowAction<Subscription> CreateTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<object> subscriptionFilter = null, [WorkflowExpression] Func<subscriptionFilterTypeInput> subscriptionFilterType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Subscription> __BuildCreateTopicSubscription(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<object> subscriptionFilter = null, WorkflowValue<subscriptionFilterTypeInput> subscriptionFilterType = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(subscriptionFilter, nameof(subscriptionFilter), required: false);
            WorkflowValue.Validate(subscriptionFilterType, nameof(subscriptionFilterType), required: false);
            return new DeferredBodyAction<Subscription>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionFilterType"] = Convert.ToString("None");
                if (subscriptionFilterType != null)
                    callPayload.Queries["subscriptionFilterType"] = ExpressionConverter.Convert(subscriptionFilterType);
                callPayload.Body = ExpressionConverter.ConvertO(subscriptionFilter);
                return new ApiConnectionAction<Subscription>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTopicSubscription))]
        public IWorkflowAction DeleteTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTopicSubscription(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromTopicWithPeekLock))]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage[]> __BuildGetMessagesFromTopicWithPeekLock(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<int> maxMessageCount = null, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/peek", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction<ServiceBusMessage[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildCloseSessionInTopic))]
        public IWorkflowAction CloseSessionInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseSessionInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/close", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [WorkflowExpressionFactory(nameof(__BuildRenewLockOnSessionInTopic))]
        public IWorkflowAction RenewLockOnSessionInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnSessionInTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/renewlock", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ServicebusTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildGetMessageFromQueue))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetMessageFromQueue(WorkflowValue<string> queueName, WorkflowValue<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessageFromQueueWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetNewMessageFromQueueWithPeekLock(WorkflowValue<string> queueName, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/head/peek", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromQueue))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetMessagesFromQueue(WorkflowValue<string> queueName, WorkflowValue<int> maxMessageCount = null, WorkflowValue<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessagesFromQueueWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetNewMessagesFromQueueWithPeekLock(WorkflowValue<string> queueName, WorkflowValue<int> maxMessageCount = null, WorkflowValue<queueTypeInput> queueType = null, WorkflowValue<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowValue.Validate(queueType, nameof(queueType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head/peek", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessageFromTopic))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetMessageFromTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessageFromTopicWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetNewMessageFromTopicWithPeekLock(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head/peek", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromTopic))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetMessagesFromTopic(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<int> maxMessageCount = null, WorkflowValue<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessagesFromTopicWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetNewMessagesFromTopicWithPeekLock(WorkflowValue<string> topicName, WorkflowValue<string> subscriptionName, WorkflowValue<int> maxMessageCount = null, WorkflowValue<subscriptionTypeInput> subscriptionType = null, WorkflowValue<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowValue.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowValue.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head/peek", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class ServiceBusMessage
    {
        [JsonProperty("ContentData")]
        public string Content { get; set; }
        public string ContentType { get; set; }
        public JToken Properties { get; set; }
        public string MessageId { get; set; }
        public string To { get; set; }
        public string ReplyTo { get; set; }
        public string ReplyToSessionId { get; set; }
        public string Label { get; set; }
        public string ScheduledEnqueueTimeUtc { get; set; }
        public string SessionId { get; set; }
        public string CorrelationId { get; set; }
        public int SequenceNumber { get; set; }
        public string LockToken { get; set; }
        public string TimeToLive { get; set; }
    }

    public enum queueTypeInput
    {
        Main,
        DeadLetter
    }

    public enum subscriptionTypeInput
    {
        Main,
        DeadLetter
    }

    public class Subscription
    {
        public string SubscriptionName { get; set; }
    }

    public enum subscriptionFilterTypeInput
    {
        None,
        Correlation
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;

    public partial class WorkflowManagedActions
    {
        public ServicebusActions Servicebus(string connectionId) => new ServicebusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServicebusTriggers Servicebus(string connectionId) => new ServicebusTriggers(connectionId);
    }
}
