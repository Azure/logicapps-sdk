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
        public IBodyWorkflowAction<ListObjectsS3Response> ListObjectsS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> bucketlistType = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> delimiter = null, [WorkflowExpression] Func<string> prefix = null, [WorkflowExpression] Func<string> encodingType = null, [WorkflowExpression] Func<string> fetchOwner = null, [WorkflowExpression] Func<double> maxKeys = null, [WorkflowExpression] Func<string> startAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bucketlist-type"] = Convert.ToString("2");
                if (bucketlistType != null)
                    callPayload.Queries["bucketlist-type"] = SourceExpressionConverter.ConvertO(bucketlistType);
                if (continuationToken != null)
                    callPayload.Queries["continuation-token"] = SourceExpressionConverter.ConvertO(continuationToken);
                if (delimiter != null)
                    callPayload.Queries["delimiter"] = SourceExpressionConverter.ConvertO(delimiter);
                if (prefix != null)
                    callPayload.Queries["prefix"] = SourceExpressionConverter.ConvertO(prefix);
                if (encodingType != null)
                    callPayload.Queries["encoding-type"] = SourceExpressionConverter.ConvertO(encodingType);
                if (fetchOwner != null)
                    callPayload.Queries["fetch-owner"] = SourceExpressionConverter.ConvertO(fetchOwner);
                if (maxKeys != null)
                    callPayload.Queries["max-keys"] = SourceExpressionConverter.ConvertO(maxKeys);
                if (startAfter != null)
                    callPayload.Queries["start-after"] = SourceExpressionConverter.ConvertO(startAfter);
                return callPayload;
            }

            return new ApiConnectionAction<ListObjectsS3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction DeleteObjectS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> key)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction GetObjectS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> key)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "amazons3bucket")]
        public IWorkflowAction PutObjectS3([WorkflowExpression] Func<string> region, [WorkflowExpression] Func<string> bucket, [WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/aws/s3/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(region, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bucket, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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