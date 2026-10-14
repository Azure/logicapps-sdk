//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<S3ObjectCollection> ListObjects(Expression<Func<string>> bucketName, Expression<Func<string>> bucketRegion = null, Expression<Func<int>> maxObjectCount = null, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_bucketName = bucketName == null ? null : WorkflowExpression.Compile(bucketName);
            WorkflowExpression.Validate(__workflow_bucketName, nameof(bucketName), required: true);
            var __workflow_bucketRegion = bucketRegion == null ? null : WorkflowExpression.Compile(bucketRegion);
            WorkflowExpression.Validate(__workflow_bucketRegion, nameof(bucketRegion), required: false);
            var __workflow_maxObjectCount = maxObjectCount == null ? null : WorkflowExpression.Compile(maxObjectCount);
            WorkflowExpression.Validate(__workflow_maxObjectCount, nameof(maxObjectCount), required: false);
            var __workflow_continuationToken = continuationToken == null ? null : WorkflowExpression.Compile(continuationToken);
            WorkflowExpression.Validate(__workflow_continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<S3ObjectCollection>(() =>
            {
                var apiCallPath = "/buckets/objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(__workflow_bucketName);
                if (__workflow_bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(__workflow_bucketRegion);
                callPayload.Queries["maxObjectCount"] = Convert.ToString(100);
                if (__workflow_maxObjectCount != null)
                    callPayload.Queries["maxObjectCount"] = ExpressionConverter.Convert(__workflow_maxObjectCount);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                return new ApiConnectionAction<S3ObjectCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<S3ObjectDeepMetadata> GetObjectMetadata(Expression<Func<string>> bucketName, Expression<Func<string>> objectKey, Expression<Func<string>> bucketRegion = null)
        {
            var __workflow_bucketName = bucketName == null ? null : WorkflowExpression.Compile(bucketName);
            WorkflowExpression.Validate(__workflow_bucketName, nameof(bucketName), required: true);
            var __workflow_objectKey = objectKey == null ? null : WorkflowExpression.Compile(objectKey);
            WorkflowExpression.Validate(__workflow_objectKey, nameof(objectKey), required: true);
            var __workflow_bucketRegion = bucketRegion == null ? null : WorkflowExpression.Compile(bucketRegion);
            WorkflowExpression.Validate(__workflow_bucketRegion, nameof(bucketRegion), required: false);
            return new DeferredBodyAction<S3ObjectDeepMetadata>(() =>
            {
                var apiCallPath = "/buckets/objects/metadata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(__workflow_bucketName);
                callPayload.Queries["objectKey"] = ExpressionConverter.Convert(__workflow_objectKey);
                if (__workflow_bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(__workflow_bucketRegion);
                return new ApiConnectionAction<S3ObjectDeepMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3")]
        public IBodyWorkflowAction<string> GetObjectContent(Expression<Func<string>> bucketName, Expression<Func<string>> objectKey, Expression<Func<string>> bucketRegion = null)
        {
            var __workflow_bucketName = bucketName == null ? null : WorkflowExpression.Compile(bucketName);
            WorkflowExpression.Validate(__workflow_bucketName, nameof(bucketName), required: true);
            var __workflow_objectKey = objectKey == null ? null : WorkflowExpression.Compile(objectKey);
            WorkflowExpression.Validate(__workflow_objectKey, nameof(objectKey), required: true);
            var __workflow_bucketRegion = bucketRegion == null ? null : WorkflowExpression.Compile(bucketRegion);
            WorkflowExpression.Validate(__workflow_bucketRegion, nameof(bucketRegion), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/buckets/objects/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(__workflow_bucketName);
                callPayload.Queries["objectKey"] = ExpressionConverter.Convert(__workflow_objectKey);
                if (__workflow_bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(__workflow_bucketRegion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Amazons3Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<S3ObjectDeepMetadata> OnObjectUpdate(Expression<Func<string>> bucketName, Expression<Func<string>> objectKey, Expression<Func<string>> bucketRegion = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bucketName = bucketName == null ? null : WorkflowExpression.Compile(bucketName);
            WorkflowExpression.Validate(__workflow_bucketName, nameof(bucketName), required: true);
            var __workflow_objectKey = objectKey == null ? null : WorkflowExpression.Compile(objectKey);
            WorkflowExpression.Validate(__workflow_objectKey, nameof(objectKey), required: true);
            var __workflow_bucketRegion = bucketRegion == null ? null : WorkflowExpression.Compile(bucketRegion);
            WorkflowExpression.Validate(__workflow_bucketRegion, nameof(bucketRegion), required: false);
            return new DeferredBodyTrigger<S3ObjectDeepMetadata>(() =>
            {
                var apiCallPath = "/buckets/objects/onupdate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketName"] = ExpressionConverter.Convert(__workflow_bucketName);
                callPayload.Queries["objectKey"] = ExpressionConverter.Convert(__workflow_objectKey);
                if (__workflow_bucketRegion != null)
                    callPayload.Queries["bucketRegion"] = ExpressionConverter.Convert(__workflow_bucketRegion);
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
