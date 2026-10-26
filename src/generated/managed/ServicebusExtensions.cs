//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServicebusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> entityName, Expression<Func<SendMessageInput>> message, Expression<Func<string>> systemProperties = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            var __workflow_systemProperties = WorkflowExpression.Compile(systemProperties, nameof(systemProperties), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages", __workflow_entityName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["systemProperties"] = Convert.ToString("None");
                if (__workflow_systemProperties != null)
                    callPayload.Queries["systemProperties"] = ExpressionConverter.Convert(__workflow_systemProperties);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendMessages(Expression<Func<string>> entityName, Expression<Func<ServiceBusMessage[]>> messages, Expression<Func<string>> systemProperties = null)
        {
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_messages = WorkflowExpression.Compile(messages, nameof(messages), required: true);
            var __workflow_systemProperties = WorkflowExpression.Compile(systemProperties, nameof(systemProperties), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/batch", __workflow_entityName.WithUrlEncoding(2)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CompleteMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/complete", __workflow_queueName.WithUrlEncoding(2)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AbandonMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/abandon", __workflow_queueName.WithUrlEncoding(2)));
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
        public IBodyWorkflowAction<ServiceBusMessage, ApiConnectionActionConfiguration> GetDeferredMessageFromQueue(Expression<Func<string>> queueName, Expression<Func<int>> sequenceNumber, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/defer", __workflow_queueName.WithUrlEncoding(2)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeferMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/defer", __workflow_queueName.WithUrlEncoding(2)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeadLetterMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<string>> sessionId = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/deadletter", __workflow_queueName.WithUrlEncoding(2)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> RenewLockOnMessageInQueue(Expression<Func<string>> queueName, Expression<Func<string>> lockToken, Expression<Func<queueTypeInput>> queueType = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/renewlock", __workflow_queueName.WithUrlEncoding(2)));
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
        public IBodyWorkflowAction<ServiceBusMessage[], ApiConnectionActionConfiguration> GetMessagesFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/batch/peek", __workflow_queueName.WithUrlEncoding(2)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseSessionInQueue(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/sessions/{1}/close", __workflow_queueName.WithUrlEncoding(2), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RenewLockOnSessionInQueue(Expression<Func<string>> queueName, Expression<Func<string>> sessionId)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/sessions/{1}/renewlock", __workflow_queueName.WithUrlEncoding(2), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompleteMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/complete", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AbandonMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/abandon", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<ServiceBusMessage, ApiConnectionActionConfiguration> GetDeferredMessageFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> sequenceNumber, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sequenceNumber = WorkflowExpression.Compile(sequenceNumber, nameof(sequenceNumber), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/defer", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeferMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/defer", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeadLetterMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<string>> sessionId = null, Expression<Func<string>> deadLetterReason = null, Expression<Func<string>> deadLetterErrorDescription = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_deadLetterReason = WorkflowExpression.Compile(deadLetterReason, nameof(deadLetterReason), required: false);
            var __workflow_deadLetterErrorDescription = WorkflowExpression.Compile(deadLetterErrorDescription, nameof(deadLetterErrorDescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/deadletter", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> RenewLockOnMessageInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> lockToken, Expression<Func<subscriptionTypeInput>> subscriptionType = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_lockToken = WorkflowExpression.Compile(lockToken, nameof(lockToken), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/renewlock", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<Subscription, ApiConnectionActionConfiguration> CreateTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<object>> subscriptionFilter, Expression<Func<subscriptionFilterTypeInput>> subscriptionFilterType = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_subscriptionFilter = WorkflowExpression.Compile(subscriptionFilter, nameof(subscriptionFilter), required: true);
            var __workflow_subscriptionFilterType = WorkflowExpression.Compile(subscriptionFilterType, nameof(subscriptionFilterType), required: false);
            return new DeferredBodyAction<Subscription, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTopicSubscription(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IBodyWorkflowAction<ServiceBusMessage[], ApiConnectionActionConfiguration> GetMessagesFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ServiceBusMessage[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/batch/peek", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseSessionInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/close", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicebus")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RenewLockOnSessionInTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<string>> sessionId)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/sessions/{2}/renewlock", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ServicebusTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration> GetMessageFromQueue(Expression<Func<string>> queueName, Expression<Func<queueTypeInput>> queueType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/head", __workflow_queueName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueType"] = Convert.ToString("Main");
                if (__workflow_queueType != null)
                    callPayload.Queries["queueType"] = ExpressionConverter.Convert(__workflow_queueType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration> GetNewMessageFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/head/peek", __workflow_queueName.WithUrlEncoding(2)));
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

        public IBodyWorkflowTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration> GetMessagesFromQueue(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/batch/head", __workflow_queueName.WithUrlEncoding(2)));
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

        public IBodyWorkflowTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration> GetNewMessagesFromQueueWithPeekLock(Expression<Func<string>> queueName, Expression<Func<int>> maxMessageCount = null, Expression<Func<queueTypeInput>> queueType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_queueType = WorkflowExpression.Compile(queueType, nameof(queueType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/messages/batch/head/peek", __workflow_queueName.WithUrlEncoding(2)));
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

        public IBodyWorkflowTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration> GetMessageFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<subscriptionTypeInput>> subscriptionType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/head", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionType"] = Convert.ToString("Main");
                if (__workflow_subscriptionType != null)
                    callPayload.Queries["subscriptionType"] = ExpressionConverter.Convert(__workflow_subscriptionType);
                return new ApiConnectionTrigger<ServiceBusMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration> GetNewMessageFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/head/peek", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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

        public IBodyWorkflowTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration> GetMessagesFromTopic(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/batch/head", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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

        public IBodyWorkflowTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration> GetNewMessagesFromTopicWithPeekLock(Expression<Func<string>> topicName, Expression<Func<string>> subscriptionName, Expression<Func<int>> maxMessageCount = null, Expression<Func<subscriptionTypeInput>> subscriptionType = null, Expression<Func<string>> sessionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_subscriptionName = WorkflowExpression.Compile(subscriptionName, nameof(subscriptionName), required: true);
            var __workflow_maxMessageCount = WorkflowExpression.Compile(maxMessageCount, nameof(maxMessageCount), required: false);
            var __workflow_subscriptionType = WorkflowExpression.Compile(subscriptionType, nameof(subscriptionType), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyTrigger<ServiceBusMessage[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/subscriptions/{1}/messages/batch/head/peek", __workflow_topicName.WithUrlEncoding(2), __workflow_subscriptionName.WithUrlEncoding(1)));
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

    public class SendMessageInput
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
        public int? SequenceNumber { get; set; }
        public string LockToken { get; set; }
        public string TimeToLive { get; set; }
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