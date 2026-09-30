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
        public IBodyWorkflowAction<BulkCreateOrUpdateDocumentOutputItem[]> BulkCreateOrUpdateDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<object> items, [WorkflowExpression] Func<bool> isUpsert = null)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(items, nameof(items), required: true);
            SourceExpression.Validate(isUpsert, nameof(isUpsert), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = SourceExpressionConverter.ConvertToken(databaseId);
                serviceProviderParameters["containerId"] = SourceExpressionConverter.ConvertToken(containerId);
                serviceProviderParameters["items"] = SourceExpressionConverter.ConvertToken(items);
                if (isUpsert != null)
                {
                    serviceProviderParameters["isUpsert"] = SourceExpressionConverter.ConvertToken(isUpsert);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<BulkCreateOrUpdateDocumentOutputItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<CreateOrUpdateDocumentOutput> CreateOrUpdateDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> item, [WorkflowExpression] Func<string> partitionKey = null, [WorkflowExpression] Func<bool> isUpsert = null, [WorkflowExpression] Func<string> sessionToken = null, [WorkflowExpression] Func<string> etag = null)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(item, nameof(item), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            SourceExpression.Validate(isUpsert, nameof(isUpsert), required: false);
            SourceExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            SourceExpression.Validate(etag, nameof(etag), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = SourceExpressionConverter.ConvertToken(databaseId);
                serviceProviderParameters["containerId"] = SourceExpressionConverter.ConvertToken(containerId);
                serviceProviderParameters["item"] = SourceExpressionConverter.ConvertToken(item);
                if (partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                }

                if (isUpsert != null)
                {
                    serviceProviderParameters["isUpsert"] = SourceExpressionConverter.ConvertToken(isUpsert);
                }
                else
                {
                    serviceProviderParameters["isUpsert"] = true;
                }

                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = SourceExpressionConverter.ConvertToken(sessionToken);
                }

                if (etag != null)
                {
                    serviceProviderParameters["etag"] = SourceExpressionConverter.ConvertToken(etag);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "CreateOrUpdateDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateOrUpdateDocumentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<DeleteDocumentOutput> DeleteDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> sessionToken = null)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = SourceExpressionConverter.ConvertToken(databaseId);
                serviceProviderParameters["containerId"] = SourceExpressionConverter.ConvertToken(containerId);
                serviceProviderParameters["itemId"] = SourceExpressionConverter.ConvertToken(itemId);
                serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = SourceExpressionConverter.ConvertToken(sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "DeleteDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<DeleteDocumentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<ReadDocumentOutput> ReadDocument([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<string> sessionToken = null)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = SourceExpressionConverter.ConvertToken(databaseId);
                serviceProviderParameters["containerId"] = SourceExpressionConverter.ConvertToken(containerId);
                serviceProviderParameters["itemId"] = SourceExpressionConverter.ConvertToken(itemId);
                serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = SourceExpressionConverter.ConvertToken(sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "ReadDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ReadDocumentOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<QueryDocumentsOutput> QueryDocuments([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> queryText, [WorkflowExpression] Func<string> partitionKey = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> maxItemCount = null, [WorkflowExpression] Func<string> sessionToken = null)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(queryText, nameof(queryText), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: false);
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            SourceExpression.Validate(maxItemCount, nameof(maxItemCount), required: false);
            SourceExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = SourceExpressionConverter.ConvertToken(databaseId);
                serviceProviderParameters["containerId"] = SourceExpressionConverter.ConvertToken(containerId);
                serviceProviderParameters["queryText"] = SourceExpressionConverter.ConvertToken(queryText);
                if (partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                }

                if (continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = SourceExpressionConverter.ConvertToken(continuationToken);
                }

                if (maxItemCount != null)
                {
                    serviceProviderParameters["maxItemCount"] = SourceExpressionConverter.ConvertToken(maxItemCount);
                }

                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = SourceExpressionConverter.ConvertToken(sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "QueryDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<QueryDocumentsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<PatchItemOutput> PatchItem([WorkflowExpression] Func<string> databaseId, [WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> itemId, [WorkflowExpression] Func<string> partitionKey, [WorkflowExpression] Func<PatchItemInputPatchOperationsTypeItem[]> patchOperations, [WorkflowExpression] Func<string> sessionToken = null)
        {
            SourceExpression.Validate(databaseId, nameof(databaseId), required: true);
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(partitionKey, nameof(partitionKey), required: true);
            SourceExpression.Validate(patchOperations, nameof(patchOperations), required: true);
            SourceExpression.Validate(sessionToken, nameof(sessionToken), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = SourceExpressionConverter.ConvertToken(databaseId);
                serviceProviderParameters["containerId"] = SourceExpressionConverter.ConvertToken(containerId);
                serviceProviderParameters["itemId"] = SourceExpressionConverter.ConvertToken(itemId);
                serviceProviderParameters["partitionKey"] = SourceExpressionConverter.ConvertToken(partitionKey);
                if (sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = SourceExpressionConverter.ConvertToken(sessionToken);
                }

                serviceProviderParameters["patchOperations"] = SourceExpressionConverter.ConvertToken(patchOperations);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "PatchItem", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<PatchItemOutput>(BuildSourceInput);
        }
    }

    public class AzureCosmosDBTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]> WhenADocumentIsCreatedOrModified([WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> collectionName, [WorkflowExpression] Func<string> leaseCollectionName = null, [WorkflowExpression] Func<bool> createLeaseCollectionIfNotExists = null, [WorkflowExpression] Func<int> leasesCollectionThroughput = null)
        {
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(collectionName, nameof(collectionName), required: true);
            SourceExpression.Validate(leaseCollectionName, nameof(leaseCollectionName), required: false);
            SourceExpression.Validate(createLeaseCollectionIfNotExists, nameof(createLeaseCollectionIfNotExists), required: false);
            SourceExpression.Validate(leasesCollectionThroughput, nameof(leasesCollectionThroughput), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseName"] = SourceExpressionConverter.ConvertToken(databaseName);
                serviceProviderParameters["collectionName"] = SourceExpressionConverter.ConvertToken(collectionName);
                if (leaseCollectionName != null)
                {
                    serviceProviderParameters["leaseCollectionName"] = SourceExpressionConverter.ConvertToken(leaseCollectionName);
                }
                else
                {
                    serviceProviderParameters["leaseCollectionName"] = "leases";
                }

                if (createLeaseCollectionIfNotExists != null)
                {
                    serviceProviderParameters["createLeaseCollectionIfNotExists"] = SourceExpressionConverter.ConvertToken(createLeaseCollectionIfNotExists);
                }
                else
                {
                    serviceProviderParameters["createLeaseCollectionIfNotExists"] = false;
                }

                if (leasesCollectionThroughput != null)
                {
                    serviceProviderParameters["leasesCollectionThroughput"] = SourceExpressionConverter.ConvertToken(leasesCollectionThroughput);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "whenADocumentIsCreatedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(BuildSourceInput);
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