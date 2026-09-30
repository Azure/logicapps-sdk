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
        public IBodyWorkflowAction<SendMessageOutput> SendMessage([WorkflowExpression] Func<string> topicName, [WorkflowExpression] Func<object> message, [WorkflowExpression] Func<string> messageKey = null, [WorkflowExpression] Func<object> headers = null, [WorkflowExpression] Func<string> schemaSubjectName = null, [WorkflowExpression] Func<bool> rawStringContent = null)
        {
            SourceExpression.Validate(topicName, nameof(topicName), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            SourceExpression.Validate(messageKey, nameof(messageKey), required: false);
            SourceExpression.Validate(headers, nameof(headers), required: false);
            SourceExpression.Validate(schemaSubjectName, nameof(schemaSubjectName), required: false);
            SourceExpression.Validate(rawStringContent, nameof(rawStringContent), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["TopicName"] = SourceExpressionConverter.ConvertToken(topicName);
                serviceProviderParameters["Message"] = SourceExpressionConverter.ConvertToken(message);
                if (messageKey != null)
                {
                    serviceProviderParameters["messageKey"] = SourceExpressionConverter.ConvertToken(messageKey);
                }

                if (headers != null)
                {
                    serviceProviderParameters["Headers"] = SourceExpressionConverter.ConvertToken(headers);
                }

                if (schemaSubjectName != null)
                {
                    serviceProviderParameters["SchemaSubjectName"] = SourceExpressionConverter.ConvertToken(schemaSubjectName);
                }

                if (rawStringContent != null)
                {
                    serviceProviderParameters["rawStringContent"] = SourceExpressionConverter.ConvertToken(rawStringContent);
                }
                else
                {
                    serviceProviderParameters["rawStringContent"] = false;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "SendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<SendMessageOutput>(BuildSourceInput);
        }
    }

    public class ConfluentKafkaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage([WorkflowExpression] Func<string> topic, [WorkflowExpression] Func<string> consumerGroup = null, [WorkflowExpression] Func<ReceiveMessageInputAuthenticationModeType> authenticationMode = null, [WorkflowExpression] Func<ReceiveMessageInputProtocolType> protocol = null, [WorkflowExpression] Func<string> avroSchema = null)
        {
            SourceExpression.Validate(topic, nameof(topic), required: true);
            SourceExpression.Validate(consumerGroup, nameof(consumerGroup), required: false);
            SourceExpression.Validate(authenticationMode, nameof(authenticationMode), required: false);
            SourceExpression.Validate(protocol, nameof(protocol), required: false);
            SourceExpression.Validate(avroSchema, nameof(avroSchema), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["Topic"] = SourceExpressionConverter.ConvertToken(topic);
                if (consumerGroup != null)
                {
                    serviceProviderParameters["ConsumerGroup"] = SourceExpressionConverter.ConvertToken(consumerGroup);
                }
                else
                {
                    serviceProviderParameters["ConsumerGroup"] = "$Default";
                }

                if (authenticationMode != null)
                {
                    serviceProviderParameters["AuthenticationMode"] = SourceExpressionConverter.ConvertToken(authenticationMode);
                }
                else
                {
                    serviceProviderParameters["AuthenticationMode"] = "Plain";
                }

                if (protocol != null)
                {
                    serviceProviderParameters["Protocol"] = SourceExpressionConverter.ConvertToken(protocol);
                }
                else
                {
                    serviceProviderParameters["Protocol"] = "SaslSsl";
                }

                if (avroSchema != null)
                {
                    serviceProviderParameters["AvroSchema"] = SourceExpressionConverter.ConvertToken(avroSchema);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "ReceiveMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveMessageOutput>(BuildSourceInput);
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