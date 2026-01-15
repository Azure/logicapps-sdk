//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cohesitygaia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CohesitygaiaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohesitygaia")]
        public IBodyWorkflowAction<GetLlmListResponse> GetLlmList()
        {
            var apiCallPath = "/mcm/gaia/llms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLlmListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohesitygaia")]
        public IBodyWorkflowAction<GetDatasetsResponse> GetDatasets()
        {
            var apiCallPath = "/mcm/gaia/datasets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDatasetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cohesitygaia")]
        public IBodyWorkflowAction<QueryResponse> SendQuery(Expression<Func<string>> bodyllmName, Expression<Func<string>> bodyllmId, Expression<Func<string[]>> bodydatasetNames, Expression<Func<string>> bodyqueryString)
        {
            var apiCallPath = "/mcm/gaia/ask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["llmName"] = ExpressionConverter.ConvertO(bodyllmName);
            bodypropCount++;
            body["llmId"] = ExpressionConverter.ConvertO(bodyllmId);
            bodypropCount++;
            body["datasetNames"] = ExpressionConverter.ConvertO(bodydatasetNames);
            bodypropCount++;
            body["queryString"] = ExpressionConverter.ConvertO(bodyqueryString);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryResponse>(callPayload);
        }
    }

    public class CohesitygaiaTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLlmListResponse
    {
        [JsonProperty("llms")]
        public LLM[] Llms { get; set; }
    }

    public class LLM
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("buildType")]
        public string BuildType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("deploymentName")]
        public string DeploymentName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetDatasetsResponse
    {
        [JsonProperty("datasets")]
        public Dataset[] Datasets { get; set; }
    }

    public class Dataset
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("numObjects")]
        public int NumObjects { get; set; }

        [JsonProperty("numQueries")]
        public int NumQueries { get; set; }

        [JsonProperty("dataSources")]
        public JToken[] DataSources { get; set; }

        [JsonProperty("baasSnapshots")]
        public JToken[] BaasSnapshots { get; set; }

        [JsonProperty("indexingWindow")]
        public DatasetIndexingWindowType IndexingWindow { get; set; }

        [JsonProperty("userIds")]
        public string[] UserIds { get; set; }

        [JsonProperty("lastIndexingRun")]
        public DatasetLastIndexingRunType LastIndexingRun { get; set; }
    }

    public class DatasetIndexingWindowType
    {
        [JsonProperty("mostRecent")]
        public bool MostRecent { get; set; }

        [JsonProperty("startTimeUsecs")]
        public int StartTimeUsecs { get; set; }

        [JsonProperty("endTimeUsecs")]
        public int EndTimeUsecs { get; set; }
    }

    public class DatasetLastIndexingRunType
    {
        [JsonProperty("startTimeUsecs")]
        public int StartTimeUsecs { get; set; }

        [JsonProperty("endTimeUsecs")]
        public int EndTimeUsecs { get; set; }

        [JsonProperty("stats")]
        public JToken Stats { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("progress")]
        public JToken Progress { get; set; }
    }

    public class QueryResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sourceData")]
        public SourceData[] SourceData { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("queryUid")]
        public string QueryUid { get; set; }

        [JsonProperty("responseString")]
        public string ResponseString { get; set; }
    }

    public class SourceData
    {
        [JsonProperty("sourceType")]
        public string SourceType { get; set; }

        [JsonProperty("sourceContent")]
        public string SourceContent { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }
    }

    public class Document
    {
        [JsonProperty("absolutePath")]
        public string AbsolutePath { get; set; }

        [JsonProperty("baasSnapshot")]
        public DocumentBaasSnapshotType BaasSnapshot { get; set; }

        [JsonProperty("citations")]
        public DocumentCitationsTypeItem[] Citations { get; set; }

        [JsonProperty("datasetId")]
        public string DatasetId { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectInfo")]
        public DocumentObjectInfoType ObjectInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DocumentBaasSnapshotType
    {
        [JsonProperty("regionId")]
        public string RegionId { get; set; }

        [JsonProperty("snapshotInfo")]
        public DocumentBaasSnapshotTypeSnapshotInfoType SnapshotInfo { get; set; }
    }

    public class DocumentBaasSnapshotTypeSnapshotInfoType
    {
        [JsonProperty("runInstanceId")]
        public int RunInstanceId { get; set; }

        [JsonProperty("runStartTimeUsecs")]
        public int RunStartTimeUsecs { get; set; }
    }

    public class DocumentCitationsTypeItem
    {
        [JsonProperty("cosineScore")]
        public double CosineScore { get; set; }

        [JsonProperty("textSnippet")]
        public string TextSnippet { get; set; }
    }

    public class DocumentObjectInfoType
    {
        [JsonProperty("cloudProvider")]
        public string CloudProvider { get; set; }

        [JsonProperty("clusterIdentifier")]
        public string ClusterIdentifier { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("globalId")]
        public string GlobalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("regionId")]
        public string RegionId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Cohesitygaia;

    public partial class WorkflowManagedActions
    {
        public CohesitygaiaActions Cohesitygaia(string connectionId) => new CohesitygaiaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CohesitygaiaTriggers Cohesitygaia(string connectionId) => new CohesitygaiaTriggers(connectionId);
    }
}