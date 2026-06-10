//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Batch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BatchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "batch")]
        public IBodyWorkflowAction<SendToBatchOutput> SendToBatch(Expression<Func<string>> batchName, Expression<Func<object>> content, Expression<Func<SendToBatchHostType>> host, Expression<Func<string>> partitionName = null, Expression<Func<string>> messageId = null)
        {
            var parameters = new JObject();
            parameters["batchName"] = ExpressionConverter.ConvertO(batchName);
            parameters["content"] = ExpressionConverter.ConvertO(content);
            if (partitionName != null)
            {
                parameters["partitionName"] = ExpressionConverter.ConvertO(partitionName);
            }

            if (messageId != null)
            {
                parameters["messageId"] = ExpressionConverter.ConvertO(messageId);
            }

            parameters["host"] = ExpressionConverter.ConvertO(host);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/connectionProviders/batch", operationId: "sendToBatch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<SendToBatchOutput>(input);
        }
    }

    public class BatchTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BatchOutput> Batch(Expression<Func<string>> mode, Expression<Func<BatchConfigurationsType>> configurations, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["mode"] = ExpressionConverter.ConvertO(mode);
            parameters["configurations"] = ExpressionConverter.ConvertO(configurations);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/connectionProviders/batch", operationId: "batch", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<BatchOutput>(input, triggerName);
        }
    }

    public class SendToBatchOutput
    {
        [JsonProperty("batchName")]
        public string BatchName { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("partitionName")]
        public string PartitionName { get; set; }
    }

    public class SendToBatchHostType
    {
        [JsonProperty("workflow")]
        public SendToBatchHostTypeWorkflowType Workflow { get; set; }

        [JsonProperty("triggerName")]
        public string TriggerName { get; set; }
    }

    public class SendToBatchHostTypeWorkflowType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BatchOutput
    {
        [JsonProperty("batchName")]
        public string BatchName { get; set; }

        [JsonProperty("partitionName")]
        public string PartitionName { get; set; }

        [JsonProperty("items")]
        public BatchOutputItemsTypeItem[] Items { get; set; }
    }

    public class BatchOutputItemsTypeItem
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    public class BatchConfigurationsType
    {
        [JsonProperty("$$batchName$$")]
        public BatchConfigurationsTypeBatchNameType BatchName { get; set; }
    }

    public class BatchConfigurationsTypeBatchNameType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("releaseCriteria")]
        public BatchConfigurationsTypeBatchNameTypeReleaseCriteriaType ReleaseCriteria { get; set; }
    }

    public class BatchConfigurationsTypeBatchNameTypeReleaseCriteriaType
    {
        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("messageCount")]
        public int MessageCount { get; set; }

        [JsonProperty("batchSize")]
        public int BatchSize { get; set; }

        [JsonProperty("recurrence")]
        public JToken Recurrence { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Batch;

    public partial class WorkflowServiceProviderActions
    {
        public BatchActions Batch(string connectionId) => new BatchActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public BatchTriggers Batch(string connectionId) => new BatchTriggers(connectionId);
    }
}