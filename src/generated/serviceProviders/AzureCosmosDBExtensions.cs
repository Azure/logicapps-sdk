//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureCosmosDB
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AzureCosmosDBActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<BulkCreateOrUpdateDocumentOutputItem[]> BulkCreateOrUpdateDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<object>> items, Expression<Func<bool>> isUpsert = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: true);
            var __workflow_isUpsert = WorkflowExpression.Compile(isUpsert, nameof(isUpsert), required: false);
            return new DeferredBodyAction<BulkCreateOrUpdateDocumentOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(__workflow_databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(__workflow_containerId);
                serviceProviderParameters["items"] = ExpressionConverter.ConvertO(__workflow_items);
                if (__workflow_isUpsert != null)
                {
                    serviceProviderParameters["isUpsert"] = ExpressionConverter.ConvertO(__workflow_isUpsert);
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
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<CreateOrUpdateDocumentOutput> CreateOrUpdateDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> item, Expression<Func<string>> partitionKey = null, Expression<Func<bool>> isUpsert = null, Expression<Func<string>> sessionToken = null, Expression<Func<string>> etag = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: false);
            var __workflow_isUpsert = WorkflowExpression.Compile(isUpsert, nameof(isUpsert), required: false);
            var __workflow_sessionToken = WorkflowExpression.Compile(sessionToken, nameof(sessionToken), required: false);
            var __workflow_etag = WorkflowExpression.Compile(etag, nameof(etag), required: false);
            return new DeferredBodyAction<CreateOrUpdateDocumentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(__workflow_databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(__workflow_containerId);
                serviceProviderParameters["item"] = ExpressionConverter.ConvertO(__workflow_item);
                if (__workflow_partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                }

                if (__workflow_isUpsert != null)
                {
                    serviceProviderParameters["isUpsert"] = ExpressionConverter.ConvertO(__workflow_isUpsert);
                }
                else
                {
                    serviceProviderParameters["isUpsert"] = true;
                }

                if (__workflow_sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(__workflow_sessionToken);
                }

                if (__workflow_etag != null)
                {
                    serviceProviderParameters["etag"] = ExpressionConverter.ConvertO(__workflow_etag);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "CreateOrUpdateDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CreateOrUpdateDocumentOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<DeleteDocumentOutput> DeleteDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<string>> sessionToken = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_sessionToken = WorkflowExpression.Compile(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<DeleteDocumentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(__workflow_databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(__workflow_containerId);
                serviceProviderParameters["itemId"] = ExpressionConverter.ConvertO(__workflow_itemId);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                if (__workflow_sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(__workflow_sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "DeleteDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<DeleteDocumentOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<QueryDocumentsOutput> QueryDocuments(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> queryText, Expression<Func<string>> partitionKey = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> maxItemCount = null, Expression<Func<string>> sessionToken = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_queryText = WorkflowExpression.Compile(queryText, nameof(queryText), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_maxItemCount = WorkflowExpression.Compile(maxItemCount, nameof(maxItemCount), required: false);
            var __workflow_sessionToken = WorkflowExpression.Compile(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<QueryDocumentsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(__workflow_databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(__workflow_containerId);
                serviceProviderParameters["queryText"] = ExpressionConverter.ConvertO(__workflow_queryText);
                if (__workflow_partitionKey != null)
                {
                    serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                }

                if (__workflow_continuationToken != null)
                {
                    serviceProviderParameters["continuationToken"] = ExpressionConverter.ConvertO(__workflow_continuationToken);
                }

                if (__workflow_maxItemCount != null)
                {
                    serviceProviderParameters["maxItemCount"] = ExpressionConverter.ConvertO(__workflow_maxItemCount);
                }

                if (__workflow_sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(__workflow_sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "QueryDocuments", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<QueryDocumentsOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<ReadDocumentOutput> ReadDocument(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<string>> sessionToken = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_sessionToken = WorkflowExpression.Compile(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<ReadDocumentOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(__workflow_databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(__workflow_containerId);
                serviceProviderParameters["itemId"] = ExpressionConverter.ConvertO(__workflow_itemId);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                if (__workflow_sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(__workflow_sessionToken);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "ReadDocument", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ReadDocumentOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "AzureCosmosDB")]
        public IBodyWorkflowAction<PatchItemOutput> PatchItem(Expression<Func<string>> databaseId, Expression<Func<string>> containerId, Expression<Func<string>> itemId, Expression<Func<string>> partitionKey, Expression<Func<PatchItemInputPatchOperationsTypeItem[]>> patchOperations, Expression<Func<string>> sessionToken = null)
        {
            var __workflow_databaseId = WorkflowExpression.Compile(databaseId, nameof(databaseId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_partitionKey = WorkflowExpression.Compile(partitionKey, nameof(partitionKey), required: true);
            var __workflow_patchOperations = WorkflowExpression.Compile(patchOperations, nameof(patchOperations), required: true);
            var __workflow_sessionToken = WorkflowExpression.Compile(sessionToken, nameof(sessionToken), required: false);
            return new DeferredBodyAction<PatchItemOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseId"] = ExpressionConverter.ConvertO(__workflow_databaseId);
                serviceProviderParameters["containerId"] = ExpressionConverter.ConvertO(__workflow_containerId);
                serviceProviderParameters["itemId"] = ExpressionConverter.ConvertO(__workflow_itemId);
                serviceProviderParameters["partitionKey"] = ExpressionConverter.ConvertO(__workflow_partitionKey);
                if (__workflow_sessionToken != null)
                {
                    serviceProviderParameters["sessionToken"] = ExpressionConverter.ConvertO(__workflow_sessionToken);
                }

                serviceProviderParameters["patchOperations"] = ExpressionConverter.ConvertO(__workflow_patchOperations);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "PatchItem", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<PatchItemOutput>(serviceProviderInput);
            }, WorkflowActionSettingProfile.RetryPolicy | WorkflowActionSettingProfile.TrackedProperties | WorkflowActionSettingProfile.SecureInputs | WorkflowActionSettingProfile.SecureOutputs);
        }
    }

    public class AzureCosmosDBTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]> WhenADocumentIsCreatedOrModified(Expression<Func<string>> databaseName, Expression<Func<string>> collectionName, Expression<Func<string>> leaseCollectionName = null, Expression<Func<bool>> createLeaseCollectionIfNotExists = null, Expression<Func<int>> leasesCollectionThroughput = null)
        {
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_collectionName = WorkflowExpression.Compile(collectionName, nameof(collectionName), required: true);
            var __workflow_leaseCollectionName = WorkflowExpression.Compile(leaseCollectionName, nameof(leaseCollectionName), required: false);
            var __workflow_createLeaseCollectionIfNotExists = WorkflowExpression.Compile(createLeaseCollectionIfNotExists, nameof(createLeaseCollectionIfNotExists), required: false);
            var __workflow_leasesCollectionThroughput = WorkflowExpression.Compile(leasesCollectionThroughput, nameof(leasesCollectionThroughput), required: false);
            return new DeferredBodyTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["databaseName"] = ExpressionConverter.ConvertO(__workflow_databaseName);
                serviceProviderParameters["collectionName"] = ExpressionConverter.ConvertO(__workflow_collectionName);
                if (__workflow_leaseCollectionName != null)
                {
                    serviceProviderParameters["leaseCollectionName"] = ExpressionConverter.ConvertO(__workflow_leaseCollectionName);
                }
                else
                {
                    serviceProviderParameters["leaseCollectionName"] = "leases";
                }

                if (__workflow_createLeaseCollectionIfNotExists != null)
                {
                    serviceProviderParameters["createLeaseCollectionIfNotExists"] = ExpressionConverter.ConvertO(__workflow_createLeaseCollectionIfNotExists);
                }
                else
                {
                    serviceProviderParameters["createLeaseCollectionIfNotExists"] = false;
                }

                if (__workflow_leasesCollectionThroughput != null)
                {
                    serviceProviderParameters["leasesCollectionThroughput"] = ExpressionConverter.ConvertO(__workflow_leasesCollectionThroughput);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/AzureCosmosDB", operationId: "whenADocumentIsCreatedOrModified", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderTrigger<WhenADocumentIsCreatedOrModifiedOutputItem[]>(serviceProviderInput);
            }, WorkflowTriggerSettingProfile.SecureInputs | WorkflowTriggerSettingProfile.SecureOutputs);
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