//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfless
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdflessActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfless")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePDF))]
        public IBodyWorkflowAction<PDFDtoApiResult> CreatePDF([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> commandtemplateId, [WorkflowExpression] Func<string> commandpayload, [WorkflowExpression] Func<string> commandreferenceId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfless")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PDFDtoApiResult> __BuildCreatePDF(WorkflowExpression<string> version, WorkflowExpression<string> commandtemplateId, WorkflowExpression<string> commandpayload, WorkflowExpression<string> commandreferenceId = null)
        {
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(commandtemplateId, nameof(commandtemplateId), required: true);
            WorkflowExpression.Validate(commandpayload, nameof(commandpayload), required: true);
            WorkflowExpression.Validate(commandreferenceId, nameof(commandreferenceId), required: false);
            return new DeferredBodyAction<PDFDtoApiResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v{0}/pdfs", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var command = new JObject();
                var commandpropCount = 0;
                commandpropCount++;
                command["template_id"] = ExpressionConverter.ConvertO(commandtemplateId);
                commandpropCount++;
                command["payload"] = ExpressionConverter.ConvertO(commandpayload);
                if (commandreferenceId != null)
                {
                    command["reference_id"] = ExpressionConverter.ConvertO(commandreferenceId);
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