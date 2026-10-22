//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3bucket
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Amazons3bucketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IBodyWorkflowAction<ListObjectsS3Response, ApiConnectionActionConfiguration> ListObjectsS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> bucketlistType = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> delimiter = null, Expression<Func<string>> prefix = null, Expression<Func<string>> encodingType = null, Expression<Func<string>> fetchOwner = null, Expression<Func<double>> maxKeys = null, Expression<Func<string>> startAfter = null)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bucket = WorkflowExpression.Compile(bucket, nameof(bucket), required: true);
            var __workflow_bucketlistType = WorkflowExpression.Compile(bucketlistType, nameof(bucketlistType), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_delimiter = WorkflowExpression.Compile(delimiter, nameof(delimiter), required: false);
            var __workflow_prefix = WorkflowExpression.Compile(prefix, nameof(prefix), required: false);
            var __workflow_encodingType = WorkflowExpression.Compile(encodingType, nameof(encodingType), required: false);
            var __workflow_fetchOwner = WorkflowExpression.Compile(fetchOwner, nameof(fetchOwner), required: false);
            var __workflow_maxKeys = WorkflowExpression.Compile(maxKeys, nameof(maxKeys), required: false);
            var __workflow_startAfter = WorkflowExpression.Compile(startAfter, nameof(startAfter), required: false);
            return new DeferredBodyAction<ListObjectsS3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/aws/s3/{0}/{1}", __workflow_region.WithUrlEncoding(1), __workflow_bucket.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketlist-type"] = Convert.ToString("2");
                if (__workflow_bucketlistType != null)
                    callPayload.Queries["bucketlist-type"] = ExpressionConverter.Convert(__workflow_bucketlistType);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuation-token"] = ExpressionConverter.Convert(__workflow_continuationToken);
                if (__workflow_delimiter != null)
                    callPayload.Queries["delimiter"] = ExpressionConverter.Convert(__workflow_delimiter);
                if (__workflow_prefix != null)
                    callPayload.Queries["prefix"] = ExpressionConverter.Convert(__workflow_prefix);
                if (__workflow_encodingType != null)
                    callPayload.Queries["encoding-type"] = ExpressionConverter.Convert(__workflow_encodingType);
                if (__workflow_fetchOwner != null)
                    callPayload.Queries["fetch-owner"] = ExpressionConverter.Convert(__workflow_fetchOwner);
                if (__workflow_maxKeys != null)
                    callPayload.Queries["max-keys"] = ExpressionConverter.Convert(__workflow_maxKeys);
                if (__workflow_startAfter != null)
                    callPayload.Queries["start-after"] = ExpressionConverter.Convert(__workflow_startAfter);
                return new ApiConnectionAction<ListObjectsS3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bucket = WorkflowExpression.Compile(bucket, nameof(bucket), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/aws/s3/{0}/{1}/{2}", __workflow_region.WithUrlEncoding(1), __workflow_bucket.WithUrlEncoding(1), __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bucket = WorkflowExpression.Compile(bucket, nameof(bucket), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/aws/s3/{0}/{1}/{2}", __workflow_region.WithUrlEncoding(1), __workflow_bucket.WithUrlEncoding(1), __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key, Expression<Func<string>> body = null)
        {
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: true);
            var __workflow_bucket = WorkflowExpression.Compile(bucket, nameof(bucket), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/aws/s3/{0}/{1}/{2}", __workflow_region.WithUrlEncoding(1), __workflow_bucket.WithUrlEncoding(1), __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Amazons3bucketTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListObjectsS3Response
    {
        public ListObjectsS3ResponseListBucketResultType ListBucketResult { get; set; }
    }

    public class ListObjectsS3ResponseListBucketResultType
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string MaxKeys { get; set; }
        public string IsTruncated { get; set; }
        public string KeyCount { get; set; }
        public string ContinuationToken { get; set; }
        public string NextContinuationToken { get; set; }
        public string StartAfter { get; set; }
        public ListObjectsS3ResponseListBucketResultTypeContentsTypeItem[] Contents { get; set; }
    }

    public class ListObjectsS3ResponseListBucketResultTypeContentsTypeItem
    {
        public string Key { get; set; }
        public string LastModified { get; set; }
        public string Size { get; set; }
        public ListObjectsS3ResponseListBucketResultTypeContentsTypeItemOwnerType Owner { get; set; }
        public string StorageClass { get; set; }
    }

    public class ListObjectsS3ResponseListBucketResultTypeContentsTypeItemOwnerType
    {
        public string ID { get; set; }
        public string DisplayName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3bucket;

    public partial class WorkflowManagedActions
    {
        public Amazons3bucketActions Amazons3bucket(string connectionId) => new Amazons3bucketActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Amazons3bucketTriggers Amazons3bucket(string connectionId) => new Amazons3bucketTriggers(connectionId);
    }
}
