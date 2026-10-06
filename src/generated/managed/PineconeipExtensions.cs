//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pineconeip
{
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
        [WorkflowExpressionFactory(nameof(__BuildVectorQuery))]
        public IBodyWorkflowAction<VectorQueryPostResponse> VectorQuery([WorkflowExpression] Func<bool> bodyincludeValues = null, [WorkflowExpression] Func<bool> bodyincludeMetadata = null, [WorkflowExpression] Func<int[]> bodysparseVectorindices = null, [WorkflowExpression] Func<int[]> bodysparseVectorvalues = null, [WorkflowExpression] Func<string> bodyNamespace = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<int[]> bodyvector = null, [WorkflowExpression] Func<string> bodyid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VectorQueryPostResponse> __BuildVectorQuery(WorkflowExpression<bool> bodyincludeValues = null, WorkflowExpression<bool> bodyincludeMetadata = null, WorkflowExpression<int[]> bodysparseVectorindices = null, WorkflowExpression<int[]> bodysparseVectorvalues = null, WorkflowExpression<string> bodyNamespace = null, WorkflowExpression<int> bodytopK = null, WorkflowExpression<int[]> bodyvector = null, WorkflowExpression<string> bodyid = null)
        {
            WorkflowExpression.Validate(bodyincludeValues, nameof(bodyincludeValues), required: false);
            WorkflowExpression.Validate(bodyincludeMetadata, nameof(bodyincludeMetadata), required: false);
            WorkflowExpression.Validate(bodysparseVectorindices, nameof(bodysparseVectorindices), required: false);
            WorkflowExpression.Validate(bodysparseVectorvalues, nameof(bodysparseVectorvalues), required: false);
            WorkflowExpression.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
            WorkflowExpression.Validate(bodytopK, nameof(bodytopK), required: false);
            WorkflowExpression.Validate(bodyvector, nameof(bodyvector), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            return new DeferredBodyAction<VectorQueryPostResponse>(() =>
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyincludeValues != null)
                {
                    body["includeValues"] = ExpressionConverter.ConvertO(bodyincludeValues);
                    bodypropCount++;
                }

                if (bodyincludeMetadata != null)
                {
                    body["includeMetadata"] = ExpressionConverter.ConvertO(bodyincludeMetadata);
                    bodypropCount++;
                }

                var sparseVectorObject = new JObject();
                var sparseVectorObjectpropCount = 0;
                if (bodysparseVectorindices != null)
                {
                    sparseVectorObject["indices"] = ExpressionConverter.ConvertO(bodysparseVectorindices);
                    sparseVectorObjectpropCount++;
                }

                if (bodysparseVectorvalues != null)
                {
                    sparseVectorObject["values"] = ExpressionConverter.ConvertO(bodysparseVectorvalues);
                    sparseVectorObjectpropCount++;
                }

                if (sparseVectorObjectpropCount > 0)
                {
                    body["sparseVector"] = sparseVectorObject;
                    bodypropCount++;
                }

                if (bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
                    bodypropCount++;
                }

                if (bodytopK != null)
                {
                    body["topK"] = ExpressionConverter.ConvertO(bodytopK);
                    bodypropCount++;
                }

                if (bodyvector != null)
                {
                    body["vector"] = ExpressionConverter.ConvertO(bodyvector);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
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
        [WorkflowExpressionFactory(nameof(__BuildVectorDelete))]
        public IBodyWorkflowAction<string> VectorDelete([WorkflowExpression] Func<bool> bodydeleteAll = null, [WorkflowExpression] Func<string[]> bodyids = null, [WorkflowExpression] Func<string> bodyNamespace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVectorDelete(WorkflowExpression<bool> bodydeleteAll = null, WorkflowExpression<string[]> bodyids = null, WorkflowExpression<string> bodyNamespace = null)
        {
            WorkflowExpression.Validate(bodydeleteAll, nameof(bodydeleteAll), required: false);
            WorkflowExpression.Validate(bodyids, nameof(bodyids), required: false);
            WorkflowExpression.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/vectors/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydeleteAll != null)
                {
                    body["deleteAll"] = ExpressionConverter.ConvertO(bodydeleteAll);
                    bodypropCount++;
                }

                if (bodyids != null)
                {
                    body["ids"] = ExpressionConverter.ConvertO(bodyids);
                    bodypropCount++;
                }

                if (bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
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
        [WorkflowExpressionFactory(nameof(__BuildVectorsGet))]
        public IBodyWorkflowAction<VectorsGetResponse> VectorsGet([WorkflowExpression] Func<string> ids, [WorkflowExpression] Func<string> @namespace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VectorsGetResponse> __BuildVectorsGet(WorkflowExpression<string> ids, WorkflowExpression<string> @namespace = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: true);
            WorkflowExpression.Validate(@namespace, nameof(@namespace), required: false);
            return new DeferredBodyAction<VectorsGetResponse>(() =>
            {
                var apiCallPath = "/fetch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (@namespace != null)
                    callPayload.Queries["namespace"] = ExpressionConverter.Convert(@namespace);
                return new ApiConnectionAction<VectorsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [WorkflowExpressionFactory(nameof(__BuildVectorUpdate))]
        public IBodyWorkflowAction<string> VectorUpdate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<double[]> bodyvalues = null, [WorkflowExpression] Func<int[]> bodysparseValuesindices = null, [WorkflowExpression] Func<double[]> bodysparseValuesvalues = null, [WorkflowExpression] Func<string> bodyNamespace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVectorUpdate(WorkflowExpression<string> bodyid, WorkflowExpression<double[]> bodyvalues = null, WorkflowExpression<int[]> bodysparseValuesindices = null, WorkflowExpression<double[]> bodysparseValuesvalues = null, WorkflowExpression<string> bodyNamespace = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyvalues, nameof(bodyvalues), required: false);
            WorkflowExpression.Validate(bodysparseValuesindices, nameof(bodysparseValuesindices), required: false);
            WorkflowExpression.Validate(bodysparseValuesvalues, nameof(bodysparseValuesvalues), required: false);
            WorkflowExpression.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/vectors/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodyvalues != null)
                {
                    body["values"] = ExpressionConverter.ConvertO(bodyvalues);
                    bodypropCount++;
                }

                var sparseValuesObject = new JObject();
                var sparseValuesObjectpropCount = 0;
                if (bodysparseValuesindices != null)
                {
                    sparseValuesObject["indices"] = ExpressionConverter.ConvertO(bodysparseValuesindices);
                    sparseValuesObjectpropCount++;
                }

                if (bodysparseValuesvalues != null)
                {
                    sparseValuesObject["values"] = ExpressionConverter.ConvertO(bodysparseValuesvalues);
                    sparseValuesObjectpropCount++;
                }

                if (sparseValuesObjectpropCount > 0)
                {
                    body["sparseValues"] = sparseValuesObject;
                    bodypropCount++;
                }

                if (bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
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
        [WorkflowExpressionFactory(nameof(__BuildVectorUpsert))]
        public IBodyWorkflowAction<VectorUpsertPostResponse> VectorUpsert([WorkflowExpression] Func<bodyvectorsInputItem[]> bodyvectors = null, [WorkflowExpression] Func<string> bodyNamespace = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VectorUpsertPostResponse> __BuildVectorUpsert(WorkflowExpression<bodyvectorsInputItem[]> bodyvectors = null, WorkflowExpression<string> bodyNamespace = null)
        {
            WorkflowExpression.Validate(bodyvectors, nameof(bodyvectors), required: false);
            WorkflowExpression.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
            return new DeferredBodyAction<VectorUpsertPostResponse>(() =>
            {
                var apiCallPath = "/vectors/upsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvectors != null)
                {
                    body["vectors"] = ExpressionConverter.ConvertO(bodyvectors);
                    bodypropCount++;
                }

                if (bodyNamespace != null)
                {
                    body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
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
        [WorkflowExpressionFactory(nameof(__BuildCollectionCreate))]
        public IBodyWorkflowAction<string> CollectionCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodysource)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCollectionCreate(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodysource)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/collections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [WorkflowExpressionFactory(nameof(__BuildCollectionGet))]
        public IBodyWorkflowAction<CollectionGetResponse> CollectionGet([WorkflowExpression] Func<string> collectionName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CollectionGetResponse> __BuildCollectionGet(WorkflowExpression<string> collectionName)
        {
            WorkflowExpression.Validate(collectionName, nameof(collectionName), required: true);
            return new DeferredBodyAction<CollectionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(collectionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CollectionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [WorkflowExpressionFactory(nameof(__BuildCollectionDelete))]
        public IBodyWorkflowAction<string> CollectionDelete([WorkflowExpression] Func<string> collectionName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCollectionDelete(WorkflowExpression<string> collectionName)
        {
            WorkflowExpression.Validate(collectionName, nameof(collectionName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(collectionName, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildIndex))]
        public IBodyWorkflowAction<string> Index([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int> bodydimension, [WorkflowExpression] Func<string> bodymetric = null, [WorkflowExpression] Func<int> bodypods = null, [WorkflowExpression] Func<int> bodyreplicas = null, [WorkflowExpression] Func<string> bodypodType = null, [WorkflowExpression] Func<string> bodysourceCollection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildIndex(WorkflowExpression<string> bodyname, WorkflowExpression<int> bodydimension, WorkflowExpression<string> bodymetric = null, WorkflowExpression<int> bodypods = null, WorkflowExpression<int> bodyreplicas = null, WorkflowExpression<string> bodypodType = null, WorkflowExpression<string> bodysourceCollection = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydimension, nameof(bodydimension), required: true);
            WorkflowExpression.Validate(bodymetric, nameof(bodymetric), required: false);
            WorkflowExpression.Validate(bodypods, nameof(bodypods), required: false);
            WorkflowExpression.Validate(bodyreplicas, nameof(bodyreplicas), required: false);
            WorkflowExpression.Validate(bodypodType, nameof(bodypodType), required: false);
            WorkflowExpression.Validate(bodysourceCollection, nameof(bodysourceCollection), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/databases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["dimension"] = ExpressionConverter.ConvertO(bodydimension);
                if (bodymetric != null)
                {
                    body["metric"] = ExpressionConverter.ConvertO(bodymetric);
                    bodypropCount++;
                }

                if (bodypods != null)
                {
                    body["pods"] = ExpressionConverter.ConvertO(bodypods);
                    bodypropCount++;
                }

                if (bodyreplicas != null)
                {
                    body["replicas"] = ExpressionConverter.ConvertO(bodyreplicas);
                    bodypropCount++;
                }

                if (bodypodType != null)
                {
                    body["pod_type"] = ExpressionConverter.ConvertO(bodypodType);
                    bodypropCount++;
                }

                if (bodysourceCollection != null)
                {
                    body["source_collection"] = ExpressionConverter.ConvertO(bodysourceCollection);
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
        [WorkflowExpressionFactory(nameof(__BuildIndexGet))]
        public IBodyWorkflowAction<IndexGetResponse> IndexGet([WorkflowExpression] Func<string> indexName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IndexGetResponse> __BuildIndexGet(WorkflowExpression<string> indexName)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<IndexGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IndexGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [WorkflowExpressionFactory(nameof(__BuildIndexDelete))]
        public IBodyWorkflowAction<string> IndexDelete([WorkflowExpression] Func<string> indexName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildIndexDelete(WorkflowExpression<string> indexName)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [WorkflowExpressionFactory(nameof(__BuildIndexPatch))]
        public IBodyWorkflowAction<string> IndexPatch([WorkflowExpression] Func<string> indexName, [WorkflowExpression] Func<int> bodyreplicas = null, [WorkflowExpression] Func<string> bodypodType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildIndexPatch(WorkflowExpression<string> indexName, WorkflowExpression<int> bodyreplicas = null, WorkflowExpression<string> bodypodType = null)
        {
            WorkflowExpression.Validate(indexName, nameof(indexName), required: true);
            WorkflowExpression.Validate(bodyreplicas, nameof(bodyreplicas), required: false);
            WorkflowExpression.Validate(bodypodType, nameof(bodypodType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyreplicas != null)
                {
                    body["replicas"] = ExpressionConverter.ConvertO(bodyreplicas);
                    bodypropCount++;
                }

                if (bodypodType != null)
                {
                    body["pod_type"] = ExpressionConverter.ConvertO(bodypodType);
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