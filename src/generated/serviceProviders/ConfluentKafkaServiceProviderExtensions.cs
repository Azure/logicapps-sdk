//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ConfluentKafka
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConfluentKafkaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "confluentKafka")]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage(Expression<Func<string>> topicName, Expression<Func<object>> message, Expression<Func<string>> messageKey = null, Expression<Func<object>> headers = null, Expression<Func<string>> schemaSubjectName = null)
        {
            var parameters = new JObject();
            parameters["TopicName"] = ExpressionConverter.ConvertO(topicName);
            parameters["Message"] = ExpressionConverter.ConvertO(message);
            if (messageKey != null)
            {
                parameters["messageKey"] = ExpressionConverter.ConvertO(messageKey);
            }

            if (headers != null)
            {
                parameters["Headers"] = ExpressionConverter.ConvertO(headers);
            }

            if (schemaSubjectName != null)
            {
                parameters["SchemaSubjectName"] = ExpressionConverter.ConvertO(schemaSubjectName);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "SendMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<SendMessageOutput>(input);
        }
    }

    public class ConfluentKafkaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage(Expression<Func<string>> topic, Expression<Func<string>> consumerGroup = null, Expression<Func<ReceiveMessageAuthenticationModeType>> authenticationMode = null, Expression<Func<ReceiveMessageProtocolType>> protocol = null, Expression<Func<string>> avroSchema = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["Topic"] = ExpressionConverter.ConvertO(topic);
            if (consumerGroup != null)
            {
                parameters["ConsumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
            }

            if (authenticationMode != null)
            {
                parameters["AuthenticationMode"] = ExpressionConverter.ConvertO(authenticationMode);
            }

            if (protocol != null)
            {
                parameters["Protocol"] = ExpressionConverter.ConvertO(protocol);
            }

            if (avroSchema != null)
            {
                parameters["AvroSchema"] = ExpressionConverter.ConvertO(avroSchema);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "ReceiveMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<ReceiveMessageOutput>(input, triggerName);
        }
    }

    public class SendMessageOutput
    {
        public string TopicName { get; set; }
        public int Partition { get; set; }
        public int Offset { get; set; }
        public string Timestamp { get; set; }
        public string Status { get; set; }
    }

    public class ReceiveMessageOutput
    {
        [JsonProperty("messageKey")]
        public string MessageKey { get; set; }
        public int Offset { get; set; }
        public int Partition { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
        public ReceiveMessageOutputHeadersType Headers { get; set; }
        public string Timestamp { get; set; }
        public string Message { get; set; }
    }

    public class ReceiveMessageOutputHeadersType
    {
        public string HeaderKey { get; set; }
        public string HeaderValue { get; set; }
    }

    public enum ReceiveMessageAuthenticationModeType
    {
        Plain,
        ScramSha256,
        ScramSha512
    }

    public enum ReceiveMessageProtocolType
    {
        Ssl,
        SaslPlaintext,
        SaslSsl
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ConfluentKafka;

    public partial class WorkflowServiceProviderActions
    {
        public ConfluentKafkaActions ConfluentKafka(string connectionId) => new ConfluentKafkaActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public ConfluentKafkaTriggers ConfluentKafka(string connectionId) => new ConfluentKafkaTriggers(connectionId);
    }
}