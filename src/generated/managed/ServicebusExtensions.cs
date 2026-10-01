//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServicebusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction SendMessage([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<JToken> messagecontent = null, [WorkflowExpression] Func<string> messagecontentType = null, [WorkflowExpression] Func<string> messagemessageId = null, [WorkflowExpression] Func<string> messageto = null, [WorkflowExpression] Func<string> messagereplyTo = null, [WorkflowExpression] Func<string> messagereplyToSessionId = null, [WorkflowExpression] Func<string> messagelabel = null, [WorkflowExpression] Func<string> messagescheduledEnqueueTimeUtc = null, [WorkflowExpression] Func<string> messagesessionId = null, [WorkflowExpression] Func<string> messagecorrelationId = null, [WorkflowExpression] Func<int> messagesequenceNumber = null, [WorkflowExpression] Func<string> messagelockToken = null, [WorkflowExpression] Func<string> messagetimeToLive = null, [WorkflowExpression] Func<string> systemProperties = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (systemProperties != null)
                    callPayload.Queries["systemProperties"] = SourceExpressionConverter.ConvertO(systemProperties);
                var message = new JObject();
                var messagepropCount = 0;
                if (messagecontent != null)
                {
                    message["ContentData"] = SourceExpressionConverter.ConvertOWithBase64(messagecontent);
                    messagepropCount++;
                }

                if (messagecontentType != null)
                {
                    message["ContentType"] = SourceExpressionConverter.ConvertToken(messagecontentType);
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
                    message["MessageId"] = SourceExpressionConverter.ConvertToken(messagemessageId);
                    messagepropCount++;
                }

                if (messageto != null)
                {
                    message["To"] = SourceExpressionConverter.ConvertToken(messageto);
                    messagepropCount++;
                }

                if (messagereplyTo != null)
                {
                    message["ReplyTo"] = SourceExpressionConverter.ConvertToken(messagereplyTo);
                    messagepropCount++;
                }

                if (messagereplyToSessionId != null)
                {
                    message["ReplyToSessionId"] = SourceExpressionConverter.ConvertToken(messagereplyToSessionId);
                    messagepropCount++;
                }

                if (messagelabel != null)
                {
                    message["Label"] = SourceExpressionConverter.ConvertToken(messagelabel);
                    messagepropCount++;
                }

                if (messagescheduledEnqueueTimeUtc != null)
                {
                    message["ScheduledEnqueueTimeUtc"] = SourceExpressionConverter.ConvertToken(messagescheduledEnqueueTimeUtc);
                    messagepropCount++;
                }

                if (messagesessionId != null)
                {
                    message["SessionId"] = SourceExpressionConverter.ConvertToken(messagesessionId);
                    messagepropCount++;
                }

                if (messagecorrelationId != null)
                {
                    message["CorrelationId"] = SourceExpressionConverter.ConvertToken(messagecorrelationId);
                    messagepropCount++;
                }

                if (messagesequenceNumber != null)
                {
                    message["SequenceNumber"] = SourceExpressionConverter.ConvertToken(messagesequenceNumber);
                    messagepropCount++;
                }

                if (messagelockToken != null)
                {
                    message["LockToken"] = SourceExpressionConverter.ConvertToken(messagelockToken);
                    messagepropCount++;
                }

                if (messagetimeToLive != null)
                {
                    message["TimeToLive"] = SourceExpressionConverter.ConvertToken(messagetimeToLive);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction SendMessages([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<ServiceBusMessage[]> messages = null, [WorkflowExpression] Func<string> systemProperties = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (systemProperties != null)
                    callPayload.Queries["systemProperties"] = SourceExpressionConverter.ConvertO(systemProperties);
                callPayload.Body = SourceExpressionConverter.ConvertToken(messages);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/complete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/abandon", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> sequenceNumber, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sequenceNumber"] = SourceExpressionConverter.ConvertO(sequenceNumber);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction<ServiceBusMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/deadletter", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["deadLetterReason"] = Convert.ToString("");
                if (deadLetterReason != null)
                    callPayload.Queries["deadLetterReason"] = SourceExpressionConverter.ConvertO(deadLetterReason);
                callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
                if (deadLetterErrorDescription != null)
                    callPayload.Queries["deadLetterErrorDescription"] = SourceExpressionConverter.ConvertO(deadLetterErrorDescription);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/renewlock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/peek", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = SourceExpressionConverter.ConvertO(maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction<ServiceBusMessage[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/close", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/renewlock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/complete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/abandon", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> sequenceNumber, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sequenceNumber"] = SourceExpressionConverter.ConvertO(sequenceNumber);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction<ServiceBusMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/deadletter", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["deadLetterReason"] = Convert.ToString("");
                if (deadLetterReason != null)
                    callPayload.Queries["deadLetterReason"] = SourceExpressionConverter.ConvertO(deadLetterReason);
                callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
                if (deadLetterErrorDescription != null)
                    callPayload.Queries["deadLetterErrorDescription"] = SourceExpressionConverter.ConvertO(deadLetterErrorDescription);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/renewlock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockToken"] = SourceExpressionConverter.ConvertO(lockToken);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<Subscription> CreateTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<object> subscriptionFilter = null, [WorkflowExpression] Func<subscriptionFilterTypeInput> subscriptionFilterType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionFilterType"] = Convert.ToString("None");
                if (subscriptionFilterType != null)
                    callPayload.Queries["subscriptionFilterType"] = SourceExpressionConverter.Convert(subscriptionFilterType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(subscriptionFilter);
                return callPayload;
            }

            return new ApiConnectionAction<Subscription>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeleteTopicSubscription([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/peek", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = SourceExpressionConverter.ConvertO(maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction<ServiceBusMessage[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/close", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<string> sessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/renewlock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class ServicebusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/head", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/head/peek", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromQueue([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = SourceExpressionConverter.ConvertO(maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromQueueWithPeekLock([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head/peek", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = SourceExpressionConverter.ConvertO(maxMessageCount);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (queueType != null)
                    callPayload.Queries["queueType"] = SourceExpressionConverter.Convert(queueType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head/peek", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromTopic([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = SourceExpressionConverter.ConvertO(maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromTopicWithPeekLock([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head/peek", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
                if (maxMessageCount != null)
                    callPayload.Queries["maxMessageCount"] = SourceExpressionConverter.ConvertO(maxMessageCount);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = SourceExpressionConverter.Convert(subscriptionType);
                callPayload.Queries["sessionId"] = Convert.ToString("None");
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceBusMessage[]>(BuildSourceInput, triggerName, recurrence);
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