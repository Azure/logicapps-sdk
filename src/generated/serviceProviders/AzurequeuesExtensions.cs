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
        [WorkflowExpressionFactory(nameof(__BuildPutMessage))]
        public IOutputWorkflowAction<PutMessageOutput> PutMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<string> timeToLive = null, [WorkflowExpression] Func<string> visibilityTimeout = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<PutMessageOutput> __BuildPutMessage(WorkflowValue<string> queueName, WorkflowValue<string> message, WorkflowValue<string> timeToLive = null, WorkflowValue<string> visibilityTimeout = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(message, nameof(message), required: true);
            WorkflowValue.Validate(timeToLive, nameof(timeToLive), required: false);
            WorkflowValue.Validate(visibilityTimeout, nameof(visibilityTimeout), required: false);
            return new DeferredOutputAction<PutMessageOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessages))]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> GetMessages([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<int> messageCount = null, [WorkflowExpression] Func<string> visibilityTimeout = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesOutputItem[]> __BuildGetMessages(WorkflowValue<string> queueName, WorkflowValue<int> messageCount = null, WorkflowValue<string> visibilityTimeout = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(messageCount, nameof(messageCount), required: false);
            WorkflowValue.Validate(visibilityTimeout, nameof(visibilityTimeout), required: false);
            return new DeferredBodyAction<GetMessagesOutputItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteMessage))]
        public IOutputWorkflowAction<JToken> DeleteMessage([WorkflowExpression] Func<string> queueName, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> popReceipt)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildDeleteMessage(WorkflowValue<string> queueName, WorkflowValue<string> messageId, WorkflowValue<string> popReceipt)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(popReceipt, nameof(popReceipt), required: true);
            return new DeferredOutputAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildPutQueue))]
        public IOutputWorkflowAction<JToken> PutQueue([WorkflowExpression] Func<string> queueName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildPutQueue(WorkflowValue<string> queueName)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "putQueue", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "azurequeues")]
        [WorkflowExpressionFactory(nameof(__BuildListQueues))]
        public IBodyWorkflowAction<ListQueuesOutput> ListQueues([WorkflowExpression] Func<string> prefix = null, [WorkflowExpression] Func<int> maxCount = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListQueuesOutput> __BuildListQueues(WorkflowValue<string> prefix = null, WorkflowValue<int> maxCount = null, WorkflowValue<string> continuationToken = null)
        {
            WorkflowValue.Validate(prefix, nameof(prefix), required: false);
            WorkflowValue.Validate(maxCount, nameof(maxCount), required: false);
            WorkflowValue.Validate(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<ListQueuesOutput>(() =>
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
            });
        }
    }

    public class AzurequeuesTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildReceiveQueueMessages))]
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput> ReceiveQueueMessages([WorkflowExpression] Func<object> queueName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReceiveQueueMessagesOutput> __BuildReceiveQueueMessages(WorkflowValue<object> queueName)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            return new DeferredBodyTrigger<ReceiveQueueMessagesOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/azurequeues", operationId: "receiveQueueMessages", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<ReceiveQueueMessagesOutput>(serviceProviderInput);
            }, "ServiceProviderTrigger");
        }

        [WorkflowExpressionFactory(nameof(__BuildSpecifiedNumberOfMessagesAvailable))]
        public IBodyWorkflowTrigger<int> SpecifiedNumberOfMessagesAvailable([WorkflowExpression] Func<object> queueName, [WorkflowExpression] Func<int> threshold, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<int> __BuildSpecifiedNumberOfMessagesAvailable(WorkflowValue<object> queueName, WorkflowValue<int> threshold, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(queueName, nameof(queueName), required: true);
            WorkflowValue.Validate(threshold, nameof(threshold), required: true);
            return new DeferredBodyTrigger<int>(() =>
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
            }, "ServiceProviderTrigger");
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
