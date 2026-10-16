//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazonsqs
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AmazonsqsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        public IBodyWorkflowAction<QueueMessageMetadata> SendMessageToQueue(Expression<Func<int>> sendMessageOperationInputmessageVisibilityDelayInSeconds = null, Expression<Func<string>> sendMessageOperationInputmessageContent = null)
        {
            var __workflow_sendMessageOperationInputmessageVisibilityDelayInSeconds = WorkflowExpression.Compile(sendMessageOperationInputmessageVisibilityDelayInSeconds, nameof(sendMessageOperationInputmessageVisibilityDelayInSeconds), required: false);
            var __workflow_sendMessageOperationInputmessageContent = WorkflowExpression.Compile(sendMessageOperationInputmessageContent, nameof(sendMessageOperationInputmessageContent), required: false);
            return new DeferredBodyAction<QueueMessageMetadata>(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageOperationInput = new JObject();
                var sendMessageOperationInputpropCount = 0;
                if (__workflow_sendMessageOperationInputmessageVisibilityDelayInSeconds != null)
                {
                    sendMessageOperationInput["messageVisibilityDelaySeconds"] = ExpressionConverter.ConvertO(__workflow_sendMessageOperationInputmessageVisibilityDelayInSeconds);
                    sendMessageOperationInputpropCount++;
                }

                if (__workflow_sendMessageOperationInputmessageContent != null)
                {
                    sendMessageOperationInput["messageContent"] = ExpressionConverter.ConvertO(__workflow_sendMessageOperationInputmessageContent);
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
        public IWorkflowAction DeleteMessageFromQueue(Expression<Func<string>> messageReceiptHandle)
        {
            var __workflow_messageReceiptHandle = WorkflowExpression.Compile(messageReceiptHandle, nameof(messageReceiptHandle), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageReceiptHandle"] = ExpressionConverter.Convert(__workflow_messageReceiptHandle);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AmazonsqsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<QueueMessage> GetMessageFromQueue(Expression<Func<int>> messageVisibilityTimeoutSeconds = null, Expression<Func<int>> requestWaitTimeoutSeconds = null, Expression<Func<string>> messageAttributeNames = null, FlowRecurrence recurrence = null)
        {
            var __workflow_messageVisibilityTimeoutSeconds = WorkflowExpression.Compile(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            var __workflow_requestWaitTimeoutSeconds = WorkflowExpression.Compile(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            var __workflow_messageAttributeNames = WorkflowExpression.Compile(messageAttributeNames, nameof(messageAttributeNames), required: false);
            return new DeferredBodyTrigger<QueueMessage>(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_messageVisibilityTimeoutSeconds != null)
                    callPayload.Queries["messageVisibilityTimeoutSeconds"] = ExpressionConverter.Convert(__workflow_messageVisibilityTimeoutSeconds);
                callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
                if (__workflow_requestWaitTimeoutSeconds != null)
                    callPayload.Queries["requestWaitTimeoutSeconds"] = ExpressionConverter.Convert(__workflow_requestWaitTimeoutSeconds);
                if (__workflow_messageAttributeNames != null)
                    callPayload.Queries["messageAttributeNames"] = ExpressionConverter.Convert(__workflow_messageAttributeNames);
                return new ApiConnectionTrigger<QueueMessage>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<QueueMessage[]> GetMessagesFromQueue(Expression<Func<int>> maximumNumberOfMessages = null, Expression<Func<int>> messageVisibilityTimeoutSeconds = null, Expression<Func<int>> requestWaitTimeoutSeconds = null, Expression<Func<string>> messageAttributeNames = null, FlowRecurrence recurrence = null)
        {
            var __workflow_maximumNumberOfMessages = WorkflowExpression.Compile(maximumNumberOfMessages, nameof(maximumNumberOfMessages), required: false);
            var __workflow_messageVisibilityTimeoutSeconds = WorkflowExpression.Compile(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            var __workflow_requestWaitTimeoutSeconds = WorkflowExpression.Compile(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            var __workflow_messageAttributeNames = WorkflowExpression.Compile(messageAttributeNames, nameof(messageAttributeNames), required: false);
            return new DeferredBodyTrigger<QueueMessage[]>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maximumNumberOfMessages"] = Convert.ToString(10);
                if (__workflow_maximumNumberOfMessages != null)
                    callPayload.Queries["maximumNumberOfMessages"] = ExpressionConverter.Convert(__workflow_maximumNumberOfMessages);
                if (__workflow_messageVisibilityTimeoutSeconds != null)
                    callPayload.Queries["messageVisibilityTimeoutSeconds"] = ExpressionConverter.Convert(__workflow_messageVisibilityTimeoutSeconds);
                callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
                if (__workflow_requestWaitTimeoutSeconds != null)
                    callPayload.Queries["requestWaitTimeoutSeconds"] = ExpressionConverter.Convert(__workflow_requestWaitTimeoutSeconds);
                if (__workflow_messageAttributeNames != null)
                    callPayload.Queries["messageAttributeNames"] = ExpressionConverter.Convert(__workflow_messageAttributeNames);
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
