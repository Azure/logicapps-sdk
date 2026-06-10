//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureCosmosDB
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureCosmosDBActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<BulkCreateOrUpdateDocumentOutputItem[]> BulkCreateOrUpdateDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<object>> items, Expression<Func<bool>> isUpsert = null)
        {
            var parameters = new JObject();
            parameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
            parameters["containerId"] = ExpressionConverter.ConvertO(containerId);
            parameters["items"] = ExpressionConverter.ConvertO(items);
            if (isUpsert != null)
            {
                parameters["isUpsert"] = ExpressionConverter.ConvertO(isUpsert);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "BulkCreateOrUpdateDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<BulkCreateOrUpdateDocumentOutputItem[]>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<CreateOrUpdateDocumentOutput> CreateOrUpdateDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> item, Expression<Func<string>> partitionKey = null, Expression<Func<bool>> isUpsert = null, Expression<Func<string>> sessionToken = null, Expression<Func<string>> etag = null)
        {
            var parameters = new JObject();
            parameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
            parameters["containerId"] = ExpressionConverter.ConvertO(containerId);
            parameters["item"] = ExpressionConverter.ConvertO(item);
            if (partitionKey != null)
            {
                parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            }

            if (isUpsert != null)
            {
                parameters["isUpsert"] = ExpressionConverter.ConvertO(isUpsert);
            }

            if (sessionToken != null)
            {
                parameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
            }

            if (etag != null)
            {
                parameters["etag"] = ExpressionConverter.ConvertO(etag);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "CreateOrUpdateDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<CreateOrUpdateDocumentOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<DeleteDocumentOutput> DeleteDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<string>> sessionToken = null)
        {
            var parameters = new JObject();
            parameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
            parameters["containerId"] = ExpressionConverter.ConvertO(containerId);
            parameters["itemId"] = ExpressionConverter.ConvertO(itemId);
            parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            if (sessionToken != null)
            {
                parameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "DeleteDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<DeleteDocumentOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<QueryDocumentsOutput> QueryDocuments(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> queryText, Expression<Func<string>> partitionKey = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> maxItemCount = null, Expression<Func<string>> sessionToken = null)
        {
            var parameters = new JObject();
            parameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
            parameters["containerId"] = ExpressionConverter.ConvertO(containerId);
            parameters["queryText"] = ExpressionConverter.ConvertO(queryText);
            if (partitionKey != null)
            {
                parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            }

            if (continuationToken != null)
            {
                parameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
            }

            if (maxItemCount != null)
            {
                parameters["maxItemCount"] = ExpressionConverter.ConvertO(maxItemCount);
            }

            if (sessionToken != null)
            {
                parameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "QueryDocuments", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<QueryDocumentsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<ReadDocumentOutput> ReadDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<string>> sessionToken = null)
        {
            var parameters = new JObject();
            parameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
            parameters["containerId"] = ExpressionConverter.ConvertO(containerId);
            parameters["itemId"] = ExpressionConverter.ConvertO(itemId);
            parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            if (sessionToken != null)
            {
                parameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "ReadDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ReadDocumentOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<PatchItemOutput> PatchItem(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<PatchItemPatchOperationsTypeItem[]>> patchOperations, Expression<Func<string>> sessionToken = null)
        {
            var parameters = new JObject();
            parameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
            parameters["containerId"] = ExpressionConverter.ConvertO(containerId);
            parameters["itemId"] = ExpressionConverter.ConvertO(itemId);
            parameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
            if (sessionToken != null)
            {
                parameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
            }

            parameters["patchOperations"] = ExpressionConverter.ConvertO(patchOperations);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "PatchItem", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<PatchItemOutput>(input);
        }
    }

    public class AzureCosmosDBTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]> WhenADocumentIsCreatedOrModified(Expression<Func<string>> databaseName, Expression<Func<string>> collectionName, Expression<Func<string>> leaseCollectionName = null, Expression<Func<bool>> createLeaseCollectionIfNotExists = null, Expression<Func<int>> leasesCollectionThroughput = null, string triggerName = null)
        {
            var parameters = new JObject();
            parameters["databaseName"] = ExpressionConverter.ConvertO(databaseName);
            parameters["collectionName"] = ExpressionConverter.ConvertO(collectionName);
            if (leaseCollectionName != null)
            {
                parameters["leaseCollectionName"] = ExpressionConverter.ConvertO(leaseCollectionName);
            }

            if (createLeaseCollectionIfNotExists != null)
            {
                parameters["createLeaseCollectionIfNotExists"] = ExpressionConverter.ConvertO(createLeaseCollectionIfNotExists);
            }

            if (leasesCollectionThroughput != null)
            {
                parameters["leasesCollectionThroughput"] = ExpressionConverter.ConvertO(leasesCollectionThroughput);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "whenADocumentIsCreatedOrModified", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(input, triggerName);
        }
    }

    public class BulkCreateOrUpdateDocumentOutputItem
    {
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("requestCharge")]
        public string RequestCharge { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }

    public class CreateOrUpdateDocumentOutput
    {
        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("requestCharge")]
        public string RequestCharge { get; set; }

        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }

    public class DeleteDocumentOutput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("requestCharge")]
        public string RequestCharge { get; set; }

        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }

    public class QueryDocumentsOutput
    {
        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("requestCharge")]
        public string RequestCharge { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("items")]
        public string[] Items { get; set; }

        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }

    public class ReadDocumentOutput
    {
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("requestCharge")]
        public string RequestCharge { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }

    public class PatchItemOutput
    {
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("requestCharge")]
        public string RequestCharge { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("sessionToken")]
        public string SessionToken { get; set; }
    }

    public class PatchItemPatchOperationsTypeItem
    {
        [JsonProperty("type")]
        public PatchItemPatchOperationsTypeItemTypeType Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum PatchItemPatchOperationsTypeItemTypeType
    {
        Add,
        Remove,
        Replace,
        Set,
        Increment,
        Move
    }

    public class WhenADocumentIsCreatedOrModifiedOutputItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_ts")]
        public string Ts { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureCosmosDB;

    public partial class WorkflowServiceProviderActions
    {
        public AzureCosmosDBActions AzureCosmosDB(string connectionId) => new AzureCosmosDBActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AzureCosmosDBTriggers AzureCosmosDB(string connectionId) => new AzureCosmosDBTriggers(connectionId);
    }
}