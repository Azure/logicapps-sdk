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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendMessage(WorkflowExpression<string> entityName, WorkflowExpression<JToken> messagecontent = null, WorkflowExpression<string> messagecontentType = null, WorkflowExpression<string> messagemessageId = null, WorkflowExpression<string> messageto = null, WorkflowExpression<string> messagereplyTo = null, WorkflowExpression<string> messagereplyToSessionId = null, WorkflowExpression<string> messagelabel = null, WorkflowExpression<string> messagescheduledEnqueueTimeUtc = null, WorkflowExpression<string> messagesessionId = null, WorkflowExpression<string> messagecorrelationId = null, WorkflowExpression<int> messagesequenceNumber = null, WorkflowExpression<string> messagelockToken = null, WorkflowExpression<string> messagetimeToLive = null, WorkflowExpression<string> systemProperties = null)
        {
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(messagecontent, nameof(messagecontent), required: false);
            WorkflowExpression.Validate(messagecontentType, nameof(messagecontentType), required: false);
            WorkflowExpression.Validate(messagemessageId, nameof(messagemessageId), required: false);
            WorkflowExpression.Validate(messageto, nameof(messageto), required: false);
            WorkflowExpression.Validate(messagereplyTo, nameof(messagereplyTo), required: false);
            WorkflowExpression.Validate(messagereplyToSessionId, nameof(messagereplyToSessionId), required: false);
            WorkflowExpression.Validate(messagelabel, nameof(messagelabel), required: false);
            WorkflowExpression.Validate(messagescheduledEnqueueTimeUtc, nameof(messagescheduledEnqueueTimeUtc), required: false);
            WorkflowExpression.Validate(messagesessionId, nameof(messagesessionId), required: false);
            WorkflowExpression.Validate(messagecorrelationId, nameof(messagecorrelationId), required: false);
            WorkflowExpression.Validate(messagesequenceNumber, nameof(messagesequenceNumber), required: false);
            WorkflowExpression.Validate(messagelockToken, nameof(messagelockToken), required: false);
            WorkflowExpression.Validate(messagetimeToLive, nameof(messagetimeToLive), required: false);
            WorkflowExpression.Validate(systemProperties, nameof(systemProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendMessages(WorkflowExpression<string> entityName, WorkflowExpression<ServiceBusMessage[]> messages = null, WorkflowExpression<string> systemProperties = null)
        {
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(messages, nameof(messages), required: false);
            WorkflowExpression.Validate(systemProperties, nameof(systemProperties), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompleteMessageInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> lockToken, WorkflowExpression<queueTypeInput> queueType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAbandonMessageInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> lockToken, WorkflowExpression<queueTypeInput> queueType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage> __BuildGetDeferredMessageFromQueue(WorkflowExpression<string> queueName, WorkflowExpression<int> sequenceNumber, WorkflowExpression<queueTypeInput> queueType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeferMessageInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> lockToken, WorkflowExpression<queueTypeInput> queueType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeadLetterMessageInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> lockToken, WorkflowExpression<string> sessionId = null, WorkflowExpression<string> deadLetterReason = null, WorkflowExpression<string> deadLetterErrorDescription = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowExpression.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowExpression.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnMessageInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> lockToken, WorkflowExpression<queueTypeInput> queueType = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage[]> __BuildGetMessagesFromQueueWithPeekLock(WorkflowExpression<string> queueName, WorkflowExpression<int> maxMessageCount = null, WorkflowExpression<queueTypeInput> queueType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseSessionInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> sessionId)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnSessionInQueue(WorkflowExpression<string> queueName, WorkflowExpression<string> sessionId)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompleteMessageInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> lockToken, WorkflowExpression<subscriptionTypeInput> subscriptionType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAbandonMessageInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> lockToken, WorkflowExpression<subscriptionTypeInput> subscriptionType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage> __BuildGetDeferredMessageFromTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<int> sequenceNumber, WorkflowExpression<subscriptionTypeInput> subscriptionType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(sequenceNumber, nameof(sequenceNumber), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeferMessageInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> lockToken, WorkflowExpression<subscriptionTypeInput> subscriptionType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeadLetterMessageInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> lockToken, WorkflowExpression<string> sessionId = null, WorkflowExpression<string> deadLetterReason = null, WorkflowExpression<string> deadLetterErrorDescription = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowExpression.Validate(deadLetterReason, nameof(deadLetterReason), required: false);
            WorkflowExpression.Validate(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnMessageInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> lockToken, WorkflowExpression<subscriptionTypeInput> subscriptionType = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(lockToken, nameof(lockToken), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Subscription> __BuildCreateTopicSubscription(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<object> subscriptionFilter = null, WorkflowExpression<subscriptionFilterTypeInput> subscriptionFilterType = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(subscriptionFilter, nameof(subscriptionFilter), required: false);
            WorkflowExpression.Validate(subscriptionFilterType, nameof(subscriptionFilterType), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTopicSubscription(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceBusMessage[]> __BuildGetMessagesFromTopicWithPeekLock(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<int> maxMessageCount = null, WorkflowExpression<subscriptionTypeInput> subscriptionType = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseSessionInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> sessionId)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenewLockOnSessionInTopic(WorkflowExpression<string> topicName, WorkflowExpression<string> subscriptionName, WorkflowExpression<string> sessionId)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
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
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromQueue([WorkflowExpression] Func<string> queueName,[WorkflowExpression] Func<queueTypeInput> queueType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetMessageFromQueue(WorkflowExpression<string> queueName,WorkflowExpression<queueTypeInput> queueType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessageFromQueueWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName,[WorkflowExpression] Func<queueTypeInput> queueType = null,[WorkflowExpression] Func<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetNewMessageFromQueueWithPeekLock(WorkflowExpression<string> queueName,WorkflowExpression<queueTypeInput> queueType = null,WorkflowExpression<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromQueue))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromQueue([WorkflowExpression] Func<string> queueName,[WorkflowExpression] Func<int> maxMessageCount = null,[WorkflowExpression] Func<queueTypeInput> queueType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetMessagesFromQueue(WorkflowExpression<string> queueName,WorkflowExpression<int> maxMessageCount = null,WorkflowExpression<queueTypeInput> queueType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
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
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessagesFromQueueWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName,[WorkflowExpression] Func<int> maxMessageCount = null,[WorkflowExpression] Func<queueTypeInput> queueType = null,[WorkflowExpression] Func<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetNewMessagesFromQueueWithPeekLock(WorkflowExpression<string> queueName,WorkflowExpression<int> maxMessageCount = null,WorkflowExpression<queueTypeInput> queueType = null,WorkflowExpression<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowExpression.Validate(queueType, nameof(queueType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessageFromTopic))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromTopic([WorkflowExpression] Func<string> topicName,[WorkflowExpression] Func<string> subscriptionName,[WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetMessageFromTopic(WorkflowExpression<string> topicName,WorkflowExpression<string> subscriptionName,WorkflowExpression<subscriptionTypeInput> subscriptionType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessageFromTopicWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName,[WorkflowExpression] Func<string> subscriptionName,[WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null,[WorkflowExpression] Func<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage> __BuildGetNewMessageFromTopicWithPeekLock(WorkflowExpression<string> topicName,WorkflowExpression<string> subscriptionName,WorkflowExpression<subscriptionTypeInput> subscriptionType = null,WorkflowExpression<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromTopic))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromTopic([WorkflowExpression] Func<string> topicName,[WorkflowExpression] Func<string> subscriptionName,[WorkflowExpression] Func<int> maxMessageCount = null,[WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetMessagesFromTopic(WorkflowExpression<string> topicName,WorkflowExpression<string> subscriptionName,WorkflowExpression<int> maxMessageCount = null,WorkflowExpression<subscriptionTypeInput> subscriptionType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
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
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetNewMessagesFromTopicWithPeekLock))]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName,[WorkflowExpression] Func<string> subscriptionName,[WorkflowExpression] Func<int> maxMessageCount = null,[WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null,[WorkflowExpression] Func<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceBusMessage[]> __BuildGetNewMessagesFromTopicWithPeekLock(WorkflowExpression<string> topicName,WorkflowExpression<string> subscriptionName,WorkflowExpression<int> maxMessageCount = null,WorkflowExpression<subscriptionTypeInput> subscriptionType = null,WorkflowExpression<string> sessionId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(topicName, nameof(topicName), required: true);
            WorkflowExpression.Validate(subscriptionName, nameof(subscriptionName), required: true);
            WorkflowExpression.Validate(maxMessageCount, nameof(maxMessageCount), required: false);
            WorkflowExpression.Validate(subscriptionType, nameof(subscriptionType), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
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
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
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