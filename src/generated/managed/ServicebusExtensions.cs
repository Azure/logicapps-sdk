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
        public IWorkflowAction SendMessage(Expression<Func<string>> entityName, Expression<Func<JToken>> messagecontent = null, Expression<Func<string>> messagecontentType = null, Expression<Func<string>> messagemessageId = null, Expression<Func<string>> messageto = null, Expression<Func<string>> messagereplyTo = null, Expression<Func<string>> messagereplyToSessionId = null, Expression<Func<string>> messagelabel = null, Expression<Func<string>> messagescheduledEnqueueTimeUtc = null, Expression<Func<string>> messagesessionId = null, Expression<Func<string>> messagecorrelationId = null, Expression<Func<int>> messagesequenceNumber = null, Expression<Func<string>> messagelockToken = null, Expression<Func<string>> messagetimeToLive = null, Expression<Func<string>> systemProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["systemProperties"] = Convert.ToString("None");
            if (systemProperties != null)
                callPayload.Queries["systemProperties"] = CSharpExpressionConverter.ConvertO(systemProperties);
            var message = new JObject();
            var messagepropCount = 0;
            if (messagecontent != null)
            {
                message["ContentData"] = CSharpExpressionConverter.ConvertOWithBase64(messagecontent);
                messagepropCount++;
            }

            if (messagecontentType != null)
            {
                message["ContentType"] = CSharpExpressionConverter.ConvertToken(messagecontentType);
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
                message["MessageId"] = CSharpExpressionConverter.ConvertToken(messagemessageId);
                messagepropCount++;
            }

            if (messageto != null)
            {
                message["To"] = CSharpExpressionConverter.ConvertToken(messageto);
                messagepropCount++;
            }

            if (messagereplyTo != null)
            {
                message["ReplyTo"] = CSharpExpressionConverter.ConvertToken(messagereplyTo);
                messagepropCount++;
            }

            if (messagereplyToSessionId != null)
            {
                message["ReplyToSessionId"] = CSharpExpressionConverter.ConvertToken(messagereplyToSessionId);
                messagepropCount++;
            }

            if (messagelabel != null)
            {
                message["Label"] = CSharpExpressionConverter.ConvertToken(messagelabel);
                messagepropCount++;
            }

            if (messagescheduledEnqueueTimeUtc != null)
            {
                message["ScheduledEnqueueTimeUtc"] = CSharpExpressionConverter.ConvertToken(messagescheduledEnqueueTimeUtc);
                messagepropCount++;
            }

            if (messagesessionId != null)
            {
                message["SessionId"] = CSharpExpressionConverter.ConvertToken(messagesessionId);
                messagepropCount++;
            }

            if (messagecorrelationId != null)
            {
                message["CorrelationId"] = CSharpExpressionConverter.ConvertToken(messagecorrelationId);
                messagepropCount++;
            }

            if (messagesequenceNumber != null)
            {
                message["SequenceNumber"] = CSharpExpressionConverter.ConvertToken(messagesequenceNumber);
                messagepropCount++;
            }

            if (messagelockToken != null)
            {
                message["LockToken"] = CSharpExpressionConverter.ConvertToken(messagelockToken);
                messagepropCount++;
            }

            if (messagetimeToLive != null)
            {
                message["TimeToLive"] = CSharpExpressionConverter.ConvertToken(messagetimeToLive);
                messagepropCount++;
            }

            if (messagepropCount > 0)
            {
                callPayload.Body = message;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction SendMessages(Expression<Func<string>> entityName, Expression<Func<ServiceBusMessage[]>> messages = null, Expression<Func<string>> systemProperties = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["systemProperties"] = Convert.ToString("None");
            if (systemProperties != null)
                callPayload.Queries["systemProperties"] = CSharpExpressionConverter.ConvertO(systemProperties);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(messages);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/complete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/abandon", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromQueue(Expression<Func<string>> queueName, Expression<Func<int>> sequenceNumber, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sequenceNumber"] = CSharpExpressionConverter.ConvertO(sequenceNumber);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction<ServiceBusMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/defer", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<string>> sessionId = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/deadletter", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            callPayload.Queries["deadLetterReason"] = Convert.ToString("");
            if (deadLetterReason != null)
                callPayload.Queries["deadLetterReason"] = CSharpExpressionConverter.ConvertO(deadLetterReason);
            callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
            if (deadLetterErrorDescription != null)
                callPayload.Queries["deadLetterErrorDescription"] = CSharpExpressionConverter.ConvertO(deadLetterErrorDescription);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/renewlock", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/peek", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = CSharpExpressionConverter.ConvertO(maxMessageCount);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction<ServiceBusMessage[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInQueue(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/close", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInQueue(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/sessions/{1}/renewlock", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/complete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/abandon", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> sequenceNumber, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sequenceNumber"] = CSharpExpressionConverter.ConvertO(sequenceNumber);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction<ServiceBusMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/defer", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<string>> sessionId = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/deadletter", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            callPayload.Queries["deadLetterReason"] = Convert.ToString("");
            if (deadLetterReason != null)
                callPayload.Queries["deadLetterReason"] = CSharpExpressionConverter.ConvertO(deadLetterReason);
            callPayload.Queries["deadLetterErrorDescription"] = Convert.ToString("");
            if (deadLetterErrorDescription != null)
                callPayload.Queries["deadLetterErrorDescription"] = CSharpExpressionConverter.ConvertO(deadLetterErrorDescription);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/renewlock", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = CSharpExpressionConverter.ConvertO(lockToken);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<Subscription> CreateTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<object>> subscriptionFilter = null, Expression<Func<subscriptionFilterTypeInput>> subscriptionFilterType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionFilterType"] = Convert.ToString("None");
            if (subscriptionFilterType != null)
                callPayload.Queries["subscriptionFilterType"] = CSharpExpressionConverter.Convert(subscriptionFilterType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(subscriptionFilter);
            return new ApiConnectionAction<Subscription>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeleteTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/peek", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = CSharpExpressionConverter.ConvertO(maxMessageCount);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction<ServiceBusMessage[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/close", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/renewlock", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ServicebusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromQueue(Expression<Func<string>> queueName, Expression<Func<queueTypeInput>> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/head", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/head/peek", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("None");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromQueue(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = CSharpExpressionConverter.ConvertO(maxMessageCount);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/messages/batch/head/peek", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = CSharpExpressionConverter.ConvertO(maxMessageCount);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = CSharpExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("None");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<subscriptionTypeInput>> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/head/peek", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("None");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = CSharpExpressionConverter.ConvertO(maxMessageCount);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/subscriptions/{1}/messages/batch/head/peek", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = CSharpExpressionConverter.ConvertO(maxMessageCount);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = CSharpExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("None");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
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