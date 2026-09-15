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
        public IOutputWorkflowAction<PutMessageOutput> PutMessage(Expression<Func<string>> queueName, Expression<Func<string>> message, Expression<Func<string>> timeToLive = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            serviceProviderParameters["message"] = CSharpExpressionConverter.ConvertToken(message);
            if (timeToLive != null)
            {
                serviceProviderParameters["timeToLive"] = CSharpExpressionConverter.ConvertToken(timeToLive);
            }

            if (visibilityTimeout != null)
            {
                serviceProviderParameters["visibilityTimeout"] = CSharpExpressionConverter.ConvertToken(visibilityTimeout);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<PutMessageOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> GetMessages(Expression<Func<string>> queueName, Expression<Func<int>> messageCount = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            if (messageCount != null)
            {
                serviceProviderParameters["messageCount"] = CSharpExpressionConverter.ConvertToken(messageCount);
            }
            else
            {
                serviceProviderParameters["messageCount"] = 1;
            }

            if (visibilityTimeout != null)
            {
                serviceProviderParameters["visibilityTimeout"] = CSharpExpressionConverter.ConvertToken(visibilityTimeout);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "getMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> DeleteMessage(Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popReceipt)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            serviceProviderParameters["messageId"] = CSharpExpressionConverter.ConvertToken(messageId);
            serviceProviderParameters["popReceipt"] = CSharpExpressionConverter.ConvertToken(popReceipt);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "deleteMessage", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> PutQueue(Expression<Func<string>> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putQueue", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<ListQueuesOutput> ListQueues(Expression<Func<string>> prefix = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> continuationToken = null)
        {
            var serviceProviderParameters = new JObject();
            if (prefix != null)
            {
                serviceProviderParameters["prefix"] = CSharpExpressionConverter.ConvertToken(prefix);
            }

            if (maxCount != null)
            {
                serviceProviderParameters["maxCount"] = CSharpExpressionConverter.ConvertToken(maxCount);
            }

            if (continuationToken != null)
            {
                serviceProviderParameters["continuationToken"] = CSharpExpressionConverter.ConvertToken(continuationToken);
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
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput> ReceiveQueueMessages(Expression<Func<object>> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "receiveQueueMessages", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<int> SpecifiedNumberOfMessagesAvailable(Expression<Func<object>> queueName, Expression<Func<int>> threshold, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            serviceProviderParameters["threshold"] = CSharpExpressionConverter.ConvertToken(threshold);
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