//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazonsqs
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmazonsqsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        public IBodyWorkflowAction<QueueMessageMetadata, ApiConnectionActionConfiguration> SendMessageToQueue(Expression<Func<SendMessageToQueueInput>> sendMessageOperationInput)
        {
            var __workflow_sendMessageOperationInput = WorkflowExpression.Compile(sendMessageOperationInput, nameof(sendMessageOperationInput), required: true);
            return new DeferredBodyAction<QueueMessageMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendMessageOperationInput);
                return new ApiConnectionAction<QueueMessageMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMessageFromQueue(Expression<Func<string>> messageReceiptHandle)
        {
            var __workflow_messageReceiptHandle = WorkflowExpression.Compile(messageReceiptHandle, nameof(messageReceiptHandle), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowTrigger<QueueMessage, ApiConnectionTriggerConfiguration> GetMessageFromQueue(Expression<Func<int>> messageVisibilityTimeoutSeconds = null, Expression<Func<int>> requestWaitTimeoutSeconds = null, Expression<Func<string>> messageAttributeNames = null, FlowRecurrence recurrence = null)
        {
            var __workflow_messageVisibilityTimeoutSeconds = WorkflowExpression.Compile(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            var __workflow_requestWaitTimeoutSeconds = WorkflowExpression.Compile(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            var __workflow_messageAttributeNames = WorkflowExpression.Compile(messageAttributeNames, nameof(messageAttributeNames), required: false);
            return new DeferredBodyTrigger<QueueMessage, ApiConnectionTriggerConfiguration>(() =>
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

        public IBodyWorkflowTrigger<QueueMessage[], ApiConnectionTriggerConfiguration> GetMessagesFromQueue(Expression<Func<int>> maximumNumberOfMessages = null, Expression<Func<int>> messageVisibilityTimeoutSeconds = null, Expression<Func<int>> requestWaitTimeoutSeconds = null, Expression<Func<string>> messageAttributeNames = null, FlowRecurrence recurrence = null)
        {
            var __workflow_maximumNumberOfMessages = WorkflowExpression.Compile(maximumNumberOfMessages, nameof(maximumNumberOfMessages), required: false);
            var __workflow_messageVisibilityTimeoutSeconds = WorkflowExpression.Compile(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            var __workflow_requestWaitTimeoutSeconds = WorkflowExpression.Compile(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            var __workflow_messageAttributeNames = WorkflowExpression.Compile(messageAttributeNames, nameof(messageAttributeNames), required: false);
            return new DeferredBodyTrigger<QueueMessage[], ApiConnectionTriggerConfiguration>(() =>
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

    public class SendMessageToQueueInput
    {
        [JsonProperty("messageVisibilityDelaySeconds")]
        public int? MessageVisibilityDelayInSeconds { get; set; }

        [JsonProperty("messageContent")]
        public string MessageContent { get; set; }
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