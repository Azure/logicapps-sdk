//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazonsqs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmazonsqsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        public IBodyWorkflowAction<QueueMessageMetadata> SendMessageToQueue(Expression<Func<int>> sendMessageOperationInputmessageVisibilityDelayInSeconds = null, Expression<Func<string>> sendMessageOperationInputmessageContent = null)
        {
            var apiCallPath = "/message";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendMessageOperationInput = new JObject();
            var sendMessageOperationInputpropCount = 0;
            if (sendMessageOperationInputmessageVisibilityDelayInSeconds != null)
            {
                sendMessageOperationInput["messageVisibilityDelaySeconds"] = CSharpExpressionConverter.ConvertToken(sendMessageOperationInputmessageVisibilityDelayInSeconds);
                sendMessageOperationInputpropCount++;
            }

            if (sendMessageOperationInputmessageContent != null)
            {
                sendMessageOperationInput["messageContent"] = CSharpExpressionConverter.ConvertToken(sendMessageOperationInputmessageContent);
                sendMessageOperationInputpropCount++;
            }

            if (sendMessageOperationInputpropCount > 0)
            {
                callPayload.Body = sendMessageOperationInput;
            }

            return new ApiConnectionAction<QueueMessageMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        public IWorkflowAction DeleteMessageFromQueue(Expression<Func<string>> messageReceiptHandle)
        {
            var apiCallPath = "/message";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["messageReceiptHandle"] = CSharpExpressionConverter.ConvertO(messageReceiptHandle);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class AmazonsqsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<QueueMessage> GetMessageFromQueue(Expression<Func<int>> messageVisibilityTimeoutSeconds = null, Expression<Func<int>> requestWaitTimeoutSeconds = null, Expression<Func<string>> messageAttributeNames = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/message";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (messageVisibilityTimeoutSeconds != null)
                callPayload.Queries["messageVisibilityTimeoutSeconds"] = CSharpExpressionConverter.ConvertO(messageVisibilityTimeoutSeconds);
            callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
            if (requestWaitTimeoutSeconds != null)
                callPayload.Queries["requestWaitTimeoutSeconds"] = CSharpExpressionConverter.ConvertO(requestWaitTimeoutSeconds);
            if (messageAttributeNames != null)
                callPayload.Queries["messageAttributeNames"] = CSharpExpressionConverter.ConvertO(messageAttributeNames);
            return new ApiConnectionTrigger<QueueMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<QueueMessage[]> GetMessagesFromQueue(Expression<Func<int>> maximumNumberOfMessages = null, Expression<Func<int>> messageVisibilityTimeoutSeconds = null, Expression<Func<int>> requestWaitTimeoutSeconds = null, Expression<Func<string>> messageAttributeNames = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/messages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["maximumNumberOfMessages"] = Convert.ToString(10);
            if (maximumNumberOfMessages != null)
                callPayload.Queries["maximumNumberOfMessages"] = CSharpExpressionConverter.ConvertO(maximumNumberOfMessages);
            if (messageVisibilityTimeoutSeconds != null)
                callPayload.Queries["messageVisibilityTimeoutSeconds"] = CSharpExpressionConverter.ConvertO(messageVisibilityTimeoutSeconds);
            callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
            if (requestWaitTimeoutSeconds != null)
                callPayload.Queries["requestWaitTimeoutSeconds"] = CSharpExpressionConverter.ConvertO(requestWaitTimeoutSeconds);
            if (messageAttributeNames != null)
                callPayload.Queries["messageAttributeNames"] = CSharpExpressionConverter.ConvertO(messageAttributeNames);
            return new ApiConnectionTrigger<QueueMessage[]>(callPayload, triggerName, recurrence);
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