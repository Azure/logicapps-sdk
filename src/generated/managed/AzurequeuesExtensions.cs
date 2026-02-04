//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurequeues
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Queue[]> ListQueuesV2(Expression<Func<string>> storageAccountName)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/queues/list", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Queue[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Messages> GetMessagesV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> numofmessages = null, Expression<Func<string>> visibilitytimeout = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/queues/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (numofmessages != null)
                callPayload.Queries["numofmessages"] = ExpressionConverter.Convert(numofmessages);
            if (visibilitytimeout != null)
                callPayload.Queries["visibilitytimeout"] = ExpressionConverter.Convert(visibilitytimeout);
            return new ApiConnectionAction<Messages>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IWorkflowAction PutMessageV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> message = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/queues/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(message);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IWorkflowAction DeleteMessageV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popreceipt)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/queues/{1}/messages/{2}", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["popreceipt"] = ExpressionConverter.Convert(popreceipt);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> OnMessageThresholdReachedV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<int>> threshold, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/queues/{1}/count_trigger", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["threshold"] = ExpressionConverter.Convert(threshold);
            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Messages> OnMessagesV2(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> visibilitytimeout = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v2/storageAccounts/{0}/queues/{1}/message_trigger", ExpressionConverter.ConvertWithUrlEncoding(storageAccountName, 2), ExpressionConverter.ConvertWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (visibilitytimeout != null)
                callPayload.Queries["visibilitytimeout"] = ExpressionConverter.Convert(visibilitytimeout);
            return new ApiConnectionTrigger<Messages>(callPayload, triggerName, recurrence);
        }
    }

    public class Queue
    {
        public string Name { get; set; }
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