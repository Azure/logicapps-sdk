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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "putMessage", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<PutMessageOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> GetMessages(Expression<Func<string>> queueName, Expression<Func<int>> messageCount = null, Expression<Func<string>> visibilityTimeout = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            if (messageCount != null)
            {
                serviceProviderParameters["messageCount"] = ExpressionConverter.ConvertO(messageCount);
            }

            if (visibilityTimeout != null)
            {
                serviceProviderParameters["visibilityTimeout"] = ExpressionConverter.ConvertO(visibilityTimeout);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "getMessages", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMessagesOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> DeleteMessage(Expression<Func<string>> queueName, Expression<Func<string>> messageId, Expression<Func<string>> popReceipt)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            serviceProviderParameters["popReceipt"] = ExpressionConverter.ConvertO(popReceipt);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "deleteMessage", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        public IOutputWorkflowAction<JToken> PutQueue(Expression<Func<string>> queueName)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "putQueue", connectionId),
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "listQueues", connectionId),
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
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "receiveQueueMessages", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(serviceProviderInput);
        }

        public IBodyWorkflowTrigger<int> SpecifiedNumberOfMessagesAvailable(Expression<Func<object>> queueName, Expression<Func<int>> threshold, FlowRecurrence recurrence = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            serviceProviderParameters["threshold"] = ExpressionConverter.ConvertO(threshold);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/azurequeues", "specifiedNumberOfMessagesAvailable", connectionId),
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