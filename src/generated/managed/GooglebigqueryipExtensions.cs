//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlebigqueryip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglebigqueryipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlebigqueryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDataset))]
        public IBodyWorkflowAction<GetDatasetResponse> GetDataset([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> datasetId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlebigqueryip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDatasetResponse> __BuildGetDataset(WorkflowExpression<string> projectId, WorkflowExpression<string> datasetId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(datasetId, nameof(datasetId), required: true);
            return new DeferredBodyAction<GetDatasetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bigquery/v2/projects/{0}/datasets/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(datasetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDatasetResponse>(callPayload);
            });
        }
    }

    public class GooglebigqueryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDatasetResponse
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("selfLink")]
        public string SelfLink { get; set; }

        [JsonProperty("datasetReference")]
        public GetDatasetResponseDatasetReferenceType DatasetReference { get; set; }

        [JsonProperty("defaultTableExpirationMs")]
        public string DefaultTableExpirationMs { get; set; }

        [JsonProperty("access")]
        public GetDatasetResponseAccessTypeItem[] Access { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("defaultPartitionExpirationMs")]
        public string DefaultPartitionExpirationMs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDatasetResponseDatasetReferenceType
    {
        [JsonProperty("datasetId")]
        public string DatasetID { get; set; }

        [JsonProperty("projectId")]
        public string ProjectID { get; set; }
    }

    public class GetDatasetResponseAccessTypeItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("specialGroup")]
        public string SpecialGroup { get; set; }

        [JsonProperty("userByEmail")]
        public string UserByEmail { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlebigqueryip;

    public partial class WorkflowManagedActions
    {
        public GooglebigqueryipActions Googlebigqueryip(string connectionId) => new GooglebigqueryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglebigqueryipTriggers Googlebigqueryip(string connectionId) => new GooglebigqueryipTriggers(connectionId);
    }
}