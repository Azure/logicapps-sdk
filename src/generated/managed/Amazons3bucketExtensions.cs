//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Amazons3bucket
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Amazons3bucketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IBodyWorkflowAction<ListObjectsS3Response> ListObjectsS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> bucketlistType = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> delimiter = null, Expression<Func<string>> prefix = null, Expression<Func<string>> encodingType = null, Expression<Func<string>> fetchOwner = null, Expression<Func<double>> maxKeys = null, Expression<Func<string>> startAfter = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bucketlist-type"] = Convert.ToString("2");
            if (bucketlistType != null)
                callPayload.Queries["bucketlist-type"] = CSharpExpressionConverter.ConvertO(bucketlistType);
            if (continuationToken != null)
                callPayload.Queries["continuation-token"] = CSharpExpressionConverter.ConvertO(continuationToken);
            if (delimiter != null)
                callPayload.Queries["delimiter"] = CSharpExpressionConverter.ConvertO(delimiter);
            if (prefix != null)
                callPayload.Queries["prefix"] = CSharpExpressionConverter.ConvertO(prefix);
            if (encodingType != null)
                callPayload.Queries["encoding-type"] = CSharpExpressionConverter.ConvertO(encodingType);
            if (fetchOwner != null)
                callPayload.Queries["fetch-owner"] = CSharpExpressionConverter.ConvertO(fetchOwner);
            if (maxKeys != null)
                callPayload.Queries["max-keys"] = CSharpExpressionConverter.ConvertO(maxKeys);
            if (startAfter != null)
                callPayload.Queries["start-after"] = CSharpExpressionConverter.ConvertO(startAfter);
            return new ApiConnectionAction<ListObjectsS3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction DeleteObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction GetObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction PutObjectS3(Expression<Func<string>> region, Expression<Func<string>> bucket, Expression<Func<string>> key, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
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