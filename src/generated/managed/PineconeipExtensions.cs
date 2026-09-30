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
        public IBodyWorkflowAction<VectorQueryPostResponse> VectorQuery([WorkflowExpression] Func<bool> bodyincludeValues = null, [WorkflowExpression] Func<bool> bodyincludeMetadata = null, [WorkflowExpression] Func<int[]> bodysparseVectorindices = null, [WorkflowExpression] Func<int[]> bodysparseVectorvalues = null, [WorkflowExpression] Func<string> bodyNamespace = null, [WorkflowExpression] Func<int> bodytopK = null, [WorkflowExpression] Func<int[]> bodyvector = null, [WorkflowExpression] Func<string> bodyid = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> VectorDelete([WorkflowExpression] Func<bool> bodydeleteAll = null, [WorkflowExpression] Func<string[]> bodyids = null, [WorkflowExpression] Func<string> bodyNamespace = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<VectorsGetResponse> VectorsGet([WorkflowExpression] Func<string> ids, [WorkflowExpression] Func<string> @namespace = null)
        {
            var apiCallPath = "/fetch";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (@namespace != null)
                callPayload.Queries["namespace"] = ExpressionConverter.Convert(@namespace);
            return new ApiConnectionAction<VectorsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> VectorUpdate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<double[]> bodyvalues = null, [WorkflowExpression] Func<int[]> bodysparseValuesindices = null, [WorkflowExpression] Func<double[]> bodysparseValuesvalues = null, [WorkflowExpression] Func<string> bodyNamespace = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<VectorUpsertPostResponse> VectorUpsert([WorkflowExpression] Func<bodyvectorsInputItem[]> bodyvectors = null, [WorkflowExpression] Func<string> bodyNamespace = null)
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
        public IBodyWorkflowAction<string> CollectionCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodysource)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<CollectionGetResponse> CollectionGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> collectionName)
        {
            var apiCallPath = String.Format("/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(collectionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CollectionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> CollectionDelete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> collectionName)
        {
            var apiCallPath = String.Format("/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(collectionName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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
        public IBodyWorkflowAction<string> Index([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int> bodydimension, [WorkflowExpression] Func<string> bodymetric = null, [WorkflowExpression] Func<int> bodypods = null, [WorkflowExpression] Func<int> bodyreplicas = null, [WorkflowExpression] Func<string> bodypodType = null, [WorkflowExpression] Func<string> bodysourceCollection = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<IndexGetResponse> IndexGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> indexName)
        {
            var apiCallPath = String.Format("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IndexGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> IndexDelete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> indexName)
        {
            var apiCallPath = String.Format("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pineconeip")]
        public IBodyWorkflowAction<string> IndexPatch([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> indexName, [WorkflowExpression] Func<int> bodyreplicas = null, [WorkflowExpression] Func<string> bodypodType = null)
        {
            var apiCallPath = String.Format("/databases/{0}", ExpressionConverter.ConvertWithUrlEncoding(indexName, 1));
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