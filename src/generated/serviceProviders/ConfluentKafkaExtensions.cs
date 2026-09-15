//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ConfluentKafka
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ConfluentKafkaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "confluentKafka")]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage(Expression<Func<string>> topicName, Expression<Func<object>> message, Expression<Func<string>> messageKey = null, Expression<Func<object>> headers = null, Expression<Func<string>> schemaSubjectName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["TopicName"] = CSharpExpressionConverter.ConvertToken(topicName);
            serviceProviderParameters["Message"] = CSharpExpressionConverter.ConvertToken(message);
            if (messageKey != null)
            {
                serviceProviderParameters["messageKey"] = CSharpExpressionConverter.ConvertToken(messageKey);
            }

            if (headers != null)
            {
                serviceProviderParameters["Headers"] = CSharpExpressionConverter.ConvertToken(headers);
            }

            if (schemaSubjectName != null)
            {
                serviceProviderParameters["SchemaSubjectName"] = CSharpExpressionConverter.ConvertToken(schemaSubjectName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "SendMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<SendMessageOutput>(serviceProviderInput);
        }
    }

    public class ConfluentKafkaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage(Expression<Func<string>> topic, Expression<Func<string>> consumerGroup = null, Expression<Func<ReceiveMessageInputAuthenticationModeType>> authenticationMode = null, Expression<Func<ReceiveMessageInputProtocolType>> protocol = null, Expression<Func<string>> avroSchema = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["Topic"] = CSharpExpressionConverter.ConvertToken(topic);
            if (consumerGroup != null)
            {
                serviceProviderParameters["ConsumerGroup"] = CSharpExpressionConverter.ConvertToken(consumerGroup);
            }
            else
            {
                serviceProviderParameters["ConsumerGroup"] = "$Default";
            }

            if (authenticationMode != null)
            {
                serviceProviderParameters["AuthenticationMode"] = CSharpExpressionConverter.ConvertToken(authenticationMode);
            }
            else
            {
                serviceProviderParameters["AuthenticationMode"] = "Plain";
            }

            if (protocol != null)
            {
                serviceProviderParameters["Protocol"] = CSharpExpressionConverter.ConvertToken(protocol);
            }
            else
            {
                serviceProviderParameters["Protocol"] = "SaslSsl";
            }

            if (avroSchema != null)
            {
                serviceProviderParameters["AvroSchema"] = CSharpExpressionConverter.ConvertToken(avroSchema);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "ReceiveMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveMessageOutput>(serviceProviderInput);
        }
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveMessageInputAuthenticationModeType
    {
        Plain,
        ScramSha256,
        ScramSha512
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveMessageInputProtocolType
    {
        Ssl,
        SaslPlaintext,
        SaslSsl
    }

    public class SendMessageOutput
    {
        public string TopicName { get; set; }
        public int Partition { get; set; }
        public int Offset { get; set; }
        public string Timestamp { get; set; }
        public string Status { get; set; }
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