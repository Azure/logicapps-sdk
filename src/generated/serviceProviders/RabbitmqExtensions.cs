//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Rabbitmq
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class RabbitmqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        [WorkflowExpressionFactory(nameof(__BuildSendRabbitMQMessage))]
        public IBodyWorkflowAction<SendRabbitMQMessageOutput> SendRabbitMQMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<object> message, [WorkflowExpression] Func<string> exchangeName = null, [WorkflowExpression] Func<string> routingKey = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendRabbitMQMessageOutput> __BuildSendRabbitMQMessage(WorkflowValue<string> queueName, WorkflowValue<object> message, WorkflowValue<string> exchangeName = null, WorkflowValue<string> routingKey = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(message, nameof(message), required: true);
            WorkflowValue.Validate(exchangeName, nameof(exchangeName), required: false);
            WorkflowValue.Validate(routingKey, nameof(routingKey), required: false);
            return new DeferredBodyAction<SendRabbitMQMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["message"] = ExpressionConverter.ConvertO(message);
                if (exchangeName != null)
                {
                    serviceProviderParameters["exchangeName"] = ExpressionConverter.ConvertO(exchangeName);
                }

                if (routingKey != null)
                {
                    serviceProviderParameters["routingKey"] = ExpressionConverter.ConvertO(routingKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "sendRabbitMQMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendRabbitMQMessageOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        [WorkflowExpressionFactory(nameof(__BuildCreateQueue))]
        public IBodyWorkflowAction<CreateQueueOutput> CreateQueue([WorkflowExpression] Func<object> queueName, [WorkflowExpression] Func<bool> durable, [WorkflowExpression] Func<string> exchangeName, [WorkflowExpression] Func<CreateQueueInputExchangeTypeType> exchangeType, [WorkflowExpression] Func<string> bindingKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateQueueOutput> __BuildCreateQueue(WorkflowValue<object> queueName, WorkflowValue<bool> durable, WorkflowValue<string> exchangeName, WorkflowValue<CreateQueueInputExchangeTypeType> exchangeType, WorkflowValue<string> bindingKey)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(durable, nameof(durable), required: true);
            WorkflowValue.Validate(exchangeName, nameof(exchangeName), required: true);
            WorkflowValue.Validate(exchangeType, nameof(exchangeType), required: true);
            WorkflowValue.Validate(bindingKey, nameof(bindingKey), required: true);
            return new DeferredBodyAction<CreateQueueOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(durable);
                serviceProviderParameters["exchangeName"] = ExpressionConverter.ConvertO(exchangeName);
                serviceProviderParameters["exchangeType"] = ExpressionConverter.ConvertO(exchangeType);
                serviceProviderParameters["bindingKey"] = ExpressionConverter.ConvertO(bindingKey);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "createQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateQueueOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteMessage))]
        public IOutputWorkflowAction<JToken> CompleteMessage([WorkflowExpression] Func<int> deliveryTag, [WorkflowExpression] Func<string> consumerTag, [WorkflowExpression] Func<CompleteMessageInputAcknowledgementType> acknowledgement, [WorkflowExpression] Func<bool> requeueOnReject = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCompleteMessage(WorkflowValue<int> deliveryTag, WorkflowValue<string> consumerTag, WorkflowValue<CompleteMessageInputAcknowledgementType> acknowledgement, WorkflowValue<bool> requeueOnReject = null)
        {
            WorkflowValue.Validate(deliveryTag, nameof(deliveryTag), required: true);
            WorkflowValue.Validate(consumerTag, nameof(consumerTag), required: true);
            WorkflowValue.Validate(acknowledgement, nameof(acknowledgement), required: true);
            WorkflowValue.Validate(requeueOnReject, nameof(requeueOnReject), required: false);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deliveryTag"] = ExpressionConverter.ConvertO(deliveryTag);
                serviceProviderParameters["consumerTag"] = ExpressionConverter.ConvertO(consumerTag);
                serviceProviderParameters["acknowledgement"] = ExpressionConverter.ConvertO(acknowledgement);
                if (requeueOnReject != null)
                {
                    serviceProviderParameters["requeueOnReject"] = ExpressionConverter.ConvertO(requeueOnReject);
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
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }
    }

    public class RabbitmqTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildReceiveRabbitMQMessages))]
        public IBodyWorkflowTrigger<ReceiveRabbitMQMessagesOutput> ReceiveRabbitMQMessages([WorkflowExpression] Func<object> queueName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveRabbitMQMessagesOutput> __BuildReceiveRabbitMQMessages(WorkflowValue<object> queueName)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<ReceiveRabbitMQMessagesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "receiveRabbitMQMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveRabbitMQMessagesOutput>(serviceProviderInput);
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildPeeklockRabbitMQMessages))]
        public IBodyWorkflowTrigger<PeeklockRabbitMQMessagesOutput> PeeklockRabbitMQMessages([WorkflowExpression] Func<object> queueName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PeeklockRabbitMQMessagesOutput> __BuildPeeklockRabbitMQMessages(WorkflowValue<object> queueName)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<PeeklockRabbitMQMessagesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "peeklockRabbitMQMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<PeeklockRabbitMQMessagesOutput>(serviceProviderInput);
            }, "ServiceProviderTrigger");
        }
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
