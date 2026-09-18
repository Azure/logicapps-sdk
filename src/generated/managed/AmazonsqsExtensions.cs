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
        public IBodyWorkflowAction<QueueMessageMetadata> SendMessageToQueue([WorkflowExpression] Func<int> sendMessageOperationInputmessageVisibilityDelayInSeconds = null, [WorkflowExpression] Func<string> sendMessageOperationInputmessageContent = null)
        {
            SourceExpression.Validate(sendMessageOperationInputmessageVisibilityDelayInSeconds, nameof(sendMessageOperationInputmessageVisibilityDelayInSeconds), required: false);
            SourceExpression.Validate(sendMessageOperationInputmessageContent, nameof(sendMessageOperationInputmessageContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sendMessageOperationInput = new JObject();
                var sendMessageOperationInputpropCount = 0;
                if (sendMessageOperationInputmessageVisibilityDelayInSeconds != null)
                {
                    sendMessageOperationInput["messageVisibilityDelaySeconds"] = SourceExpressionConverter.ConvertToken(sendMessageOperationInputmessageVisibilityDelayInSeconds);
                    sendMessageOperationInputpropCount++;
                }

                if (sendMessageOperationInputmessageContent != null)
                {
                    sendMessageOperationInput["messageContent"] = SourceExpressionConverter.ConvertToken(sendMessageOperationInputmessageContent);
                    sendMessageOperationInputpropCount++;
                }

                if (sendMessageOperationInputpropCount > 0)
                {
                    callPayload.Body = sendMessageOperationInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueueMessageMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazonsqs")]
        public IWorkflowAction DeleteMessageFromQueue([WorkflowExpression] Func<string> messageReceiptHandle)
        {
            SourceExpression.Validate(messageReceiptHandle, nameof(messageReceiptHandle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageReceiptHandle"] = SourceExpressionConverter.ConvertO(messageReceiptHandle);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class AmazonsqsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<QueueMessage> GetMessageFromQueue([WorkflowExpression] Func<int> messageVisibilityTimeoutSeconds = null, [WorkflowExpression] Func<int> requestWaitTimeoutSeconds = null, [WorkflowExpression] Func<string> messageAttributeNames = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            SourceExpression.Validate(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            SourceExpression.Validate(messageAttributeNames, nameof(messageAttributeNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (messageVisibilityTimeoutSeconds != null)
                    callPayload.Queries["messageVisibilityTimeoutSeconds"] = SourceExpressionConverter.ConvertO(messageVisibilityTimeoutSeconds);
                callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
                if (requestWaitTimeoutSeconds != null)
                    callPayload.Queries["requestWaitTimeoutSeconds"] = SourceExpressionConverter.ConvertO(requestWaitTimeoutSeconds);
                if (messageAttributeNames != null)
                    callPayload.Queries["messageAttributeNames"] = SourceExpressionConverter.ConvertO(messageAttributeNames);
                return callPayload;
            }

            return new ApiConnectionTrigger<QueueMessage>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<QueueMessage[]> GetMessagesFromQueue([WorkflowExpression] Func<int> maximumNumberOfMessages = null, [WorkflowExpression] Func<int> messageVisibilityTimeoutSeconds = null, [WorkflowExpression] Func<int> requestWaitTimeoutSeconds = null, [WorkflowExpression] Func<string> messageAttributeNames = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(maximumNumberOfMessages, nameof(maximumNumberOfMessages), required: false);
            SourceExpression.Validate(messageVisibilityTimeoutSeconds, nameof(messageVisibilityTimeoutSeconds), required: false);
            SourceExpression.Validate(requestWaitTimeoutSeconds, nameof(requestWaitTimeoutSeconds), required: false);
            SourceExpression.Validate(messageAttributeNames, nameof(messageAttributeNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["maximumNumberOfMessages"] = Convert.ToString(10);
                if (maximumNumberOfMessages != null)
                    callPayload.Queries["maximumNumberOfMessages"] = SourceExpressionConverter.ConvertO(maximumNumberOfMessages);
                if (messageVisibilityTimeoutSeconds != null)
                    callPayload.Queries["messageVisibilityTimeoutSeconds"] = SourceExpressionConverter.ConvertO(messageVisibilityTimeoutSeconds);
                callPayload.Queries["requestWaitTimeoutSeconds"] = Convert.ToString(0);
                if (requestWaitTimeoutSeconds != null)
                    callPayload.Queries["requestWaitTimeoutSeconds"] = SourceExpressionConverter.ConvertO(requestWaitTimeoutSeconds);
                if (messageAttributeNames != null)
                    callPayload.Queries["messageAttributeNames"] = SourceExpressionConverter.ConvertO(messageAttributeNames);
                return callPayload;
            }

            return new ApiConnectionTrigger<QueueMessage[]>(BuildSourceInput, triggerName, recurrence);
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