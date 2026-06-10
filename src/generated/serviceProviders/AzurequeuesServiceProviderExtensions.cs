//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurequeuesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<PutMessageOutput> PutMessage(Expression<Func<string>> queueName, Expression<Func<string>> message, Expression<Func<string>> timeToLive = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["message"] = ExpressionConverter.ConvertO(message);
            if (timeToLive != null)
            {
                parameters["timeToLive"] = ExpressionConverter.ConvertO(timeToLive);
            }

            if (visibilityTimeout != null)
            {
                parameters["visibilityTimeout"] = ExpressionConverter.ConvertO(visibilityTimeout);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<PutMessageOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> GetMessages(Expression<Func<string>> queueName, Expression<Func<int>> messageCount = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (messageCount != null)
            {
                parameters["messageCount"] = ExpressionConverter.ConvertO(messageCount);
            }

            if (visibilityTimeout != null)
            {
                parameters["visibilityTimeout"] = ExpressionConverter.ConvertO(visibilityTimeout);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "getMessages", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetMessagesOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> DeleteMessage(Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popReceipt)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            parameters["popReceipt"] = ExpressionConverter.ConvertO(popReceipt);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "deleteMessage", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> PutQueue(Expression<Func<string>> queueName)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putQueue", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<ListQueuesOutput> ListQueues(Expression<Func<string>> prefix = null, Expression<Func<int>> maxCount = null, Expression<Func<string>> continuationToken = null)
        {
            var parameters = new JObject();
            if (prefix != null)
            {
                parameters["prefix"] = ExpressionConverter.ConvertO(prefix);
            }

            if (maxCount != null)
            {
                parameters["maxCount"] = ExpressionConverter.ConvertO(maxCount);
            }

            if (continuationToken != null)
            {
                parameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "listQueues", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ListQueuesOutput>(input);
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput> ReceiveQueueMessages(Expression<Func<object>> queueName, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "receiveQueueMessages", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(input, triggerName);
        }

        public IBodyWorkflowTrigger<int> SpecifiedNumberOfMessagesAvailable(Expression<Func<object>> queueName, Expression<Func<int>> threshold, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            parameters["threshold"] = ExpressionConverter.ConvertO(threshold);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "specifiedNumberOfMessagesAvailable", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<int>(input, triggerName);
        }
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