//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Amazons3Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3RegionCollection> ListRegions()
        {
            var apiCallPath = "/regions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<S3RegionCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3BucketCollection> ListBuckets()
        {
            var apiCallPath = "/buckets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<S3BucketCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        [WorkflowExpressionFactory(nameof(__BuildListObjects))]
        public IBodyWorkflowAction<S3ObjectCollection> ListObjects([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> bucketRegion = null, [WorkflowExpression] Func<int> maxObjectCount = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<S3ObjectCollection> __BuildListObjects(WorkflowExpression<string> bucketName, WorkflowExpression<string> bucketRegion = null, WorkflowExpression<int> maxObjectCount = null, WorkflowExpression<string> continuationToken = null)
        {
            WorkflowExpression.Validate(bucketName, nameof(bucketName), required: true);
            WorkflowExpression.Validate(bucketRegion, nameof(bucketRegion), required: false);
            WorkflowExpression.Validate(maxObjectCount, nameof(maxObjectCount), required: false);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<S3ObjectCollection>(() =>
            {
                var apiCallPath = "/buckets/objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(bucketName);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(bucketRegion);
                callPayload.Queries["maxObjectCount"] = Convert.ToString(100);
                if (maxObjectCount != null)
                    callPayload.Queries["maxObjectCount"] = ExpressionConverter.Convert(maxObjectCount);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
                return new ApiConnectionAction<S3ObjectCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        [WorkflowExpressionFactory(nameof(__BuildGetObjectMetadata))]
        public IBodyWorkflowAction<S3ObjectDeepMetadata> GetObjectMetadata([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> objectKey, [WorkflowExpression] Func<string> bucketRegion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<S3ObjectDeepMetadata> __BuildGetObjectMetadata(WorkflowExpression<string> bucketName, WorkflowExpression<string> objectKey, WorkflowExpression<string> bucketRegion = null)
        {
            WorkflowExpression.Validate(bucketName, nameof(bucketName), required: true);
            WorkflowExpression.Validate(objectKey, nameof(objectKey), required: true);
            WorkflowExpression.Validate(bucketRegion, nameof(bucketRegion), required: false);
            return new DeferredBodyAction<S3ObjectDeepMetadata>(() =>
            {
                var apiCallPath = "/buckets/objects/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(bucketName);
                callPayload.Queries["objectKey"] = ExpressionConverter.Convert(objectKey);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(bucketRegion);
                return new ApiConnectionAction<S3ObjectDeepMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        [WorkflowExpressionFactory(nameof(__BuildGetObjectContent))]
        public IBodyWorkflowAction<string> GetObjectContent([WorkflowExpression] Func<string> bucketName, [WorkflowExpression] Func<string> objectKey, [WorkflowExpression] Func<string> bucketRegion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetObjectContent(WorkflowExpression<string> bucketName, WorkflowExpression<string> objectKey, WorkflowExpression<string> bucketRegion = null)
        {
            WorkflowExpression.Validate(bucketName, nameof(bucketName), required: true);
            WorkflowExpression.Validate(objectKey, nameof(objectKey), required: true);
            WorkflowExpression.Validate(bucketRegion, nameof(bucketRegion), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/buckets/objects/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(bucketName);
                callPayload.Queries["objectKey"] = ExpressionConverter.Convert(objectKey);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(bucketRegion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Amazons3Triggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnObjectUpdate))]
        public IBodyWorkflowTrigger<S3ObjectDeepMetadata> OnObjectUpdate([WorkflowExpression] Func<string> bucketName,[WorkflowExpression] Func<string> objectKey,[WorkflowExpression] Func<string> bucketRegion = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<S3ObjectDeepMetadata> __BuildOnObjectUpdate(WorkflowExpression<string> bucketName,WorkflowExpression<string> objectKey,WorkflowExpression<string> bucketRegion = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bucketName, nameof(bucketName), required: true);
            WorkflowExpression.Validate(objectKey, nameof(objectKey), required: true);
            WorkflowExpression.Validate(bucketRegion, nameof(bucketRegion), required: false);
            return new DeferredBodyTrigger<S3ObjectDeepMetadata>(() =>
            {
                var apiCallPath = "/buckets/objects/onupdate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(bucketName);
                callPayload.Queries["objectKey"] = ExpressionConverter.Convert(objectKey);
                if (bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(bucketRegion);
                return new ApiConnectionTrigger<S3ObjectDeepMetadata>(callPayload, recurrence: recurrence);
            });
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