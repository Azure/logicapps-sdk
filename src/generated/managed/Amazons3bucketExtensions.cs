//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3bucket
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Amazons3bucketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IBodyWorkflowAction<ListObjectsS3Response> ListObjectsS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> bucketlistType = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> delimiter = null, Expression<Func<string>> prefix = null, Expression<Func<string>> encodingType = null, Expression<Func<string>> fetchOwner = null, Expression<Func<double>> maxKeys = null, Expression<Func<string>> startAfter = null)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_bucket = bucket == null ? null : WorkflowExpression.Compile(bucket);
            WorkflowExpression.Validate(__workflow_bucket, nameof(bucket), required: true);
            var __workflow_bucketlistType = bucketlistType == null ? null : WorkflowExpression.Compile(bucketlistType);
            WorkflowExpression.Validate(__workflow_bucketlistType, nameof(bucketlistType), required: false);
            var __workflow_continuationToken = continuationToken == null ? null : WorkflowExpression.Compile(continuationToken);
            WorkflowExpression.Validate(__workflow_continuationToken, nameof(continuationToken), required: false);
            var __workflow_delimiter = delimiter == null ? null : WorkflowExpression.Compile(delimiter);
            WorkflowExpression.Validate(__workflow_delimiter, nameof(delimiter), required: false);
            var __workflow_prefix = prefix == null ? null : WorkflowExpression.Compile(prefix);
            WorkflowExpression.Validate(__workflow_prefix, nameof(prefix), required: false);
            var __workflow_encodingType = encodingType == null ? null : WorkflowExpression.Compile(encodingType);
            WorkflowExpression.Validate(__workflow_encodingType, nameof(encodingType), required: false);
            var __workflow_fetchOwner = fetchOwner == null ? null : WorkflowExpression.Compile(fetchOwner);
            WorkflowExpression.Validate(__workflow_fetchOwner, nameof(fetchOwner), required: false);
            var __workflow_maxKeys = maxKeys == null ? null : WorkflowExpression.Compile(maxKeys);
            WorkflowExpression.Validate(__workflow_maxKeys, nameof(maxKeys), required: false);
            var __workflow_startAfter = startAfter == null ? null : WorkflowExpression.Compile(startAfter);
            WorkflowExpression.Validate(__workflow_startAfter, nameof(startAfter), required: false);
            return new DeferredBodyAction<ListObjectsS3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_region, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_bucket, 1));
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
        public IWorkflowAction DeleteObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_bucket = bucket == null ? null : WorkflowExpression.Compile(bucket);
            WorkflowExpression.Validate(__workflow_bucket, nameof(bucket), required: true);
            var __workflow_key = key == null ? null : WorkflowExpression.Compile(key);
            WorkflowExpression.Validate(__workflow_key, nameof(key), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_region, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_bucket, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction GetObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_bucket = bucket == null ? null : WorkflowExpression.Compile(bucket);
            WorkflowExpression.Validate(__workflow_bucket, nameof(bucket), required: true);
            var __workflow_key = key == null ? null : WorkflowExpression.Compile(key);
            WorkflowExpression.Validate(__workflow_key, nameof(key), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_region, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_bucket, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_key, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction PutObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key, Expression<Func<string>> body = null)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_bucket = bucket == null ? null : WorkflowExpression.Compile(bucket);
            WorkflowExpression.Validate(__workflow_bucket, nameof(bucket), required: true);
            var __workflow_key = key == null ? null : WorkflowExpression.Compile(key);
            WorkflowExpression.Validate(__workflow_key, nameof(key), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_region, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_bucket, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_key, 1));
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
