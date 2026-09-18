//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<PutMessageOutput> PutMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<string> timeToLive = null, [WorkflowExpression] Func<string> visibilityTimeout = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            SourceExpression.Validate(timeToLive, nameof(timeToLive), required: false);
            SourceExpression.Validate(visibilityTimeout, nameof(visibilityTimeout), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["message"] = SourceExpressionConverter.ConvertToken(message);
                if (timeToLive != null)
                {
                    serviceProviderParameters["timeToLive"] = SourceExpressionConverter.ConvertToken(timeToLive);
                }

                if (visibilityTimeout != null)
                {
                    serviceProviderParameters["visibilityTimeout"] = SourceExpressionConverter.ConvertToken(visibilityTimeout);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<PutMessageOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> GetMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> messageCount = null, [WorkflowExpression] Func<string> visibilityTimeout = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(messageCount, nameof(messageCount), required: false);
            SourceExpression.Validate(visibilityTimeout, nameof(visibilityTimeout), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                if (messageCount != null)
                {
                    serviceProviderParameters["messageCount"] = SourceExpressionConverter.ConvertToken(messageCount);
                }
                else
                {
                    serviceProviderParameters["messageCount"] = 1;
                }

                if (visibilityTimeout != null)
                {
                    serviceProviderParameters["visibilityTimeout"] = SourceExpressionConverter.ConvertToken(visibilityTimeout);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "getMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetMessagesOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> DeleteMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> popReceipt)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(popReceipt, nameof(popReceipt), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["messageId"] = SourceExpressionConverter.ConvertToken(messageId);
                serviceProviderParameters["popReceipt"] = SourceExpressionConverter.ConvertToken(popReceipt);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "deleteMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> PutQueue([WorkflowExpression] Func<string> queueName)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<ListQueuesOutput> ListQueues([WorkflowExpression] Func<string> prefix = null, [WorkflowExpression] Func<int> maxCount = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            SourceExpression.Validate(prefix, nameof(prefix), required: false);
            SourceExpression.Validate(maxCount, nameof(maxCount), required: false);
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (prefix != null)
                {
                    serviceProviderParameters["prefix"] = SourceExpressionConverter.ConvertToken(prefix);
                }

                if (maxCount != null)
                {
                    serviceProviderParameters["maxCount"] = SourceExpressionConverter.ConvertToken(maxCount);
                }

                if (continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = SourceExpressionConverter.ConvertToken(continuationToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "listQueues", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ListQueuesOutput>(BuildSourceInput);
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput> ReceiveQueueMessages([WorkflowExpression] Func<object> queueName)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "receiveQueueMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<int> SpecifiedNumberOfMessagesAvailable([WorkflowExpression] Func<object> queueName, [WorkflowExpression] Func<int> threshold, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(queueName, nameof(queueName), required: true);
            SourceExpression.Validate(threshold, nameof(threshold), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                serviceProviderParameters["threshold"] = SourceExpressionConverter.ConvertToken(threshold);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "specifiedNumberOfMessagesAvailable", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<int>(BuildSourceInput, isPolling: true, recurrence: recurrence);
        }
    }

    public class ReceiveQueueMessagesOutput
    {
        [JsonProperty("messageText")]
        public JToken MessageText { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("insertedOn")]
        public string InsertedOn { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("popReceipt")]
        public string PopReceipt { get; set; }

        [JsonProperty("nextVisibleOn")]
        public string NextVisibleOn { get; set; }
    }

    public class PutMessageOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("insertedOn")]
        public string InsertedOn { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("popReceipt")]
        public string PopReceipt { get; set; }

        [JsonProperty("nextVisibleOn")]
        public string NextVisibleOn { get; set; }
    }

    public class GetMessagesOutputItem
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("insertedOn")]
        public string InsertedOn { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("popReceipt")]
        public string PopReceipt { get; set; }

        [JsonProperty("nextVisibleOn")]
        public string NextVisibleOn { get; set; }
    }

    public class ListQueuesOutput
    {
        [JsonProperty("queueList")]
        public JToken QueueList { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues;

    public partial class WorkflowServiceProviderActions
    {
        public AzurequeuesActions Azurequeues(string connectionId) => new AzurequeuesActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzurequeuesTriggers Azurequeues(string connectionId) => new AzurequeuesTriggers(connectionId);
    }
}