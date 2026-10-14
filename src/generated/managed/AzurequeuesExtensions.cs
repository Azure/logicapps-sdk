//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurequeues
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IWorkflowAction DeleteMessage(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popreceipt)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            var __workflow_popreceipt = popreceipt == null ? null : WorkflowExpression.Compile(popreceipt);
            WorkflowExpression.Validate(__workflow_popreceipt, nameof(popreceipt), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["popreceipt"] = ExpressionConverter.Convert(__workflow_popreceipt);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Messages> GetMessages(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> numofmessages = null, Expression<Func<string>> visibilitytimeout = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: true);
            var __workflow_numofmessages = numofmessages == null ? null : WorkflowExpression.Compile(numofmessages);
            WorkflowExpression.Validate(__workflow_numofmessages, nameof(numofmessages), required: false);
            var __workflow_visibilitytimeout = visibilitytimeout == null ? null : WorkflowExpression.Compile(visibilitytimeout);
            WorkflowExpression.Validate(__workflow_visibilitytimeout, nameof(visibilitytimeout), required: false);
            return new DeferredBodyAction<Messages>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_numofmessages != null)
                    callPayload.Queries["numofmessages"] = ExpressionConverter.Convert(__workflow_numofmessages);
                if (__workflow_visibilitytimeout != null)
                    callPayload.Queries["visibilitytimeout"] = ExpressionConverter.Convert(__workflow_visibilitytimeout);
                return new ApiConnectionAction<Messages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Queue[]> ListQueues(Expression<Func<string>> storageAccountName)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            return new DeferredBodyAction<Queue[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/list", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Queue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IWorkflowAction PutMessage(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> message = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: true);
            var __workflow_message = message == null ? null : WorkflowExpression.Compile(message);
            WorkflowExpression.Validate(__workflow_message, nameof(message), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_message);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Messages> OnMessages(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> visibilitytimeout = null, FlowRecurrence recurrence = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: true);
            var __workflow_visibilitytimeout = visibilitytimeout == null ? null : WorkflowExpression.Compile(visibilitytimeout);
            WorkflowExpression.Validate(__workflow_visibilitytimeout, nameof(visibilitytimeout), required: false);
            return new DeferredBodyTrigger<Messages>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/message_trigger", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_visibilitytimeout != null)
                    callPayload.Queries["visibilitytimeout"] = ExpressionConverter.Convert(__workflow_visibilitytimeout);
                return new ApiConnectionTrigger<Messages>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string> OnMessageThresholdReached(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<int>> threshold, FlowRecurrence recurrence = null)
        {
            var __workflow_storageAccountName = storageAccountName == null ? null : WorkflowExpression.Compile(storageAccountName);
            WorkflowExpression.Validate(__workflow_storageAccountName, nameof(storageAccountName), required: true);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: true);
            var __workflow_threshold = threshold == null ? null : WorkflowExpression.Compile(threshold);
            WorkflowExpression.Validate(__workflow_threshold, nameof(threshold), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/count_trigger", ExpressionConverter.ConvertWithUrlEncoding(__workflow_storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["threshold"] = ExpressionConverter.Convert(__workflow_threshold);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Messages
    {
        public MessagesQueueMessagesListType QueueMessagesList { get; set; }
    }

    public class MessagesQueueMessagesListType
    {
        public MessagesQueueMessagesListTypeQueueMessageTypeItem[] QueueMessage { get; set; }
    }

    public class MessagesQueueMessagesListTypeQueueMessageTypeItem
    {
        [JsonProperty("MessageId")]
        public string MessageID { get; set; }
        public string InsertionTime { get; set; }
        public string ExpirationTime { get; set; }
        public string PopReceipt { get; set; }

        [JsonProperty("TimeNextVisible")]
        public string NextVisibleTime { get; set; }
        public string MessageText { get; set; }
    }

    public class Queue
    {
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurequeues;

    public partial class WorkflowManagedActions
    {
        public AzurequeuesActions Azurequeues(string connectionId) => new AzurequeuesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurequeuesTriggers Azurequeues(string connectionId) => new AzurequeuesTriggers(connectionId);
    }
}
