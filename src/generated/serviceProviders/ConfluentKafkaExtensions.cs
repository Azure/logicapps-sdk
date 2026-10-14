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
    using System.Linq.Expressions;

    public class ConfluentKafkaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "confluentKafka")]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage(Expression<Func<string>> topicName, Expression<Func<object>> message, Expression<Func<string>> messageKey = null, Expression<Func<object>> headers = null, Expression<Func<string>> schemaSubjectName = null)
        {
            var __workflow_topicName = topicName == null ? null : WorkflowExpression.Compile(topicName);
            WorkflowExpression.Validate(__workflow_topicName, nameof(topicName), required: true);
            var __workflow_message = message == null ? null : WorkflowExpression.Compile(message);
            WorkflowExpression.Validate(__workflow_message, nameof(message), required: true);
            var __workflow_messageKey = messageKey == null ? null : WorkflowExpression.Compile(messageKey);
            WorkflowExpression.Validate(__workflow_messageKey, nameof(messageKey), required: false);
            var __workflow_headers = headers == null ? null : WorkflowExpression.Compile(headers);
            WorkflowExpression.Validate(__workflow_headers, nameof(headers), required: false);
            var __workflow_schemaSubjectName = schemaSubjectName == null ? null : WorkflowExpression.Compile(schemaSubjectName);
            WorkflowExpression.Validate(__workflow_schemaSubjectName, nameof(schemaSubjectName), required: false);
            return new DeferredBodyAction<SendMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["TopicName"] = ExpressionConverter.ConvertO(__workflow_topicName);
                serviceProviderParameters["Message"] = ExpressionConverter.ConvertO(__workflow_message);
                if (__workflow_messageKey != null)
                {
                    serviceProviderParameters["messageKey"] = ExpressionConverter.ConvertO(__workflow_messageKey);
                }

                if (__workflow_headers != null)
                {
                    serviceProviderParameters["Headers"] = ExpressionConverter.ConvertO(__workflow_headers);
                }

                if (__workflow_schemaSubjectName != null)
                {
                    serviceProviderParameters["SchemaSubjectName"] = ExpressionConverter.ConvertO(__workflow_schemaSubjectName);
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
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage(Expression<Func<string>> topic, Expression<Func<string>> consumerGroup = null, Expression<Func<ReceiveMessageInputAuthenticationModeType>> authenticationMode = null, Expression<Func<ReceiveMessageInputProtocolType>> protocol = null, Expression<Func<string>> avroSchema = null)
        {
            var __workflow_topic = topic == null ? null : WorkflowExpression.Compile(topic);
            WorkflowExpression.Validate(__workflow_topic, nameof(topic), required: true);
            var __workflow_consumerGroup = consumerGroup == null ? null : WorkflowExpression.Compile(consumerGroup);
            WorkflowExpression.Validate(__workflow_consumerGroup, nameof(consumerGroup), required: false);
            var __workflow_authenticationMode = authenticationMode == null ? null : WorkflowExpression.Compile(authenticationMode);
            WorkflowExpression.Validate(__workflow_authenticationMode, nameof(authenticationMode), required: false);
            var __workflow_protocol = protocol == null ? null : WorkflowExpression.Compile(protocol);
            WorkflowExpression.Validate(__workflow_protocol, nameof(protocol), required: false);
            var __workflow_avroSchema = avroSchema == null ? null : WorkflowExpression.Compile(avroSchema);
            WorkflowExpression.Validate(__workflow_avroSchema, nameof(avroSchema), required: false);
            return new DeferredBodyTrigger<ReceiveMessageOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["Topic"] = ExpressionConverter.ConvertO(__workflow_topic);
                if (__workflow_consumerGroup != null)
                {
                    serviceProviderParameters["ConsumerGroup"] = ExpressionConverter.ConvertO(__workflow_consumerGroup);
                }
                else
                {
                    serviceProviderParameters["ConsumerGroup"] = "$Default";
                }

                if (__workflow_authenticationMode != null)
                {
                    serviceProviderParameters["AuthenticationMode"] = ExpressionConverter.ConvertO(__workflow_authenticationMode);
                }
                else
                {
                    serviceProviderParameters["AuthenticationMode"] = "Plain";
                }

                if (__workflow_protocol != null)
                {
                    serviceProviderParameters["Protocol"] = ExpressionConverter.ConvertO(__workflow_protocol);
                }
                else
                {
                    serviceProviderParameters["Protocol"] = "SaslSsl";
                }

                if (__workflow_avroSchema != null)
                {
                    serviceProviderParameters["AvroSchema"] = ExpressionConverter.ConvertO(__workflow_avroSchema);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/confluentKafka", operationId: "ReceiveMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveMessageOutput>(serviceProviderInput);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReceiveMessageInputAuthenticationModeType
    {
        Plain,
        ScramSha256,
        ScramSha512
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
