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
        public IBodyWorkflowAction<ImportJobsPostResponse> ImportJobs([WorkflowExpression] Func<string> batchimportData, [WorkflowExpression] Func<string> batchnameForImport, [WorkflowExpression] Func<string> batchsecurityToken, [WorkflowExpression] Func<batchrPAEnvironmentInput> batchrPAEnvironment)
        {
            SourceExpression.Validate(batchimportData, nameof(batchimportData), required: true);
            SourceExpression.Validate(batchnameForImport, nameof(batchnameForImport), required: true);
            SourceExpression.Validate(batchsecurityToken, nameof(batchsecurityToken), required: true);
            SourceExpression.Validate(batchrPAEnvironment, nameof(batchrPAEnvironment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ImportJobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var batch = new JObject();
                var batchpropCount = 0;
                batchpropCount++;
                batch["Data"] = SourceExpressionConverter.ConvertToken(batchimportData);
                batchpropCount++;
                batch["FileName"] = SourceExpressionConverter.ConvertToken(batchnameForImport);
                batchpropCount++;
                batch["SecurityKey"] = SourceExpressionConverter.ConvertToken(batchsecurityToken);
                batchpropCount++;
                batch["Version"] = SourceExpressionConverter.Convert(batchrPAEnvironment);
                if (batchpropCount > 0)
                {
                    callPayload.Body = batch;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportJobsPostResponse>(BuildSourceInput);
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