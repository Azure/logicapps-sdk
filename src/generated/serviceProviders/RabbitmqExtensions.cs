//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Rabbitmq
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class RabbitmqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<SendRabbitMQMessageOutput> SendRabbitMQMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<object> message, [WorkflowExpression] Func<string> exchangeName = null, [WorkflowExpression] Func<string> routingKey = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["message"] = SourceExpressionConverter.ConvertToken(message);
                if (exchangeName != null)
                {
                    serviceProviderParameters["exchangeName"] = SourceExpressionConverter.ConvertToken(exchangeName);
                }

                if (routingKey != null)
                {
                    serviceProviderParameters["routingKey"] = SourceExpressionConverter.ConvertToken(routingKey);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "sendRabbitMQMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<SendRabbitMQMessageOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<CreateQueueOutput> CreateQueue([WorkflowExpression] Func<object> queueName, [WorkflowExpression] Func<bool> durable, [WorkflowExpression] Func<string> exchangeName, [WorkflowExpression] Func<CreateQueueInputExchangeTypeType> exchangeType, [WorkflowExpression] Func<string> bindingKey)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["durable"] = SourceExpressionConverter.ConvertToken(durable);
                serviceProviderParameters["exchangeName"] = SourceExpressionConverter.ConvertToken(exchangeName);
                serviceProviderParameters["exchangeType"] = SourceExpressionConverter.ConvertToken(exchangeType);
                serviceProviderParameters["bindingKey"] = SourceExpressionConverter.ConvertToken(bindingKey);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "createQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateQueueOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IOutputWorkflowAction<JToken> CompleteMessage([WorkflowExpression] Func<int> deliveryTag, [WorkflowExpression] Func<string> consumerTag, [WorkflowExpression] Func<CompleteMessageInputAcknowledgementType> acknowledgement, [WorkflowExpression] Func<bool> requeueOnReject = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deliveryTag"] = SourceExpressionConverter.ConvertToken(deliveryTag);
                serviceProviderParameters["consumerTag"] = SourceExpressionConverter.ConvertToken(consumerTag);
                serviceProviderParameters["acknowledgement"] = SourceExpressionConverter.ConvertToken(acknowledgement);
                if (requeueOnReject != null)
                {
                    serviceProviderParameters["requeueOnReject"] = SourceExpressionConverter.ConvertToken(requeueOnReject);
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
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }
    }

    public class RabbitmqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveRabbitMQMessagesOutput> ReceiveRabbitMQMessages([WorkflowExpression] Func<object> queueName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "receiveRabbitMQMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveRabbitMQMessagesOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<PeeklockRabbitMQMessagesOutput> PeeklockRabbitMQMessages([WorkflowExpression] Func<object> queueName)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "peeklockRabbitMQMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<PeeklockRabbitMQMessagesOutput>(BuildSourceInput);
        }
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