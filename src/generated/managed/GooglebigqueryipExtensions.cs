//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlebigqueryip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglebigqueryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlebigqueryip")]
        public IBodyWorkflowAction<GetDatasetResponse> GetDataset([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> datasetId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(datasetId, nameof(datasetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bigquery/v2/projects/{0}/datasets/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDatasetResponse>(BuildSourceInput);
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