//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Amazons3Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3RegionCollection> ListRegions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<S3RegionCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3BucketCollection> ListBuckets()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/buckets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<S3BucketCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3ObjectCollection> ListObjects([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> bucketRegion = null, [WorkflowExpression] Func<int> maxObjectCount = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/buckets/objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = SourceExpressionConverter.ConvertO(bucketName);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = SourceExpressionConverter.ConvertO(bucketRegion);
                callPayload.Queries["maxObjectCount"] = Convert.ToString(100);
                if (maxObjectCount != null)
                    callPayload.Queries["maxObjectCount"] = SourceExpressionConverter.ConvertO(maxObjectCount);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                return callPayload;
            }

            return new ApiConnectionAction<S3ObjectCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3ObjectDeepMetadata> GetObjectMetadata([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> objectKey, [WorkflowExpression] Func<string> bucketRegion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/buckets/objects/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = SourceExpressionConverter.ConvertO(bucketName);
                callPayload.Queries["objectKey"] = SourceExpressionConverter.ConvertO(objectKey);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = SourceExpressionConverter.ConvertO(bucketRegion);
                return callPayload;
            }

            return new ApiConnectionAction<S3ObjectDeepMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<string> GetObjectContent([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> objectKey, [WorkflowExpression] Func<string> bucketRegion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/buckets/objects/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = SourceExpressionConverter.ConvertO(bucketName);
                callPayload.Queries["objectKey"] = SourceExpressionConverter.ConvertO(objectKey);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = SourceExpressionConverter.ConvertO(bucketRegion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class Amazons3Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<S3ObjectDeepMetadata> OnObjectUpdate([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> objectKey, [WorkflowExpression] Func<string> bucketRegion = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/buckets/objects/onupdate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = SourceExpressionConverter.ConvertO(bucketName);
                callPayload.Queries["objectKey"] = SourceExpressionConverter.ConvertO(objectKey);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = SourceExpressionConverter.ConvertO(bucketRegion);
                return callPayload;
            }

            return new ApiConnectionTrigger<S3ObjectDeepMetadata>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class S3RegionCollection
    {
        [JsonProperty("value")]
        public S3Region[] Value { get; set; }
    }

    public class S3Region
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class S3BucketCollection
    {
        [JsonProperty("value")]
        public S3Bucket[] Value { get; set; }
    }

    public class S3Bucket
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class S3ObjectCollection
    {
        [JsonProperty("value")]
        public S3ObjectMetadata[] Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }

    public class S3ObjectMetadata
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastChangedTime")]
        public string LastChangedTime { get; set; }
    }

    public class S3ObjectDeepMetadata
    {
        [JsonProperty("bucket")]
        public string Bucket { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastChangedTime")]
        public string LastChangedTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3;

    public partial class WorkflowManagedActions
    {
        public Amazons3Actions Amazons3(string connectionId) => new Amazons3Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Amazons3Triggers Amazons3(string connectionId) => new Amazons3Triggers(connectionId);
    }
}