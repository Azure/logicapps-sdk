//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<PutMessageOutput> PutMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<string> timeToLive = null, [WorkflowExpression] Func<string> visibilityTimeout = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["message"] = ExpressionConverter.ConvertO(message);
            if (timeToLive != null)
            {
                serviceProviderParameters["timeToLive"] = ExpressionConverter.ConvertO(timeToLive);
            }

            if (visibilityTimeout != null)
            {
                serviceProviderParameters["visibilityTimeout"] = ExpressionConverter.ConvertO(visibilityTimeout);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<PutMessageOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> GetMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> messageCount = null, [WorkflowExpression] Func<string> visibilityTimeout = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (messageCount != null)
            {
                serviceProviderParameters["messageCount"] = ExpressionConverter.ConvertO(messageCount);
            }
            else
            {
                serviceProviderParameters["messageCount"] = 1;
            }

            if (visibilityTimeout != null)
            {
                serviceProviderParameters["visibilityTimeout"] = ExpressionConverter.ConvertO(visibilityTimeout);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "getMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> DeleteMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> popReceipt)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            serviceProviderParameters["popReceipt"] = ExpressionConverter.ConvertO(popReceipt);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "deleteMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> PutQueue([WorkflowExpression] Func<string> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putQueue", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<ListQueuesOutput> ListQueues([WorkflowExpression] Func<string> prefix = null, [WorkflowExpression] Func<int> maxCount = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            var serviceProviderParameters = new JObject();
            if (prefix != null)
            {
                serviceProviderParameters["prefix"] = ExpressionConverter.ConvertO(prefix);
            }

            if (maxCount != null)
            {
                serviceProviderParameters["maxCount"] = ExpressionConverter.ConvertO(maxCount);
            }

            if (continuationToken != null)
            {
                serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "listQueues", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ListQueuesOutput>(serviceProviderInput);
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput> ReceiveQueueMessages([WorkflowExpression] Func<object> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "receiveQueueMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<int> SpecifiedNumberOfMessagesAvailable([WorkflowExpression] Func<object> queueName, [WorkflowExpression] Func<int> threshold, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["threshold"] = ExpressionConverter.ConvertO(threshold);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "specifiedNumberOfMessagesAvailable", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<int>(serviceProviderInput, isPolling: true, recurrence: recurrence);
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