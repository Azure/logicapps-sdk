//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<PutMessageOutput, PutMessageActionConfiguration> PutMessage(Expression<Func<string>> queueName, Expression<Func<string>> message, Expression<Func<string>> timeToLive = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            var __workflow_timeToLive = WorkflowExpression.Compile(timeToLive, nameof(timeToLive), required: false);
            var __workflow_visibilityTimeout = WorkflowExpression.Compile(visibilityTimeout, nameof(visibilityTimeout), required: false);
            return new DeferredOutputAction<PutMessageOutput, PutMessageActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["message"] = ExpressionConverter.ConvertO(__workflow_message);
                if (__workflow_timeToLive != null)
                {
                    serviceProviderParameters["timeToLive"] = ExpressionConverter.ConvertO(__workflow_timeToLive);
                }

                if (__workflow_visibilityTimeout != null)
                {
                    serviceProviderParameters["visibilityTimeout"] = ExpressionConverter.ConvertO(__workflow_visibilityTimeout);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<PutMessageOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<GetMessagesOutputItem[], GetMessagesActionConfiguration> GetMessages(Expression<Func<string>> queueName, Expression<Func<int>> messageCount = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_messageCount = WorkflowExpression.Compile(messageCount, nameof(messageCount), required: false);
            var __workflow_visibilityTimeout = WorkflowExpression.Compile(visibilityTimeout, nameof(visibilityTimeout), required: false);
            return new DeferredBodyAction<GetMessagesOutputItem[], GetMessagesActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_messageCount != null)
                {
                    serviceProviderParameters["messageCount"] = ExpressionConverter.ConvertO(__workflow_messageCount);
                }
                else
                {
                    serviceProviderParameters["messageCount"] = 1;
                }

                if (__workflow_visibilityTimeout != null)
                {
                    serviceProviderParameters["visibilityTimeout"] = ExpressionConverter.ConvertO(__workflow_visibilityTimeout);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "getMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetMessagesOutputItem[]>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IWorkflowAction<DeleteMessageActionConfiguration> DeleteMessage(Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popReceipt)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_popReceipt = WorkflowExpression.Compile(popReceipt, nameof(popReceipt), required: true);
            return new DeferredWorkflowAction<DeleteMessageActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(__workflow_messageId);
                serviceProviderParameters["popReceipt"] = ExpressionConverter.ConvertO(__workflow_popReceipt);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "deleteMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IWorkflowAction<PutQueueActionConfiguration> PutQueue(Expression<Func<string>> queueName)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            return new DeferredWorkflowAction<PutQueueActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<ListQueuesOutput, ListQueuesActionConfiguration> ListQueues(Expression<Func<string>> prefix = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_prefix = WorkflowExpression.Compile(prefix, nameof(prefix), required: false);
            var __workflow_maxCount = WorkflowExpression.Compile(maxCount, nameof(maxCount), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<ListQueuesOutput, ListQueuesActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_prefix != null)
                {
                    serviceProviderParameters["prefix"] = ExpressionConverter.ConvertO(__workflow_prefix);
                }

                if (__workflow_maxCount != null)
                {
                    serviceProviderParameters["maxCount"] = ExpressionConverter.ConvertO(__workflow_maxCount);
                }

                if (__workflow_continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(__workflow_continuationToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "listQueues", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ListQueuesOutput>(serviceProviderInput);
            });
        }
    }

    public sealed class PutMessageActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetMessagesActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class DeleteMessageActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class PutQueueActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ListQueuesActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput, ReceiveQueueMessagesTriggerConfiguration> ReceiveQueueMessages(Expression<Func<object>> queueName)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<ReceiveQueueMessagesOutput, ReceiveQueueMessagesTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "receiveQueueMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<int, SpecifiedNumberOfMessagesAvailableTriggerConfiguration> SpecifiedNumberOfMessagesAvailable(Expression<Func<object>> queueName, Expression<Func<int>> threshold, FlowRecurrence recurrence = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_threshold = WorkflowExpression.Compile(threshold, nameof(threshold), required: true);
            return new DeferredBodyTrigger<int, SpecifiedNumberOfMessagesAvailableTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["threshold"] = ExpressionConverter.ConvertO(__workflow_threshold);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "specifiedNumberOfMessagesAvailable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<int>(serviceProviderInput, isPolling: true, recurrence: recurrence);
            });
        }
    }

    public sealed class ReceiveQueueMessagesTriggerConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class SpecifiedNumberOfMessagesAvailableTriggerConfiguration : IWorkflowOperationConfiguration, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class ReceiveQueueMessagesOutput
    {
        [JsonProperty("messageText")]
        public JToken MessageText { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("insertedOn")]
        public string InsertedOn { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("popReceipt")]
        public string PopReceipt { get; set; }

        [JsonProperty("nextVisibleOn")]
        public string NextVisibleOn { get; set; }
    }

    public class PutMessageOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("insertedOn")]
        public string InsertedOn { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("popReceipt")]
        public string PopReceipt { get; set; }

        [JsonProperty("nextVisibleOn")]
        public string NextVisibleOn { get; set; }
    }

    public class GetMessagesOutputItem
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("insertedOn")]
        public string InsertedOn { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("popReceipt")]
        public string PopReceipt { get; set; }

        [JsonProperty("nextVisibleOn")]
        public string NextVisibleOn { get; set; }
    }

    public class ListQueuesOutput
    {
        [JsonProperty("queueList")]
        public JToken QueueList { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues;

    public partial class WorkflowServiceProviderActions
    {
        public AzurequeuesActions Azurequeues(string connectionId) => new AzurequeuesActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzurequeuesTriggers Azurequeues(string connectionId) => new AzurequeuesTriggers(connectionId);
    }
}