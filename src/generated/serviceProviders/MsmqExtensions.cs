//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Msmq
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class MsmqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "msmq")]
        public IBodyWorkflowAction<SendMsmqMessageOutput> SendMsmqMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> messageBody, [WorkflowExpression] Func<string> messageLabel = null, [WorkflowExpression] Func<bool> isTransactional = null, [WorkflowExpression] Func<bool> useDeadLetterQueue = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(messageBody, nameof(messageBody), required: true);
            SourceExpression.Validate(messageLabel, nameof(messageLabel), required: false);
            SourceExpression.Validate(isTransactional, nameof(isTransactional), required: false);
            SourceExpression.Validate(useDeadLetterQueue, nameof(useDeadLetterQueue), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (messageLabel != null)
                {
                    serviceProviderParameters["messageLabel"] = SourceExpressionConverter.ConvertToken(messageLabel);
                }

                serviceProviderParameters["messageBody"] = SourceExpressionConverter.ConvertToken(messageBody);
                if (isTransactional != null)
                {
                    serviceProviderParameters["isTransactional"] = SourceExpressionConverter.ConvertToken(isTransactional);
                }
                else
                {
                    serviceProviderParameters["isTransactional"] = false;
                }

                if (useDeadLetterQueue != null)
                {
                    serviceProviderParameters["useDeadLetterQueue"] = SourceExpressionConverter.ConvertToken(useDeadLetterQueue);
                }
                else
                {
                    serviceProviderParameters["useDeadLetterQueue"] = true;
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/msmq", operationId: "sendMsmqMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<SendMsmqMessageOutput>(BuildSourceInput);
        }
    }

    public class MsmqTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenMessageIsAvailableInMsmqQueueOutput> WhenMessageIsAvailableInMsmqQueue([WorkflowExpression] Func<string> queueName)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/msmq", operationId: "whenMessageIsAvailableInMsmqQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenMessageIsAvailableInMsmqQueueOutput>(BuildSourceInput);
        }
    }

    public class SendMsmqMessageOutput
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("queuePath")]
        public string QueuePath { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class WhenMessageIsAvailableInMsmqQueueOutput
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("queuePath")]
        public string QueuePath { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Msmq;

    public partial class WorkflowServiceProviderActions
    {
        public MsmqActions Msmq(string connectionId) => new MsmqActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public MsmqTriggers Msmq(string connectionId) => new MsmqTriggers(connectionId);
    }
}