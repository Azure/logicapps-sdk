//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pineconeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PineconeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<IndexStatsPostResponse> IndexStats()
        {
            var apiCallPath = "/describe_index_stats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IndexStatsPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<VectorQueryPostResponse> VectorQuery(Expression<Func<bool>> bodyincludeValues = null, Expression<Func<bool>> bodyincludeMetadata = null, Expression<Func<int[]>> bodysparseVectorindices = null, Expression<Func<int[]>> bodysparseVectorvalues = null, Expression<Func<string>> bodyNamespace = null, Expression<Func<int>> bodytopK = null, Expression<Func<int[]>> bodyvector = null, Expression<Func<string>> bodyid = null)
        {
            var __workflow_bodyincludeValues = WorkflowExpression.Compile(bodyincludeValues, nameof(bodyincludeValues), required: false);
            var __workflow_bodyincludeMetadata = WorkflowExpression.Compile(bodyincludeMetadata, nameof(bodyincludeMetadata), required: false);
            var __workflow_bodysparseVectorindices = WorkflowExpression.Compile(bodysparseVectorindices, nameof(bodysparseVectorindices), required: false);
            var __workflow_bodysparseVectorvalues = WorkflowExpression.Compile(bodysparseVectorvalues, nameof(bodysparseVectorvalues), required: false);
            var __workflow_bodyNamespace = WorkflowExpression.Compile(bodyNamespace, nameof(bodyNamespace), required: false);
            var __workflow_bodytopK = WorkflowExpression.Compile(bodytopK, nameof(bodytopK), required: false);
            var __workflow_bodyvector = WorkflowExpression.Compile(bodyvector, nameof(bodyvector), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            return new DeferredBodyAction<VectorQueryPostResponse>(() =>
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyincludeValues != null)
                {
                    body["includeValues"] = ExpressionConverter.ConvertO(__workflow_bodyincludeValues);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMetadata != null)
                {
                    body["includeMetadata"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMetadata);
                    bodypropCount++;
                }

                var sparseVectorObject = new JObject();
                var sparseVectorObjectpropCount = 0;
                if (__workflow_bodysparseVectorindices != null)
                {
                    sparseVectorObject["indices"] = ExpressionConverter.ConvertO(__workflow_bodysparseVectorindices);
                    sparseVectorObjectpropCount++;
                }

                if (__workflow_bodysparseVectorvalues != null)
                {
                    sparseVectorObject["values"] = ExpressionConverter.ConvertO(__workflow_bodysparseVectorvalues);
                    sparseVectorObjectpropCount++;
                }

                if (sparseVectorObjectpropCount > 0)
                {
                    body["sparseVector"] = sparseVectorObject;
                    bodypropCount++;
                }

                if (__workflow_bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(__workflow_bodyNamespace);
                    bodypropCount++;
                }

                if (__workflow_bodytopK != null)
                {
                    body["topK"] = ExpressionConverter.ConvertO(__workflow_bodytopK);
                    bodypropCount++;
                }

                if (__workflow_bodyvector != null)
                {
                    body["vector"] = ExpressionConverter.ConvertO(__workflow_bodyvector);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<VectorQueryPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> VectorDelete(Expression<Func<bool>> bodydeleteAll = null, Expression<Func<string[]>> bodyids = null, Expression<Func<string>> bodyNamespace = null)
        {
            var __workflow_bodydeleteAll = WorkflowExpression.Compile(bodydeleteAll, nameof(bodydeleteAll), required: false);
            var __workflow_bodyids = WorkflowExpression.Compile(bodyids, nameof(bodyids), required: false);
            var __workflow_bodyNamespace = WorkflowExpression.Compile(bodyNamespace, nameof(bodyNamespace), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/vectors/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydeleteAll != null)
                {
                    body["deleteAll"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAll);
                    bodypropCount++;
                }

                if (__workflow_bodyids != null)
                {
                    body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyids);
                    bodypropCount++;
                }

                if (__workflow_bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(__workflow_bodyNamespace);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<VectorsGetResponse> VectorsGet(Expression<Func<string>> ids, Expression<Func<string>> @namespace = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            var __workflow_namespace = WorkflowExpression.Compile(@namespace, nameof(@namespace), required: false);
            return new DeferredBodyAction<VectorsGetResponse>(() =>
            {
                var apiCallPath = "/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_namespace != null)
                    callPayload.Queries["namespace"] = ExpressionConverter.Convert(__workflow_namespace);
                return new ApiConnectionAction<VectorsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> VectorUpdate(Expression<Func<string>> bodyid, Expression<Func<double[]>> bodyvalues = null, Expression<Func<int[]>> bodysparseValuesindices = null, Expression<Func<double[]>> bodysparseValuesvalues = null, Expression<Func<string>> bodyNamespace = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyvalues = WorkflowExpression.Compile(bodyvalues, nameof(bodyvalues), required: false);
            var __workflow_bodysparseValuesindices = WorkflowExpression.Compile(bodysparseValuesindices, nameof(bodysparseValuesindices), required: false);
            var __workflow_bodysparseValuesvalues = WorkflowExpression.Compile(bodysparseValuesvalues, nameof(bodysparseValuesvalues), required: false);
            var __workflow_bodyNamespace = WorkflowExpression.Compile(bodyNamespace, nameof(bodyNamespace), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/vectors/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyvalues != null)
                {
                    body["values"] = ExpressionConverter.ConvertO(__workflow_bodyvalues);
                    bodypropCount++;
                }

                var sparseValuesObject = new JObject();
                var sparseValuesObjectpropCount = 0;
                if (__workflow_bodysparseValuesindices != null)
                {
                    sparseValuesObject["indices"] = ExpressionConverter.ConvertO(__workflow_bodysparseValuesindices);
                    sparseValuesObjectpropCount++;
                }

                if (__workflow_bodysparseValuesvalues != null)
                {
                    sparseValuesObject["values"] = ExpressionConverter.ConvertO(__workflow_bodysparseValuesvalues);
                    sparseValuesObjectpropCount++;
                }

                if (sparseValuesObjectpropCount > 0)
                {
                    body["sparseValues"] = sparseValuesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(__workflow_bodyNamespace);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<VectorUpsertPostResponse> VectorUpsert(Expression<Func<bodyvectorsInputItem[]>> bodyvectors = null, Expression<Func<string>> bodyNamespace = null)
        {
            var __workflow_bodyvectors = WorkflowExpression.Compile(bodyvectors, nameof(bodyvectors), required: false);
            var __workflow_bodyNamespace = WorkflowExpression.Compile(bodyNamespace, nameof(bodyNamespace), required: false);
            return new DeferredBodyAction<VectorUpsertPostResponse>(() =>
            {
                var apiCallPath = "/vectors/upsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyvectors != null)
                {
                    body["vectors"] = ExpressionConverter.ConvertO(__workflow_bodyvectors);
                    bodypropCount++;
                }

                if (__workflow_bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(__workflow_bodyNamespace);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<VectorUpsertPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string[]> CollectionsGet()
        {
            var apiCallPath = "/collections";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> CollectionCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodysource)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/collections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<CollectionGetResponse> CollectionGet(Expression<Func<string>> collectionName)
        {
            var __workflow_collectionName = WorkflowExpression.Compile(collectionName, nameof(collectionName), required: true);
            return new DeferredBodyAction<CollectionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/collections/{0}", __workflow_collectionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CollectionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> CollectionDelete(Expression<Func<string>> collectionName)
        {
            var __workflow_collectionName = WorkflowExpression.Compile(collectionName, nameof(collectionName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/collections/{0}", __workflow_collectionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string[]> IndexesGet()
        {
            var apiCallPath = "/databases";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> Index(Expression<Func<string>> bodyname, Expression<Func<int>> bodydimension, Expression<Func<string>> bodymetric = null, Expression<Func<int>> bodypods = null, Expression<Func<int>> bodyreplicas = null, Expression<Func<string>> bodypodType = null, Expression<Func<string>> bodysourceCollection = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydimension = WorkflowExpression.Compile(bodydimension, nameof(bodydimension), required: true);
            var __workflow_bodymetric = WorkflowExpression.Compile(bodymetric, nameof(bodymetric), required: false);
            var __workflow_bodypods = WorkflowExpression.Compile(bodypods, nameof(bodypods), required: false);
            var __workflow_bodyreplicas = WorkflowExpression.Compile(bodyreplicas, nameof(bodyreplicas), required: false);
            var __workflow_bodypodType = WorkflowExpression.Compile(bodypodType, nameof(bodypodType), required: false);
            var __workflow_bodysourceCollection = WorkflowExpression.Compile(bodysourceCollection, nameof(bodysourceCollection), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/databases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["dimension"] = ExpressionConverter.ConvertO(__workflow_bodydimension);
                if (__workflow_bodymetric != null)
                {
                    body["metric"] = ExpressionConverter.ConvertO(__workflow_bodymetric);
                    bodypropCount++;
                }

                if (__workflow_bodypods != null)
                {
                    body["pods"] = ExpressionConverter.ConvertO(__workflow_bodypods);
                    bodypropCount++;
                }

                if (__workflow_bodyreplicas != null)
                {
                    body["replicas"] = ExpressionConverter.ConvertO(__workflow_bodyreplicas);
                    bodypropCount++;
                }

                if (__workflow_bodypodType != null)
                {
                    body["pod_type"] = ExpressionConverter.ConvertO(__workflow_bodypodType);
                    bodypropCount++;
                }

                if (__workflow_bodysourceCollection != null)
                {
                    body["source_collection"] = ExpressionConverter.ConvertO(__workflow_bodysourceCollection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<IndexGetResponse> IndexGet(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<IndexGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/databases/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IndexGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> IndexDelete(Expression<Func<string>> indexName)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/databases/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> IndexPatch(Expression<Func<string>> indexName, Expression<Func<int>> bodyreplicas = null, Expression<Func<string>> bodypodType = null)
        {
            var __workflow_indexName = WorkflowExpression.Compile(indexName, nameof(indexName), required: true);
            var __workflow_bodyreplicas = WorkflowExpression.Compile(bodyreplicas, nameof(bodyreplicas), required: false);
            var __workflow_bodypodType = WorkflowExpression.Compile(bodypodType, nameof(bodypodType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/databases/{0}", __workflow_indexName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyreplicas != null)
                {
                    body["replicas"] = ExpressionConverter.ConvertO(__workflow_bodyreplicas);
                    bodypropCount++;
                }

                if (__workflow_bodypodType != null)
                {
                    body["pod_type"] = ExpressionConverter.ConvertO(__workflow_bodypodType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class PineconeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class IndexStatsPostResponse
    {
        [JsonProperty("namespaces")]
        public IndexStatsPostResponseNamespacesType Namespaces { get; set; }

        [JsonProperty("dimension")]
        public int Dimension { get; set; }

        [JsonProperty("index_fullness")]
        public double IndexFullness { get; set; }
    }

    public class IndexStatsPostResponseNamespacesType
    {
        [JsonProperty("namespace")]
        public IndexStatsPostResponseNamespacesTypeNamespaceType Namespace { get; set; }
    }

    public class IndexStatsPostResponseNamespacesTypeNamespaceType
    {
        [JsonProperty("vectorCount")]
        public int VectorCount { get; set; }
    }

    public class VectorQueryPostResponse
    {
        [JsonProperty("matches")]
        public VectorQueryPostResponseMatchesTypeItem[] Matches { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }

    public class VectorQueryPostResponseMatchesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("values")]
        public double[] Values { get; set; }

        [JsonProperty("sparseValues")]
        public VectorQueryPostResponseMatchesTypeItemSparseValuesType SparseValues { get; set; }

        [JsonProperty("metadata")]
        public VectorQueryPostResponseMatchesTypeItemMetadataType Metadata { get; set; }
    }

    public class VectorQueryPostResponseMatchesTypeItemSparseValuesType
    {
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        [JsonProperty("values")]
        public double[] Values { get; set; }
    }

    public class VectorQueryPostResponseMatchesTypeItemMetadataType
    {
        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class VectorsGetResponse
    {
        [JsonProperty("vectors")]
        public VectorsGetResponseVectorsType Vectors { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }

    public class VectorsGetResponseVectorsType
    {
        [JsonProperty("additionalProp")]
        public VectorsGetResponseVectorsTypeAdditionalPropType AdditionalProp { get; set; }
    }

    public class VectorsGetResponseVectorsTypeAdditionalPropType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("values")]
        public double[] Values { get; set; }

        [JsonProperty("sparseValues")]
        public VectorsGetResponseVectorsTypeAdditionalPropTypeSparseValuesType SparseValues { get; set; }

        [JsonProperty("metadata")]
        public VectorsGetResponseVectorsTypeAdditionalPropTypeMetadataType Metadata { get; set; }
    }

    public class VectorsGetResponseVectorsTypeAdditionalPropTypeSparseValuesType
    {
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        [JsonProperty("values")]
        public double[] Values { get; set; }
    }

    public class VectorsGetResponseVectorsTypeAdditionalPropTypeMetadataType
    {
        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class VectorUpsertPostResponse
    {
        [JsonProperty("upsertedCount")]
        public int UpsertedCount { get; set; }
    }

    public class bodyvectorsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("values")]
        public double[] Values { get; set; }

        [JsonProperty("sparseValues")]
        public bodyvectorsInputItemSparseValuesType SparseValues { get; set; }
    }

    public class bodyvectorsInputItemSparseValuesType
    {
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        [JsonProperty("values")]
        public double[] Values { get; set; }
    }

    public class CollectionGetResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IndexGetResponse
    {
        [JsonProperty("database")]
        public IndexGetResponseDatabaseType Database { get; set; }
    }

    public class IndexGetResponseDatabaseType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        [JsonProperty("metric")]
        public string Metric { get; set; }

        [JsonProperty("pods")]
        public int Pods { get; set; }

        [JsonProperty("replicas")]
        public int Replicas { get; set; }

        [JsonProperty("shards")]
        public int Shards { get; set; }

        [JsonProperty("pod_type")]
        public string PodType { get; set; }

        [JsonProperty("index_config")]
        public IndexGetResponseDatabaseTypeIndexConfigType IndexConfig { get; set; }

        [JsonProperty("status")]
        public IndexGetResponseDatabaseTypeStatusType Status { get; set; }
    }

    public class IndexGetResponseDatabaseTypeIndexConfigType
    {
        [JsonProperty("k_bits")]
        public int KBits { get; set; }

        [JsonProperty("hybrid")]
        public bool Hybrid { get; set; }
    }

    public class IndexGetResponseDatabaseTypeStatusType
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pineconeip;

    public partial class WorkflowManagedActions
    {
        public PineconeipActions Pineconeip(string connectionId) => new PineconeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PineconeipTriggers Pineconeip(string connectionId) => new PineconeipTriggers(connectionId);
    }
}
