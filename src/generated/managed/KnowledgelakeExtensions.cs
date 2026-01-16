//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgelake
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KnowledgelakeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgelake")]
        public IBodyWorkflowAction<ImportJobsPostResponse> ImportJobsPost(Expression<Func<string>> batchimportData, Expression<Func<string>> batchnameForImport, Expression<Func<string>> batchsecurityToken, Expression<Func<batchrPAEnvironmentInput>> batchrPAEnvironment)
        {
            var apiCallPath = "/ImportJobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var batch = new JObject();
            var batchpropCount = 0;
            batchpropCount++;
            batch["Data"] = ExpressionConverter.ConvertO(batchimportData);
            batchpropCount++;
            batch["FileName"] = ExpressionConverter.ConvertO(batchnameForImport);
            batchpropCount++;
            batch["SecurityKey"] = ExpressionConverter.ConvertO(batchsecurityToken);
            batchpropCount++;
            batch["Version"] = ExpressionConverter.ConvertO(batchrPAEnvironment);
            if (batchpropCount > 0)
            {
                callPayload.Body = batch;
            }

            return new ApiConnectionAction<ImportJobsPostResponse>(callPayload);
        }
    }

    public class KnowledgelakeTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImportJobsPostResponse
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public ImportJobsPostResponseDataType Data { get; set; }
        public string[] Errors { get; set; }
        public bool Success { get; set; }
    }

    public class ImportJobsPostResponseDataType
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public string BlobKey { get; set; }
        public string JobId { get; set; }
    }

    public enum batchrPAEnvironmentInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgelake;

    public partial class WorkflowManagedActions
    {
        public KnowledgelakeActions Knowledgelake(string connectionId) => new KnowledgelakeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KnowledgelakeTriggers Knowledgelake(string connectionId) => new KnowledgelakeTriggers(connectionId);
    }
}