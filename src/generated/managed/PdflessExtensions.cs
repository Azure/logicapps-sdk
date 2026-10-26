//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfless
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdflessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfless")]
        public IBodyWorkflowAction<PDFDtoApiResult, ApiConnectionActionConfiguration> CreatePDF(Expression<Func<string>> version, Expression<Func<CreatePDFInput>> command)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_command = WorkflowExpression.Compile(command, nameof(command), required: true);
            return new DeferredBodyAction<PDFDtoApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v{0}/pdfs", __workflow_version.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_command);
                return new ApiConnectionAction<PDFDtoApiResult>(callPayload);
            });
        }
    }

    public class PdflessTriggers([ConnectionName] string connectionId)
    {
    }

    public class PDFDtoApiResult
    {
        [JsonProperty("data")]
        public PDFDto Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PDFDto
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class CreatePDFInput
    {
        [JsonProperty("template_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("payload", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Payload { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfless;

    public partial class WorkflowManagedActions
    {
        public PdflessActions Pdfless(string connectionId) => new PdflessActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdflessTriggers Pdfless(string connectionId) => new PdflessTriggers(connectionId);
    }
}