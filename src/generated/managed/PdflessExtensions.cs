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
        public IBodyWorkflowAction<PDFDtoApiResult> CreatePDF(Expression<Func<string>> version, Expression<Func<string>> commandtemplateId, Expression<Func<string>> commandpayload, Expression<Func<string>> commandreferenceId = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_commandtemplateId = WorkflowExpression.Compile(commandtemplateId, nameof(commandtemplateId), required: true);
            var __workflow_commandpayload = WorkflowExpression.Compile(commandpayload, nameof(commandpayload), required: true);
            var __workflow_commandreferenceId = WorkflowExpression.Compile(commandreferenceId, nameof(commandreferenceId), required: false);
            return new DeferredBodyAction<PDFDtoApiResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v{0}/pdfs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var command = new JObject();
                var commandpropCount = 0;
                commandpropCount++;
                command["template_id"] = ExpressionConverter.ConvertO(__workflow_commandtemplateId);
                commandpropCount++;
                command["payload"] = ExpressionConverter.ConvertO(__workflow_commandpayload);
                if (__workflow_commandreferenceId != null)
                {
                    command["reference_id"] = ExpressionConverter.ConvertO(__workflow_commandreferenceId);
                    commandpropCount++;
                }

                if (commandpropCount > 0)
                {
                    callPayload.Body = command;
                }

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
