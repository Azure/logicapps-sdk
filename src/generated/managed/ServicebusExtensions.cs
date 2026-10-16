//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ServicebusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction SendMessage(Expression<Func<string>> entityName, Expression<Func<JToken>> messagecontent = null, Expression<Func<string>> messagecontentType = null, Expression<Func<string>> messagemessageId = null, Expression<Func<string>> messageto = null, Expression<Func<string>> messagereplyTo = null, Expression<Func<string>> messagereplyToSessionId = null, Expression<Func<string>> messagelabel = null, Expression<Func<string>> messagescheduledEnqueueTimeUtc = null, Expression<Func<string>> messagesessionId = null, Expression<Func<string>> messagecorrelationId = null, Expression<Func<int>> messagesequenceNumber = null, Expression<Func<string>> messagelockToken = null, Expression<Func<string>> messagetimeToLive = null, Expression<Func<string>> systemProperties = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_messagecontent = WorkflowExpression.Compile(messagecontent, nameof(messagecontent), required: false);
            var __workflow_messagecontentType = WorkflowExpression.Compile(messagecontentType, nameof(messagecontentType), required: false);
            var __workflow_messagemessageId = WorkflowExpression.Compile(messagemessageId, nameof(messagemessageId), required: false);
            var __workflow_messageto = WorkflowExpression.Compile(messageto, nameof(messageto), required: false);
            var __workflow_messagereplyTo = WorkflowExpression.Compile(messagereplyTo, nameof(messagereplyTo), required: false);
            var __workflow_messagereplyToSessionId = WorkflowExpression.Compile(messagereplyToSessionId, nameof(messagereplyToSessionId), required: false);
            var __workflow_messagelabel = WorkflowExpression.Compile(messagelabel, nameof(messagelabel), required: false);
            var __workflow_messagescheduledEnqueueTimeUtc = WorkflowExpression.Compile(messagescheduledEnqueueTimeUtc, nameof(messagescheduledEnqueueTimeUtc), required: false);
            var __workflow_messagesessionId = WorkflowExpression.Compile(messagesessionId, nameof(messagesessionId), required: false);
            var __workflow_messagecorrelationId = WorkflowExpression.Compile(messagecorrelationId, nameof(messagecorrelationId), required: false);
            var __workflow_messagesequenceNumber = WorkflowExpression.Compile(messagesequenceNumber, nameof(messagesequenceNumber), required: false);
            var __workflow_messagelockToken = WorkflowExpression.Compile(messagelockToken, nameof(messagelockToken), required: false);
            var __workflow_messagetimeToLive = WorkflowExpression.Compile(messagetimeToLive, nameof(messagetimeToLive), required: false);
            var __workflow_systemProperties = WorkflowExpression.Compile(systemProperties, nameof(systemProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (__workflow_systemProperties != null)
                    callPayload.Queries["systemProperties"] = ExpressionConverter.Convert(__workflow_systemProperties);
                var message = new JObject();
                var messagepropCount = 0;
                if (__workflow_messagecontent != null)
                {
                    message["ContentData"] = ExpressionConverter.ConvertOWithBase64(__workflow_messagecontent);
                    messagepropCount++;
                }

                if (__workflow_messagecontentType != null)
                {
                    message["ContentType"] = ExpressionConverter.ConvertO(__workflow_messagecontentType);
                    messagepropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    message["Properties"] = propertiesObject;
                    messagepropCount++;
                }

                if (__workflow_messagemessageId != null)
                {
                    message["MessageId"] = ExpressionConverter.ConvertO(__workflow_messagemessageId);
                    messagepropCount++;
                }

                if (__workflow_messageto != null)
                {
                    message["To"] = ExpressionConverter.ConvertO(__workflow_messageto);
                    messagepropCount++;
                }

                if (__workflow_messagereplyTo != null)
                {
                    message["ReplyTo"] = ExpressionConverter.ConvertO(__workflow_messagereplyTo);
                    messagepropCount++;
                }

                if (__workflow_messagereplyToSessionId != null)
                {
                    message["ReplyToSessionId"] = ExpressionConverter.ConvertO(__workflow_messagereplyToSessionId);
                    messagepropCount++;
                }

                if (__workflow_messagelabel != null)
                {
                    message["Label"] = ExpressionConverter.ConvertO(__workflow_messagelabel);
                    messagepropCount++;
                }

                if (__workflow_messagescheduledEnqueueTimeUtc != null)
                {
                    message["ScheduledEnqueueTimeUtc"] = ExpressionConverter.ConvertO(__workflow_messagescheduledEnqueueTimeUtc);
                    messagepropCount++;
                }

                if (__workflow_messagesessionId != null)
                {
                    message["SessionId"] = ExpressionConverter.ConvertO(__workflow_messagesessionId);
                    messagepropCount++;
                }

                if (__workflow_messagecorrelationId != null)
                {
                    message["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_messagecorrelationId);
                    messagepropCount++;
                }

                if (__workflow_messagesequenceNumber != null)
                {
                    message["SequenceNumber"] = ExpressionConverter.ConvertO(__workflow_messagesequenceNumber);
                    messagepropCount++;
                }

                if (__workflow_messagelockToken != null)
                {
                    message["LockToken"] = ExpressionConverter.ConvertO(__workflow_messagelockToken);
                    messagepropCount++;
                }

                if (__workflow_messagetimeToLive != null)
                {
                    message["TimeToLive"] = ExpressionConverter.ConvertO(__workflow_messagetimeToLive);
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
        public IWorkflowAction SendMessages(Expression<Func<string>> entityName, Expression<Func<ServiceBusMessage[]>> messages = null, Expression<Func<string>> systemProperties = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_messages = WorkflowExpression.Compile(messages, nameof(messages), required: false);
            var __workflow_systemProperties = WorkflowExpression.Compile(systemProperties, nameof(systemProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (__workflow_systemProperties != null)
                    callPayload.Queries["systemProperties"] = ExpressionConverter.Convert(__workflow_systemProperties);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messages);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/complete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/abandon", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromQueue(Expression<Func<string>> queueName, Expression<Func<int>> sequenceNumber, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sequenceNumber"] = ExpressionConverter.Convert(__workflow_sequenceNumber);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<ServiceBusMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<string>> sessionId = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/deadletter", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                callPayload.Queries["deadLetterReason"] = Convert.ToString("");
                if (__workflow_deadLetterReason != null)
                    callPayload.Queries["deadLetterReason"] = ExpressionConverter.Convert(__workflow_deadLetterReason);
                callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
                if (__workflow_deadLetterErrorDescription != null)
                    callPayload.Queries["deadLetterErrorDescription"] = ExpressionConverter.Convert(__workflow_deadLetterErrorDescription);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/renewlock", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/peek", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (__workflow_maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(__workflow_maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<ServiceBusMessage[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInQueue(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/close", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_sessionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInQueue(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/renewlock", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/complete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/abandon", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> sequenceNumber, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sequenceNumber"] = ExpressionConverter.Convert(__workflow_sequenceNumber);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<ServiceBusMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<string>> sessionId = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/deadletter", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                callPayload.Queries["deadLetterReason"] = Convert.ToString("");
                if (__workflow_deadLetterReason != null)
                    callPayload.Queries["deadLetterReason"] = ExpressionConverter.Convert(__workflow_deadLetterReason);
                callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
                if (__workflow_deadLetterErrorDescription != null)
                    callPayload.Queries["deadLetterErrorDescription"] = ExpressionConverter.Convert(__workflow_deadLetterErrorDescription);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/renewlock", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = ExpressionConverter.Convert(__workflow_lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<Subscription> CreateTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<object>> subscriptionFilter = null, Expression<Func<subscriptionFilterTypeInput>> subscriptionFilterType = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_subscriptionFilter = WorkflowExpression.Compile(subscriptionFilter, nameof(subscriptionFilter), required: false);
            var __workflow_subscriptionFilterType = WorkflowExpression.Compile(subscriptionFilterType, nameof(subscriptionFilterType), required: false);
            return new DeferredBodyAction<Subscription>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionFilterType"] = Convert.ToString("None");
                if (__workflow_subscriptionFilterType != null)
                    callPayload.Queries["subscriptionFilterType"] = ExpressionConverter.Convert(__workflow_subscriptionFilterType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscriptionFilter);
                return new ApiConnectionAction<Subscription>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeleteTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/peek", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (__workflow_maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(__workflow_maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<ServiceBusMessage[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/close", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_sessionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/renewlock", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ServicebusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromQueue(Expression<Func<string>> queueName, Expression<Func<queueTypeInput>> queueType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/head/peek", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromQueue(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (__workflow_maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(__workflow_maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head/peek", ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (__workflow_maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(__workflow_maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<subscriptionTypeInput>> subscriptionType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head/peek", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (__workflow_maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(__workflow_maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head/peek", ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (__workflow_maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(__workflow_maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum queueTypeInput
    {
        Main,
        DeadLetter
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum subscriptionTypeInput
    {
        Main,
        DeadLetter
    }

    public class Subscription
    {
        public string SubscriptionName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
