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
        public IWorkflowAction SendMessage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<JToken> messagecontent = null, [WorkflowExpression] Func<string> messagecontentType = null, [WorkflowExpression] Func<string> messagemessageId = null, [WorkflowExpression] Func<string> messageto = null, [WorkflowExpression] Func<string> messagereplyTo = null, [WorkflowExpression] Func<string> messagereplyToSessionId = null, [WorkflowExpression] Func<string> messagelabel = null, [WorkflowExpression] Func<string> messagescheduledEnqueueTimeUtc = null, [WorkflowExpression] Func<string> messagesessionId = null, [WorkflowExpression] Func<string> messagecorrelationId = null, [WorkflowExpression] Func<int> messagesequenceNumber = null, [WorkflowExpression] Func<string> messagelockToken = null, [WorkflowExpression] Func<string> messagetimeToLive = null, [WorkflowExpression] Func<string> systemProperties = null)
        {
            var apiCallPath = String.Format("/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction SendMessages([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<ServiceBusMessage[]> messages = null, [WorkflowExpression] Func<string> systemProperties = null)
        {
            var apiCallPath = String.Format("/{0}/messages/batch", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["systemProperties"] = Convert.ToString("None");
            if (systemProperties != null)
                callPayload.Queries["systemProperties"] = ExpressionConverter.Convert(systemProperties);
            callPayload.Body = ExpressionConverter.ConvertO(messages);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/messages/complete", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/messages/abandon", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<int> sequenceNumber, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            var apiCallPath = String.Format("/{0}/messages/deadletter", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<queueTypeInput> queueType = null)
        {
            var apiCallPath = String.Format("/{0}/messages/renewlock", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromQueueWithPeekLock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/messages/batch/peek", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            var apiCallPath = String.Format("/{0}/sessions/{1}/close", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<string> sessionId)
        {
            var apiCallPath = String.Format("/{0}/sessions/{1}/renewlock", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CompleteMessageInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/complete", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction AbandonMessageInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/abandon", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage> GetDeferredMessageFromTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<int> sequenceNumber, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeferMessageInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/defer", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeadLetterMessageInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> deadLetterReason = null, [WorkflowExpression] Func<string> deadLetterErrorDescription = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/deadletter", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnMessageInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<string> lockToken, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/renewlock", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lockToken"] = ExpressionConverter.Convert(lockToken);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<Subscription> CreateTopicSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<object> subscriptionFilter = null, [WorkflowExpression] Func<subscriptionFilterTypeInput> subscriptionFilterType = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionFilterType"] = Convert.ToString("None");
            if (subscriptionFilterType != null)
                callPayload.Queries["subscriptionFilterType"] = ExpressionConverter.Convert(subscriptionFilterType);
            callPayload.Body = ExpressionConverter.ConvertO(subscriptionFilter);
            return new ApiConnectionAction<Subscription>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction DeleteTopicSubscription([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[]> GetMessagesFromTopicWithPeekLock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/batch/peek", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction CloseSessionInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sessionId)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/sessions/{2}/close", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction RenewLockOnSessionInTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sessionId)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/sessions/{2}/renewlock", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1), ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ServicebusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromQueueWithPeekLock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/messages/head/peek", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
            callPayload.Queries["sessionId"] = Convert.ToString("None");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromQueue([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/messages/batch/head", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
            callPayload.Queries["queueType"] = Convert.ToString("Main");
            if (queueType != null)
                callPayload.Queries["queueType"] = ExpressionConverter.Convert(queueType);
            return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromQueueWithPeekLock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> queueName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<queueTypeInput> queueType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/messages/batch/head/peek", ExpressionConverter.ConvertWithUrlEncoding(queueName, 2));
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
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetMessageFromTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/head", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage> GetNewMessageFromTopicWithPeekLock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/head/peek", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
            callPayload.Queries["sessionId"] = Convert.ToString("None");
            if (sessionId != null)
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetMessagesFromTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/batch/head", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maxMessageCount"] = Convert.ToString(20);
            if (maxMessageCount != null)
                callPayload.Queries["maxMessageCount"] = ExpressionConverter.Convert(maxMessageCount);
            callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
            if (subscriptionType != null)
                callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(subscriptionType);
            return new ApiConnectionTrigger<ServiceBusMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceBusMessage[]> GetNewMessagesFromTopicWithPeekLock([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriptionName, [WorkflowExpression] Func<int> maxMessageCount = null, [WorkflowExpression] Func<subscriptionTypeInput> subscriptionType = null, [WorkflowExpression] Func<string> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/{0}/subscriptions/{1}/messages/batch/head/peek", ExpressionConverter.ConvertWithUrlEncoding(topicName, 2), ExpressionConverter.ConvertWithUrlEncoding(subscriptionName, 1));
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