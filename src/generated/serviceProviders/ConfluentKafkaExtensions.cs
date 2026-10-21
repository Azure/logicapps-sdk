//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ConfluentKafka
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ConfluentKafkaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "confluentKafka")]
        public IBodyWorkflowAction<SendMessageOutput> SendMessage(Expression<Func<string>> topicName, Expression<Func<object>> message, Expression<Func<string>> messageKey = null, Expression<Func<object>> headers = null, Expression<Func<string>> schemaSubjectName = null)
        {
            var __workflow_topicName = WorkflowExpression.Compile(topicName, nameof(topicName), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: true);
            var __workflow_messageKey = WorkflowExpression.Compile(messageKey, nameof(messageKey), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_schemaSubjectName = WorkflowExpression.Compile(schemaSubjectName, nameof(schemaSubjectName), required: false);
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
            }, WorkflowActionSettings.TrackedProperties | WorkflowActionSettings.SecureInputs | WorkflowActionSettings.SecureOutputs);
        }
    }

    public class ConfluentKafkaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveMessageOutput> ReceiveMessage(Expression<Func<string>> topic, Expression<Func<string>> consumerGroup = null, Expression<Func<ReceiveMessageInputAuthenticationModeType>> authenticationMode = null, Expression<Func<ReceiveMessageInputProtocolType>> protocol = null, Expression<Func<string>> avroSchema = null)
        {
            var __workflow_topic = WorkflowExpression.Compile(topic, nameof(topic), required: true);
            var __workflow_consumerGroup = WorkflowExpression.Compile(consumerGroup, nameof(consumerGroup), required: false);
            var __workflow_authenticationMode = WorkflowExpression.Compile(authenticationMode, nameof(authenticationMode), required: false);
            var __workflow_protocol = WorkflowExpression.Compile(protocol, nameof(protocol), required: false);
            var __workflow_avroSchema = WorkflowExpression.Compile(avroSchema, nameof(avroSchema), required: false);
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
            }, WorkflowTriggerSettings.SecureInputs | WorkflowTriggerSettings.SecureOutputs);
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