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
        public IBodyWorkflowAction<SendRabbitMQMessageOutput> SendRabbitMQMessage(Expression<Func<string>> queueName, Expression<Func<object>> message, Expression<Func<string>> exchangeName = null, Expression<Func<string>> routingKey = null)
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/rabbitmq", "sendRabbitMQMessage", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<SendRabbitMQMessageOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IBodyWorkflowAction<CreateQueueOutput> CreateQueue(Expression<Func<object>> queueName, Expression<Func<bool>> durable, Expression<Func<string>> exchangeName, Expression<Func<CreateQueueInputExchangeTypeType>> exchangeType, Expression<Func<string>> bindingKey)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["durable"] = ExpressionConverter.ConvertO(durable);
            serviceProviderParameters["exchangeName"] = ExpressionConverter.ConvertO(exchangeName);
            serviceProviderParameters["exchangeType"] = ExpressionConverter.ConvertO(exchangeType);
            serviceProviderParameters["bindingKey"] = ExpressionConverter.ConvertO(bindingKey);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/rabbitmq", "createQueue", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateQueueOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rabbitmq")]
        public IOutputWorkflowAction<JToken> CompleteMessage(Expression<Func<int>> deliveryTag, Expression<Func<string>> consumerTag, Expression<Func<CompleteMessageInputAcknowledgementType>> acknowledgement, Expression<Func<bool>> requeueOnReject = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deliveryTag"] = ExpressionConverter.ConvertO(deliveryTag);
            serviceProviderParameters["consumerTag"] = ExpressionConverter.ConvertO(consumerTag);
            serviceProviderParameters["acknowledgement"] = ExpressionConverter.ConvertO(acknowledgement);
            if (requeueOnReject != null)
            {
                serviceProviderParameters["requeueOnReject"] = ExpressionConverter.ConvertO(requeueOnReject);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/rabbitmq", "completeMessage", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }
    }

    public class RabbitmqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveRabbitMQMessagesOutput> ReceiveRabbitMQMessages(Expression<Func<object>> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/rabbitmq", "receiveRabbitMQMessages", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveRabbitMQMessagesOutput>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<PeeklockRabbitMQMessagesOutput> PeeklockRabbitMQMessages(Expression<Func<object>> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/rabbitmq", "peeklockRabbitMQMessages", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<PeeklockRabbitMQMessagesOutput>(serviceProviderInput);
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