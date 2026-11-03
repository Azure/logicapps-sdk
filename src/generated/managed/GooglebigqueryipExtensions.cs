//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlebigqueryip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglebigqueryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlebigqueryip")]
        public IBodyWorkflowAction<GetDatasetResponse, ApiConnectionActionConfiguration> GetDataset(Expression<Func<string>> projectId, Expression<Func<string>> datasetId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_datasetId = WorkflowExpression.Compile(datasetId, nameof(datasetId), required: true);
            return new DeferredBodyAction<GetDatasetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bigquery/v2/projects/{0}/datasets/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_datasetId.WithUrlEncoding(1)));
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
        public string Id { get; set; }

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
        public string DatasetId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
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