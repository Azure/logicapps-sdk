//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureCosmosDB
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureCosmosDBActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<BulkCreateOrUpdateDocumentOutputItem[]> BulkCreateOrUpdateDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<object>> items, Expression<Func<bool>> isUpsert = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseId"] = CSharpExpressionConverter.ConvertToken(databaseId);
            serviceProviderParameters["containerId"] = CSharpExpressionConverter.ConvertToken(containerId);
            serviceProviderParameters["items"] = CSharpExpressionConverter.ConvertToken(items);
            if (isUpsert != null)
            {
                serviceProviderParameters["isUpsert"] = CSharpExpressionConverter.ConvertToken(isUpsert);
            }
            else
            {
                serviceProviderParameters["isUpsert"] = true;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "BulkCreateOrUpdateDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BulkCreateOrUpdateDocumentOutputItem[]>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<CreateOrUpdateDocumentOutput> CreateOrUpdateDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> item, Expression<Func<string>> partitionKey = null, Expression<Func<bool>> isUpsert = null, Expression<Func<string>> sessionToken = null, Expression<Func<string>> etag = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseId"] = CSharpExpressionConverter.ConvertToken(databaseId);
            serviceProviderParameters["containerId"] = CSharpExpressionConverter.ConvertToken(containerId);
            serviceProviderParameters["item"] = CSharpExpressionConverter.ConvertToken(item);
            if (partitionKey != null)
            {
                serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            }

            if (isUpsert != null)
            {
                serviceProviderParameters["isUpsert"] = CSharpExpressionConverter.ConvertToken(isUpsert);
            }
            else
            {
                serviceProviderParameters["isUpsert"] = true;
            }

            if (sessionToken != null)
            {
                serviceProviderParameters["sessionToken"] = CSharpExpressionConverter.ConvertToken(sessionToken);
            }

            if (etag != null)
            {
                serviceProviderParameters["etag"] = CSharpExpressionConverter.ConvertToken(etag);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "CreateOrUpdateDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateOrUpdateDocumentOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<DeleteDocumentOutput> DeleteDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<string>> sessionToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseId"] = CSharpExpressionConverter.ConvertToken(databaseId);
            serviceProviderParameters["containerId"] = CSharpExpressionConverter.ConvertToken(containerId);
            serviceProviderParameters["itemId"] = CSharpExpressionConverter.ConvertToken(itemId);
            serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            if (sessionToken != null)
            {
                serviceProviderParameters["sessionToken"] = CSharpExpressionConverter.ConvertToken(sessionToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "DeleteDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<DeleteDocumentOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<QueryDocumentsOutput> QueryDocuments(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> queryText, Expression<Func<string>> partitionKey = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> maxItemCount = null, Expression<Func<string>> sessionToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseId"] = CSharpExpressionConverter.ConvertToken(databaseId);
            serviceProviderParameters["containerId"] = CSharpExpressionConverter.ConvertToken(containerId);
            serviceProviderParameters["queryText"] = CSharpExpressionConverter.ConvertToken(queryText);
            if (partitionKey != null)
            {
                serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            }

            if (continuationToken != null)
            {
                serviceProviderParameters["continuationToken"] = CSharpExpressionConverter.ConvertToken(continuationToken);
            }

            if (maxItemCount != null)
            {
                serviceProviderParameters["maxItemCount"] = CSharpExpressionConverter.ConvertToken(maxItemCount);
            }

            if (sessionToken != null)
            {
                serviceProviderParameters["sessionToken"] = CSharpExpressionConverter.ConvertToken(sessionToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "QueryDocuments", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<QueryDocumentsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<ReadDocumentOutput> ReadDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<string>> sessionToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseId"] = CSharpExpressionConverter.ConvertToken(databaseId);
            serviceProviderParameters["containerId"] = CSharpExpressionConverter.ConvertToken(containerId);
            serviceProviderParameters["itemId"] = CSharpExpressionConverter.ConvertToken(itemId);
            serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            if (sessionToken != null)
            {
                serviceProviderParameters["sessionToken"] = CSharpExpressionConverter.ConvertToken(sessionToken);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "ReadDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ReadDocumentOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<PatchItemOutput> PatchItem(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<PatchItemInputPatchOperationsTypeItem[]>> patchOperations, Expression<Func<string>> sessionToken = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseId"] = CSharpExpressionConverter.ConvertToken(databaseId);
            serviceProviderParameters["containerId"] = CSharpExpressionConverter.ConvertToken(containerId);
            serviceProviderParameters["itemId"] = CSharpExpressionConverter.ConvertToken(itemId);
            serviceProviderParameters["partitionKey"] = CSharpExpressionConverter.ConvertToken(partitionKey);
            if (sessionToken != null)
            {
                serviceProviderParameters["sessionToken"] = CSharpExpressionConverter.ConvertToken(sessionToken);
            }

            serviceProviderParameters["patchOperations"] = CSharpExpressionConverter.ConvertToken(patchOperations);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "PatchItem", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<PatchItemOutput>(serviceProviderInput);
        }
    }

    public class AzureCosmosDBTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]> WhenADocumentIsCreatedOrModified(Expression<Func<string>> databaseName, Expression<Func<string>> collectionName, Expression<Func<string>> leaseCollectionName = null, Expression<Func<bool>> createLeaseCollectionIfNotExists = null, Expression<Func<int>> leasesCollectionThroughput = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["databaseName"] = CSharpExpressionConverter.ConvertToken(databaseName);
            serviceProviderParameters["collectionName"] = CSharpExpressionConverter.ConvertToken(collectionName);
            if (leaseCollectionName != null)
            {
                serviceProviderParameters["leaseCollectionName"] = CSharpExpressionConverter.ConvertToken(leaseCollectionName);
            }
            else
            {
                serviceProviderParameters["leaseCollectionName"] = "leases";
            }

            if (createLeaseCollectionIfNotExists != null)
            {
                serviceProviderParameters["createLeaseCollectionIfNotExists"] = CSharpExpressionConverter.ConvertToken(createLeaseCollectionIfNotExists);
            }
            else
            {
                serviceProviderParameters["createLeaseCollectionIfNotExists"] = false;
            }

            if (leasesCollectionThroughput != null)
            {
                serviceProviderParameters["leasesCollectionThroughput"] = CSharpExpressionConverter.ConvertToken(leasesCollectionThroughput);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "whenADocumentIsCreatedOrModified", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(serviceProviderInput);
        }
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
        public JToken[] Items { get; set; }

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

    public class PatchItemInputPatchOperationsTypeItem
    {
        [JsonProperty("type")]
        public PatchItemInputPatchOperationsTypeItemTypeType? Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PatchItemInputPatchOperationsTypeItemTypeType
    {
        Add,
        Remove,
        Replace,
        Set,
        Increment,
        Move
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