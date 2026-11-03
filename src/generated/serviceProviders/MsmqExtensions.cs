//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Msmq
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class MsmqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "msmq")]
        public IBodyWorkflowAction<SendMsmqMessageOutput, SendMsmqMessageActionConfiguration> SendMsmqMessage(Expression<Func<string>> queueName, Expression<Func<string>> messageBody, Expression<Func<string>> messageLabel = null, Expression<Func<bool>> isTransactional = null, Expression<Func<bool>> useDeadLetterQueue = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_messageBody = WorkflowExpression.Compile(messageBody, nameof(messageBody), required: true);
            var __workflow_messageLabel = WorkflowExpression.Compile(messageLabel, nameof(messageLabel), required: false);
            var __workflow_isTransactional = WorkflowExpression.Compile(isTransactional, nameof(isTransactional), required: false);
            var __workflow_useDeadLetterQueue = WorkflowExpression.Compile(useDeadLetterQueue, nameof(useDeadLetterQueue), required: false);
            return new DeferredBodyAction<SendMsmqMessageOutput, SendMsmqMessageActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                if (__workflow_messageLabel != null)
                {
                    serviceProviderParameters["messageLabel"] = ExpressionConverter.ConvertO(__workflow_messageLabel);
                }

                serviceProviderParameters["messageBody"] = ExpressionConverter.ConvertO(__workflow_messageBody);
                if (__workflow_isTransactional != null)
                {
                    serviceProviderParameters["isTransactional"] = ExpressionConverter.ConvertO(__workflow_isTransactional);
                }
                else
                {
                    serviceProviderParameters["isTransactional"] = false;
                }

                if (__workflow_useDeadLetterQueue != null)
                {
                    serviceProviderParameters["useDeadLetterQueue"] = ExpressionConverter.ConvertO(__workflow_useDeadLetterQueue);
                }
                else
                {
                    serviceProviderParameters["useDeadLetterQueue"] = true;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/msmq", operationId: "sendMsmqMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<SendMsmqMessageOutput, SendMsmqMessageActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class SendMsmqMessageActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public class MsmqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenMessageIsAvailableInMsmqQueueOutput, WhenMessageIsAvailableInMsmqQueueTriggerConfiguration> WhenMessageIsAvailableInMsmqQueue(Expression<Func<string>> queueName)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<WhenMessageIsAvailableInMsmqQueueOutput, WhenMessageIsAvailableInMsmqQueueTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/msmq", operationId: "whenMessageIsAvailableInMsmqQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<WhenMessageIsAvailableInMsmqQueueOutput, WhenMessageIsAvailableInMsmqQueueTriggerConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class WhenMessageIsAvailableInMsmqQueueTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public class WhenMessageIsAvailableInMsmqQueueOutput
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("queuePath")]
        public string QueuePath { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendMsmqMessageOutput
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("queuePath")]
        public string QueuePath { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Msmq;

    public partial class WorkflowServiceProviderActions
    {
        public MsmqActions Msmq(string connectionId) => new MsmqActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public MsmqTriggers Msmq(string connectionId) => new MsmqTriggers(connectionId);
    }
}