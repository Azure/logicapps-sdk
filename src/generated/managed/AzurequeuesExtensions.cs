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
        public IWorkflowAction DeleteMessage(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popreceipt)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["popreceipt"] = CSharpExpressionConverter.ConvertO(popreceipt);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Messages> GetMessages(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> numofmessages = null, Expression<Func<string>> visibilitytimeout = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (numofmessages != null)
                callPayload.Queries["numofmessages"] = CSharpExpressionConverter.ConvertO(numofmessages);
            if (visibilitytimeout != null)
                callPayload.Queries["visibilitytimeout"] = CSharpExpressionConverter.ConvertO(visibilitytimeout);
            return new ApiConnectionAction<Messages>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Queue[]> ListQueues(Expression<Func<string>> storageAccountName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/list", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Queue[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IWorkflowAction PutMessage(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> message = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(message);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Messages> OnMessages(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<string>> visibilitytimeout = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/message_trigger", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (visibilitytimeout != null)
                callPayload.Queries["visibilitytimeout"] = CSharpExpressionConverter.ConvertO(visibilitytimeout);
            return new ApiConnectionTrigger<Messages>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnMessageThresholdReached(Expression<Func<string>> storageAccountName, Expression<Func<string>> queueName, Expression<Func<int>> threshold, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/count_trigger", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["threshold"] = CSharpExpressionConverter.ConvertO(threshold);
            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
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