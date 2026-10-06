//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurequeues
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteMessage))]
        public IWorkflowAction DeleteMessage([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> popreceipt)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteMessage(WorkflowExpression<string> storageAccountName, WorkflowExpression<string> queueName, WorkflowExpression<string> messageId, WorkflowExpression<string> popreceipt)
        {
            WorkflowExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(popreceipt, nameof(popreceipt), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["popreceipt"] = ExpressionConverter.Convert(popreceipt);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessages))]
        public IBodyWorkflowAction<Messages> GetMessages([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> numofmessages = null, [WorkflowExpression] Func<string> visibilitytimeout = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Messages> __BuildGetMessages(WorkflowExpression<string> storageAccountName, WorkflowExpression<string> queueName, WorkflowExpression<string> numofmessages = null, WorkflowExpression<string> visibilitytimeout = null)
        {
            WorkflowExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(numofmessages, nameof(numofmessages), required: false);
            WorkflowExpression.Validate(visibilitytimeout, nameof(visibilitytimeout), required: false);
            return new DeferredBodyAction<Messages>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (numofmessages != null)
                    callPayload.Queries["numofmessages"] = ExpressionConverter.Convert(numofmessages);
                if (visibilitytimeout != null)
                    callPayload.Queries["visibilitytimeout"] = ExpressionConverter.Convert(visibilitytimeout);
                return new ApiConnectionAction<Messages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildListQueues))]
        public IBodyWorkflowAction<Queue[]> ListQueues([WorkflowExpression] Func<string> storageAccountName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Queue[]> __BuildListQueues(WorkflowExpression<string> storageAccountName)
        {
            WorkflowExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            return new DeferredBodyAction<Queue[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/list", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Queue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildPutMessage))]
        public IWorkflowAction PutMessage([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> message = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutMessage(WorkflowExpression<string> storageAccountName, WorkflowExpression<string> queueName, WorkflowExpression<string> message = null)
        {
            WorkflowExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(message);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnMessages))]
        public IBodyWorkflowTrigger<Messages> OnMessages([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> visibilitytimeout = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<Messages> __BuildOnMessages(WorkflowExpression<string> storageAccountName, WorkflowExpression<string> queueName, WorkflowExpression<string> visibilitytimeout = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(visibilitytimeout, nameof(visibilitytimeout), required: false);
            return new DeferredBodyTrigger<Messages>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/message_trigger", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (visibilitytimeout != null)
                    callPayload.Queries["visibilitytimeout"] = ExpressionConverter.Convert(visibilitytimeout);
                return new ApiConnectionTrigger<Messages>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnMessageThresholdReached))]
        public IBodyWorkflowTrigger<string> OnMessageThresholdReached([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> threshold, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildOnMessageThresholdReached(WorkflowExpression<string> storageAccountName, WorkflowExpression<string> queueName, WorkflowExpression<int> threshold, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: true);
            WorkflowExpression.Validate(threshold, nameof(threshold), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/count_trigger", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["threshold"] = ExpressionConverter.Convert(threshold);
                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
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