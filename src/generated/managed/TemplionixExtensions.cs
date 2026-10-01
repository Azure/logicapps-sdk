//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Templionix
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TemplionixActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "templionix")]
        public IBodyWorkflowAction<BulkGenerationJobStatusDto[]> GetBulkGenerationJobsByTemplateId([WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/bulkGenerationJobs/byTemplate/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BulkGenerationJobStatusDto[]>(BuildSourceInput);
        }
    }

    public class TemplionixTriggers([ConnectionName] string connectionId)
    {
    }

    public class BulkGenerationJobStatusDto
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("zipUrl")]
        public string ZipUrl { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("failedGenerations")]
        public BulkGenerationFailureItemDto[] FailedGenerations { get; set; }

        [JsonProperty("failedGenerationCount")]
        public int FailedGenerationCount { get; set; }
    }

    public class BulkGenerationFailureItemDto
    {
        [JsonProperty("globalIndex")]
        public string GlobalIndex { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Templionix;

    public partial class WorkflowManagedActions
    {
        public TemplionixActions Templionix(string connectionId) => new TemplionixActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TemplionixTriggers Templionix(string connectionId) => new TemplionixTriggers(connectionId);
    }
}