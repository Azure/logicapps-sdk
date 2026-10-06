//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureCosmosDB
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureCosmosDBActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [WorkflowExpressionFactory(nameof(__BuildBulkCreateOrUpdateDocument))]
        public IBodyWorkflowAction<BulkCreateOrUpdateDocumentOutputItem[]> BulkCreateOrUpdateDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<object> items, [WorkflowExpression] Func<bool> isUpsert = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BulkCreateOrUpdateDocumentOutputItem[]> __BuildBulkCreateOrUpdateDocument(WorkflowExpression<string> databaseId, WorkflowExpression<string> containerId, WorkflowExpression<object> items, WorkflowExpression<bool> isUpsert = null)
        {
            WorkflowExpression.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowExpression.Validate(containerId, nameof(containerId), required: true);
            WorkflowExpression.Validate(items, nameof(items), required: true);
            WorkflowExpression.Validate(isUpsert, nameof(isUpsert), required: false);
            return new DeferredBodyAction<BulkCreateOrUpdateDocumentOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(containerId);
                serviceProviderParameters["items"] = ExpressionConverter.ConvertO(items);
                if (isUpsert != null)
                {
                    serviceProviderParameters["isUpsert"] = ExpressionConverter.ConvertO(isUpsert);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOrUpdateDocument))]
        public IBodyWorkflowAction<CreateOrUpdateDocumentOutput> CreateOrUpdateDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> item, [WorkflowExpression] Func<string> partitionKey = null, [WorkflowExpression] Func<bool> isUpsert = null, [WorkflowExpression] Func<string> sessionToken = null, [WorkflowExpression] Func<string> etag = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOrUpdateDocumentOutput> __BuildCreateOrUpdateDocument(WorkflowExpression<string> databaseId, WorkflowExpression<string> containerId, WorkflowExpression<string> item, WorkflowExpression<string> partitionKey = null, WorkflowExpression<bool> isUpsert = null, WorkflowExpression<string> sessionToken = null, WorkflowExpression<string> etag = null)
        {
            WorkflowExpression.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowExpression.Validate(containerId, nameof(containerId), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            WorkflowExpression.Validate(isUpsert, nameof(isUpsert), required: false);
            WorkflowExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            WorkflowExpression.Validate(etag, nameof(etag), required: false);
            return new DeferredBodyAction<CreateOrUpdateDocumentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(containerId);
                serviceProviderParameters["item"] = ExpressionConverter.ConvertO(item);
                if (partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
                }

                if (isUpsert != null)
                {
                    serviceProviderParameters["isUpsert"] = ExpressionConverter.ConvertO(isUpsert);
                }
                else
                {
                    serviceProviderParameters["isUpsert"] = true;
                }

                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
                }

                if (etag != null)
                {
                    serviceProviderParameters["etag"] = ExpressionConverter.ConvertO(etag);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "CreateOrUpdateDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateOrUpdateDocumentOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IBodyWorkflowAction<DeleteDocumentOutput> DeleteDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> sessionToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteDocumentOutput> __BuildDeleteDocument(WorkflowExpression<string> databaseId, WorkflowExpression<string> containerId, WorkflowExpression<string> itemId, WorkflowExpression<string> partitionKey, WorkflowExpression<string> sessionToken = null)
        {
            WorkflowExpression.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowExpression.Validate(containerId, nameof(containerId), required: true);
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<DeleteDocumentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(containerId);
                serviceProviderParameters["itemId"] = ExpressionConverter.ConvertO(itemId);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "DeleteDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteDocumentOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [WorkflowExpressionFactory(nameof(__BuildQueryDocuments))]
        public IBodyWorkflowAction<QueryDocumentsOutput> QueryDocuments([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> queryText, [WorkflowExpression] Func<string> partitionKey = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> maxItemCount = null, [WorkflowExpression] Func<string> sessionToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryDocumentsOutput> __BuildQueryDocuments(WorkflowExpression<string> databaseId, WorkflowExpression<string> containerId, WorkflowExpression<string> queryText, WorkflowExpression<string> partitionKey = null, WorkflowExpression<string> continuationToken = null, WorkflowExpression<string> maxItemCount = null, WorkflowExpression<string> sessionToken = null)
        {
            WorkflowExpression.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowExpression.Validate(containerId, nameof(containerId), required: true);
            WorkflowExpression.Validate(queryText, nameof(queryText), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowExpression.Validate(maxItemCount, nameof(maxItemCount), required: false);
            WorkflowExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<QueryDocumentsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(containerId);
                serviceProviderParameters["queryText"] = ExpressionConverter.ConvertO(queryText);
                if (partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
                }

                if (continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(continuationToken);
                }

                if (maxItemCount != null)
                {
                    serviceProviderParameters["maxItemCount"] = ExpressionConverter.ConvertO(maxItemCount);
                }

                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "QueryDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<QueryDocumentsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [WorkflowExpressionFactory(nameof(__BuildReadDocument))]
        public IBodyWorkflowAction<ReadDocumentOutput> ReadDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> sessionToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadDocumentOutput> __BuildReadDocument(WorkflowExpression<string> databaseId, WorkflowExpression<string> containerId, WorkflowExpression<string> itemId, WorkflowExpression<string> partitionKey, WorkflowExpression<string> sessionToken = null)
        {
            WorkflowExpression.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowExpression.Validate(containerId, nameof(containerId), required: true);
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<ReadDocumentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(containerId);
                serviceProviderParameters["itemId"] = ExpressionConverter.ConvertO(itemId);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "ReadDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReadDocumentOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<PatchItemOutput> PatchItem([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<PatchItemInputPatchOperationsTypeItem[]> patchOperations, [WorkflowExpression] Func<string> sessionToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchItemOutput> __BuildPatchItem(WorkflowExpression<string> databaseId, WorkflowExpression<string> containerId, WorkflowExpression<string> itemId, WorkflowExpression<string> partitionKey, WorkflowExpression<PatchItemInputPatchOperationsTypeItem[]> patchOperations, WorkflowExpression<string> sessionToken = null)
        {
            WorkflowExpression.Validate(databaseId, nameof(databaseId), required: true);
            WorkflowExpression.Validate(containerId, nameof(containerId), required: true);
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            WorkflowExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            WorkflowExpression.Validate(patchOperations, nameof(patchOperations), required: true);
            WorkflowExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<PatchItemOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(containerId);
                serviceProviderParameters["itemId"] = ExpressionConverter.ConvertO(itemId);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(partitionKey);
                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(sessionToken);
                }

                serviceProviderParameters["patchOperations"] = ExpressionConverter.ConvertO(patchOperations);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "PatchItem", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<PatchItemOutput>(serviceProviderInput);
            });
        }
    }

    public class AzureCosmosDBTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWhenADocumentIsCreatedOrModified))]
        public IBodyWorkflowTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]> WhenADocumentIsCreatedOrModified([WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> collectionName, [WorkflowExpression] Func<string> leaseCollectionName = null, [WorkflowExpression] Func<bool> createLeaseCollectionIfNotExists = null, [WorkflowExpression] Func<int> leasesCollectionThroughput = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]> __BuildWhenADocumentIsCreatedOrModified(WorkflowExpression<string> databaseName, WorkflowExpression<string> collectionName, WorkflowExpression<string> leaseCollectionName = null, WorkflowExpression<bool> createLeaseCollectionIfNotExists = null, WorkflowExpression<int> leasesCollectionThroughput = null)
        {
            WorkflowExpression.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowExpression.Validate(collectionName, nameof(collectionName), required: true);
            WorkflowExpression.Validate(leaseCollectionName, nameof(leaseCollectionName), required: false);
            WorkflowExpression.Validate(createLeaseCollectionIfNotExists, nameof(createLeaseCollectionIfNotExists), required: false);
            WorkflowExpression.Validate(leasesCollectionThroughput, nameof(leasesCollectionThroughput), required: false);
            return new DeferredBodyTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseName"] = ExpressionConverter.ConvertO(databaseName);
                serviceProviderParameters["collectionName"] = ExpressionConverter.ConvertO(collectionName);
                if (leaseCollectionName != null)
                {
                    serviceProviderParameters["leaseCollectionName"] = ExpressionConverter.ConvertO(leaseCollectionName);
                }
                else
                {
                    serviceProviderParameters["leaseCollectionName"] = "leases";
                }

                if (createLeaseCollectionIfNotExists != null)
                {
                    serviceProviderParameters["createLeaseCollectionIfNotExists"] = ExpressionConverter.ConvertO(createLeaseCollectionIfNotExists);
                }
                else
                {
                    serviceProviderParameters["createLeaseCollectionIfNotExists"] = false;
                }

                if (leasesCollectionThroughput != null)
                {
                    serviceProviderParameters["leasesCollectionThroughput"] = ExpressionConverter.ConvertO(leasesCollectionThroughput);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "whenADocumentIsCreatedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(serviceProviderInput);
            });
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