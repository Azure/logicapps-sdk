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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListObjectsS3Response> __BuildListObjectsS3(WorkflowValue<string> region, WorkflowValue<string> bucket, WorkflowValue<string> bucketlistType = null, WorkflowValue<string> continuationToken = null, WorkflowValue<string> delimiter = null, WorkflowValue<string> prefix = null, WorkflowValue<string> encodingType = null, WorkflowValue<string> fetchOwner = null, WorkflowValue<double> maxKeys = null, WorkflowValue<string> startAfter = null)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(bucket, nameof(bucket), required: true);
            WorkflowValue.Validate(bucketlistType, nameof(bucketlistType), required: false);
            WorkflowValue.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowValue.Validate(delimiter, nameof(delimiter), required: false);
            WorkflowValue.Validate(prefix, nameof(prefix), required: false);
            WorkflowValue.Validate(encodingType, nameof(encodingType), required: false);
            WorkflowValue.Validate(fetchOwner, nameof(fetchOwner), required: false);
            WorkflowValue.Validate(maxKeys, nameof(maxKeys), required: false);
            WorkflowValue.Validate(startAfter, nameof(startAfter), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteObjectS3(WorkflowValue<string> region, WorkflowValue<string> bucket, WorkflowValue<string> key)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(bucket, nameof(bucket), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetObjectS3(WorkflowValue<string> region, WorkflowValue<string> bucket, WorkflowValue<string> key)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(bucket, nameof(bucket), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutObjectS3(WorkflowValue<string> region, WorkflowValue<string> bucket, WorkflowValue<string> key, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(bucket, nameof(bucket), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
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
