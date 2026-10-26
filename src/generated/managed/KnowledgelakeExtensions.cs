//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgelake
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KnowledgelakeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgelake")]
        public IBodyWorkflowAction<ImportJobsPostResponse, ApiConnectionActionConfiguration> ImportJobs(Expression<Func<ImportJobsPostInput>> batch)
        {
            var __workflow_batch = WorkflowExpression.Compile(batch, nameof(batch), required: true);
            return new DeferredBodyAction<ImportJobsPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ImportJobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_batch);
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

    public class ImportJobsPostInput
    {
        [JsonProperty("Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImportData { get; set; }

        [JsonProperty("FileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NameForImport { get; set; }

        [JsonProperty("SecurityKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecurityToken { get; set; }

        [JsonProperty("Version", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImportJobsPostInputRPAEnvironmentType RPAEnvironment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportJobsPostInputRPAEnvironmentType
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