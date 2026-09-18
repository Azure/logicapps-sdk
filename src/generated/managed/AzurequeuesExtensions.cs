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
        public IWorkflowAction DeleteMessage([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> popreceipt)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(popreceipt, nameof(popreceipt), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["popreceipt"] = SourceExpressionConverter.ConvertO(popreceipt);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Messages> GetMessages([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> numofmessages = null, [WorkflowExpression] Func<string> visibilitytimeout = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(numofmessages, nameof(numofmessages), required: false);
            SourceExpression.Validate(visibilitytimeout, nameof(visibilitytimeout), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (numofmessages != null)
                    callPayload.Queries["numofmessages"] = SourceExpressionConverter.ConvertO(numofmessages);
                if (visibilitytimeout != null)
                    callPayload.Queries["visibilitytimeout"] = SourceExpressionConverter.ConvertO(visibilitytimeout);
                return callPayload;
            }

            return new ApiConnectionAction<Messages>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<Queue[]> ListQueues([WorkflowExpression] Func<string> storageAccountName)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Queue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurequeues")]
        public IWorkflowAction PutMessage([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> message = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(message, nameof(message), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(message);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Messages> OnMessages([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> visibilitytimeout = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(visibilitytimeout, nameof(visibilitytimeout), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/message_trigger", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (visibilitytimeout != null)
                    callPayload.Queries["visibilitytimeout"] = SourceExpressionConverter.ConvertO(visibilitytimeout);
                return callPayload;
            }

            return new ApiConnectionTrigger<Messages>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnMessageThresholdReached([WorkflowExpression] Func<string> storageAccountName, [WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> threshold, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(storageAccountName, nameof(storageAccountName), required: true);
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(threshold, nameof(threshold), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/storageAccounts/{0}/queues/{1}/count_trigger", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageAccountName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queueName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["threshold"] = SourceExpressionConverter.ConvertO(threshold);
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
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