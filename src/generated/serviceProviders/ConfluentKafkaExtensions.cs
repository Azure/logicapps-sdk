//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ConfluentKafka
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ConfluentKafkaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "confluentKafka")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<object> message, [WorkflowExpression] Func<string> messageKey = null, [WorkflowExpression] Func<object> headers = null, [WorkflowExpression] Func<string> schemaSubjectName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageOutput> __BuildSendMessage(WorkflowValue<string> topicName, WorkflowValue<object> message, WorkflowValue<string> messageKey = null, WorkflowValue<object> headers = null, WorkflowValue<string> schemaSubjectName = null)
        {
            WorkflowValue.Validate(topicName, nameof(topicName), required: true);
            WorkflowValue.Validate(message, nameof(message), required: true);
            WorkflowValue.Validate(messageKey, nameof(messageKey), required: false);
            WorkflowValue.Validate(headers, nameof(headers), required: false);
            WorkflowValue.Validate(schemaSubjectName, nameof(schemaSubjectName), required: false);
            return new DeferredBodyAction<SendMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["TopicName"] = ExpressionConverter.ConvertO(topicName);
                serviceProviderParameters["Message"] = ExpressionConverter.ConvertO(message);
                if (messageKey != null)
                {
                    serviceProviderParameters["messageKey"] = ExpressionConverter.ConvertO(messageKey);
                }

                if (headers != null)
                {
                    serviceProviderParameters["Headers"] = ExpressionConverter.ConvertO(headers);
                }

                if (schemaSubjectName != null)
                {
                    serviceProviderParameters["SchemaSubjectName"] = ExpressionConverter.ConvertO(schemaSubjectName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "SendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendMessageOutput>(serviceProviderInput);
            });
        }
    }

    public class ConfluentKafkaTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildReceiveMessage))]
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage([WorkflowExpression] Func<string> topic, [WorkflowExpression] Func<string> consumerGroup = null, [WorkflowExpression] Func<ReceiveMessageInputAuthenticationModeType> authenticationMode = null, [WorkflowExpression] Func<ReceiveMessageInputProtocolType> protocol = null, [WorkflowExpression] Func<string> avroSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveMessageOutput> __BuildReceiveMessage(WorkflowValue<string> topic, WorkflowValue<string> consumerGroup = null, WorkflowValue<ReceiveMessageInputAuthenticationModeType> authenticationMode = null, WorkflowValue<ReceiveMessageInputProtocolType> protocol = null, WorkflowValue<string> avroSchema = null)
        {
            WorkflowValue.Validate(topic, nameof(topic), required: true);
            WorkflowValue.Validate(consumerGroup, nameof(consumerGroup), required: false);
            WorkflowValue.Validate(authenticationMode, nameof(authenticationMode), required: false);
            WorkflowValue.Validate(protocol, nameof(protocol), required: false);
            WorkflowValue.Validate(avroSchema, nameof(avroSchema), required: false);
            return new DeferredBodyTrigger<ReceiveMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["Topic"] = ExpressionConverter.ConvertO(topic);
                if (consumerGroup != null)
                {
                    serviceProviderParameters["ConsumerGroup"] = ExpressionConverter.ConvertO(consumerGroup);
                }
                else
                {
                    serviceProviderParameters["ConsumerGroup"] = "$Default";
                }

                if (authenticationMode != null)
                {
                    serviceProviderParameters["AuthenticationMode"] = ExpressionConverter.ConvertO(authenticationMode);
                }
                else
                {
                    serviceProviderParameters["AuthenticationMode"] = "Plain";
                }

                if (protocol != null)
                {
                    serviceProviderParameters["Protocol"] = ExpressionConverter.ConvertO(protocol);
                }
                else
                {
                    serviceProviderParameters["Protocol"] = "SaslSsl";
                }

                if (avroSchema != null)
                {
                    serviceProviderParameters["AvroSchema"] = ExpressionConverter.ConvertO(avroSchema);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "ReceiveMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveMessageOutput>(serviceProviderInput);
            }, "ServiceProviderTrigger");
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
