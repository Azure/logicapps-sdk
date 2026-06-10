//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Rabbitmq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RabbitmqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<SendRabbitMQMessageOutput> SendRabbitMQMessage(Expression<Func<string>> queueName, Expression<Func<object>> message, Expression<Func<string>> exchangeName = null, Expression<Func<string>> routingKey = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["message"] = ExpressionConverter.ConvertO(message);
            if (exchangeName != null)
            {
                parameters["exchangeName"] = ExpressionConverter.ConvertO(exchangeName);
            }

            if (routingKey != null)
            {
                parameters["routingKey"] = ExpressionConverter.ConvertO(routingKey);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "sendRabbitMQMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<SendRabbitMQMessageOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<CreateQueueOutput> CreateQueue(Expression<Func<object>> queueName, Expression<Func<bool>> durable, Expression<Func<string>> exchangeName, Expression<Func<CreateQueueExchangeTypeType>> exchangeType, Expression<Func<string>> bindingKey)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["durable"] = ExpressionConverter.ConvertO(durable);
            parameters["exchangeName"] = ExpressionConverter.ConvertO(exchangeName);
            parameters["exchangeType"] = ExpressionConverter.ConvertO(exchangeType);
            parameters["bindingKey"] = ExpressionConverter.ConvertO(bindingKey);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "createQueue", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateQueueOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IOutputWorkflowAction<JToken> CompleteMessage(Expression<Func<int>> deliveryTag, Expression<Func<string>> consumerTag, Expression<Func<CompleteMessageAcknowledgementType>> acknowledgement, Expression<Func<bool>> requeueOnReject = null)
        {
            var parameters = new JObject();
            parameters["deliveryTag"] = ExpressionConverter.ConvertO(deliveryTag);
            parameters["consumerTag"] = ExpressionConverter.ConvertO(consumerTag);
            parameters["acknowledgement"] = ExpressionConverter.ConvertO(acknowledgement);
            if (requeueOnReject != null)
            {
                parameters["requeueOnReject"] = ExpressionConverter.ConvertO(requeueOnReject);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "completeMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }
    }

    public class RabbitmqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveRabbitMQMessagesOutput> ReceiveRabbitMQMessages(Expression<Func<object>> queueName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "receiveRabbitMQMessages", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<ReceiveRabbitMQMessagesOutput>(input, triggerName);
        }

        public IBodyWorkflowTrigger<PeeklockRabbitMQMessagesOutput> PeeklockRabbitMQMessages(Expression<Func<object>> queueName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/rabbitmq", operationId: "peeklockRabbitMQMessages", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<PeeklockRabbitMQMessagesOutput>(input, triggerName);
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

    public enum CreateQueueExchangeTypeType
    {
        Direct,
        Topic
    }

    public enum CompleteMessageAcknowledgementType
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