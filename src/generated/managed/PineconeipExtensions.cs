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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VectorQueryPostResponse> __BuildVectorQuery(WorkflowValue<bool> bodyincludeValues = null, WorkflowValue<bool> bodyincludeMetadata = null, WorkflowValue<int[]> bodysparseVectorindices = null, WorkflowValue<int[]> bodysparseVectorvalues = null, WorkflowValue<string> bodyNamespace = null, WorkflowValue<int> bodytopK = null, WorkflowValue<int[]> bodyvector = null, WorkflowValue<string> bodyid = null)
        {
            WorkflowValue.Validate(bodyincludeValues, nameof(bodyincludeValues), required: false);
            WorkflowValue.Validate(bodyincludeMetadata, nameof(bodyincludeMetadata), required: false);
            WorkflowValue.Validate(bodysparseVectorindices, nameof(bodysparseVectorindices), required: false);
            WorkflowValue.Validate(bodysparseVectorvalues, nameof(bodysparseVectorvalues), required: false);
            WorkflowValue.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
            WorkflowValue.Validate(bodytopK, nameof(bodytopK), required: false);
            WorkflowValue.Validate(bodyvector, nameof(bodyvector), required: false);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVectorDelete(WorkflowValue<bool> bodydeleteAll = null, WorkflowValue<string[]> bodyids = null, WorkflowValue<string> bodyNamespace = null)
        {
            WorkflowValue.Validate(bodydeleteAll, nameof(bodydeleteAll), required: false);
            WorkflowValue.Validate(bodyids, nameof(bodyids), required: false);
            WorkflowValue.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VectorsGetResponse> __BuildVectorsGet(WorkflowValue<string> ids, WorkflowValue<string> @namespace = null)
        {
            WorkflowValue.Validate(ids, nameof(ids), required: true);
            WorkflowValue.Validate(@namespace, nameof(@namespace), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVectorUpdate(WorkflowValue<string> bodyid, WorkflowValue<double[]> bodyvalues = null, WorkflowValue<int[]> bodysparseValuesindices = null, WorkflowValue<double[]> bodysparseValuesvalues = null, WorkflowValue<string> bodyNamespace = null)
        {
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowValue.Validate(bodyvalues, nameof(bodyvalues), required: false);
            WorkflowValue.Validate(bodysparseValuesindices, nameof(bodysparseValuesindices), required: false);
            WorkflowValue.Validate(bodysparseValuesvalues, nameof(bodysparseValuesvalues), required: false);
            WorkflowValue.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VectorUpsertPostResponse> __BuildVectorUpsert(WorkflowValue<bodyvectorsInputItem[]> bodyvectors = null, WorkflowValue<string> bodyNamespace = null)
        {
            WorkflowValue.Validate(bodyvectors, nameof(bodyvectors), required: false);
            WorkflowValue.Validate(bodyNamespace, nameof(bodyNamespace), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCollectionCreate(WorkflowValue<string> bodyname, WorkflowValue<string> bodysource)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CollectionGetResponse> __BuildCollectionGet(WorkflowValue<string> collectionName)
        {
            WorkflowValue.Validate(collectionName, nameof(collectionName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCollectionDelete(WorkflowValue<string> collectionName)
        {
            WorkflowValue.Validate(collectionName, nameof(collectionName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildIndex(WorkflowValue<string> bodyname, WorkflowValue<int> bodydimension, WorkflowValue<string> bodymetric = null, WorkflowValue<int> bodypods = null, WorkflowValue<int> bodyreplicas = null, WorkflowValue<string> bodypodType = null, WorkflowValue<string> bodysourceCollection = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodydimension, nameof(bodydimension), required: true);
            WorkflowValue.Validate(bodymetric, nameof(bodymetric), required: false);
            WorkflowValue.Validate(bodypods, nameof(bodypods), required: false);
            WorkflowValue.Validate(bodyreplicas, nameof(bodyreplicas), required: false);
            WorkflowValue.Validate(bodypodType, nameof(bodypodType), required: false);
            WorkflowValue.Validate(bodysourceCollection, nameof(bodysourceCollection), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IndexGetResponse> __BuildIndexGet(WorkflowValue<string> indexName)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildIndexDelete(WorkflowValue<string> indexName)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildIndexPatch(WorkflowValue<string> indexName, WorkflowValue<int> bodyreplicas = null, WorkflowValue<string> bodypodType = null)
        {
            WorkflowValue.Validate(indexName, nameof(indexName), required: true);
            WorkflowValue.Validate(bodyreplicas, nameof(bodyreplicas), required: false);
            WorkflowValue.Validate(bodypodType, nameof(bodypodType), required: false);
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
