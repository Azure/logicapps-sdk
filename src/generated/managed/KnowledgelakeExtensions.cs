//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgelake
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KnowledgelakeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgelake")]
        [WorkflowExpressionFactory(nameof(__BuildImportJobs))]
        public IBodyWorkflowAction<ImportJobsPostResponse> ImportJobs([WorkflowExpression] Func<string> batchimportData, [WorkflowExpression] Func<string> batchnameForImport, [WorkflowExpression] Func<string> batchsecurityToken, [WorkflowExpression] Func<batchrPAEnvironmentInput> batchrPAEnvironment)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImportJobsPostResponse> __BuildImportJobs(WorkflowExpression<string> batchimportData, WorkflowExpression<string> batchnameForImport, WorkflowExpression<string> batchsecurityToken, WorkflowExpression<batchrPAEnvironmentInput> batchrPAEnvironment)
        {
            WorkflowExpression.Validate(batchimportData, nameof(batchimportData), required: true);
            WorkflowExpression.Validate(batchnameForImport, nameof(batchnameForImport), required: true);
            WorkflowExpression.Validate(batchsecurityToken, nameof(batchsecurityToken), required: true);
            WorkflowExpression.Validate(batchrPAEnvironment, nameof(batchrPAEnvironment), required: true);
            return new DeferredBodyAction<ImportJobsPostResponse>(() =>
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
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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