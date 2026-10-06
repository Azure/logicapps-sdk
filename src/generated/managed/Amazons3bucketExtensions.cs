//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3bucket
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Amazons3bucketActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [WorkflowExpressionFactory(nameof(__BuildListObjectsS3))]
        public IBodyWorkflowAction<ListObjectsS3Response> ListObjectsS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> bucketlistType = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> delimiter = null, [WorkflowExpression] Func<string> prefix = null, [WorkflowExpression] Func<string> encodingType = null, [WorkflowExpression] Func<string> fetchOwner = null, [WorkflowExpression] Func<double> maxKeys = null, [WorkflowExpression] Func<string> startAfter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListObjectsS3Response> __BuildListObjectsS3(WorkflowExpression<string> region, WorkflowExpression<string> bucket, WorkflowExpression<string> bucketlistType = null, WorkflowExpression<string> continuationToken = null, WorkflowExpression<string> delimiter = null, WorkflowExpression<string> prefix = null, WorkflowExpression<string> encodingType = null, WorkflowExpression<string> fetchOwner = null, WorkflowExpression<double> maxKeys = null, WorkflowExpression<string> startAfter = null)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bucket, nameof(bucket), required: true);
            WorkflowExpression.Validate(bucketlistType, nameof(bucketlistType), required: false);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowExpression.Validate(delimiter, nameof(delimiter), required: false);
            WorkflowExpression.Validate(prefix, nameof(prefix), required: false);
            WorkflowExpression.Validate(encodingType, nameof(encodingType), required: false);
            WorkflowExpression.Validate(fetchOwner, nameof(fetchOwner), required: false);
            WorkflowExpression.Validate(maxKeys, nameof(maxKeys), required: false);
            WorkflowExpression.Validate(startAfter, nameof(startAfter), required: false);
            return new DeferredBodyAction<ListObjectsS3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(region, 1), ExpressionConverter.ConvertWithUrlEncoding(bucket, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketlist-type"] = Convert.ToString("2");
                if (bucketlistType != null)
                    callPayload.Queries["bucketlist-type"] = ExpressionConverter.Convert(bucketlistType);
                if (continuationToken != null)
                    callPayload.Queries["continuation-token"] = ExpressionConverter.Convert(continuationToken);
                if (delimiter != null)
                    callPayload.Queries["delimiter"] = ExpressionConverter.Convert(delimiter);
                if (prefix != null)
                    callPayload.Queries["prefix"] = ExpressionConverter.Convert(prefix);
                if (encodingType != null)
                    callPayload.Queries["encoding-type"] = ExpressionConverter.Convert(encodingType);
                if (fetchOwner != null)
                    callPayload.Queries["fetch-owner"] = ExpressionConverter.Convert(fetchOwner);
                if (maxKeys != null)
                    callPayload.Queries["max-keys"] = ExpressionConverter.Convert(maxKeys);
                if (startAfter != null)
                    callPayload.Queries["start-after"] = ExpressionConverter.Convert(startAfter);
                return new ApiConnectionAction<ListObjectsS3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteObjectS3))]
        public IWorkflowAction DeleteObjectS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteObjectS3(WorkflowExpression<string> region, WorkflowExpression<string> bucket, WorkflowExpression<string> key)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bucket, nameof(bucket), required: true);
            WorkflowExpression.Validate(key, nameof(key), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(region, 1), ExpressionConverter.ConvertWithUrlEncoding(bucket, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [WorkflowExpressionFactory(nameof(__BuildGetObjectS3))]
        public IWorkflowAction GetObjectS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetObjectS3(WorkflowExpression<string> region, WorkflowExpression<string> bucket, WorkflowExpression<string> key)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bucket, nameof(bucket), required: true);
            WorkflowExpression.Validate(key, nameof(key), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(region, 1), ExpressionConverter.ConvertWithUrlEncoding(bucket, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [WorkflowExpressionFactory(nameof(__BuildPutObjectS3))]
        public IWorkflowAction PutObjectS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutObjectS3(WorkflowExpression<string> region, WorkflowExpression<string> bucket, WorkflowExpression<string> key, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(region, nameof(region), required: true);
            WorkflowExpression.Validate(bucket, nameof(bucket), required: true);
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(region, 1), ExpressionConverter.ConvertWithUrlEncoding(bucket, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
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