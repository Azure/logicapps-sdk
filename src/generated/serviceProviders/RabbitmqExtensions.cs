//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Rabbitmq
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class RabbitmqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<SendRabbitMQMessageOutput, SendRabbitMQMessageActionConfiguration> SendRabbitMQMessage(Expression<Func<string>> queueName, Expression<Func<object>> message, Expression<Func<string>> exchangeName = null, Expression<Func<string>> routingKey = null)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            var __workflow_exchangeName = WorkflowExpression.Compile(exchangeName, nameof(exchangeName), required: false);
            var __workflow_routingKey = WorkflowExpression.Compile(routingKey, nameof(routingKey), required: false);
            return new DeferredBodyAction<SendRabbitMQMessageOutput, SendRabbitMQMessageActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["message"] = ExpressionConverter.ConvertO(__workflow_message);
                if (__workflow_exchangeName != null)
                {
                    serviceProviderParameters["exchangeName"] = ExpressionConverter.ConvertO(__workflow_exchangeName);
                }

                if (__workflow_routingKey != null)
                {
                    serviceProviderParameters["routingKey"] = ExpressionConverter.ConvertO(__workflow_routingKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "sendRabbitMQMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<SendRabbitMQMessageOutput, SendRabbitMQMessageActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<CreateQueueOutput, CreateQueueActionConfiguration> CreateQueue(Expression<Func<object>> queueName, Expression<Func<bool>> durable, Expression<Func<string>> exchangeName, Expression<Func<CreateQueueInputExchangeTypeType>> exchangeType, Expression<Func<string>> bindingKey)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            var __workflow_durable = WorkflowExpression.Compile(durable, nameof(durable), required: true);
            var __workflow_exchangeName = WorkflowExpression.Compile(exchangeName, nameof(exchangeName), required: true);
            var __workflow_exchangeType = WorkflowExpression.Compile(exchangeType, nameof(exchangeType), required: true);
            var __workflow_bindingKey = WorkflowExpression.Compile(bindingKey, nameof(bindingKey), required: true);
            return new DeferredBodyAction<CreateQueueOutput, CreateQueueActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(__workflow_durable);
                serviceProviderParameters["exchangeName"] = ExpressionConverter.ConvertO(__workflow_exchangeName);
                serviceProviderParameters["exchangeType"] = ExpressionConverter.ConvertO(__workflow_exchangeType);
                serviceProviderParameters["bindingKey"] = ExpressionConverter.ConvertO(__workflow_bindingKey);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "createQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<CreateQueueOutput, CreateQueueActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IWorkflowAction<CompleteMessageActionConfiguration> CompleteMessage(Expression<Func<int>> deliveryTag, Expression<Func<string>> consumerTag, Expression<Func<CompleteMessageInputAcknowledgementType>> acknowledgement, Expression<Func<bool>> requeueOnReject = null)
        {
            var __workflow_deliveryTag = WorkflowExpression.Compile(deliveryTag, nameof(deliveryTag), required: true);
            var __workflow_consumerTag = WorkflowExpression.Compile(consumerTag, nameof(consumerTag), required: true);
            var __workflow_acknowledgement = WorkflowExpression.Compile(acknowledgement, nameof(acknowledgement), required: true);
            var __workflow_requeueOnReject = WorkflowExpression.Compile(requeueOnReject, nameof(requeueOnReject), required: false);
            return new DeferredWorkflowAction<CompleteMessageActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deliveryTag"] = ExpressionConverter.ConvertO(__workflow_deliveryTag);
                serviceProviderParameters["consumerTag"] = ExpressionConverter.ConvertO(__workflow_consumerTag);
                serviceProviderParameters["acknowledgement"] = ExpressionConverter.ConvertO(__workflow_acknowledgement);
                if (__workflow_requeueOnReject != null)
                {
                    serviceProviderParameters["requeueOnReject"] = ExpressionConverter.ConvertO(__workflow_requeueOnReject);
                }
                else
                {
                    serviceProviderParameters["requeueOnReject"] = false;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "completeMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CompleteMessageActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class SendRabbitMQMessageActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CreateQueueActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CompleteMessageActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class RabbitmqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveRabbitMQMessagesOutput, ReceiveRabbitMQMessagesTriggerConfiguration> ReceiveRabbitMQMessages(Expression<Func<object>> queueName)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<ReceiveRabbitMQMessagesOutput, ReceiveRabbitMQMessagesTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "receiveRabbitMQMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<ReceiveRabbitMQMessagesOutput, ReceiveRabbitMQMessagesTriggerConfiguration>(serviceProviderInput);
            });
        }

        public IBodyWorkflowTrigger<PeeklockRabbitMQMessagesOutput, PeeklockRabbitMQMessagesTriggerConfiguration> PeeklockRabbitMQMessages(Expression<Func<object>> queueName)
        {
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<PeeklockRabbitMQMessagesOutput, PeeklockRabbitMQMessagesTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "peeklockRabbitMQMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyTrigger<PeeklockRabbitMQMessagesOutput, PeeklockRabbitMQMessagesTriggerConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class ReceiveRabbitMQMessagesTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class PeeklockRabbitMQMessagesTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class ReceiveRabbitMQMessagesOutput
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("basicProperties")]
        public JToken BasicProperties { get; set; }

        [JsonProperty("deliveryTag")]
        public int DeliveryTag { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("consumerTag")]
        public string ConsumerTag { get; set; }
    }

    public class PeeklockRabbitMQMessagesOutput
    {
        [JsonProperty("contentData")]
        public JToken ContentData { get; set; }

        [JsonProperty("basicProperties")]
        public JToken BasicProperties { get; set; }

        [JsonProperty("deliveryTag")]
        public int DeliveryTag { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("consumerTag")]
        public string ConsumerTag { get; set; }
    }

    public class SendRabbitMQMessageOutput
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }
    }

    public class CreateQueueOutput
    {
        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("messageCount")]
        public int MessageCount { get; set; }

        [JsonProperty("consumerCount")]
        public int ConsumerCount { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateQueueInputExchangeTypeType
    {
        Direct,
        Topic
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompleteMessageInputAcknowledgementType
    {
        Complete,
        Reject
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Rabbitmq;

    public partial class WorkflowServiceProviderActions
    {
        public RabbitmqActions Rabbitmq(string connectionId) => new RabbitmqActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public RabbitmqTriggers Rabbitmq(string connectionId) => new RabbitmqTriggers(connectionId);
    }
}