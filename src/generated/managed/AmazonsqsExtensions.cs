//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazonsqs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmazonsqsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageToQueue))]
        public IBodyWorkflowAction<QueueMessageMetadata> SendMessageToQueue([WorkflowExpression] Func<int> sendMessageOperationInputmessageVisibilityDelayInSeconds = null, [WorkflowExpression] Func<string> sendMessageOperationInputmessageContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueueMessageMetadata> __BuildSendMessageToQueue(WorkflowExpression<int> sendMessageOperationInputmessageVisibilityDelayInSeconds = null, WorkflowExpression<string> sendMessageOperationInputmessageContent = null)
        {
            WorkflowExpression.Validate(sendMessageOperationInputmessageVisibilityDelayInSeconds, nameof(sendMessageOperationInputmessageVisibilityDelayInSeconds), required: false);
            WorkflowExpression.Validate(sendMessageOperationInputmessageContent, nameof(sendMessageOperationInputmessageContent), required: false);
            return new DeferredBodyAction<QueueMessageMetadata>(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageOperationInput = new JObject();
                var sendMessageOperationInputpropCount = 0;
                if (sendMessageOperationInputmessageVisibilityDelayInSeconds != null)
                {
                    sendMessageOperationInput["messageVisibilityDelaySeconds"] = ExpressionConverter.ConvertO(sendMessageOperationInputmessageVisibilityDelayInSeconds);
                    sendMessageOperationInputpropCount++;
                }

                if (sendMessageOperationInputmessageContent != null)
                {
                    sendMessageOperationInput["messageContent"] = ExpressionConverter.ConvertO(sendMessageOperationInputmessageContent);
                    sendMessageOperationInputpropCount++;
                }

                if (sendMessageOperationInputpropCount > 0)
                {
                    callPayload.Body = sendMessageOperationInput;
                }

                return new ApiConnectionAction<QueueMessageMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteMessageFromQueue))]
        public IWorkflowAction DeleteMessageFromQueue([WorkflowExpression] Func<string> messageReceiptHandle)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteMessageFromQueue(WorkflowExpression<string> messageReceiptHandle)
        {
            WorkflowExpression.Validate(messageReceiptHandle, nameof(messageReceiptHandle), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageReceiptHandle"] = ExpressionConverter.Convert(messageReceiptHandle);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AmazonsqsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildGetMessageFromQueue))]
        public IBodyWorkflowTrigger<QueueMessage> GetMessageFromQueue([WorkflowExpression] Func<int> messageVisibilityTimeoutSeconds = null,[WorkflowExpression] Func<int> requestWaitTimeoutSeconds = null,[WorkflowExpression] Func<string> messageAttributeNames = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<QueueMessage> __BuildGetMessageFromQueue(WorkflowExpression<int> messageVisibilityTimeoutSeconds = null,WorkflowExpression<int> requestWaitTimeoutSeconds = null,WorkflowExpression<string> messageAttributeNames = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            WorkflowExpression.Validate(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            WorkflowExpression.Validate(messageAttributeNames, nameof(messageAttributeNames), required: false);
            return new DeferredBodyTrigger<QueueMessage>(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (messageVisibilityTimeoutSeconds != null)
                    callPayload.Queries["messageVisibilityTimeoutSeconds"] = ExpressionConverter.Convert(messageVisibilityTimeoutSeconds);
                callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
                if (requestWaitTimeoutSeconds != null)
                    callPayload.Queries["requestWaitTimeoutSeconds"] = ExpressionConverter.Convert(requestWaitTimeoutSeconds);
                if (messageAttributeNames != null)
                    callPayload.Queries["messageAttributeNames"] = ExpressionConverter.Convert(messageAttributeNames);
                return new ApiConnectionTrigger<QueueMessage>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetMessagesFromQueue))]
        public IBodyWorkflowTrigger<QueueMessage[]> GetMessagesFromQueue([WorkflowExpression] Func<int> maximumNumberOfMessages = null,[WorkflowExpression] Func<int> messageVisibilityTimeoutSeconds = null,[WorkflowExpression] Func<int> requestWaitTimeoutSeconds = null,[WorkflowExpression] Func<string> messageAttributeNames = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<QueueMessage[]> __BuildGetMessagesFromQueue(WorkflowExpression<int> maximumNumberOfMessages = null,WorkflowExpression<int> messageVisibilityTimeoutSeconds = null,WorkflowExpression<int> requestWaitTimeoutSeconds = null,WorkflowExpression<string> messageAttributeNames = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(maximumNumberOfMessages, nameof(maximumNumberOfMessages), required: false);
            WorkflowExpression.Validate(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            WorkflowExpression.Validate(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            WorkflowExpression.Validate(messageAttributeNames, nameof(messageAttributeNames), required: false);
            return new DeferredBodyTrigger<QueueMessage[]>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maximumNumberOfMessages"] = Convert.ToString(10);
                if (maximumNumberOfMessages != null)
                    callPayload.Queries["maximumNumberOfMessages"] = ExpressionConverter.Convert(maximumNumberOfMessages);
                if (messageVisibilityTimeoutSeconds != null)
                    callPayload.Queries["messageVisibilityTimeoutSeconds"] = ExpressionConverter.Convert(messageVisibilityTimeoutSeconds);
                callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
                if (requestWaitTimeoutSeconds != null)
                    callPayload.Queries["requestWaitTimeoutSeconds"] = ExpressionConverter.Convert(requestWaitTimeoutSeconds);
                if (messageAttributeNames != null)
                    callPayload.Queries["messageAttributeNames"] = ExpressionConverter.Convert(messageAttributeNames);
                return new ApiConnectionTrigger<QueueMessage[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class QueueMessageMetadata
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }
    }

    public class QueueMessage
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("receiptHandle")]
        public string ReceiptHandle { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentMD5")]
        public string ContentMD5 { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Amazonsqs;

    public partial class WorkflowManagedActions
    {
        public AmazonsqsActions Amazonsqs(string connectionId) => new AmazonsqsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AmazonsqsTriggers Amazonsqs(string connectionId) => new AmazonsqsTriggers(connectionId);
    }
}